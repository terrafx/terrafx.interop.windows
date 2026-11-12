// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System.Runtime.Versioning;
using NUnit.Framework;

namespace TerraFX.Interop.DirectX.UnitTests;

/// <summary>Validates the composition target identifier equality operators.</summary>
[SupportedOSPlatform("windows10.0.22000.0")]
public static class COMPOSITION_TARGET_IDManualTests
{
    /// <summary>A zero unique identifier matches any identifier when all other fields match.</summary>
    [Test]
    public static void EqualityTreatsZeroUniqueIdAsWildcard()
    {
        COMPOSITION_TARGET_ID lhs = new()
        {
            uniqueId = 0,
            vidPnSourceId = 1,
            vidPnTargetId = 2,
        };
        COMPOSITION_TARGET_ID rhs = lhs;
        rhs.uniqueId = 7;

        Assert.That(lhs == rhs, Is.True);
        Assert.That(lhs != rhs, Is.False);
        Assert.That(lhs.Equals(rhs), Is.True);
        Assert.That(lhs.GetHashCode(), Is.EqualTo(rhs.GetHashCode()));

        rhs.uniqueId = 0;
        rhs.vidPnTargetId++;

        Assert.That(lhs == rhs, Is.False);
        Assert.That(lhs != rhs, Is.True);
    }
}
