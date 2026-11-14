// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;
using NUnit.Framework;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="PROPERTYKEY"/> value type.</summary>
public static partial class PROPERTYKEYTests
{
    /// <summary>Validates equality by format identifier and property identifier.</summary>
    [Test]
    public static void EqualityTest()
    {
        PROPERTYKEY key = new()
        {
            fmtid = new Guid("00112233-4455-6677-8899-aabbccddeeff"),
            pid = 1,
        };
        PROPERTYKEY sameKey = key;
        PROPERTYKEY differentPid = key;
        differentPid.pid = 2;
        PROPERTYKEY differentFormat = key;
        differentFormat.fmtid = new Guid("ffeeddcc-bbaa-9988-7766-554433221100");

        Assert.That(Windows.IsEqualPropertyKey(key, sameKey), Is.EqualTo(1));
        Assert.That(Windows.IsEqualPropertyKey(key, differentPid), Is.EqualTo(0));
        Assert.That(Windows.IsEqualPropertyKey(key, differentFormat), Is.EqualTo(0));
        Assert.That(key == sameKey, Is.True);
        Assert.That(key != differentPid, Is.True);
        Assert.That(key != differentFormat, Is.True);
        Assert.That(key.Equals(sameKey), Is.True);
        Assert.That(key.GetHashCode(), Is.EqualTo(sameKey.GetHashCode()));
    }
}
