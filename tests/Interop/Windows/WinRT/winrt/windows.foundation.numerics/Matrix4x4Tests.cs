// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.foundation.numerics.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.WinRT.UnitTests;

/// <summary>Provides validation of the <see cref="Matrix4x4" /> struct.</summary>
public static unsafe partial class Matrix4x4Tests
{
    /// <summary>Validates that the <see cref="Matrix4x4" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<Matrix4x4>(), Is.EqualTo(sizeof(Matrix4x4)));
    }

    /// <summary>Validates that the <see cref="Matrix4x4" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(Matrix4x4).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="Matrix4x4" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(Matrix4x4), Is.EqualTo(64));
    }
}
