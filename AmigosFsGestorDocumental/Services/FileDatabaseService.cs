using AmigosFsGestorDocumental.Data.DTOs;
using AmigosFsGestorDocumental.Data.Model;
using AmigosFsGestorDocumental.Services.Interfaces;
using Dapper;
using Microsoft.Data.SqlClient;

namespace AmigosFsGestorDocumental.Services
{
    public class FileDatabaseService : IFileDatabaseService
    {
        #region  CONSTANTS
        private readonly string _connectionString = @"Server=tcp:amigosfsserver.database.windows.net,1433;Initial Catalog=amigosfs;Persist Security Info=False;User ID=amigosfs;Password=@migosFs4!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        #endregion
        
        /// <summary>
        /// Constructor
        /// </summary>
        public FileDatabaseService()
        {

        }

        /// <summary>
        /// Get files by description
        /// </summary>
        /// <param name="description">Search param</param>
        /// <returns></returns>
        public IEnumerable<FileDatabase> GetFilesByDescription(string description)
        {
            var connection = new SqlConnection(_connectionString);
            var query = $"Select * from FileDatabase where Description like '%{description}%'";
            var jobModel = connection.Query<FileDatabase>(query);

            return jobModel;
        }

        public FileDatabase GetFilesById(Guid fileId)
        {
            var connection = new SqlConnection(_connectionString);
            var query = $"Select * from FileDatabase where Id = '{fileId}'";
            var jobModel = connection.Query<FileDatabase>(query);

            return jobModel.FirstOrDefault();
        }

        /// <summary>
        /// Get all files
        /// </summary>
        /// <returns></returns>
        public IEnumerable<FileDatabase> GetAllFiles()
        {
            var connection = new SqlConnection(_connectionString);
            var query = "Select * from FileDatabase";
            var jobModel = connection.Query<FileDatabase>(query);

            return jobModel;
        }

        /// <summary>
        /// Add a new file
        /// </summary>
        /// <param name="file"></param>
        public void AddFile(FileDatabaseCreateDto file)
        {
            var connection = new SqlConnection(_connectionString);
            var query = $@"INSERT INTO FileDatabase (Id, FileName, Name, Description, Content, Created) VALUES ('{Guid.NewGuid()}',
                    '{file.FileName}','{file.Name}','{file.Description}','{file.Content}','{DateTime.Now}');";
            connection.Query<FileDatabase>(query);
        }

        /// <summary>
        /// Update a file
        /// </summary>
        /// <param name="file"></param>
        public void UpdateFile(FileDatabaseUpdateDto file)
        {
            var connection = new SqlConnection(_connectionString);
            var query = $@"UPDATE FileDatabase SET 
                    FileName='{file.FileName}', Name='{file.Name}', Description='{file.Description}' WHERE Id='{file.Id}';";
            connection.Query<FileDatabase>(query);
        }

        /// <summary>
        /// Delete a file
        /// </summary>
        /// <param name="fileId"></param>
        public void DeleteFile(Guid fileId)
        {
            var connection = new SqlConnection(_connectionString);
            var query = $@"DELETE FROM FileDatabase WHERE Id='{fileId}';";
            connection.Query<FileDatabase>(query);
        }
    }
}
