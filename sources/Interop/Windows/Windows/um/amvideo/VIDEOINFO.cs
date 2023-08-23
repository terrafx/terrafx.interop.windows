// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/amvideo.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='VIDEOINFO.xml' path='doc/member[@name="VIDEOINFO"]/*' />
public unsafe partial struct VIDEOINFO
{
    /// <include file='VIDEOINFO.xml' path='doc/member[@name="VIDEOINFO.rcSource"]/*' />
    public RECT rcSource;

    /// <include file='VIDEOINFO.xml' path='doc/member[@name="VIDEOINFO.rcTarget"]/*' />
    public RECT rcTarget;

    /// <include file='VIDEOINFO.xml' path='doc/member[@name="VIDEOINFO.dwBitRate"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwBitRate;

    /// <include file='VIDEOINFO.xml' path='doc/member[@name="VIDEOINFO.dwBitErrorRate"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwBitErrorRate;

    /// <include file='VIDEOINFO.xml' path='doc/member[@name="VIDEOINFO.AvgTimePerFrame"]/*' />
    [NativeTypeName("REFERENCE_TIME")]
    public long AvgTimePerFrame;

    /// <include file='VIDEOINFO.xml' path='doc/member[@name="VIDEOINFO.bmiHeader"]/*' />
    public BITMAPINFOHEADER bmiHeader;

    /// <include file='VIDEOINFO.xml' path='doc/member[@name="VIDEOINFO.Anonymous"]/*' />
    [NativeTypeName("__AnonymousRecord_amvideo_L319_C5")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.bmiColors"]/*' />
    [UnscopedRef]
    public Span<RGBQUAD> bmiColors
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return Anonymous.bmiColors;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.dwBitMasks"]/*' />
    [UnscopedRef]
    public Span<uint> dwBitMasks
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return MemoryMarshal.CreateSpan(ref Anonymous.dwBitMasks[0], 3);
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.TrueColorInfo"]/*' />
    [UnscopedRef]
    public ref TRUECOLORINFO TrueColorInfo
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.TrueColorInfo;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.bmiColors"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("RGBQUAD[256]")]
        public _bmiColors_e__FixedBuffer bmiColors;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.dwBitMasks"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("DWORD[3]")]
        public fixed uint dwBitMasks[3];

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.TrueColorInfo"]/*' />
        [FieldOffset(0)]
        public TRUECOLORINFO TrueColorInfo;

        /// <include file='_bmiColors_e__FixedBuffer.xml' path='doc/member[@name="_bmiColors_e__FixedBuffer"]/*' />
        [InlineArray(256)]
        public partial struct _bmiColors_e__FixedBuffer
        {
            public RGBQUAD e0;
        }
    }
}
