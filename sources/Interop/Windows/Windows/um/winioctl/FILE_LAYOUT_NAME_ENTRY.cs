// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='FILE_LAYOUT_NAME_ENTRY.xml' path='doc/member[@name="FILE_LAYOUT_NAME_ENTRY"]/*' />
public partial struct FILE_LAYOUT_NAME_ENTRY
{
    /// <include file='FILE_LAYOUT_NAME_ENTRY.xml' path='doc/member[@name="FILE_LAYOUT_NAME_ENTRY.NextNameOffset"]/*' />
    [NativeTypeName("DWORD")]
    public uint NextNameOffset;

    /// <include file='FILE_LAYOUT_NAME_ENTRY.xml' path='doc/member[@name="FILE_LAYOUT_NAME_ENTRY.Flags"]/*' />
    [NativeTypeName("DWORD")]
    public uint Flags;

    /// <include file='FILE_LAYOUT_NAME_ENTRY.xml' path='doc/member[@name="FILE_LAYOUT_NAME_ENTRY.ParentFileReferenceNumber"]/*' />
    [NativeTypeName("DWORDLONG")]
    public ulong ParentFileReferenceNumber;

    /// <include file='FILE_LAYOUT_NAME_ENTRY.xml' path='doc/member[@name="FILE_LAYOUT_NAME_ENTRY.FileNameLength"]/*' />
    [NativeTypeName("DWORD")]
    public uint FileNameLength;

    /// <include file='FILE_LAYOUT_NAME_ENTRY.xml' path='doc/member[@name="FILE_LAYOUT_NAME_ENTRY.Reserved"]/*' />
    [NativeTypeName("DWORD")]
    public uint Reserved;

    /// <include file='FILE_LAYOUT_NAME_ENTRY.xml' path='doc/member[@name="FILE_LAYOUT_NAME_ENTRY.FileName"]/*' />
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
