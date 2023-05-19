using AmigosFsGestorDocumental.Data.DTOs;
using AmigosFsGestorDocumental.Data.Model;

namespace AmigosFsGestorDocumental.Services.Interfaces
{
    public interface IFileDatabaseService
    {
        /// <summary>
        /// Search files by description param
        /// </summary>
        /// <param name="description"></param>
        /// <returns></returns>
        IEnumerable<FileDatabase> GetFilesByDescription(string description);

        /// <summary>
        /// Get all files
        /// </summary>
        /// <returns></returns>
        IEnumerable<FileDatabase> GetAllFiles();

        /// <summary>
        /// Add new File
        /// </summary>
        /// <param name="file"></param>
        void AddFile(FileDatabaseCreateDto file);

        /// <summary>
        /// UpdateFile
        /// </summary>
        /// <param name="file"></param>
        void UpdateFile(FileDatabaseUpdateDto file);

        /// <summary>
        /// Delete a File
        /// </summary>
        /// <param name="fileId"></param>
        void DeleteFile(Guid fileId);

        /// <summary>
        /// Get Files By Id
        /// </summary>
        /// <param name="fileId"></param>
        /// <returns></returns>
        FileDatabase GetFilesById(Guid fileId);
    }
}
