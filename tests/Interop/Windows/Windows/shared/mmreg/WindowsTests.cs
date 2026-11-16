// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/mmreg.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.CompilerServices;
using static TerraFX.Interop.Windows.Windows;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="Windows" /> class.</summary>
public static unsafe partial class WindowsTests
{
    /// <summary>Validates Multimedia Extensions GUID initialization and inspection helpers.</summary>
    [Test]
    public static void MmregGuidHelpersTest()
    {
        Guid guid = default;

        INIT_MMREG_MID(&guid, 0x1234);
        Assert.That(IS_COMPATIBLE_MMREG_MID(&guid), Is.True);
        Assert.That(EXTRACT_MMREG_MID(&guid), Is.EqualTo((ushort)0x1234));

        INIT_MMREG_PID(&guid, 0x4321);
        Assert.That(IS_COMPATIBLE_MMREG_PID(&guid), Is.True);
        Assert.That(EXTRACT_MMREG_PID(&guid), Is.EqualTo((ushort)0x4321));

        INIT_WAVEFORMATEX_GUID(&guid, 0x1234);
        Assert.That(IS_VALID_WAVEFORMATEX_GUID(&guid), Is.True);
        Assert.That(EXTRACT_WAVEFORMATEX_ID(&guid), Is.EqualTo((ushort)0x1234));
        Guid invalid = Guid.Empty;
        Assert.That(IS_VALID_WAVEFORMATEX_GUID(&invalid), Is.False);
    }

    /// <summary>Validates Windows Media Audio extra-format sizes.</summary>
    [Test]
    public static void WmaudioExtraBytesTest()
    {
        Assert.That(MSAUDIO1_WFX_EXTRA_BYTES, Is.EqualTo((nuint)(Unsafe.SizeOf<MSAUDIO1WAVEFORMAT>() - Unsafe.SizeOf<WAVEFORMATEX>())));
        Assert.That(WMAUDIO2_WFX_EXTRA_BYTES, Is.EqualTo((nuint)(Unsafe.SizeOf<WMAUDIO2WAVEFORMAT>() - Unsafe.SizeOf<WAVEFORMATEX>())));
        Assert.That(WMAUDIO3_WFX_EXTRA_BYTES, Is.EqualTo((nuint)(Unsafe.SizeOf<WMAUDIO3WAVEFORMAT>() - Unsafe.SizeOf<WAVEFORMATEX>())));
    }
}
