// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/gdiplusimaging.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Gdiplus;

public static partial class Gdiplus
{
    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.ImageFormatUndefined"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid ImageFormatUndefined
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xA9, 0x3C, 0x6B, 0xB9,
                0x28, 0x07,
                0xD3, 0x11,
                0x9D,
                0x7B,
                0x00,
                0x00,
                0xF8,
                0x1E,
                0xF3,
                0x2E
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.ImageFormatMemoryBMP"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid ImageFormatMemoryBMP
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xAA, 0x3C, 0x6B, 0xB9,
                0x28, 0x07,
                0xD3, 0x11,
                0x9D,
                0x7B,
                0x00,
                0x00,
                0xF8,
                0x1E,
                0xF3,
                0x2E
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.ImageFormatBMP"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid ImageFormatBMP
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xAB, 0x3C, 0x6B, 0xB9,
                0x28, 0x07,
                0xD3, 0x11,
                0x9D,
                0x7B,
                0x00,
                0x00,
                0xF8,
                0x1E,
                0xF3,
                0x2E
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.ImageFormatEMF"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid ImageFormatEMF
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xAC, 0x3C, 0x6B, 0xB9,
                0x28, 0x07,
                0xD3, 0x11,
                0x9D,
                0x7B,
                0x00,
                0x00,
                0xF8,
                0x1E,
                0xF3,
                0x2E
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.ImageFormatWMF"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid ImageFormatWMF
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xAD, 0x3C, 0x6B, 0xB9,
                0x28, 0x07,
                0xD3, 0x11,
                0x9D,
                0x7B,
                0x00,
                0x00,
                0xF8,
                0x1E,
                0xF3,
                0x2E
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.ImageFormatJPEG"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid ImageFormatJPEG
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xAE, 0x3C, 0x6B, 0xB9,
                0x28, 0x07,
                0xD3, 0x11,
                0x9D,
                0x7B,
                0x00,
                0x00,
                0xF8,
                0x1E,
                0xF3,
                0x2E
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.ImageFormatPNG"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid ImageFormatPNG
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xAF, 0x3C, 0x6B, 0xB9,
                0x28, 0x07,
                0xD3, 0x11,
                0x9D,
                0x7B,
                0x00,
                0x00,
                0xF8,
                0x1E,
                0xF3,
                0x2E
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.ImageFormatGIF"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid ImageFormatGIF
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xB0, 0x3C, 0x6B, 0xB9,
                0x28, 0x07,
                0xD3, 0x11,
                0x9D,
                0x7B,
                0x00,
                0x00,
                0xF8,
                0x1E,
                0xF3,
                0x2E
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.ImageFormatTIFF"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid ImageFormatTIFF
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xB1, 0x3C, 0x6B, 0xB9,
                0x28, 0x07,
                0xD3, 0x11,
                0x9D,
                0x7B,
                0x00,
                0x00,
                0xF8,
                0x1E,
                0xF3,
                0x2E
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.ImageFormatEXIF"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid ImageFormatEXIF
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xB2, 0x3C, 0x6B, 0xB9,
                0x28, 0x07,
                0xD3, 0x11,
                0x9D,
                0x7B,
                0x00,
                0x00,
                0xF8,
                0x1E,
                0xF3,
                0x2E
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.ImageFormatIcon"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid ImageFormatIcon
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xB5, 0x3C, 0x6B, 0xB9,
                0x28, 0x07,
                0xD3, 0x11,
                0x9D,
                0x7B,
                0x00,
                0x00,
                0xF8,
                0x1E,
                0xF3,
                0x2E
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.ImageFormatHEIF"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid ImageFormatHEIF
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xB6, 0x3C, 0x6B, 0xB9,
                0x28, 0x07,
                0xD3, 0x11,
                0x9D,
                0x7B,
                0x00,
                0x00,
                0xF8,
                0x1E,
                0xF3,
                0x2E
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.ImageFormatWEBP"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid ImageFormatWEBP
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xB7, 0x3C, 0x6B, 0xB9,
                0x28, 0x07,
                0xD3, 0x11,
                0x9D,
                0x7B,
                0x00,
                0x00,
                0xF8,
                0x1E,
                0xF3,
                0x2E
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.FrameDimensionTime"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid FrameDimensionTime
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x6D, 0xBD, 0xED, 0x6A,
                0xB5, 0x3F,
                0x8A, 0x41,
                0x83,
                0xA6,
                0x7F,
                0x45,
                0x22,
                0x9D,
                0xC8,
                0x72
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.FrameDimensionResolution"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid FrameDimensionResolution
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x7B, 0x6F, 0x23, 0x84,
                0xD3, 0x3B,
                0x8F, 0x42,
                0x8D,
                0xAB,
                0x4E,
                0xA1,
                0x43,
                0x9C,
                0xA3,
                0x15
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.FrameDimensionPage"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid FrameDimensionPage
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x86, 0xDC, 0x62, 0x74,
                0x80, 0x61,
                0x7E, 0x4C,
                0x8E,
                0x3F,
                0xEE,
                0x73,
                0x33,
                0xA7,
                0xA4,
                0x83
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.FormatIDImageInformation"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid FormatIDImageInformation
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xBE, 0x6C, 0x83, 0xE5,
                0xEF, 0x5E,
                0x1D, 0x4F,
                0xAC,
                0xDE,
                0xAE,
                0x4C,
                0x43,
                0xB6,
                0x08,
                0xCE
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.FormatIDJpegAppHeaders"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid FormatIDJpegAppHeaders
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xCD, 0xFD, 0x4A, 0x1C,
                0x77, 0x61,
                0xCF, 0x43,
                0xAB,
                0xC7,
                0x5F,
                0x51,
                0xAF,
                0x39,
                0xEE,
                0x85
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.EncoderCompression"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid EncoderCompression
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x9D, 0x73, 0x9D, 0xE0,
                0xD4, 0xCC,
                0xEE, 0x44,
                0x8E,
                0xBA,
                0x3F,
                0xBF,
                0x8B,
                0xE4,
                0xFC,
                0x58
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.EncoderColorDepth"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid EncoderColorDepth
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x55, 0x70, 0x08, 0x66,
                0x66, 0xAD,
                0x7C, 0x4C,
                0x9A,
                0x18,
                0x38,
                0xA2,
                0x31,
                0x0B,
                0x83,
                0x37
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.EncoderScanMethod"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid EncoderScanMethod
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x61, 0x26, 0x4E, 0x3A,
                0x09, 0x31,
                0x56, 0x4E,
                0x85,
                0x36,
                0x42,
                0xC1,
                0x56,
                0xE7,
                0xDC,
                0xFA
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.EncoderVersion"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid EncoderVersion
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x76, 0x8C, 0xD1, 0x24,
                0x4A, 0x81,
                0xA4, 0x41,
                0xBF,
                0x53,
                0x1C,
                0x21,
                0x9C,
                0xCC,
                0xF7,
                0x97
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.EncoderRenderMethod"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid EncoderRenderMethod
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x3A, 0xC5, 0x42, 0x6D,
                0x9A, 0x22,
                0x25, 0x48,
                0x8B,
                0xB7,
                0x5C,
                0x99,
                0xE2,
                0xB9,
                0xA8,
                0xB8
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.EncoderQuality"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid EncoderQuality
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xB5, 0xE4, 0x5B, 0x1D,
                0x4A, 0xFA,
                0x2D, 0x45,
                0x9C,
                0xDD,
                0x5D,
                0xB3,
                0x51,
                0x05,
                0xE7,
                0xEB
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.EncoderTransformation"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid EncoderTransformation
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xD1, 0xB2, 0x0E, 0x8D,
                0x8E, 0xA5,
                0xA8, 0x4E,
                0xAA,
                0x14,
                0x10,
                0x80,
                0x74,
                0xB7,
                0xB6,
                0xF9
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.EncoderLuminanceTable"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid EncoderLuminanceTable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xCE, 0x3B, 0xB3, 0xED,
                0x66, 0x02,
                0x77, 0x4A,
                0xB9,
                0x04,
                0x27,
                0x21,
                0x60,
                0x99,
                0xE7,
                0x17
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.EncoderChrominanceTable"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid EncoderChrominanceTable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xDC, 0x55, 0xE4, 0xF2,
                0xB3, 0x09,
                0x16, 0x43,
                0x82,
                0x60,
                0x67,
                0x6A,
                0xDA,
                0x32,
                0x48,
                0x1C
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.EncoderSaveFlag"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid EncoderSaveFlag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xFC, 0x66, 0x22, 0x29,
                0x40, 0xAC,
                0xBF, 0x47,
                0x8C,
                0xFC,
                0xA8,
                0x5B,
                0x89,
                0xA6,
                0x55,
                0xDE
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.EncoderColorSpace"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid EncoderColorSpace
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xA0, 0x62, 0x7A, 0xAE,
                0x2C, 0xEE,
                0xD8, 0x49,
                0x9D,
                0x07,
                0x1B,
                0xA8,
                0xA9,
                0x27,
                0x59,
                0x6E
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.EncoderImageItems"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid EncoderImageItems
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x13, 0x5E, 0x87, 0x63,
                0x1D, 0x1F,
                0xAB, 0x45,
                0x91,
                0x95,
                0xA2,
                0x9B,
                0x60,
                0x66,
                0xA6,
                0x50
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.EncoderSaveAsCMYK"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid EncoderSaveAsCMYK
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xC9, 0xBB, 0x19, 0xA2,
                0x9D, 0x0A,
                0x05, 0x40,
                0xA3,
                0xEE,
                0x3A,
                0x42,
                0x1B,
                0x8B,
                0xB0,
                0x6C
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.CodecIImageBytes"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid CodecIImageBytes
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x23, 0x18, 0x5D, 0x02,
                0x7D, 0x6C,
                0x7B, 0x44,
                0xBB,
                0xDB,
                0xA3,
                0xCB,
                0xC3,
                0xDF,
                0xA2,
                0xFC
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagTypeByte"]/*' />
    [NativeTypeName("#define PropertyTagTypeByte 1")]
    public const int PropertyTagTypeByte = 1;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagTypeASCII"]/*' />
    [NativeTypeName("#define PropertyTagTypeASCII 2")]
    public const int PropertyTagTypeASCII = 2;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagTypeShort"]/*' />
    [NativeTypeName("#define PropertyTagTypeShort 3")]
    public const int PropertyTagTypeShort = 3;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagTypeLong"]/*' />
    [NativeTypeName("#define PropertyTagTypeLong 4")]
    public const int PropertyTagTypeLong = 4;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagTypeRational"]/*' />
    [NativeTypeName("#define PropertyTagTypeRational 5")]
    public const int PropertyTagTypeRational = 5;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagTypeUndefined"]/*' />
    [NativeTypeName("#define PropertyTagTypeUndefined 7")]
    public const int PropertyTagTypeUndefined = 7;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagTypeSLONG"]/*' />
    [NativeTypeName("#define PropertyTagTypeSLONG 9")]
    public const int PropertyTagTypeSLONG = 9;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagTypeSRational"]/*' />
    [NativeTypeName("#define PropertyTagTypeSRational 10")]
    public const int PropertyTagTypeSRational = 10;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagExifIFD"]/*' />
    [NativeTypeName("#define PropertyTagExifIFD 0x8769")]
    public const int PropertyTagExifIFD = 0x8769;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagGpsIFD"]/*' />
    [NativeTypeName("#define PropertyTagGpsIFD 0x8825")]
    public const int PropertyTagGpsIFD = 0x8825;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagNewSubfileType"]/*' />
    [NativeTypeName("#define PropertyTagNewSubfileType 0x00FE")]
    public const int PropertyTagNewSubfileType = 0x00FE;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagSubfileType"]/*' />
    [NativeTypeName("#define PropertyTagSubfileType 0x00FF")]
    public const int PropertyTagSubfileType = 0x00FF;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagImageWidth"]/*' />
    [NativeTypeName("#define PropertyTagImageWidth 0x0100")]
    public const int PropertyTagImageWidth = 0x0100;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagImageHeight"]/*' />
    [NativeTypeName("#define PropertyTagImageHeight 0x0101")]
    public const int PropertyTagImageHeight = 0x0101;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagBitsPerSample"]/*' />
    [NativeTypeName("#define PropertyTagBitsPerSample 0x0102")]
    public const int PropertyTagBitsPerSample = 0x0102;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagCompression"]/*' />
    [NativeTypeName("#define PropertyTagCompression 0x0103")]
    public const int PropertyTagCompression = 0x0103;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagPhotometricInterp"]/*' />
    [NativeTypeName("#define PropertyTagPhotometricInterp 0x0106")]
    public const int PropertyTagPhotometricInterp = 0x0106;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagThreshHolding"]/*' />
    [NativeTypeName("#define PropertyTagThreshHolding 0x0107")]
    public const int PropertyTagThreshHolding = 0x0107;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagCellWidth"]/*' />
    [NativeTypeName("#define PropertyTagCellWidth 0x0108")]
    public const int PropertyTagCellWidth = 0x0108;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagCellHeight"]/*' />
    [NativeTypeName("#define PropertyTagCellHeight 0x0109")]
    public const int PropertyTagCellHeight = 0x0109;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagFillOrder"]/*' />
    [NativeTypeName("#define PropertyTagFillOrder 0x010A")]
    public const int PropertyTagFillOrder = 0x010A;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagDocumentName"]/*' />
    [NativeTypeName("#define PropertyTagDocumentName 0x010D")]
    public const int PropertyTagDocumentName = 0x010D;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagImageDescription"]/*' />
    [NativeTypeName("#define PropertyTagImageDescription 0x010E")]
    public const int PropertyTagImageDescription = 0x010E;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagEquipMake"]/*' />
    [NativeTypeName("#define PropertyTagEquipMake 0x010F")]
    public const int PropertyTagEquipMake = 0x010F;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagEquipModel"]/*' />
    [NativeTypeName("#define PropertyTagEquipModel 0x0110")]
    public const int PropertyTagEquipModel = 0x0110;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagStripOffsets"]/*' />
    [NativeTypeName("#define PropertyTagStripOffsets 0x0111")]
    public const int PropertyTagStripOffsets = 0x0111;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagOrientation"]/*' />
    [NativeTypeName("#define PropertyTagOrientation 0x0112")]
    public const int PropertyTagOrientation = 0x0112;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagSamplesPerPixel"]/*' />
    [NativeTypeName("#define PropertyTagSamplesPerPixel 0x0115")]
    public const int PropertyTagSamplesPerPixel = 0x0115;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagRowsPerStrip"]/*' />
    [NativeTypeName("#define PropertyTagRowsPerStrip 0x0116")]
    public const int PropertyTagRowsPerStrip = 0x0116;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagStripBytesCount"]/*' />
    [NativeTypeName("#define PropertyTagStripBytesCount 0x0117")]
    public const int PropertyTagStripBytesCount = 0x0117;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagMinSampleValue"]/*' />
    [NativeTypeName("#define PropertyTagMinSampleValue 0x0118")]
    public const int PropertyTagMinSampleValue = 0x0118;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagMaxSampleValue"]/*' />
    [NativeTypeName("#define PropertyTagMaxSampleValue 0x0119")]
    public const int PropertyTagMaxSampleValue = 0x0119;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagXResolution"]/*' />
    [NativeTypeName("#define PropertyTagXResolution 0x011A")]
    public const int PropertyTagXResolution = 0x011A;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagYResolution"]/*' />
    [NativeTypeName("#define PropertyTagYResolution 0x011B")]
    public const int PropertyTagYResolution = 0x011B;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagPlanarConfig"]/*' />
    [NativeTypeName("#define PropertyTagPlanarConfig 0x011C")]
    public const int PropertyTagPlanarConfig = 0x011C;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagPageName"]/*' />
    [NativeTypeName("#define PropertyTagPageName 0x011D")]
    public const int PropertyTagPageName = 0x011D;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagXPosition"]/*' />
    [NativeTypeName("#define PropertyTagXPosition 0x011E")]
    public const int PropertyTagXPosition = 0x011E;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagYPosition"]/*' />
    [NativeTypeName("#define PropertyTagYPosition 0x011F")]
    public const int PropertyTagYPosition = 0x011F;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagFreeOffset"]/*' />
    [NativeTypeName("#define PropertyTagFreeOffset 0x0120")]
    public const int PropertyTagFreeOffset = 0x0120;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagFreeByteCounts"]/*' />
    [NativeTypeName("#define PropertyTagFreeByteCounts 0x0121")]
    public const int PropertyTagFreeByteCounts = 0x0121;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagGrayResponseUnit"]/*' />
    [NativeTypeName("#define PropertyTagGrayResponseUnit 0x0122")]
    public const int PropertyTagGrayResponseUnit = 0x0122;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagGrayResponseCurve"]/*' />
    [NativeTypeName("#define PropertyTagGrayResponseCurve 0x0123")]
    public const int PropertyTagGrayResponseCurve = 0x0123;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagT4Option"]/*' />
    [NativeTypeName("#define PropertyTagT4Option 0x0124")]
    public const int PropertyTagT4Option = 0x0124;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagT6Option"]/*' />
    [NativeTypeName("#define PropertyTagT6Option 0x0125")]
    public const int PropertyTagT6Option = 0x0125;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagResolutionUnit"]/*' />
    [NativeTypeName("#define PropertyTagResolutionUnit 0x0128")]
    public const int PropertyTagResolutionUnit = 0x0128;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagPageNumber"]/*' />
    [NativeTypeName("#define PropertyTagPageNumber 0x0129")]
    public const int PropertyTagPageNumber = 0x0129;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagTransferFuncition"]/*' />
    [NativeTypeName("#define PropertyTagTransferFuncition 0x012D")]
    public const int PropertyTagTransferFuncition = 0x012D;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagSoftwareUsed"]/*' />
    [NativeTypeName("#define PropertyTagSoftwareUsed 0x0131")]
    public const int PropertyTagSoftwareUsed = 0x0131;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagDateTime"]/*' />
    [NativeTypeName("#define PropertyTagDateTime 0x0132")]
    public const int PropertyTagDateTime = 0x0132;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagArtist"]/*' />
    [NativeTypeName("#define PropertyTagArtist 0x013B")]
    public const int PropertyTagArtist = 0x013B;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagHostComputer"]/*' />
    [NativeTypeName("#define PropertyTagHostComputer 0x013C")]
    public const int PropertyTagHostComputer = 0x013C;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagPredictor"]/*' />
    [NativeTypeName("#define PropertyTagPredictor 0x013D")]
    public const int PropertyTagPredictor = 0x013D;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagWhitePoint"]/*' />
    [NativeTypeName("#define PropertyTagWhitePoint 0x013E")]
    public const int PropertyTagWhitePoint = 0x013E;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagPrimaryChromaticities"]/*' />
    [NativeTypeName("#define PropertyTagPrimaryChromaticities 0x013F")]
    public const int PropertyTagPrimaryChromaticities = 0x013F;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagColorMap"]/*' />
    [NativeTypeName("#define PropertyTagColorMap 0x0140")]
    public const int PropertyTagColorMap = 0x0140;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagHalftoneHints"]/*' />
    [NativeTypeName("#define PropertyTagHalftoneHints 0x0141")]
    public const int PropertyTagHalftoneHints = 0x0141;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagTileWidth"]/*' />
    [NativeTypeName("#define PropertyTagTileWidth 0x0142")]
    public const int PropertyTagTileWidth = 0x0142;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagTileLength"]/*' />
    [NativeTypeName("#define PropertyTagTileLength 0x0143")]
    public const int PropertyTagTileLength = 0x0143;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagTileOffset"]/*' />
    [NativeTypeName("#define PropertyTagTileOffset 0x0144")]
    public const int PropertyTagTileOffset = 0x0144;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagTileByteCounts"]/*' />
    [NativeTypeName("#define PropertyTagTileByteCounts 0x0145")]
    public const int PropertyTagTileByteCounts = 0x0145;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagInkSet"]/*' />
    [NativeTypeName("#define PropertyTagInkSet 0x014C")]
    public const int PropertyTagInkSet = 0x014C;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagInkNames"]/*' />
    [NativeTypeName("#define PropertyTagInkNames 0x014D")]
    public const int PropertyTagInkNames = 0x014D;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagNumberOfInks"]/*' />
    [NativeTypeName("#define PropertyTagNumberOfInks 0x014E")]
    public const int PropertyTagNumberOfInks = 0x014E;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagDotRange"]/*' />
    [NativeTypeName("#define PropertyTagDotRange 0x0150")]
    public const int PropertyTagDotRange = 0x0150;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagTargetPrinter"]/*' />
    [NativeTypeName("#define PropertyTagTargetPrinter 0x0151")]
    public const int PropertyTagTargetPrinter = 0x0151;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagExtraSamples"]/*' />
    [NativeTypeName("#define PropertyTagExtraSamples 0x0152")]
    public const int PropertyTagExtraSamples = 0x0152;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagSampleFormat"]/*' />
    [NativeTypeName("#define PropertyTagSampleFormat 0x0153")]
    public const int PropertyTagSampleFormat = 0x0153;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagSMinSampleValue"]/*' />
    [NativeTypeName("#define PropertyTagSMinSampleValue 0x0154")]
    public const int PropertyTagSMinSampleValue = 0x0154;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagSMaxSampleValue"]/*' />
    [NativeTypeName("#define PropertyTagSMaxSampleValue 0x0155")]
    public const int PropertyTagSMaxSampleValue = 0x0155;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagTransferRange"]/*' />
    [NativeTypeName("#define PropertyTagTransferRange 0x0156")]
    public const int PropertyTagTransferRange = 0x0156;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagJPEGProc"]/*' />
    [NativeTypeName("#define PropertyTagJPEGProc 0x0200")]
    public const int PropertyTagJPEGProc = 0x0200;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagJPEGInterFormat"]/*' />
    [NativeTypeName("#define PropertyTagJPEGInterFormat 0x0201")]
    public const int PropertyTagJPEGInterFormat = 0x0201;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagJPEGInterLength"]/*' />
    [NativeTypeName("#define PropertyTagJPEGInterLength 0x0202")]
    public const int PropertyTagJPEGInterLength = 0x0202;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagJPEGRestartInterval"]/*' />
    [NativeTypeName("#define PropertyTagJPEGRestartInterval 0x0203")]
    public const int PropertyTagJPEGRestartInterval = 0x0203;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagJPEGLosslessPredictors"]/*' />
    [NativeTypeName("#define PropertyTagJPEGLosslessPredictors 0x0205")]
    public const int PropertyTagJPEGLosslessPredictors = 0x0205;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagJPEGPointTransforms"]/*' />
    [NativeTypeName("#define PropertyTagJPEGPointTransforms 0x0206")]
    public const int PropertyTagJPEGPointTransforms = 0x0206;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagJPEGQTables"]/*' />
    [NativeTypeName("#define PropertyTagJPEGQTables 0x0207")]
    public const int PropertyTagJPEGQTables = 0x0207;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagJPEGDCTables"]/*' />
    [NativeTypeName("#define PropertyTagJPEGDCTables 0x0208")]
    public const int PropertyTagJPEGDCTables = 0x0208;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagJPEGACTables"]/*' />
    [NativeTypeName("#define PropertyTagJPEGACTables 0x0209")]
    public const int PropertyTagJPEGACTables = 0x0209;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagYCbCrCoefficients"]/*' />
    [NativeTypeName("#define PropertyTagYCbCrCoefficients 0x0211")]
    public const int PropertyTagYCbCrCoefficients = 0x0211;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagYCbCrSubsampling"]/*' />
    [NativeTypeName("#define PropertyTagYCbCrSubsampling 0x0212")]
    public const int PropertyTagYCbCrSubsampling = 0x0212;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagYCbCrPositioning"]/*' />
    [NativeTypeName("#define PropertyTagYCbCrPositioning 0x0213")]
    public const int PropertyTagYCbCrPositioning = 0x0213;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagREFBlackWhite"]/*' />
    [NativeTypeName("#define PropertyTagREFBlackWhite 0x0214")]
    public const int PropertyTagREFBlackWhite = 0x0214;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagICCProfile"]/*' />
    [NativeTypeName("#define PropertyTagICCProfile 0x8773")]
    public const int PropertyTagICCProfile = 0x8773;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagGamma"]/*' />
    [NativeTypeName("#define PropertyTagGamma 0x0301")]
    public const int PropertyTagGamma = 0x0301;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagICCProfileDescriptor"]/*' />
    [NativeTypeName("#define PropertyTagICCProfileDescriptor 0x0302")]
    public const int PropertyTagICCProfileDescriptor = 0x0302;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagSRGBRenderingIntent"]/*' />
    [NativeTypeName("#define PropertyTagSRGBRenderingIntent 0x0303")]
    public const int PropertyTagSRGBRenderingIntent = 0x0303;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagImageTitle"]/*' />
    [NativeTypeName("#define PropertyTagImageTitle 0x0320")]
    public const int PropertyTagImageTitle = 0x0320;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagCopyright"]/*' />
    [NativeTypeName("#define PropertyTagCopyright 0x8298")]
    public const int PropertyTagCopyright = 0x8298;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagResolutionXUnit"]/*' />
    [NativeTypeName("#define PropertyTagResolutionXUnit 0x5001")]
    public const int PropertyTagResolutionXUnit = 0x5001;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagResolutionYUnit"]/*' />
    [NativeTypeName("#define PropertyTagResolutionYUnit 0x5002")]
    public const int PropertyTagResolutionYUnit = 0x5002;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagResolutionXLengthUnit"]/*' />
    [NativeTypeName("#define PropertyTagResolutionXLengthUnit 0x5003")]
    public const int PropertyTagResolutionXLengthUnit = 0x5003;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagResolutionYLengthUnit"]/*' />
    [NativeTypeName("#define PropertyTagResolutionYLengthUnit 0x5004")]
    public const int PropertyTagResolutionYLengthUnit = 0x5004;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagPrintFlags"]/*' />
    [NativeTypeName("#define PropertyTagPrintFlags 0x5005")]
    public const int PropertyTagPrintFlags = 0x5005;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagPrintFlagsVersion"]/*' />
    [NativeTypeName("#define PropertyTagPrintFlagsVersion 0x5006")]
    public const int PropertyTagPrintFlagsVersion = 0x5006;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagPrintFlagsCrop"]/*' />
    [NativeTypeName("#define PropertyTagPrintFlagsCrop 0x5007")]
    public const int PropertyTagPrintFlagsCrop = 0x5007;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagPrintFlagsBleedWidth"]/*' />
    [NativeTypeName("#define PropertyTagPrintFlagsBleedWidth 0x5008")]
    public const int PropertyTagPrintFlagsBleedWidth = 0x5008;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagPrintFlagsBleedWidthScale"]/*' />
    [NativeTypeName("#define PropertyTagPrintFlagsBleedWidthScale 0x5009")]
    public const int PropertyTagPrintFlagsBleedWidthScale = 0x5009;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagHalftoneLPI"]/*' />
    [NativeTypeName("#define PropertyTagHalftoneLPI 0x500A")]
    public const int PropertyTagHalftoneLPI = 0x500A;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagHalftoneLPIUnit"]/*' />
    [NativeTypeName("#define PropertyTagHalftoneLPIUnit 0x500B")]
    public const int PropertyTagHalftoneLPIUnit = 0x500B;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagHalftoneDegree"]/*' />
    [NativeTypeName("#define PropertyTagHalftoneDegree 0x500C")]
    public const int PropertyTagHalftoneDegree = 0x500C;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagHalftoneShape"]/*' />
    [NativeTypeName("#define PropertyTagHalftoneShape 0x500D")]
    public const int PropertyTagHalftoneShape = 0x500D;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagHalftoneMisc"]/*' />
    [NativeTypeName("#define PropertyTagHalftoneMisc 0x500E")]
    public const int PropertyTagHalftoneMisc = 0x500E;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagHalftoneScreen"]/*' />
    [NativeTypeName("#define PropertyTagHalftoneScreen 0x500F")]
    public const int PropertyTagHalftoneScreen = 0x500F;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagJPEGQuality"]/*' />
    [NativeTypeName("#define PropertyTagJPEGQuality 0x5010")]
    public const int PropertyTagJPEGQuality = 0x5010;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagGridSize"]/*' />
    [NativeTypeName("#define PropertyTagGridSize 0x5011")]
    public const int PropertyTagGridSize = 0x5011;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagThumbnailFormat"]/*' />
    [NativeTypeName("#define PropertyTagThumbnailFormat 0x5012")]
    public const int PropertyTagThumbnailFormat = 0x5012;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagThumbnailWidth"]/*' />
    [NativeTypeName("#define PropertyTagThumbnailWidth 0x5013")]
    public const int PropertyTagThumbnailWidth = 0x5013;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagThumbnailHeight"]/*' />
    [NativeTypeName("#define PropertyTagThumbnailHeight 0x5014")]
    public const int PropertyTagThumbnailHeight = 0x5014;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagThumbnailColorDepth"]/*' />
    [NativeTypeName("#define PropertyTagThumbnailColorDepth 0x5015")]
    public const int PropertyTagThumbnailColorDepth = 0x5015;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagThumbnailPlanes"]/*' />
    [NativeTypeName("#define PropertyTagThumbnailPlanes 0x5016")]
    public const int PropertyTagThumbnailPlanes = 0x5016;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagThumbnailRawBytes"]/*' />
    [NativeTypeName("#define PropertyTagThumbnailRawBytes 0x5017")]
    public const int PropertyTagThumbnailRawBytes = 0x5017;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagThumbnailSize"]/*' />
    [NativeTypeName("#define PropertyTagThumbnailSize 0x5018")]
    public const int PropertyTagThumbnailSize = 0x5018;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagThumbnailCompressedSize"]/*' />
    [NativeTypeName("#define PropertyTagThumbnailCompressedSize 0x5019")]
    public const int PropertyTagThumbnailCompressedSize = 0x5019;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagColorTransferFunction"]/*' />
    [NativeTypeName("#define PropertyTagColorTransferFunction 0x501A")]
    public const int PropertyTagColorTransferFunction = 0x501A;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagThumbnailData"]/*' />
    [NativeTypeName("#define PropertyTagThumbnailData 0x501B")]
    public const int PropertyTagThumbnailData = 0x501B;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagThumbnailImageWidth"]/*' />
    [NativeTypeName("#define PropertyTagThumbnailImageWidth 0x5020")]
    public const int PropertyTagThumbnailImageWidth = 0x5020;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagThumbnailImageHeight"]/*' />
    [NativeTypeName("#define PropertyTagThumbnailImageHeight 0x5021")]
    public const int PropertyTagThumbnailImageHeight = 0x5021;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagThumbnailBitsPerSample"]/*' />
    [NativeTypeName("#define PropertyTagThumbnailBitsPerSample 0x5022")]
    public const int PropertyTagThumbnailBitsPerSample = 0x5022;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagThumbnailCompression"]/*' />
    [NativeTypeName("#define PropertyTagThumbnailCompression 0x5023")]
    public const int PropertyTagThumbnailCompression = 0x5023;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagThumbnailPhotometricInterp"]/*' />
    [NativeTypeName("#define PropertyTagThumbnailPhotometricInterp 0x5024")]
    public const int PropertyTagThumbnailPhotometricInterp = 0x5024;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagThumbnailImageDescription"]/*' />
    [NativeTypeName("#define PropertyTagThumbnailImageDescription 0x5025")]
    public const int PropertyTagThumbnailImageDescription = 0x5025;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagThumbnailEquipMake"]/*' />
    [NativeTypeName("#define PropertyTagThumbnailEquipMake 0x5026")]
    public const int PropertyTagThumbnailEquipMake = 0x5026;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagThumbnailEquipModel"]/*' />
    [NativeTypeName("#define PropertyTagThumbnailEquipModel 0x5027")]
    public const int PropertyTagThumbnailEquipModel = 0x5027;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagThumbnailStripOffsets"]/*' />
    [NativeTypeName("#define PropertyTagThumbnailStripOffsets 0x5028")]
    public const int PropertyTagThumbnailStripOffsets = 0x5028;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagThumbnailOrientation"]/*' />
    [NativeTypeName("#define PropertyTagThumbnailOrientation 0x5029")]
    public const int PropertyTagThumbnailOrientation = 0x5029;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagThumbnailSamplesPerPixel"]/*' />
    [NativeTypeName("#define PropertyTagThumbnailSamplesPerPixel 0x502A")]
    public const int PropertyTagThumbnailSamplesPerPixel = 0x502A;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagThumbnailRowsPerStrip"]/*' />
    [NativeTypeName("#define PropertyTagThumbnailRowsPerStrip 0x502B")]
    public const int PropertyTagThumbnailRowsPerStrip = 0x502B;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagThumbnailStripBytesCount"]/*' />
    [NativeTypeName("#define PropertyTagThumbnailStripBytesCount 0x502C")]
    public const int PropertyTagThumbnailStripBytesCount = 0x502C;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagThumbnailResolutionX"]/*' />
    [NativeTypeName("#define PropertyTagThumbnailResolutionX 0x502D")]
    public const int PropertyTagThumbnailResolutionX = 0x502D;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagThumbnailResolutionY"]/*' />
    [NativeTypeName("#define PropertyTagThumbnailResolutionY 0x502E")]
    public const int PropertyTagThumbnailResolutionY = 0x502E;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagThumbnailPlanarConfig"]/*' />
    [NativeTypeName("#define PropertyTagThumbnailPlanarConfig 0x502F")]
    public const int PropertyTagThumbnailPlanarConfig = 0x502F;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagThumbnailResolutionUnit"]/*' />
    [NativeTypeName("#define PropertyTagThumbnailResolutionUnit 0x5030")]
    public const int PropertyTagThumbnailResolutionUnit = 0x5030;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagThumbnailTransferFunction"]/*' />
    [NativeTypeName("#define PropertyTagThumbnailTransferFunction 0x5031")]
    public const int PropertyTagThumbnailTransferFunction = 0x5031;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagThumbnailSoftwareUsed"]/*' />
    [NativeTypeName("#define PropertyTagThumbnailSoftwareUsed 0x5032")]
    public const int PropertyTagThumbnailSoftwareUsed = 0x5032;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagThumbnailDateTime"]/*' />
    [NativeTypeName("#define PropertyTagThumbnailDateTime 0x5033")]
    public const int PropertyTagThumbnailDateTime = 0x5033;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagThumbnailArtist"]/*' />
    [NativeTypeName("#define PropertyTagThumbnailArtist 0x5034")]
    public const int PropertyTagThumbnailArtist = 0x5034;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagThumbnailWhitePoint"]/*' />
    [NativeTypeName("#define PropertyTagThumbnailWhitePoint 0x5035")]
    public const int PropertyTagThumbnailWhitePoint = 0x5035;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagThumbnailPrimaryChromaticities"]/*' />
    [NativeTypeName("#define PropertyTagThumbnailPrimaryChromaticities 0x5036")]
    public const int PropertyTagThumbnailPrimaryChromaticities = 0x5036;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagThumbnailYCbCrCoefficients"]/*' />
    [NativeTypeName("#define PropertyTagThumbnailYCbCrCoefficients 0x5037")]
    public const int PropertyTagThumbnailYCbCrCoefficients = 0x5037;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagThumbnailYCbCrSubsampling"]/*' />
    [NativeTypeName("#define PropertyTagThumbnailYCbCrSubsampling 0x5038")]
    public const int PropertyTagThumbnailYCbCrSubsampling = 0x5038;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagThumbnailYCbCrPositioning"]/*' />
    [NativeTypeName("#define PropertyTagThumbnailYCbCrPositioning 0x5039")]
    public const int PropertyTagThumbnailYCbCrPositioning = 0x5039;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagThumbnailRefBlackWhite"]/*' />
    [NativeTypeName("#define PropertyTagThumbnailRefBlackWhite 0x503A")]
    public const int PropertyTagThumbnailRefBlackWhite = 0x503A;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagThumbnailCopyRight"]/*' />
    [NativeTypeName("#define PropertyTagThumbnailCopyRight 0x503B")]
    public const int PropertyTagThumbnailCopyRight = 0x503B;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagLuminanceTable"]/*' />
    [NativeTypeName("#define PropertyTagLuminanceTable 0x5090")]
    public const int PropertyTagLuminanceTable = 0x5090;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagChrominanceTable"]/*' />
    [NativeTypeName("#define PropertyTagChrominanceTable 0x5091")]
    public const int PropertyTagChrominanceTable = 0x5091;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagFrameDelay"]/*' />
    [NativeTypeName("#define PropertyTagFrameDelay 0x5100")]
    public const int PropertyTagFrameDelay = 0x5100;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagLoopCount"]/*' />
    [NativeTypeName("#define PropertyTagLoopCount 0x5101")]
    public const int PropertyTagLoopCount = 0x5101;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagGlobalPalette"]/*' />
    [NativeTypeName("#define PropertyTagGlobalPalette 0x5102")]
    public const int PropertyTagGlobalPalette = 0x5102;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagIndexBackground"]/*' />
    [NativeTypeName("#define PropertyTagIndexBackground 0x5103")]
    public const int PropertyTagIndexBackground = 0x5103;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagIndexTransparent"]/*' />
    [NativeTypeName("#define PropertyTagIndexTransparent 0x5104")]
    public const int PropertyTagIndexTransparent = 0x5104;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagPixelUnit"]/*' />
    [NativeTypeName("#define PropertyTagPixelUnit 0x5110")]
    public const int PropertyTagPixelUnit = 0x5110;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagPixelPerUnitX"]/*' />
    [NativeTypeName("#define PropertyTagPixelPerUnitX 0x5111")]
    public const int PropertyTagPixelPerUnitX = 0x5111;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagPixelPerUnitY"]/*' />
    [NativeTypeName("#define PropertyTagPixelPerUnitY 0x5112")]
    public const int PropertyTagPixelPerUnitY = 0x5112;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagPaletteHistogram"]/*' />
    [NativeTypeName("#define PropertyTagPaletteHistogram 0x5113")]
    public const int PropertyTagPaletteHistogram = 0x5113;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagExifExposureTime"]/*' />
    [NativeTypeName("#define PropertyTagExifExposureTime 0x829A")]
    public const int PropertyTagExifExposureTime = 0x829A;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagExifFNumber"]/*' />
    [NativeTypeName("#define PropertyTagExifFNumber 0x829D")]
    public const int PropertyTagExifFNumber = 0x829D;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagExifExposureProg"]/*' />
    [NativeTypeName("#define PropertyTagExifExposureProg 0x8822")]
    public const int PropertyTagExifExposureProg = 0x8822;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagExifSpectralSense"]/*' />
    [NativeTypeName("#define PropertyTagExifSpectralSense 0x8824")]
    public const int PropertyTagExifSpectralSense = 0x8824;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagExifISOSpeed"]/*' />
    [NativeTypeName("#define PropertyTagExifISOSpeed 0x8827")]
    public const int PropertyTagExifISOSpeed = 0x8827;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagExifOECF"]/*' />
    [NativeTypeName("#define PropertyTagExifOECF 0x8828")]
    public const int PropertyTagExifOECF = 0x8828;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagExifVer"]/*' />
    [NativeTypeName("#define PropertyTagExifVer 0x9000")]
    public const int PropertyTagExifVer = 0x9000;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagExifDTOrig"]/*' />
    [NativeTypeName("#define PropertyTagExifDTOrig 0x9003")]
    public const int PropertyTagExifDTOrig = 0x9003;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagExifDTDigitized"]/*' />
    [NativeTypeName("#define PropertyTagExifDTDigitized 0x9004")]
    public const int PropertyTagExifDTDigitized = 0x9004;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagExifCompConfig"]/*' />
    [NativeTypeName("#define PropertyTagExifCompConfig 0x9101")]
    public const int PropertyTagExifCompConfig = 0x9101;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagExifCompBPP"]/*' />
    [NativeTypeName("#define PropertyTagExifCompBPP 0x9102")]
    public const int PropertyTagExifCompBPP = 0x9102;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagExifShutterSpeed"]/*' />
    [NativeTypeName("#define PropertyTagExifShutterSpeed 0x9201")]
    public const int PropertyTagExifShutterSpeed = 0x9201;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagExifAperture"]/*' />
    [NativeTypeName("#define PropertyTagExifAperture 0x9202")]
    public const int PropertyTagExifAperture = 0x9202;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagExifBrightness"]/*' />
    [NativeTypeName("#define PropertyTagExifBrightness 0x9203")]
    public const int PropertyTagExifBrightness = 0x9203;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagExifExposureBias"]/*' />
    [NativeTypeName("#define PropertyTagExifExposureBias 0x9204")]
    public const int PropertyTagExifExposureBias = 0x9204;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagExifMaxAperture"]/*' />
    [NativeTypeName("#define PropertyTagExifMaxAperture 0x9205")]
    public const int PropertyTagExifMaxAperture = 0x9205;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagExifSubjectDist"]/*' />
    [NativeTypeName("#define PropertyTagExifSubjectDist 0x9206")]
    public const int PropertyTagExifSubjectDist = 0x9206;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagExifMeteringMode"]/*' />
    [NativeTypeName("#define PropertyTagExifMeteringMode 0x9207")]
    public const int PropertyTagExifMeteringMode = 0x9207;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagExifLightSource"]/*' />
    [NativeTypeName("#define PropertyTagExifLightSource 0x9208")]
    public const int PropertyTagExifLightSource = 0x9208;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagExifFlash"]/*' />
    [NativeTypeName("#define PropertyTagExifFlash 0x9209")]
    public const int PropertyTagExifFlash = 0x9209;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagExifFocalLength"]/*' />
    [NativeTypeName("#define PropertyTagExifFocalLength 0x920A")]
    public const int PropertyTagExifFocalLength = 0x920A;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagExifSubjectArea"]/*' />
    [NativeTypeName("#define PropertyTagExifSubjectArea 0x9214")]
    public const int PropertyTagExifSubjectArea = 0x9214;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagExifMakerNote"]/*' />
    [NativeTypeName("#define PropertyTagExifMakerNote 0x927C")]
    public const int PropertyTagExifMakerNote = 0x927C;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagExifUserComment"]/*' />
    [NativeTypeName("#define PropertyTagExifUserComment 0x9286")]
    public const int PropertyTagExifUserComment = 0x9286;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagExifDTSubsec"]/*' />
    [NativeTypeName("#define PropertyTagExifDTSubsec 0x9290")]
    public const int PropertyTagExifDTSubsec = 0x9290;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagExifDTOrigSS"]/*' />
    [NativeTypeName("#define PropertyTagExifDTOrigSS 0x9291")]
    public const int PropertyTagExifDTOrigSS = 0x9291;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagExifDTDigSS"]/*' />
    [NativeTypeName("#define PropertyTagExifDTDigSS 0x9292")]
    public const int PropertyTagExifDTDigSS = 0x9292;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagExifFPXVer"]/*' />
    [NativeTypeName("#define PropertyTagExifFPXVer 0xA000")]
    public const int PropertyTagExifFPXVer = 0xA000;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagExifColorSpace"]/*' />
    [NativeTypeName("#define PropertyTagExifColorSpace 0xA001")]
    public const int PropertyTagExifColorSpace = 0xA001;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagExifPixXDim"]/*' />
    [NativeTypeName("#define PropertyTagExifPixXDim 0xA002")]
    public const int PropertyTagExifPixXDim = 0xA002;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagExifPixYDim"]/*' />
    [NativeTypeName("#define PropertyTagExifPixYDim 0xA003")]
    public const int PropertyTagExifPixYDim = 0xA003;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagExifRelatedWav"]/*' />
    [NativeTypeName("#define PropertyTagExifRelatedWav 0xA004")]
    public const int PropertyTagExifRelatedWav = 0xA004;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagExifInterop"]/*' />
    [NativeTypeName("#define PropertyTagExifInterop 0xA005")]
    public const int PropertyTagExifInterop = 0xA005;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagExifFlashEnergy"]/*' />
    [NativeTypeName("#define PropertyTagExifFlashEnergy 0xA20B")]
    public const int PropertyTagExifFlashEnergy = 0xA20B;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagExifSpatialFR"]/*' />
    [NativeTypeName("#define PropertyTagExifSpatialFR 0xA20C")]
    public const int PropertyTagExifSpatialFR = 0xA20C;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagExifFocalXRes"]/*' />
    [NativeTypeName("#define PropertyTagExifFocalXRes 0xA20E")]
    public const int PropertyTagExifFocalXRes = 0xA20E;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagExifFocalYRes"]/*' />
    [NativeTypeName("#define PropertyTagExifFocalYRes 0xA20F")]
    public const int PropertyTagExifFocalYRes = 0xA20F;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagExifFocalResUnit"]/*' />
    [NativeTypeName("#define PropertyTagExifFocalResUnit 0xA210")]
    public const int PropertyTagExifFocalResUnit = 0xA210;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagExifSubjectLoc"]/*' />
    [NativeTypeName("#define PropertyTagExifSubjectLoc 0xA214")]
    public const int PropertyTagExifSubjectLoc = 0xA214;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagExifExposureIndex"]/*' />
    [NativeTypeName("#define PropertyTagExifExposureIndex 0xA215")]
    public const int PropertyTagExifExposureIndex = 0xA215;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagExifSensingMethod"]/*' />
    [NativeTypeName("#define PropertyTagExifSensingMethod 0xA217")]
    public const int PropertyTagExifSensingMethod = 0xA217;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagExifFileSource"]/*' />
    [NativeTypeName("#define PropertyTagExifFileSource 0xA300")]
    public const int PropertyTagExifFileSource = 0xA300;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagExifSceneType"]/*' />
    [NativeTypeName("#define PropertyTagExifSceneType 0xA301")]
    public const int PropertyTagExifSceneType = 0xA301;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagExifCfaPattern"]/*' />
    [NativeTypeName("#define PropertyTagExifCfaPattern 0xA302")]
    public const int PropertyTagExifCfaPattern = 0xA302;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagExifCustomRendered"]/*' />
    [NativeTypeName("#define PropertyTagExifCustomRendered 0xA401")]
    public const int PropertyTagExifCustomRendered = 0xA401;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagExifExposureMode"]/*' />
    [NativeTypeName("#define PropertyTagExifExposureMode 0xA402")]
    public const int PropertyTagExifExposureMode = 0xA402;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagExifWhiteBalance"]/*' />
    [NativeTypeName("#define PropertyTagExifWhiteBalance 0xA403")]
    public const int PropertyTagExifWhiteBalance = 0xA403;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagExifDigitalZoomRatio"]/*' />
    [NativeTypeName("#define PropertyTagExifDigitalZoomRatio 0xA404")]
    public const int PropertyTagExifDigitalZoomRatio = 0xA404;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagExifFocalLengthIn35mmFilm"]/*' />
    [NativeTypeName("#define PropertyTagExifFocalLengthIn35mmFilm 0xA405")]
    public const int PropertyTagExifFocalLengthIn35mmFilm = 0xA405;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagExifSceneCaptureType"]/*' />
    [NativeTypeName("#define PropertyTagExifSceneCaptureType 0xA406")]
    public const int PropertyTagExifSceneCaptureType = 0xA406;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagExifGainControl"]/*' />
    [NativeTypeName("#define PropertyTagExifGainControl 0xA407")]
    public const int PropertyTagExifGainControl = 0xA407;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagExifContrast"]/*' />
    [NativeTypeName("#define PropertyTagExifContrast 0xA408")]
    public const int PropertyTagExifContrast = 0xA408;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagExifSaturation"]/*' />
    [NativeTypeName("#define PropertyTagExifSaturation 0xA409")]
    public const int PropertyTagExifSaturation = 0xA409;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagExifSharpness"]/*' />
    [NativeTypeName("#define PropertyTagExifSharpness 0xA40A")]
    public const int PropertyTagExifSharpness = 0xA40A;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagExifDeviceSettingDesc"]/*' />
    [NativeTypeName("#define PropertyTagExifDeviceSettingDesc 0xA40B")]
    public const int PropertyTagExifDeviceSettingDesc = 0xA40B;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagExifSubjectDistanceRange"]/*' />
    [NativeTypeName("#define PropertyTagExifSubjectDistanceRange 0xA40C")]
    public const int PropertyTagExifSubjectDistanceRange = 0xA40C;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagExifUniqueImageID"]/*' />
    [NativeTypeName("#define PropertyTagExifUniqueImageID 0xA420")]
    public const int PropertyTagExifUniqueImageID = 0xA420;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagGpsVer"]/*' />
    [NativeTypeName("#define PropertyTagGpsVer 0x0000")]
    public const int PropertyTagGpsVer = 0x0000;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagGpsLatitudeRef"]/*' />
    [NativeTypeName("#define PropertyTagGpsLatitudeRef 0x0001")]
    public const int PropertyTagGpsLatitudeRef = 0x0001;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagGpsLatitude"]/*' />
    [NativeTypeName("#define PropertyTagGpsLatitude 0x0002")]
    public const int PropertyTagGpsLatitude = 0x0002;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagGpsLongitudeRef"]/*' />
    [NativeTypeName("#define PropertyTagGpsLongitudeRef 0x0003")]
    public const int PropertyTagGpsLongitudeRef = 0x0003;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagGpsLongitude"]/*' />
    [NativeTypeName("#define PropertyTagGpsLongitude 0x0004")]
    public const int PropertyTagGpsLongitude = 0x0004;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagGpsAltitudeRef"]/*' />
    [NativeTypeName("#define PropertyTagGpsAltitudeRef 0x0005")]
    public const int PropertyTagGpsAltitudeRef = 0x0005;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagGpsAltitude"]/*' />
    [NativeTypeName("#define PropertyTagGpsAltitude 0x0006")]
    public const int PropertyTagGpsAltitude = 0x0006;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagGpsGpsTime"]/*' />
    [NativeTypeName("#define PropertyTagGpsGpsTime 0x0007")]
    public const int PropertyTagGpsGpsTime = 0x0007;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagGpsGpsSatellites"]/*' />
    [NativeTypeName("#define PropertyTagGpsGpsSatellites 0x0008")]
    public const int PropertyTagGpsGpsSatellites = 0x0008;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagGpsGpsStatus"]/*' />
    [NativeTypeName("#define PropertyTagGpsGpsStatus 0x0009")]
    public const int PropertyTagGpsGpsStatus = 0x0009;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagGpsGpsMeasureMode"]/*' />
    [NativeTypeName("#define PropertyTagGpsGpsMeasureMode 0x00A")]
    public const int PropertyTagGpsGpsMeasureMode = 0x00A;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagGpsGpsDop"]/*' />
    [NativeTypeName("#define PropertyTagGpsGpsDop 0x000B")]
    public const int PropertyTagGpsGpsDop = 0x000B;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagGpsSpeedRef"]/*' />
    [NativeTypeName("#define PropertyTagGpsSpeedRef 0x000C")]
    public const int PropertyTagGpsSpeedRef = 0x000C;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagGpsSpeed"]/*' />
    [NativeTypeName("#define PropertyTagGpsSpeed 0x000D")]
    public const int PropertyTagGpsSpeed = 0x000D;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagGpsTrackRef"]/*' />
    [NativeTypeName("#define PropertyTagGpsTrackRef 0x000E")]
    public const int PropertyTagGpsTrackRef = 0x000E;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagGpsTrack"]/*' />
    [NativeTypeName("#define PropertyTagGpsTrack 0x000F")]
    public const int PropertyTagGpsTrack = 0x000F;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagGpsImgDirRef"]/*' />
    [NativeTypeName("#define PropertyTagGpsImgDirRef 0x0010")]
    public const int PropertyTagGpsImgDirRef = 0x0010;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagGpsImgDir"]/*' />
    [NativeTypeName("#define PropertyTagGpsImgDir 0x0011")]
    public const int PropertyTagGpsImgDir = 0x0011;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagGpsMapDatum"]/*' />
    [NativeTypeName("#define PropertyTagGpsMapDatum 0x0012")]
    public const int PropertyTagGpsMapDatum = 0x0012;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagGpsDestLatRef"]/*' />
    [NativeTypeName("#define PropertyTagGpsDestLatRef 0x0013")]
    public const int PropertyTagGpsDestLatRef = 0x0013;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagGpsDestLat"]/*' />
    [NativeTypeName("#define PropertyTagGpsDestLat 0x0014")]
    public const int PropertyTagGpsDestLat = 0x0014;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagGpsDestLongRef"]/*' />
    [NativeTypeName("#define PropertyTagGpsDestLongRef 0x0015")]
    public const int PropertyTagGpsDestLongRef = 0x0015;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagGpsDestLong"]/*' />
    [NativeTypeName("#define PropertyTagGpsDestLong 0x0016")]
    public const int PropertyTagGpsDestLong = 0x0016;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagGpsDestBearRef"]/*' />
    [NativeTypeName("#define PropertyTagGpsDestBearRef 0x0017")]
    public const int PropertyTagGpsDestBearRef = 0x0017;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagGpsDestBear"]/*' />
    [NativeTypeName("#define PropertyTagGpsDestBear 0x0018")]
    public const int PropertyTagGpsDestBear = 0x0018;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagGpsDestDistRef"]/*' />
    [NativeTypeName("#define PropertyTagGpsDestDistRef 0x0019")]
    public const int PropertyTagGpsDestDistRef = 0x0019;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagGpsDestDist"]/*' />
    [NativeTypeName("#define PropertyTagGpsDestDist 0x001A")]
    public const int PropertyTagGpsDestDist = 0x001A;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagGpsProcessingMethod"]/*' />
    [NativeTypeName("#define PropertyTagGpsProcessingMethod 0x001B")]
    public const int PropertyTagGpsProcessingMethod = 0x001B;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagGpsAreaInformation"]/*' />
    [NativeTypeName("#define PropertyTagGpsAreaInformation 0x001C")]
    public const int PropertyTagGpsAreaInformation = 0x001C;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagGpsDate"]/*' />
    [NativeTypeName("#define PropertyTagGpsDate 0x001D")]
    public const int PropertyTagGpsDate = 0x001D;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PropertyTagGpsDifferential"]/*' />
    [NativeTypeName("#define PropertyTagGpsDifferential 0x001E")]
    public const int PropertyTagGpsDifferential = 0x001E;
}
