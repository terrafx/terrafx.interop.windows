// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/shellapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="OPEN_PRINTER_PROPS_INFO32W" /> struct.</summary>
public static unsafe partial class OPEN_PRINTER_PROPS_INFO32WTests
{
    /// <summary>Validates that the <see cref="OPEN_PRINTER_PROPS_INFO32W" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<OPEN_PRINTER_PROPS_INFO32W>(), Is.EqualTo(sizeof(OPEN_PRINTER_PROPS_INFO32W)));
    }

    /// <summary>Validates that the <see cref="OPEN_PRINTER_PROPS_INFO32W" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(OPEN_PRINTER_PROPS_INFO32W).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="OPEN_PRINTER_PROPS_INFO32W" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(OPEN_PRINTER_PROPS_INFO32W), Is.EqualTo(24));
        }
        else
        {
            Assert.That(sizeof(OPEN_PRINTER_PROPS_INFO32W), Is.EqualTo(20));
        }
    }
}
