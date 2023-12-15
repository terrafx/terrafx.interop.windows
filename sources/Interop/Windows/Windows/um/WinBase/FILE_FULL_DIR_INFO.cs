// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;

/// <include file='FILE_FULL_DIR_INFO.xml' path='doc/member[@name="FILE_FULL_DIR_INFO"]/*' />
[SupportedOSPlatform("windows6.2")]
public partial struct FILE_FULL_DIR_INFO
{
    /// <include file='FILE_FULL_DIR_INFO.xml' path='doc/member[@name="FILE_FULL_DIR_INFO.NextEntryOffset"]/*' />
    [NativeTypeName("ULONG")]
    public uint NextEntryOffset;

    /// <include file='FILE_FULL_DIR_INFO.xml' path='doc/member[@name="FILE_FULL_DIR_INFO.FileIndex"]/*' />
    [NativeTypeName("ULONG")]
    public uint FileIndex;

    /// <include file='FILE_FULL_DIR_INFO.xml' path='doc/member[@name="FILE_FULL_DIR_INFO.CreationTime"]/*' />
    public LARGE_INTEGER CreationTime;

    /// <include file='FILE_FULL_DIR_INFO.xml' path='doc/member[@name="FILE_FULL_DIR_INFO.LastAccessTime"]/*' />
    public LARGE_INTEGER LastAccessTime;

    /// <include file='FILE_FULL_DIR_INFO.xml' path='doc/member[@name="FILE_FULL_DIR_INFO.LastWriteTime"]/*' />
    public LARGE_INTEGER LastWriteTime;

    /// <include file='FILE_FULL_DIR_INFO.xml' path='doc/member[@name="FILE_FULL_DIR_INFO.ChangeTime"]/*' />
    public LARGE_INTEGER ChangeTime;

    /// <include file='FILE_FULL_DIR_INFO.xml' path='doc/member[@name="FILE_FULL_DIR_INFO.EndOfFile"]/*' />
    public LARGE_INTEGER EndOfFile;

    /// <include file='FILE_FULL_DIR_INFO.xml' path='doc/member[@name="FILE_FULL_DIR_INFO.AllocationSize"]/*' />
    public LARGE_INTEGER AllocationSize;

    /// <include file='FILE_FULL_DIR_INFO.xml' path='doc/member[@name="FILE_FULL_DIR_INFO.FileAttributes"]/*' />
    [NativeTypeName("ULONG")]
    public uint FileAttributes;

    /// <include file='FILE_FULL_DIR_INFO.xml' path='doc/member[@name="FILE_FULL_DIR_INFO.FileNameLength"]/*' />
    [NativeTypeName("ULONG")]
    public uint FileNameLength;

    /// <include file='FILE_FULL_DIR_INFO.xml' path='doc/member[@name="FILE_FULL_DIR_INFO.EaSize"]/*' />
    [NativeTypeName("ULONG")]
    public uint EaSize;

    /// <include file='FILE_FULL_DIR_INFO.xml' path='doc/member[@name="FILE_FULL_DIR_INFO.FileName"]/*' />
    [NativeTypeName("WCHAR[1]")]
    public _FileName_e__FixedBuffer FileName;

    /// <include file='_FileName_e__FixedBuffer.xml' path='doc/member[@name="_FileName_e__FixedBuffer"]/*' />
    [Obsolete("Possible string represented as a fixed-sized buffer.")]
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
