// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='LOOKUP_STREAM_FROM_CLUSTER_ENTRY.xml' path='doc/member[@name="LOOKUP_STREAM_FROM_CLUSTER_ENTRY"]/*' />
public partial struct LOOKUP_STREAM_FROM_CLUSTER_ENTRY
{
    /// <include file='LOOKUP_STREAM_FROM_CLUSTER_ENTRY.xml' path='doc/member[@name="LOOKUP_STREAM_FROM_CLUSTER_ENTRY.OffsetToNext"]/*' />
    [NativeTypeName("DWORD")]
    public uint OffsetToNext;

    /// <include file='LOOKUP_STREAM_FROM_CLUSTER_ENTRY.xml' path='doc/member[@name="LOOKUP_STREAM_FROM_CLUSTER_ENTRY.Flags"]/*' />
    [NativeTypeName("DWORD")]
    public uint Flags;

    /// <include file='LOOKUP_STREAM_FROM_CLUSTER_ENTRY.xml' path='doc/member[@name="LOOKUP_STREAM_FROM_CLUSTER_ENTRY.Reserved"]/*' />
    public LARGE_INTEGER Reserved;

    /// <include file='LOOKUP_STREAM_FROM_CLUSTER_ENTRY.xml' path='doc/member[@name="LOOKUP_STREAM_FROM_CLUSTER_ENTRY.Cluster"]/*' />
    public LARGE_INTEGER Cluster;

    /// <include file='LOOKUP_STREAM_FROM_CLUSTER_ENTRY.xml' path='doc/member[@name="LOOKUP_STREAM_FROM_CLUSTER_ENTRY.FileName"]/*' />
    [NativeTypeName("WCHAR[1]")]
    public _FileName_e__FixedBuffer FileName;

    /// <include file='_FileName_e__FixedBuffer.xml' path='doc/member[@name="_FileName_e__FixedBuffer"]/*' />
    public partial struct _FileName_e__FixedBuffer
    {
        public char e0;

        [UnscopedRef]
        public ref char this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Unsafe.Add(ref e0, index);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<char> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}
