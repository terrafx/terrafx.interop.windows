// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WiaDef.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

public static partial class WiaImgFmt
{
    /// <include file='WiaImgFmt.xml' path='doc/member[@name="WiaImgFmt.WiaImgFmt_UNDEFINED"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid WiaImgFmt_UNDEFINED
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

    /// <include file='WiaImgFmt.xml' path='doc/member[@name="WiaImgFmt.WiaImgFmt_RAWRGB"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid WiaImgFmt_RAWRGB
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x55, 0x8B, 0xA4, 0xBC,
                0x72, 0xF2,
                0x71, 0x43,
                0xB0,
                0xF1,
                0x4A,
                0x15,
                0x0D,
                0x05,
                0x7B,
                0xB4
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='WiaImgFmt.xml' path='doc/member[@name="WiaImgFmt.WiaImgFmt_MEMORYBMP"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid WiaImgFmt_MEMORYBMP
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

    /// <include file='WiaImgFmt.xml' path='doc/member[@name="WiaImgFmt.WiaImgFmt_BMP"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid WiaImgFmt_BMP
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

    /// <include file='WiaImgFmt.xml' path='doc/member[@name="WiaImgFmt.WiaImgFmt_EMF"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid WiaImgFmt_EMF
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

    /// <include file='WiaImgFmt.xml' path='doc/member[@name="WiaImgFmt.WiaImgFmt_WMF"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid WiaImgFmt_WMF
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

    /// <include file='WiaImgFmt.xml' path='doc/member[@name="WiaImgFmt.WiaImgFmt_JPEG"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid WiaImgFmt_JPEG
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

    /// <include file='WiaImgFmt.xml' path='doc/member[@name="WiaImgFmt.WiaImgFmt_PNG"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid WiaImgFmt_PNG
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

    /// <include file='WiaImgFmt.xml' path='doc/member[@name="WiaImgFmt.WiaImgFmt_GIF"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid WiaImgFmt_GIF
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

    /// <include file='WiaImgFmt.xml' path='doc/member[@name="WiaImgFmt.WiaImgFmt_TIFF"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid WiaImgFmt_TIFF
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

    /// <include file='WiaImgFmt.xml' path='doc/member[@name="WiaImgFmt.WiaImgFmt_EXIF"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid WiaImgFmt_EXIF
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

    /// <include file='WiaImgFmt.xml' path='doc/member[@name="WiaImgFmt.WiaImgFmt_PHOTOCD"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid WiaImgFmt_PHOTOCD
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xB3, 0x3C, 0x6B, 0xB9,
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

    /// <include file='WiaImgFmt.xml' path='doc/member[@name="WiaImgFmt.WiaImgFmt_FLASHPIX"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid WiaImgFmt_FLASHPIX
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xB4, 0x3C, 0x6B, 0xB9,
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

    /// <include file='WiaImgFmt.xml' path='doc/member[@name="WiaImgFmt.WiaImgFmt_ICO"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid WiaImgFmt_ICO
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

    /// <include file='WiaImgFmt.xml' path='doc/member[@name="WiaImgFmt.WiaImgFmt_CIFF"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid WiaImgFmt_CIFF
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xAB, 0xA8, 0x21, 0x98,
                0x7E, 0x3A,
                0x15, 0x42,
                0x94,
                0xE0,
                0xD2,
                0x7A,
                0x46,
                0x0C,
                0x03,
                0xB2
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='WiaImgFmt.xml' path='doc/member[@name="WiaImgFmt.WiaImgFmt_PICT"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid WiaImgFmt_PICT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xD8, 0x85, 0xBC, 0xA6,
                0x3E, 0x6B,
                0xEE, 0x40,
                0xA9,
                0x5C,
                0x25,
                0xD4,
                0x82,
                0xE4,
                0x1A,
                0xDC
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='WiaImgFmt.xml' path='doc/member[@name="WiaImgFmt.WiaImgFmt_JPEG2K"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid WiaImgFmt_JPEG2K
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xB2, 0xE2, 0x4E, 0x34,
                0xDB, 0x39,
                0xDE, 0x4D,
                0x81,
                0x73,
                0xC4,
                0xB7,
                0x5F,
                0x8F,
                0x1E,
                0x49
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='WiaImgFmt.xml' path='doc/member[@name="WiaImgFmt.WiaImgFmt_JPEG2KX"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid WiaImgFmt_JPEG2KX
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x14, 0x46, 0xE1, 0x43,
                0x0A, 0xC8,
                0x50, 0x48,
                0xBA,
                0xF3,
                0x4B,
                0x15,
                0x2D,
                0xC8,
                0xDA,
                0x27
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='WiaImgFmt.xml' path='doc/member[@name="WiaImgFmt.WiaImgFmt_RAW"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid WiaImgFmt_RAW
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x19, 0x07, 0x12, 0x6F,
                0xA8, 0xF1,
                0x07, 0x4E,
                0x9A,
                0xDE,
                0x9B,
                0x64,
                0xC6,
                0x3A,
                0x3D,
                0xCC
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='WiaImgFmt.xml' path='doc/member[@name="WiaImgFmt.WiaImgFmt_JBIG"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid WiaImgFmt_JBIG
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x92, 0xDD, 0xE8, 0x41,
                0x0A, 0x2F,
                0xD4, 0x43,
                0x86,
                0x36,
                0xF1,
                0x61,
                0x4B,
                0xA1,
                0x1E,
                0x46
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='WiaImgFmt.xml' path='doc/member[@name="WiaImgFmt.WiaImgFmt_JBIG2"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid WiaImgFmt_JBIG2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x67, 0x7E, 0x8E, 0xBB,
                0x3C, 0x28,
                0x35, 0x42,
                0x9E,
                0x59,
                0x0B,
                0x9B,
                0xF9,
                0x4C,
                0xA6,
                0x87
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='WiaImgFmt.xml' path='doc/member[@name="WiaImgFmt.WiaImgFmt_RTF"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid WiaImgFmt_RTF
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xA3, 0xD6, 0x3D, 0x57,
                0x34, 0x48,
                0x2D, 0x43,
                0xA9,
                0xB5,
                0xE1,
                0x98,
                0xDD,
                0x9E,
                0x89,
                0x0D
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='WiaImgFmt.xml' path='doc/member[@name="WiaImgFmt.WiaImgFmt_XML"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid WiaImgFmt_XML
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x57, 0x14, 0x17, 0xB9,
                0xC8, 0xDA,
                0x84, 0x48,
                0xB3,
                0x93,
                0x15,
                0xB4,
                0x71,
                0xD5,
                0xF0,
                0x7E
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='WiaImgFmt.xml' path='doc/member[@name="WiaImgFmt.WiaImgFmt_HTML"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid WiaImgFmt_HTML
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x62, 0x4E, 0x9A, 0xC9,
                0xDE, 0x99,
                0x94, 0x4A,
                0xAC,
                0xCA,
                0x71,
                0x95,
                0x6A,
                0xC2,
                0x97,
                0x7D
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='WiaImgFmt.xml' path='doc/member[@name="WiaImgFmt.WiaImgFmt_TXT"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid WiaImgFmt_TXT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x82, 0x4D, 0xFD, 0xFA,
                0x3F, 0x72,
                0x1F, 0x42,
                0x93,
                0x18,
                0x30,
                0x50,
                0x1A,
                0xC4,
                0x4B,
                0x59
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='WiaImgFmt.xml' path='doc/member[@name="WiaImgFmt.WiaImgFmt_PDFA"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid WiaImgFmt_PDFA
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x5B, 0xBD, 0x80, 0x99,
                0x63, 0x34,
                0xC7, 0x43,
                0xBD,
                0xCA,
                0x3C,
                0xAA,
                0x14,
                0x6F,
                0x22,
                0x9F
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='WiaImgFmt.xml' path='doc/member[@name="WiaImgFmt.WiaImgFmt_XPS"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid WiaImgFmt_XPS
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x0F, 0x4A, 0x0B, 0x70,
                0x11, 0x20,
                0x1C, 0x41,
                0xB4,
                0x30,
                0xD1,
                0xE0,
                0xB2,
                0xE1,
                0x0B,
                0x28
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='WiaImgFmt.xml' path='doc/member[@name="WiaImgFmt.WiaImgFmt_OXPS"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid WiaImgFmt_OXPS
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x40, 0x12, 0x7B, 0x2C,
                0x4D, 0xC1,
                0x09, 0x41,
                0x97,
                0x55,
                0x04,
                0xB8,
                0x90,
                0x25,
                0x15,
                0x3A
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='WiaImgFmt.xml' path='doc/member[@name="WiaImgFmt.WiaImgFmt_CSV"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid WiaImgFmt_CSV
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x24, 0xDA, 0x5B, 0x35,
                0x9F, 0x5A,
                0x94, 0x44,
                0x80,
                0xDC,
                0xBE,
                0x75,
                0x2C,
                0xEC,
                0xBC,
                0x8C
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='WiaImgFmt.xml' path='doc/member[@name="WiaImgFmt.WiaImgFmt_MPG"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid WiaImgFmt_MPG
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xE4, 0x57, 0xD7, 0xEC,
                0xEC, 0xD2,
                0x57, 0x4F,
                0x95,
                0x5D,
                0xBC,
                0xF8,
                0xA9,
                0x7C,
                0x4E,
                0x52
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='WiaImgFmt.xml' path='doc/member[@name="WiaImgFmt.WiaImgFmt_AVI"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid WiaImgFmt_AVI
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x14, 0xCA, 0xF8, 0x32,
                0x7C, 0x08,
                0x08, 0x49,
                0xB7,
                0xC4,
                0x67,
                0x57,
                0xFE,
                0x7E,
                0x90,
                0xAB
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='WiaImgFmt.xml' path='doc/member[@name="WiaImgFmt.WiaImgFmt_ASF"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid WiaImgFmt_ASF
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xE9, 0x8E, 0x94, 0x8D,
                0xAA, 0xD0,
                0x12, 0x4A,
                0x9D,
                0x9A,
                0x9C,
                0xC5,
                0xDE,
                0x36,
                0x19,
                0x9B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='WiaImgFmt.xml' path='doc/member[@name="WiaImgFmt.WiaImgFmt_SCRIPT"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid WiaImgFmt_SCRIPT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x53, 0x6C, 0x7D, 0xFE,
                0xAC, 0x2D,
                0x6A, 0x44,
                0xB0,
                0xBD,
                0xD7,
                0x3E,
                0x21,
                0xE9,
                0x24,
                0xC9
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='WiaImgFmt.xml' path='doc/member[@name="WiaImgFmt.WiaImgFmt_EXEC"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid WiaImgFmt_EXEC
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x97, 0xA0, 0x5D, 0x48,
                0x1E, 0x14,
                0xA5, 0x4A,
                0xBB,
                0x3B,
                0xA5,
                0x61,
                0x8D,
                0x95,
                0xD0,
                0x2B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='WiaImgFmt.xml' path='doc/member[@name="WiaImgFmt.WiaImgFmt_UNICODE16"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid WiaImgFmt_UNICODE16
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xB6, 0x39, 0x76, 0x1B,
                0x57, 0x63,
                0xD1, 0x47,
                0x9A,
                0x07,
                0x12,
                0x45,
                0x2D,
                0xC0,
                0x73,
                0xE9
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='WiaImgFmt.xml' path='doc/member[@name="WiaImgFmt.WiaImgFmt_DPOF"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid WiaImgFmt_DPOF
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xAB, 0xEE, 0x9E, 0x36,
                0xE8, 0xA0,
                0xCA, 0x45,
                0x86,
                0xA6,
                0xA8,
                0x3C,
                0xE5,
                0x69,
                0x7E,
                0x28
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='WiaImgFmt.xml' path='doc/member[@name="WiaImgFmt.WiaImgFmt_XMLBAR"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid WiaImgFmt_XMLBAR
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x1C, 0x70, 0x35, 0x62,
                0x98, 0x3A,
                0x4C, 0x48,
                0xB2,
                0xA8,
                0xFD,
                0xFF,
                0xD8,
                0x7E,
                0x6B,
                0x16
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='WiaImgFmt.xml' path='doc/member[@name="WiaImgFmt.WiaImgFmt_RAWBAR"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid WiaImgFmt_RAWBAR
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x33, 0xF8, 0x63, 0xDA,
                0x6E, 0xD2,
                0x1E, 0x45,
                0x90,
                0xD2,
                0xEA,
                0x55,
                0xA1,
                0x36,
                0x5D,
                0x62
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='WiaImgFmt.xml' path='doc/member[@name="WiaImgFmt.WiaImgFmt_XMLPAT"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid WiaImgFmt_XMLPAT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x55, 0x6F, 0x98, 0xF8,
                0x52, 0xF0,
                0x0D, 0x46,
                0x95,
                0x23,
                0x3A,
                0x7D,
                0xFE,
                0xDB,
                0xB3,
                0x3C
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='WiaImgFmt.xml' path='doc/member[@name="WiaImgFmt.WiaImgFmt_RAWPAT"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid WiaImgFmt_RAWPAT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x7C, 0x50, 0x60, 0x77,
                0x64, 0x50,
                0x0C, 0x40,
                0x9A,
                0x17,
                0x57,
                0x56,
                0x24,
                0xD8,
                0x82,
                0x4B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='WiaImgFmt.xml' path='doc/member[@name="WiaImgFmt.WiaImgFmt_XMLMIC"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid WiaImgFmt_XMLMIC
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x61, 0x4C, 0x16, 0x2D,
                0xAE, 0xB9,
                0x23, 0x4B,
                0x89,
                0x73,
                0xC7,
                0x06,
                0x7E,
                0x1F,
                0xBD,
                0x31
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='WiaImgFmt.xml' path='doc/member[@name="WiaImgFmt.WiaImgFmt_RAWMIC"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid WiaImgFmt_RAWMIC
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x58, 0xF0, 0xC4, 0x22,
                0x88, 0x0D,
                0x9C, 0x40,
                0xAC,
                0x1C,
                0xEE,
                0xC1,
                0x2B,
                0x0E,
                0xA6,
                0x80
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
