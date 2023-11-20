using System.Collections.Frozen;
using System.Collections.Immutable;

namespace CS2Internal;

public static class Boners
{
    public static readonly FrozenDictionary<string, int> BoneOffsetMap = new Dictionary<string, int>()
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
    }.ToFrozenDictionary();

    public static readonly ImmutableArray<(string Bone1, string Bone2)> BoneConnections = new[] {
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
    }.ToImmutableArray();
}