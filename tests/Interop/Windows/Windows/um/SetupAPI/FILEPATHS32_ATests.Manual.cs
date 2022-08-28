// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="FILEPATHS32_A" /> struct.</summary>
public static unsafe partial class FILEPATHS32_ATests
{
    /// <summary>Validates that the <see cref="FILEPATHS32_A" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<FILEPATHS32_A>(), Is.EqualTo(sizeof(FILEPATHS32_A)));
    }

    /// <summary>Validates that the <see cref="FILEPATHS32_A" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(FILEPATHS32_A).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="FILEPATHS32_A" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(FILEPATHS32_A), Is.EqualTo(24));
        }
        else
        {
            Assert.That(sizeof(FILEPATHS32_A), Is.EqualTo(16));
        }
    }
}
