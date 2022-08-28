// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/shellapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="SHFILEINFO64A" /> struct.</summary>
public static unsafe partial class SHFILEINFO64ATests
{
    /// <summary>Validates that the <see cref="SHFILEINFO64A" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<SHFILEINFO64A>(), Is.EqualTo(sizeof(SHFILEINFO64A)));
    }

    /// <summary>Validates that the <see cref="SHFILEINFO64A" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SHFILEINFO64A).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="SHFILEINFO64A" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(SHFILEINFO64A), Is.EqualTo(360));
        }
        else
        {
            Assert.That(sizeof(SHFILEINFO64A), Is.EqualTo(352));
        }
    }
}
