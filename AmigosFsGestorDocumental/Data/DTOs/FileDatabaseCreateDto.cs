namespace AmigosFsGestorDocumental.Data.DTOs
{
    /// <summary>
    /// 
    /// </summary>
    public class FileDatabaseCreateDto
    {
        /// <summary>
        /// File name
        /// </summary>
        public string? FileName { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// Description
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// Download url
        /// </summary>
        public string? Content { get; set; }
    }
}
