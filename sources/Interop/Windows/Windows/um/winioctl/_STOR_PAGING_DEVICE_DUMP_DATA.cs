// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='_STOR_PAGING_DEVICE_DUMP_DATA.xml' path='doc/member[@name="_STOR_PAGING_DEVICE_DUMP_DATA"]/*' />
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct _STOR_PAGING_DEVICE_DUMP_DATA
{
    /// <include file='_STOR_PAGING_DEVICE_DUMP_DATA.xml' path='doc/member[@name="_STOR_PAGING_DEVICE_DUMP_DATA.Descriptor"]/*' />
    public DEVICEDUMP_STRUCTURE_VERSION Descriptor;

    /// <include file='_STOR_PAGING_DEVICE_DUMP_DATA.xml' path='doc/member[@name="_STOR_PAGING_DEVICE_DUMP_DATA.EntryCount"]/*' />
    [NativeTypeName("DWORD")]
    public uint EntryCount;

    /// <include file='_STOR_PAGING_DEVICE_DUMP_DATA.xml' path='doc/member[@name="_STOR_PAGING_DEVICE_DUMP_DATA.EntrySize"]/*' />
    [NativeTypeName("DWORD")]
    public uint EntrySize;

    /// <include file='_STOR_PAGING_DEVICE_DUMP_DATA.xml' path='doc/member[@name="_STOR_PAGING_DEVICE_DUMP_DATA.Entries"]/*' />
    [NativeTypeName("STOR_PAGING_DEVICE_DUMP_ENTRY[1]")]
    public _Entries_e__FixedBuffer Entries;

    /// <include file='_Entries_e__FixedBuffer.xml' path='doc/member[@name="_Entries_e__FixedBuffer"]/*' />
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _Entries_e__FixedBuffer
    {
        public _STOR_PAGING_DEVICE_DUMP_ENTRY e0;

        [UnscopedRef]
        public ref _STOR_PAGING_DEVICE_DUMP_ENTRY this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Unsafe.Add(ref e0, index);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<_STOR_PAGING_DEVICE_DUMP_ENTRY> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}
