namespace NetEscapades.EnumGenerators;

public readonly struct EnumToGenerate
{
    public readonly string Name;
    public readonly string FullyQualifiedName;
    public readonly string Namespace;
    public readonly bool IsPublic;
    public readonly bool HasFlags;
    public readonly string UnderlyingType;
    public readonly List<KeyValuePair<string, object>> Values;
    public readonly Dictionary<string, string> AttrKeyValuePairs;

    public EnumToGenerate(
    string name,
    string ns,
    string fullyQualifiedName,
    string underlyingType,
    bool isPublic,
    List<KeyValuePair<string, object>> values,
    bool hasFlags,
    Dictionary<string, string> attrKeyValuePairs)
    {
        Name = name;
        Namespace = ns;
        UnderlyingType = underlyingType;
        Values = values;
        HasFlags = hasFlags;
        IsPublic = isPublic;
        FullyQualifiedName = fullyQualifiedName;
        AttrKeyValuePairs = attrKeyValuePairs;
    }
}