// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='SCM_PD_FIRMWARE_DOWNLOAD.xml' path='doc/member[@name="SCM_PD_FIRMWARE_DOWNLOAD"]/*' />
public partial struct SCM_PD_FIRMWARE_DOWNLOAD
{
    /// <include file='SCM_PD_FIRMWARE_DOWNLOAD.xml' path='doc/member[@name="SCM_PD_FIRMWARE_DOWNLOAD.Version"]/*' />
    [NativeTypeName("DWORD")]
    public uint Version;

    /// <include file='SCM_PD_FIRMWARE_DOWNLOAD.xml' path='doc/member[@name="SCM_PD_FIRMWARE_DOWNLOAD.Size"]/*' />
    [NativeTypeName("DWORD")]
    public uint Size;

    /// <include file='SCM_PD_FIRMWARE_DOWNLOAD.xml' path='doc/member[@name="SCM_PD_FIRMWARE_DOWNLOAD.Flags"]/*' />
    [NativeTypeName("DWORD")]
    public uint Flags;

    /// <include file='SCM_PD_FIRMWARE_DOWNLOAD.xml' path='doc/member[@name="SCM_PD_FIRMWARE_DOWNLOAD.Slot"]/*' />
    public byte Slot;

    /// <include file='SCM_PD_FIRMWARE_DOWNLOAD.xml' path='doc/member[@name="SCM_PD_FIRMWARE_DOWNLOAD.Reserved"]/*' />
    [NativeTypeName("BYTE[3]")]
    public _Reserved_e__FixedBuffer Reserved;

    /// <include file='SCM_PD_FIRMWARE_DOWNLOAD.xml' path='doc/member[@name="SCM_PD_FIRMWARE_DOWNLOAD.Offset"]/*' />
    [NativeTypeName("DWORD64")]
    public ulong Offset;

    /// <include file='SCM_PD_FIRMWARE_DOWNLOAD.xml' path='doc/member[@name="SCM_PD_FIRMWARE_DOWNLOAD.FirmwareImageSizeInBytes"]/*' />
    [NativeTypeName("DWORD")]
    public uint FirmwareImageSizeInBytes;

    /// <include file='SCM_PD_FIRMWARE_DOWNLOAD.xml' path='doc/member[@name="SCM_PD_FIRMWARE_DOWNLOAD.FirmwareImage"]/*' />
    [NativeTypeName("BYTE[1]")]
    public _FirmwareImage_e__FixedBuffer FirmwareImage;

    /// <include file='_Reserved_e__FixedBuffer.xml' path='doc/member[@name="_Reserved_e__FixedBuffer"]/*' />
    [InlineArray(3)]
    public partial struct _Reserved_e__FixedBuffer
    {
        public byte e0;
    }

    /// <include file='_FirmwareImage_e__FixedBuffer.xml' path='doc/member[@name="_FirmwareImage_e__FixedBuffer"]/*' />
    public partial struct _FirmwareImage_e__FixedBuffer
    {
        public byte e0;

        [UnscopedRef]
        public ref byte this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Unsafe.Add(ref e0, index);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<byte> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}
