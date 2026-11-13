// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/mmreg.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Buffers.Binary;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

public static unsafe partial class Windows
{
    public static void INIT_MMREG_MID([NativeTypeName("GUID *")] Guid* guid, [NativeTypeName("USHORT")] ushort id)
        => *guid = new Guid(unchecked((int)(0xd5a47fa7u + id)), 0x6d98, 0x11d1, 0xa2, 0x1a, 0x00, 0xa0, 0xc9, 0x22, 0x31, 0x96);

    public static ushort EXTRACT_MMREG_MID([NativeTypeName("const GUID *")] Guid* guid)
        => unchecked((ushort)(ReadGuidData1(guid) - 0xd5a47fa7u));

    public static bool IS_COMPATIBLE_MMREG_MID([NativeTypeName("const GUID *")] Guid* guid)
        => IsCompatibleMmregGuid(guid, 0xd5a47fa7u, 0x6d98);

    public static void INIT_MMREG_PID([NativeTypeName("GUID *")] Guid* guid, [NativeTypeName("USHORT")] ushort id)
        => *guid = new Guid(unchecked((int)(0xe36dc2acu + id)), 0x6d9a, 0x11d1, 0xa2, 0x1a, 0x00, 0xa0, 0xc9, 0x22, 0x31, 0x96);

    public static ushort EXTRACT_MMREG_PID([NativeTypeName("const GUID *")] Guid* guid)
        => unchecked((ushort)(ReadGuidData1(guid) - 0xe36dc2acu));

    public static bool IS_COMPATIBLE_MMREG_PID([NativeTypeName("const GUID *")] Guid* guid)
        => IsCompatibleMmregGuid(guid, 0xe36dc2acu, 0x6d9a);

    public static void INIT_WAVEFORMATEX_GUID([NativeTypeName("GUID *")] Guid* guid, [NativeTypeName("USHORT")] ushort format)
        => *guid = new Guid(format, 0, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

    public static ushort EXTRACT_WAVEFORMATEX_ID([NativeTypeName("const GUID *")] Guid* guid)
    {
        Span<byte> bytes = stackalloc byte[16];
        guid->TryWriteBytes(bytes);
        return BinaryPrimitives.ReadUInt16LittleEndian(bytes);
    }

    public static bool IS_VALID_WAVEFORMATEX_GUID([NativeTypeName("const GUID *")] Guid* guid)
    {
        Span<byte> expected = stackalloc byte[16];
        Span<byte> actual = stackalloc byte[16];
        IID_KSDATAFORMAT_SUBTYPE_WAVEFORMATEX.TryWriteBytes(expected);
        guid->TryWriteBytes(actual);
        return expected[2..].SequenceEqual(actual[2..]);
    }

    public static nuint MSAUDIO1_WFX_EXTRA_BYTES => (nuint)(sizeof(MSAUDIO1WAVEFORMAT) - sizeof(WAVEFORMATEX));

    public static nuint WMAUDIO2_WFX_EXTRA_BYTES => (nuint)(sizeof(WMAUDIO2WAVEFORMAT) - sizeof(WAVEFORMATEX));

    public static nuint WMAUDIO3_WFX_EXTRA_BYTES => (nuint)(sizeof(WMAUDIO3WAVEFORMAT) - sizeof(WAVEFORMATEX));

    private static uint ReadGuidData1(Guid* guid)
    {
        Span<byte> bytes = stackalloc byte[16];
        guid->TryWriteBytes(bytes);
        return BinaryPrimitives.ReadUInt32LittleEndian(bytes);
    }

    private static bool IsCompatibleMmregGuid(Guid* guid, uint data1Base, ushort data2)
    {
        Span<byte> bytes = stackalloc byte[16];
        guid->TryWriteBytes(bytes);

        uint data1 = BinaryPrimitives.ReadUInt32LittleEndian(bytes);

        return (data1 >= data1Base)
            && (data1 < (data1Base + 0xffff))
            && (BinaryPrimitives.ReadUInt16LittleEndian(bytes[4..]) == data2)
            && (BinaryPrimitives.ReadUInt16LittleEndian(bytes[6..]) == 0x11d1)
            && (bytes[8] == 0xa2)
            && (bytes[9] == 0x1a)
            && (bytes[10] == 0x00)
            && (bytes[11] == 0xa0)
            && (bytes[12] == 0xc9)
            && (bytes[13] == 0x22)
            && (bytes[14] == 0x31)
            && (bytes[15] == 0x96);
    }
}
