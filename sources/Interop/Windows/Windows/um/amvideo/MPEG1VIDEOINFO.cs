// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/amvideo.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='MPEG1VIDEOINFO.xml' path='doc/member[@name="MPEG1VIDEOINFO"]/*' />
public partial struct MPEG1VIDEOINFO
{
    /// <include file='MPEG1VIDEOINFO.xml' path='doc/member[@name="MPEG1VIDEOINFO.hdr"]/*' />
    public VIDEOINFOHEADER hdr;

    /// <include file='MPEG1VIDEOINFO.xml' path='doc/member[@name="MPEG1VIDEOINFO.dwStartTimeCode"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwStartTimeCode;

    /// <include file='MPEG1VIDEOINFO.xml' path='doc/member[@name="MPEG1VIDEOINFO.cbSequenceHeader"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbSequenceHeader;

    /// <include file='MPEG1VIDEOINFO.xml' path='doc/member[@name="MPEG1VIDEOINFO.bSequenceHeader"]/*' />
    [NativeTypeName("BYTE[1]")]
    public _bSequenceHeader_e__FixedBuffer bSequenceHeader;

    /// <include file='_bSequenceHeader_e__FixedBuffer.xml' path='doc/member[@name="_bSequenceHeader_e__FixedBuffer"]/*' />
    public partial struct _bSequenceHeader_e__FixedBuffer
    {
        public byte e0;

        [UnscopedRef]
        public ref byte this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Unsafe.Add(ref e0, index);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<byte> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}
