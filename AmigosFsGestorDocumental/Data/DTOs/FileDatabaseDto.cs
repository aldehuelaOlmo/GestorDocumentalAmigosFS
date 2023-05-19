namespace AmigosFsGestorDocumental.Data.DTOs
{
    /// <summary>
    /// 
    /// </summary>
    public class FileDatabaseDto
    {
        /// <summary>
        /// File identifier
        /// </summary>
        public Guid Id { get; set; }

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

        /// <summary>
        /// Created file
        /// </summary>
        public DateTime Created { get; set; }
    }
}
