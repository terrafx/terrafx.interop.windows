// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/shellapi.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="SHELLEXECUTEINFO64A" /> struct.</summary>
public static unsafe partial class SHELLEXECUTEINFO64ATests
{
    /// <summary>Validates that the <see cref="SHELLEXECUTEINFO64A" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<SHELLEXECUTEINFO64A>(), Is.EqualTo(sizeof(SHELLEXECUTEINFO64A)));
    }

    /// <summary>Validates that the <see cref="SHELLEXECUTEINFO64A" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SHELLEXECUTEINFO64A).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="SHELLEXECUTEINFO64A" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(SHELLEXECUTEINFO64A), Is.EqualTo(112));
        }
        else
        {
            Assert.That(sizeof(SHELLEXECUTEINFO64A), Is.EqualTo(60));
        }
    }
}
