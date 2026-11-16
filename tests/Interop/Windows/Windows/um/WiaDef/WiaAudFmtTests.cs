// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WiaDef.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using static TerraFX.Interop.Windows.WiaAudFmt;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="WiaAudFmt" /> class.</summary>
public static partial class WiaAudFmtTests
{
    /// <summary>Validates that the value of the <see cref="WiaAudFmt_WAV" /> property is correct.</summary>
    [Test]
    public static void WiaAudFmt_WAVTest()
    {
        Assert.That(WiaAudFmt_WAV, Is.EqualTo(new Guid(0xf818e146, 0x07af, 0x40ff, 0xae, 0x55, 0xbe, 0x8f, 0x2c, 0x06, 0x5d, 0xbe)));
    }

    /// <summary>Validates that the value of the <see cref="WiaAudFmt_MP3" /> property is correct.</summary>
    [Test]
    public static void WiaAudFmt_MP3Test()
    {
        Assert.That(WiaAudFmt_MP3, Is.EqualTo(new Guid(0x0fbc71fb, 0x43bf, 0x49f2, 0x91, 0x90, 0xe6, 0xfe, 0xcf, 0xf3, 0x7e, 0x54)));
    }

    /// <summary>Validates that the value of the <see cref="WiaAudFmt_AIFF" /> property is correct.</summary>
    [Test]
    public static void WiaAudFmt_AIFFTest()
    {
        Assert.That(WiaAudFmt_AIFF, Is.EqualTo(new Guid(0x66e2bf4f, 0xb6fc, 0x443f, 0x94, 0xc8, 0x2f, 0x33, 0xc8, 0xa6, 0x5a, 0xaf)));
    }

    /// <summary>Validates that the value of the <see cref="WiaAudFmt_WMA" /> property is correct.</summary>
    [Test]
    public static void WiaAudFmt_WMATest()
    {
        Assert.That(WiaAudFmt_WMA, Is.EqualTo(new Guid(0xd61d6413, 0x8bc2, 0x438f, 0x93, 0xad, 0x21, 0xbd, 0x48, 0x4d, 0xb6, 0xa1)));
    }
}
