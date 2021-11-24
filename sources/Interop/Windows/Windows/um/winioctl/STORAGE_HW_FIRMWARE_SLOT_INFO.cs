// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

public unsafe partial struct STORAGE_HW_FIRMWARE_SLOT_INFO
{
    [NativeTypeName("DWORD")]
    public uint Version;

    [NativeTypeName("DWORD")]
    public uint Size;

    public byte SlotNumber;

    public byte _bitfield;

    [NativeTypeName("byte : 1")]
    public byte ReadOnly
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (byte)(_bitfield & 0x1u);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (byte)((_bitfield & ~0x1u) | (value & 0x1u));
        }
    }

    [NativeTypeName("byte : 7")]
    public byte Reserved0
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (byte)((_bitfield >> 1) & 0x7Fu);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (byte)((_bitfield & ~(0x7Fu << 1)) | ((value & 0x7Fu) << 1));
        }
    }

    [NativeTypeName("BYTE [6]")]
    public fixed byte Reserved1[6];

    [NativeTypeName("BYTE [16]")]
    public fixed byte Revision[16];
}
