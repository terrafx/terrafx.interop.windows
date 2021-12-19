// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="INFCONTEXT32" /> struct.</summary>
public static unsafe partial class INFCONTEXT32Tests
{
    /// <summary>Validates that the <see cref="INFCONTEXT32" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<INFCONTEXT32>(), Is.EqualTo(sizeof(INFCONTEXT32)));
    }

    /// <summary>Validates that the <see cref="INFCONTEXT32" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(INFCONTEXT32).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="INFCONTEXT32" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(INFCONTEXT32), Is.EqualTo(24));
        }
        else
        {
            Assert.That(sizeof(INFCONTEXT32), Is.EqualTo(16));
        }
    }
}
