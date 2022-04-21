namespace MyResumeBlazor
{
    public class SkillDataGroup
    {
        /// <summary>
        /// Skill key
        /// </summary>
        public string? Key { get; set; }

        /// <summary>
        /// Kill name
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// Skills
        /// </summary>
        public SkillDataItem[]? Items { get; set; }
    }
}
