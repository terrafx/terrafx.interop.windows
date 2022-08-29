// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/hidpi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="HIDP_EXTENDED_ATTRIBUTES" /> struct.</summary>
public static unsafe partial class HIDP_EXTENDED_ATTRIBUTESTests
{
    /// <summary>Validates that the <see cref="HIDP_EXTENDED_ATTRIBUTES" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<HIDP_EXTENDED_ATTRIBUTES>(), Is.EqualTo(sizeof(HIDP_EXTENDED_ATTRIBUTES)));
    }

    /// <summary>Validates that the <see cref="HIDP_EXTENDED_ATTRIBUTES" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(HIDP_EXTENDED_ATTRIBUTES).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="HIDP_EXTENDED_ATTRIBUTES" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(HIDP_EXTENDED_ATTRIBUTES), Is.EqualTo(16));
        }
        else
        {
            Assert.That(sizeof(HIDP_EXTENDED_ATTRIBUTES), Is.EqualTo(12));
        }
    }
}
