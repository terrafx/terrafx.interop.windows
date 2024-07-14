// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='FILE_PREFETCH.xml' path='doc/member[@name="FILE_PREFETCH"]/*' />
public partial struct FILE_PREFETCH
{
    /// <include file='FILE_PREFETCH.xml' path='doc/member[@name="FILE_PREFETCH.Type"]/*' />
    [NativeTypeName("DWORD")]
    public uint Type;

    /// <include file='FILE_PREFETCH.xml' path='doc/member[@name="FILE_PREFETCH.Count"]/*' />
    [NativeTypeName("DWORD")]
    public uint Count;

    /// <include file='FILE_PREFETCH.xml' path='doc/member[@name="FILE_PREFETCH.Prefetch"]/*' />
    [NativeTypeName("DWORDLONG[1]")]
    public _Prefetch_e__FixedBuffer Prefetch;

    /// <include file='_Prefetch_e__FixedBuffer.xml' path='doc/member[@name="_Prefetch_e__FixedBuffer"]/*' />
    public partial struct _Prefetch_e__FixedBuffer
    {
        public ulong e0;

        [UnscopedRef]
        public ref ulong this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Unsafe.Add(ref e0, index);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<ulong> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}
