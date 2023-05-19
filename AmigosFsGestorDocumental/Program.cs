using AmigosFsGestorDocumental;
using AmigosFsGestorDocumental.Data.DTOs;
using AmigosFsGestorDocumental.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

builder.Configure();

var app = builder.Build();

//app.MapGet("/", () => "Hello World!");

#region FileDatabase
app.MapGet("filedatabase", (IFileDatabaseService service) =>
{
    var result = service.GetAllFiles();
    return Results.Ok(result);
});

app.MapGet("filedatabase/{description}/fileByDescription", (IFileDatabaseService service, string description) =>
{
    var result = service.GetFilesByDescription(description);
    return Results.Ok(result);
});

app.MapGet("filedatabase/{id}/fileById", (IFileDatabaseService service, Guid id) =>
{
    var result = service.GetFilesById(id);
    if (result == null)
    {
        return Results.NotFound();
    }
    return Results.Ok(result);
});

app.MapPost("filedatabase", (IFileDatabaseService service, FileDatabaseCreateDto dto) =>
{
    service.AddFile(dto);
    return Results.Ok();
});

app.MapPut("filedatabase", (IFileDatabaseService service, FileDatabaseUpdateDto dto) =>
{
    service.UpdateFile(dto);
    return Results.Ok();
});

app.MapDelete("filedatabase/{fileId}", (IFileDatabaseService service, Guid fileId) =>
{
    service.DeleteFile(fileId);
    return Results.Ok();
});


#endregion

app.UseSwagger();
app.UseSwaggerUI();

app.Run();
