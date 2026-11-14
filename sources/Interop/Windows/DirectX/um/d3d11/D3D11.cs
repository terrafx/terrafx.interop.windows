// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.DirectX;

public static partial class D3D11
{
    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_DECODER_PROFILE_MPEG2_MOCOMP"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3D11_DECODER_PROFILE_MPEG2_MOCOMP
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x4B, 0xF4, 0xA9, 0xE6,
                0xB0, 0x61,
                0x63, 0x45,
                0x9E,
                0xA4,
                0x63,
                0xD2,
                0xA3,
                0xC6,
                0xFE,
                0x66
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_DECODER_PROFILE_MPEG2_IDCT"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3D11_DECODER_PROFILE_MPEG2_IDCT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x00, 0xAD, 0x22, 0xBF,
                0xEA, 0x03,
                0x90, 0x46,
                0x80,
                0x77,
                0x47,
                0x33,
                0x46,
                0x20,
                0x9B,
                0x7E
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_DECODER_PROFILE_MPEG2_VLD"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3D11_DECODER_PROFILE_MPEG2_VLD
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x7F, 0x41, 0x27, 0xEE,
                0x28, 0x5E,
                0x65, 0x4E,
                0xBE,
                0xEA,
                0x1D,
                0x26,
                0xB5,
                0x08,
                0xAD,
                0xC9
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_DECODER_PROFILE_MPEG1_VLD"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3D11_DECODER_PROFILE_MPEG1_VLD
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x19, 0xC7, 0x3E, 0x6F,
                0x35, 0x37,
                0xCC, 0x42,
                0x80,
                0x63,
                0x65,
                0xCC,
                0x3C,
                0xB3,
                0x66,
                0x16
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_DECODER_PROFILE_MPEG2and1_VLD"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3D11_DECODER_PROFILE_MPEG2and1_VLD
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x12, 0x5F, 0x69, 0x86,
                0x0E, 0x34,
                0x04, 0x4F,
                0x9F,
                0xD3,
                0x92,
                0x53,
                0xDD,
                0x32,
                0x74,
                0x60
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_DECODER_PROFILE_H264_MOCOMP_NOFGT"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3D11_DECODER_PROFILE_H264_MOCOMP_NOFGT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x64, 0xBE, 0x81, 0x1B,
                0xC7, 0xA0,
                0xD3, 0x11,
                0xB9,
                0x84,
                0x00,
                0xC0,
                0x4F,
                0x2E,
                0x73,
                0xC5
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_DECODER_PROFILE_H264_MOCOMP_FGT"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3D11_DECODER_PROFILE_H264_MOCOMP_FGT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x65, 0xBE, 0x81, 0x1B,
                0xC7, 0xA0,
                0xD3, 0x11,
                0xB9,
                0x84,
                0x00,
                0xC0,
                0x4F,
                0x2E,
                0x73,
                0xC5
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_DECODER_PROFILE_H264_IDCT_NOFGT"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3D11_DECODER_PROFILE_H264_IDCT_NOFGT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x66, 0xBE, 0x81, 0x1B,
                0xC7, 0xA0,
                0xD3, 0x11,
                0xB9,
                0x84,
                0x00,
                0xC0,
                0x4F,
                0x2E,
                0x73,
                0xC5
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_DECODER_PROFILE_H264_IDCT_FGT"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3D11_DECODER_PROFILE_H264_IDCT_FGT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x67, 0xBE, 0x81, 0x1B,
                0xC7, 0xA0,
                0xD3, 0x11,
                0xB9,
                0x84,
                0x00,
                0xC0,
                0x4F,
                0x2E,
                0x73,
                0xC5
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_DECODER_PROFILE_H264_VLD_NOFGT"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3D11_DECODER_PROFILE_H264_VLD_NOFGT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x68, 0xBE, 0x81, 0x1B,
                0xC7, 0xA0,
                0xD3, 0x11,
                0xB9,
                0x84,
                0x00,
                0xC0,
                0x4F,
                0x2E,
                0x73,
                0xC5
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_DECODER_PROFILE_H264_VLD_FGT"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3D11_DECODER_PROFILE_H264_VLD_FGT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x69, 0xBE, 0x81, 0x1B,
                0xC7, 0xA0,
                0xD3, 0x11,
                0xB9,
                0x84,
                0x00,
                0xC0,
                0x4F,
                0x2E,
                0x73,
                0xC5
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_DECODER_PROFILE_H264_VLD_WITHFMOASO_NOFGT"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3D11_DECODER_PROFILE_H264_VLD_WITHFMOASO_NOFGT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xF9, 0x4F, 0xF0, 0xD5,
                0x18, 0x34,
                0xD8, 0x45,
                0x95,
                0x61,
                0x32,
                0xA7,
                0x6A,
                0xAE,
                0x2D,
                0xDD
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_DECODER_PROFILE_H264_VLD_STEREO_PROGRESSIVE_NOFGT"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3D11_DECODER_PROFILE_H264_VLD_STEREO_PROGRESSIVE_NOFGT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xDA, 0xE8, 0x9B, 0xD7,
                0xF1, 0x0C,
                0x81, 0x4C,
                0xB8,
                0x2A,
                0x69,
                0xA4,
                0xE2,
                0x36,
                0xF4,
                0x3D
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_DECODER_PROFILE_H264_VLD_STEREO_NOFGT"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3D11_DECODER_PROFILE_H264_VLD_STEREO_NOFGT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xBB, 0xCC, 0xAA, 0xF9,
                0xB6, 0xC2,
                0xFC, 0x4C,
                0x87,
                0x79,
                0x57,
                0x07,
                0xB1,
                0x76,
                0x05,
                0x52
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_DECODER_PROFILE_H264_VLD_MULTIVIEW_NOFGT"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3D11_DECODER_PROFILE_H264_VLD_MULTIVIEW_NOFGT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x82, 0x9D, 0x5B, 0x70,
                0xCF, 0x76,
                0xD6, 0x49,
                0xB7,
                0xE6,
                0xAC,
                0x88,
                0x72,
                0xDB,
                0x01,
                0x3C
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_DECODER_PROFILE_WMV8_POSTPROC"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3D11_DECODER_PROFILE_WMV8_POSTPROC
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x80, 0xBE, 0x81, 0x1B,
                0xC7, 0xA0,
                0xD3, 0x11,
                0xB9,
                0x84,
                0x00,
                0xC0,
                0x4F,
                0x2E,
                0x73,
                0xC5
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_DECODER_PROFILE_WMV8_MOCOMP"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3D11_DECODER_PROFILE_WMV8_MOCOMP
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x81, 0xBE, 0x81, 0x1B,
                0xC7, 0xA0,
                0xD3, 0x11,
                0xB9,
                0x84,
                0x00,
                0xC0,
                0x4F,
                0x2E,
                0x73,
                0xC5
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_DECODER_PROFILE_WMV9_POSTPROC"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3D11_DECODER_PROFILE_WMV9_POSTPROC
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x90, 0xBE, 0x81, 0x1B,
                0xC7, 0xA0,
                0xD3, 0x11,
                0xB9,
                0x84,
                0x00,
                0xC0,
                0x4F,
                0x2E,
                0x73,
                0xC5
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_DECODER_PROFILE_WMV9_MOCOMP"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3D11_DECODER_PROFILE_WMV9_MOCOMP
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x91, 0xBE, 0x81, 0x1B,
                0xC7, 0xA0,
                0xD3, 0x11,
                0xB9,
                0x84,
                0x00,
                0xC0,
                0x4F,
                0x2E,
                0x73,
                0xC5
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_DECODER_PROFILE_WMV9_IDCT"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3D11_DECODER_PROFILE_WMV9_IDCT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x94, 0xBE, 0x81, 0x1B,
                0xC7, 0xA0,
                0xD3, 0x11,
                0xB9,
                0x84,
                0x00,
                0xC0,
                0x4F,
                0x2E,
                0x73,
                0xC5
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_DECODER_PROFILE_VC1_POSTPROC"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3D11_DECODER_PROFILE_VC1_POSTPROC
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xA0, 0xBE, 0x81, 0x1B,
                0xC7, 0xA0,
                0xD3, 0x11,
                0xB9,
                0x84,
                0x00,
                0xC0,
                0x4F,
                0x2E,
                0x73,
                0xC5
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_DECODER_PROFILE_VC1_MOCOMP"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3D11_DECODER_PROFILE_VC1_MOCOMP
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xA1, 0xBE, 0x81, 0x1B,
                0xC7, 0xA0,
                0xD3, 0x11,
                0xB9,
                0x84,
                0x00,
                0xC0,
                0x4F,
                0x2E,
                0x73,
                0xC5
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_DECODER_PROFILE_VC1_IDCT"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3D11_DECODER_PROFILE_VC1_IDCT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xA2, 0xBE, 0x81, 0x1B,
                0xC7, 0xA0,
                0xD3, 0x11,
                0xB9,
                0x84,
                0x00,
                0xC0,
                0x4F,
                0x2E,
                0x73,
                0xC5
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_DECODER_PROFILE_VC1_VLD"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3D11_DECODER_PROFILE_VC1_VLD
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xA3, 0xBE, 0x81, 0x1B,
                0xC7, 0xA0,
                0xD3, 0x11,
                0xB9,
                0x84,
                0x00,
                0xC0,
                0x4F,
                0x2E,
                0x73,
                0xC5
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_DECODER_PROFILE_VC1_D2010"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3D11_DECODER_PROFILE_VC1_D2010
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xA4, 0xBE, 0x81, 0x1B,
                0xC7, 0xA0,
                0xD3, 0x11,
                0xB9,
                0x84,
                0x00,
                0xC0,
                0x4F,
                0x2E,
                0x73,
                0xC5
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_DECODER_PROFILE_MPEG4PT2_VLD_SIMPLE"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3D11_DECODER_PROFILE_MPEG4PT2_VLD_SIMPLE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x74, 0x4D, 0xD6, 0xEF,
                0xE8, 0xC9,
                0xD7, 0x41,
                0xA5,
                0xE9,
                0xE9,
                0xB0,
                0xE3,
                0x9F,
                0xA3,
                0x19
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_DECODER_PROFILE_MPEG4PT2_VLD_ADVSIMPLE_NOGMC"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3D11_DECODER_PROFILE_MPEG4PT2_VLD_ADVSIMPLE_NOGMC
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x9F, 0x8A, 0x41, 0xED,
                0x0D, 0x01,
                0xDA, 0x4E,
                0x9A,
                0xE3,
                0x9A,
                0x65,
                0x35,
                0x8D,
                0x8D,
                0x2E
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_DECODER_PROFILE_MPEG4PT2_VLD_ADVSIMPLE_GMC"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3D11_DECODER_PROFILE_MPEG4PT2_VLD_ADVSIMPLE_GMC
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x5B, 0x8B, 0x99, 0xAB,
                0x58, 0x42,
                0xA9, 0x44,
                0x9F,
                0xEB,
                0x94,
                0xE5,
                0x97,
                0xA6,
                0xBA,
                0xAE
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_DECODER_PROFILE_HEVC_VLD_MAIN"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3D11_DECODER_PROFILE_HEVC_VLD_MAIN
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x1B, 0xD5, 0x11, 0x5B,
                0x4C, 0x2F,
                0x52, 0x44,
                0xBC,
                0xC3,
                0x09,
                0xF2,
                0xA1,
                0x16,
                0x0C,
                0xC0
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_DECODER_PROFILE_HEVC_VLD_MAIN10"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3D11_DECODER_PROFILE_HEVC_VLD_MAIN10
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xE0, 0xF0, 0x7A, 0x10,
                0x1A, 0xEF,
                0x19, 0x4D,
                0xAB,
                0xA8,
                0x67,
                0xA1,
                0x63,
                0x07,
                0x3D,
                0x13
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_DECODER_PROFILE_HEVC_VLD_MONOCHROME"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3D11_DECODER_PROFILE_HEVC_VLD_MONOCHROME
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x93, 0xB9, 0x85, 0x06,
                0x8C, 0x3D,
                0xA0, 0x43,
                0x8B,
                0x28,
                0xD7,
                0x4C,
                0x2D,
                0x68,
                0x99,
                0xA4
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_DECODER_PROFILE_HEVC_VLD_MONOCHROME10"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3D11_DECODER_PROFILE_HEVC_VLD_MONOCHROME10
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x0F, 0x1D, 0x2A, 0x14,
                0xDD, 0x69,
                0xC9, 0x4E,
                0x85,
                0x91,
                0xB1,
                0x2F,
                0xFC,
                0xB9,
                0x1A,
                0x29
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_DECODER_PROFILE_HEVC_VLD_MAIN12"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3D11_DECODER_PROFILE_HEVC_VLD_MAIN12
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x5F, 0x92, 0x72, 0x1A,
                0x2C, 0x0C,
                0x15, 0x4F,
                0x96,
                0xFB,
                0xB1,
                0x7D,
                0x14,
                0x73,
                0x60,
                0x3F
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_DECODER_PROFILE_HEVC_VLD_MAIN10_422"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3D11_DECODER_PROFILE_HEVC_VLD_MAIN10_422
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xE5, 0x4F, 0xAC, 0x0B,
                0x32, 0x15,
                0x29, 0x44,
                0xA8,
                0x54,
                0xF8,
                0x4D,
                0xE0,
                0x49,
                0x53,
                0xDB
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_DECODER_PROFILE_HEVC_VLD_MAIN12_422"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3D11_DECODER_PROFILE_HEVC_VLD_MAIN12_422
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x81, 0xAC, 0xBC, 0x55,
                0x11, 0xF3,
                0x93, 0x40,
                0xA7,
                0xD0,
                0x1C,
                0xBC,
                0x0B,
                0x84,
                0x9B,
                0xEE
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_DECODER_PROFILE_HEVC_VLD_MAIN_444"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3D11_DECODER_PROFILE_HEVC_VLD_MAIN_444
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x8F, 0x01, 0x08, 0x40,
                0x37, 0xF5,
                0x36, 0x4B,
                0x98,
                0xCF,
                0x61,
                0xAF,
                0x8A,
                0x2C,
                0x1A,
                0x33
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_DECODER_PROFILE_HEVC_VLD_MAIN10_EXT"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3D11_DECODER_PROFILE_HEVC_VLD_MAIN10_EXT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x90, 0x54, 0xC5, 0x9C,
                0x7C, 0xE3,
                0x32, 0x49,
                0x86,
                0x84,
                0x49,
                0x20,
                0xF9,
                0xF6,
                0x40,
                0x9C
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_DECODER_PROFILE_HEVC_VLD_MAIN10_444"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3D11_DECODER_PROFILE_HEVC_VLD_MAIN10_444
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xFA, 0xEF, 0xAB, 0x0D,
                0x58, 0x44,
                0x02, 0x46,
                0xBC,
                0x03,
                0x07,
                0x95,
                0x65,
                0x9D,
                0x61,
                0x7C
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_DECODER_PROFILE_HEVC_VLD_MAIN12_444"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3D11_DECODER_PROFILE_HEVC_VLD_MAIN12_444
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x4D, 0x63, 0x98, 0x97,
                0x9D, 0xFE,
                0xE5, 0x48,
                0xB4,
                0xDA,
                0xDB,
                0xEC,
                0x45,
                0xB3,
                0xDF,
                0x01
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_DECODER_PROFILE_HEVC_VLD_MAIN16"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3D11_DECODER_PROFILE_HEVC_VLD_MAIN16
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xB0, 0xDB, 0xFB, 0xA4,
                0x13, 0xA1,
                0x2B, 0x48,
                0xA2,
                0x32,
                0x63,
                0x5C,
                0xC0,
                0x69,
                0x7F,
                0x6D
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_DECODER_PROFILE_VP9_VLD_PROFILE0"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3D11_DECODER_PROFILE_VP9_VLD_PROFILE0
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xF8, 0x07, 0x37, 0x46,
                0xD0, 0xA1,
                0x85, 0x45,
                0x87,
                0x6D,
                0x83,
                0xAA,
                0x6D,
                0x60,
                0xB8,
                0x9E
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_DECODER_PROFILE_VP9_VLD_10BIT_PROFILE2"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3D11_DECODER_PROFILE_VP9_VLD_10BIT_PROFILE2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xEF, 0x49, 0xC7, 0xA4,
                0xCF, 0x6E,
                0xAA, 0x48,
                0x84,
                0x48,
                0x50,
                0xA7,
                0xA1,
                0x16,
                0x5F,
                0xF7
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_DECODER_PROFILE_VP8_VLD"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3D11_DECODER_PROFILE_VP8_VLD
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xEA, 0x99, 0xB8, 0x90,
                0x62, 0x3A,
                0x05, 0x47,
                0x88,
                0xB3,
                0x8D,
                0xF0,
                0x4B,
                0x27,
                0x44,
                0xE7
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_DECODER_PROFILE_AV1_VLD_PROFILE0"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3D11_DECODER_PROFILE_AV1_VLD_PROFILE0
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xCB, 0x4C, 0xBE, 0xB8,
                0x53, 0xCF,
                0xBA, 0x46,
                0x8D,
                0x59,
                0xD6,
                0xB8,
                0xA6,
                0xDA,
                0x5D,
                0x2A
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_DECODER_PROFILE_AV1_VLD_PROFILE1"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3D11_DECODER_PROFILE_AV1_VLD_PROFILE1
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x0F, 0xFF, 0x36, 0x69,
                0xB1, 0x45,
                0x63, 0x41,
                0x9C,
                0xC1,
                0x64,
                0x6E,
                0xF6,
                0x94,
                0x61,
                0x08
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_DECODER_PROFILE_AV1_VLD_PROFILE2"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3D11_DECODER_PROFILE_AV1_VLD_PROFILE2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xA1, 0x2A, 0x5F, 0x0C,
                0x41, 0xE5,
                0x89, 0x40,
                0xBB,
                0x7B,
                0x98,
                0x11,
                0x0A,
                0x19,
                0xD7,
                0xC8
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_DECODER_PROFILE_AV1_VLD_12BIT_PROFILE2"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3D11_DECODER_PROFILE_AV1_VLD_12BIT_PROFILE2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x09, 0x70, 0x12, 0x17,
                0x0F, 0xA0,
                0xE1, 0x4C,
                0x99,
                0x4E,
                0xBF,
                0x40,
                0x81,
                0xF6,
                0xF3,
                0xF0
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_DECODER_PROFILE_AV1_VLD_12BIT_PROFILE2_420"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3D11_DECODER_PROFILE_AV1_VLD_12BIT_PROFILE2_420
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xD6, 0xBE, 0x80, 0x2D,
                0xAC, 0x9C,
                0x35, 0x48,
                0x9E,
                0x91,
                0x32,
                0x7B,
                0xBC,
                0x4F,
                0x9E,
                0xE8
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_DECODER_PROFILE_MJPEG_VLD_420"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3D11_DECODER_PROFILE_MJPEG_VLD_420
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x06, 0xB5, 0x5C, 0x72,
                0x29, 0x0C,
                0xC4, 0x43,
                0x94,
                0x40,
                0x8E,
                0x93,
                0x97,
                0x90,
                0x3A,
                0x04
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_DECODER_PROFILE_MJPEG_VLD_422"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3D11_DECODER_PROFILE_MJPEG_VLD_422
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xCD, 0xB9, 0x77, 0x5B,
                0x35, 0x1A,
                0x30, 0x4C,
                0x9F,
                0xD8,
                0xEF,
                0x4B,
                0x60,
                0xC0,
                0x35,
                0xDD
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_DECODER_PROFILE_MJPEG_VLD_444"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3D11_DECODER_PROFILE_MJPEG_VLD_444
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xF9, 0x61, 0x51, 0xD9,
                0x44, 0x0D,
                0xE6, 0x47,
                0xBC,
                0xF5,
                0x1B,
                0xFB,
                0xFB,
                0x26,
                0x8F,
                0x97
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_DECODER_PROFILE_MJPEG_VLD_4444"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3D11_DECODER_PROFILE_MJPEG_VLD_4444
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xD5, 0x48, 0x17, 0xC9,
                0x18, 0xFD,
                0xCA, 0x4A,
                0x9D,
                0xB3,
                0x3A,
                0x66,
                0x34,
                0xAB,
                0x54,
                0x7D
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_DECODER_PROFILE_JPEG_VLD_420"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3D11_DECODER_PROFILE_JPEG_VLD_420
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x83, 0x2C, 0x78, 0xCF,
                0xF5, 0xBE,
                0x2C, 0x4A,
                0x87,
                0xCB,
                0x60,
                0x19,
                0xE7,
                0xB1,
                0x75,
                0xAC
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_DECODER_PROFILE_JPEG_VLD_422"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3D11_DECODER_PROFILE_JPEG_VLD_422
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x17, 0xF4, 0x4D, 0xF0,
                0xE2, 0xEE,
                0x67, 0x40,
                0xA7,
                0x78,
                0xF3,
                0x5C,
                0x15,
                0xAB,
                0x97,
                0x21
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_DECODER_PROFILE_JPEG_VLD_444"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3D11_DECODER_PROFILE_JPEG_VLD_444
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x17, 0x0E, 0xD0, 0x4C,
                0xBA, 0x89,
                0xEF, 0x48,
                0xB9,
                0xF9,
                0xED,
                0xCB,
                0x82,
                0x71,
                0x3F,
                0x65
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_DECODER_PROFILE_APV_VLD_422_10"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3D11_DECODER_PROFILE_APV_VLD_422_10
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x9D, 0x70, 0x6A, 0x22,
                0x12, 0xAE,
                0xC5, 0x44,
                0xBA,
                0x21,
                0x16,
                0x4F,
                0xEE,
                0xB7,
                0xF9,
                0xB6
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_DECODER_PROFILE_APV_VLD_422_12"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3D11_DECODER_PROFILE_APV_VLD_422_12
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xAD, 0x52, 0xF1, 0xF6,
                0xE5, 0x94,
                0xFA, 0x4B,
                0x92,
                0x27,
                0x67,
                0x6C,
                0xDD,
                0xEF,
                0xF4,
                0x2B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_DECODER_PROFILE_APV_VLD_444_10"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3D11_DECODER_PROFILE_APV_VLD_444_10
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x7D, 0x8D, 0x4A, 0x6A,
                0x10, 0x76,
                0x9F, 0x46,
                0x85,
                0x5F,
                0x39,
                0xF1,
                0x30,
                0x51,
                0xC0,
                0x13
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_DECODER_PROFILE_APV_VLD_444_12"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3D11_DECODER_PROFILE_APV_VLD_444_12
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x1C, 0x9A, 0x03, 0xF1,
                0x08, 0xE2,
                0xC1, 0x45,
                0x95,
                0x2C,
                0x04,
                0x08,
                0x41,
                0xB6,
                0x76,
                0x67
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_DECODER_PROFILE_APV_VLD_4444_10"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3D11_DECODER_PROFILE_APV_VLD_4444_10
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xB9, 0x99, 0x37, 0xC8,
                0x55, 0x96,
                0x95, 0x4B,
                0x80,
                0x08,
                0x56,
                0xA3,
                0x22,
                0xCE,
                0x5D,
                0x81
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_DECODER_PROFILE_APV_VLD_4444_12"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3D11_DECODER_PROFILE_APV_VLD_4444_12
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xE3, 0x3E, 0x76, 0x6A,
                0x05, 0x4D,
                0xFE, 0x47,
                0xA4,
                0x29,
                0x72,
                0x34,
                0x74,
                0xB6,
                0x9D,
                0x7C
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_DECODER_PROFILE_APV_VLD_400_10"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3D11_DECODER_PROFILE_APV_VLD_400_10
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x62, 0x88, 0x14, 0x37,
                0xD6, 0x6B,
                0x18, 0x46,
                0x82,
                0x93,
                0x77,
                0x7B,
                0x68,
                0x6B,
                0x08,
                0x24
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_CRYPTO_TYPE_AES128_CTR"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3D11_CRYPTO_TYPE_AES128_CTR
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x11, 0xD7, 0x6B, 0x9B,
                0x74, 0x4F,
                0xC9, 0x41,
                0x9E,
                0x7B,
                0x0B,
                0xE2,
                0xD7,
                0xD9,
                0x3B,
                0x4F
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_DECODER_ENCRYPTION_HW_CENC"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3D11_DECODER_ENCRYPTION_HW_CENC
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x4F, 0xAC, 0xD6, 0x89,
                0xF2, 0x09,
                0x29, 0x42,
                0xB2,
                0xCD,
                0x37,
                0x74,
                0x0A,
                0x6D,
                0xFD,
                0x81
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_DECODER_BITSTREAM_ENCRYPTION_TYPE_CENC"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3D11_DECODER_BITSTREAM_ENCRYPTION_TYPE_CENC
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x35, 0x52, 0x40, 0xB0,
                0x3D, 0xC1,
                0xF2, 0x44,
                0x9A,
                0xE5,
                0xDD,
                0x48,
                0xE0,
                0x8E,
                0x5B,
                0x67
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_DECODER_BITSTREAM_ENCRYPTION_TYPE_CBCS"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3D11_DECODER_BITSTREAM_ENCRYPTION_TYPE_CBCS
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x19, 0x93, 0x2D, 0x42,
                0x21, 0x9D,
                0xB7, 0x4B,
                0x93,
                0x71,
                0xFA,
                0xF5,
                0xA8,
                0x2C,
                0x3E,
                0x04
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_KEY_EXCHANGE_HW_PROTECTION"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3D11_KEY_EXCHANGE_HW_PROTECTION
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x8A, 0x0D, 0x17, 0xB1,
                0x8D, 0x62,
                0xA3, 0x4D,
                0xAD,
                0x3B,
                0x82,
                0xDD,
                0xB0,
                0x8B,
                0x49,
                0x70
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_AUTHENTICATED_QUERY_PROTECTION"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3D11_AUTHENTICATED_QUERY_PROTECTION
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x84, 0xB5, 0x4E, 0xA8,
                0x95, 0xC4,
                0xAA, 0x48,
                0xB9,
                0x4D,
                0x8B,
                0xD2,
                0xD6,
                0xFB,
                0xCE,
                0x05
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_AUTHENTICATED_QUERY_CHANNEL_TYPE"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3D11_AUTHENTICATED_QUERY_CHANNEL_TYPE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xA5, 0x18, 0x1B, 0xBC,
                0xFB, 0xB1,
                0xAB, 0x42,
                0xBD,
                0x94,
                0xB5,
                0x82,
                0x8B,
                0x4B,
                0xF7,
                0xBE
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_AUTHENTICATED_QUERY_DEVICE_HANDLE"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3D11_AUTHENTICATED_QUERY_DEVICE_HANDLE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x9D, 0x53, 0x1C, 0xEC,
                0xFF, 0x8C,
                0x2A, 0x4E,
                0xBC,
                0xC4,
                0xF5,
                0x69,
                0x2F,
                0x99,
                0xF4,
                0x80
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_AUTHENTICATED_QUERY_CRYPTO_SESSION"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3D11_AUTHENTICATED_QUERY_CRYPTO_SESSION
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x9E, 0x49, 0x34, 0x26,
                0x18, 0xD0,
                0x74, 0x4D,
                0xAC,
                0x17,
                0x7F,
                0x72,
                0x40,
                0x59,
                0x52,
                0x8D
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_AUTHENTICATED_QUERY_RESTRICTED_SHARED_RESOURCE_PROCESS_COUNT"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3D11_AUTHENTICATED_QUERY_RESTRICTED_SHARED_RESOURCE_PROCESS_COUNT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xB3, 0x07, 0xB2, 0x0D,
                0x50, 0x94,
                0xA6, 0x46,
                0x82,
                0xDE,
                0x1B,
                0x96,
                0xD4,
                0x4F,
                0x9C,
                0xF2
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_AUTHENTICATED_QUERY_RESTRICTED_SHARED_RESOURCE_PROCESS"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3D11_AUTHENTICATED_QUERY_RESTRICTED_SHARED_RESOURCE_PROCESS
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xDB, 0xBA, 0x9B, 0x64,
                0xF4, 0xF0,
                0x39, 0x46,
                0xA1,
                0x5B,
                0x24,
                0x39,
                0x3F,
                0xC3,
                0xAB,
                0xAC
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_AUTHENTICATED_QUERY_UNRESTRICTED_PROTECTED_SHARED_RESOURCE_COUNT"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3D11_AUTHENTICATED_QUERY_UNRESTRICTED_PROTECTED_SHARED_RESOURCE_COUNT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xD6, 0x0B, 0x2F, 0x01,
                0x62, 0xE6,
                0x74, 0x44,
                0xBE,
                0xFD,
                0xAA,
                0x53,
                0xE5,
                0x14,
                0x3C,
                0x6D
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_AUTHENTICATED_QUERY_OUTPUT_ID_COUNT"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3D11_AUTHENTICATED_QUERY_OUTPUT_ID_COUNT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x5E, 0x2B, 0x04, 0x2C,
                0x07, 0x8C,
                0xD5, 0x46,
                0xAA,
                0xBE,
                0x8F,
                0x75,
                0xCB,
                0xAD,
                0x4C,
                0x31
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_AUTHENTICATED_QUERY_OUTPUT_ID"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3D11_AUTHENTICATED_QUERY_OUTPUT_ID
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xA3, 0xDC, 0x9D, 0x83,
                0x4E, 0x9B,
                0xE4, 0x41,
                0xB0,
                0x53,
                0x89,
                0x2B,
                0xD2,
                0xA1,
                0x1E,
                0xE7
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_AUTHENTICATED_QUERY_ACCESSIBILITY_ATTRIBUTES"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3D11_AUTHENTICATED_QUERY_ACCESSIBILITY_ATTRIBUTES
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xD2, 0xD9, 0x14, 0x62,
                0x2C, 0x43,
                0xBB, 0x4A,
                0x9F,
                0xCE,
                0x21,
                0x6E,
                0xEA,
                0x26,
                0x9E,
                0x3B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_AUTHENTICATED_QUERY_ENCRYPTION_WHEN_ACCESSIBLE_GUID_COUNT"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3D11_AUTHENTICATED_QUERY_ENCRYPTION_WHEN_ACCESSIBLE_GUID_COUNT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x66, 0x70, 0x0F, 0xB3,
                0x3C, 0x20,
                0x07, 0x4B,
                0x93,
                0xFC,
                0xCE,
                0xAA,
                0xFD,
                0x61,
                0x24,
                0x1E
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_AUTHENTICATED_QUERY_ENCRYPTION_WHEN_ACCESSIBLE_GUID"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3D11_AUTHENTICATED_QUERY_ENCRYPTION_WHEN_ACCESSIBLE_GUID
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x58, 0x59, 0x3A, 0xF8,
                0x86, 0xE9,
                0xDA, 0x4B,
                0xBE,
                0xB0,
                0x41,
                0x1F,
                0x6A,
                0x7A,
                0x01,
                0xB7
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_AUTHENTICATED_QUERY_CURRENT_ENCRYPTION_WHEN_ACCESSIBLE"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3D11_AUTHENTICATED_QUERY_CURRENT_ENCRYPTION_WHEN_ACCESSIBLE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xC7, 0x91, 0x17, 0xEC,
                0xD3, 0xDA,
                0x15, 0x4F,
                0x9E,
                0xC3,
                0xFA,
                0xA9,
                0x3D,
                0x60,
                0xD4,
                0xF0
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_AUTHENTICATED_CONFIGURE_INITIALIZE"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3D11_AUTHENTICATED_CONFIGURE_INITIALIZE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xDB, 0x4B, 0x11, 0x06,
                0x23, 0x35,
                0x0A, 0x47,
                0x8D,
                0xCA,
                0xFB,
                0xC2,
                0x84,
                0x51,
                0x54,
                0xF0
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_AUTHENTICATED_CONFIGURE_PROTECTION"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3D11_AUTHENTICATED_CONFIGURE_PROTECTION
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x58, 0x56, 0x45, 0x50,
                0x47, 0x3F,
                0x62, 0x43,
                0xBF,
                0x99,
                0xBF,
                0xDF,
                0xCD,
                0xE9,
                0xED,
                0x29
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_AUTHENTICATED_CONFIGURE_CRYPTO_SESSION"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3D11_AUTHENTICATED_CONFIGURE_CRYPTO_SESSION
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x54, 0xCC, 0x46, 0x63,
                0xFC, 0x2C,
                0xD4, 0x4A,
                0x82,
                0x24,
                0xD1,
                0x58,
                0x37,
                0xDE,
                0x77,
                0x00
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_AUTHENTICATED_CONFIGURE_SHARED_RESOURCE"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3D11_AUTHENTICATED_CONFIGURE_SHARED_RESOURCE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x47, 0xD0, 0x72, 0x07,
                0x40, 0x1B,
                0xE8, 0x48,
                0x9C,
                0xA6,
                0xB5,
                0xF5,
                0x10,
                0xDE,
                0x9F,
                0x01
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_AUTHENTICATED_CONFIGURE_ENCRYPTION_WHEN_ACCESSIBLE"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3D11_AUTHENTICATED_CONFIGURE_ENCRYPTION_WHEN_ACCESSIBLE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x86, 0xF2, 0xFF, 0x41,
                0xE0, 0x6A,
                0x43, 0x4D,
                0x9D,
                0x55,
                0xA4,
                0x6E,
                0x9E,
                0xFD,
                0x15,
                0x8A
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_KEY_EXCHANGE_RSAES_OAEP"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3D11_KEY_EXCHANGE_RSAES_OAEP
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x95, 0x98, 0x94, 0xC1,
                0x2A, 0xD7,
                0x1D, 0x4A,
                0x8E,
                0x5D,
                0xED,
                0x85,
                0x7D,
                0x17,
                0x15,
                0x20
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_16BIT_INDEX_STRIP_CUT_VALUE"]/*' />
    [NativeTypeName("#define D3D11_16BIT_INDEX_STRIP_CUT_VALUE ( 0xffff )")]
    public const int D3D11_16BIT_INDEX_STRIP_CUT_VALUE = (0xffff);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_32BIT_INDEX_STRIP_CUT_VALUE"]/*' />
    [NativeTypeName("#define D3D11_32BIT_INDEX_STRIP_CUT_VALUE ( 0xffffffff )")]
    public const uint D3D11_32BIT_INDEX_STRIP_CUT_VALUE = (0xffffffff);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_8BIT_INDEX_STRIP_CUT_VALUE"]/*' />
    [NativeTypeName("#define D3D11_8BIT_INDEX_STRIP_CUT_VALUE ( 0xff )")]
    public const int D3D11_8BIT_INDEX_STRIP_CUT_VALUE = (0xff);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_ARRAY_AXIS_ADDRESS_RANGE_BIT_COUNT"]/*' />
    [NativeTypeName("#define D3D11_ARRAY_AXIS_ADDRESS_RANGE_BIT_COUNT ( 9 )")]
    public const int D3D11_ARRAY_AXIS_ADDRESS_RANGE_BIT_COUNT = (9);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_CLIP_OR_CULL_DISTANCE_COUNT"]/*' />
    [NativeTypeName("#define D3D11_CLIP_OR_CULL_DISTANCE_COUNT ( 8 )")]
    public const int D3D11_CLIP_OR_CULL_DISTANCE_COUNT = (8);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_CLIP_OR_CULL_DISTANCE_ELEMENT_COUNT"]/*' />
    [NativeTypeName("#define D3D11_CLIP_OR_CULL_DISTANCE_ELEMENT_COUNT ( 2 )")]
    public const int D3D11_CLIP_OR_CULL_DISTANCE_ELEMENT_COUNT = (2);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT"]/*' />
    [NativeTypeName("#define D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT ( 14 )")]
    public const int D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT = (14);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_COMMONSHADER_CONSTANT_BUFFER_COMPONENTS"]/*' />
    [NativeTypeName("#define D3D11_COMMONSHADER_CONSTANT_BUFFER_COMPONENTS ( 4 )")]
    public const int D3D11_COMMONSHADER_CONSTANT_BUFFER_COMPONENTS = (4);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_COMMONSHADER_CONSTANT_BUFFER_COMPONENT_BIT_COUNT"]/*' />
    [NativeTypeName("#define D3D11_COMMONSHADER_CONSTANT_BUFFER_COMPONENT_BIT_COUNT ( 32 )")]
    public const int D3D11_COMMONSHADER_CONSTANT_BUFFER_COMPONENT_BIT_COUNT = (32);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_COMMONSHADER_CONSTANT_BUFFER_HW_SLOT_COUNT"]/*' />
    [NativeTypeName("#define D3D11_COMMONSHADER_CONSTANT_BUFFER_HW_SLOT_COUNT ( 15 )")]
    public const int D3D11_COMMONSHADER_CONSTANT_BUFFER_HW_SLOT_COUNT = (15);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_COMMONSHADER_CONSTANT_BUFFER_PARTIAL_UPDATE_EXTENTS_BYTE_ALIGNMENT"]/*' />
    [NativeTypeName("#define D3D11_COMMONSHADER_CONSTANT_BUFFER_PARTIAL_UPDATE_EXTENTS_BYTE_ALIGNMENT ( 16 )")]
    public const int D3D11_COMMONSHADER_CONSTANT_BUFFER_PARTIAL_UPDATE_EXTENTS_BYTE_ALIGNMENT = (16);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_COMMONSHADER_CONSTANT_BUFFER_REGISTER_COMPONENTS"]/*' />
    [NativeTypeName("#define D3D11_COMMONSHADER_CONSTANT_BUFFER_REGISTER_COMPONENTS ( 4 )")]
    public const int D3D11_COMMONSHADER_CONSTANT_BUFFER_REGISTER_COMPONENTS = (4);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_COMMONSHADER_CONSTANT_BUFFER_REGISTER_COUNT"]/*' />
    [NativeTypeName("#define D3D11_COMMONSHADER_CONSTANT_BUFFER_REGISTER_COUNT ( 15 )")]
    public const int D3D11_COMMONSHADER_CONSTANT_BUFFER_REGISTER_COUNT = (15);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_COMMONSHADER_CONSTANT_BUFFER_REGISTER_READS_PER_INST"]/*' />
    [NativeTypeName("#define D3D11_COMMONSHADER_CONSTANT_BUFFER_REGISTER_READS_PER_INST ( 1 )")]
    public const int D3D11_COMMONSHADER_CONSTANT_BUFFER_REGISTER_READS_PER_INST = (1);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_COMMONSHADER_CONSTANT_BUFFER_REGISTER_READ_PORTS"]/*' />
    [NativeTypeName("#define D3D11_COMMONSHADER_CONSTANT_BUFFER_REGISTER_READ_PORTS ( 1 )")]
    public const int D3D11_COMMONSHADER_CONSTANT_BUFFER_REGISTER_READ_PORTS = (1);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_COMMONSHADER_FLOWCONTROL_NESTING_LIMIT"]/*' />
    [NativeTypeName("#define D3D11_COMMONSHADER_FLOWCONTROL_NESTING_LIMIT ( 64 )")]
    public const int D3D11_COMMONSHADER_FLOWCONTROL_NESTING_LIMIT = (64);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_COMMONSHADER_IMMEDIATE_CONSTANT_BUFFER_REGISTER_COMPONENTS"]/*' />
    [NativeTypeName("#define D3D11_COMMONSHADER_IMMEDIATE_CONSTANT_BUFFER_REGISTER_COMPONENTS ( 4 )")]
    public const int D3D11_COMMONSHADER_IMMEDIATE_CONSTANT_BUFFER_REGISTER_COMPONENTS = (4);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_COMMONSHADER_IMMEDIATE_CONSTANT_BUFFER_REGISTER_COUNT"]/*' />
    [NativeTypeName("#define D3D11_COMMONSHADER_IMMEDIATE_CONSTANT_BUFFER_REGISTER_COUNT ( 1 )")]
    public const int D3D11_COMMONSHADER_IMMEDIATE_CONSTANT_BUFFER_REGISTER_COUNT = (1);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_COMMONSHADER_IMMEDIATE_CONSTANT_BUFFER_REGISTER_READS_PER_INST"]/*' />
    [NativeTypeName("#define D3D11_COMMONSHADER_IMMEDIATE_CONSTANT_BUFFER_REGISTER_READS_PER_INST ( 1 )")]
    public const int D3D11_COMMONSHADER_IMMEDIATE_CONSTANT_BUFFER_REGISTER_READS_PER_INST = (1);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_COMMONSHADER_IMMEDIATE_CONSTANT_BUFFER_REGISTER_READ_PORTS"]/*' />
    [NativeTypeName("#define D3D11_COMMONSHADER_IMMEDIATE_CONSTANT_BUFFER_REGISTER_READ_PORTS ( 1 )")]
    public const int D3D11_COMMONSHADER_IMMEDIATE_CONSTANT_BUFFER_REGISTER_READ_PORTS = (1);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_COMMONSHADER_IMMEDIATE_VALUE_COMPONENT_BIT_COUNT"]/*' />
    [NativeTypeName("#define D3D11_COMMONSHADER_IMMEDIATE_VALUE_COMPONENT_BIT_COUNT ( 32 )")]
    public const int D3D11_COMMONSHADER_IMMEDIATE_VALUE_COMPONENT_BIT_COUNT = (32);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_COMMONSHADER_INPUT_RESOURCE_REGISTER_COMPONENTS"]/*' />
    [NativeTypeName("#define D3D11_COMMONSHADER_INPUT_RESOURCE_REGISTER_COMPONENTS ( 1 )")]
    public const int D3D11_COMMONSHADER_INPUT_RESOURCE_REGISTER_COMPONENTS = (1);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_COMMONSHADER_INPUT_RESOURCE_REGISTER_COUNT"]/*' />
    [NativeTypeName("#define D3D11_COMMONSHADER_INPUT_RESOURCE_REGISTER_COUNT ( 128 )")]
    public const int D3D11_COMMONSHADER_INPUT_RESOURCE_REGISTER_COUNT = (128);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_COMMONSHADER_INPUT_RESOURCE_REGISTER_READS_PER_INST"]/*' />
    [NativeTypeName("#define D3D11_COMMONSHADER_INPUT_RESOURCE_REGISTER_READS_PER_INST ( 1 )")]
    public const int D3D11_COMMONSHADER_INPUT_RESOURCE_REGISTER_READS_PER_INST = (1);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_COMMONSHADER_INPUT_RESOURCE_REGISTER_READ_PORTS"]/*' />
    [NativeTypeName("#define D3D11_COMMONSHADER_INPUT_RESOURCE_REGISTER_READ_PORTS ( 1 )")]
    public const int D3D11_COMMONSHADER_INPUT_RESOURCE_REGISTER_READ_PORTS = (1);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_COMMONSHADER_INPUT_RESOURCE_SLOT_COUNT"]/*' />
    [NativeTypeName("#define D3D11_COMMONSHADER_INPUT_RESOURCE_SLOT_COUNT ( 128 )")]
    public const int D3D11_COMMONSHADER_INPUT_RESOURCE_SLOT_COUNT = (128);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_COMMONSHADER_SAMPLER_REGISTER_COMPONENTS"]/*' />
    [NativeTypeName("#define D3D11_COMMONSHADER_SAMPLER_REGISTER_COMPONENTS ( 1 )")]
    public const int D3D11_COMMONSHADER_SAMPLER_REGISTER_COMPONENTS = (1);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_COMMONSHADER_SAMPLER_REGISTER_COUNT"]/*' />
    [NativeTypeName("#define D3D11_COMMONSHADER_SAMPLER_REGISTER_COUNT ( 16 )")]
    public const int D3D11_COMMONSHADER_SAMPLER_REGISTER_COUNT = (16);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_COMMONSHADER_SAMPLER_REGISTER_READS_PER_INST"]/*' />
    [NativeTypeName("#define D3D11_COMMONSHADER_SAMPLER_REGISTER_READS_PER_INST ( 1 )")]
    public const int D3D11_COMMONSHADER_SAMPLER_REGISTER_READS_PER_INST = (1);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_COMMONSHADER_SAMPLER_REGISTER_READ_PORTS"]/*' />
    [NativeTypeName("#define D3D11_COMMONSHADER_SAMPLER_REGISTER_READ_PORTS ( 1 )")]
    public const int D3D11_COMMONSHADER_SAMPLER_REGISTER_READ_PORTS = (1);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_COMMONSHADER_SAMPLER_SLOT_COUNT"]/*' />
    [NativeTypeName("#define D3D11_COMMONSHADER_SAMPLER_SLOT_COUNT ( 16 )")]
    public const int D3D11_COMMONSHADER_SAMPLER_SLOT_COUNT = (16);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_COMMONSHADER_SUBROUTINE_NESTING_LIMIT"]/*' />
    [NativeTypeName("#define D3D11_COMMONSHADER_SUBROUTINE_NESTING_LIMIT ( 32 )")]
    public const int D3D11_COMMONSHADER_SUBROUTINE_NESTING_LIMIT = (32);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_COMMONSHADER_TEMP_REGISTER_COMPONENTS"]/*' />
    [NativeTypeName("#define D3D11_COMMONSHADER_TEMP_REGISTER_COMPONENTS ( 4 )")]
    public const int D3D11_COMMONSHADER_TEMP_REGISTER_COMPONENTS = (4);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_COMMONSHADER_TEMP_REGISTER_COMPONENT_BIT_COUNT"]/*' />
    [NativeTypeName("#define D3D11_COMMONSHADER_TEMP_REGISTER_COMPONENT_BIT_COUNT ( 32 )")]
    public const int D3D11_COMMONSHADER_TEMP_REGISTER_COMPONENT_BIT_COUNT = (32);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_COMMONSHADER_TEMP_REGISTER_COUNT"]/*' />
    [NativeTypeName("#define D3D11_COMMONSHADER_TEMP_REGISTER_COUNT ( 4096 )")]
    public const int D3D11_COMMONSHADER_TEMP_REGISTER_COUNT = (4096);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_COMMONSHADER_TEMP_REGISTER_READS_PER_INST"]/*' />
    [NativeTypeName("#define D3D11_COMMONSHADER_TEMP_REGISTER_READS_PER_INST ( 3 )")]
    public const int D3D11_COMMONSHADER_TEMP_REGISTER_READS_PER_INST = (3);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_COMMONSHADER_TEMP_REGISTER_READ_PORTS"]/*' />
    [NativeTypeName("#define D3D11_COMMONSHADER_TEMP_REGISTER_READ_PORTS ( 3 )")]
    public const int D3D11_COMMONSHADER_TEMP_REGISTER_READ_PORTS = (3);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_COMMONSHADER_TEXCOORD_RANGE_REDUCTION_MAX"]/*' />
    [NativeTypeName("#define D3D11_COMMONSHADER_TEXCOORD_RANGE_REDUCTION_MAX ( 10 )")]
    public const int D3D11_COMMONSHADER_TEXCOORD_RANGE_REDUCTION_MAX = (10);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_COMMONSHADER_TEXCOORD_RANGE_REDUCTION_MIN"]/*' />
    [NativeTypeName("#define D3D11_COMMONSHADER_TEXCOORD_RANGE_REDUCTION_MIN ( -10 )")]
    public const int D3D11_COMMONSHADER_TEXCOORD_RANGE_REDUCTION_MIN = (-10);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_COMMONSHADER_TEXEL_OFFSET_MAX_NEGATIVE"]/*' />
    [NativeTypeName("#define D3D11_COMMONSHADER_TEXEL_OFFSET_MAX_NEGATIVE ( -8 )")]
    public const int D3D11_COMMONSHADER_TEXEL_OFFSET_MAX_NEGATIVE = (-8);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_COMMONSHADER_TEXEL_OFFSET_MAX_POSITIVE"]/*' />
    [NativeTypeName("#define D3D11_COMMONSHADER_TEXEL_OFFSET_MAX_POSITIVE ( 7 )")]
    public const int D3D11_COMMONSHADER_TEXEL_OFFSET_MAX_POSITIVE = (7);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_CS_4_X_BUCKET00_MAX_BYTES_TGSM_WRITABLE_PER_THREAD"]/*' />
    [NativeTypeName("#define D3D11_CS_4_X_BUCKET00_MAX_BYTES_TGSM_WRITABLE_PER_THREAD ( 256 )")]
    public const int D3D11_CS_4_X_BUCKET00_MAX_BYTES_TGSM_WRITABLE_PER_THREAD = (256);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_CS_4_X_BUCKET00_MAX_NUM_THREADS_PER_GROUP"]/*' />
    [NativeTypeName("#define D3D11_CS_4_X_BUCKET00_MAX_NUM_THREADS_PER_GROUP ( 64 )")]
    public const int D3D11_CS_4_X_BUCKET00_MAX_NUM_THREADS_PER_GROUP = (64);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_CS_4_X_BUCKET01_MAX_BYTES_TGSM_WRITABLE_PER_THREAD"]/*' />
    [NativeTypeName("#define D3D11_CS_4_X_BUCKET01_MAX_BYTES_TGSM_WRITABLE_PER_THREAD ( 240 )")]
    public const int D3D11_CS_4_X_BUCKET01_MAX_BYTES_TGSM_WRITABLE_PER_THREAD = (240);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_CS_4_X_BUCKET01_MAX_NUM_THREADS_PER_GROUP"]/*' />
    [NativeTypeName("#define D3D11_CS_4_X_BUCKET01_MAX_NUM_THREADS_PER_GROUP ( 68 )")]
    public const int D3D11_CS_4_X_BUCKET01_MAX_NUM_THREADS_PER_GROUP = (68);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_CS_4_X_BUCKET02_MAX_BYTES_TGSM_WRITABLE_PER_THREAD"]/*' />
    [NativeTypeName("#define D3D11_CS_4_X_BUCKET02_MAX_BYTES_TGSM_WRITABLE_PER_THREAD ( 224 )")]
    public const int D3D11_CS_4_X_BUCKET02_MAX_BYTES_TGSM_WRITABLE_PER_THREAD = (224);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_CS_4_X_BUCKET02_MAX_NUM_THREADS_PER_GROUP"]/*' />
    [NativeTypeName("#define D3D11_CS_4_X_BUCKET02_MAX_NUM_THREADS_PER_GROUP ( 72 )")]
    public const int D3D11_CS_4_X_BUCKET02_MAX_NUM_THREADS_PER_GROUP = (72);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_CS_4_X_BUCKET03_MAX_BYTES_TGSM_WRITABLE_PER_THREAD"]/*' />
    [NativeTypeName("#define D3D11_CS_4_X_BUCKET03_MAX_BYTES_TGSM_WRITABLE_PER_THREAD ( 208 )")]
    public const int D3D11_CS_4_X_BUCKET03_MAX_BYTES_TGSM_WRITABLE_PER_THREAD = (208);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_CS_4_X_BUCKET03_MAX_NUM_THREADS_PER_GROUP"]/*' />
    [NativeTypeName("#define D3D11_CS_4_X_BUCKET03_MAX_NUM_THREADS_PER_GROUP ( 76 )")]
    public const int D3D11_CS_4_X_BUCKET03_MAX_NUM_THREADS_PER_GROUP = (76);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_CS_4_X_BUCKET04_MAX_BYTES_TGSM_WRITABLE_PER_THREAD"]/*' />
    [NativeTypeName("#define D3D11_CS_4_X_BUCKET04_MAX_BYTES_TGSM_WRITABLE_PER_THREAD ( 192 )")]
    public const int D3D11_CS_4_X_BUCKET04_MAX_BYTES_TGSM_WRITABLE_PER_THREAD = (192);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_CS_4_X_BUCKET04_MAX_NUM_THREADS_PER_GROUP"]/*' />
    [NativeTypeName("#define D3D11_CS_4_X_BUCKET04_MAX_NUM_THREADS_PER_GROUP ( 84 )")]
    public const int D3D11_CS_4_X_BUCKET04_MAX_NUM_THREADS_PER_GROUP = (84);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_CS_4_X_BUCKET05_MAX_BYTES_TGSM_WRITABLE_PER_THREAD"]/*' />
    [NativeTypeName("#define D3D11_CS_4_X_BUCKET05_MAX_BYTES_TGSM_WRITABLE_PER_THREAD ( 176 )")]
    public const int D3D11_CS_4_X_BUCKET05_MAX_BYTES_TGSM_WRITABLE_PER_THREAD = (176);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_CS_4_X_BUCKET05_MAX_NUM_THREADS_PER_GROUP"]/*' />
    [NativeTypeName("#define D3D11_CS_4_X_BUCKET05_MAX_NUM_THREADS_PER_GROUP ( 92 )")]
    public const int D3D11_CS_4_X_BUCKET05_MAX_NUM_THREADS_PER_GROUP = (92);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_CS_4_X_BUCKET06_MAX_BYTES_TGSM_WRITABLE_PER_THREAD"]/*' />
    [NativeTypeName("#define D3D11_CS_4_X_BUCKET06_MAX_BYTES_TGSM_WRITABLE_PER_THREAD ( 160 )")]
    public const int D3D11_CS_4_X_BUCKET06_MAX_BYTES_TGSM_WRITABLE_PER_THREAD = (160);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_CS_4_X_BUCKET06_MAX_NUM_THREADS_PER_GROUP"]/*' />
    [NativeTypeName("#define D3D11_CS_4_X_BUCKET06_MAX_NUM_THREADS_PER_GROUP ( 100 )")]
    public const int D3D11_CS_4_X_BUCKET06_MAX_NUM_THREADS_PER_GROUP = (100);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_CS_4_X_BUCKET07_MAX_BYTES_TGSM_WRITABLE_PER_THREAD"]/*' />
    [NativeTypeName("#define D3D11_CS_4_X_BUCKET07_MAX_BYTES_TGSM_WRITABLE_PER_THREAD ( 144 )")]
    public const int D3D11_CS_4_X_BUCKET07_MAX_BYTES_TGSM_WRITABLE_PER_THREAD = (144);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_CS_4_X_BUCKET07_MAX_NUM_THREADS_PER_GROUP"]/*' />
    [NativeTypeName("#define D3D11_CS_4_X_BUCKET07_MAX_NUM_THREADS_PER_GROUP ( 112 )")]
    public const int D3D11_CS_4_X_BUCKET07_MAX_NUM_THREADS_PER_GROUP = (112);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_CS_4_X_BUCKET08_MAX_BYTES_TGSM_WRITABLE_PER_THREAD"]/*' />
    [NativeTypeName("#define D3D11_CS_4_X_BUCKET08_MAX_BYTES_TGSM_WRITABLE_PER_THREAD ( 128 )")]
    public const int D3D11_CS_4_X_BUCKET08_MAX_BYTES_TGSM_WRITABLE_PER_THREAD = (128);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_CS_4_X_BUCKET08_MAX_NUM_THREADS_PER_GROUP"]/*' />
    [NativeTypeName("#define D3D11_CS_4_X_BUCKET08_MAX_NUM_THREADS_PER_GROUP ( 128 )")]
    public const int D3D11_CS_4_X_BUCKET08_MAX_NUM_THREADS_PER_GROUP = (128);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_CS_4_X_BUCKET09_MAX_BYTES_TGSM_WRITABLE_PER_THREAD"]/*' />
    [NativeTypeName("#define D3D11_CS_4_X_BUCKET09_MAX_BYTES_TGSM_WRITABLE_PER_THREAD ( 112 )")]
    public const int D3D11_CS_4_X_BUCKET09_MAX_BYTES_TGSM_WRITABLE_PER_THREAD = (112);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_CS_4_X_BUCKET09_MAX_NUM_THREADS_PER_GROUP"]/*' />
    [NativeTypeName("#define D3D11_CS_4_X_BUCKET09_MAX_NUM_THREADS_PER_GROUP ( 144 )")]
    public const int D3D11_CS_4_X_BUCKET09_MAX_NUM_THREADS_PER_GROUP = (144);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_CS_4_X_BUCKET10_MAX_BYTES_TGSM_WRITABLE_PER_THREAD"]/*' />
    [NativeTypeName("#define D3D11_CS_4_X_BUCKET10_MAX_BYTES_TGSM_WRITABLE_PER_THREAD ( 96 )")]
    public const int D3D11_CS_4_X_BUCKET10_MAX_BYTES_TGSM_WRITABLE_PER_THREAD = (96);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_CS_4_X_BUCKET10_MAX_NUM_THREADS_PER_GROUP"]/*' />
    [NativeTypeName("#define D3D11_CS_4_X_BUCKET10_MAX_NUM_THREADS_PER_GROUP ( 168 )")]
    public const int D3D11_CS_4_X_BUCKET10_MAX_NUM_THREADS_PER_GROUP = (168);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_CS_4_X_BUCKET11_MAX_BYTES_TGSM_WRITABLE_PER_THREAD"]/*' />
    [NativeTypeName("#define D3D11_CS_4_X_BUCKET11_MAX_BYTES_TGSM_WRITABLE_PER_THREAD ( 80 )")]
    public const int D3D11_CS_4_X_BUCKET11_MAX_BYTES_TGSM_WRITABLE_PER_THREAD = (80);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_CS_4_X_BUCKET11_MAX_NUM_THREADS_PER_GROUP"]/*' />
    [NativeTypeName("#define D3D11_CS_4_X_BUCKET11_MAX_NUM_THREADS_PER_GROUP ( 204 )")]
    public const int D3D11_CS_4_X_BUCKET11_MAX_NUM_THREADS_PER_GROUP = (204);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_CS_4_X_BUCKET12_MAX_BYTES_TGSM_WRITABLE_PER_THREAD"]/*' />
    [NativeTypeName("#define D3D11_CS_4_X_BUCKET12_MAX_BYTES_TGSM_WRITABLE_PER_THREAD ( 64 )")]
    public const int D3D11_CS_4_X_BUCKET12_MAX_BYTES_TGSM_WRITABLE_PER_THREAD = (64);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_CS_4_X_BUCKET12_MAX_NUM_THREADS_PER_GROUP"]/*' />
    [NativeTypeName("#define D3D11_CS_4_X_BUCKET12_MAX_NUM_THREADS_PER_GROUP ( 256 )")]
    public const int D3D11_CS_4_X_BUCKET12_MAX_NUM_THREADS_PER_GROUP = (256);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_CS_4_X_BUCKET13_MAX_BYTES_TGSM_WRITABLE_PER_THREAD"]/*' />
    [NativeTypeName("#define D3D11_CS_4_X_BUCKET13_MAX_BYTES_TGSM_WRITABLE_PER_THREAD ( 48 )")]
    public const int D3D11_CS_4_X_BUCKET13_MAX_BYTES_TGSM_WRITABLE_PER_THREAD = (48);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_CS_4_X_BUCKET13_MAX_NUM_THREADS_PER_GROUP"]/*' />
    [NativeTypeName("#define D3D11_CS_4_X_BUCKET13_MAX_NUM_THREADS_PER_GROUP ( 340 )")]
    public const int D3D11_CS_4_X_BUCKET13_MAX_NUM_THREADS_PER_GROUP = (340);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_CS_4_X_BUCKET14_MAX_BYTES_TGSM_WRITABLE_PER_THREAD"]/*' />
    [NativeTypeName("#define D3D11_CS_4_X_BUCKET14_MAX_BYTES_TGSM_WRITABLE_PER_THREAD ( 32 )")]
    public const int D3D11_CS_4_X_BUCKET14_MAX_BYTES_TGSM_WRITABLE_PER_THREAD = (32);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_CS_4_X_BUCKET14_MAX_NUM_THREADS_PER_GROUP"]/*' />
    [NativeTypeName("#define D3D11_CS_4_X_BUCKET14_MAX_NUM_THREADS_PER_GROUP ( 512 )")]
    public const int D3D11_CS_4_X_BUCKET14_MAX_NUM_THREADS_PER_GROUP = (512);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_CS_4_X_BUCKET15_MAX_BYTES_TGSM_WRITABLE_PER_THREAD"]/*' />
    [NativeTypeName("#define D3D11_CS_4_X_BUCKET15_MAX_BYTES_TGSM_WRITABLE_PER_THREAD ( 16 )")]
    public const int D3D11_CS_4_X_BUCKET15_MAX_BYTES_TGSM_WRITABLE_PER_THREAD = (16);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_CS_4_X_BUCKET15_MAX_NUM_THREADS_PER_GROUP"]/*' />
    [NativeTypeName("#define D3D11_CS_4_X_BUCKET15_MAX_NUM_THREADS_PER_GROUP ( 768 )")]
    public const int D3D11_CS_4_X_BUCKET15_MAX_NUM_THREADS_PER_GROUP = (768);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_CS_4_X_DISPATCH_MAX_THREAD_GROUPS_IN_Z_DIMENSION"]/*' />
    [NativeTypeName("#define D3D11_CS_4_X_DISPATCH_MAX_THREAD_GROUPS_IN_Z_DIMENSION ( 1 )")]
    public const int D3D11_CS_4_X_DISPATCH_MAX_THREAD_GROUPS_IN_Z_DIMENSION = (1);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_CS_4_X_RAW_UAV_BYTE_ALIGNMENT"]/*' />
    [NativeTypeName("#define D3D11_CS_4_X_RAW_UAV_BYTE_ALIGNMENT ( 256 )")]
    public const int D3D11_CS_4_X_RAW_UAV_BYTE_ALIGNMENT = (256);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_CS_4_X_THREAD_GROUP_MAX_THREADS_PER_GROUP"]/*' />
    [NativeTypeName("#define D3D11_CS_4_X_THREAD_GROUP_MAX_THREADS_PER_GROUP ( 768 )")]
    public const int D3D11_CS_4_X_THREAD_GROUP_MAX_THREADS_PER_GROUP = (768);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_CS_4_X_THREAD_GROUP_MAX_X"]/*' />
    [NativeTypeName("#define D3D11_CS_4_X_THREAD_GROUP_MAX_X ( 768 )")]
    public const int D3D11_CS_4_X_THREAD_GROUP_MAX_X = (768);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_CS_4_X_THREAD_GROUP_MAX_Y"]/*' />
    [NativeTypeName("#define D3D11_CS_4_X_THREAD_GROUP_MAX_Y ( 768 )")]
    public const int D3D11_CS_4_X_THREAD_GROUP_MAX_Y = (768);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_CS_4_X_UAV_REGISTER_COUNT"]/*' />
    [NativeTypeName("#define D3D11_CS_4_X_UAV_REGISTER_COUNT ( 1 )")]
    public const int D3D11_CS_4_X_UAV_REGISTER_COUNT = (1);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_CS_DISPATCH_MAX_THREAD_GROUPS_PER_DIMENSION"]/*' />
    [NativeTypeName("#define D3D11_CS_DISPATCH_MAX_THREAD_GROUPS_PER_DIMENSION ( 65535 )")]
    public const int D3D11_CS_DISPATCH_MAX_THREAD_GROUPS_PER_DIMENSION = (65535);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_CS_TGSM_REGISTER_COUNT"]/*' />
    [NativeTypeName("#define D3D11_CS_TGSM_REGISTER_COUNT ( 8192 )")]
    public const int D3D11_CS_TGSM_REGISTER_COUNT = (8192);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_CS_TGSM_REGISTER_READS_PER_INST"]/*' />
    [NativeTypeName("#define D3D11_CS_TGSM_REGISTER_READS_PER_INST ( 1 )")]
    public const int D3D11_CS_TGSM_REGISTER_READS_PER_INST = (1);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_CS_TGSM_RESOURCE_REGISTER_COMPONENTS"]/*' />
    [NativeTypeName("#define D3D11_CS_TGSM_RESOURCE_REGISTER_COMPONENTS ( 1 )")]
    public const int D3D11_CS_TGSM_RESOURCE_REGISTER_COMPONENTS = (1);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_CS_TGSM_RESOURCE_REGISTER_READ_PORTS"]/*' />
    [NativeTypeName("#define D3D11_CS_TGSM_RESOURCE_REGISTER_READ_PORTS ( 1 )")]
    public const int D3D11_CS_TGSM_RESOURCE_REGISTER_READ_PORTS = (1);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_CS_THREADGROUPID_REGISTER_COMPONENTS"]/*' />
    [NativeTypeName("#define D3D11_CS_THREADGROUPID_REGISTER_COMPONENTS ( 3 )")]
    public const int D3D11_CS_THREADGROUPID_REGISTER_COMPONENTS = (3);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_CS_THREADGROUPID_REGISTER_COUNT"]/*' />
    [NativeTypeName("#define D3D11_CS_THREADGROUPID_REGISTER_COUNT ( 1 )")]
    public const int D3D11_CS_THREADGROUPID_REGISTER_COUNT = (1);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_CS_THREADIDINGROUPFLATTENED_REGISTER_COMPONENTS"]/*' />
    [NativeTypeName("#define D3D11_CS_THREADIDINGROUPFLATTENED_REGISTER_COMPONENTS ( 1 )")]
    public const int D3D11_CS_THREADIDINGROUPFLATTENED_REGISTER_COMPONENTS = (1);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_CS_THREADIDINGROUPFLATTENED_REGISTER_COUNT"]/*' />
    [NativeTypeName("#define D3D11_CS_THREADIDINGROUPFLATTENED_REGISTER_COUNT ( 1 )")]
    public const int D3D11_CS_THREADIDINGROUPFLATTENED_REGISTER_COUNT = (1);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_CS_THREADIDINGROUP_REGISTER_COMPONENTS"]/*' />
    [NativeTypeName("#define D3D11_CS_THREADIDINGROUP_REGISTER_COMPONENTS ( 3 )")]
    public const int D3D11_CS_THREADIDINGROUP_REGISTER_COMPONENTS = (3);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_CS_THREADIDINGROUP_REGISTER_COUNT"]/*' />
    [NativeTypeName("#define D3D11_CS_THREADIDINGROUP_REGISTER_COUNT ( 1 )")]
    public const int D3D11_CS_THREADIDINGROUP_REGISTER_COUNT = (1);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_CS_THREADID_REGISTER_COMPONENTS"]/*' />
    [NativeTypeName("#define D3D11_CS_THREADID_REGISTER_COMPONENTS ( 3 )")]
    public const int D3D11_CS_THREADID_REGISTER_COMPONENTS = (3);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_CS_THREADID_REGISTER_COUNT"]/*' />
    [NativeTypeName("#define D3D11_CS_THREADID_REGISTER_COUNT ( 1 )")]
    public const int D3D11_CS_THREADID_REGISTER_COUNT = (1);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_CS_THREAD_GROUP_MAX_THREADS_PER_GROUP"]/*' />
    [NativeTypeName("#define D3D11_CS_THREAD_GROUP_MAX_THREADS_PER_GROUP ( 1024 )")]
    public const int D3D11_CS_THREAD_GROUP_MAX_THREADS_PER_GROUP = (1024);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_CS_THREAD_GROUP_MAX_X"]/*' />
    [NativeTypeName("#define D3D11_CS_THREAD_GROUP_MAX_X ( 1024 )")]
    public const int D3D11_CS_THREAD_GROUP_MAX_X = (1024);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_CS_THREAD_GROUP_MAX_Y"]/*' />
    [NativeTypeName("#define D3D11_CS_THREAD_GROUP_MAX_Y ( 1024 )")]
    public const int D3D11_CS_THREAD_GROUP_MAX_Y = (1024);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_CS_THREAD_GROUP_MAX_Z"]/*' />
    [NativeTypeName("#define D3D11_CS_THREAD_GROUP_MAX_Z ( 64 )")]
    public const int D3D11_CS_THREAD_GROUP_MAX_Z = (64);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_CS_THREAD_GROUP_MIN_X"]/*' />
    [NativeTypeName("#define D3D11_CS_THREAD_GROUP_MIN_X ( 1 )")]
    public const int D3D11_CS_THREAD_GROUP_MIN_X = (1);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_CS_THREAD_GROUP_MIN_Y"]/*' />
    [NativeTypeName("#define D3D11_CS_THREAD_GROUP_MIN_Y ( 1 )")]
    public const int D3D11_CS_THREAD_GROUP_MIN_Y = (1);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_CS_THREAD_GROUP_MIN_Z"]/*' />
    [NativeTypeName("#define D3D11_CS_THREAD_GROUP_MIN_Z ( 1 )")]
    public const int D3D11_CS_THREAD_GROUP_MIN_Z = (1);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_CS_THREAD_LOCAL_TEMP_REGISTER_POOL"]/*' />
    [NativeTypeName("#define D3D11_CS_THREAD_LOCAL_TEMP_REGISTER_POOL ( 16384 )")]
    public const int D3D11_CS_THREAD_LOCAL_TEMP_REGISTER_POOL = (16384);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_DEFAULT_BLEND_FACTOR_ALPHA"]/*' />
    [NativeTypeName("#define D3D11_DEFAULT_BLEND_FACTOR_ALPHA ( 1.0f )")]
    public const float D3D11_DEFAULT_BLEND_FACTOR_ALPHA = (1.0f);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_DEFAULT_BLEND_FACTOR_BLUE"]/*' />
    [NativeTypeName("#define D3D11_DEFAULT_BLEND_FACTOR_BLUE ( 1.0f )")]
    public const float D3D11_DEFAULT_BLEND_FACTOR_BLUE = (1.0f);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_DEFAULT_BLEND_FACTOR_GREEN"]/*' />
    [NativeTypeName("#define D3D11_DEFAULT_BLEND_FACTOR_GREEN ( 1.0f )")]
    public const float D3D11_DEFAULT_BLEND_FACTOR_GREEN = (1.0f);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_DEFAULT_BLEND_FACTOR_RED"]/*' />
    [NativeTypeName("#define D3D11_DEFAULT_BLEND_FACTOR_RED ( 1.0f )")]
    public const float D3D11_DEFAULT_BLEND_FACTOR_RED = (1.0f);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_DEFAULT_BORDER_COLOR_COMPONENT"]/*' />
    [NativeTypeName("#define D3D11_DEFAULT_BORDER_COLOR_COMPONENT ( 0.0f )")]
    public const float D3D11_DEFAULT_BORDER_COLOR_COMPONENT = (0.0f);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_DEFAULT_DEPTH_BIAS"]/*' />
    [NativeTypeName("#define D3D11_DEFAULT_DEPTH_BIAS ( 0 )")]
    public const int D3D11_DEFAULT_DEPTH_BIAS = (0);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_DEFAULT_DEPTH_BIAS_CLAMP"]/*' />
    [NativeTypeName("#define D3D11_DEFAULT_DEPTH_BIAS_CLAMP ( 0.0f )")]
    public const float D3D11_DEFAULT_DEPTH_BIAS_CLAMP = (0.0f);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_DEFAULT_MAX_ANISOTROPY"]/*' />
    [NativeTypeName("#define D3D11_DEFAULT_MAX_ANISOTROPY ( 16 )")]
    public const int D3D11_DEFAULT_MAX_ANISOTROPY = (16);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_DEFAULT_MIP_LOD_BIAS"]/*' />
    [NativeTypeName("#define D3D11_DEFAULT_MIP_LOD_BIAS ( 0.0f )")]
    public const float D3D11_DEFAULT_MIP_LOD_BIAS = (0.0f);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_DEFAULT_RENDER_TARGET_ARRAY_INDEX"]/*' />
    [NativeTypeName("#define D3D11_DEFAULT_RENDER_TARGET_ARRAY_INDEX ( 0 )")]
    public const int D3D11_DEFAULT_RENDER_TARGET_ARRAY_INDEX = (0);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_DEFAULT_SAMPLE_MASK"]/*' />
    [NativeTypeName("#define D3D11_DEFAULT_SAMPLE_MASK ( 0xffffffff )")]
    public const uint D3D11_DEFAULT_SAMPLE_MASK = (0xffffffff);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_DEFAULT_SCISSOR_ENDX"]/*' />
    [NativeTypeName("#define D3D11_DEFAULT_SCISSOR_ENDX ( 0 )")]
    public const int D3D11_DEFAULT_SCISSOR_ENDX = (0);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_DEFAULT_SCISSOR_ENDY"]/*' />
    [NativeTypeName("#define D3D11_DEFAULT_SCISSOR_ENDY ( 0 )")]
    public const int D3D11_DEFAULT_SCISSOR_ENDY = (0);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_DEFAULT_SCISSOR_STARTX"]/*' />
    [NativeTypeName("#define D3D11_DEFAULT_SCISSOR_STARTX ( 0 )")]
    public const int D3D11_DEFAULT_SCISSOR_STARTX = (0);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_DEFAULT_SCISSOR_STARTY"]/*' />
    [NativeTypeName("#define D3D11_DEFAULT_SCISSOR_STARTY ( 0 )")]
    public const int D3D11_DEFAULT_SCISSOR_STARTY = (0);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_DEFAULT_SLOPE_SCALED_DEPTH_BIAS"]/*' />
    [NativeTypeName("#define D3D11_DEFAULT_SLOPE_SCALED_DEPTH_BIAS ( 0.0f )")]
    public const float D3D11_DEFAULT_SLOPE_SCALED_DEPTH_BIAS = (0.0f);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_DEFAULT_STENCIL_READ_MASK"]/*' />
    [NativeTypeName("#define D3D11_DEFAULT_STENCIL_READ_MASK ( 0xff )")]
    public const int D3D11_DEFAULT_STENCIL_READ_MASK = (0xff);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_DEFAULT_STENCIL_REFERENCE"]/*' />
    [NativeTypeName("#define D3D11_DEFAULT_STENCIL_REFERENCE ( 0 )")]
    public const int D3D11_DEFAULT_STENCIL_REFERENCE = (0);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_DEFAULT_STENCIL_WRITE_MASK"]/*' />
    [NativeTypeName("#define D3D11_DEFAULT_STENCIL_WRITE_MASK ( 0xff )")]
    public const int D3D11_DEFAULT_STENCIL_WRITE_MASK = (0xff);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_DEFAULT_VIEWPORT_AND_SCISSORRECT_INDEX"]/*' />
    [NativeTypeName("#define D3D11_DEFAULT_VIEWPORT_AND_SCISSORRECT_INDEX ( 0 )")]
    public const int D3D11_DEFAULT_VIEWPORT_AND_SCISSORRECT_INDEX = (0);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_DEFAULT_VIEWPORT_HEIGHT"]/*' />
    [NativeTypeName("#define D3D11_DEFAULT_VIEWPORT_HEIGHT ( 0 )")]
    public const int D3D11_DEFAULT_VIEWPORT_HEIGHT = (0);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_DEFAULT_VIEWPORT_MAX_DEPTH"]/*' />
    [NativeTypeName("#define D3D11_DEFAULT_VIEWPORT_MAX_DEPTH ( 0.0f )")]
    public const float D3D11_DEFAULT_VIEWPORT_MAX_DEPTH = (0.0f);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_DEFAULT_VIEWPORT_MIN_DEPTH"]/*' />
    [NativeTypeName("#define D3D11_DEFAULT_VIEWPORT_MIN_DEPTH ( 0.0f )")]
    public const float D3D11_DEFAULT_VIEWPORT_MIN_DEPTH = (0.0f);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_DEFAULT_VIEWPORT_TOPLEFTX"]/*' />
    [NativeTypeName("#define D3D11_DEFAULT_VIEWPORT_TOPLEFTX ( 0 )")]
    public const int D3D11_DEFAULT_VIEWPORT_TOPLEFTX = (0);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_DEFAULT_VIEWPORT_TOPLEFTY"]/*' />
    [NativeTypeName("#define D3D11_DEFAULT_VIEWPORT_TOPLEFTY ( 0 )")]
    public const int D3D11_DEFAULT_VIEWPORT_TOPLEFTY = (0);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_DEFAULT_VIEWPORT_WIDTH"]/*' />
    [NativeTypeName("#define D3D11_DEFAULT_VIEWPORT_WIDTH ( 0 )")]
    public const int D3D11_DEFAULT_VIEWPORT_WIDTH = (0);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_DS_INPUT_CONTROL_POINTS_MAX_TOTAL_SCALARS"]/*' />
    [NativeTypeName("#define D3D11_DS_INPUT_CONTROL_POINTS_MAX_TOTAL_SCALARS ( 3968 )")]
    public const int D3D11_DS_INPUT_CONTROL_POINTS_MAX_TOTAL_SCALARS = (3968);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_DS_INPUT_CONTROL_POINT_REGISTER_COMPONENTS"]/*' />
    [NativeTypeName("#define D3D11_DS_INPUT_CONTROL_POINT_REGISTER_COMPONENTS ( 4 )")]
    public const int D3D11_DS_INPUT_CONTROL_POINT_REGISTER_COMPONENTS = (4);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_DS_INPUT_CONTROL_POINT_REGISTER_COMPONENT_BIT_COUNT"]/*' />
    [NativeTypeName("#define D3D11_DS_INPUT_CONTROL_POINT_REGISTER_COMPONENT_BIT_COUNT ( 32 )")]
    public const int D3D11_DS_INPUT_CONTROL_POINT_REGISTER_COMPONENT_BIT_COUNT = (32);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_DS_INPUT_CONTROL_POINT_REGISTER_COUNT"]/*' />
    [NativeTypeName("#define D3D11_DS_INPUT_CONTROL_POINT_REGISTER_COUNT ( 32 )")]
    public const int D3D11_DS_INPUT_CONTROL_POINT_REGISTER_COUNT = (32);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_DS_INPUT_CONTROL_POINT_REGISTER_READS_PER_INST"]/*' />
    [NativeTypeName("#define D3D11_DS_INPUT_CONTROL_POINT_REGISTER_READS_PER_INST ( 2 )")]
    public const int D3D11_DS_INPUT_CONTROL_POINT_REGISTER_READS_PER_INST = (2);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_DS_INPUT_CONTROL_POINT_REGISTER_READ_PORTS"]/*' />
    [NativeTypeName("#define D3D11_DS_INPUT_CONTROL_POINT_REGISTER_READ_PORTS ( 1 )")]
    public const int D3D11_DS_INPUT_CONTROL_POINT_REGISTER_READ_PORTS = (1);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_DS_INPUT_DOMAIN_POINT_REGISTER_COMPONENTS"]/*' />
    [NativeTypeName("#define D3D11_DS_INPUT_DOMAIN_POINT_REGISTER_COMPONENTS ( 3 )")]
    public const int D3D11_DS_INPUT_DOMAIN_POINT_REGISTER_COMPONENTS = (3);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_DS_INPUT_DOMAIN_POINT_REGISTER_COMPONENT_BIT_COUNT"]/*' />
    [NativeTypeName("#define D3D11_DS_INPUT_DOMAIN_POINT_REGISTER_COMPONENT_BIT_COUNT ( 32 )")]
    public const int D3D11_DS_INPUT_DOMAIN_POINT_REGISTER_COMPONENT_BIT_COUNT = (32);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_DS_INPUT_DOMAIN_POINT_REGISTER_COUNT"]/*' />
    [NativeTypeName("#define D3D11_DS_INPUT_DOMAIN_POINT_REGISTER_COUNT ( 1 )")]
    public const int D3D11_DS_INPUT_DOMAIN_POINT_REGISTER_COUNT = (1);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_DS_INPUT_DOMAIN_POINT_REGISTER_READS_PER_INST"]/*' />
    [NativeTypeName("#define D3D11_DS_INPUT_DOMAIN_POINT_REGISTER_READS_PER_INST ( 2 )")]
    public const int D3D11_DS_INPUT_DOMAIN_POINT_REGISTER_READS_PER_INST = (2);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_DS_INPUT_DOMAIN_POINT_REGISTER_READ_PORTS"]/*' />
    [NativeTypeName("#define D3D11_DS_INPUT_DOMAIN_POINT_REGISTER_READ_PORTS ( 1 )")]
    public const int D3D11_DS_INPUT_DOMAIN_POINT_REGISTER_READ_PORTS = (1);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_DS_INPUT_PATCH_CONSTANT_REGISTER_COMPONENTS"]/*' />
    [NativeTypeName("#define D3D11_DS_INPUT_PATCH_CONSTANT_REGISTER_COMPONENTS ( 4 )")]
    public const int D3D11_DS_INPUT_PATCH_CONSTANT_REGISTER_COMPONENTS = (4);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_DS_INPUT_PATCH_CONSTANT_REGISTER_COMPONENT_BIT_COUNT"]/*' />
    [NativeTypeName("#define D3D11_DS_INPUT_PATCH_CONSTANT_REGISTER_COMPONENT_BIT_COUNT ( 32 )")]
    public const int D3D11_DS_INPUT_PATCH_CONSTANT_REGISTER_COMPONENT_BIT_COUNT = (32);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_DS_INPUT_PATCH_CONSTANT_REGISTER_COUNT"]/*' />
    [NativeTypeName("#define D3D11_DS_INPUT_PATCH_CONSTANT_REGISTER_COUNT ( 32 )")]
    public const int D3D11_DS_INPUT_PATCH_CONSTANT_REGISTER_COUNT = (32);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_DS_INPUT_PATCH_CONSTANT_REGISTER_READS_PER_INST"]/*' />
    [NativeTypeName("#define D3D11_DS_INPUT_PATCH_CONSTANT_REGISTER_READS_PER_INST ( 2 )")]
    public const int D3D11_DS_INPUT_PATCH_CONSTANT_REGISTER_READS_PER_INST = (2);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_DS_INPUT_PATCH_CONSTANT_REGISTER_READ_PORTS"]/*' />
    [NativeTypeName("#define D3D11_DS_INPUT_PATCH_CONSTANT_REGISTER_READ_PORTS ( 1 )")]
    public const int D3D11_DS_INPUT_PATCH_CONSTANT_REGISTER_READ_PORTS = (1);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_DS_INPUT_PRIMITIVE_ID_REGISTER_COMPONENTS"]/*' />
    [NativeTypeName("#define D3D11_DS_INPUT_PRIMITIVE_ID_REGISTER_COMPONENTS ( 1 )")]
    public const int D3D11_DS_INPUT_PRIMITIVE_ID_REGISTER_COMPONENTS = (1);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_DS_INPUT_PRIMITIVE_ID_REGISTER_COMPONENT_BIT_COUNT"]/*' />
    [NativeTypeName("#define D3D11_DS_INPUT_PRIMITIVE_ID_REGISTER_COMPONENT_BIT_COUNT ( 32 )")]
    public const int D3D11_DS_INPUT_PRIMITIVE_ID_REGISTER_COMPONENT_BIT_COUNT = (32);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_DS_INPUT_PRIMITIVE_ID_REGISTER_COUNT"]/*' />
    [NativeTypeName("#define D3D11_DS_INPUT_PRIMITIVE_ID_REGISTER_COUNT ( 1 )")]
    public const int D3D11_DS_INPUT_PRIMITIVE_ID_REGISTER_COUNT = (1);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_DS_INPUT_PRIMITIVE_ID_REGISTER_READS_PER_INST"]/*' />
    [NativeTypeName("#define D3D11_DS_INPUT_PRIMITIVE_ID_REGISTER_READS_PER_INST ( 2 )")]
    public const int D3D11_DS_INPUT_PRIMITIVE_ID_REGISTER_READS_PER_INST = (2);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_DS_INPUT_PRIMITIVE_ID_REGISTER_READ_PORTS"]/*' />
    [NativeTypeName("#define D3D11_DS_INPUT_PRIMITIVE_ID_REGISTER_READ_PORTS ( 1 )")]
    public const int D3D11_DS_INPUT_PRIMITIVE_ID_REGISTER_READ_PORTS = (1);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_DS_OUTPUT_REGISTER_COMPONENTS"]/*' />
    [NativeTypeName("#define D3D11_DS_OUTPUT_REGISTER_COMPONENTS ( 4 )")]
    public const int D3D11_DS_OUTPUT_REGISTER_COMPONENTS = (4);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_DS_OUTPUT_REGISTER_COMPONENT_BIT_COUNT"]/*' />
    [NativeTypeName("#define D3D11_DS_OUTPUT_REGISTER_COMPONENT_BIT_COUNT ( 32 )")]
    public const int D3D11_DS_OUTPUT_REGISTER_COMPONENT_BIT_COUNT = (32);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_DS_OUTPUT_REGISTER_COUNT"]/*' />
    [NativeTypeName("#define D3D11_DS_OUTPUT_REGISTER_COUNT ( 32 )")]
    public const int D3D11_DS_OUTPUT_REGISTER_COUNT = (32);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_FLOAT16_FUSED_TOLERANCE_IN_ULP"]/*' />
    [NativeTypeName("#define D3D11_FLOAT16_FUSED_TOLERANCE_IN_ULP ( 0.6 )")]
    public const double D3D11_FLOAT16_FUSED_TOLERANCE_IN_ULP = (0.6);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_FLOAT32_MAX"]/*' />
    [NativeTypeName("#define D3D11_FLOAT32_MAX ( 3.402823466e+38f )")]
    public const float D3D11_FLOAT32_MAX = (3.402823466e+38f);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_FLOAT32_TO_INTEGER_TOLERANCE_IN_ULP"]/*' />
    [NativeTypeName("#define D3D11_FLOAT32_TO_INTEGER_TOLERANCE_IN_ULP ( 0.6f )")]
    public const float D3D11_FLOAT32_TO_INTEGER_TOLERANCE_IN_ULP = (0.6f);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_FLOAT_TO_SRGB_EXPONENT_DENOMINATOR"]/*' />
    [NativeTypeName("#define D3D11_FLOAT_TO_SRGB_EXPONENT_DENOMINATOR ( 2.4f )")]
    public const float D3D11_FLOAT_TO_SRGB_EXPONENT_DENOMINATOR = (2.4f);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_FLOAT_TO_SRGB_EXPONENT_NUMERATOR"]/*' />
    [NativeTypeName("#define D3D11_FLOAT_TO_SRGB_EXPONENT_NUMERATOR ( 1.0f )")]
    public const float D3D11_FLOAT_TO_SRGB_EXPONENT_NUMERATOR = (1.0f);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_FLOAT_TO_SRGB_OFFSET"]/*' />
    [NativeTypeName("#define D3D11_FLOAT_TO_SRGB_OFFSET ( 0.055f )")]
    public const float D3D11_FLOAT_TO_SRGB_OFFSET = (0.055f);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_FLOAT_TO_SRGB_SCALE_1"]/*' />
    [NativeTypeName("#define D3D11_FLOAT_TO_SRGB_SCALE_1 ( 12.92f )")]
    public const float D3D11_FLOAT_TO_SRGB_SCALE_1 = (12.92f);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_FLOAT_TO_SRGB_SCALE_2"]/*' />
    [NativeTypeName("#define D3D11_FLOAT_TO_SRGB_SCALE_2 ( 1.055f )")]
    public const float D3D11_FLOAT_TO_SRGB_SCALE_2 = (1.055f);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_FLOAT_TO_SRGB_THRESHOLD"]/*' />
    [NativeTypeName("#define D3D11_FLOAT_TO_SRGB_THRESHOLD ( 0.0031308f )")]
    public const float D3D11_FLOAT_TO_SRGB_THRESHOLD = (0.0031308f);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_FTOI_INSTRUCTION_MAX_INPUT"]/*' />
    [NativeTypeName("#define D3D11_FTOI_INSTRUCTION_MAX_INPUT ( 2147483647.999f )")]
    public const float D3D11_FTOI_INSTRUCTION_MAX_INPUT = (2147483647.999f);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_FTOI_INSTRUCTION_MIN_INPUT"]/*' />
    [NativeTypeName("#define D3D11_FTOI_INSTRUCTION_MIN_INPUT ( -2147483648.999f )")]
    public const float D3D11_FTOI_INSTRUCTION_MIN_INPUT = (-2147483648.999f);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_FTOU_INSTRUCTION_MAX_INPUT"]/*' />
    [NativeTypeName("#define D3D11_FTOU_INSTRUCTION_MAX_INPUT ( 4294967295.999f )")]
    public const float D3D11_FTOU_INSTRUCTION_MAX_INPUT = (4294967295.999f);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_FTOU_INSTRUCTION_MIN_INPUT"]/*' />
    [NativeTypeName("#define D3D11_FTOU_INSTRUCTION_MIN_INPUT ( 0.0f )")]
    public const float D3D11_FTOU_INSTRUCTION_MIN_INPUT = (0.0f);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_GS_INPUT_INSTANCE_ID_READS_PER_INST"]/*' />
    [NativeTypeName("#define D3D11_GS_INPUT_INSTANCE_ID_READS_PER_INST ( 2 )")]
    public const int D3D11_GS_INPUT_INSTANCE_ID_READS_PER_INST = (2);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_GS_INPUT_INSTANCE_ID_READ_PORTS"]/*' />
    [NativeTypeName("#define D3D11_GS_INPUT_INSTANCE_ID_READ_PORTS ( 1 )")]
    public const int D3D11_GS_INPUT_INSTANCE_ID_READ_PORTS = (1);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_GS_INPUT_INSTANCE_ID_REGISTER_COMPONENTS"]/*' />
    [NativeTypeName("#define D3D11_GS_INPUT_INSTANCE_ID_REGISTER_COMPONENTS ( 1 )")]
    public const int D3D11_GS_INPUT_INSTANCE_ID_REGISTER_COMPONENTS = (1);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_GS_INPUT_INSTANCE_ID_REGISTER_COMPONENT_BIT_COUNT"]/*' />
    [NativeTypeName("#define D3D11_GS_INPUT_INSTANCE_ID_REGISTER_COMPONENT_BIT_COUNT ( 32 )")]
    public const int D3D11_GS_INPUT_INSTANCE_ID_REGISTER_COMPONENT_BIT_COUNT = (32);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_GS_INPUT_INSTANCE_ID_REGISTER_COUNT"]/*' />
    [NativeTypeName("#define D3D11_GS_INPUT_INSTANCE_ID_REGISTER_COUNT ( 1 )")]
    public const int D3D11_GS_INPUT_INSTANCE_ID_REGISTER_COUNT = (1);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_GS_INPUT_PRIM_CONST_REGISTER_COMPONENTS"]/*' />
    [NativeTypeName("#define D3D11_GS_INPUT_PRIM_CONST_REGISTER_COMPONENTS ( 1 )")]
    public const int D3D11_GS_INPUT_PRIM_CONST_REGISTER_COMPONENTS = (1);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_GS_INPUT_PRIM_CONST_REGISTER_COMPONENT_BIT_COUNT"]/*' />
    [NativeTypeName("#define D3D11_GS_INPUT_PRIM_CONST_REGISTER_COMPONENT_BIT_COUNT ( 32 )")]
    public const int D3D11_GS_INPUT_PRIM_CONST_REGISTER_COMPONENT_BIT_COUNT = (32);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_GS_INPUT_PRIM_CONST_REGISTER_COUNT"]/*' />
    [NativeTypeName("#define D3D11_GS_INPUT_PRIM_CONST_REGISTER_COUNT ( 1 )")]
    public const int D3D11_GS_INPUT_PRIM_CONST_REGISTER_COUNT = (1);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_GS_INPUT_PRIM_CONST_REGISTER_READS_PER_INST"]/*' />
    [NativeTypeName("#define D3D11_GS_INPUT_PRIM_CONST_REGISTER_READS_PER_INST ( 2 )")]
    public const int D3D11_GS_INPUT_PRIM_CONST_REGISTER_READS_PER_INST = (2);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_GS_INPUT_PRIM_CONST_REGISTER_READ_PORTS"]/*' />
    [NativeTypeName("#define D3D11_GS_INPUT_PRIM_CONST_REGISTER_READ_PORTS ( 1 )")]
    public const int D3D11_GS_INPUT_PRIM_CONST_REGISTER_READ_PORTS = (1);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_GS_INPUT_REGISTER_COMPONENTS"]/*' />
    [NativeTypeName("#define D3D11_GS_INPUT_REGISTER_COMPONENTS ( 4 )")]
    public const int D3D11_GS_INPUT_REGISTER_COMPONENTS = (4);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_GS_INPUT_REGISTER_COMPONENT_BIT_COUNT"]/*' />
    [NativeTypeName("#define D3D11_GS_INPUT_REGISTER_COMPONENT_BIT_COUNT ( 32 )")]
    public const int D3D11_GS_INPUT_REGISTER_COMPONENT_BIT_COUNT = (32);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_GS_INPUT_REGISTER_COUNT"]/*' />
    [NativeTypeName("#define D3D11_GS_INPUT_REGISTER_COUNT ( 32 )")]
    public const int D3D11_GS_INPUT_REGISTER_COUNT = (32);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_GS_INPUT_REGISTER_READS_PER_INST"]/*' />
    [NativeTypeName("#define D3D11_GS_INPUT_REGISTER_READS_PER_INST ( 2 )")]
    public const int D3D11_GS_INPUT_REGISTER_READS_PER_INST = (2);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_GS_INPUT_REGISTER_READ_PORTS"]/*' />
    [NativeTypeName("#define D3D11_GS_INPUT_REGISTER_READ_PORTS ( 1 )")]
    public const int D3D11_GS_INPUT_REGISTER_READ_PORTS = (1);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_GS_INPUT_REGISTER_VERTICES"]/*' />
    [NativeTypeName("#define D3D11_GS_INPUT_REGISTER_VERTICES ( 32 )")]
    public const int D3D11_GS_INPUT_REGISTER_VERTICES = (32);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_GS_MAX_INSTANCE_COUNT"]/*' />
    [NativeTypeName("#define D3D11_GS_MAX_INSTANCE_COUNT ( 32 )")]
    public const int D3D11_GS_MAX_INSTANCE_COUNT = (32);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_GS_MAX_OUTPUT_VERTEX_COUNT_ACROSS_INSTANCES"]/*' />
    [NativeTypeName("#define D3D11_GS_MAX_OUTPUT_VERTEX_COUNT_ACROSS_INSTANCES ( 1024 )")]
    public const int D3D11_GS_MAX_OUTPUT_VERTEX_COUNT_ACROSS_INSTANCES = (1024);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_GS_OUTPUT_ELEMENTS"]/*' />
    [NativeTypeName("#define D3D11_GS_OUTPUT_ELEMENTS ( 32 )")]
    public const int D3D11_GS_OUTPUT_ELEMENTS = (32);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_GS_OUTPUT_REGISTER_COMPONENTS"]/*' />
    [NativeTypeName("#define D3D11_GS_OUTPUT_REGISTER_COMPONENTS ( 4 )")]
    public const int D3D11_GS_OUTPUT_REGISTER_COMPONENTS = (4);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_GS_OUTPUT_REGISTER_COMPONENT_BIT_COUNT"]/*' />
    [NativeTypeName("#define D3D11_GS_OUTPUT_REGISTER_COMPONENT_BIT_COUNT ( 32 )")]
    public const int D3D11_GS_OUTPUT_REGISTER_COMPONENT_BIT_COUNT = (32);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_GS_OUTPUT_REGISTER_COUNT"]/*' />
    [NativeTypeName("#define D3D11_GS_OUTPUT_REGISTER_COUNT ( 32 )")]
    public const int D3D11_GS_OUTPUT_REGISTER_COUNT = (32);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_HS_CONTROL_POINT_PHASE_INPUT_REGISTER_COUNT"]/*' />
    [NativeTypeName("#define D3D11_HS_CONTROL_POINT_PHASE_INPUT_REGISTER_COUNT ( 32 )")]
    public const int D3D11_HS_CONTROL_POINT_PHASE_INPUT_REGISTER_COUNT = (32);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_HS_CONTROL_POINT_PHASE_OUTPUT_REGISTER_COUNT"]/*' />
    [NativeTypeName("#define D3D11_HS_CONTROL_POINT_PHASE_OUTPUT_REGISTER_COUNT ( 32 )")]
    public const int D3D11_HS_CONTROL_POINT_PHASE_OUTPUT_REGISTER_COUNT = (32);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_HS_CONTROL_POINT_REGISTER_COMPONENTS"]/*' />
    [NativeTypeName("#define D3D11_HS_CONTROL_POINT_REGISTER_COMPONENTS ( 4 )")]
    public const int D3D11_HS_CONTROL_POINT_REGISTER_COMPONENTS = (4);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_HS_CONTROL_POINT_REGISTER_COMPONENT_BIT_COUNT"]/*' />
    [NativeTypeName("#define D3D11_HS_CONTROL_POINT_REGISTER_COMPONENT_BIT_COUNT ( 32 )")]
    public const int D3D11_HS_CONTROL_POINT_REGISTER_COMPONENT_BIT_COUNT = (32);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_HS_CONTROL_POINT_REGISTER_READS_PER_INST"]/*' />
    [NativeTypeName("#define D3D11_HS_CONTROL_POINT_REGISTER_READS_PER_INST ( 2 )")]
    public const int D3D11_HS_CONTROL_POINT_REGISTER_READS_PER_INST = (2);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_HS_CONTROL_POINT_REGISTER_READ_PORTS"]/*' />
    [NativeTypeName("#define D3D11_HS_CONTROL_POINT_REGISTER_READ_PORTS ( 1 )")]
    public const int D3D11_HS_CONTROL_POINT_REGISTER_READ_PORTS = (1);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_HS_FORK_PHASE_INSTANCE_COUNT_UPPER_BOUND"]/*' />
    [NativeTypeName("#define D3D11_HS_FORK_PHASE_INSTANCE_COUNT_UPPER_BOUND ( 0xffffffff )")]
    public const uint D3D11_HS_FORK_PHASE_INSTANCE_COUNT_UPPER_BOUND = (0xffffffff);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_HS_INPUT_FORK_INSTANCE_ID_REGISTER_COMPONENTS"]/*' />
    [NativeTypeName("#define D3D11_HS_INPUT_FORK_INSTANCE_ID_REGISTER_COMPONENTS ( 1 )")]
    public const int D3D11_HS_INPUT_FORK_INSTANCE_ID_REGISTER_COMPONENTS = (1);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_HS_INPUT_FORK_INSTANCE_ID_REGISTER_COMPONENT_BIT_COUNT"]/*' />
    [NativeTypeName("#define D3D11_HS_INPUT_FORK_INSTANCE_ID_REGISTER_COMPONENT_BIT_COUNT ( 32 )")]
    public const int D3D11_HS_INPUT_FORK_INSTANCE_ID_REGISTER_COMPONENT_BIT_COUNT = (32);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_HS_INPUT_FORK_INSTANCE_ID_REGISTER_COUNT"]/*' />
    [NativeTypeName("#define D3D11_HS_INPUT_FORK_INSTANCE_ID_REGISTER_COUNT ( 1 )")]
    public const int D3D11_HS_INPUT_FORK_INSTANCE_ID_REGISTER_COUNT = (1);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_HS_INPUT_FORK_INSTANCE_ID_REGISTER_READS_PER_INST"]/*' />
    [NativeTypeName("#define D3D11_HS_INPUT_FORK_INSTANCE_ID_REGISTER_READS_PER_INST ( 2 )")]
    public const int D3D11_HS_INPUT_FORK_INSTANCE_ID_REGISTER_READS_PER_INST = (2);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_HS_INPUT_FORK_INSTANCE_ID_REGISTER_READ_PORTS"]/*' />
    [NativeTypeName("#define D3D11_HS_INPUT_FORK_INSTANCE_ID_REGISTER_READ_PORTS ( 1 )")]
    public const int D3D11_HS_INPUT_FORK_INSTANCE_ID_REGISTER_READ_PORTS = (1);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_HS_INPUT_JOIN_INSTANCE_ID_REGISTER_COMPONENTS"]/*' />
    [NativeTypeName("#define D3D11_HS_INPUT_JOIN_INSTANCE_ID_REGISTER_COMPONENTS ( 1 )")]
    public const int D3D11_HS_INPUT_JOIN_INSTANCE_ID_REGISTER_COMPONENTS = (1);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_HS_INPUT_JOIN_INSTANCE_ID_REGISTER_COMPONENT_BIT_COUNT"]/*' />
    [NativeTypeName("#define D3D11_HS_INPUT_JOIN_INSTANCE_ID_REGISTER_COMPONENT_BIT_COUNT ( 32 )")]
    public const int D3D11_HS_INPUT_JOIN_INSTANCE_ID_REGISTER_COMPONENT_BIT_COUNT = (32);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_HS_INPUT_JOIN_INSTANCE_ID_REGISTER_COUNT"]/*' />
    [NativeTypeName("#define D3D11_HS_INPUT_JOIN_INSTANCE_ID_REGISTER_COUNT ( 1 )")]
    public const int D3D11_HS_INPUT_JOIN_INSTANCE_ID_REGISTER_COUNT = (1);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_HS_INPUT_JOIN_INSTANCE_ID_REGISTER_READS_PER_INST"]/*' />
    [NativeTypeName("#define D3D11_HS_INPUT_JOIN_INSTANCE_ID_REGISTER_READS_PER_INST ( 2 )")]
    public const int D3D11_HS_INPUT_JOIN_INSTANCE_ID_REGISTER_READS_PER_INST = (2);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_HS_INPUT_JOIN_INSTANCE_ID_REGISTER_READ_PORTS"]/*' />
    [NativeTypeName("#define D3D11_HS_INPUT_JOIN_INSTANCE_ID_REGISTER_READ_PORTS ( 1 )")]
    public const int D3D11_HS_INPUT_JOIN_INSTANCE_ID_REGISTER_READ_PORTS = (1);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_HS_INPUT_PRIMITIVE_ID_REGISTER_COMPONENTS"]/*' />
    [NativeTypeName("#define D3D11_HS_INPUT_PRIMITIVE_ID_REGISTER_COMPONENTS ( 1 )")]
    public const int D3D11_HS_INPUT_PRIMITIVE_ID_REGISTER_COMPONENTS = (1);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_HS_INPUT_PRIMITIVE_ID_REGISTER_COMPONENT_BIT_COUNT"]/*' />
    [NativeTypeName("#define D3D11_HS_INPUT_PRIMITIVE_ID_REGISTER_COMPONENT_BIT_COUNT ( 32 )")]
    public const int D3D11_HS_INPUT_PRIMITIVE_ID_REGISTER_COMPONENT_BIT_COUNT = (32);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_HS_INPUT_PRIMITIVE_ID_REGISTER_COUNT"]/*' />
    [NativeTypeName("#define D3D11_HS_INPUT_PRIMITIVE_ID_REGISTER_COUNT ( 1 )")]
    public const int D3D11_HS_INPUT_PRIMITIVE_ID_REGISTER_COUNT = (1);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_HS_INPUT_PRIMITIVE_ID_REGISTER_READS_PER_INST"]/*' />
    [NativeTypeName("#define D3D11_HS_INPUT_PRIMITIVE_ID_REGISTER_READS_PER_INST ( 2 )")]
    public const int D3D11_HS_INPUT_PRIMITIVE_ID_REGISTER_READS_PER_INST = (2);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_HS_INPUT_PRIMITIVE_ID_REGISTER_READ_PORTS"]/*' />
    [NativeTypeName("#define D3D11_HS_INPUT_PRIMITIVE_ID_REGISTER_READ_PORTS ( 1 )")]
    public const int D3D11_HS_INPUT_PRIMITIVE_ID_REGISTER_READ_PORTS = (1);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_HS_JOIN_PHASE_INSTANCE_COUNT_UPPER_BOUND"]/*' />
    [NativeTypeName("#define D3D11_HS_JOIN_PHASE_INSTANCE_COUNT_UPPER_BOUND ( 0xffffffff )")]
    public const uint D3D11_HS_JOIN_PHASE_INSTANCE_COUNT_UPPER_BOUND = (0xffffffff);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_HS_MAXTESSFACTOR_LOWER_BOUND"]/*' />
    [NativeTypeName("#define D3D11_HS_MAXTESSFACTOR_LOWER_BOUND ( 1.0f )")]
    public const float D3D11_HS_MAXTESSFACTOR_LOWER_BOUND = (1.0f);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_HS_MAXTESSFACTOR_UPPER_BOUND"]/*' />
    [NativeTypeName("#define D3D11_HS_MAXTESSFACTOR_UPPER_BOUND ( 64.0f )")]
    public const float D3D11_HS_MAXTESSFACTOR_UPPER_BOUND = (64.0f);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_HS_OUTPUT_CONTROL_POINTS_MAX_TOTAL_SCALARS"]/*' />
    [NativeTypeName("#define D3D11_HS_OUTPUT_CONTROL_POINTS_MAX_TOTAL_SCALARS ( 3968 )")]
    public const int D3D11_HS_OUTPUT_CONTROL_POINTS_MAX_TOTAL_SCALARS = (3968);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_HS_OUTPUT_CONTROL_POINT_ID_REGISTER_COMPONENTS"]/*' />
    [NativeTypeName("#define D3D11_HS_OUTPUT_CONTROL_POINT_ID_REGISTER_COMPONENTS ( 1 )")]
    public const int D3D11_HS_OUTPUT_CONTROL_POINT_ID_REGISTER_COMPONENTS = (1);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_HS_OUTPUT_CONTROL_POINT_ID_REGISTER_COMPONENT_BIT_COUNT"]/*' />
    [NativeTypeName("#define D3D11_HS_OUTPUT_CONTROL_POINT_ID_REGISTER_COMPONENT_BIT_COUNT ( 32 )")]
    public const int D3D11_HS_OUTPUT_CONTROL_POINT_ID_REGISTER_COMPONENT_BIT_COUNT = (32);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_HS_OUTPUT_CONTROL_POINT_ID_REGISTER_COUNT"]/*' />
    [NativeTypeName("#define D3D11_HS_OUTPUT_CONTROL_POINT_ID_REGISTER_COUNT ( 1 )")]
    public const int D3D11_HS_OUTPUT_CONTROL_POINT_ID_REGISTER_COUNT = (1);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_HS_OUTPUT_CONTROL_POINT_ID_REGISTER_READS_PER_INST"]/*' />
    [NativeTypeName("#define D3D11_HS_OUTPUT_CONTROL_POINT_ID_REGISTER_READS_PER_INST ( 2 )")]
    public const int D3D11_HS_OUTPUT_CONTROL_POINT_ID_REGISTER_READS_PER_INST = (2);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_HS_OUTPUT_CONTROL_POINT_ID_REGISTER_READ_PORTS"]/*' />
    [NativeTypeName("#define D3D11_HS_OUTPUT_CONTROL_POINT_ID_REGISTER_READ_PORTS ( 1 )")]
    public const int D3D11_HS_OUTPUT_CONTROL_POINT_ID_REGISTER_READ_PORTS = (1);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_HS_OUTPUT_PATCH_CONSTANT_REGISTER_COMPONENTS"]/*' />
    [NativeTypeName("#define D3D11_HS_OUTPUT_PATCH_CONSTANT_REGISTER_COMPONENTS ( 4 )")]
    public const int D3D11_HS_OUTPUT_PATCH_CONSTANT_REGISTER_COMPONENTS = (4);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_HS_OUTPUT_PATCH_CONSTANT_REGISTER_COMPONENT_BIT_COUNT"]/*' />
    [NativeTypeName("#define D3D11_HS_OUTPUT_PATCH_CONSTANT_REGISTER_COMPONENT_BIT_COUNT ( 32 )")]
    public const int D3D11_HS_OUTPUT_PATCH_CONSTANT_REGISTER_COMPONENT_BIT_COUNT = (32);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_HS_OUTPUT_PATCH_CONSTANT_REGISTER_COUNT"]/*' />
    [NativeTypeName("#define D3D11_HS_OUTPUT_PATCH_CONSTANT_REGISTER_COUNT ( 32 )")]
    public const int D3D11_HS_OUTPUT_PATCH_CONSTANT_REGISTER_COUNT = (32);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_HS_OUTPUT_PATCH_CONSTANT_REGISTER_READS_PER_INST"]/*' />
    [NativeTypeName("#define D3D11_HS_OUTPUT_PATCH_CONSTANT_REGISTER_READS_PER_INST ( 2 )")]
    public const int D3D11_HS_OUTPUT_PATCH_CONSTANT_REGISTER_READS_PER_INST = (2);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_HS_OUTPUT_PATCH_CONSTANT_REGISTER_READ_PORTS"]/*' />
    [NativeTypeName("#define D3D11_HS_OUTPUT_PATCH_CONSTANT_REGISTER_READ_PORTS ( 1 )")]
    public const int D3D11_HS_OUTPUT_PATCH_CONSTANT_REGISTER_READ_PORTS = (1);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_HS_OUTPUT_PATCH_CONSTANT_REGISTER_SCALAR_COMPONENTS"]/*' />
    [NativeTypeName("#define D3D11_HS_OUTPUT_PATCH_CONSTANT_REGISTER_SCALAR_COMPONENTS ( 128 )")]
    public const int D3D11_HS_OUTPUT_PATCH_CONSTANT_REGISTER_SCALAR_COMPONENTS = (128);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_IA_DEFAULT_INDEX_BUFFER_OFFSET_IN_BYTES"]/*' />
    [NativeTypeName("#define D3D11_IA_DEFAULT_INDEX_BUFFER_OFFSET_IN_BYTES ( 0 )")]
    public const int D3D11_IA_DEFAULT_INDEX_BUFFER_OFFSET_IN_BYTES = (0);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_IA_DEFAULT_PRIMITIVE_TOPOLOGY"]/*' />
    [NativeTypeName("#define D3D11_IA_DEFAULT_PRIMITIVE_TOPOLOGY ( 0 )")]
    public const int D3D11_IA_DEFAULT_PRIMITIVE_TOPOLOGY = (0);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_IA_DEFAULT_VERTEX_BUFFER_OFFSET_IN_BYTES"]/*' />
    [NativeTypeName("#define D3D11_IA_DEFAULT_VERTEX_BUFFER_OFFSET_IN_BYTES ( 0 )")]
    public const int D3D11_IA_DEFAULT_VERTEX_BUFFER_OFFSET_IN_BYTES = (0);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_IA_INDEX_INPUT_RESOURCE_SLOT_COUNT"]/*' />
    [NativeTypeName("#define D3D11_IA_INDEX_INPUT_RESOURCE_SLOT_COUNT ( 1 )")]
    public const int D3D11_IA_INDEX_INPUT_RESOURCE_SLOT_COUNT = (1);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_IA_INSTANCE_ID_BIT_COUNT"]/*' />
    [NativeTypeName("#define D3D11_IA_INSTANCE_ID_BIT_COUNT ( 32 )")]
    public const int D3D11_IA_INSTANCE_ID_BIT_COUNT = (32);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_IA_INTEGER_ARITHMETIC_BIT_COUNT"]/*' />
    [NativeTypeName("#define D3D11_IA_INTEGER_ARITHMETIC_BIT_COUNT ( 32 )")]
    public const int D3D11_IA_INTEGER_ARITHMETIC_BIT_COUNT = (32);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_IA_PATCH_MAX_CONTROL_POINT_COUNT"]/*' />
    [NativeTypeName("#define D3D11_IA_PATCH_MAX_CONTROL_POINT_COUNT ( 32 )")]
    public const int D3D11_IA_PATCH_MAX_CONTROL_POINT_COUNT = (32);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_IA_PRIMITIVE_ID_BIT_COUNT"]/*' />
    [NativeTypeName("#define D3D11_IA_PRIMITIVE_ID_BIT_COUNT ( 32 )")]
    public const int D3D11_IA_PRIMITIVE_ID_BIT_COUNT = (32);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_IA_VERTEX_ID_BIT_COUNT"]/*' />
    [NativeTypeName("#define D3D11_IA_VERTEX_ID_BIT_COUNT ( 32 )")]
    public const int D3D11_IA_VERTEX_ID_BIT_COUNT = (32);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_IA_VERTEX_INPUT_RESOURCE_SLOT_COUNT"]/*' />
    [NativeTypeName("#define D3D11_IA_VERTEX_INPUT_RESOURCE_SLOT_COUNT ( 32 )")]
    public const int D3D11_IA_VERTEX_INPUT_RESOURCE_SLOT_COUNT = (32);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_IA_VERTEX_INPUT_STRUCTURE_ELEMENTS_COMPONENTS"]/*' />
    [NativeTypeName("#define D3D11_IA_VERTEX_INPUT_STRUCTURE_ELEMENTS_COMPONENTS ( 128 )")]
    public const int D3D11_IA_VERTEX_INPUT_STRUCTURE_ELEMENTS_COMPONENTS = (128);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_IA_VERTEX_INPUT_STRUCTURE_ELEMENT_COUNT"]/*' />
    [NativeTypeName("#define D3D11_IA_VERTEX_INPUT_STRUCTURE_ELEMENT_COUNT ( 32 )")]
    public const int D3D11_IA_VERTEX_INPUT_STRUCTURE_ELEMENT_COUNT = (32);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_INTEGER_DIVIDE_BY_ZERO_QUOTIENT"]/*' />
    [NativeTypeName("#define D3D11_INTEGER_DIVIDE_BY_ZERO_QUOTIENT ( 0xffffffff )")]
    public const uint D3D11_INTEGER_DIVIDE_BY_ZERO_QUOTIENT = (0xffffffff);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_INTEGER_DIVIDE_BY_ZERO_REMAINDER"]/*' />
    [NativeTypeName("#define D3D11_INTEGER_DIVIDE_BY_ZERO_REMAINDER ( 0xffffffff )")]
    public const uint D3D11_INTEGER_DIVIDE_BY_ZERO_REMAINDER = (0xffffffff);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_KEEP_RENDER_TARGETS_AND_DEPTH_STENCIL"]/*' />
    [NativeTypeName("#define D3D11_KEEP_RENDER_TARGETS_AND_DEPTH_STENCIL ( 0xffffffff )")]
    public const uint D3D11_KEEP_RENDER_TARGETS_AND_DEPTH_STENCIL = (0xffffffff);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_KEEP_UNORDERED_ACCESS_VIEWS"]/*' />
    [NativeTypeName("#define D3D11_KEEP_UNORDERED_ACCESS_VIEWS ( 0xffffffff )")]
    public const uint D3D11_KEEP_UNORDERED_ACCESS_VIEWS = (0xffffffff);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_LINEAR_GAMMA"]/*' />
    [NativeTypeName("#define D3D11_LINEAR_GAMMA ( 1.0f )")]
    public const float D3D11_LINEAR_GAMMA = (1.0f);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_MAJOR_VERSION"]/*' />
    [NativeTypeName("#define D3D11_MAJOR_VERSION ( 11 )")]
    public const int D3D11_MAJOR_VERSION = (11);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_MAX_BORDER_COLOR_COMPONENT"]/*' />
    [NativeTypeName("#define D3D11_MAX_BORDER_COLOR_COMPONENT ( 1.0f )")]
    public const float D3D11_MAX_BORDER_COLOR_COMPONENT = (1.0f);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_MAX_DEPTH"]/*' />
    [NativeTypeName("#define D3D11_MAX_DEPTH ( 1.0f )")]
    public const float D3D11_MAX_DEPTH = (1.0f);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_MAX_MAXANISOTROPY"]/*' />
    [NativeTypeName("#define D3D11_MAX_MAXANISOTROPY ( 16 )")]
    public const int D3D11_MAX_MAXANISOTROPY = (16);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_MAX_MULTISAMPLE_SAMPLE_COUNT"]/*' />
    [NativeTypeName("#define D3D11_MAX_MULTISAMPLE_SAMPLE_COUNT ( 32 )")]
    public const int D3D11_MAX_MULTISAMPLE_SAMPLE_COUNT = (32);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_MAX_POSITION_VALUE"]/*' />
    [NativeTypeName("#define D3D11_MAX_POSITION_VALUE ( 3.402823466e+34f )")]
    public const float D3D11_MAX_POSITION_VALUE = (3.402823466e+34f);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_MAX_TEXTURE_DIMENSION_2_TO_EXP"]/*' />
    [NativeTypeName("#define D3D11_MAX_TEXTURE_DIMENSION_2_TO_EXP ( 17 )")]
    public const int D3D11_MAX_TEXTURE_DIMENSION_2_TO_EXP = (17);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_MINOR_VERSION"]/*' />
    [NativeTypeName("#define D3D11_MINOR_VERSION ( 0 )")]
    public const int D3D11_MINOR_VERSION = (0);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_MIN_BORDER_COLOR_COMPONENT"]/*' />
    [NativeTypeName("#define D3D11_MIN_BORDER_COLOR_COMPONENT ( 0.0f )")]
    public const float D3D11_MIN_BORDER_COLOR_COMPONENT = (0.0f);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_MIN_DEPTH"]/*' />
    [NativeTypeName("#define D3D11_MIN_DEPTH ( 0.0f )")]
    public const float D3D11_MIN_DEPTH = (0.0f);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_MIN_MAXANISOTROPY"]/*' />
    [NativeTypeName("#define D3D11_MIN_MAXANISOTROPY ( 0 )")]
    public const int D3D11_MIN_MAXANISOTROPY = (0);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_MIP_LOD_BIAS_MAX"]/*' />
    [NativeTypeName("#define D3D11_MIP_LOD_BIAS_MAX ( 15.99f )")]
    public const float D3D11_MIP_LOD_BIAS_MAX = (15.99f);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_MIP_LOD_BIAS_MIN"]/*' />
    [NativeTypeName("#define D3D11_MIP_LOD_BIAS_MIN ( -16.0f )")]
    public const float D3D11_MIP_LOD_BIAS_MIN = (-16.0f);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_MIP_LOD_FRACTIONAL_BIT_COUNT"]/*' />
    [NativeTypeName("#define D3D11_MIP_LOD_FRACTIONAL_BIT_COUNT ( 8 )")]
    public const int D3D11_MIP_LOD_FRACTIONAL_BIT_COUNT = (8);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_MIP_LOD_RANGE_BIT_COUNT"]/*' />
    [NativeTypeName("#define D3D11_MIP_LOD_RANGE_BIT_COUNT ( 8 )")]
    public const int D3D11_MIP_LOD_RANGE_BIT_COUNT = (8);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_MULTISAMPLE_ANTIALIAS_LINE_WIDTH"]/*' />
    [NativeTypeName("#define D3D11_MULTISAMPLE_ANTIALIAS_LINE_WIDTH ( 1.4f )")]
    public const float D3D11_MULTISAMPLE_ANTIALIAS_LINE_WIDTH = (1.4f);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_NONSAMPLE_FETCH_OUT_OF_RANGE_ACCESS_RESULT"]/*' />
    [NativeTypeName("#define D3D11_NONSAMPLE_FETCH_OUT_OF_RANGE_ACCESS_RESULT ( 0 )")]
    public const int D3D11_NONSAMPLE_FETCH_OUT_OF_RANGE_ACCESS_RESULT = (0);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_PIXEL_ADDRESS_RANGE_BIT_COUNT"]/*' />
    [NativeTypeName("#define D3D11_PIXEL_ADDRESS_RANGE_BIT_COUNT ( 15 )")]
    public const int D3D11_PIXEL_ADDRESS_RANGE_BIT_COUNT = (15);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_PRE_SCISSOR_PIXEL_ADDRESS_RANGE_BIT_COUNT"]/*' />
    [NativeTypeName("#define D3D11_PRE_SCISSOR_PIXEL_ADDRESS_RANGE_BIT_COUNT ( 16 )")]
    public const int D3D11_PRE_SCISSOR_PIXEL_ADDRESS_RANGE_BIT_COUNT = (16);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_PS_CS_UAV_REGISTER_COMPONENTS"]/*' />
    [NativeTypeName("#define D3D11_PS_CS_UAV_REGISTER_COMPONENTS ( 1 )")]
    public const int D3D11_PS_CS_UAV_REGISTER_COMPONENTS = (1);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_PS_CS_UAV_REGISTER_COUNT"]/*' />
    [NativeTypeName("#define D3D11_PS_CS_UAV_REGISTER_COUNT ( 8 )")]
    public const int D3D11_PS_CS_UAV_REGISTER_COUNT = (8);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_PS_CS_UAV_REGISTER_READS_PER_INST"]/*' />
    [NativeTypeName("#define D3D11_PS_CS_UAV_REGISTER_READS_PER_INST ( 1 )")]
    public const int D3D11_PS_CS_UAV_REGISTER_READS_PER_INST = (1);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_PS_CS_UAV_REGISTER_READ_PORTS"]/*' />
    [NativeTypeName("#define D3D11_PS_CS_UAV_REGISTER_READ_PORTS ( 1 )")]
    public const int D3D11_PS_CS_UAV_REGISTER_READ_PORTS = (1);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_PS_FRONTFACING_DEFAULT_VALUE"]/*' />
    [NativeTypeName("#define D3D11_PS_FRONTFACING_DEFAULT_VALUE ( 0xffffffff )")]
    public const uint D3D11_PS_FRONTFACING_DEFAULT_VALUE = (0xffffffff);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_PS_FRONTFACING_FALSE_VALUE"]/*' />
    [NativeTypeName("#define D3D11_PS_FRONTFACING_FALSE_VALUE ( 0 )")]
    public const int D3D11_PS_FRONTFACING_FALSE_VALUE = (0);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_PS_FRONTFACING_TRUE_VALUE"]/*' />
    [NativeTypeName("#define D3D11_PS_FRONTFACING_TRUE_VALUE ( 0xffffffff )")]
    public const uint D3D11_PS_FRONTFACING_TRUE_VALUE = (0xffffffff);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_PS_INPUT_REGISTER_COMPONENTS"]/*' />
    [NativeTypeName("#define D3D11_PS_INPUT_REGISTER_COMPONENTS ( 4 )")]
    public const int D3D11_PS_INPUT_REGISTER_COMPONENTS = (4);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_PS_INPUT_REGISTER_COMPONENT_BIT_COUNT"]/*' />
    [NativeTypeName("#define D3D11_PS_INPUT_REGISTER_COMPONENT_BIT_COUNT ( 32 )")]
    public const int D3D11_PS_INPUT_REGISTER_COMPONENT_BIT_COUNT = (32);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_PS_INPUT_REGISTER_COUNT"]/*' />
    [NativeTypeName("#define D3D11_PS_INPUT_REGISTER_COUNT ( 32 )")]
    public const int D3D11_PS_INPUT_REGISTER_COUNT = (32);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_PS_INPUT_REGISTER_READS_PER_INST"]/*' />
    [NativeTypeName("#define D3D11_PS_INPUT_REGISTER_READS_PER_INST ( 2 )")]
    public const int D3D11_PS_INPUT_REGISTER_READS_PER_INST = (2);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_PS_INPUT_REGISTER_READ_PORTS"]/*' />
    [NativeTypeName("#define D3D11_PS_INPUT_REGISTER_READ_PORTS ( 1 )")]
    public const int D3D11_PS_INPUT_REGISTER_READ_PORTS = (1);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_PS_LEGACY_PIXEL_CENTER_FRACTIONAL_COMPONENT"]/*' />
    [NativeTypeName("#define D3D11_PS_LEGACY_PIXEL_CENTER_FRACTIONAL_COMPONENT ( 0.0f )")]
    public const float D3D11_PS_LEGACY_PIXEL_CENTER_FRACTIONAL_COMPONENT = (0.0f);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_PS_OUTPUT_DEPTH_REGISTER_COMPONENTS"]/*' />
    [NativeTypeName("#define D3D11_PS_OUTPUT_DEPTH_REGISTER_COMPONENTS ( 1 )")]
    public const int D3D11_PS_OUTPUT_DEPTH_REGISTER_COMPONENTS = (1);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_PS_OUTPUT_DEPTH_REGISTER_COMPONENT_BIT_COUNT"]/*' />
    [NativeTypeName("#define D3D11_PS_OUTPUT_DEPTH_REGISTER_COMPONENT_BIT_COUNT ( 32 )")]
    public const int D3D11_PS_OUTPUT_DEPTH_REGISTER_COMPONENT_BIT_COUNT = (32);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_PS_OUTPUT_DEPTH_REGISTER_COUNT"]/*' />
    [NativeTypeName("#define D3D11_PS_OUTPUT_DEPTH_REGISTER_COUNT ( 1 )")]
    public const int D3D11_PS_OUTPUT_DEPTH_REGISTER_COUNT = (1);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_PS_OUTPUT_MASK_REGISTER_COMPONENTS"]/*' />
    [NativeTypeName("#define D3D11_PS_OUTPUT_MASK_REGISTER_COMPONENTS ( 1 )")]
    public const int D3D11_PS_OUTPUT_MASK_REGISTER_COMPONENTS = (1);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_PS_OUTPUT_MASK_REGISTER_COMPONENT_BIT_COUNT"]/*' />
    [NativeTypeName("#define D3D11_PS_OUTPUT_MASK_REGISTER_COMPONENT_BIT_COUNT ( 32 )")]
    public const int D3D11_PS_OUTPUT_MASK_REGISTER_COMPONENT_BIT_COUNT = (32);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_PS_OUTPUT_MASK_REGISTER_COUNT"]/*' />
    [NativeTypeName("#define D3D11_PS_OUTPUT_MASK_REGISTER_COUNT ( 1 )")]
    public const int D3D11_PS_OUTPUT_MASK_REGISTER_COUNT = (1);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_PS_OUTPUT_REGISTER_COMPONENTS"]/*' />
    [NativeTypeName("#define D3D11_PS_OUTPUT_REGISTER_COMPONENTS ( 4 )")]
    public const int D3D11_PS_OUTPUT_REGISTER_COMPONENTS = (4);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_PS_OUTPUT_REGISTER_COMPONENT_BIT_COUNT"]/*' />
    [NativeTypeName("#define D3D11_PS_OUTPUT_REGISTER_COMPONENT_BIT_COUNT ( 32 )")]
    public const int D3D11_PS_OUTPUT_REGISTER_COMPONENT_BIT_COUNT = (32);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_PS_OUTPUT_REGISTER_COUNT"]/*' />
    [NativeTypeName("#define D3D11_PS_OUTPUT_REGISTER_COUNT ( 8 )")]
    public const int D3D11_PS_OUTPUT_REGISTER_COUNT = (8);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_PS_PIXEL_CENTER_FRACTIONAL_COMPONENT"]/*' />
    [NativeTypeName("#define D3D11_PS_PIXEL_CENTER_FRACTIONAL_COMPONENT ( 0.5f )")]
    public const float D3D11_PS_PIXEL_CENTER_FRACTIONAL_COMPONENT = (0.5f);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_RAW_UAV_SRV_BYTE_ALIGNMENT"]/*' />
    [NativeTypeName("#define D3D11_RAW_UAV_SRV_BYTE_ALIGNMENT ( 16 )")]
    public const int D3D11_RAW_UAV_SRV_BYTE_ALIGNMENT = (16);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_REQ_BLEND_OBJECT_COUNT_PER_DEVICE"]/*' />
    [NativeTypeName("#define D3D11_REQ_BLEND_OBJECT_COUNT_PER_DEVICE ( 4096 )")]
    public const int D3D11_REQ_BLEND_OBJECT_COUNT_PER_DEVICE = (4096);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_REQ_BUFFER_RESOURCE_TEXEL_COUNT_2_TO_EXP"]/*' />
    [NativeTypeName("#define D3D11_REQ_BUFFER_RESOURCE_TEXEL_COUNT_2_TO_EXP ( 27 )")]
    public const int D3D11_REQ_BUFFER_RESOURCE_TEXEL_COUNT_2_TO_EXP = (27);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_REQ_CONSTANT_BUFFER_ELEMENT_COUNT"]/*' />
    [NativeTypeName("#define D3D11_REQ_CONSTANT_BUFFER_ELEMENT_COUNT ( 4096 )")]
    public const int D3D11_REQ_CONSTANT_BUFFER_ELEMENT_COUNT = (4096);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_REQ_DEPTH_STENCIL_OBJECT_COUNT_PER_DEVICE"]/*' />
    [NativeTypeName("#define D3D11_REQ_DEPTH_STENCIL_OBJECT_COUNT_PER_DEVICE ( 4096 )")]
    public const int D3D11_REQ_DEPTH_STENCIL_OBJECT_COUNT_PER_DEVICE = (4096);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_REQ_DRAWINDEXED_INDEX_COUNT_2_TO_EXP"]/*' />
    [NativeTypeName("#define D3D11_REQ_DRAWINDEXED_INDEX_COUNT_2_TO_EXP ( 32 )")]
    public const int D3D11_REQ_DRAWINDEXED_INDEX_COUNT_2_TO_EXP = (32);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_REQ_DRAW_VERTEX_COUNT_2_TO_EXP"]/*' />
    [NativeTypeName("#define D3D11_REQ_DRAW_VERTEX_COUNT_2_TO_EXP ( 32 )")]
    public const int D3D11_REQ_DRAW_VERTEX_COUNT_2_TO_EXP = (32);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_REQ_FILTERING_HW_ADDRESSABLE_RESOURCE_DIMENSION"]/*' />
    [NativeTypeName("#define D3D11_REQ_FILTERING_HW_ADDRESSABLE_RESOURCE_DIMENSION ( 16384 )")]
    public const int D3D11_REQ_FILTERING_HW_ADDRESSABLE_RESOURCE_DIMENSION = (16384);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_REQ_GS_INVOCATION_32BIT_OUTPUT_COMPONENT_LIMIT"]/*' />
    [NativeTypeName("#define D3D11_REQ_GS_INVOCATION_32BIT_OUTPUT_COMPONENT_LIMIT ( 1024 )")]
    public const int D3D11_REQ_GS_INVOCATION_32BIT_OUTPUT_COMPONENT_LIMIT = (1024);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_REQ_IMMEDIATE_CONSTANT_BUFFER_ELEMENT_COUNT"]/*' />
    [NativeTypeName("#define D3D11_REQ_IMMEDIATE_CONSTANT_BUFFER_ELEMENT_COUNT ( 4096 )")]
    public const int D3D11_REQ_IMMEDIATE_CONSTANT_BUFFER_ELEMENT_COUNT = (4096);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_REQ_MAXANISOTROPY"]/*' />
    [NativeTypeName("#define D3D11_REQ_MAXANISOTROPY ( 16 )")]
    public const int D3D11_REQ_MAXANISOTROPY = (16);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_REQ_MIP_LEVELS"]/*' />
    [NativeTypeName("#define D3D11_REQ_MIP_LEVELS ( 15 )")]
    public const int D3D11_REQ_MIP_LEVELS = (15);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_REQ_MULTI_ELEMENT_STRUCTURE_SIZE_IN_BYTES"]/*' />
    [NativeTypeName("#define D3D11_REQ_MULTI_ELEMENT_STRUCTURE_SIZE_IN_BYTES ( 2048 )")]
    public const int D3D11_REQ_MULTI_ELEMENT_STRUCTURE_SIZE_IN_BYTES = (2048);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_REQ_RASTERIZER_OBJECT_COUNT_PER_DEVICE"]/*' />
    [NativeTypeName("#define D3D11_REQ_RASTERIZER_OBJECT_COUNT_PER_DEVICE ( 4096 )")]
    public const int D3D11_REQ_RASTERIZER_OBJECT_COUNT_PER_DEVICE = (4096);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_REQ_RENDER_TO_BUFFER_WINDOW_WIDTH"]/*' />
    [NativeTypeName("#define D3D11_REQ_RENDER_TO_BUFFER_WINDOW_WIDTH ( 16384 )")]
    public const int D3D11_REQ_RENDER_TO_BUFFER_WINDOW_WIDTH = (16384);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_REQ_RESOURCE_SIZE_IN_MEGABYTES_EXPRESSION_A_TERM"]/*' />
    [NativeTypeName("#define D3D11_REQ_RESOURCE_SIZE_IN_MEGABYTES_EXPRESSION_A_TERM ( 128 )")]
    public const int D3D11_REQ_RESOURCE_SIZE_IN_MEGABYTES_EXPRESSION_A_TERM = (128);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_REQ_RESOURCE_SIZE_IN_MEGABYTES_EXPRESSION_B_TERM"]/*' />
    [NativeTypeName("#define D3D11_REQ_RESOURCE_SIZE_IN_MEGABYTES_EXPRESSION_B_TERM ( 0.25f )")]
    public const float D3D11_REQ_RESOURCE_SIZE_IN_MEGABYTES_EXPRESSION_B_TERM = (0.25f);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_REQ_RESOURCE_SIZE_IN_MEGABYTES_EXPRESSION_C_TERM"]/*' />
    [NativeTypeName("#define D3D11_REQ_RESOURCE_SIZE_IN_MEGABYTES_EXPRESSION_C_TERM ( 2048 )")]
    public const int D3D11_REQ_RESOURCE_SIZE_IN_MEGABYTES_EXPRESSION_C_TERM = (2048);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_REQ_RESOURCE_VIEW_COUNT_PER_DEVICE_2_TO_EXP"]/*' />
    [NativeTypeName("#define D3D11_REQ_RESOURCE_VIEW_COUNT_PER_DEVICE_2_TO_EXP ( 20 )")]
    public const int D3D11_REQ_RESOURCE_VIEW_COUNT_PER_DEVICE_2_TO_EXP = (20);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_REQ_SAMPLER_OBJECT_COUNT_PER_DEVICE"]/*' />
    [NativeTypeName("#define D3D11_REQ_SAMPLER_OBJECT_COUNT_PER_DEVICE ( 4096 )")]
    public const int D3D11_REQ_SAMPLER_OBJECT_COUNT_PER_DEVICE = (4096);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_REQ_TEXTURE1D_ARRAY_AXIS_DIMENSION"]/*' />
    [NativeTypeName("#define D3D11_REQ_TEXTURE1D_ARRAY_AXIS_DIMENSION ( 2048 )")]
    public const int D3D11_REQ_TEXTURE1D_ARRAY_AXIS_DIMENSION = (2048);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_REQ_TEXTURE1D_U_DIMENSION"]/*' />
    [NativeTypeName("#define D3D11_REQ_TEXTURE1D_U_DIMENSION ( 16384 )")]
    public const int D3D11_REQ_TEXTURE1D_U_DIMENSION = (16384);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_REQ_TEXTURE2D_ARRAY_AXIS_DIMENSION"]/*' />
    [NativeTypeName("#define D3D11_REQ_TEXTURE2D_ARRAY_AXIS_DIMENSION ( 2048 )")]
    public const int D3D11_REQ_TEXTURE2D_ARRAY_AXIS_DIMENSION = (2048);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_REQ_TEXTURE2D_U_OR_V_DIMENSION"]/*' />
    [NativeTypeName("#define D3D11_REQ_TEXTURE2D_U_OR_V_DIMENSION ( 16384 )")]
    public const int D3D11_REQ_TEXTURE2D_U_OR_V_DIMENSION = (16384);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_REQ_TEXTURE3D_U_V_OR_W_DIMENSION"]/*' />
    [NativeTypeName("#define D3D11_REQ_TEXTURE3D_U_V_OR_W_DIMENSION ( 2048 )")]
    public const int D3D11_REQ_TEXTURE3D_U_V_OR_W_DIMENSION = (2048);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_REQ_TEXTURECUBE_DIMENSION"]/*' />
    [NativeTypeName("#define D3D11_REQ_TEXTURECUBE_DIMENSION ( 16384 )")]
    public const int D3D11_REQ_TEXTURECUBE_DIMENSION = (16384);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_RESINFO_INSTRUCTION_MISSING_COMPONENT_RETVAL"]/*' />
    [NativeTypeName("#define D3D11_RESINFO_INSTRUCTION_MISSING_COMPONENT_RETVAL ( 0 )")]
    public const int D3D11_RESINFO_INSTRUCTION_MISSING_COMPONENT_RETVAL = (0);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_SHADER_MAJOR_VERSION"]/*' />
    [NativeTypeName("#define D3D11_SHADER_MAJOR_VERSION ( 5 )")]
    public const int D3D11_SHADER_MAJOR_VERSION = (5);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_SHADER_MAX_INSTANCES"]/*' />
    [NativeTypeName("#define D3D11_SHADER_MAX_INSTANCES ( 65535 )")]
    public const int D3D11_SHADER_MAX_INSTANCES = (65535);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_SHADER_MAX_INTERFACES"]/*' />
    [NativeTypeName("#define D3D11_SHADER_MAX_INTERFACES ( 253 )")]
    public const int D3D11_SHADER_MAX_INTERFACES = (253);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_SHADER_MAX_INTERFACE_CALL_SITES"]/*' />
    [NativeTypeName("#define D3D11_SHADER_MAX_INTERFACE_CALL_SITES ( 4096 )")]
    public const int D3D11_SHADER_MAX_INTERFACE_CALL_SITES = (4096);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_SHADER_MAX_TYPES"]/*' />
    [NativeTypeName("#define D3D11_SHADER_MAX_TYPES ( 65535 )")]
    public const int D3D11_SHADER_MAX_TYPES = (65535);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_SHADER_MINOR_VERSION"]/*' />
    [NativeTypeName("#define D3D11_SHADER_MINOR_VERSION ( 0 )")]
    public const int D3D11_SHADER_MINOR_VERSION = (0);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_SHIFT_INSTRUCTION_PAD_VALUE"]/*' />
    [NativeTypeName("#define D3D11_SHIFT_INSTRUCTION_PAD_VALUE ( 0 )")]
    public const int D3D11_SHIFT_INSTRUCTION_PAD_VALUE = (0);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_SHIFT_INSTRUCTION_SHIFT_VALUE_BIT_COUNT"]/*' />
    [NativeTypeName("#define D3D11_SHIFT_INSTRUCTION_SHIFT_VALUE_BIT_COUNT ( 5 )")]
    public const int D3D11_SHIFT_INSTRUCTION_SHIFT_VALUE_BIT_COUNT = (5);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_SIMULTANEOUS_RENDER_TARGET_COUNT"]/*' />
    [NativeTypeName("#define D3D11_SIMULTANEOUS_RENDER_TARGET_COUNT ( 8 )")]
    public const int D3D11_SIMULTANEOUS_RENDER_TARGET_COUNT = (8);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_SO_BUFFER_MAX_STRIDE_IN_BYTES"]/*' />
    [NativeTypeName("#define D3D11_SO_BUFFER_MAX_STRIDE_IN_BYTES ( 2048 )")]
    public const int D3D11_SO_BUFFER_MAX_STRIDE_IN_BYTES = (2048);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_SO_BUFFER_MAX_WRITE_WINDOW_IN_BYTES"]/*' />
    [NativeTypeName("#define D3D11_SO_BUFFER_MAX_WRITE_WINDOW_IN_BYTES ( 512 )")]
    public const int D3D11_SO_BUFFER_MAX_WRITE_WINDOW_IN_BYTES = (512);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_SO_BUFFER_SLOT_COUNT"]/*' />
    [NativeTypeName("#define D3D11_SO_BUFFER_SLOT_COUNT ( 4 )")]
    public const int D3D11_SO_BUFFER_SLOT_COUNT = (4);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_SO_DDI_REGISTER_INDEX_DENOTING_GAP"]/*' />
    [NativeTypeName("#define D3D11_SO_DDI_REGISTER_INDEX_DENOTING_GAP ( 0xffffffff )")]
    public const uint D3D11_SO_DDI_REGISTER_INDEX_DENOTING_GAP = (0xffffffff);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_SO_NO_RASTERIZED_STREAM"]/*' />
    [NativeTypeName("#define D3D11_SO_NO_RASTERIZED_STREAM ( 0xffffffff )")]
    public const uint D3D11_SO_NO_RASTERIZED_STREAM = (0xffffffff);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_SO_OUTPUT_COMPONENT_COUNT"]/*' />
    [NativeTypeName("#define D3D11_SO_OUTPUT_COMPONENT_COUNT ( 128 )")]
    public const int D3D11_SO_OUTPUT_COMPONENT_COUNT = (128);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_SO_STREAM_COUNT"]/*' />
    [NativeTypeName("#define D3D11_SO_STREAM_COUNT ( 4 )")]
    public const int D3D11_SO_STREAM_COUNT = (4);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_SPEC_DATE_DAY"]/*' />
    [NativeTypeName("#define D3D11_SPEC_DATE_DAY ( 16 )")]
    public const int D3D11_SPEC_DATE_DAY = (16);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_SPEC_DATE_MONTH"]/*' />
    [NativeTypeName("#define D3D11_SPEC_DATE_MONTH ( 05 )")]
    public const int D3D11_SPEC_DATE_MONTH = (05);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_SPEC_DATE_YEAR"]/*' />
    [NativeTypeName("#define D3D11_SPEC_DATE_YEAR ( 2011 )")]
    public const int D3D11_SPEC_DATE_YEAR = (2011);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_SPEC_VERSION"]/*' />
    [NativeTypeName("#define D3D11_SPEC_VERSION ( 1.07 )")]
    public const double D3D11_SPEC_VERSION = (1.07);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_SRGB_GAMMA"]/*' />
    [NativeTypeName("#define D3D11_SRGB_GAMMA ( 2.2f )")]
    public const float D3D11_SRGB_GAMMA = (2.2f);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_SRGB_TO_FLOAT_DENOMINATOR_1"]/*' />
    [NativeTypeName("#define D3D11_SRGB_TO_FLOAT_DENOMINATOR_1 ( 12.92f )")]
    public const float D3D11_SRGB_TO_FLOAT_DENOMINATOR_1 = (12.92f);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_SRGB_TO_FLOAT_DENOMINATOR_2"]/*' />
    [NativeTypeName("#define D3D11_SRGB_TO_FLOAT_DENOMINATOR_2 ( 1.055f )")]
    public const float D3D11_SRGB_TO_FLOAT_DENOMINATOR_2 = (1.055f);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_SRGB_TO_FLOAT_EXPONENT"]/*' />
    [NativeTypeName("#define D3D11_SRGB_TO_FLOAT_EXPONENT ( 2.4f )")]
    public const float D3D11_SRGB_TO_FLOAT_EXPONENT = (2.4f);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_SRGB_TO_FLOAT_OFFSET"]/*' />
    [NativeTypeName("#define D3D11_SRGB_TO_FLOAT_OFFSET ( 0.055f )")]
    public const float D3D11_SRGB_TO_FLOAT_OFFSET = (0.055f);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_SRGB_TO_FLOAT_THRESHOLD"]/*' />
    [NativeTypeName("#define D3D11_SRGB_TO_FLOAT_THRESHOLD ( 0.04045f )")]
    public const float D3D11_SRGB_TO_FLOAT_THRESHOLD = (0.04045f);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_SRGB_TO_FLOAT_TOLERANCE_IN_ULP"]/*' />
    [NativeTypeName("#define D3D11_SRGB_TO_FLOAT_TOLERANCE_IN_ULP ( 0.5f )")]
    public const float D3D11_SRGB_TO_FLOAT_TOLERANCE_IN_ULP = (0.5f);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_STANDARD_COMPONENT_BIT_COUNT"]/*' />
    [NativeTypeName("#define D3D11_STANDARD_COMPONENT_BIT_COUNT ( 32 )")]
    public const int D3D11_STANDARD_COMPONENT_BIT_COUNT = (32);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_STANDARD_COMPONENT_BIT_COUNT_DOUBLED"]/*' />
    [NativeTypeName("#define D3D11_STANDARD_COMPONENT_BIT_COUNT_DOUBLED ( 64 )")]
    public const int D3D11_STANDARD_COMPONENT_BIT_COUNT_DOUBLED = (64);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_STANDARD_MAXIMUM_ELEMENT_ALIGNMENT_BYTE_MULTIPLE"]/*' />
    [NativeTypeName("#define D3D11_STANDARD_MAXIMUM_ELEMENT_ALIGNMENT_BYTE_MULTIPLE ( 4 )")]
    public const int D3D11_STANDARD_MAXIMUM_ELEMENT_ALIGNMENT_BYTE_MULTIPLE = (4);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_STANDARD_PIXEL_COMPONENT_COUNT"]/*' />
    [NativeTypeName("#define D3D11_STANDARD_PIXEL_COMPONENT_COUNT ( 128 )")]
    public const int D3D11_STANDARD_PIXEL_COMPONENT_COUNT = (128);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_STANDARD_PIXEL_ELEMENT_COUNT"]/*' />
    [NativeTypeName("#define D3D11_STANDARD_PIXEL_ELEMENT_COUNT ( 32 )")]
    public const int D3D11_STANDARD_PIXEL_ELEMENT_COUNT = (32);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_STANDARD_VECTOR_SIZE"]/*' />
    [NativeTypeName("#define D3D11_STANDARD_VECTOR_SIZE ( 4 )")]
    public const int D3D11_STANDARD_VECTOR_SIZE = (4);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_STANDARD_VERTEX_ELEMENT_COUNT"]/*' />
    [NativeTypeName("#define D3D11_STANDARD_VERTEX_ELEMENT_COUNT ( 32 )")]
    public const int D3D11_STANDARD_VERTEX_ELEMENT_COUNT = (32);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_STANDARD_VERTEX_TOTAL_COMPONENT_COUNT"]/*' />
    [NativeTypeName("#define D3D11_STANDARD_VERTEX_TOTAL_COMPONENT_COUNT ( 64 )")]
    public const int D3D11_STANDARD_VERTEX_TOTAL_COMPONENT_COUNT = (64);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_SUBPIXEL_FRACTIONAL_BIT_COUNT"]/*' />
    [NativeTypeName("#define D3D11_SUBPIXEL_FRACTIONAL_BIT_COUNT ( 8 )")]
    public const int D3D11_SUBPIXEL_FRACTIONAL_BIT_COUNT = (8);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_SUBTEXEL_FRACTIONAL_BIT_COUNT"]/*' />
    [NativeTypeName("#define D3D11_SUBTEXEL_FRACTIONAL_BIT_COUNT ( 8 )")]
    public const int D3D11_SUBTEXEL_FRACTIONAL_BIT_COUNT = (8);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_TESSELLATOR_MAX_EVEN_TESSELLATION_FACTOR"]/*' />
    [NativeTypeName("#define D3D11_TESSELLATOR_MAX_EVEN_TESSELLATION_FACTOR ( 64 )")]
    public const int D3D11_TESSELLATOR_MAX_EVEN_TESSELLATION_FACTOR = (64);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_TESSELLATOR_MAX_ISOLINE_DENSITY_TESSELLATION_FACTOR"]/*' />
    [NativeTypeName("#define D3D11_TESSELLATOR_MAX_ISOLINE_DENSITY_TESSELLATION_FACTOR ( 64 )")]
    public const int D3D11_TESSELLATOR_MAX_ISOLINE_DENSITY_TESSELLATION_FACTOR = (64);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_TESSELLATOR_MAX_ODD_TESSELLATION_FACTOR"]/*' />
    [NativeTypeName("#define D3D11_TESSELLATOR_MAX_ODD_TESSELLATION_FACTOR ( 63 )")]
    public const int D3D11_TESSELLATOR_MAX_ODD_TESSELLATION_FACTOR = (63);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_TESSELLATOR_MAX_TESSELLATION_FACTOR"]/*' />
    [NativeTypeName("#define D3D11_TESSELLATOR_MAX_TESSELLATION_FACTOR ( 64 )")]
    public const int D3D11_TESSELLATOR_MAX_TESSELLATION_FACTOR = (64);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_TESSELLATOR_MIN_EVEN_TESSELLATION_FACTOR"]/*' />
    [NativeTypeName("#define D3D11_TESSELLATOR_MIN_EVEN_TESSELLATION_FACTOR ( 2 )")]
    public const int D3D11_TESSELLATOR_MIN_EVEN_TESSELLATION_FACTOR = (2);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_TESSELLATOR_MIN_ISOLINE_DENSITY_TESSELLATION_FACTOR"]/*' />
    [NativeTypeName("#define D3D11_TESSELLATOR_MIN_ISOLINE_DENSITY_TESSELLATION_FACTOR ( 1 )")]
    public const int D3D11_TESSELLATOR_MIN_ISOLINE_DENSITY_TESSELLATION_FACTOR = (1);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_TESSELLATOR_MIN_ODD_TESSELLATION_FACTOR"]/*' />
    [NativeTypeName("#define D3D11_TESSELLATOR_MIN_ODD_TESSELLATION_FACTOR ( 1 )")]
    public const int D3D11_TESSELLATOR_MIN_ODD_TESSELLATION_FACTOR = (1);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_TEXEL_ADDRESS_RANGE_BIT_COUNT"]/*' />
    [NativeTypeName("#define D3D11_TEXEL_ADDRESS_RANGE_BIT_COUNT ( 16 )")]
    public const int D3D11_TEXEL_ADDRESS_RANGE_BIT_COUNT = (16);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_UNBOUND_MEMORY_ACCESS_RESULT"]/*' />
    [NativeTypeName("#define D3D11_UNBOUND_MEMORY_ACCESS_RESULT ( 0 )")]
    public const int D3D11_UNBOUND_MEMORY_ACCESS_RESULT = (0);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_VIEWPORT_AND_SCISSORRECT_MAX_INDEX"]/*' />
    [NativeTypeName("#define D3D11_VIEWPORT_AND_SCISSORRECT_MAX_INDEX ( 15 )")]
    public const int D3D11_VIEWPORT_AND_SCISSORRECT_MAX_INDEX = (15);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_VIEWPORT_AND_SCISSORRECT_OBJECT_COUNT_PER_PIPELINE"]/*' />
    [NativeTypeName("#define D3D11_VIEWPORT_AND_SCISSORRECT_OBJECT_COUNT_PER_PIPELINE ( 16 )")]
    public const int D3D11_VIEWPORT_AND_SCISSORRECT_OBJECT_COUNT_PER_PIPELINE = (16);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_VIEWPORT_BOUNDS_MAX"]/*' />
    [NativeTypeName("#define D3D11_VIEWPORT_BOUNDS_MAX ( 32767 )")]
    public const int D3D11_VIEWPORT_BOUNDS_MAX = (32767);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_VIEWPORT_BOUNDS_MIN"]/*' />
    [NativeTypeName("#define D3D11_VIEWPORT_BOUNDS_MIN ( -32768 )")]
    public const int D3D11_VIEWPORT_BOUNDS_MIN = (-32768);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_VS_INPUT_REGISTER_COMPONENTS"]/*' />
    [NativeTypeName("#define D3D11_VS_INPUT_REGISTER_COMPONENTS ( 4 )")]
    public const int D3D11_VS_INPUT_REGISTER_COMPONENTS = (4);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_VS_INPUT_REGISTER_COMPONENT_BIT_COUNT"]/*' />
    [NativeTypeName("#define D3D11_VS_INPUT_REGISTER_COMPONENT_BIT_COUNT ( 32 )")]
    public const int D3D11_VS_INPUT_REGISTER_COMPONENT_BIT_COUNT = (32);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_VS_INPUT_REGISTER_COUNT"]/*' />
    [NativeTypeName("#define D3D11_VS_INPUT_REGISTER_COUNT ( 32 )")]
    public const int D3D11_VS_INPUT_REGISTER_COUNT = (32);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_VS_INPUT_REGISTER_READS_PER_INST"]/*' />
    [NativeTypeName("#define D3D11_VS_INPUT_REGISTER_READS_PER_INST ( 2 )")]
    public const int D3D11_VS_INPUT_REGISTER_READS_PER_INST = (2);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_VS_INPUT_REGISTER_READ_PORTS"]/*' />
    [NativeTypeName("#define D3D11_VS_INPUT_REGISTER_READ_PORTS ( 1 )")]
    public const int D3D11_VS_INPUT_REGISTER_READ_PORTS = (1);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_VS_OUTPUT_REGISTER_COMPONENTS"]/*' />
    [NativeTypeName("#define D3D11_VS_OUTPUT_REGISTER_COMPONENTS ( 4 )")]
    public const int D3D11_VS_OUTPUT_REGISTER_COMPONENTS = (4);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_VS_OUTPUT_REGISTER_COMPONENT_BIT_COUNT"]/*' />
    [NativeTypeName("#define D3D11_VS_OUTPUT_REGISTER_COMPONENT_BIT_COUNT ( 32 )")]
    public const int D3D11_VS_OUTPUT_REGISTER_COMPONENT_BIT_COUNT = (32);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_VS_OUTPUT_REGISTER_COUNT"]/*' />
    [NativeTypeName("#define D3D11_VS_OUTPUT_REGISTER_COUNT ( 32 )")]
    public const int D3D11_VS_OUTPUT_REGISTER_COUNT = (32);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_WHQL_CONTEXT_COUNT_FOR_RESOURCE_LIMIT"]/*' />
    [NativeTypeName("#define D3D11_WHQL_CONTEXT_COUNT_FOR_RESOURCE_LIMIT ( 10 )")]
    public const int D3D11_WHQL_CONTEXT_COUNT_FOR_RESOURCE_LIMIT = (10);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_WHQL_DRAWINDEXED_INDEX_COUNT_2_TO_EXP"]/*' />
    [NativeTypeName("#define D3D11_WHQL_DRAWINDEXED_INDEX_COUNT_2_TO_EXP ( 25 )")]
    public const int D3D11_WHQL_DRAWINDEXED_INDEX_COUNT_2_TO_EXP = (25);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_WHQL_DRAW_VERTEX_COUNT_2_TO_EXP"]/*' />
    [NativeTypeName("#define D3D11_WHQL_DRAW_VERTEX_COUNT_2_TO_EXP ( 25 )")]
    public const int D3D11_WHQL_DRAW_VERTEX_COUNT_2_TO_EXP = (25);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_1_UAV_SLOT_COUNT"]/*' />
    [NativeTypeName("#define D3D11_1_UAV_SLOT_COUNT ( 64 )")]
    public const int D3D11_1_UAV_SLOT_COUNT = (64);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_2_TILED_RESOURCE_TILE_SIZE_IN_BYTES"]/*' />
    [NativeTypeName("#define D3D11_2_TILED_RESOURCE_TILE_SIZE_IN_BYTES ( 65536 )")]
    public const int D3D11_2_TILED_RESOURCE_TILE_SIZE_IN_BYTES = (65536);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_4_VIDEO_DECODER_MAX_HISTOGRAM_COMPONENTS"]/*' />
    [NativeTypeName("#define D3D11_4_VIDEO_DECODER_MAX_HISTOGRAM_COMPONENTS ( 4 )")]
    public const int D3D11_4_VIDEO_DECODER_MAX_HISTOGRAM_COMPONENTS = (4);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_4_VIDEO_DECODER_HISTOGRAM_OFFSET_ALIGNMENT"]/*' />
    [NativeTypeName("#define D3D11_4_VIDEO_DECODER_HISTOGRAM_OFFSET_ALIGNMENT ( 256 )")]
    public const int D3D11_4_VIDEO_DECODER_HISTOGRAM_OFFSET_ALIGNMENT = (256);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_APPEND_ALIGNED_ELEMENT"]/*' />
    [NativeTypeName("#define D3D11_APPEND_ALIGNED_ELEMENT ( 0xffffffff )")]
    public const uint D3D11_APPEND_ALIGNED_ELEMENT = (0xffffffff);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_FILTER_REDUCTION_TYPE_MASK"]/*' />
    [NativeTypeName("#define D3D11_FILTER_REDUCTION_TYPE_MASK ( 0x3 )")]
    public const int D3D11_FILTER_REDUCTION_TYPE_MASK = (0x3);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_FILTER_REDUCTION_TYPE_SHIFT"]/*' />
    [NativeTypeName("#define D3D11_FILTER_REDUCTION_TYPE_SHIFT ( 7 )")]
    public const int D3D11_FILTER_REDUCTION_TYPE_SHIFT = (7);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_FILTER_TYPE_MASK"]/*' />
    [NativeTypeName("#define D3D11_FILTER_TYPE_MASK ( 0x3 )")]
    public const int D3D11_FILTER_TYPE_MASK = (0x3);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_MIN_FILTER_SHIFT"]/*' />
    [NativeTypeName("#define D3D11_MIN_FILTER_SHIFT ( 4 )")]
    public const int D3D11_MIN_FILTER_SHIFT = (4);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_MAG_FILTER_SHIFT"]/*' />
    [NativeTypeName("#define D3D11_MAG_FILTER_SHIFT ( 2 )")]
    public const int D3D11_MAG_FILTER_SHIFT = (2);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_MIP_FILTER_SHIFT"]/*' />
    [NativeTypeName("#define D3D11_MIP_FILTER_SHIFT ( 0 )")]
    public const int D3D11_MIP_FILTER_SHIFT = (0);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_COMPARISON_FILTERING_BIT"]/*' />
    [NativeTypeName("#define D3D11_COMPARISON_FILTERING_BIT ( 0x80 )")]
    public const int D3D11_COMPARISON_FILTERING_BIT = (0x80);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_ANISOTROPIC_FILTERING_BIT"]/*' />
    [NativeTypeName("#define D3D11_ANISOTROPIC_FILTERING_BIT ( 0x40 )")]
    public const int D3D11_ANISOTROPIC_FILTERING_BIT = (0x40);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_SDK_VERSION"]/*' />
    [NativeTypeName("#define D3D11_SDK_VERSION ( 7 )")]
    public const int D3D11_SDK_VERSION = (7);
}
