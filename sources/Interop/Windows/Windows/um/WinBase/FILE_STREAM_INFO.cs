// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='FILE_STREAM_INFO.xml' path='doc/member[@name="FILE_STREAM_INFO"]/*' />
public partial struct FILE_STREAM_INFO
{
    /// <include file='FILE_STREAM_INFO.xml' path='doc/member[@name="FILE_STREAM_INFO.NextEntryOffset"]/*' />
    [NativeTypeName("DWORD")]
    public uint NextEntryOffset;

    /// <include file='FILE_STREAM_INFO.xml' path='doc/member[@name="FILE_STREAM_INFO.StreamNameLength"]/*' />
    [NativeTypeName("DWORD")]
    public uint StreamNameLength;

    /// <include file='FILE_STREAM_INFO.xml' path='doc/member[@name="FILE_STREAM_INFO.StreamSize"]/*' />
    public LARGE_INTEGER StreamSize;

    /// <include file='FILE_STREAM_INFO.xml' path='doc/member[@name="FILE_STREAM_INFO.StreamAllocationSize"]/*' />
    public LARGE_INTEGER StreamAllocationSize;

    /// <include file='FILE_STREAM_INFO.xml' path='doc/member[@name="FILE_STREAM_INFO.StreamName"]/*' />
    [NativeTypeName("WCHAR[1]")]
    public _StreamName_e__FixedBuffer StreamName;

    /// <include file='_StreamName_e__FixedBuffer.xml' path='doc/member[@name="_StreamName_e__FixedBuffer"]/*' />
    public partial struct _StreamName_e__FixedBuffer
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
