// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="CABINET_INFO32_A" /> struct.</summary>
public static unsafe partial class CABINET_INFO32_ATests
{
    /// <summary>Validates that the <see cref="CABINET_INFO32_A" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<CABINET_INFO32_A>(), Is.EqualTo(sizeof(CABINET_INFO32_A)));
    }

    /// <summary>Validates that the <see cref="CABINET_INFO32_A" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(CABINET_INFO32_A).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="CABINET_INFO32_A" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(CABINET_INFO32_A), Is.EqualTo(28));
        }
        else
        {
            Assert.That(sizeof(CABINET_INFO32_A), Is.EqualTo(16));
        }
    }
}
