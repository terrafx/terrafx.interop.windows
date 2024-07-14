// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='DEVICE_DSM_LOST_QUERY_OUTPUT.xml' path='doc/member[@name="DEVICE_DSM_LOST_QUERY_OUTPUT"]/*' />
public partial struct DEVICE_DSM_LOST_QUERY_OUTPUT
{
    /// <include file='DEVICE_DSM_LOST_QUERY_OUTPUT.xml' path='doc/member[@name="DEVICE_DSM_LOST_QUERY_OUTPUT.Version"]/*' />
    [NativeTypeName("DWORD")]
    public uint Version;

    /// <include file='DEVICE_DSM_LOST_QUERY_OUTPUT.xml' path='doc/member[@name="DEVICE_DSM_LOST_QUERY_OUTPUT.Size"]/*' />
    [NativeTypeName("DWORD")]
    public uint Size;

    /// <include file='DEVICE_DSM_LOST_QUERY_OUTPUT.xml' path='doc/member[@name="DEVICE_DSM_LOST_QUERY_OUTPUT.Alignment"]/*' />
    [NativeTypeName("DWORDLONG")]
    public ulong Alignment;

    /// <include file='DEVICE_DSM_LOST_QUERY_OUTPUT.xml' path='doc/member[@name="DEVICE_DSM_LOST_QUERY_OUTPUT.NumberOfBits"]/*' />
    [NativeTypeName("DWORD")]
    public uint NumberOfBits;

    /// <include file='DEVICE_DSM_LOST_QUERY_OUTPUT.xml' path='doc/member[@name="DEVICE_DSM_LOST_QUERY_OUTPUT.BitMap"]/*' />
    [NativeTypeName("DWORD[1]")]
    public _BitMap_e__FixedBuffer BitMap;

    /// <include file='_BitMap_e__FixedBuffer.xml' path='doc/member[@name="_BitMap_e__FixedBuffer"]/*' />
    public partial struct _BitMap_e__FixedBuffer
    {
        public uint e0;

        [UnscopedRef]
        public ref uint this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Unsafe.Add(ref e0, index);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<uint> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}
