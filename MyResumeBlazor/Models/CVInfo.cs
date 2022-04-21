namespace MyResumeBlazor
{
    /// <summary>
    /// CV Information
    /// </summary>
    public class CVInfo
    {
        /// <summary>
        /// Awards
        /// </summary>
        public AwardData[]? Awards { get; set; }

        /// <summary>
        /// Certificates
        /// </summary>
        public CertificateData[]? Certificates { get; set; }

        /// <summary>
        /// Diplomas
        /// </summary>
        public DiplomaData[]? Diplomas { get; set; }

        /// <summary>
        /// The experience
        /// </summary>
        public ExperienceDataYear[]? Experience { get; set; }

        /// <summary>
        /// Languages
        /// </summary>
        public LanguageData[]? Languages { get; set; }

        /// <summary>
        /// Personal information
        /// </summary>
        public PersonalInfo? Personal { get; set; }

        /// <summary>
        /// Portfolio
        /// </summary>
        public PortfolioDataYear[]? Portfolio { get; set; }

        /// <summary>
        /// Skills
        /// </summary>
        public SkillDataGroup[]? Skills { get; set; }
    }
}
