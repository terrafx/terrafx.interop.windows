// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='STREAM_LAYOUT_ENTRY.xml' path='doc/member[@name="STREAM_LAYOUT_ENTRY"]/*' />
public partial struct STREAM_LAYOUT_ENTRY
{
    /// <include file='STREAM_LAYOUT_ENTRY.xml' path='doc/member[@name="STREAM_LAYOUT_ENTRY.Version"]/*' />
    [NativeTypeName("DWORD")]
    public uint Version;

    /// <include file='STREAM_LAYOUT_ENTRY.xml' path='doc/member[@name="STREAM_LAYOUT_ENTRY.NextStreamOffset"]/*' />
    [NativeTypeName("DWORD")]
    public uint NextStreamOffset;

    /// <include file='STREAM_LAYOUT_ENTRY.xml' path='doc/member[@name="STREAM_LAYOUT_ENTRY.Flags"]/*' />
    [NativeTypeName("DWORD")]
    public uint Flags;

    /// <include file='STREAM_LAYOUT_ENTRY.xml' path='doc/member[@name="STREAM_LAYOUT_ENTRY.ExtentInformationOffset"]/*' />
    [NativeTypeName("DWORD")]
    public uint ExtentInformationOffset;

    /// <include file='STREAM_LAYOUT_ENTRY.xml' path='doc/member[@name="STREAM_LAYOUT_ENTRY.AllocationSize"]/*' />
    public LARGE_INTEGER AllocationSize;

    /// <include file='STREAM_LAYOUT_ENTRY.xml' path='doc/member[@name="STREAM_LAYOUT_ENTRY.EndOfFile"]/*' />
    public LARGE_INTEGER EndOfFile;

    /// <include file='STREAM_LAYOUT_ENTRY.xml' path='doc/member[@name="STREAM_LAYOUT_ENTRY.StreamInformationOffset"]/*' />
    [NativeTypeName("DWORD")]
    public uint StreamInformationOffset;

    /// <include file='STREAM_LAYOUT_ENTRY.xml' path='doc/member[@name="STREAM_LAYOUT_ENTRY.AttributeTypeCode"]/*' />
    [NativeTypeName("DWORD")]
    public uint AttributeTypeCode;

    /// <include file='STREAM_LAYOUT_ENTRY.xml' path='doc/member[@name="STREAM_LAYOUT_ENTRY.AttributeFlags"]/*' />
    [NativeTypeName("DWORD")]
    public uint AttributeFlags;

    /// <include file='STREAM_LAYOUT_ENTRY.xml' path='doc/member[@name="STREAM_LAYOUT_ENTRY.StreamIdentifierLength"]/*' />
    [NativeTypeName("DWORD")]
    public uint StreamIdentifierLength;

    /// <include file='STREAM_LAYOUT_ENTRY.xml' path='doc/member[@name="STREAM_LAYOUT_ENTRY.StreamIdentifier"]/*' />
    [NativeTypeName("WCHAR[1]")]
    public _StreamIdentifier_e__FixedBuffer StreamIdentifier;

    /// <include file='_StreamIdentifier_e__FixedBuffer.xml' path='doc/member[@name="_StreamIdentifier_e__FixedBuffer"]/*' />
    public partial struct _StreamIdentifier_e__FixedBuffer
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
