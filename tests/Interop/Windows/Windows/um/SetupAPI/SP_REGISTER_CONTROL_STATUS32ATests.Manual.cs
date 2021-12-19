// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="SP_REGISTER_CONTROL_STATUS32A" /> struct.</summary>
public static unsafe partial class SP_REGISTER_CONTROL_STATUS32ATests
{
    /// <summary>Validates that the <see cref="SP_REGISTER_CONTROL_STATUS32A" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<SP_REGISTER_CONTROL_STATUS32A>(), Is.EqualTo(sizeof(SP_REGISTER_CONTROL_STATUS32A)));
    }

    /// <summary>Validates that the <see cref="SP_REGISTER_CONTROL_STATUS32A" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SP_REGISTER_CONTROL_STATUS32A).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="SP_REGISTER_CONTROL_STATUS32A" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(SP_REGISTER_CONTROL_STATUS32A), Is.EqualTo(20));
        }
        else
        {
            Assert.That(sizeof(SP_REGISTER_CONTROL_STATUS32A), Is.EqualTo(16));
        }
    }
}
