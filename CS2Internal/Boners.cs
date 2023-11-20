namespace CS2Internal;

public static class Boners
{
    public static readonly Dictionary<string, int> BoneOffsetMap = new()
    {
        { "head", 6 },
        { "cou", 5 },
        { "shoulderR", 8 },
        { "shoulderL", 13 },
        { "brasR", 9 },
        { "brasL", 14 },
        { "handR", 11 },
        { "handL", 16 },
        { "cock", 0 }, // nice
        { "kneesR", 23 },
        { "kneesL", 26 },
        { "feetR", 24 },
        { "feetL", 27 }
    };

    public static readonly (string Bone1, string Bone2)[] BoneConnections = {
        ("cou", "head"),
        ("cou", "shoulderR"),
        ("cou", "shoulderL"),
        ("brasL", "shoulderL"),
        ("brasR", "shoulderR"),
        ("brasR", "handR"),
        ("brasL", "handL"),
        ("cou", "cock"),
        ("kneesR", "cock"),
        ("kneesL", "cock"),
        ("kneesL", "feetL"),
        ("kneesR", "feetR")
    };
}