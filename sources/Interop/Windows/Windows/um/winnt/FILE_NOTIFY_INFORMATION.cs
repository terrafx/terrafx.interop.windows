// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='FILE_NOTIFY_INFORMATION.xml' path='doc/member[@name="FILE_NOTIFY_INFORMATION"]/*' />
public partial struct FILE_NOTIFY_INFORMATION
{
    /// <include file='FILE_NOTIFY_INFORMATION.xml' path='doc/member[@name="FILE_NOTIFY_INFORMATION.NextEntryOffset"]/*' />
    [NativeTypeName("DWORD")]
    public uint NextEntryOffset;

    /// <include file='FILE_NOTIFY_INFORMATION.xml' path='doc/member[@name="FILE_NOTIFY_INFORMATION.Action"]/*' />
    [NativeTypeName("DWORD")]
    public uint Action;

    /// <include file='FILE_NOTIFY_INFORMATION.xml' path='doc/member[@name="FILE_NOTIFY_INFORMATION.FileNameLength"]/*' />
    [NativeTypeName("DWORD")]
    public uint FileNameLength;

    /// <include file='FILE_NOTIFY_INFORMATION.xml' path='doc/member[@name="FILE_NOTIFY_INFORMATION.FileName"]/*' />
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
