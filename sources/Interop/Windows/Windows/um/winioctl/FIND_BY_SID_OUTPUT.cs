// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='FIND_BY_SID_OUTPUT.xml' path='doc/member[@name="FIND_BY_SID_OUTPUT"]/*' />
public partial struct FIND_BY_SID_OUTPUT
{
    /// <include file='FIND_BY_SID_OUTPUT.xml' path='doc/member[@name="FIND_BY_SID_OUTPUT.NextEntryOffset"]/*' />
    [NativeTypeName("DWORD")]
    public uint NextEntryOffset;

    /// <include file='FIND_BY_SID_OUTPUT.xml' path='doc/member[@name="FIND_BY_SID_OUTPUT.FileIndex"]/*' />
    [NativeTypeName("DWORD")]
    public uint FileIndex;

    /// <include file='FIND_BY_SID_OUTPUT.xml' path='doc/member[@name="FIND_BY_SID_OUTPUT.FileNameLength"]/*' />
    [NativeTypeName("DWORD")]
    public uint FileNameLength;

    /// <include file='FIND_BY_SID_OUTPUT.xml' path='doc/member[@name="FIND_BY_SID_OUTPUT.FileName"]/*' />
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
