namespace MyResumeBlazor
{
    /// <summary>
    /// Experience item
    /// </summary>
    public class ExperienceDataItem
    {
        /// <summary>
        /// The company
        /// </summary>
        public string? Company { get; set; }

        /// <summary>
        /// Company key
        /// </summary>
        public string? CompanyKey { get; set; }

        /// <summary>
        /// Company URL
        /// </summary>
        public string? CompanyUrl { get; set; }

        /// <summary>
        /// The countries
        /// </summary>
        public string[]? Countries { get; set; }

        /// <summary>
        /// The description
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// Position
        /// </summary>
        public string? Position { get; set; }

        /// <summary>
        /// The technologies
        /// </summary>
        public string[]? Technologies { get; set; }

    }
}
