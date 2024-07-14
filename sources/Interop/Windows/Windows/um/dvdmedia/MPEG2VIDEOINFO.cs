// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dvdmedia.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='MPEG2VIDEOINFO.xml' path='doc/member[@name="MPEG2VIDEOINFO"]/*' />
public partial struct MPEG2VIDEOINFO
{
    /// <include file='MPEG2VIDEOINFO.xml' path='doc/member[@name="MPEG2VIDEOINFO.hdr"]/*' />
    public VIDEOINFOHEADER2 hdr;

    /// <include file='MPEG2VIDEOINFO.xml' path='doc/member[@name="MPEG2VIDEOINFO.dwStartTimeCode"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwStartTimeCode;

    /// <include file='MPEG2VIDEOINFO.xml' path='doc/member[@name="MPEG2VIDEOINFO.cbSequenceHeader"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbSequenceHeader;

    /// <include file='MPEG2VIDEOINFO.xml' path='doc/member[@name="MPEG2VIDEOINFO.dwProfile"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwProfile;

    /// <include file='MPEG2VIDEOINFO.xml' path='doc/member[@name="MPEG2VIDEOINFO.dwLevel"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwLevel;

    /// <include file='MPEG2VIDEOINFO.xml' path='doc/member[@name="MPEG2VIDEOINFO.dwFlags"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwFlags;

    /// <include file='MPEG2VIDEOINFO.xml' path='doc/member[@name="MPEG2VIDEOINFO.dwSequenceHeader"]/*' />
    [NativeTypeName("DWORD[1]")]
    public _dwSequenceHeader_e__FixedBuffer dwSequenceHeader;

    /// <include file='_dwSequenceHeader_e__FixedBuffer.xml' path='doc/member[@name="_dwSequenceHeader_e__FixedBuffer"]/*' />
    public partial struct _dwSequenceHeader_e__FixedBuffer
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
