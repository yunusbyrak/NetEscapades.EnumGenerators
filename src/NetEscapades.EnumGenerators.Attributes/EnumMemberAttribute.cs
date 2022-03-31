namespace NetEscapades.EnumGenerators
{
    /// <summary>
    /// Add to enums to indicate that extension methods should be generated for the type
    /// </summary>
    public class EnumMemberAttribute : System.Attribute
    {
        public string? Name { get; set; }
    }
}