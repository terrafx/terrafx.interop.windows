// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/strsafe.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using static TerraFX.Interop.Windows.Windows;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="Windows" /> class.</summary>
public static partial class WindowsTests
{
    /// <summary>Validates the strsafe fill-pattern helper macros.</summary>
    [Test]
    public static void StrSafeFillPatternTest()
    {
        Assert.That(STRSAFE_FILL_BYTE(0x5A), Is.EqualTo(0x0000025A));
        Assert.That(STRSAFE_FAILURE_BYTE(0x5A), Is.EqualTo(0x0000045A));
        Assert.That(STRSAFE_GET_FILL_PATTERN(0x12345678), Is.EqualTo(0x78));
    }

    /// <summary>Validates that the ANSI gets helper preserves extended byte values.</summary>
    [Test]
    public static unsafe void StringGetsWorkerAPreservesExtendedBytes()
    {
        var originalInput = System.Console.In;
        try
        {
            System.Console.SetIn(new System.IO.StringReader("\u00E9"));
            sbyte* destination = stackalloc sbyte[2];
            nuint length = 0;

            Assert.That(StringGetsWorkerA(destination, 2, &length).Value, Is.EqualTo(0));
            Assert.That(destination[0], Is.EqualTo(unchecked((sbyte)0xE9)));
            Assert.That(destination[1], Is.EqualTo((sbyte)'\0'));
            Assert.That(length, Is.EqualTo((nuint)1));
        }
        finally
        {
            System.Console.SetIn(originalInput);
        }
    }
}
