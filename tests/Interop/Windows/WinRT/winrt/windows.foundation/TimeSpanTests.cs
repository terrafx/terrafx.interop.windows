// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.foundation.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.WinRT.UnitTests;

/// <summary>Provides validation of the <see cref="TimeSpan" /> struct.</summary>
public static unsafe partial class TimeSpanTests
{
    /// <summary>Validates that the <see cref="TimeSpan" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<TimeSpan>(), Is.EqualTo(sizeof(TimeSpan)));
    }

    /// <summary>Validates that the <see cref="TimeSpan" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(TimeSpan).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="TimeSpan" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(TimeSpan), Is.EqualTo(8));
    }
}
