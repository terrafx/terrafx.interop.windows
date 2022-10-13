// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.foundation.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.WinRT.UnitTests;

/// <summary>Provides validation of the <see cref="DateTime" /> struct.</summary>
public static unsafe partial class DateTimeTests
{
    /// <summary>Validates that the <see cref="DateTime" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<DateTime>(), Is.EqualTo(sizeof(DateTime)));
    }

    /// <summary>Validates that the <see cref="DateTime" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DateTime).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="DateTime" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(DateTime), Is.EqualTo(8));
    }
}
