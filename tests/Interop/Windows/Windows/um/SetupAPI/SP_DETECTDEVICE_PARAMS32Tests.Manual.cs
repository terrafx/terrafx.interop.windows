// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="SP_DETECTDEVICE_PARAMS32" /> struct.</summary>
public static unsafe partial class SP_DETECTDEVICE_PARAMS32Tests
{
    /// <summary>Validates that the <see cref="SP_DETECTDEVICE_PARAMS32" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<SP_DETECTDEVICE_PARAMS32>(), Is.EqualTo(sizeof(SP_DETECTDEVICE_PARAMS32)));
    }

    /// <summary>Validates that the <see cref="SP_DETECTDEVICE_PARAMS32" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SP_DETECTDEVICE_PARAMS32).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="SP_DETECTDEVICE_PARAMS32" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(SP_DETECTDEVICE_PARAMS32), Is.EqualTo(24));
        }
        else
        {
            Assert.That(sizeof(SP_DETECTDEVICE_PARAMS32), Is.EqualTo(16));
        }
    }
}
