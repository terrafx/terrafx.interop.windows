// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='SD_ENUM_SDS_ENTRY.xml' path='doc/member[@name="SD_ENUM_SDS_ENTRY"]/*' />
public partial struct SD_ENUM_SDS_ENTRY
{
    /// <include file='SD_ENUM_SDS_ENTRY.xml' path='doc/member[@name="SD_ENUM_SDS_ENTRY.Hash"]/*' />
    [NativeTypeName("DWORD")]
    public uint Hash;

    /// <include file='SD_ENUM_SDS_ENTRY.xml' path='doc/member[@name="SD_ENUM_SDS_ENTRY.SecurityId"]/*' />
    [NativeTypeName("DWORD")]
    public uint SecurityId;

    /// <include file='SD_ENUM_SDS_ENTRY.xml' path='doc/member[@name="SD_ENUM_SDS_ENTRY.Offset"]/*' />
    [NativeTypeName("DWORDLONG")]
    public ulong Offset;

    /// <include file='SD_ENUM_SDS_ENTRY.xml' path='doc/member[@name="SD_ENUM_SDS_ENTRY.Length"]/*' />
    [NativeTypeName("DWORD")]
    public uint Length;

    /// <include file='SD_ENUM_SDS_ENTRY.xml' path='doc/member[@name="SD_ENUM_SDS_ENTRY.Descriptor"]/*' />
    [NativeTypeName("BYTE[1]")]
    public _Descriptor_e__FixedBuffer Descriptor;

    /// <include file='_Descriptor_e__FixedBuffer.xml' path='doc/member[@name="_Descriptor_e__FixedBuffer"]/*' />
    public partial struct _Descriptor_e__FixedBuffer
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
