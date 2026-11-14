// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

public static unsafe partial class Windows
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static uint MAKE_MFPROTECTIONDATA_DISABLE(bool Disable)
        => Disable ? 0x00000001u : 0u;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool EXTRACT_MFPROTECTIONDATA_DISABLE_ON(uint Data)
        => (Data & 0x00000001u) != 0;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static uint EXTRACT_MFPROTECTIONDATA_DISABLE_RESERVED(uint Data)
        => (Data & 0xFFFFFFFEu) >> 1;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static uint MAKE_MFPROTECTIONDATA_CONSTRICTAUDIO(uint Level)
        => Level;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static uint EXTRACT_MFPROTECTIONDATA_CONSTRICTAUDIO_LEVEL(uint Data)
        => Data & 0x000000FFu;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static uint EXTRACT_MFPROTECTIONDATA_CONSTRICTAUDIO_RESERVED(uint Data)
        => (Data & 0xFFFFFF00u) >> 8;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static uint MAKE_MFPROTECTIONDATA_TRUSTEDAUDIODRIVERS(bool TestCertificateEnable, bool DigitalOutputDisable, uint DrmLevel)
        => (TestCertificateEnable ? 0x00020000u : 0u)
        | (DigitalOutputDisable ? 0x00010000u : 0u)
        | DrmLevel;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static uint MAKE_MFPROTECTIONDATA_TRUSTEDAUDIODRIVERS2(bool TestCertificateEnable, bool DigitalOutputDisable, bool CopyOK, uint DrmLevel)
        => (TestCertificateEnable ? 0x00020000u : 0u)
        | (DigitalOutputDisable ? 0x00010000u : 0u)
        | (CopyOK ? 0x00040000u : 0u)
        | DrmLevel;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static uint EXTRACT_MFPROTECTIONDATA_TRUSTEDAUDIODRIVERS_DRMLEVEL(uint Data)
        => Data & 0x0000FFFFu;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool EXTRACT_MFPROTECTIONDATA_TRUSTEDAUDIODRIVERS_DIGITALOUTPUTDISABLE(uint Data)
        => (Data & 0x00010000u) != 0;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool EXTRACT_MFPROTECTIONDATA_TRUSTEDAUDIODRIVERS_TESTCERTIFICATEENABLE(uint Data)
        => (Data & 0x00020000u) != 0;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool EXTRACT_MFPROTECTIONDATA_TRUSTEDAUDIODRIVERS_COPYOK(uint Data)
        => (Data & 0x00040000u) != 0;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static uint EXTRACT_MFPROTECTIONDATA_TRUSTEDAUDIODRIVERS_RESERVED(uint Data)
        => (Data & 0xFFF80000u) >> 19;
}
