// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WiaDef.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

public static partial class WIA
{
    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_CATEGORY_FINISHED_FILE"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid WIA_CATEGORY_FINISHED_FILE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xCA, 0x77, 0x2B, 0xFF,
                0x84, 0xCF,
                0x2B, 0x43,
                0xA7,
                0x35,
                0x3A,
                0x13,
                0x0D,
                0xDE,
                0x2A,
                0x88
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_CATEGORY_FLATBED"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid WIA_CATEGORY_FLATBED
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x1F, 0x7B, 0x60, 0xFB,
                0xF3, 0x43,
                0x8B, 0x48,
                0x85,
                0x5B,
                0xFB,
                0x70,
                0x3E,
                0xC3,
                0x42,
                0xA6
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_CATEGORY_FEEDER"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid WIA_CATEGORY_FEEDER
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x34, 0x19, 0x13, 0xFE,
                0x4C, 0xF8,
                0xAD, 0x42,
                0x8D,
                0xA4,
                0x61,
                0x29,
                0xCD,
                0xDD,
                0x72,
                0x88
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_CATEGORY_FILM"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid WIA_CATEGORY_FILM
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xE7, 0x5B, 0xF6, 0xFC,
                0xE3, 0x3C,
                0x73, 0x44,
                0xAF,
                0x85,
                0xF5,
                0xD3,
                0x7D,
                0x21,
                0xB6,
                0x8A
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_CATEGORY_ROOT"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid WIA_CATEGORY_ROOT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x6F, 0x52, 0x93, 0xF1,
                0xB8, 0x59,
                0x26, 0x4A,
                0x98,
                0x88,
                0xE1,
                0x6E,
                0x4F,
                0x97,
                0xCE,
                0x10
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_CATEGORY_FOLDER"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid WIA_CATEGORY_FOLDER
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x46, 0xA4, 0x92, 0xC6,
                0x5A, 0x6F,
                0x1D, 0x48,
                0x85,
                0xBB,
                0x92,
                0xE2,
                0xE8,
                0x6F,
                0xD3,
                0x0A
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_CATEGORY_FEEDER_FRONT"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid WIA_CATEGORY_FEEDER_FRONT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x5C, 0x17, 0x23, 0x48,
                0x28, 0x3B,
                0x7B, 0x48,
                0xA7,
                0xE6,
                0xEE,
                0xBC,
                0x17,
                0x61,
                0x4F,
                0xD1
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_CATEGORY_FEEDER_BACK"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid WIA_CATEGORY_FEEDER_BACK
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xD4, 0x74, 0xCA, 0x61,
                0xDB, 0x39,
                0xAA, 0x42,
                0x89,
                0xB1,
                0x8C,
                0x19,
                0xC9,
                0xCD,
                0x4C,
                0x23
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_CATEGORY_AUTO"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid WIA_CATEGORY_AUTO
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xD8, 0x5F, 0xFE, 0xDE,
                0x97, 0x6C,
                0xDE, 0x4D,
                0xB1,
                0x1E,
                0xCB,
                0x50,
                0x9B,
                0x27,
                0x0E,
                0x11
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_CATEGORY_IMPRINTER"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid WIA_CATEGORY_IMPRINTER
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x6D, 0x01, 0x65, 0xFC,
                0x02, 0x92,
                0xDD, 0x43,
                0x91,
                0xA7,
                0x64,
                0xC2,
                0x95,
                0x4C,
                0xFB,
                0x8B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_CATEGORY_ENDORSER"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid WIA_CATEGORY_ENDORSER
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xC3, 0x2C, 0x10, 0x47,
                0x7F, 0x12,
                0x71, 0x47,
                0xAD,
                0xFC,
                0x99,
                0x1A,
                0xB8,
                0xEE,
                0x1E,
                0x97
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_CATEGORY_BARCODE_READER"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid WIA_CATEGORY_BARCODE_READER
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xA0, 0x78, 0xE1, 0x36,
                0x3F, 0x47,
                0x4B, 0x49,
                0xAF,
                0x8F,
                0x6C,
                0x3F,
                0x6D,
                0x74,
                0x86,
                0xFC
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_CATEGORY_PATCH_CODE_READER"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid WIA_CATEGORY_PATCH_CODE_READER
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x6D, 0x1A, 0xAA, 0x8F,
                0x8A, 0x9C,
                0xCD, 0x42,
                0x98,
                0xB3,
                0xEE,
                0x97,
                0x00,
                0xCB,
                0xC7,
                0x4F
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_CATEGORY_MICR_READER"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid WIA_CATEGORY_MICR_READER
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xEC, 0xC1, 0x86, 0x3B,
                0xBC, 0x71,
                0x45, 0x46,
                0xB4,
                0xD5,
                0x1B,
                0x19,
                0xDA,
                0x2B,
                0xE9,
                0x78
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_EVENT_DEVICE_DISCONNECTED"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid WIA_EVENT_DEVICE_DISCONNECTED
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x83, 0x4E, 0x3E, 0x14,
                0x97, 0x64,
                0xD2, 0x11,
                0xA2,
                0x31,
                0x00,
                0xC0,
                0x4F,
                0xA3,
                0x18,
                0x09
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_EVENT_DEVICE_CONNECTED"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid WIA_EVENT_DEVICE_CONNECTED
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xDE, 0xBA, 0x8B, 0xA2,
                0xB6, 0x64,
                0xD2, 0x11,
                0xA2,
                0x31,
                0x00,
                0xC0,
                0x4F,
                0xA3,
                0x18,
                0x09
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_EVENT_ITEM_DELETED"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid WIA_EVENT_ITEM_DELETED
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x59, 0xA5, 0x22, 0x1D,
                0x4F, 0xE1,
                0xD2, 0x11,
                0xB3,
                0x26,
                0x00,
                0xC0,
                0x4F,
                0x68,
                0xCE,
                0x61
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_EVENT_ITEM_CREATED"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid WIA_EVENT_ITEM_CREATED
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xF5, 0x4E, 0x8F, 0x4C,
                0x4F, 0xE1,
                0xD2, 0x11,
                0xB3,
                0x26,
                0x00,
                0xC0,
                0x4F,
                0x68,
                0xCE,
                0x61
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_EVENT_TREE_UPDATED"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid WIA_EVENT_TREE_UPDATED
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x91, 0x9B, 0x85, 0xC9,
                0xB2, 0x4A,
                0xD6, 0x4C,
                0xA1,
                0xFC,
                0x58,
                0x2E,
                0xEC,
                0x55,
                0xE5,
                0x85
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_EVENT_VOLUME_INSERT"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid WIA_EVENT_VOLUME_INSERT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xFD, 0xBB, 0x38, 0x96,
                0xBD, 0xD1,
                0xD2, 0x11,
                0xB3,
                0x1F,
                0x00,
                0xC0,
                0x4F,
                0x68,
                0xCE,
                0x61
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_EVENT_SCAN_IMAGE"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid WIA_EVENT_SCAN_IMAGE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x15, 0xA7, 0xC5, 0xA6,
                0x6E, 0x8C,
                0xD2, 0x11,
                0x97,
                0x7A,
                0x00,
                0x00,
                0xF8,
                0x7A,
                0x92,
                0x6F
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_EVENT_SCAN_PRINT_IMAGE"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid WIA_EVENT_SCAN_PRINT_IMAGE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x25, 0xF4, 0x41, 0xB4,
                0x6E, 0x8C,
                0xD2, 0x11,
                0x97,
                0x7A,
                0x00,
                0x00,
                0xF8,
                0x7A,
                0x92,
                0x6F
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_EVENT_SCAN_FAX_IMAGE"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid WIA_EVENT_SCAN_FAX_IMAGE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x93, 0xB7, 0x0E, 0xC0,
                0x6E, 0x8C,
                0xD2, 0x11,
                0x97,
                0x7A,
                0x00,
                0x00,
                0xF8,
                0x7A,
                0x92,
                0x6F
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_EVENT_SCAN_OCR_IMAGE"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid WIA_EVENT_SCAN_OCR_IMAGE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x89, 0x5B, 0x09, 0x9D,
                0xD6, 0x37,
                0x77, 0x48,
                0xAF,
                0xED,
                0x62,
                0xA2,
                0x97,
                0xDC,
                0x6D,
                0xBE
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_EVENT_SCAN_EMAIL_IMAGE"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid WIA_EVENT_SCAN_EMAIL_IMAGE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xEE, 0xDC, 0x86, 0xC6,
                0xF2, 0x54,
                0x9E, 0x41,
                0x9A,
                0x27,
                0x2F,
                0xC7,
                0xF2,
                0xE9,
                0x8F,
                0x9E
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_EVENT_SCAN_FILM_IMAGE"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid WIA_EVENT_SCAN_FILM_IMAGE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x2C, 0x66, 0x2B, 0x9B,
                0x85, 0x61,
                0x8C, 0x43,
                0xB6,
                0x8B,
                0xE3,
                0x9E,
                0xE2,
                0x5E,
                0x71,
                0xCB
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_EVENT_SCAN_IMAGE2"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid WIA_EVENT_SCAN_IMAGE2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xC1, 0x67, 0x47, 0xFC,
                0xB3, 0xC8,
                0xA2, 0x48,
                0x9C,
                0xFA,
                0x2E,
                0x90,
                0xCB,
                0x3D,
                0x35,
                0x90
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_EVENT_SCAN_IMAGE3"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid WIA_EVENT_SCAN_IMAGE3
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xBE, 0x27, 0x4E, 0x15,
                0x17, 0xB6,
                0x53, 0x46,
                0xAC,
                0xC5,
                0x0F,
                0xD7,
                0xBD,
                0x4C,
                0x65,
                0xCE
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_EVENT_SCAN_IMAGE4"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid WIA_EVENT_SCAN_IMAGE4
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x4A, 0x70, 0x5B, 0xA6,
                0x3C, 0x7F,
                0x47, 0x44,
                0xA7,
                0x5D,
                0x8A,
                0x26,
                0xDF,
                0xCA,
                0x1F,
                0xDF
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_EVENT_STORAGE_CREATED"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid WIA_EVENT_STORAGE_CREATED
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xB2, 0x08, 0x33, 0x35,
                0x73, 0xFE,
                0xC8, 0x46,
                0x89,
                0x5E,
                0xFA,
                0x45,
                0x51,
                0xCC,
                0xC8,
                0x5A
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_EVENT_STORAGE_DELETED"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid WIA_EVENT_STORAGE_DELETED
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x5E, 0xE7, 0x41, 0x5E,
                0x90, 0x93,
                0xC5, 0x44,
                0x9A,
                0x51,
                0xE4,
                0x70,
                0x19,
                0xE3,
                0x90,
                0xCF
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_EVENT_STI_PROXY"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid WIA_EVENT_STI_PROXY
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x1F, 0xF8, 0x11, 0xD7,
                0x0D, 0x1F,
                0x2D, 0x42,
                0x86,
                0x41,
                0x92,
                0x7D,
                0x1B,
                0x93,
                0xE5,
                0xE5
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_EVENT_CANCEL_IO"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid WIA_EVENT_CANCEL_IO
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xB8, 0xF7, 0x60, 0xC8,
                0xCD, 0x9C,
                0xEA, 0x41,
                0xBB,
                0xBF,
                0x4D,
                0xD0,
                0x9C,
                0x5B,
                0x17,
                0x95
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_EVENT_POWER_SUSPEND"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid WIA_EVENT_POWER_SUSPEND
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xF9, 0x2F, 0x92, 0xA0,
                0xB4, 0xC3,
                0x1C, 0x41,
                0x9E,
                0x29,
                0x03,
                0xA6,
                0x69,
                0x93,
                0xD2,
                0xBE
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_EVENT_POWER_RESUME"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid WIA_EVENT_POWER_RESUME
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x3E, 0x15, 0x8F, 0x61,
                0x86, 0xF6,
                0x50, 0x43,
                0x96,
                0x34,
                0x41,
                0x15,
                0xA3,
                0x04,
                0x83,
                0x0C
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_EVENT_HANDLER_NO_ACTION"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid WIA_EVENT_HANDLER_NO_ACTION
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x7D, 0x2B, 0x37, 0xE0,
                0x15, 0xE1,
                0x25, 0x45,
                0xBC,
                0x55,
                0xB6,
                0x29,
                0xE6,
                0x8C,
                0x74,
                0x5A
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_EVENT_HANDLER_PROMPT"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid WIA_EVENT_HANDLER_PROMPT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xD0, 0xAA, 0x4B, 0x5F,
                0x59, 0x4D,
                0xCD, 0x4F,
                0xB2,
                0x13,
                0x78,
                0x3C,
                0xE7,
                0xA9,
                0x2F,
                0x22
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_EVENT_DEVICE_NOT_READY"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid WIA_EVENT_DEVICE_NOT_READY
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x7E, 0x2D, 0x96, 0xD8,
                0xDC, 0xE4,
                0x4D, 0x4B,
                0xBA,
                0x29,
                0x66,
                0x8A,
                0x87,
                0xF4,
                0x2E,
                0x6F
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_EVENT_DEVICE_READY"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid WIA_EVENT_DEVICE_READY
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x6C, 0xEC, 0x23, 0x75,
                0x8B, 0x98,
                0x9E, 0x41,
                0x9A,
                0x0A,
                0x42,
                0x5A,
                0xC3,
                0x1B,
                0x37,
                0xDC
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_EVENT_FLATBED_LID_OPEN"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid WIA_EVENT_FLATBED_LID_OPEN
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x23, 0x06, 0x0A, 0xBA,
                0x7D, 0x43,
                0x03, 0x4F,
                0xA9,
                0x7D,
                0x77,
                0x93,
                0xB1,
                0x23,
                0x11,
                0x3C
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_EVENT_FLATBED_LID_CLOSED"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid WIA_EVENT_FLATBED_LID_CLOSED
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x0F, 0xAF, 0x79, 0xF8,
                0x29, 0x9B,
                0x83, 0x42,
                0xAD,
                0x95,
                0xD4,
                0x12,
                0x16,
                0x4D,
                0x39,
                0xA9
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_EVENT_FEEDER_LOADED"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid WIA_EVENT_FEEDER_LOADED
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x1E, 0x70, 0x8D, 0xCC,
                0xBA, 0x9A,
                0x1D, 0x48,
                0xBF,
                0x74,
                0x78,
                0xF7,
                0x63,
                0xDC,
                0x34,
                0x2A
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_EVENT_FEEDER_EMPTIED"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid WIA_EVENT_FEEDER_EMPTIED
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x82, 0x4B, 0x0B, 0xE7,
                0xDA, 0x6D,
                0xBB, 0x46,
                0x8F,
                0xF9,
                0x53,
                0xCE,
                0xB1,
                0xA0,
                0x3E,
                0x35
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_EVENT_COVER_OPEN"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid WIA_EVENT_COVER_OPEN
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x36, 0x21, 0xA1, 0x19,
                0x1C, 0xFA,
                0x66, 0x4F,
                0x90,
                0x0F,
                0x8F,
                0x91,
                0x4E,
                0xC7,
                0x4E,
                0xC9
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_EVENT_COVER_CLOSED"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid WIA_EVENT_COVER_CLOSED
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xE6, 0xA1, 0x14, 0x67,
                0x85, 0xE2,
                0x8C, 0x46,
                0x9B,
                0x8C,
                0xDA,
                0x7D,
                0xC4,
                0xCB,
                0xAA,
                0x05
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_CMD_SYNCHRONIZE"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid WIA_CMD_SYNCHRONIZE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xB2, 0xB7, 0x26, 0x9B,
                0xAD, 0xAC,
                0xD2, 0x11,
                0xA0,
                0x93,
                0x00,
                0xC0,
                0x4F,
                0x72,
                0xDC,
                0x3C
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_CMD_TAKE_PICTURE"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid WIA_CMD_TAKE_PICTURE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xAC, 0x3C, 0x93, 0xAF,
                0xAD, 0xAC,
                0xD2, 0x11,
                0xA0,
                0x93,
                0x00,
                0xC0,
                0x4F,
                0x72,
                0xDC,
                0x3C
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_CMD_DELETE_ALL_ITEMS"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid WIA_CMD_DELETE_ALL_ITEMS
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x70, 0xC1, 0x08, 0xE2,
                0xAD, 0xAC,
                0xD2, 0x11,
                0xA0,
                0x93,
                0x00,
                0xC0,
                0x4F,
                0x72,
                0xDC,
                0x3C
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_CMD_CHANGE_DOCUMENT"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid WIA_CMD_CHANGE_DOCUMENT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xB0, 0x25, 0xE7, 0x04,
                0xAE, 0xAC,
                0xD2, 0x11,
                0xA0,
                0x93,
                0x00,
                0xC0,
                0x4F,
                0x72,
                0xDC,
                0x3C
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_CMD_UNLOAD_DOCUMENT"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid WIA_CMD_UNLOAD_DOCUMENT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x8E, 0x3D, 0x3B, 0x1F,
                0xAE, 0xAC,
                0xD2, 0x11,
                0xA0,
                0x93,
                0x00,
                0xC0,
                0x4F,
                0x72,
                0xDC,
                0x3C
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_CMD_DIAGNOSTIC"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid WIA_CMD_DIAGNOSTIC
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xF5, 0x52, 0xFF, 0x10,
                0x04, 0xDE,
                0xF0, 0x4C,
                0xA5,
                0xAD,
                0x69,
                0x1F,
                0x8D,
                0xCE,
                0x01,
                0x41
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_CMD_FORMAT"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid WIA_CMD_FORMAT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xAA, 0x93, 0xA6, 0xC3,
                0x88, 0xF7,
                0x34, 0x4D,
                0xA5,
                0xB0,
                0xBE,
                0x71,
                0x90,
                0x75,
                0x9A,
                0x24
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_CMD_DELETE_DEVICE_TREE"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid WIA_CMD_DELETE_DEVICE_TREE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x42, 0x59, 0x81, 0x73,
                0xEA, 0xDB,
                0xD2, 0x11,
                0x84,
                0x16,
                0x00,
                0xC0,
                0x4F,
                0xA3,
                0x61,
                0x45
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_CMD_BUILD_DEVICE_TREE"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid WIA_CMD_BUILD_DEVICE_TREE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xE0, 0x5C, 0xBA, 0x9C,
                0xEA, 0xDB,
                0xD2, 0x11,
                0x84,
                0x16,
                0x00,
                0xC0,
                0x4F,
                0xA3,
                0x61,
                0x45
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_CMD_START_FEEDER"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid WIA_CMD_START_FEEDER
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xC9, 0xF6, 0x9D, 0x5A,
                0x2D, 0x5F,
                0x39, 0x4A,
                0x9D,
                0x6C,
                0x00,
                0x45,
                0x6D,
                0x04,
                0x7F,
                0x00
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_CMD_STOP_FEEDER"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid WIA_CMD_STOP_FEEDER
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x6D, 0xB0, 0x47, 0xD8,
                0x05, 0x39,
                0x9C, 0x45,
                0x95,
                0x09,
                0x9B,
                0x29,
                0xCD,
                0xB6,
                0x91,
                0xE7
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_CMD_PAUSE_FEEDER"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid WIA_CMD_PAUSE_FEEDER
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x4D, 0x5E, 0x98, 0x50,
                0xB2, 0xA5,
                0x71, 0x4B,
                0x9C,
                0x95,
                0x6D,
                0x7D,
                0x7C,
                0x46,
                0x9A,
                0x43
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DIP_DEV_ID"]/*' />
    [NativeTypeName("#define WIA_DIP_DEV_ID 2")]
    public const int WIA_DIP_DEV_ID = 2;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DIP_DEV_ID_STR"]/*' />
    [NativeTypeName("#define WIA_DIP_DEV_ID_STR L\"Unique Device ID\"")]
    public const string WIA_DIP_DEV_ID_STR = "Unique Device ID";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DIP_VEND_DESC"]/*' />
    [NativeTypeName("#define WIA_DIP_VEND_DESC 3")]
    public const int WIA_DIP_VEND_DESC = 3;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DIP_VEND_DESC_STR"]/*' />
    [NativeTypeName("#define WIA_DIP_VEND_DESC_STR L\"Manufacturer\"")]
    public const string WIA_DIP_VEND_DESC_STR = "Manufacturer";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DIP_DEV_DESC"]/*' />
    [NativeTypeName("#define WIA_DIP_DEV_DESC 4")]
    public const int WIA_DIP_DEV_DESC = 4;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DIP_DEV_DESC_STR"]/*' />
    [NativeTypeName("#define WIA_DIP_DEV_DESC_STR L\"Description\"")]
    public const string WIA_DIP_DEV_DESC_STR = "Description";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DIP_DEV_TYPE"]/*' />
    [NativeTypeName("#define WIA_DIP_DEV_TYPE 5")]
    public const int WIA_DIP_DEV_TYPE = 5;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DIP_DEV_TYPE_STR"]/*' />
    [NativeTypeName("#define WIA_DIP_DEV_TYPE_STR L\"Type\"")]
    public const string WIA_DIP_DEV_TYPE_STR = "Type";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DIP_PORT_NAME"]/*' />
    [NativeTypeName("#define WIA_DIP_PORT_NAME 6")]
    public const int WIA_DIP_PORT_NAME = 6;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DIP_PORT_NAME_STR"]/*' />
    [NativeTypeName("#define WIA_DIP_PORT_NAME_STR L\"Port\"")]
    public const string WIA_DIP_PORT_NAME_STR = "Port";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DIP_DEV_NAME"]/*' />
    [NativeTypeName("#define WIA_DIP_DEV_NAME 7")]
    public const int WIA_DIP_DEV_NAME = 7;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DIP_DEV_NAME_STR"]/*' />
    [NativeTypeName("#define WIA_DIP_DEV_NAME_STR L\"Name\"")]
    public const string WIA_DIP_DEV_NAME_STR = "Name";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DIP_SERVER_NAME"]/*' />
    [NativeTypeName("#define WIA_DIP_SERVER_NAME 8")]
    public const int WIA_DIP_SERVER_NAME = 8;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DIP_SERVER_NAME_STR"]/*' />
    [NativeTypeName("#define WIA_DIP_SERVER_NAME_STR L\"Server\"")]
    public const string WIA_DIP_SERVER_NAME_STR = "Server";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DIP_REMOTE_DEV_ID"]/*' />
    [NativeTypeName("#define WIA_DIP_REMOTE_DEV_ID 9")]
    public const int WIA_DIP_REMOTE_DEV_ID = 9;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DIP_REMOTE_DEV_ID_STR"]/*' />
    [NativeTypeName("#define WIA_DIP_REMOTE_DEV_ID_STR L\"Remote Device ID\"")]
    public const string WIA_DIP_REMOTE_DEV_ID_STR = "Remote Device ID";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DIP_UI_CLSID"]/*' />
    [NativeTypeName("#define WIA_DIP_UI_CLSID 10")]
    public const int WIA_DIP_UI_CLSID = 10;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DIP_UI_CLSID_STR"]/*' />
    [NativeTypeName("#define WIA_DIP_UI_CLSID_STR L\"UI Class ID\"")]
    public const string WIA_DIP_UI_CLSID_STR = "UI Class ID";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DIP_HW_CONFIG"]/*' />
    [NativeTypeName("#define WIA_DIP_HW_CONFIG 11")]
    public const int WIA_DIP_HW_CONFIG = 11;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DIP_HW_CONFIG_STR"]/*' />
    [NativeTypeName("#define WIA_DIP_HW_CONFIG_STR L\"Hardware Configuration\"")]
    public const string WIA_DIP_HW_CONFIG_STR = "Hardware Configuration";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DIP_BAUDRATE"]/*' />
    [NativeTypeName("#define WIA_DIP_BAUDRATE 12")]
    public const int WIA_DIP_BAUDRATE = 12;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DIP_BAUDRATE_STR"]/*' />
    [NativeTypeName("#define WIA_DIP_BAUDRATE_STR L\"BaudRate\"")]
    public const string WIA_DIP_BAUDRATE_STR = "BaudRate";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DIP_STI_GEN_CAPABILITIES"]/*' />
    [NativeTypeName("#define WIA_DIP_STI_GEN_CAPABILITIES 13")]
    public const int WIA_DIP_STI_GEN_CAPABILITIES = 13;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DIP_STI_GEN_CAPABILITIES_STR"]/*' />
    [NativeTypeName("#define WIA_DIP_STI_GEN_CAPABILITIES_STR L\"STI Generic Capabilities\"")]
    public const string WIA_DIP_STI_GEN_CAPABILITIES_STR = "STI Generic Capabilities";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DIP_WIA_VERSION"]/*' />
    [NativeTypeName("#define WIA_DIP_WIA_VERSION 14")]
    public const int WIA_DIP_WIA_VERSION = 14;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DIP_WIA_VERSION_STR"]/*' />
    [NativeTypeName("#define WIA_DIP_WIA_VERSION_STR L\"WIA Version\"")]
    public const string WIA_DIP_WIA_VERSION_STR = "WIA Version";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DIP_DRIVER_VERSION"]/*' />
    [NativeTypeName("#define WIA_DIP_DRIVER_VERSION 15")]
    public const int WIA_DIP_DRIVER_VERSION = 15;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DIP_DRIVER_VERSION_STR"]/*' />
    [NativeTypeName("#define WIA_DIP_DRIVER_VERSION_STR L\"Driver Version\"")]
    public const string WIA_DIP_DRIVER_VERSION_STR = "Driver Version";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DIP_PNP_ID"]/*' />
    [NativeTypeName("#define WIA_DIP_PNP_ID 16")]
    public const int WIA_DIP_PNP_ID = 16;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DIP_PNP_ID_STR"]/*' />
    [NativeTypeName("#define WIA_DIP_PNP_ID_STR L\"PnP ID String\"")]
    public const string WIA_DIP_PNP_ID_STR = "PnP ID String";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DIP_STI_DRIVER_VERSION"]/*' />
    [NativeTypeName("#define WIA_DIP_STI_DRIVER_VERSION 17")]
    public const int WIA_DIP_STI_DRIVER_VERSION = 17;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DIP_STI_DRIVER_VERSION_STR"]/*' />
    [NativeTypeName("#define WIA_DIP_STI_DRIVER_VERSION_STR L\"STI Driver Version\"")]
    public const string WIA_DIP_STI_DRIVER_VERSION_STR = "STI Driver Version";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPA_FIRMWARE_VERSION"]/*' />
    [NativeTypeName("#define WIA_DPA_FIRMWARE_VERSION 1026")]
    public const int WIA_DPA_FIRMWARE_VERSION = 1026;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPA_FIRMWARE_VERSION_STR"]/*' />
    [NativeTypeName("#define WIA_DPA_FIRMWARE_VERSION_STR L\"Firmware Version\"")]
    public const string WIA_DPA_FIRMWARE_VERSION_STR = "Firmware Version";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPA_CONNECT_STATUS"]/*' />
    [NativeTypeName("#define WIA_DPA_CONNECT_STATUS 1027")]
    public const int WIA_DPA_CONNECT_STATUS = 1027;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPA_CONNECT_STATUS_STR"]/*' />
    [NativeTypeName("#define WIA_DPA_CONNECT_STATUS_STR L\"Connect Status\"")]
    public const string WIA_DPA_CONNECT_STATUS_STR = "Connect Status";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPA_DEVICE_TIME"]/*' />
    [NativeTypeName("#define WIA_DPA_DEVICE_TIME 1028")]
    public const int WIA_DPA_DEVICE_TIME = 1028;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPA_DEVICE_TIME_STR"]/*' />
    [NativeTypeName("#define WIA_DPA_DEVICE_TIME_STR L\"Device Time\"")]
    public const string WIA_DPA_DEVICE_TIME_STR = "Device Time";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPC_PICTURES_TAKEN"]/*' />
    [NativeTypeName("#define WIA_DPC_PICTURES_TAKEN 2050")]
    public const int WIA_DPC_PICTURES_TAKEN = 2050;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPC_PICTURES_TAKEN_STR"]/*' />
    [NativeTypeName("#define WIA_DPC_PICTURES_TAKEN_STR L\"Pictures Taken\"")]
    public const string WIA_DPC_PICTURES_TAKEN_STR = "Pictures Taken";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPC_PICTURES_REMAINING"]/*' />
    [NativeTypeName("#define WIA_DPC_PICTURES_REMAINING 2051")]
    public const int WIA_DPC_PICTURES_REMAINING = 2051;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPC_PICTURES_REMAINING_STR"]/*' />
    [NativeTypeName("#define WIA_DPC_PICTURES_REMAINING_STR L\"Pictures Remaining\"")]
    public const string WIA_DPC_PICTURES_REMAINING_STR = "Pictures Remaining";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPC_EXPOSURE_MODE"]/*' />
    [NativeTypeName("#define WIA_DPC_EXPOSURE_MODE 2052")]
    public const int WIA_DPC_EXPOSURE_MODE = 2052;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPC_EXPOSURE_MODE_STR"]/*' />
    [NativeTypeName("#define WIA_DPC_EXPOSURE_MODE_STR L\"Exposure Mode\"")]
    public const string WIA_DPC_EXPOSURE_MODE_STR = "Exposure Mode";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPC_EXPOSURE_COMP"]/*' />
    [NativeTypeName("#define WIA_DPC_EXPOSURE_COMP 2053")]
    public const int WIA_DPC_EXPOSURE_COMP = 2053;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPC_EXPOSURE_COMP_STR"]/*' />
    [NativeTypeName("#define WIA_DPC_EXPOSURE_COMP_STR L\"Exposure Compensation\"")]
    public const string WIA_DPC_EXPOSURE_COMP_STR = "Exposure Compensation";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPC_EXPOSURE_TIME"]/*' />
    [NativeTypeName("#define WIA_DPC_EXPOSURE_TIME 2054")]
    public const int WIA_DPC_EXPOSURE_TIME = 2054;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPC_EXPOSURE_TIME_STR"]/*' />
    [NativeTypeName("#define WIA_DPC_EXPOSURE_TIME_STR L\"Exposure Time\"")]
    public const string WIA_DPC_EXPOSURE_TIME_STR = "Exposure Time";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPC_FNUMBER"]/*' />
    [NativeTypeName("#define WIA_DPC_FNUMBER 2055")]
    public const int WIA_DPC_FNUMBER = 2055;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPC_FNUMBER_STR"]/*' />
    [NativeTypeName("#define WIA_DPC_FNUMBER_STR L\"F Number\"")]
    public const string WIA_DPC_FNUMBER_STR = "F Number";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPC_FLASH_MODE"]/*' />
    [NativeTypeName("#define WIA_DPC_FLASH_MODE 2056")]
    public const int WIA_DPC_FLASH_MODE = 2056;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPC_FLASH_MODE_STR"]/*' />
    [NativeTypeName("#define WIA_DPC_FLASH_MODE_STR L\"Flash Mode\"")]
    public const string WIA_DPC_FLASH_MODE_STR = "Flash Mode";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPC_FOCUS_MODE"]/*' />
    [NativeTypeName("#define WIA_DPC_FOCUS_MODE 2057")]
    public const int WIA_DPC_FOCUS_MODE = 2057;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPC_FOCUS_MODE_STR"]/*' />
    [NativeTypeName("#define WIA_DPC_FOCUS_MODE_STR L\"Focus Mode\"")]
    public const string WIA_DPC_FOCUS_MODE_STR = "Focus Mode";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPC_FOCUS_MANUAL_DIST"]/*' />
    [NativeTypeName("#define WIA_DPC_FOCUS_MANUAL_DIST 2058")]
    public const int WIA_DPC_FOCUS_MANUAL_DIST = 2058;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPC_FOCUS_MANUAL_DIST_STR"]/*' />
    [NativeTypeName("#define WIA_DPC_FOCUS_MANUAL_DIST_STR L\"Focus Manual Dist\"")]
    public const string WIA_DPC_FOCUS_MANUAL_DIST_STR = "Focus Manual Dist";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPC_ZOOM_POSITION"]/*' />
    [NativeTypeName("#define WIA_DPC_ZOOM_POSITION 2059")]
    public const int WIA_DPC_ZOOM_POSITION = 2059;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPC_ZOOM_POSITION_STR"]/*' />
    [NativeTypeName("#define WIA_DPC_ZOOM_POSITION_STR L\"Zoom Position\"")]
    public const string WIA_DPC_ZOOM_POSITION_STR = "Zoom Position";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPC_PAN_POSITION"]/*' />
    [NativeTypeName("#define WIA_DPC_PAN_POSITION 2060")]
    public const int WIA_DPC_PAN_POSITION = 2060;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPC_PAN_POSITION_STR"]/*' />
    [NativeTypeName("#define WIA_DPC_PAN_POSITION_STR L\"Pan Position\"")]
    public const string WIA_DPC_PAN_POSITION_STR = "Pan Position";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPC_TILT_POSITION"]/*' />
    [NativeTypeName("#define WIA_DPC_TILT_POSITION 2061")]
    public const int WIA_DPC_TILT_POSITION = 2061;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPC_TILT_POSITION_STR"]/*' />
    [NativeTypeName("#define WIA_DPC_TILT_POSITION_STR L\"Tilt Position\"")]
    public const string WIA_DPC_TILT_POSITION_STR = "Tilt Position";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPC_TIMER_MODE"]/*' />
    [NativeTypeName("#define WIA_DPC_TIMER_MODE 2062")]
    public const int WIA_DPC_TIMER_MODE = 2062;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPC_TIMER_MODE_STR"]/*' />
    [NativeTypeName("#define WIA_DPC_TIMER_MODE_STR L\"Timer Mode\"")]
    public const string WIA_DPC_TIMER_MODE_STR = "Timer Mode";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPC_TIMER_VALUE"]/*' />
    [NativeTypeName("#define WIA_DPC_TIMER_VALUE 2063")]
    public const int WIA_DPC_TIMER_VALUE = 2063;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPC_TIMER_VALUE_STR"]/*' />
    [NativeTypeName("#define WIA_DPC_TIMER_VALUE_STR L\"Timer Value\"")]
    public const string WIA_DPC_TIMER_VALUE_STR = "Timer Value";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPC_POWER_MODE"]/*' />
    [NativeTypeName("#define WIA_DPC_POWER_MODE 2064")]
    public const int WIA_DPC_POWER_MODE = 2064;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPC_POWER_MODE_STR"]/*' />
    [NativeTypeName("#define WIA_DPC_POWER_MODE_STR L\"Power Mode\"")]
    public const string WIA_DPC_POWER_MODE_STR = "Power Mode";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPC_BATTERY_STATUS"]/*' />
    [NativeTypeName("#define WIA_DPC_BATTERY_STATUS 2065")]
    public const int WIA_DPC_BATTERY_STATUS = 2065;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPC_BATTERY_STATUS_STR"]/*' />
    [NativeTypeName("#define WIA_DPC_BATTERY_STATUS_STR L\"Battery Status\"")]
    public const string WIA_DPC_BATTERY_STATUS_STR = "Battery Status";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPC_THUMB_WIDTH"]/*' />
    [NativeTypeName("#define WIA_DPC_THUMB_WIDTH 2066")]
    public const int WIA_DPC_THUMB_WIDTH = 2066;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPC_THUMB_WIDTH_STR"]/*' />
    [NativeTypeName("#define WIA_DPC_THUMB_WIDTH_STR L\"Thumbnail Width\"")]
    public const string WIA_DPC_THUMB_WIDTH_STR = "Thumbnail Width";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPC_THUMB_HEIGHT"]/*' />
    [NativeTypeName("#define WIA_DPC_THUMB_HEIGHT 2067")]
    public const int WIA_DPC_THUMB_HEIGHT = 2067;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPC_THUMB_HEIGHT_STR"]/*' />
    [NativeTypeName("#define WIA_DPC_THUMB_HEIGHT_STR L\"Thumbnail Height\"")]
    public const string WIA_DPC_THUMB_HEIGHT_STR = "Thumbnail Height";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPC_PICT_WIDTH"]/*' />
    [NativeTypeName("#define WIA_DPC_PICT_WIDTH 2068")]
    public const int WIA_DPC_PICT_WIDTH = 2068;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPC_PICT_WIDTH_STR"]/*' />
    [NativeTypeName("#define WIA_DPC_PICT_WIDTH_STR L\"Picture Width\"")]
    public const string WIA_DPC_PICT_WIDTH_STR = "Picture Width";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPC_PICT_HEIGHT"]/*' />
    [NativeTypeName("#define WIA_DPC_PICT_HEIGHT 2069")]
    public const int WIA_DPC_PICT_HEIGHT = 2069;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPC_PICT_HEIGHT_STR"]/*' />
    [NativeTypeName("#define WIA_DPC_PICT_HEIGHT_STR L\"Picture Height\"")]
    public const string WIA_DPC_PICT_HEIGHT_STR = "Picture Height";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPC_DIMENSION"]/*' />
    [NativeTypeName("#define WIA_DPC_DIMENSION 2070")]
    public const int WIA_DPC_DIMENSION = 2070;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPC_DIMENSION_STR"]/*' />
    [NativeTypeName("#define WIA_DPC_DIMENSION_STR L\"Dimension\"")]
    public const string WIA_DPC_DIMENSION_STR = "Dimension";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPC_COMPRESSION_SETTING"]/*' />
    [NativeTypeName("#define WIA_DPC_COMPRESSION_SETTING 2071")]
    public const int WIA_DPC_COMPRESSION_SETTING = 2071;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPC_COMPRESSION_SETTING_STR"]/*' />
    [NativeTypeName("#define WIA_DPC_COMPRESSION_SETTING_STR L\"Compression Setting\"")]
    public const string WIA_DPC_COMPRESSION_SETTING_STR = "Compression Setting";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPC_FOCUS_METERING"]/*' />
    [NativeTypeName("#define WIA_DPC_FOCUS_METERING 2072")]
    public const int WIA_DPC_FOCUS_METERING = 2072;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPC_FOCUS_METERING_STR"]/*' />
    [NativeTypeName("#define WIA_DPC_FOCUS_METERING_STR L\"Focus Metering Mode\"")]
    public const string WIA_DPC_FOCUS_METERING_STR = "Focus Metering Mode";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPC_TIMELAPSE_INTERVAL"]/*' />
    [NativeTypeName("#define WIA_DPC_TIMELAPSE_INTERVAL 2073")]
    public const int WIA_DPC_TIMELAPSE_INTERVAL = 2073;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPC_TIMELAPSE_INTERVAL_STR"]/*' />
    [NativeTypeName("#define WIA_DPC_TIMELAPSE_INTERVAL_STR L\"Timelapse Interval\"")]
    public const string WIA_DPC_TIMELAPSE_INTERVAL_STR = "Timelapse Interval";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPC_TIMELAPSE_NUMBER"]/*' />
    [NativeTypeName("#define WIA_DPC_TIMELAPSE_NUMBER 2074")]
    public const int WIA_DPC_TIMELAPSE_NUMBER = 2074;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPC_TIMELAPSE_NUMBER_STR"]/*' />
    [NativeTypeName("#define WIA_DPC_TIMELAPSE_NUMBER_STR L\"Timelapse Number\"")]
    public const string WIA_DPC_TIMELAPSE_NUMBER_STR = "Timelapse Number";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPC_BURST_INTERVAL"]/*' />
    [NativeTypeName("#define WIA_DPC_BURST_INTERVAL 2075")]
    public const int WIA_DPC_BURST_INTERVAL = 2075;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPC_BURST_INTERVAL_STR"]/*' />
    [NativeTypeName("#define WIA_DPC_BURST_INTERVAL_STR L\"Burst Interval\"")]
    public const string WIA_DPC_BURST_INTERVAL_STR = "Burst Interval";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPC_BURST_NUMBER"]/*' />
    [NativeTypeName("#define WIA_DPC_BURST_NUMBER 2076")]
    public const int WIA_DPC_BURST_NUMBER = 2076;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPC_BURST_NUMBER_STR"]/*' />
    [NativeTypeName("#define WIA_DPC_BURST_NUMBER_STR L\"Burst Number\"")]
    public const string WIA_DPC_BURST_NUMBER_STR = "Burst Number";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPC_EFFECT_MODE"]/*' />
    [NativeTypeName("#define WIA_DPC_EFFECT_MODE 2077")]
    public const int WIA_DPC_EFFECT_MODE = 2077;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPC_EFFECT_MODE_STR"]/*' />
    [NativeTypeName("#define WIA_DPC_EFFECT_MODE_STR L\"Effect Mode\"")]
    public const string WIA_DPC_EFFECT_MODE_STR = "Effect Mode";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPC_DIGITAL_ZOOM"]/*' />
    [NativeTypeName("#define WIA_DPC_DIGITAL_ZOOM 2078")]
    public const int WIA_DPC_DIGITAL_ZOOM = 2078;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPC_DIGITAL_ZOOM_STR"]/*' />
    [NativeTypeName("#define WIA_DPC_DIGITAL_ZOOM_STR L\"Digital Zoom\"")]
    public const string WIA_DPC_DIGITAL_ZOOM_STR = "Digital Zoom";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPC_SHARPNESS"]/*' />
    [NativeTypeName("#define WIA_DPC_SHARPNESS 2079")]
    public const int WIA_DPC_SHARPNESS = 2079;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPC_SHARPNESS_STR"]/*' />
    [NativeTypeName("#define WIA_DPC_SHARPNESS_STR L\"Sharpness\"")]
    public const string WIA_DPC_SHARPNESS_STR = "Sharpness";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPC_CONTRAST"]/*' />
    [NativeTypeName("#define WIA_DPC_CONTRAST 2080")]
    public const int WIA_DPC_CONTRAST = 2080;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPC_CONTRAST_STR"]/*' />
    [NativeTypeName("#define WIA_DPC_CONTRAST_STR L\"Contrast\"")]
    public const string WIA_DPC_CONTRAST_STR = "Contrast";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPC_CAPTURE_MODE"]/*' />
    [NativeTypeName("#define WIA_DPC_CAPTURE_MODE 2081")]
    public const int WIA_DPC_CAPTURE_MODE = 2081;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPC_CAPTURE_MODE_STR"]/*' />
    [NativeTypeName("#define WIA_DPC_CAPTURE_MODE_STR L\"Capture Mode\"")]
    public const string WIA_DPC_CAPTURE_MODE_STR = "Capture Mode";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPC_CAPTURE_DELAY"]/*' />
    [NativeTypeName("#define WIA_DPC_CAPTURE_DELAY 2082")]
    public const int WIA_DPC_CAPTURE_DELAY = 2082;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPC_CAPTURE_DELAY_STR"]/*' />
    [NativeTypeName("#define WIA_DPC_CAPTURE_DELAY_STR L\"Capture Delay\"")]
    public const string WIA_DPC_CAPTURE_DELAY_STR = "Capture Delay";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPC_EXPOSURE_INDEX"]/*' />
    [NativeTypeName("#define WIA_DPC_EXPOSURE_INDEX 2083")]
    public const int WIA_DPC_EXPOSURE_INDEX = 2083;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPC_EXPOSURE_INDEX_STR"]/*' />
    [NativeTypeName("#define WIA_DPC_EXPOSURE_INDEX_STR L\"Exposure Index\"")]
    public const string WIA_DPC_EXPOSURE_INDEX_STR = "Exposure Index";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPC_EXPOSURE_METERING_MODE"]/*' />
    [NativeTypeName("#define WIA_DPC_EXPOSURE_METERING_MODE 2084")]
    public const int WIA_DPC_EXPOSURE_METERING_MODE = 2084;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPC_EXPOSURE_METERING_MODE_STR"]/*' />
    [NativeTypeName("#define WIA_DPC_EXPOSURE_METERING_MODE_STR L\"Exposure Metering Mode\"")]
    public const string WIA_DPC_EXPOSURE_METERING_MODE_STR = "Exposure Metering Mode";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPC_FOCUS_METERING_MODE"]/*' />
    [NativeTypeName("#define WIA_DPC_FOCUS_METERING_MODE 2085")]
    public const int WIA_DPC_FOCUS_METERING_MODE = 2085;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPC_FOCUS_METERING_MODE_STR"]/*' />
    [NativeTypeName("#define WIA_DPC_FOCUS_METERING_MODE_STR L\"Focus Metering Mode\"")]
    public const string WIA_DPC_FOCUS_METERING_MODE_STR = "Focus Metering Mode";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPC_FOCUS_DISTANCE"]/*' />
    [NativeTypeName("#define WIA_DPC_FOCUS_DISTANCE 2086")]
    public const int WIA_DPC_FOCUS_DISTANCE = 2086;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPC_FOCUS_DISTANCE_STR"]/*' />
    [NativeTypeName("#define WIA_DPC_FOCUS_DISTANCE_STR L\"Focus Distance\"")]
    public const string WIA_DPC_FOCUS_DISTANCE_STR = "Focus Distance";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPC_FOCAL_LENGTH"]/*' />
    [NativeTypeName("#define WIA_DPC_FOCAL_LENGTH 2087")]
    public const int WIA_DPC_FOCAL_LENGTH = 2087;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPC_FOCAL_LENGTH_STR"]/*' />
    [NativeTypeName("#define WIA_DPC_FOCAL_LENGTH_STR L\"Focus Length\"")]
    public const string WIA_DPC_FOCAL_LENGTH_STR = "Focus Length";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPC_RGB_GAIN"]/*' />
    [NativeTypeName("#define WIA_DPC_RGB_GAIN 2088")]
    public const int WIA_DPC_RGB_GAIN = 2088;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPC_RGB_GAIN_STR"]/*' />
    [NativeTypeName("#define WIA_DPC_RGB_GAIN_STR L\"RGB Gain\"")]
    public const string WIA_DPC_RGB_GAIN_STR = "RGB Gain";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPC_WHITE_BALANCE"]/*' />
    [NativeTypeName("#define WIA_DPC_WHITE_BALANCE 2089")]
    public const int WIA_DPC_WHITE_BALANCE = 2089;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPC_WHITE_BALANCE_STR"]/*' />
    [NativeTypeName("#define WIA_DPC_WHITE_BALANCE_STR L\"White Balance\"")]
    public const string WIA_DPC_WHITE_BALANCE_STR = "White Balance";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPC_UPLOAD_URL"]/*' />
    [NativeTypeName("#define WIA_DPC_UPLOAD_URL 2090")]
    public const int WIA_DPC_UPLOAD_URL = 2090;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPC_UPLOAD_URL_STR"]/*' />
    [NativeTypeName("#define WIA_DPC_UPLOAD_URL_STR L\"Upload URL\"")]
    public const string WIA_DPC_UPLOAD_URL_STR = "Upload URL";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPC_ARTIST"]/*' />
    [NativeTypeName("#define WIA_DPC_ARTIST 2091")]
    public const int WIA_DPC_ARTIST = 2091;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPC_ARTIST_STR"]/*' />
    [NativeTypeName("#define WIA_DPC_ARTIST_STR L\"Artist\"")]
    public const string WIA_DPC_ARTIST_STR = "Artist";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPC_COPYRIGHT_INFO"]/*' />
    [NativeTypeName("#define WIA_DPC_COPYRIGHT_INFO 2092")]
    public const int WIA_DPC_COPYRIGHT_INFO = 2092;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPC_COPYRIGHT_INFO_STR"]/*' />
    [NativeTypeName("#define WIA_DPC_COPYRIGHT_INFO_STR L\"Copyright Info\"")]
    public const string WIA_DPC_COPYRIGHT_INFO_STR = "Copyright Info";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPS_HORIZONTAL_BED_SIZE"]/*' />
    [NativeTypeName("#define WIA_DPS_HORIZONTAL_BED_SIZE 3074")]
    public const int WIA_DPS_HORIZONTAL_BED_SIZE = 3074;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPS_HORIZONTAL_BED_SIZE_STR"]/*' />
    [NativeTypeName("#define WIA_DPS_HORIZONTAL_BED_SIZE_STR L\"Horizontal Bed Size\"")]
    public const string WIA_DPS_HORIZONTAL_BED_SIZE_STR = "Horizontal Bed Size";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPS_VERTICAL_BED_SIZE"]/*' />
    [NativeTypeName("#define WIA_DPS_VERTICAL_BED_SIZE 3075")]
    public const int WIA_DPS_VERTICAL_BED_SIZE = 3075;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPS_VERTICAL_BED_SIZE_STR"]/*' />
    [NativeTypeName("#define WIA_DPS_VERTICAL_BED_SIZE_STR L\"Vertical Bed Size\"")]
    public const string WIA_DPS_VERTICAL_BED_SIZE_STR = "Vertical Bed Size";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPS_HORIZONTAL_SHEET_FEED_SIZE"]/*' />
    [NativeTypeName("#define WIA_DPS_HORIZONTAL_SHEET_FEED_SIZE 3076")]
    public const int WIA_DPS_HORIZONTAL_SHEET_FEED_SIZE = 3076;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPS_HORIZONTAL_SHEET_FEED_SIZE_STR"]/*' />
    [NativeTypeName("#define WIA_DPS_HORIZONTAL_SHEET_FEED_SIZE_STR L\"Horizontal Sheet Feed Size\"")]
    public const string WIA_DPS_HORIZONTAL_SHEET_FEED_SIZE_STR = "Horizontal Sheet Feed Size";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPS_VERTICAL_SHEET_FEED_SIZE"]/*' />
    [NativeTypeName("#define WIA_DPS_VERTICAL_SHEET_FEED_SIZE 3077")]
    public const int WIA_DPS_VERTICAL_SHEET_FEED_SIZE = 3077;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPS_VERTICAL_SHEET_FEED_SIZE_STR"]/*' />
    [NativeTypeName("#define WIA_DPS_VERTICAL_SHEET_FEED_SIZE_STR L\"Vertical Sheet Feed Size\"")]
    public const string WIA_DPS_VERTICAL_SHEET_FEED_SIZE_STR = "Vertical Sheet Feed Size";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPS_SHEET_FEEDER_REGISTRATION"]/*' />
    [NativeTypeName("#define WIA_DPS_SHEET_FEEDER_REGISTRATION 3078")]
    public const int WIA_DPS_SHEET_FEEDER_REGISTRATION = 3078;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPS_SHEET_FEEDER_REGISTRATION_STR"]/*' />
    [NativeTypeName("#define WIA_DPS_SHEET_FEEDER_REGISTRATION_STR L\"Sheet Feeder Registration\"")]
    public const string WIA_DPS_SHEET_FEEDER_REGISTRATION_STR = "Sheet Feeder Registration";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPS_HORIZONTAL_BED_REGISTRATION"]/*' />
    [NativeTypeName("#define WIA_DPS_HORIZONTAL_BED_REGISTRATION 3079")]
    public const int WIA_DPS_HORIZONTAL_BED_REGISTRATION = 3079;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPS_HORIZONTAL_BED_REGISTRATION_STR"]/*' />
    [NativeTypeName("#define WIA_DPS_HORIZONTAL_BED_REGISTRATION_STR L\"Horizontal Bed Registration\"")]
    public const string WIA_DPS_HORIZONTAL_BED_REGISTRATION_STR = "Horizontal Bed Registration";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPS_VERTICAL_BED_REGISTRATION"]/*' />
    [NativeTypeName("#define WIA_DPS_VERTICAL_BED_REGISTRATION 3080")]
    public const int WIA_DPS_VERTICAL_BED_REGISTRATION = 3080;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPS_VERTICAL_BED_REGISTRATION_STR"]/*' />
    [NativeTypeName("#define WIA_DPS_VERTICAL_BED_REGISTRATION_STR L\"Vertical Bed Registration\"")]
    public const string WIA_DPS_VERTICAL_BED_REGISTRATION_STR = "Vertical Bed Registration";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPS_PLATEN_COLOR"]/*' />
    [NativeTypeName("#define WIA_DPS_PLATEN_COLOR 3081")]
    public const int WIA_DPS_PLATEN_COLOR = 3081;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPS_PLATEN_COLOR_STR"]/*' />
    [NativeTypeName("#define WIA_DPS_PLATEN_COLOR_STR L\"Platen Color\"")]
    public const string WIA_DPS_PLATEN_COLOR_STR = "Platen Color";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPS_PAD_COLOR"]/*' />
    [NativeTypeName("#define WIA_DPS_PAD_COLOR 3082")]
    public const int WIA_DPS_PAD_COLOR = 3082;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPS_PAD_COLOR_STR"]/*' />
    [NativeTypeName("#define WIA_DPS_PAD_COLOR_STR L\"Pad Color\"")]
    public const string WIA_DPS_PAD_COLOR_STR = "Pad Color";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPS_FILTER_SELECT"]/*' />
    [NativeTypeName("#define WIA_DPS_FILTER_SELECT 3083")]
    public const int WIA_DPS_FILTER_SELECT = 3083;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPS_FILTER_SELECT_STR"]/*' />
    [NativeTypeName("#define WIA_DPS_FILTER_SELECT_STR L\"Filter Select\"")]
    public const string WIA_DPS_FILTER_SELECT_STR = "Filter Select";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPS_DITHER_SELECT"]/*' />
    [NativeTypeName("#define WIA_DPS_DITHER_SELECT 3084")]
    public const int WIA_DPS_DITHER_SELECT = 3084;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPS_DITHER_SELECT_STR"]/*' />
    [NativeTypeName("#define WIA_DPS_DITHER_SELECT_STR L\"Dither Select\"")]
    public const string WIA_DPS_DITHER_SELECT_STR = "Dither Select";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPS_DITHER_PATTERN_DATA"]/*' />
    [NativeTypeName("#define WIA_DPS_DITHER_PATTERN_DATA 3085")]
    public const int WIA_DPS_DITHER_PATTERN_DATA = 3085;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPS_DITHER_PATTERN_DATA_STR"]/*' />
    [NativeTypeName("#define WIA_DPS_DITHER_PATTERN_DATA_STR L\"Dither Pattern Data\"")]
    public const string WIA_DPS_DITHER_PATTERN_DATA_STR = "Dither Pattern Data";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPS_DOCUMENT_HANDLING_CAPABILITIES"]/*' />
    [NativeTypeName("#define WIA_DPS_DOCUMENT_HANDLING_CAPABILITIES 3086")]
    public const int WIA_DPS_DOCUMENT_HANDLING_CAPABILITIES = 3086;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPS_DOCUMENT_HANDLING_CAPABILITIES_STR"]/*' />
    [NativeTypeName("#define WIA_DPS_DOCUMENT_HANDLING_CAPABILITIES_STR L\"Document Handling Capabilities\"")]
    public const string WIA_DPS_DOCUMENT_HANDLING_CAPABILITIES_STR = "Document Handling Capabilities";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPS_DOCUMENT_HANDLING_STATUS"]/*' />
    [NativeTypeName("#define WIA_DPS_DOCUMENT_HANDLING_STATUS 3087")]
    public const int WIA_DPS_DOCUMENT_HANDLING_STATUS = 3087;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPS_DOCUMENT_HANDLING_STATUS_STR"]/*' />
    [NativeTypeName("#define WIA_DPS_DOCUMENT_HANDLING_STATUS_STR L\"Document Handling Status\"")]
    public const string WIA_DPS_DOCUMENT_HANDLING_STATUS_STR = "Document Handling Status";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPS_DOCUMENT_HANDLING_SELECT"]/*' />
    [NativeTypeName("#define WIA_DPS_DOCUMENT_HANDLING_SELECT 3088")]
    public const int WIA_DPS_DOCUMENT_HANDLING_SELECT = 3088;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPS_DOCUMENT_HANDLING_SELECT_STR"]/*' />
    [NativeTypeName("#define WIA_DPS_DOCUMENT_HANDLING_SELECT_STR L\"Document Handling Select\"")]
    public const string WIA_DPS_DOCUMENT_HANDLING_SELECT_STR = "Document Handling Select";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPS_DOCUMENT_HANDLING_CAPACITY"]/*' />
    [NativeTypeName("#define WIA_DPS_DOCUMENT_HANDLING_CAPACITY 3089")]
    public const int WIA_DPS_DOCUMENT_HANDLING_CAPACITY = 3089;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPS_DOCUMENT_HANDLING_CAPACITY_STR"]/*' />
    [NativeTypeName("#define WIA_DPS_DOCUMENT_HANDLING_CAPACITY_STR L\"Document Handling Capacity\"")]
    public const string WIA_DPS_DOCUMENT_HANDLING_CAPACITY_STR = "Document Handling Capacity";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPS_OPTICAL_XRES"]/*' />
    [NativeTypeName("#define WIA_DPS_OPTICAL_XRES 3090")]
    public const int WIA_DPS_OPTICAL_XRES = 3090;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPS_OPTICAL_XRES_STR"]/*' />
    [NativeTypeName("#define WIA_DPS_OPTICAL_XRES_STR L\"Horizontal Optical Resolution\"")]
    public const string WIA_DPS_OPTICAL_XRES_STR = "Horizontal Optical Resolution";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPS_OPTICAL_YRES"]/*' />
    [NativeTypeName("#define WIA_DPS_OPTICAL_YRES 3091")]
    public const int WIA_DPS_OPTICAL_YRES = 3091;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPS_OPTICAL_YRES_STR"]/*' />
    [NativeTypeName("#define WIA_DPS_OPTICAL_YRES_STR L\"Vertical Optical Resolution\"")]
    public const string WIA_DPS_OPTICAL_YRES_STR = "Vertical Optical Resolution";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPS_ENDORSER_CHARACTERS"]/*' />
    [NativeTypeName("#define WIA_DPS_ENDORSER_CHARACTERS 3092")]
    public const int WIA_DPS_ENDORSER_CHARACTERS = 3092;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPS_ENDORSER_CHARACTERS_STR"]/*' />
    [NativeTypeName("#define WIA_DPS_ENDORSER_CHARACTERS_STR L\"Endorser Characters\"")]
    public const string WIA_DPS_ENDORSER_CHARACTERS_STR = "Endorser Characters";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPS_ENDORSER_STRING"]/*' />
    [NativeTypeName("#define WIA_DPS_ENDORSER_STRING 3093")]
    public const int WIA_DPS_ENDORSER_STRING = 3093;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPS_ENDORSER_STRING_STR"]/*' />
    [NativeTypeName("#define WIA_DPS_ENDORSER_STRING_STR L\"Endorser String\"")]
    public const string WIA_DPS_ENDORSER_STRING_STR = "Endorser String";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPS_SCAN_AHEAD_PAGES"]/*' />
    [NativeTypeName("#define WIA_DPS_SCAN_AHEAD_PAGES 3094")]
    public const int WIA_DPS_SCAN_AHEAD_PAGES = 3094;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPS_SCAN_AHEAD_PAGES_STR"]/*' />
    [NativeTypeName("#define WIA_DPS_SCAN_AHEAD_PAGES_STR L\"Scan Ahead Pages\"")]
    public const string WIA_DPS_SCAN_AHEAD_PAGES_STR = "Scan Ahead Pages";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPS_MAX_SCAN_TIME"]/*' />
    [NativeTypeName("#define WIA_DPS_MAX_SCAN_TIME 3095")]
    public const int WIA_DPS_MAX_SCAN_TIME = 3095;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPS_MAX_SCAN_TIME_STR"]/*' />
    [NativeTypeName("#define WIA_DPS_MAX_SCAN_TIME_STR L\"Max Scan Time\"")]
    public const string WIA_DPS_MAX_SCAN_TIME_STR = "Max Scan Time";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPS_PAGES"]/*' />
    [NativeTypeName("#define WIA_DPS_PAGES 3096")]
    public const int WIA_DPS_PAGES = 3096;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPS_PAGES_STR"]/*' />
    [NativeTypeName("#define WIA_DPS_PAGES_STR L\"Pages\"")]
    public const string WIA_DPS_PAGES_STR = "Pages";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPS_PAGE_SIZE"]/*' />
    [NativeTypeName("#define WIA_DPS_PAGE_SIZE 3097")]
    public const int WIA_DPS_PAGE_SIZE = 3097;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPS_PAGE_SIZE_STR"]/*' />
    [NativeTypeName("#define WIA_DPS_PAGE_SIZE_STR L\"Page Size\"")]
    public const string WIA_DPS_PAGE_SIZE_STR = "Page Size";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPS_PAGE_WIDTH"]/*' />
    [NativeTypeName("#define WIA_DPS_PAGE_WIDTH 3098")]
    public const int WIA_DPS_PAGE_WIDTH = 3098;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPS_PAGE_WIDTH_STR"]/*' />
    [NativeTypeName("#define WIA_DPS_PAGE_WIDTH_STR L\"Page Width\"")]
    public const string WIA_DPS_PAGE_WIDTH_STR = "Page Width";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPS_PAGE_HEIGHT"]/*' />
    [NativeTypeName("#define WIA_DPS_PAGE_HEIGHT 3099")]
    public const int WIA_DPS_PAGE_HEIGHT = 3099;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPS_PAGE_HEIGHT_STR"]/*' />
    [NativeTypeName("#define WIA_DPS_PAGE_HEIGHT_STR L\"Page Height\"")]
    public const string WIA_DPS_PAGE_HEIGHT_STR = "Page Height";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPS_PREVIEW"]/*' />
    [NativeTypeName("#define WIA_DPS_PREVIEW 3100")]
    public const int WIA_DPS_PREVIEW = 3100;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPS_PREVIEW_STR"]/*' />
    [NativeTypeName("#define WIA_DPS_PREVIEW_STR L\"Preview\"")]
    public const string WIA_DPS_PREVIEW_STR = "Preview";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPS_TRANSPARENCY"]/*' />
    [NativeTypeName("#define WIA_DPS_TRANSPARENCY 3101")]
    public const int WIA_DPS_TRANSPARENCY = 3101;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPS_TRANSPARENCY_STR"]/*' />
    [NativeTypeName("#define WIA_DPS_TRANSPARENCY_STR L\"Transparency Adapter\"")]
    public const string WIA_DPS_TRANSPARENCY_STR = "Transparency Adapter";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPS_TRANSPARENCY_SELECT"]/*' />
    [NativeTypeName("#define WIA_DPS_TRANSPARENCY_SELECT 3102")]
    public const int WIA_DPS_TRANSPARENCY_SELECT = 3102;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPS_TRANSPARENCY_SELECT_STR"]/*' />
    [NativeTypeName("#define WIA_DPS_TRANSPARENCY_SELECT_STR L\"Transparency Adapter Select\"")]
    public const string WIA_DPS_TRANSPARENCY_SELECT_STR = "Transparency Adapter Select";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPS_SHOW_PREVIEW_CONTROL"]/*' />
    [NativeTypeName("#define WIA_DPS_SHOW_PREVIEW_CONTROL 3103")]
    public const int WIA_DPS_SHOW_PREVIEW_CONTROL = 3103;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPS_SHOW_PREVIEW_CONTROL_STR"]/*' />
    [NativeTypeName("#define WIA_DPS_SHOW_PREVIEW_CONTROL_STR L\"Show preview control\"")]
    public const string WIA_DPS_SHOW_PREVIEW_CONTROL_STR = "Show preview control";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPS_MIN_HORIZONTAL_SHEET_FEED_SIZE"]/*' />
    [NativeTypeName("#define WIA_DPS_MIN_HORIZONTAL_SHEET_FEED_SIZE 3104")]
    public const int WIA_DPS_MIN_HORIZONTAL_SHEET_FEED_SIZE = 3104;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPS_MIN_HORIZONTAL_SHEET_FEED_SIZE_STR"]/*' />
    [NativeTypeName("#define WIA_DPS_MIN_HORIZONTAL_SHEET_FEED_SIZE_STR L\"Minimum Horizontal Sheet Feed Size\"")]
    public const string WIA_DPS_MIN_HORIZONTAL_SHEET_FEED_SIZE_STR = "Minimum Horizontal Sheet Feed Size";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPS_MIN_VERTICAL_SHEET_FEED_SIZE"]/*' />
    [NativeTypeName("#define WIA_DPS_MIN_VERTICAL_SHEET_FEED_SIZE 3105")]
    public const int WIA_DPS_MIN_VERTICAL_SHEET_FEED_SIZE = 3105;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPS_MIN_VERTICAL_SHEET_FEED_SIZE_STR"]/*' />
    [NativeTypeName("#define WIA_DPS_MIN_VERTICAL_SHEET_FEED_SIZE_STR L\"Minimum Vertical Sheet Feed Size\"")]
    public const string WIA_DPS_MIN_VERTICAL_SHEET_FEED_SIZE_STR = "Minimum Vertical Sheet Feed Size";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPS_TRANSPARENCY_CAPABILITIES"]/*' />
    [NativeTypeName("#define WIA_DPS_TRANSPARENCY_CAPABILITIES 3106")]
    public const int WIA_DPS_TRANSPARENCY_CAPABILITIES = 3106;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPS_TRANSPARENCY_CAPABILITIES_STR"]/*' />
    [NativeTypeName("#define WIA_DPS_TRANSPARENCY_CAPABILITIES_STR L\"Transparency Adapter Capabilities\"")]
    public const string WIA_DPS_TRANSPARENCY_CAPABILITIES_STR = "Transparency Adapter Capabilities";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPS_TRANSPARENCY_STATUS"]/*' />
    [NativeTypeName("#define WIA_DPS_TRANSPARENCY_STATUS 3107")]
    public const int WIA_DPS_TRANSPARENCY_STATUS = 3107;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPS_TRANSPARENCY_STATUS_STR"]/*' />
    [NativeTypeName("#define WIA_DPS_TRANSPARENCY_STATUS_STR L\"Transparency Adapter Status\"")]
    public const string WIA_DPS_TRANSPARENCY_STATUS_STR = "Transparency Adapter Status";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPF_MOUNT_POINT"]/*' />
    [NativeTypeName("#define WIA_DPF_MOUNT_POINT 3330")]
    public const int WIA_DPF_MOUNT_POINT = 3330;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPF_MOUNT_POINT_STR"]/*' />
    [NativeTypeName("#define WIA_DPF_MOUNT_POINT_STR L\"Directory mount point\"")]
    public const string WIA_DPF_MOUNT_POINT_STR = "Directory mount point";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPV_LAST_PICTURE_TAKEN"]/*' />
    [NativeTypeName("#define WIA_DPV_LAST_PICTURE_TAKEN 3586")]
    public const int WIA_DPV_LAST_PICTURE_TAKEN = 3586;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPV_LAST_PICTURE_TAKEN_STR"]/*' />
    [NativeTypeName("#define WIA_DPV_LAST_PICTURE_TAKEN_STR L\"Last Picture Taken\"")]
    public const string WIA_DPV_LAST_PICTURE_TAKEN_STR = "Last Picture Taken";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPV_IMAGES_DIRECTORY"]/*' />
    [NativeTypeName("#define WIA_DPV_IMAGES_DIRECTORY 3587")]
    public const int WIA_DPV_IMAGES_DIRECTORY = 3587;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPV_IMAGES_DIRECTORY_STR"]/*' />
    [NativeTypeName("#define WIA_DPV_IMAGES_DIRECTORY_STR L\"Images Directory\"")]
    public const string WIA_DPV_IMAGES_DIRECTORY_STR = "Images Directory";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPV_DSHOW_DEVICE_PATH"]/*' />
    [NativeTypeName("#define WIA_DPV_DSHOW_DEVICE_PATH 3588")]
    public const int WIA_DPV_DSHOW_DEVICE_PATH = 3588;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPV_DSHOW_DEVICE_PATH_STR"]/*' />
    [NativeTypeName("#define WIA_DPV_DSHOW_DEVICE_PATH_STR L\"Directshow Device Path\"")]
    public const string WIA_DPV_DSHOW_DEVICE_PATH_STR = "Directshow Device Path";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPA_ITEM_NAME"]/*' />
    [NativeTypeName("#define WIA_IPA_ITEM_NAME 4098")]
    public const int WIA_IPA_ITEM_NAME = 4098;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPA_ITEM_NAME_STR"]/*' />
    [NativeTypeName("#define WIA_IPA_ITEM_NAME_STR L\"Item Name\"")]
    public const string WIA_IPA_ITEM_NAME_STR = "Item Name";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPA_FULL_ITEM_NAME"]/*' />
    [NativeTypeName("#define WIA_IPA_FULL_ITEM_NAME 4099")]
    public const int WIA_IPA_FULL_ITEM_NAME = 4099;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPA_FULL_ITEM_NAME_STR"]/*' />
    [NativeTypeName("#define WIA_IPA_FULL_ITEM_NAME_STR L\"Full Item Name\"")]
    public const string WIA_IPA_FULL_ITEM_NAME_STR = "Full Item Name";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPA_ITEM_TIME"]/*' />
    [NativeTypeName("#define WIA_IPA_ITEM_TIME 4100")]
    public const int WIA_IPA_ITEM_TIME = 4100;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPA_ITEM_TIME_STR"]/*' />
    [NativeTypeName("#define WIA_IPA_ITEM_TIME_STR L\"Item Time Stamp\"")]
    public const string WIA_IPA_ITEM_TIME_STR = "Item Time Stamp";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPA_ITEM_FLAGS"]/*' />
    [NativeTypeName("#define WIA_IPA_ITEM_FLAGS 4101")]
    public const int WIA_IPA_ITEM_FLAGS = 4101;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPA_ITEM_FLAGS_STR"]/*' />
    [NativeTypeName("#define WIA_IPA_ITEM_FLAGS_STR L\"Item Flags\"")]
    public const string WIA_IPA_ITEM_FLAGS_STR = "Item Flags";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPA_ACCESS_RIGHTS"]/*' />
    [NativeTypeName("#define WIA_IPA_ACCESS_RIGHTS 4102")]
    public const int WIA_IPA_ACCESS_RIGHTS = 4102;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPA_ACCESS_RIGHTS_STR"]/*' />
    [NativeTypeName("#define WIA_IPA_ACCESS_RIGHTS_STR L\"Access Rights\"")]
    public const string WIA_IPA_ACCESS_RIGHTS_STR = "Access Rights";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPA_DATATYPE"]/*' />
    [NativeTypeName("#define WIA_IPA_DATATYPE 4103")]
    public const int WIA_IPA_DATATYPE = 4103;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPA_DATATYPE_STR"]/*' />
    [NativeTypeName("#define WIA_IPA_DATATYPE_STR L\"Data Type\"")]
    public const string WIA_IPA_DATATYPE_STR = "Data Type";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPA_DEPTH"]/*' />
    [NativeTypeName("#define WIA_IPA_DEPTH 4104")]
    public const int WIA_IPA_DEPTH = 4104;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPA_DEPTH_STR"]/*' />
    [NativeTypeName("#define WIA_IPA_DEPTH_STR L\"Bits Per Pixel\"")]
    public const string WIA_IPA_DEPTH_STR = "Bits Per Pixel";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPA_PREFERRED_FORMAT"]/*' />
    [NativeTypeName("#define WIA_IPA_PREFERRED_FORMAT 4105")]
    public const int WIA_IPA_PREFERRED_FORMAT = 4105;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPA_PREFERRED_FORMAT_STR"]/*' />
    [NativeTypeName("#define WIA_IPA_PREFERRED_FORMAT_STR L\"Preferred Format\"")]
    public const string WIA_IPA_PREFERRED_FORMAT_STR = "Preferred Format";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPA_FORMAT"]/*' />
    [NativeTypeName("#define WIA_IPA_FORMAT 4106")]
    public const int WIA_IPA_FORMAT = 4106;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPA_FORMAT_STR"]/*' />
    [NativeTypeName("#define WIA_IPA_FORMAT_STR L\"Format\"")]
    public const string WIA_IPA_FORMAT_STR = "Format";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPA_COMPRESSION"]/*' />
    [NativeTypeName("#define WIA_IPA_COMPRESSION 4107")]
    public const int WIA_IPA_COMPRESSION = 4107;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPA_COMPRESSION_STR"]/*' />
    [NativeTypeName("#define WIA_IPA_COMPRESSION_STR L\"Compression\"")]
    public const string WIA_IPA_COMPRESSION_STR = "Compression";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPA_TYMED"]/*' />
    [NativeTypeName("#define WIA_IPA_TYMED 4108")]
    public const int WIA_IPA_TYMED = 4108;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPA_TYMED_STR"]/*' />
    [NativeTypeName("#define WIA_IPA_TYMED_STR L\"Media Type\"")]
    public const string WIA_IPA_TYMED_STR = "Media Type";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPA_CHANNELS_PER_PIXEL"]/*' />
    [NativeTypeName("#define WIA_IPA_CHANNELS_PER_PIXEL 4109")]
    public const int WIA_IPA_CHANNELS_PER_PIXEL = 4109;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPA_CHANNELS_PER_PIXEL_STR"]/*' />
    [NativeTypeName("#define WIA_IPA_CHANNELS_PER_PIXEL_STR L\"Channels Per Pixel\"")]
    public const string WIA_IPA_CHANNELS_PER_PIXEL_STR = "Channels Per Pixel";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPA_BITS_PER_CHANNEL"]/*' />
    [NativeTypeName("#define WIA_IPA_BITS_PER_CHANNEL 4110")]
    public const int WIA_IPA_BITS_PER_CHANNEL = 4110;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPA_BITS_PER_CHANNEL_STR"]/*' />
    [NativeTypeName("#define WIA_IPA_BITS_PER_CHANNEL_STR L\"Bits Per Channel\"")]
    public const string WIA_IPA_BITS_PER_CHANNEL_STR = "Bits Per Channel";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPA_PLANAR"]/*' />
    [NativeTypeName("#define WIA_IPA_PLANAR 4111")]
    public const int WIA_IPA_PLANAR = 4111;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPA_PLANAR_STR"]/*' />
    [NativeTypeName("#define WIA_IPA_PLANAR_STR L\"Planar\"")]
    public const string WIA_IPA_PLANAR_STR = "Planar";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPA_PIXELS_PER_LINE"]/*' />
    [NativeTypeName("#define WIA_IPA_PIXELS_PER_LINE 4112")]
    public const int WIA_IPA_PIXELS_PER_LINE = 4112;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPA_PIXELS_PER_LINE_STR"]/*' />
    [NativeTypeName("#define WIA_IPA_PIXELS_PER_LINE_STR L\"Pixels Per Line\"")]
    public const string WIA_IPA_PIXELS_PER_LINE_STR = "Pixels Per Line";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPA_BYTES_PER_LINE"]/*' />
    [NativeTypeName("#define WIA_IPA_BYTES_PER_LINE 4113")]
    public const int WIA_IPA_BYTES_PER_LINE = 4113;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPA_BYTES_PER_LINE_STR"]/*' />
    [NativeTypeName("#define WIA_IPA_BYTES_PER_LINE_STR L\"Bytes Per Line\"")]
    public const string WIA_IPA_BYTES_PER_LINE_STR = "Bytes Per Line";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPA_NUMBER_OF_LINES"]/*' />
    [NativeTypeName("#define WIA_IPA_NUMBER_OF_LINES 4114")]
    public const int WIA_IPA_NUMBER_OF_LINES = 4114;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPA_NUMBER_OF_LINES_STR"]/*' />
    [NativeTypeName("#define WIA_IPA_NUMBER_OF_LINES_STR L\"Number of Lines\"")]
    public const string WIA_IPA_NUMBER_OF_LINES_STR = "Number of Lines";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPA_GAMMA_CURVES"]/*' />
    [NativeTypeName("#define WIA_IPA_GAMMA_CURVES 4115")]
    public const int WIA_IPA_GAMMA_CURVES = 4115;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPA_GAMMA_CURVES_STR"]/*' />
    [NativeTypeName("#define WIA_IPA_GAMMA_CURVES_STR L\"Gamma Curves\"")]
    public const string WIA_IPA_GAMMA_CURVES_STR = "Gamma Curves";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPA_ITEM_SIZE"]/*' />
    [NativeTypeName("#define WIA_IPA_ITEM_SIZE 4116")]
    public const int WIA_IPA_ITEM_SIZE = 4116;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPA_ITEM_SIZE_STR"]/*' />
    [NativeTypeName("#define WIA_IPA_ITEM_SIZE_STR L\"Item Size\"")]
    public const string WIA_IPA_ITEM_SIZE_STR = "Item Size";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPA_COLOR_PROFILE"]/*' />
    [NativeTypeName("#define WIA_IPA_COLOR_PROFILE 4117")]
    public const int WIA_IPA_COLOR_PROFILE = 4117;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPA_COLOR_PROFILE_STR"]/*' />
    [NativeTypeName("#define WIA_IPA_COLOR_PROFILE_STR L\"Color Profiles\"")]
    public const string WIA_IPA_COLOR_PROFILE_STR = "Color Profiles";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPA_MIN_BUFFER_SIZE"]/*' />
    [NativeTypeName("#define WIA_IPA_MIN_BUFFER_SIZE 4118")]
    public const int WIA_IPA_MIN_BUFFER_SIZE = 4118;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPA_MIN_BUFFER_SIZE_STR"]/*' />
    [NativeTypeName("#define WIA_IPA_MIN_BUFFER_SIZE_STR L\"Buffer Size\"")]
    public const string WIA_IPA_MIN_BUFFER_SIZE_STR = "Buffer Size";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPA_BUFFER_SIZE"]/*' />
    [NativeTypeName("#define WIA_IPA_BUFFER_SIZE 4118")]
    public const int WIA_IPA_BUFFER_SIZE = 4118;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPA_BUFFER_SIZE_STR"]/*' />
    [NativeTypeName("#define WIA_IPA_BUFFER_SIZE_STR L\"Buffer Size\"")]
    public const string WIA_IPA_BUFFER_SIZE_STR = "Buffer Size";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPA_REGION_TYPE"]/*' />
    [NativeTypeName("#define WIA_IPA_REGION_TYPE 4119")]
    public const int WIA_IPA_REGION_TYPE = 4119;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPA_REGION_TYPE_STR"]/*' />
    [NativeTypeName("#define WIA_IPA_REGION_TYPE_STR L\"Region Type\"")]
    public const string WIA_IPA_REGION_TYPE_STR = "Region Type";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPA_ICM_PROFILE_NAME"]/*' />
    [NativeTypeName("#define WIA_IPA_ICM_PROFILE_NAME 4120")]
    public const int WIA_IPA_ICM_PROFILE_NAME = 4120;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPA_ICM_PROFILE_NAME_STR"]/*' />
    [NativeTypeName("#define WIA_IPA_ICM_PROFILE_NAME_STR L\"Color Profile Name\"")]
    public const string WIA_IPA_ICM_PROFILE_NAME_STR = "Color Profile Name";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPA_APP_COLOR_MAPPING"]/*' />
    [NativeTypeName("#define WIA_IPA_APP_COLOR_MAPPING 4121")]
    public const int WIA_IPA_APP_COLOR_MAPPING = 4121;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPA_APP_COLOR_MAPPING_STR"]/*' />
    [NativeTypeName("#define WIA_IPA_APP_COLOR_MAPPING_STR L\"Application Applies Color Mapping\"")]
    public const string WIA_IPA_APP_COLOR_MAPPING_STR = "Application Applies Color Mapping";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPA_PROP_STREAM_COMPAT_ID"]/*' />
    [NativeTypeName("#define WIA_IPA_PROP_STREAM_COMPAT_ID 4122")]
    public const int WIA_IPA_PROP_STREAM_COMPAT_ID = 4122;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPA_PROP_STREAM_COMPAT_ID_STR"]/*' />
    [NativeTypeName("#define WIA_IPA_PROP_STREAM_COMPAT_ID_STR L\"Stream Compatibility ID\"")]
    public const string WIA_IPA_PROP_STREAM_COMPAT_ID_STR = "Stream Compatibility ID";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPA_FILENAME_EXTENSION"]/*' />
    [NativeTypeName("#define WIA_IPA_FILENAME_EXTENSION 4123")]
    public const int WIA_IPA_FILENAME_EXTENSION = 4123;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPA_FILENAME_EXTENSION_STR"]/*' />
    [NativeTypeName("#define WIA_IPA_FILENAME_EXTENSION_STR L\"Filename extension\"")]
    public const string WIA_IPA_FILENAME_EXTENSION_STR = "Filename extension";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPA_SUPPRESS_PROPERTY_PAGE"]/*' />
    [NativeTypeName("#define WIA_IPA_SUPPRESS_PROPERTY_PAGE 4124")]
    public const int WIA_IPA_SUPPRESS_PROPERTY_PAGE = 4124;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPA_SUPPRESS_PROPERTY_PAGE_STR"]/*' />
    [NativeTypeName("#define WIA_IPA_SUPPRESS_PROPERTY_PAGE_STR L\"Suppress a property page\"")]
    public const string WIA_IPA_SUPPRESS_PROPERTY_PAGE_STR = "Suppress a property page";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPC_THUMBNAIL"]/*' />
    [NativeTypeName("#define WIA_IPC_THUMBNAIL 5122")]
    public const int WIA_IPC_THUMBNAIL = 5122;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPC_THUMBNAIL_STR"]/*' />
    [NativeTypeName("#define WIA_IPC_THUMBNAIL_STR L\"Thumbnail Data\"")]
    public const string WIA_IPC_THUMBNAIL_STR = "Thumbnail Data";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPC_THUMB_WIDTH"]/*' />
    [NativeTypeName("#define WIA_IPC_THUMB_WIDTH 5123")]
    public const int WIA_IPC_THUMB_WIDTH = 5123;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPC_THUMB_WIDTH_STR"]/*' />
    [NativeTypeName("#define WIA_IPC_THUMB_WIDTH_STR L\"Thumbnail Width\"")]
    public const string WIA_IPC_THUMB_WIDTH_STR = "Thumbnail Width";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPC_THUMB_HEIGHT"]/*' />
    [NativeTypeName("#define WIA_IPC_THUMB_HEIGHT 5124")]
    public const int WIA_IPC_THUMB_HEIGHT = 5124;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPC_THUMB_HEIGHT_STR"]/*' />
    [NativeTypeName("#define WIA_IPC_THUMB_HEIGHT_STR L\"Thumbnail Height\"")]
    public const string WIA_IPC_THUMB_HEIGHT_STR = "Thumbnail Height";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPC_AUDIO_AVAILABLE"]/*' />
    [NativeTypeName("#define WIA_IPC_AUDIO_AVAILABLE 5125")]
    public const int WIA_IPC_AUDIO_AVAILABLE = 5125;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPC_AUDIO_AVAILABLE_STR"]/*' />
    [NativeTypeName("#define WIA_IPC_AUDIO_AVAILABLE_STR L\"Audio Available\"")]
    public const string WIA_IPC_AUDIO_AVAILABLE_STR = "Audio Available";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPC_AUDIO_DATA_FORMAT"]/*' />
    [NativeTypeName("#define WIA_IPC_AUDIO_DATA_FORMAT 5126")]
    public const int WIA_IPC_AUDIO_DATA_FORMAT = 5126;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPC_AUDIO_DATA_FORMAT_STR"]/*' />
    [NativeTypeName("#define WIA_IPC_AUDIO_DATA_FORMAT_STR L\"Audio Format\"")]
    public const string WIA_IPC_AUDIO_DATA_FORMAT_STR = "Audio Format";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPC_AUDIO_DATA"]/*' />
    [NativeTypeName("#define WIA_IPC_AUDIO_DATA 5127")]
    public const int WIA_IPC_AUDIO_DATA = 5127;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPC_AUDIO_DATA_STR"]/*' />
    [NativeTypeName("#define WIA_IPC_AUDIO_DATA_STR L\"Audio Data\"")]
    public const string WIA_IPC_AUDIO_DATA_STR = "Audio Data";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPC_NUM_PICT_PER_ROW"]/*' />
    [NativeTypeName("#define WIA_IPC_NUM_PICT_PER_ROW 5128")]
    public const int WIA_IPC_NUM_PICT_PER_ROW = 5128;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPC_NUM_PICT_PER_ROW_STR"]/*' />
    [NativeTypeName("#define WIA_IPC_NUM_PICT_PER_ROW_STR L\"Pictures per Row\"")]
    public const string WIA_IPC_NUM_PICT_PER_ROW_STR = "Pictures per Row";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPC_SEQUENCE"]/*' />
    [NativeTypeName("#define WIA_IPC_SEQUENCE 5129")]
    public const int WIA_IPC_SEQUENCE = 5129;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPC_SEQUENCE_STR"]/*' />
    [NativeTypeName("#define WIA_IPC_SEQUENCE_STR L\"Sequence Number\"")]
    public const string WIA_IPC_SEQUENCE_STR = "Sequence Number";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPC_TIMEDELAY"]/*' />
    [NativeTypeName("#define WIA_IPC_TIMEDELAY 5130")]
    public const int WIA_IPC_TIMEDELAY = 5130;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPC_TIMEDELAY_STR"]/*' />
    [NativeTypeName("#define WIA_IPC_TIMEDELAY_STR L\"Time Delay\"")]
    public const string WIA_IPC_TIMEDELAY_STR = "Time Delay";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_CUR_INTENT"]/*' />
    [NativeTypeName("#define WIA_IPS_CUR_INTENT 6146")]
    public const int WIA_IPS_CUR_INTENT = 6146;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_CUR_INTENT_STR"]/*' />
    [NativeTypeName("#define WIA_IPS_CUR_INTENT_STR L\"Current Intent\"")]
    public const string WIA_IPS_CUR_INTENT_STR = "Current Intent";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_XRES"]/*' />
    [NativeTypeName("#define WIA_IPS_XRES 6147")]
    public const int WIA_IPS_XRES = 6147;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_XRES_STR"]/*' />
    [NativeTypeName("#define WIA_IPS_XRES_STR L\"Horizontal Resolution\"")]
    public const string WIA_IPS_XRES_STR = "Horizontal Resolution";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_YRES"]/*' />
    [NativeTypeName("#define WIA_IPS_YRES 6148")]
    public const int WIA_IPS_YRES = 6148;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_YRES_STR"]/*' />
    [NativeTypeName("#define WIA_IPS_YRES_STR L\"Vertical Resolution\"")]
    public const string WIA_IPS_YRES_STR = "Vertical Resolution";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_XPOS"]/*' />
    [NativeTypeName("#define WIA_IPS_XPOS 6149")]
    public const int WIA_IPS_XPOS = 6149;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_XPOS_STR"]/*' />
    [NativeTypeName("#define WIA_IPS_XPOS_STR L\"Horizontal Start Position\"")]
    public const string WIA_IPS_XPOS_STR = "Horizontal Start Position";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_YPOS"]/*' />
    [NativeTypeName("#define WIA_IPS_YPOS 6150")]
    public const int WIA_IPS_YPOS = 6150;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_YPOS_STR"]/*' />
    [NativeTypeName("#define WIA_IPS_YPOS_STR L\"Vertical Start Position\"")]
    public const string WIA_IPS_YPOS_STR = "Vertical Start Position";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_XEXTENT"]/*' />
    [NativeTypeName("#define WIA_IPS_XEXTENT 6151")]
    public const int WIA_IPS_XEXTENT = 6151;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_XEXTENT_STR"]/*' />
    [NativeTypeName("#define WIA_IPS_XEXTENT_STR L\"Horizontal Extent\"")]
    public const string WIA_IPS_XEXTENT_STR = "Horizontal Extent";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_YEXTENT"]/*' />
    [NativeTypeName("#define WIA_IPS_YEXTENT 6152")]
    public const int WIA_IPS_YEXTENT = 6152;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_YEXTENT_STR"]/*' />
    [NativeTypeName("#define WIA_IPS_YEXTENT_STR L\"Vertical Extent\"")]
    public const string WIA_IPS_YEXTENT_STR = "Vertical Extent";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_PHOTOMETRIC_INTERP"]/*' />
    [NativeTypeName("#define WIA_IPS_PHOTOMETRIC_INTERP 6153")]
    public const int WIA_IPS_PHOTOMETRIC_INTERP = 6153;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_PHOTOMETRIC_INTERP_STR"]/*' />
    [NativeTypeName("#define WIA_IPS_PHOTOMETRIC_INTERP_STR L\"Photometric Interpretation\"")]
    public const string WIA_IPS_PHOTOMETRIC_INTERP_STR = "Photometric Interpretation";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_BRIGHTNESS"]/*' />
    [NativeTypeName("#define WIA_IPS_BRIGHTNESS 6154")]
    public const int WIA_IPS_BRIGHTNESS = 6154;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_BRIGHTNESS_STR"]/*' />
    [NativeTypeName("#define WIA_IPS_BRIGHTNESS_STR L\"Brightness\"")]
    public const string WIA_IPS_BRIGHTNESS_STR = "Brightness";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_CONTRAST"]/*' />
    [NativeTypeName("#define WIA_IPS_CONTRAST 6155")]
    public const int WIA_IPS_CONTRAST = 6155;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_CONTRAST_STR"]/*' />
    [NativeTypeName("#define WIA_IPS_CONTRAST_STR L\"Contrast\"")]
    public const string WIA_IPS_CONTRAST_STR = "Contrast";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_ORIENTATION"]/*' />
    [NativeTypeName("#define WIA_IPS_ORIENTATION 6156")]
    public const int WIA_IPS_ORIENTATION = 6156;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_ORIENTATION_STR"]/*' />
    [NativeTypeName("#define WIA_IPS_ORIENTATION_STR L\"Orientation\"")]
    public const string WIA_IPS_ORIENTATION_STR = "Orientation";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_ROTATION"]/*' />
    [NativeTypeName("#define WIA_IPS_ROTATION 6157")]
    public const int WIA_IPS_ROTATION = 6157;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_ROTATION_STR"]/*' />
    [NativeTypeName("#define WIA_IPS_ROTATION_STR L\"Rotation\"")]
    public const string WIA_IPS_ROTATION_STR = "Rotation";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_MIRROR"]/*' />
    [NativeTypeName("#define WIA_IPS_MIRROR 6158")]
    public const int WIA_IPS_MIRROR = 6158;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_MIRROR_STR"]/*' />
    [NativeTypeName("#define WIA_IPS_MIRROR_STR L\"Mirror\"")]
    public const string WIA_IPS_MIRROR_STR = "Mirror";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_THRESHOLD"]/*' />
    [NativeTypeName("#define WIA_IPS_THRESHOLD 6159")]
    public const int WIA_IPS_THRESHOLD = 6159;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_THRESHOLD_STR"]/*' />
    [NativeTypeName("#define WIA_IPS_THRESHOLD_STR L\"Threshold\"")]
    public const string WIA_IPS_THRESHOLD_STR = "Threshold";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_INVERT"]/*' />
    [NativeTypeName("#define WIA_IPS_INVERT 6160")]
    public const int WIA_IPS_INVERT = 6160;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_INVERT_STR"]/*' />
    [NativeTypeName("#define WIA_IPS_INVERT_STR L\"Invert\"")]
    public const string WIA_IPS_INVERT_STR = "Invert";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_WARM_UP_TIME"]/*' />
    [NativeTypeName("#define WIA_IPS_WARM_UP_TIME 6161")]
    public const int WIA_IPS_WARM_UP_TIME = 6161;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_WARM_UP_TIME_STR"]/*' />
    [NativeTypeName("#define WIA_IPS_WARM_UP_TIME_STR L\"Lamp Warm up Time\"")]
    public const string WIA_IPS_WARM_UP_TIME_STR = "Lamp Warm up Time";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPS_USER_NAME"]/*' />
    [NativeTypeName("#define WIA_DPS_USER_NAME 3112")]
    public const int WIA_DPS_USER_NAME = 3112;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPS_USER_NAME_STR"]/*' />
    [NativeTypeName("#define WIA_DPS_USER_NAME_STR L\"User Name\"")]
    public const string WIA_DPS_USER_NAME_STR = "User Name";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPS_SERVICE_ID"]/*' />
    [NativeTypeName("#define WIA_DPS_SERVICE_ID 3113")]
    public const int WIA_DPS_SERVICE_ID = 3113;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPS_SERVICE_ID_STR"]/*' />
    [NativeTypeName("#define WIA_DPS_SERVICE_ID_STR L\"Service ID\"")]
    public const string WIA_DPS_SERVICE_ID_STR = "Service ID";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPS_DEVICE_ID"]/*' />
    [NativeTypeName("#define WIA_DPS_DEVICE_ID 3114")]
    public const int WIA_DPS_DEVICE_ID = 3114;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPS_DEVICE_ID_STR"]/*' />
    [NativeTypeName("#define WIA_DPS_DEVICE_ID_STR L\"Device ID\"")]
    public const string WIA_DPS_DEVICE_ID_STR = "Device ID";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPS_GLOBAL_IDENTITY"]/*' />
    [NativeTypeName("#define WIA_DPS_GLOBAL_IDENTITY 3115")]
    public const int WIA_DPS_GLOBAL_IDENTITY = 3115;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPS_GLOBAL_IDENTITY_STR"]/*' />
    [NativeTypeName("#define WIA_DPS_GLOBAL_IDENTITY_STR L\"Global Identity\"")]
    public const string WIA_DPS_GLOBAL_IDENTITY_STR = "Global Identity";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPS_SCAN_AVAILABLE_ITEM"]/*' />
    [NativeTypeName("#define WIA_DPS_SCAN_AVAILABLE_ITEM 3116")]
    public const int WIA_DPS_SCAN_AVAILABLE_ITEM = 3116;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPS_SCAN_AVAILABLE_ITEM_STR"]/*' />
    [NativeTypeName("#define WIA_DPS_SCAN_AVAILABLE_ITEM_STR L\"Scan Available Item\"")]
    public const string WIA_DPS_SCAN_AVAILABLE_ITEM_STR = "Scan Available Item";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_DESKEW_X"]/*' />
    [NativeTypeName("#define WIA_IPS_DESKEW_X 6162")]
    public const int WIA_IPS_DESKEW_X = 6162;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_DESKEW_X_STR"]/*' />
    [NativeTypeName("#define WIA_IPS_DESKEW_X_STR L\"DeskewX\"")]
    public const string WIA_IPS_DESKEW_X_STR = "DeskewX";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_DESKEW_Y"]/*' />
    [NativeTypeName("#define WIA_IPS_DESKEW_Y 6163")]
    public const int WIA_IPS_DESKEW_Y = 6163;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_DESKEW_Y_STR"]/*' />
    [NativeTypeName("#define WIA_IPS_DESKEW_Y_STR L\"DeskewY\"")]
    public const string WIA_IPS_DESKEW_Y_STR = "DeskewY";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_SEGMENTATION"]/*' />
    [NativeTypeName("#define WIA_IPS_SEGMENTATION 6164")]
    public const int WIA_IPS_SEGMENTATION = 6164;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_SEGMENTATION_STR"]/*' />
    [NativeTypeName("#define WIA_IPS_SEGMENTATION_STR L\"Segmentation\"")]
    public const string WIA_IPS_SEGMENTATION_STR = "Segmentation";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_SEGMENTATION_FILTER_STR"]/*' />
    [NativeTypeName("#define WIA_SEGMENTATION_FILTER_STR L\"SegmentationFilter\"")]
    public const string WIA_SEGMENTATION_FILTER_STR = "SegmentationFilter";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IMAGEPROC_FILTER_STR"]/*' />
    [NativeTypeName("#define WIA_IMAGEPROC_FILTER_STR L\"ImageProcessingFilter\"")]
    public const string WIA_IMAGEPROC_FILTER_STR = "ImageProcessingFilter";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_MAX_HORIZONTAL_SIZE"]/*' />
    [NativeTypeName("#define WIA_IPS_MAX_HORIZONTAL_SIZE 6165")]
    public const int WIA_IPS_MAX_HORIZONTAL_SIZE = 6165;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_MAX_HORIZONTAL_SIZE_STR"]/*' />
    [NativeTypeName("#define WIA_IPS_MAX_HORIZONTAL_SIZE_STR L\"Maximum Horizontal Scan Size\"")]
    public const string WIA_IPS_MAX_HORIZONTAL_SIZE_STR = "Maximum Horizontal Scan Size";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_MAX_VERTICAL_SIZE"]/*' />
    [NativeTypeName("#define WIA_IPS_MAX_VERTICAL_SIZE 6166")]
    public const int WIA_IPS_MAX_VERTICAL_SIZE = 6166;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_MAX_VERTICAL_SIZE_STR"]/*' />
    [NativeTypeName("#define WIA_IPS_MAX_VERTICAL_SIZE_STR L\"Maximum Vertical Scan Size\"")]
    public const string WIA_IPS_MAX_VERTICAL_SIZE_STR = "Maximum Vertical Scan Size";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_MIN_HORIZONTAL_SIZE"]/*' />
    [NativeTypeName("#define WIA_IPS_MIN_HORIZONTAL_SIZE 6167")]
    public const int WIA_IPS_MIN_HORIZONTAL_SIZE = 6167;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_MIN_HORIZONTAL_SIZE_STR"]/*' />
    [NativeTypeName("#define WIA_IPS_MIN_HORIZONTAL_SIZE_STR L\"Minimum Horizontal Scan Size\"")]
    public const string WIA_IPS_MIN_HORIZONTAL_SIZE_STR = "Minimum Horizontal Scan Size";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_MIN_VERTICAL_SIZE"]/*' />
    [NativeTypeName("#define WIA_IPS_MIN_VERTICAL_SIZE 6168")]
    public const int WIA_IPS_MIN_VERTICAL_SIZE = 6168;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_MIN_VERTICAL_SIZE_STR"]/*' />
    [NativeTypeName("#define WIA_IPS_MIN_VERTICAL_SIZE_STR L\"Minimum Vertical Scan Size\"")]
    public const string WIA_IPS_MIN_VERTICAL_SIZE_STR = "Minimum Vertical Scan Size";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_TRANSFER_CAPABILITIES"]/*' />
    [NativeTypeName("#define WIA_IPS_TRANSFER_CAPABILITIES 6169")]
    public const int WIA_IPS_TRANSFER_CAPABILITIES = 6169;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_TRANSFER_CAPABILITIES_STR"]/*' />
    [NativeTypeName("#define WIA_IPS_TRANSFER_CAPABILITIES_STR L\"Transfer Capabilities\"")]
    public const string WIA_IPS_TRANSFER_CAPABILITIES_STR = "Transfer Capabilities";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_SHEET_FEEDER_REGISTRATION"]/*' />
    [NativeTypeName("#define WIA_IPS_SHEET_FEEDER_REGISTRATION 3078")]
    public const int WIA_IPS_SHEET_FEEDER_REGISTRATION = 3078;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_SHEET_FEEDER_REGISTRATION_STR"]/*' />
    [NativeTypeName("#define WIA_IPS_SHEET_FEEDER_REGISTRATION_STR L\"Sheet Feeder Registration\"")]
    public const string WIA_IPS_SHEET_FEEDER_REGISTRATION_STR = "Sheet Feeder Registration";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_DOCUMENT_HANDLING_SELECT"]/*' />
    [NativeTypeName("#define WIA_IPS_DOCUMENT_HANDLING_SELECT 3088")]
    public const int WIA_IPS_DOCUMENT_HANDLING_SELECT = 3088;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_DOCUMENT_HANDLING_SELECT_STR"]/*' />
    [NativeTypeName("#define WIA_IPS_DOCUMENT_HANDLING_SELECT_STR L\"Document Handling Select\"")]
    public const string WIA_IPS_DOCUMENT_HANDLING_SELECT_STR = "Document Handling Select";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_OPTICAL_XRES"]/*' />
    [NativeTypeName("#define WIA_IPS_OPTICAL_XRES 3090")]
    public const int WIA_IPS_OPTICAL_XRES = 3090;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_OPTICAL_XRES_STR"]/*' />
    [NativeTypeName("#define WIA_IPS_OPTICAL_XRES_STR L\"Horizontal Optical Resolution\"")]
    public const string WIA_IPS_OPTICAL_XRES_STR = "Horizontal Optical Resolution";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_OPTICAL_YRES"]/*' />
    [NativeTypeName("#define WIA_IPS_OPTICAL_YRES 3091")]
    public const int WIA_IPS_OPTICAL_YRES = 3091;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_OPTICAL_YRES_STR"]/*' />
    [NativeTypeName("#define WIA_IPS_OPTICAL_YRES_STR L\"Vertical Optical Resolution\"")]
    public const string WIA_IPS_OPTICAL_YRES_STR = "Vertical Optical Resolution";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_PAGES"]/*' />
    [NativeTypeName("#define WIA_IPS_PAGES 3096")]
    public const int WIA_IPS_PAGES = 3096;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_PAGES_STR"]/*' />
    [NativeTypeName("#define WIA_IPS_PAGES_STR L\"Pages\"")]
    public const string WIA_IPS_PAGES_STR = "Pages";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_PAGE_SIZE"]/*' />
    [NativeTypeName("#define WIA_IPS_PAGE_SIZE 3097")]
    public const int WIA_IPS_PAGE_SIZE = 3097;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_PAGE_SIZE_STR"]/*' />
    [NativeTypeName("#define WIA_IPS_PAGE_SIZE_STR L\"Page Size\"")]
    public const string WIA_IPS_PAGE_SIZE_STR = "Page Size";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_PAGE_WIDTH"]/*' />
    [NativeTypeName("#define WIA_IPS_PAGE_WIDTH 3098")]
    public const int WIA_IPS_PAGE_WIDTH = 3098;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_PAGE_WIDTH_STR"]/*' />
    [NativeTypeName("#define WIA_IPS_PAGE_WIDTH_STR L\"Page Width\"")]
    public const string WIA_IPS_PAGE_WIDTH_STR = "Page Width";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_PAGE_HEIGHT"]/*' />
    [NativeTypeName("#define WIA_IPS_PAGE_HEIGHT 3099")]
    public const int WIA_IPS_PAGE_HEIGHT = 3099;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_PAGE_HEIGHT_STR"]/*' />
    [NativeTypeName("#define WIA_IPS_PAGE_HEIGHT_STR L\"Page Height\"")]
    public const string WIA_IPS_PAGE_HEIGHT_STR = "Page Height";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_PREVIEW"]/*' />
    [NativeTypeName("#define WIA_IPS_PREVIEW 3100")]
    public const int WIA_IPS_PREVIEW = 3100;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_PREVIEW_STR"]/*' />
    [NativeTypeName("#define WIA_IPS_PREVIEW_STR L\"Preview\"")]
    public const string WIA_IPS_PREVIEW_STR = "Preview";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_SHOW_PREVIEW_CONTROL"]/*' />
    [NativeTypeName("#define WIA_IPS_SHOW_PREVIEW_CONTROL 3103")]
    public const int WIA_IPS_SHOW_PREVIEW_CONTROL = 3103;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_SHOW_PREVIEW_CONTROL_STR"]/*' />
    [NativeTypeName("#define WIA_IPS_SHOW_PREVIEW_CONTROL_STR L\"Show preview control\"")]
    public const string WIA_IPS_SHOW_PREVIEW_CONTROL_STR = "Show preview control";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_FILM_SCAN_MODE"]/*' />
    [NativeTypeName("#define WIA_IPS_FILM_SCAN_MODE 3104")]
    public const int WIA_IPS_FILM_SCAN_MODE = 3104;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_FILM_SCAN_MODE_STR"]/*' />
    [NativeTypeName("#define WIA_IPS_FILM_SCAN_MODE_STR L\"Film Scan Mode\"")]
    public const string WIA_IPS_FILM_SCAN_MODE_STR = "Film Scan Mode";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_LAMP"]/*' />
    [NativeTypeName("#define WIA_IPS_LAMP 3105")]
    public const int WIA_IPS_LAMP = 3105;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_LAMP_STR"]/*' />
    [NativeTypeName("#define WIA_IPS_LAMP_STR L\"Lamp\"")]
    public const string WIA_IPS_LAMP_STR = "Lamp";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_LAMP_AUTO_OFF"]/*' />
    [NativeTypeName("#define WIA_IPS_LAMP_AUTO_OFF 3106")]
    public const int WIA_IPS_LAMP_AUTO_OFF = 3106;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_LAMP_AUTO_OFF_STR"]/*' />
    [NativeTypeName("#define WIA_IPS_LAMP_AUTO_OFF_STR L\"Lamp Auto Off\"")]
    public const string WIA_IPS_LAMP_AUTO_OFF_STR = "Lamp Auto Off";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_AUTO_DESKEW"]/*' />
    [NativeTypeName("#define WIA_IPS_AUTO_DESKEW 3107")]
    public const int WIA_IPS_AUTO_DESKEW = 3107;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_AUTO_DESKEW_STR"]/*' />
    [NativeTypeName("#define WIA_IPS_AUTO_DESKEW_STR L\"Automatic Deskew\"")]
    public const string WIA_IPS_AUTO_DESKEW_STR = "Automatic Deskew";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_SUPPORTS_CHILD_ITEM_CREATION"]/*' />
    [NativeTypeName("#define WIA_IPS_SUPPORTS_CHILD_ITEM_CREATION 3108")]
    public const int WIA_IPS_SUPPORTS_CHILD_ITEM_CREATION = 3108;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_SUPPORTS_CHILD_ITEM_CREATION_STR"]/*' />
    [NativeTypeName("#define WIA_IPS_SUPPORTS_CHILD_ITEM_CREATION_STR L\"Supports Child Item Creation\"")]
    public const string WIA_IPS_SUPPORTS_CHILD_ITEM_CREATION_STR = "Supports Child Item Creation";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_XSCALING"]/*' />
    [NativeTypeName("#define WIA_IPS_XSCALING 3109")]
    public const int WIA_IPS_XSCALING = 3109;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_XSCALING_STR"]/*' />
    [NativeTypeName("#define WIA_IPS_XSCALING_STR L\"Horizontal Scaling\"")]
    public const string WIA_IPS_XSCALING_STR = "Horizontal Scaling";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_YSCALING"]/*' />
    [NativeTypeName("#define WIA_IPS_YSCALING 3110")]
    public const int WIA_IPS_YSCALING = 3110;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_YSCALING_STR"]/*' />
    [NativeTypeName("#define WIA_IPS_YSCALING_STR L\"Vertical Scaling\"")]
    public const string WIA_IPS_YSCALING_STR = "Vertical Scaling";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_PREVIEW_TYPE"]/*' />
    [NativeTypeName("#define WIA_IPS_PREVIEW_TYPE 3111")]
    public const int WIA_IPS_PREVIEW_TYPE = 3111;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_PREVIEW_TYPE_STR"]/*' />
    [NativeTypeName("#define WIA_IPS_PREVIEW_TYPE_STR L\"Preview Type\"")]
    public const string WIA_IPS_PREVIEW_TYPE_STR = "Preview Type";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPA_ITEM_CATEGORY"]/*' />
    [NativeTypeName("#define WIA_IPA_ITEM_CATEGORY 4125")]
    public const int WIA_IPA_ITEM_CATEGORY = 4125;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPA_ITEM_CATEGORY_STR"]/*' />
    [NativeTypeName("#define WIA_IPA_ITEM_CATEGORY_STR L\"Item Category\"")]
    public const string WIA_IPA_ITEM_CATEGORY_STR = "Item Category";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPA_UPLOAD_ITEM_SIZE"]/*' />
    [NativeTypeName("#define WIA_IPA_UPLOAD_ITEM_SIZE 4126")]
    public const int WIA_IPA_UPLOAD_ITEM_SIZE = 4126;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPA_UPLOAD_ITEM_SIZE_STR"]/*' />
    [NativeTypeName("#define WIA_IPA_UPLOAD_ITEM_SIZE_STR L\"Upload Item Size\"")]
    public const string WIA_IPA_UPLOAD_ITEM_SIZE_STR = "Upload Item Size";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPA_ITEMS_STORED"]/*' />
    [NativeTypeName("#define WIA_IPA_ITEMS_STORED 4127")]
    public const int WIA_IPA_ITEMS_STORED = 4127;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPA_ITEMS_STORED_STR"]/*' />
    [NativeTypeName("#define WIA_IPA_ITEMS_STORED_STR L\"Items Stored\"")]
    public const string WIA_IPA_ITEMS_STORED_STR = "Items Stored";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPA_RAW_BITS_PER_CHANNEL"]/*' />
    [NativeTypeName("#define WIA_IPA_RAW_BITS_PER_CHANNEL 4128")]
    public const int WIA_IPA_RAW_BITS_PER_CHANNEL = 4128;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPA_RAW_BITS_PER_CHANNEL_STR"]/*' />
    [NativeTypeName("#define WIA_IPA_RAW_BITS_PER_CHANNEL_STR L\"Raw Bits Per Channel\"")]
    public const string WIA_IPA_RAW_BITS_PER_CHANNEL_STR = "Raw Bits Per Channel";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_FILM_NODE_NAME"]/*' />
    [NativeTypeName("#define WIA_IPS_FILM_NODE_NAME 4129")]
    public const int WIA_IPS_FILM_NODE_NAME = 4129;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_FILM_NODE_NAME_STR"]/*' />
    [NativeTypeName("#define WIA_IPS_FILM_NODE_NAME_STR L\"Film Node Name\"")]
    public const string WIA_IPS_FILM_NODE_NAME_STR = "Film Node Name";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_PRINTER_ENDORSER"]/*' />
    [NativeTypeName("#define WIA_IPS_PRINTER_ENDORSER 4130")]
    public const int WIA_IPS_PRINTER_ENDORSER = 4130;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_PRINTER_ENDORSER_STR"]/*' />
    [NativeTypeName("#define WIA_IPS_PRINTER_ENDORSER_STR L\"Printer/Endorser\"")]
    public const string WIA_IPS_PRINTER_ENDORSER_STR = "Printer/Endorser";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_PRINTER_ENDORSER_ORDER"]/*' />
    [NativeTypeName("#define WIA_IPS_PRINTER_ENDORSER_ORDER 4131")]
    public const int WIA_IPS_PRINTER_ENDORSER_ORDER = 4131;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_PRINTER_ENDORSER_ORDER_STR"]/*' />
    [NativeTypeName("#define WIA_IPS_PRINTER_ENDORSER_ORDER_STR L\"Printer/Endorser Order\"")]
    public const string WIA_IPS_PRINTER_ENDORSER_ORDER_STR = "Printer/Endorser Order";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_PRINTER_ENDORSER_COUNTER"]/*' />
    [NativeTypeName("#define WIA_IPS_PRINTER_ENDORSER_COUNTER 4132")]
    public const int WIA_IPS_PRINTER_ENDORSER_COUNTER = 4132;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_PRINTER_ENDORSER_COUNTER_STR"]/*' />
    [NativeTypeName("#define WIA_IPS_PRINTER_ENDORSER_COUNTER_STR L\"Printer/Endorser Counter\"")]
    public const string WIA_IPS_PRINTER_ENDORSER_COUNTER_STR = "Printer/Endorser Counter";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_PRINTER_ENDORSER_STEP"]/*' />
    [NativeTypeName("#define WIA_IPS_PRINTER_ENDORSER_STEP 4133")]
    public const int WIA_IPS_PRINTER_ENDORSER_STEP = 4133;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_PRINTER_ENDORSER_STEP_STR"]/*' />
    [NativeTypeName("#define WIA_IPS_PRINTER_ENDORSER_STEP_STR L\"Printer/Endorser Step\"")]
    public const string WIA_IPS_PRINTER_ENDORSER_STEP_STR = "Printer/Endorser Step";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_PRINTER_ENDORSER_XOFFSET"]/*' />
    [NativeTypeName("#define WIA_IPS_PRINTER_ENDORSER_XOFFSET 4134")]
    public const int WIA_IPS_PRINTER_ENDORSER_XOFFSET = 4134;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_PRINTER_ENDORSER_XOFFSET_STR"]/*' />
    [NativeTypeName("#define WIA_IPS_PRINTER_ENDORSER_XOFFSET_STR L\"Printer/Endorser Horizontal Offset\"")]
    public const string WIA_IPS_PRINTER_ENDORSER_XOFFSET_STR = "Printer/Endorser Horizontal Offset";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_PRINTER_ENDORSER_YOFFSET"]/*' />
    [NativeTypeName("#define WIA_IPS_PRINTER_ENDORSER_YOFFSET 4135")]
    public const int WIA_IPS_PRINTER_ENDORSER_YOFFSET = 4135;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_PRINTER_ENDORSER_YOFFSET_STR"]/*' />
    [NativeTypeName("#define WIA_IPS_PRINTER_ENDORSER_YOFFSET_STR L\"Printer/Endorser Vertical Offset\"")]
    public const string WIA_IPS_PRINTER_ENDORSER_YOFFSET_STR = "Printer/Endorser Vertical Offset";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_PRINTER_ENDORSER_NUM_LINES"]/*' />
    [NativeTypeName("#define WIA_IPS_PRINTER_ENDORSER_NUM_LINES 4136")]
    public const int WIA_IPS_PRINTER_ENDORSER_NUM_LINES = 4136;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_PRINTER_ENDORSER_NUM_LINES_STR"]/*' />
    [NativeTypeName("#define WIA_IPS_PRINTER_ENDORSER_NUM_LINES_STR L\"Printer/Endorser Lines\"")]
    public const string WIA_IPS_PRINTER_ENDORSER_NUM_LINES_STR = "Printer/Endorser Lines";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_PRINTER_ENDORSER_STRING"]/*' />
    [NativeTypeName("#define WIA_IPS_PRINTER_ENDORSER_STRING 4137")]
    public const int WIA_IPS_PRINTER_ENDORSER_STRING = 4137;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_PRINTER_ENDORSER_STRING_STR"]/*' />
    [NativeTypeName("#define WIA_IPS_PRINTER_ENDORSER_STRING_STR L\"Printer/Endorser String\"")]
    public const string WIA_IPS_PRINTER_ENDORSER_STRING_STR = "Printer/Endorser String";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_PRINTER_ENDORSER_VALID_CHARACTERS"]/*' />
    [NativeTypeName("#define WIA_IPS_PRINTER_ENDORSER_VALID_CHARACTERS 4138")]
    public const int WIA_IPS_PRINTER_ENDORSER_VALID_CHARACTERS = 4138;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_PRINTER_ENDORSER_VALID_CHARACTERS_STR"]/*' />
    [NativeTypeName("#define WIA_IPS_PRINTER_ENDORSER_VALID_CHARACTERS_STR L\"Printer/Endorser Valid Characters\"")]
    public const string WIA_IPS_PRINTER_ENDORSER_VALID_CHARACTERS_STR = "Printer/Endorser Valid Characters";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_PRINTER_ENDORSER_VALID_FORMAT_SPECIFIERS"]/*' />
    [NativeTypeName("#define WIA_IPS_PRINTER_ENDORSER_VALID_FORMAT_SPECIFIERS 4139")]
    public const int WIA_IPS_PRINTER_ENDORSER_VALID_FORMAT_SPECIFIERS = 4139;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_PRINTER_ENDORSER_VALID_FORMAT_SPECIFIERS_STR"]/*' />
    [NativeTypeName("#define WIA_IPS_PRINTER_ENDORSER_VALID_FORMAT_SPECIFIERS_STR L\"Printer/Endorser Valid Format Specifiers\"")]
    public const string WIA_IPS_PRINTER_ENDORSER_VALID_FORMAT_SPECIFIERS_STR = "Printer/Endorser Valid Format Specifiers";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_PRINTER_ENDORSER_TEXT_UPLOAD"]/*' />
    [NativeTypeName("#define WIA_IPS_PRINTER_ENDORSER_TEXT_UPLOAD 4140")]
    public const int WIA_IPS_PRINTER_ENDORSER_TEXT_UPLOAD = 4140;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_PRINTER_ENDORSER_TEXT_UPLOAD_STR"]/*' />
    [NativeTypeName("#define WIA_IPS_PRINTER_ENDORSER_TEXT_UPLOAD_STR L\"Printer/Endorser Text Upload\"")]
    public const string WIA_IPS_PRINTER_ENDORSER_TEXT_UPLOAD_STR = "Printer/Endorser Text Upload";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_PRINTER_ENDORSER_TEXT_DOWNLOAD"]/*' />
    [NativeTypeName("#define WIA_IPS_PRINTER_ENDORSER_TEXT_DOWNLOAD 4141")]
    public const int WIA_IPS_PRINTER_ENDORSER_TEXT_DOWNLOAD = 4141;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_PRINTER_ENDORSER_TEXT_DOWNLOAD_STR"]/*' />
    [NativeTypeName("#define WIA_IPS_PRINTER_ENDORSER_TEXT_DOWNLOAD_STR L\"Printer/Endorser Text Download\"")]
    public const string WIA_IPS_PRINTER_ENDORSER_TEXT_DOWNLOAD_STR = "Printer/Endorser Text Download";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_PRINTER_ENDORSER_GRAPHICS"]/*' />
    [NativeTypeName("#define WIA_IPS_PRINTER_ENDORSER_GRAPHICS 4142")]
    public const int WIA_IPS_PRINTER_ENDORSER_GRAPHICS = 4142;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_PRINTER_ENDORSER_GRAPHICS_STR"]/*' />
    [NativeTypeName("#define WIA_IPS_PRINTER_ENDORSER_GRAPHICS_STR L\"Printer/Endorser Graphics\"")]
    public const string WIA_IPS_PRINTER_ENDORSER_GRAPHICS_STR = "Printer/Endorser Graphics";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_PRINTER_ENDORSER_GRAPHICS_POSITION"]/*' />
    [NativeTypeName("#define WIA_IPS_PRINTER_ENDORSER_GRAPHICS_POSITION 4143")]
    public const int WIA_IPS_PRINTER_ENDORSER_GRAPHICS_POSITION = 4143;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_PRINTER_ENDORSER_GRAPHICS_POSITION_STR"]/*' />
    [NativeTypeName("#define WIA_IPS_PRINTER_ENDORSER_GRAPHICS_POSITION_STR L\"Printer/Endorser Graphics Position\"")]
    public const string WIA_IPS_PRINTER_ENDORSER_GRAPHICS_POSITION_STR = "Printer/Endorser Graphics Position";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_PRINTER_ENDORSER_GRAPHICS_MIN_WIDTH"]/*' />
    [NativeTypeName("#define WIA_IPS_PRINTER_ENDORSER_GRAPHICS_MIN_WIDTH 4144")]
    public const int WIA_IPS_PRINTER_ENDORSER_GRAPHICS_MIN_WIDTH = 4144;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_PRINTER_ENDORSER_GRAPHICS_MIN_WIDTH_STR"]/*' />
    [NativeTypeName("#define WIA_IPS_PRINTER_ENDORSER_GRAPHICS_MIN_WIDTH_STR L\"Printer/Endorser Graphics Minimum Width\"")]
    public const string WIA_IPS_PRINTER_ENDORSER_GRAPHICS_MIN_WIDTH_STR = "Printer/Endorser Graphics Minimum Width";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_PRINTER_ENDORSER_GRAPHICS_MAX_WIDTH"]/*' />
    [NativeTypeName("#define WIA_IPS_PRINTER_ENDORSER_GRAPHICS_MAX_WIDTH 4145")]
    public const int WIA_IPS_PRINTER_ENDORSER_GRAPHICS_MAX_WIDTH = 4145;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_PRINTER_ENDORSER_GRAPHICS_MAX_WIDTH_STR"]/*' />
    [NativeTypeName("#define WIA_IPS_PRINTER_ENDORSER_GRAPHICS_MAX_WIDTH_STR L\"Printer/Endorser Graphics Maximum Width\"")]
    public const string WIA_IPS_PRINTER_ENDORSER_GRAPHICS_MAX_WIDTH_STR = "Printer/Endorser Graphics Maximum Width";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_PRINTER_ENDORSER_GRAPHICS_MIN_HEIGHT"]/*' />
    [NativeTypeName("#define WIA_IPS_PRINTER_ENDORSER_GRAPHICS_MIN_HEIGHT 4146")]
    public const int WIA_IPS_PRINTER_ENDORSER_GRAPHICS_MIN_HEIGHT = 4146;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_PRINTER_ENDORSER_GRAPHICS_MIN_HEIGHT_STR"]/*' />
    [NativeTypeName("#define WIA_IPS_PRINTER_ENDORSER_GRAPHICS_MIN_HEIGHT_STR L\"Printer/Endorser Graphics Minimum Height\"")]
    public const string WIA_IPS_PRINTER_ENDORSER_GRAPHICS_MIN_HEIGHT_STR = "Printer/Endorser Graphics Minimum Height";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_PRINTER_ENDORSER_GRAPHICS_MAX_HEIGHT"]/*' />
    [NativeTypeName("#define WIA_IPS_PRINTER_ENDORSER_GRAPHICS_MAX_HEIGHT 4147")]
    public const int WIA_IPS_PRINTER_ENDORSER_GRAPHICS_MAX_HEIGHT = 4147;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_PRINTER_ENDORSER_GRAPHICS_MAX_HEIGHT_STR"]/*' />
    [NativeTypeName("#define WIA_IPS_PRINTER_ENDORSER_GRAPHICS_MAX_HEIGHT_STR L\"Printer/Endorser Graphics Maximum Height\"")]
    public const string WIA_IPS_PRINTER_ENDORSER_GRAPHICS_MAX_HEIGHT_STR = "Printer/Endorser Graphics Maximum Height";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_PRINTER_ENDORSER_GRAPHICS_UPLOAD"]/*' />
    [NativeTypeName("#define WIA_IPS_PRINTER_ENDORSER_GRAPHICS_UPLOAD 4148")]
    public const int WIA_IPS_PRINTER_ENDORSER_GRAPHICS_UPLOAD = 4148;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_PRINTER_ENDORSER_GRAPHICS_UPLOAD_STR"]/*' />
    [NativeTypeName("#define WIA_IPS_PRINTER_ENDORSER_GRAPHICS_UPLOAD_STR L\"Printer/Endorser Graphics Upload\"")]
    public const string WIA_IPS_PRINTER_ENDORSER_GRAPHICS_UPLOAD_STR = "Printer/Endorser Graphics Upload";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_PRINTER_ENDORSER_GRAPHICS_DOWNLOAD"]/*' />
    [NativeTypeName("#define WIA_IPS_PRINTER_ENDORSER_GRAPHICS_DOWNLOAD 4149")]
    public const int WIA_IPS_PRINTER_ENDORSER_GRAPHICS_DOWNLOAD = 4149;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_PRINTER_ENDORSER_GRAPHICS_DOWNLOAD_STR"]/*' />
    [NativeTypeName("#define WIA_IPS_PRINTER_ENDORSER_GRAPHICS_DOWNLOAD_STR L\"Printer/Endorser Graphics Download\"")]
    public const string WIA_IPS_PRINTER_ENDORSER_GRAPHICS_DOWNLOAD_STR = "Printer/Endorser Graphics Download";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_BARCODE_READER"]/*' />
    [NativeTypeName("#define WIA_IPS_BARCODE_READER 4150")]
    public const int WIA_IPS_BARCODE_READER = 4150;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_BARCODE_READER_STR"]/*' />
    [NativeTypeName("#define WIA_IPS_BARCODE_READER_STR L\"Barcode Reader\"")]
    public const string WIA_IPS_BARCODE_READER_STR = "Barcode Reader";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_MAXIMUM_BARCODES_PER_PAGE"]/*' />
    [NativeTypeName("#define WIA_IPS_MAXIMUM_BARCODES_PER_PAGE 4151")]
    public const int WIA_IPS_MAXIMUM_BARCODES_PER_PAGE = 4151;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_MAXIMUM_BARCODES_PER_PAGE_STR"]/*' />
    [NativeTypeName("#define WIA_IPS_MAXIMUM_BARCODES_PER_PAGE_STR L\"Maximum Barcodes Per Page\"")]
    public const string WIA_IPS_MAXIMUM_BARCODES_PER_PAGE_STR = "Maximum Barcodes Per Page";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_BARCODE_SEARCH_DIRECTION"]/*' />
    [NativeTypeName("#define WIA_IPS_BARCODE_SEARCH_DIRECTION 4152")]
    public const int WIA_IPS_BARCODE_SEARCH_DIRECTION = 4152;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_BARCODE_SEARCH_DIRECTION_STR"]/*' />
    [NativeTypeName("#define WIA_IPS_BARCODE_SEARCH_DIRECTION_STR L\"Barcode Search Direction\"")]
    public const string WIA_IPS_BARCODE_SEARCH_DIRECTION_STR = "Barcode Search Direction";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_MAXIMUM_BARCODE_SEARCH_RETRIES"]/*' />
    [NativeTypeName("#define WIA_IPS_MAXIMUM_BARCODE_SEARCH_RETRIES 4153")]
    public const int WIA_IPS_MAXIMUM_BARCODE_SEARCH_RETRIES = 4153;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_MAXIMUM_BARCODE_SEARCH_RETRIES_STR"]/*' />
    [NativeTypeName("#define WIA_IPS_MAXIMUM_BARCODE_SEARCH_RETRIES_STR L\"Barcode Search Retries\"")]
    public const string WIA_IPS_MAXIMUM_BARCODE_SEARCH_RETRIES_STR = "Barcode Search Retries";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_BARCODE_SEARCH_TIMEOUT"]/*' />
    [NativeTypeName("#define WIA_IPS_BARCODE_SEARCH_TIMEOUT 4154")]
    public const int WIA_IPS_BARCODE_SEARCH_TIMEOUT = 4154;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_BARCODE_SEARCH_TIMEOUT_STR"]/*' />
    [NativeTypeName("#define WIA_IPS_BARCODE_SEARCH_TIMEOUT_STR L\"Barcode Search Timeout\"")]
    public const string WIA_IPS_BARCODE_SEARCH_TIMEOUT_STR = "Barcode Search Timeout";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_SUPPORTED_BARCODE_TYPES"]/*' />
    [NativeTypeName("#define WIA_IPS_SUPPORTED_BARCODE_TYPES 4155")]
    public const int WIA_IPS_SUPPORTED_BARCODE_TYPES = 4155;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_SUPPORTED_BARCODE_TYPES_STR"]/*' />
    [NativeTypeName("#define WIA_IPS_SUPPORTED_BARCODE_TYPES_STR L\"Supported Barcode Types\"")]
    public const string WIA_IPS_SUPPORTED_BARCODE_TYPES_STR = "Supported Barcode Types";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_ENABLED_BARCODE_TYPES"]/*' />
    [NativeTypeName("#define WIA_IPS_ENABLED_BARCODE_TYPES 4156")]
    public const int WIA_IPS_ENABLED_BARCODE_TYPES = 4156;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_ENABLED_BARCODE_TYPES_STR"]/*' />
    [NativeTypeName("#define WIA_IPS_ENABLED_BARCODE_TYPES_STR L\"Enabled Barcode Types\"")]
    public const string WIA_IPS_ENABLED_BARCODE_TYPES_STR = "Enabled Barcode Types";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_PATCH_CODE_READER"]/*' />
    [NativeTypeName("#define WIA_IPS_PATCH_CODE_READER 4157")]
    public const int WIA_IPS_PATCH_CODE_READER = 4157;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_PATCH_CODE_READER_STR"]/*' />
    [NativeTypeName("#define WIA_IPS_PATCH_CODE_READER_STR L\"Patch Code Reader\"")]
    public const string WIA_IPS_PATCH_CODE_READER_STR = "Patch Code Reader";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_SUPPORTED_PATCH_CODE_TYPES"]/*' />
    [NativeTypeName("#define WIA_IPS_SUPPORTED_PATCH_CODE_TYPES 4162")]
    public const int WIA_IPS_SUPPORTED_PATCH_CODE_TYPES = 4162;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_SUPPORTED_PATCH_CODE_TYPES_STR"]/*' />
    [NativeTypeName("#define WIA_IPS_SUPPORTED_PATCH_CODE_TYPES_STR L\"Supported Patch Code Types\"")]
    public const string WIA_IPS_SUPPORTED_PATCH_CODE_TYPES_STR = "Supported Patch Code Types";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_ENABLED_PATCH_CODE_TYPES"]/*' />
    [NativeTypeName("#define WIA_IPS_ENABLED_PATCH_CODE_TYPES 4163")]
    public const int WIA_IPS_ENABLED_PATCH_CODE_TYPES = 4163;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_ENABLED_PATCH_CODE_TYPES_STR"]/*' />
    [NativeTypeName("#define WIA_IPS_ENABLED_PATCH_CODE_TYPES_STR L\"Enabled Path Code Types\"")]
    public const string WIA_IPS_ENABLED_PATCH_CODE_TYPES_STR = "Enabled Path Code Types";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_MICR_READER"]/*' />
    [NativeTypeName("#define WIA_IPS_MICR_READER 4164")]
    public const int WIA_IPS_MICR_READER = 4164;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_MICR_READER_STR"]/*' />
    [NativeTypeName("#define WIA_IPS_MICR_READER_STR L\"MICR Reader\"")]
    public const string WIA_IPS_MICR_READER_STR = "MICR Reader";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_JOB_SEPARATORS"]/*' />
    [NativeTypeName("#define WIA_IPS_JOB_SEPARATORS 4165")]
    public const int WIA_IPS_JOB_SEPARATORS = 4165;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_JOB_SEPARATORS_STR"]/*' />
    [NativeTypeName("#define WIA_IPS_JOB_SEPARATORS_STR L\"Job Separators\"")]
    public const string WIA_IPS_JOB_SEPARATORS_STR = "Job Separators";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_LONG_DOCUMENT"]/*' />
    [NativeTypeName("#define WIA_IPS_LONG_DOCUMENT 4166")]
    public const int WIA_IPS_LONG_DOCUMENT = 4166;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_LONG_DOCUMENT_STR"]/*' />
    [NativeTypeName("#define WIA_IPS_LONG_DOCUMENT_STR L\"Long Document\"")]
    public const string WIA_IPS_LONG_DOCUMENT_STR = "Long Document";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_BLANK_PAGES"]/*' />
    [NativeTypeName("#define WIA_IPS_BLANK_PAGES 4167")]
    public const int WIA_IPS_BLANK_PAGES = 4167;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_BLANK_PAGES_STR"]/*' />
    [NativeTypeName("#define WIA_IPS_BLANK_PAGES_STR L\"Blank Pages\"")]
    public const string WIA_IPS_BLANK_PAGES_STR = "Blank Pages";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_MULTI_FEED"]/*' />
    [NativeTypeName("#define WIA_IPS_MULTI_FEED 4168")]
    public const int WIA_IPS_MULTI_FEED = 4168;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_MULTI_FEED_STR"]/*' />
    [NativeTypeName("#define WIA_IPS_MULTI_FEED_STR L\"Multi-Feed\"")]
    public const string WIA_IPS_MULTI_FEED_STR = "Multi-Feed";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_MULTI_FEED_SENSITIVITY"]/*' />
    [NativeTypeName("#define WIA_IPS_MULTI_FEED_SENSITIVITY 4169")]
    public const int WIA_IPS_MULTI_FEED_SENSITIVITY = 4169;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_MULTI_FEED_SENSITIVITY_STR"]/*' />
    [NativeTypeName("#define WIA_IPS_MULTI_FEED_SENSITIVITY_STR L\"Multi-Feed Sensitivity\"")]
    public const string WIA_IPS_MULTI_FEED_SENSITIVITY_STR = "Multi-Feed Sensitivity";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_AUTO_CROP"]/*' />
    [NativeTypeName("#define WIA_IPS_AUTO_CROP 4170")]
    public const int WIA_IPS_AUTO_CROP = 4170;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_AUTO_CROP_STR"]/*' />
    [NativeTypeName("#define WIA_IPS_AUTO_CROP_STR L\"Auto-Crop\"")]
    public const string WIA_IPS_AUTO_CROP_STR = "Auto-Crop";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_OVER_SCAN"]/*' />
    [NativeTypeName("#define WIA_IPS_OVER_SCAN 4171")]
    public const int WIA_IPS_OVER_SCAN = 4171;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_OVER_SCAN_STR"]/*' />
    [NativeTypeName("#define WIA_IPS_OVER_SCAN_STR L\"Overscan\"")]
    public const string WIA_IPS_OVER_SCAN_STR = "Overscan";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_OVER_SCAN_LEFT"]/*' />
    [NativeTypeName("#define WIA_IPS_OVER_SCAN_LEFT 4172")]
    public const int WIA_IPS_OVER_SCAN_LEFT = 4172;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_OVER_SCAN_LEFT_STR"]/*' />
    [NativeTypeName("#define WIA_IPS_OVER_SCAN_LEFT_STR L\"Overscan Left\"")]
    public const string WIA_IPS_OVER_SCAN_LEFT_STR = "Overscan Left";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_OVER_SCAN_RIGHT"]/*' />
    [NativeTypeName("#define WIA_IPS_OVER_SCAN_RIGHT 4173")]
    public const int WIA_IPS_OVER_SCAN_RIGHT = 4173;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_OVER_SCAN_RIGHT_STR"]/*' />
    [NativeTypeName("#define WIA_IPS_OVER_SCAN_RIGHT_STR L\"Overscan Right\"")]
    public const string WIA_IPS_OVER_SCAN_RIGHT_STR = "Overscan Right";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_OVER_SCAN_TOP"]/*' />
    [NativeTypeName("#define WIA_IPS_OVER_SCAN_TOP 4174")]
    public const int WIA_IPS_OVER_SCAN_TOP = 4174;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_OVER_SCAN_TOP_STR"]/*' />
    [NativeTypeName("#define WIA_IPS_OVER_SCAN_TOP_STR L\"Overscan Top\"")]
    public const string WIA_IPS_OVER_SCAN_TOP_STR = "Overscan Top";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_OVER_SCAN_BOTTOM"]/*' />
    [NativeTypeName("#define WIA_IPS_OVER_SCAN_BOTTOM 4175")]
    public const int WIA_IPS_OVER_SCAN_BOTTOM = 4175;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_OVER_SCAN_BOTTOM_STR"]/*' />
    [NativeTypeName("#define WIA_IPS_OVER_SCAN_BOTTOM_STR L\"Overscan Bottom\"")]
    public const string WIA_IPS_OVER_SCAN_BOTTOM_STR = "Overscan Bottom";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_COLOR_DROP"]/*' />
    [NativeTypeName("#define WIA_IPS_COLOR_DROP 4176")]
    public const int WIA_IPS_COLOR_DROP = 4176;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_COLOR_DROP_STR"]/*' />
    [NativeTypeName("#define WIA_IPS_COLOR_DROP_STR L\"Color Drop\"")]
    public const string WIA_IPS_COLOR_DROP_STR = "Color Drop";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_COLOR_DROP_RED"]/*' />
    [NativeTypeName("#define WIA_IPS_COLOR_DROP_RED 4177")]
    public const int WIA_IPS_COLOR_DROP_RED = 4177;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_COLOR_DROP_RED_STR"]/*' />
    [NativeTypeName("#define WIA_IPS_COLOR_DROP_RED_STR L\"Color Drop Red\"")]
    public const string WIA_IPS_COLOR_DROP_RED_STR = "Color Drop Red";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_COLOR_DROP_GREEN"]/*' />
    [NativeTypeName("#define WIA_IPS_COLOR_DROP_GREEN 4178")]
    public const int WIA_IPS_COLOR_DROP_GREEN = 4178;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_COLOR_DROP_GREEN_STR"]/*' />
    [NativeTypeName("#define WIA_IPS_COLOR_DROP_GREEN_STR L\"Color Drop Green\"")]
    public const string WIA_IPS_COLOR_DROP_GREEN_STR = "Color Drop Green";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_COLOR_DROP_BLUE"]/*' />
    [NativeTypeName("#define WIA_IPS_COLOR_DROP_BLUE 4179")]
    public const int WIA_IPS_COLOR_DROP_BLUE = 4179;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_COLOR_DROP_BLUE_STR"]/*' />
    [NativeTypeName("#define WIA_IPS_COLOR_DROP_BLUE_STR L\"Color Drop Blue\"")]
    public const string WIA_IPS_COLOR_DROP_BLUE_STR = "Color Drop Blue";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_SCAN_AHEAD"]/*' />
    [NativeTypeName("#define WIA_IPS_SCAN_AHEAD 4180")]
    public const int WIA_IPS_SCAN_AHEAD = 4180;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_SCAN_AHEAD_STR"]/*' />
    [NativeTypeName("#define WIA_IPS_SCAN_AHEAD_STR L\"Scan Ahead\"")]
    public const string WIA_IPS_SCAN_AHEAD_STR = "Scan Ahead";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_SCAN_AHEAD_CAPACITY"]/*' />
    [NativeTypeName("#define WIA_IPS_SCAN_AHEAD_CAPACITY 4181")]
    public const int WIA_IPS_SCAN_AHEAD_CAPACITY = 4181;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_SCAN_AHEAD_CAPACITY_STR"]/*' />
    [NativeTypeName("#define WIA_IPS_SCAN_AHEAD_CAPACITY_STR L\"Scan Ahead Capacity\"")]
    public const string WIA_IPS_SCAN_AHEAD_CAPACITY_STR = "Scan Ahead Capacity";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_FEEDER_CONTROL"]/*' />
    [NativeTypeName("#define WIA_IPS_FEEDER_CONTROL 4182")]
    public const int WIA_IPS_FEEDER_CONTROL = 4182;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_FEEDER_CONTROL_STR"]/*' />
    [NativeTypeName("#define WIA_IPS_FEEDER_CONTROL_STR L\"Feeder Control\"")]
    public const string WIA_IPS_FEEDER_CONTROL_STR = "Feeder Control";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_PRINTER_ENDORSER_PADDING"]/*' />
    [NativeTypeName("#define WIA_IPS_PRINTER_ENDORSER_PADDING 4183")]
    public const int WIA_IPS_PRINTER_ENDORSER_PADDING = 4183;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_PRINTER_ENDORSER_PADDING_STR"]/*' />
    [NativeTypeName("#define WIA_IPS_PRINTER_ENDORSER_PADDING_STR L\"Printer/Endorser Padding\"")]
    public const string WIA_IPS_PRINTER_ENDORSER_PADDING_STR = "Printer/Endorser Padding";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_PRINTER_ENDORSER_FONT_TYPE"]/*' />
    [NativeTypeName("#define WIA_IPS_PRINTER_ENDORSER_FONT_TYPE 4184")]
    public const int WIA_IPS_PRINTER_ENDORSER_FONT_TYPE = 4184;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_PRINTER_ENDORSER_FONT_TYPE_STR"]/*' />
    [NativeTypeName("#define WIA_IPS_PRINTER_ENDORSER_FONT_TYPE_STR L\"Printer/Endorser Font Type\"")]
    public const string WIA_IPS_PRINTER_ENDORSER_FONT_TYPE_STR = "Printer/Endorser Font Type";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_ALARM"]/*' />
    [NativeTypeName("#define WIA_IPS_ALARM 4185")]
    public const int WIA_IPS_ALARM = 4185;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_ALARM_STR"]/*' />
    [NativeTypeName("#define WIA_IPS_ALARM_STR L\"Alarm\"")]
    public const string WIA_IPS_ALARM_STR = "Alarm";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_PRINTER_ENDORSER_INK"]/*' />
    [NativeTypeName("#define WIA_IPS_PRINTER_ENDORSER_INK 4186")]
    public const int WIA_IPS_PRINTER_ENDORSER_INK = 4186;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_PRINTER_ENDORSER_INK_STR"]/*' />
    [NativeTypeName("#define WIA_IPS_PRINTER_ENDORSER_INK_STR L\"Printer/Endorser Ink\"")]
    public const string WIA_IPS_PRINTER_ENDORSER_INK_STR = "Printer/Endorser Ink";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_PRINTER_ENDORSER_CHARACTER_ROTATION"]/*' />
    [NativeTypeName("#define WIA_IPS_PRINTER_ENDORSER_CHARACTER_ROTATION 4187")]
    public const int WIA_IPS_PRINTER_ENDORSER_CHARACTER_ROTATION = 4187;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_PRINTER_ENDORSER_CHARACTER_ROTATION_STR"]/*' />
    [NativeTypeName("#define WIA_IPS_PRINTER_ENDORSER_CHARACTER_ROTATION_STR L\"Printer/Endorser Character Rotation\"")]
    public const string WIA_IPS_PRINTER_ENDORSER_CHARACTER_ROTATION_STR = "Printer/Endorser Character Rotation";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_PRINTER_ENDORSER_MAX_CHARACTERS"]/*' />
    [NativeTypeName("#define WIA_IPS_PRINTER_ENDORSER_MAX_CHARACTERS 4188")]
    public const int WIA_IPS_PRINTER_ENDORSER_MAX_CHARACTERS = 4188;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_PRINTER_ENDORSER_MAX_CHARACTERS_STR"]/*' />
    [NativeTypeName("#define WIA_IPS_PRINTER_ENDORSER_MAX_CHARACTERS_STR L\"Printer/Endorser Maximum Characters\"")]
    public const string WIA_IPS_PRINTER_ENDORSER_MAX_CHARACTERS_STR = "Printer/Endorser Maximum Characters";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_PRINTER_ENDORSER_MAX_GRAPHICS"]/*' />
    [NativeTypeName("#define WIA_IPS_PRINTER_ENDORSER_MAX_GRAPHICS 4189")]
    public const int WIA_IPS_PRINTER_ENDORSER_MAX_GRAPHICS = 4189;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_PRINTER_ENDORSER_MAX_GRAPHICS_STR"]/*' />
    [NativeTypeName("#define WIA_IPS_PRINTER_ENDORSER_MAX_GRAPHICS_STR L\"Printer/Endorser Maximum Graphics\"")]
    public const string WIA_IPS_PRINTER_ENDORSER_MAX_GRAPHICS_STR = "Printer/Endorser Maximum Graphics";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_PRINTER_ENDORSER_COUNTER_DIGITS"]/*' />
    [NativeTypeName("#define WIA_IPS_PRINTER_ENDORSER_COUNTER_DIGITS 4190")]
    public const int WIA_IPS_PRINTER_ENDORSER_COUNTER_DIGITS = 4190;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_PRINTER_ENDORSER_COUNTER_DIGITS_STR"]/*' />
    [NativeTypeName("#define WIA_IPS_PRINTER_ENDORSER_COUNTER_DIGITS_STR L\"Printer/Endorser Counter Digits\"")]
    public const string WIA_IPS_PRINTER_ENDORSER_COUNTER_DIGITS_STR = "Printer/Endorser Counter Digits";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_COLOR_DROP_MULTI"]/*' />
    [NativeTypeName("#define WIA_IPS_COLOR_DROP_MULTI 4191")]
    public const int WIA_IPS_COLOR_DROP_MULTI = 4191;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_COLOR_DROP_MULTI_STR"]/*' />
    [NativeTypeName("#define WIA_IPS_COLOR_DROP_MULTI_STR L\"Color Drop Multiple\"")]
    public const string WIA_IPS_COLOR_DROP_MULTI_STR = "Color Drop Multiple";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_BLANK_PAGES_SENSITIVITY"]/*' />
    [NativeTypeName("#define WIA_IPS_BLANK_PAGES_SENSITIVITY 4192")]
    public const int WIA_IPS_BLANK_PAGES_SENSITIVITY = 4192;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_BLANK_PAGES_SENSITIVITY_STR"]/*' />
    [NativeTypeName("#define WIA_IPS_BLANK_PAGES_SENSITIVITY_STR L\"Blank Pages Sensitivity\"")]
    public const string WIA_IPS_BLANK_PAGES_SENSITIVITY_STR = "Blank Pages Sensitivity";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_MULTI_FEED_DETECT_METHOD"]/*' />
    [NativeTypeName("#define WIA_IPS_MULTI_FEED_DETECT_METHOD 4193")]
    public const int WIA_IPS_MULTI_FEED_DETECT_METHOD = 4193;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_MULTI_FEED_DETECT_METHOD_STR"]/*' />
    [NativeTypeName("#define WIA_IPS_MULTI_FEED_DETECT_METHOD_STR L\"Multi-Feed Detection Method\"")]
    public const string WIA_IPS_MULTI_FEED_DETECT_METHOD_STR = "Multi-Feed Detection Method";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_TRANSFER_CHILDREN_SINGLE_SCAN"]/*' />
    [NativeTypeName("#define WIA_TRANSFER_CHILDREN_SINGLE_SCAN 0x00000001")]
    public const int WIA_TRANSFER_CHILDREN_SINGLE_SCAN = 0x00000001;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_USE_SEGMENTATION_FILTER"]/*' />
    [NativeTypeName("#define WIA_USE_SEGMENTATION_FILTER 0")]
    public const int WIA_USE_SEGMENTATION_FILTER = 0;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DONT_USE_SEGMENTATION_FILTER"]/*' />
    [NativeTypeName("#define WIA_DONT_USE_SEGMENTATION_FILTER 1")]
    public const int WIA_DONT_USE_SEGMENTATION_FILTER = 1;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_FILM_COLOR_SLIDE"]/*' />
    [NativeTypeName("#define WIA_FILM_COLOR_SLIDE 0")]
    public const int WIA_FILM_COLOR_SLIDE = 0;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_FILM_COLOR_NEGATIVE"]/*' />
    [NativeTypeName("#define WIA_FILM_COLOR_NEGATIVE 1")]
    public const int WIA_FILM_COLOR_NEGATIVE = 1;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_FILM_BW_NEGATIVE"]/*' />
    [NativeTypeName("#define WIA_FILM_BW_NEGATIVE 2")]
    public const int WIA_FILM_BW_NEGATIVE = 2;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_LAMP_ON"]/*' />
    [NativeTypeName("#define WIA_LAMP_ON 0")]
    public const int WIA_LAMP_ON = 0;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_LAMP_OFF"]/*' />
    [NativeTypeName("#define WIA_LAMP_OFF 1")]
    public const int WIA_LAMP_OFF = 1;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_AUTO_DESKEW_ON"]/*' />
    [NativeTypeName("#define WIA_AUTO_DESKEW_ON 0")]
    public const int WIA_AUTO_DESKEW_ON = 0;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_AUTO_DESKEW_OFF"]/*' />
    [NativeTypeName("#define WIA_AUTO_DESKEW_OFF 1")]
    public const int WIA_AUTO_DESKEW_OFF = 1;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_ADVANCED_PREVIEW"]/*' />
    [NativeTypeName("#define WIA_ADVANCED_PREVIEW 0")]
    public const int WIA_ADVANCED_PREVIEW = 0;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_BASIC_PREVIEW"]/*' />
    [NativeTypeName("#define WIA_BASIC_PREVIEW 1")]
    public const int WIA_BASIC_PREVIEW = 1;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_PRINTER_ENDORSER_DISABLED"]/*' />
    [NativeTypeName("#define WIA_PRINTER_ENDORSER_DISABLED 0")]
    public const int WIA_PRINTER_ENDORSER_DISABLED = 0;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_PRINTER_ENDORSER_AUTO"]/*' />
    [NativeTypeName("#define WIA_PRINTER_ENDORSER_AUTO 1")]
    public const int WIA_PRINTER_ENDORSER_AUTO = 1;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_PRINTER_ENDORSER_FLATBED"]/*' />
    [NativeTypeName("#define WIA_PRINTER_ENDORSER_FLATBED 2")]
    public const int WIA_PRINTER_ENDORSER_FLATBED = 2;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_PRINTER_ENDORSER_FEEDER_FRONT"]/*' />
    [NativeTypeName("#define WIA_PRINTER_ENDORSER_FEEDER_FRONT 3")]
    public const int WIA_PRINTER_ENDORSER_FEEDER_FRONT = 3;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_PRINTER_ENDORSER_FEEDER_BACK"]/*' />
    [NativeTypeName("#define WIA_PRINTER_ENDORSER_FEEDER_BACK 4")]
    public const int WIA_PRINTER_ENDORSER_FEEDER_BACK = 4;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_PRINTER_ENDORSER_FEEDER_DUPLEX"]/*' />
    [NativeTypeName("#define WIA_PRINTER_ENDORSER_FEEDER_DUPLEX 5")]
    public const int WIA_PRINTER_ENDORSER_FEEDER_DUPLEX = 5;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_PRINTER_ENDORSER_DIGITAL"]/*' />
    [NativeTypeName("#define WIA_PRINTER_ENDORSER_DIGITAL 6")]
    public const int WIA_PRINTER_ENDORSER_DIGITAL = 6;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_PRINTER_ENDORSER_BEFORE_SCAN"]/*' />
    [NativeTypeName("#define WIA_PRINTER_ENDORSER_BEFORE_SCAN 0")]
    public const int WIA_PRINTER_ENDORSER_BEFORE_SCAN = 0;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_PRINTER_ENDORSER_AFTER_SCAN"]/*' />
    [NativeTypeName("#define WIA_PRINTER_ENDORSER_AFTER_SCAN 1")]
    public const int WIA_PRINTER_ENDORSER_AFTER_SCAN = 1;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_PRINT_DATE"]/*' />
    [NativeTypeName("#define WIA_PRINT_DATE 0")]
    public const int WIA_PRINT_DATE = 0;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_PRINT_YEAR"]/*' />
    [NativeTypeName("#define WIA_PRINT_YEAR 1")]
    public const int WIA_PRINT_YEAR = 1;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_PRINT_MONTH"]/*' />
    [NativeTypeName("#define WIA_PRINT_MONTH 2")]
    public const int WIA_PRINT_MONTH = 2;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_PRINT_DAY"]/*' />
    [NativeTypeName("#define WIA_PRINT_DAY 3")]
    public const int WIA_PRINT_DAY = 3;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_PRINT_WEEK_DAY"]/*' />
    [NativeTypeName("#define WIA_PRINT_WEEK_DAY 4")]
    public const int WIA_PRINT_WEEK_DAY = 4;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_PRINT_TIME_24H"]/*' />
    [NativeTypeName("#define WIA_PRINT_TIME_24H 5")]
    public const int WIA_PRINT_TIME_24H = 5;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_PRINT_TIME_12H"]/*' />
    [NativeTypeName("#define WIA_PRINT_TIME_12H 6")]
    public const int WIA_PRINT_TIME_12H = 6;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_PRINT_HOUR_24H"]/*' />
    [NativeTypeName("#define WIA_PRINT_HOUR_24H 7")]
    public const int WIA_PRINT_HOUR_24H = 7;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_PRINT_HOUR_12H"]/*' />
    [NativeTypeName("#define WIA_PRINT_HOUR_12H 8")]
    public const int WIA_PRINT_HOUR_12H = 8;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_PRINT_AM_PM"]/*' />
    [NativeTypeName("#define WIA_PRINT_AM_PM 9")]
    public const int WIA_PRINT_AM_PM = 9;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_PRINT_MINUTE"]/*' />
    [NativeTypeName("#define WIA_PRINT_MINUTE 10")]
    public const int WIA_PRINT_MINUTE = 10;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_PRINT_SECOND"]/*' />
    [NativeTypeName("#define WIA_PRINT_SECOND 11")]
    public const int WIA_PRINT_SECOND = 11;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_PRINT_PAGE_COUNT"]/*' />
    [NativeTypeName("#define WIA_PRINT_PAGE_COUNT 12")]
    public const int WIA_PRINT_PAGE_COUNT = 12;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_PRINT_IMAGE"]/*' />
    [NativeTypeName("#define WIA_PRINT_IMAGE 13")]
    public const int WIA_PRINT_IMAGE = 13;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_PRINT_MILLISECOND"]/*' />
    [NativeTypeName("#define WIA_PRINT_MILLISECOND 14")]
    public const int WIA_PRINT_MILLISECOND = 14;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_PRINT_MONTH_NAME"]/*' />
    [NativeTypeName("#define WIA_PRINT_MONTH_NAME 15")]
    public const int WIA_PRINT_MONTH_NAME = 15;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_PRINT_MONTH_SHORT"]/*' />
    [NativeTypeName("#define WIA_PRINT_MONTH_SHORT 16")]
    public const int WIA_PRINT_MONTH_SHORT = 16;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_PRINT_WEEK_DAY_SHORT"]/*' />
    [NativeTypeName("#define WIA_PRINT_WEEK_DAY_SHORT 17")]
    public const int WIA_PRINT_WEEK_DAY_SHORT = 17;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_PRINTER_ENDORSER_GRAPHICS_LEFT"]/*' />
    [NativeTypeName("#define WIA_PRINTER_ENDORSER_GRAPHICS_LEFT 0")]
    public const int WIA_PRINTER_ENDORSER_GRAPHICS_LEFT = 0;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_PRINTER_ENDORSER_GRAPHICS_RIGHT"]/*' />
    [NativeTypeName("#define WIA_PRINTER_ENDORSER_GRAPHICS_RIGHT 1")]
    public const int WIA_PRINTER_ENDORSER_GRAPHICS_RIGHT = 1;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_PRINTER_ENDORSER_GRAPHICS_TOP"]/*' />
    [NativeTypeName("#define WIA_PRINTER_ENDORSER_GRAPHICS_TOP 2")]
    public const int WIA_PRINTER_ENDORSER_GRAPHICS_TOP = 2;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_PRINTER_ENDORSER_GRAPHICS_BOTTOM"]/*' />
    [NativeTypeName("#define WIA_PRINTER_ENDORSER_GRAPHICS_BOTTOM 3")]
    public const int WIA_PRINTER_ENDORSER_GRAPHICS_BOTTOM = 3;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_PRINTER_ENDORSER_GRAPHICS_TOP_LEFT"]/*' />
    [NativeTypeName("#define WIA_PRINTER_ENDORSER_GRAPHICS_TOP_LEFT 4")]
    public const int WIA_PRINTER_ENDORSER_GRAPHICS_TOP_LEFT = 4;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_PRINTER_ENDORSER_GRAPHICS_TOP_RIGHT"]/*' />
    [NativeTypeName("#define WIA_PRINTER_ENDORSER_GRAPHICS_TOP_RIGHT 5")]
    public const int WIA_PRINTER_ENDORSER_GRAPHICS_TOP_RIGHT = 5;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_PRINTER_ENDORSER_GRAPHICS_BOTTOM_LEFT"]/*' />
    [NativeTypeName("#define WIA_PRINTER_ENDORSER_GRAPHICS_BOTTOM_LEFT 6")]
    public const int WIA_PRINTER_ENDORSER_GRAPHICS_BOTTOM_LEFT = 6;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_PRINTER_ENDORSER_GRAPHICS_BOTTOM_RIGHT"]/*' />
    [NativeTypeName("#define WIA_PRINTER_ENDORSER_GRAPHICS_BOTTOM_RIGHT 7")]
    public const int WIA_PRINTER_ENDORSER_GRAPHICS_BOTTOM_RIGHT = 7;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_PRINTER_ENDORSER_GRAPHICS_BACKGROUND"]/*' />
    [NativeTypeName("#define WIA_PRINTER_ENDORSER_GRAPHICS_BACKGROUND 8")]
    public const int WIA_PRINTER_ENDORSER_GRAPHICS_BACKGROUND = 8;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_PRINTER_ENDORSER_GRAPHICS_DEVICE_DEFAULT"]/*' />
    [NativeTypeName("#define WIA_PRINTER_ENDORSER_GRAPHICS_DEVICE_DEFAULT 9")]
    public const int WIA_PRINTER_ENDORSER_GRAPHICS_DEVICE_DEFAULT = 9;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_BARCODE_READER_DISABLED"]/*' />
    [NativeTypeName("#define WIA_BARCODE_READER_DISABLED 0")]
    public const int WIA_BARCODE_READER_DISABLED = 0;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_BARCODE_READER_AUTO"]/*' />
    [NativeTypeName("#define WIA_BARCODE_READER_AUTO 1")]
    public const int WIA_BARCODE_READER_AUTO = 1;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_BARCODE_READER_FLATBED"]/*' />
    [NativeTypeName("#define WIA_BARCODE_READER_FLATBED 2")]
    public const int WIA_BARCODE_READER_FLATBED = 2;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_BARCODE_READER_FEEDER_FRONT"]/*' />
    [NativeTypeName("#define WIA_BARCODE_READER_FEEDER_FRONT 3")]
    public const int WIA_BARCODE_READER_FEEDER_FRONT = 3;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_BARCODE_READER_FEEDER_BACK"]/*' />
    [NativeTypeName("#define WIA_BARCODE_READER_FEEDER_BACK 4")]
    public const int WIA_BARCODE_READER_FEEDER_BACK = 4;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_BARCODE_READER_FEEDER_DUPLEX"]/*' />
    [NativeTypeName("#define WIA_BARCODE_READER_FEEDER_DUPLEX 5")]
    public const int WIA_BARCODE_READER_FEEDER_DUPLEX = 5;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_BARCODE_HORIZONTAL_SEARCH"]/*' />
    [NativeTypeName("#define WIA_BARCODE_HORIZONTAL_SEARCH 0")]
    public const int WIA_BARCODE_HORIZONTAL_SEARCH = 0;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_BARCODE_VERTICAL_SEARCH"]/*' />
    [NativeTypeName("#define WIA_BARCODE_VERTICAL_SEARCH 1")]
    public const int WIA_BARCODE_VERTICAL_SEARCH = 1;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_BARCODE_HORIZONTAL_VERTICAL_SEARCH"]/*' />
    [NativeTypeName("#define WIA_BARCODE_HORIZONTAL_VERTICAL_SEARCH 2")]
    public const int WIA_BARCODE_HORIZONTAL_VERTICAL_SEARCH = 2;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_BARCODE_VERTICAL_HORIZONTAL_SEARCH"]/*' />
    [NativeTypeName("#define WIA_BARCODE_VERTICAL_HORIZONTAL_SEARCH 3")]
    public const int WIA_BARCODE_VERTICAL_HORIZONTAL_SEARCH = 3;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_BARCODE_AUTO_SEARCH"]/*' />
    [NativeTypeName("#define WIA_BARCODE_AUTO_SEARCH 4")]
    public const int WIA_BARCODE_AUTO_SEARCH = 4;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_BARCODE_UPCA"]/*' />
    [NativeTypeName("#define WIA_BARCODE_UPCA 0")]
    public const int WIA_BARCODE_UPCA = 0;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_BARCODE_UPCE"]/*' />
    [NativeTypeName("#define WIA_BARCODE_UPCE 1")]
    public const int WIA_BARCODE_UPCE = 1;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_BARCODE_CODABAR"]/*' />
    [NativeTypeName("#define WIA_BARCODE_CODABAR 2")]
    public const int WIA_BARCODE_CODABAR = 2;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_BARCODE_NONINTERLEAVED_2OF5"]/*' />
    [NativeTypeName("#define WIA_BARCODE_NONINTERLEAVED_2OF5 3")]
    public const int WIA_BARCODE_NONINTERLEAVED_2OF5 = 3;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_BARCODE_INTERLEAVED_2OF5"]/*' />
    [NativeTypeName("#define WIA_BARCODE_INTERLEAVED_2OF5 4")]
    public const int WIA_BARCODE_INTERLEAVED_2OF5 = 4;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_BARCODE_CODE39"]/*' />
    [NativeTypeName("#define WIA_BARCODE_CODE39 5")]
    public const int WIA_BARCODE_CODE39 = 5;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_BARCODE_CODE39_MOD43"]/*' />
    [NativeTypeName("#define WIA_BARCODE_CODE39_MOD43 6")]
    public const int WIA_BARCODE_CODE39_MOD43 = 6;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_BARCODE_CODE39_FULLASCII"]/*' />
    [NativeTypeName("#define WIA_BARCODE_CODE39_FULLASCII 7")]
    public const int WIA_BARCODE_CODE39_FULLASCII = 7;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_BARCODE_CODE93"]/*' />
    [NativeTypeName("#define WIA_BARCODE_CODE93 8")]
    public const int WIA_BARCODE_CODE93 = 8;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_BARCODE_CODE128"]/*' />
    [NativeTypeName("#define WIA_BARCODE_CODE128 9")]
    public const int WIA_BARCODE_CODE128 = 9;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_BARCODE_CODE128A"]/*' />
    [NativeTypeName("#define WIA_BARCODE_CODE128A 10")]
    public const int WIA_BARCODE_CODE128A = 10;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_BARCODE_CODE128B"]/*' />
    [NativeTypeName("#define WIA_BARCODE_CODE128B 11")]
    public const int WIA_BARCODE_CODE128B = 11;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_BARCODE_CODE128C"]/*' />
    [NativeTypeName("#define WIA_BARCODE_CODE128C 12")]
    public const int WIA_BARCODE_CODE128C = 12;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_BARCODE_GS1128"]/*' />
    [NativeTypeName("#define WIA_BARCODE_GS1128 13")]
    public const int WIA_BARCODE_GS1128 = 13;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_BARCODE_GS1DATABAR"]/*' />
    [NativeTypeName("#define WIA_BARCODE_GS1DATABAR 14")]
    public const int WIA_BARCODE_GS1DATABAR = 14;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_BARCODE_ITF14"]/*' />
    [NativeTypeName("#define WIA_BARCODE_ITF14 15")]
    public const int WIA_BARCODE_ITF14 = 15;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_BARCODE_EAN8"]/*' />
    [NativeTypeName("#define WIA_BARCODE_EAN8 16")]
    public const int WIA_BARCODE_EAN8 = 16;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_BARCODE_EAN13"]/*' />
    [NativeTypeName("#define WIA_BARCODE_EAN13 17")]
    public const int WIA_BARCODE_EAN13 = 17;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_BARCODE_POSTNETA"]/*' />
    [NativeTypeName("#define WIA_BARCODE_POSTNETA 18")]
    public const int WIA_BARCODE_POSTNETA = 18;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_BARCODE_POSTNETB"]/*' />
    [NativeTypeName("#define WIA_BARCODE_POSTNETB 19")]
    public const int WIA_BARCODE_POSTNETB = 19;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_BARCODE_POSTNETC"]/*' />
    [NativeTypeName("#define WIA_BARCODE_POSTNETC 20")]
    public const int WIA_BARCODE_POSTNETC = 20;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_BARCODE_POSTNET_DPBC"]/*' />
    [NativeTypeName("#define WIA_BARCODE_POSTNET_DPBC 21")]
    public const int WIA_BARCODE_POSTNET_DPBC = 21;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_BARCODE_PLANET"]/*' />
    [NativeTypeName("#define WIA_BARCODE_PLANET 22")]
    public const int WIA_BARCODE_PLANET = 22;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_BARCODE_INTELLIGENT_MAIL"]/*' />
    [NativeTypeName("#define WIA_BARCODE_INTELLIGENT_MAIL 23")]
    public const int WIA_BARCODE_INTELLIGENT_MAIL = 23;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_BARCODE_POSTBAR"]/*' />
    [NativeTypeName("#define WIA_BARCODE_POSTBAR 24")]
    public const int WIA_BARCODE_POSTBAR = 24;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_BARCODE_RM4SCC"]/*' />
    [NativeTypeName("#define WIA_BARCODE_RM4SCC 25")]
    public const int WIA_BARCODE_RM4SCC = 25;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_BARCODE_HIGH_CAPACITY_COLOR"]/*' />
    [NativeTypeName("#define WIA_BARCODE_HIGH_CAPACITY_COLOR 26")]
    public const int WIA_BARCODE_HIGH_CAPACITY_COLOR = 26;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_BARCODE_MAXICODE"]/*' />
    [NativeTypeName("#define WIA_BARCODE_MAXICODE 27")]
    public const int WIA_BARCODE_MAXICODE = 27;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_BARCODE_PDF417"]/*' />
    [NativeTypeName("#define WIA_BARCODE_PDF417 28")]
    public const int WIA_BARCODE_PDF417 = 28;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_BARCODE_CPCBINARY"]/*' />
    [NativeTypeName("#define WIA_BARCODE_CPCBINARY 29")]
    public const int WIA_BARCODE_CPCBINARY = 29;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_BARCODE_FIM"]/*' />
    [NativeTypeName("#define WIA_BARCODE_FIM 30")]
    public const int WIA_BARCODE_FIM = 30;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_BARCODE_PHARMACODE"]/*' />
    [NativeTypeName("#define WIA_BARCODE_PHARMACODE 31")]
    public const int WIA_BARCODE_PHARMACODE = 31;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_BARCODE_PLESSEY"]/*' />
    [NativeTypeName("#define WIA_BARCODE_PLESSEY 32")]
    public const int WIA_BARCODE_PLESSEY = 32;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_BARCODE_MSI"]/*' />
    [NativeTypeName("#define WIA_BARCODE_MSI 33")]
    public const int WIA_BARCODE_MSI = 33;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_BARCODE_JAN"]/*' />
    [NativeTypeName("#define WIA_BARCODE_JAN 34")]
    public const int WIA_BARCODE_JAN = 34;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_BARCODE_TELEPEN"]/*' />
    [NativeTypeName("#define WIA_BARCODE_TELEPEN 35")]
    public const int WIA_BARCODE_TELEPEN = 35;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_BARCODE_AZTEC"]/*' />
    [NativeTypeName("#define WIA_BARCODE_AZTEC 36")]
    public const int WIA_BARCODE_AZTEC = 36;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_BARCODE_SMALLAZTEC"]/*' />
    [NativeTypeName("#define WIA_BARCODE_SMALLAZTEC 37")]
    public const int WIA_BARCODE_SMALLAZTEC = 37;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_BARCODE_DATAMATRIX"]/*' />
    [NativeTypeName("#define WIA_BARCODE_DATAMATRIX 38")]
    public const int WIA_BARCODE_DATAMATRIX = 38;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_BARCODE_DATASTRIP"]/*' />
    [NativeTypeName("#define WIA_BARCODE_DATASTRIP 39")]
    public const int WIA_BARCODE_DATASTRIP = 39;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_BARCODE_EZCODE"]/*' />
    [NativeTypeName("#define WIA_BARCODE_EZCODE 40")]
    public const int WIA_BARCODE_EZCODE = 40;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_BARCODE_QRCODE"]/*' />
    [NativeTypeName("#define WIA_BARCODE_QRCODE 41")]
    public const int WIA_BARCODE_QRCODE = 41;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_BARCODE_SHOTCODE"]/*' />
    [NativeTypeName("#define WIA_BARCODE_SHOTCODE 42")]
    public const int WIA_BARCODE_SHOTCODE = 42;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_BARCODE_SPARQCODE"]/*' />
    [NativeTypeName("#define WIA_BARCODE_SPARQCODE 43")]
    public const int WIA_BARCODE_SPARQCODE = 43;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_BARCODE_CUSTOMBASE"]/*' />
    [NativeTypeName("#define WIA_BARCODE_CUSTOMBASE 0x8000")]
    public const int WIA_BARCODE_CUSTOMBASE = 0x8000;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_PATCH_CODE_READER_DISABLED"]/*' />
    [NativeTypeName("#define WIA_PATCH_CODE_READER_DISABLED 0")]
    public const int WIA_PATCH_CODE_READER_DISABLED = 0;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_PATCH_CODE_READER_AUTO"]/*' />
    [NativeTypeName("#define WIA_PATCH_CODE_READER_AUTO 1")]
    public const int WIA_PATCH_CODE_READER_AUTO = 1;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_PATCH_CODE_READER_FLATBED"]/*' />
    [NativeTypeName("#define WIA_PATCH_CODE_READER_FLATBED 2")]
    public const int WIA_PATCH_CODE_READER_FLATBED = 2;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_PATCH_CODE_READER_FEEDER_FRONT"]/*' />
    [NativeTypeName("#define WIA_PATCH_CODE_READER_FEEDER_FRONT 3")]
    public const int WIA_PATCH_CODE_READER_FEEDER_FRONT = 3;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_PATCH_CODE_READER_FEEDER_BACK"]/*' />
    [NativeTypeName("#define WIA_PATCH_CODE_READER_FEEDER_BACK 4")]
    public const int WIA_PATCH_CODE_READER_FEEDER_BACK = 4;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_PATCH_CODE_READER_FEEDER_DUPLEX"]/*' />
    [NativeTypeName("#define WIA_PATCH_CODE_READER_FEEDER_DUPLEX 5")]
    public const int WIA_PATCH_CODE_READER_FEEDER_DUPLEX = 5;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_PATCH_CODE_UNKNOWN"]/*' />
    [NativeTypeName("#define WIA_PATCH_CODE_UNKNOWN 0")]
    public const int WIA_PATCH_CODE_UNKNOWN = 0;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_PATCH_CODE_1"]/*' />
    [NativeTypeName("#define WIA_PATCH_CODE_1 1")]
    public const int WIA_PATCH_CODE_1 = 1;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_PATCH_CODE_2"]/*' />
    [NativeTypeName("#define WIA_PATCH_CODE_2 2")]
    public const int WIA_PATCH_CODE_2 = 2;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_PATCH_CODE_3"]/*' />
    [NativeTypeName("#define WIA_PATCH_CODE_3 3")]
    public const int WIA_PATCH_CODE_3 = 3;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_PATCH_CODE_4"]/*' />
    [NativeTypeName("#define WIA_PATCH_CODE_4 4")]
    public const int WIA_PATCH_CODE_4 = 4;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_PATCH_CODE_T"]/*' />
    [NativeTypeName("#define WIA_PATCH_CODE_T 5")]
    public const int WIA_PATCH_CODE_T = 5;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_PATCH_CODE_6"]/*' />
    [NativeTypeName("#define WIA_PATCH_CODE_6 6")]
    public const int WIA_PATCH_CODE_6 = 6;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_PATCH_CODE_7"]/*' />
    [NativeTypeName("#define WIA_PATCH_CODE_7 7")]
    public const int WIA_PATCH_CODE_7 = 7;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_PATCH_CODE_8"]/*' />
    [NativeTypeName("#define WIA_PATCH_CODE_8 8")]
    public const int WIA_PATCH_CODE_8 = 8;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_PATCH_CODE_9"]/*' />
    [NativeTypeName("#define WIA_PATCH_CODE_9 9")]
    public const int WIA_PATCH_CODE_9 = 9;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_PATCH_CODE_10"]/*' />
    [NativeTypeName("#define WIA_PATCH_CODE_10 10")]
    public const int WIA_PATCH_CODE_10 = 10;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_PATCH_CODE_11"]/*' />
    [NativeTypeName("#define WIA_PATCH_CODE_11 11")]
    public const int WIA_PATCH_CODE_11 = 11;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_PATCH_CODE_12"]/*' />
    [NativeTypeName("#define WIA_PATCH_CODE_12 12")]
    public const int WIA_PATCH_CODE_12 = 12;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_PATCH_CODE_13"]/*' />
    [NativeTypeName("#define WIA_PATCH_CODE_13 13")]
    public const int WIA_PATCH_CODE_13 = 13;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_PATCH_CODE_14"]/*' />
    [NativeTypeName("#define WIA_PATCH_CODE_14 14")]
    public const int WIA_PATCH_CODE_14 = 14;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_PATCH_CODE_CUSTOM_BASE"]/*' />
    [NativeTypeName("#define WIA_PATCH_CODE_CUSTOM_BASE 0x8000")]
    public const int WIA_PATCH_CODE_CUSTOM_BASE = 0x8000;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_MICR_READER_DISABLED"]/*' />
    [NativeTypeName("#define WIA_MICR_READER_DISABLED 0")]
    public const int WIA_MICR_READER_DISABLED = 0;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_MICR_READER_AUTO"]/*' />
    [NativeTypeName("#define WIA_MICR_READER_AUTO 1")]
    public const int WIA_MICR_READER_AUTO = 1;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_MICR_READER_FLATBED"]/*' />
    [NativeTypeName("#define WIA_MICR_READER_FLATBED 2")]
    public const int WIA_MICR_READER_FLATBED = 2;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_MICR_READER_FEEDER_FRONT"]/*' />
    [NativeTypeName("#define WIA_MICR_READER_FEEDER_FRONT 3")]
    public const int WIA_MICR_READER_FEEDER_FRONT = 3;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_MICR_READER_FEEDER_BACK"]/*' />
    [NativeTypeName("#define WIA_MICR_READER_FEEDER_BACK 4")]
    public const int WIA_MICR_READER_FEEDER_BACK = 4;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_MICR_READER_FEEDER_DUPLEX"]/*' />
    [NativeTypeName("#define WIA_MICR_READER_FEEDER_DUPLEX 5")]
    public const int WIA_MICR_READER_FEEDER_DUPLEX = 5;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_SEPARATOR_DISABLED"]/*' />
    [NativeTypeName("#define WIA_SEPARATOR_DISABLED 0")]
    public const int WIA_SEPARATOR_DISABLED = 0;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_SEPARATOR_DETECT_SCAN_CONTINUE"]/*' />
    [NativeTypeName("#define WIA_SEPARATOR_DETECT_SCAN_CONTINUE 1")]
    public const int WIA_SEPARATOR_DETECT_SCAN_CONTINUE = 1;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_SEPARATOR_DETECT_SCAN_STOP"]/*' />
    [NativeTypeName("#define WIA_SEPARATOR_DETECT_SCAN_STOP 2")]
    public const int WIA_SEPARATOR_DETECT_SCAN_STOP = 2;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_SEPARATOR_DETECT_NOSCAN_CONTINUE"]/*' />
    [NativeTypeName("#define WIA_SEPARATOR_DETECT_NOSCAN_CONTINUE 3")]
    public const int WIA_SEPARATOR_DETECT_NOSCAN_CONTINUE = 3;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_SEPARATOR_DETECT_NOSCAN_STOP"]/*' />
    [NativeTypeName("#define WIA_SEPARATOR_DETECT_NOSCAN_STOP 4")]
    public const int WIA_SEPARATOR_DETECT_NOSCAN_STOP = 4;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_LONG_DOCUMENT_DISABLED"]/*' />
    [NativeTypeName("#define WIA_LONG_DOCUMENT_DISABLED 0")]
    public const int WIA_LONG_DOCUMENT_DISABLED = 0;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_LONG_DOCUMENT_ENABLED"]/*' />
    [NativeTypeName("#define WIA_LONG_DOCUMENT_ENABLED 1")]
    public const int WIA_LONG_DOCUMENT_ENABLED = 1;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_LONG_DOCUMENT_SPLIT"]/*' />
    [NativeTypeName("#define WIA_LONG_DOCUMENT_SPLIT 2")]
    public const int WIA_LONG_DOCUMENT_SPLIT = 2;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_BLANK_PAGE_DETECTION_DISABLED"]/*' />
    [NativeTypeName("#define WIA_BLANK_PAGE_DETECTION_DISABLED 0")]
    public const int WIA_BLANK_PAGE_DETECTION_DISABLED = 0;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_BLANK_PAGE_DISCARD"]/*' />
    [NativeTypeName("#define WIA_BLANK_PAGE_DISCARD 1")]
    public const int WIA_BLANK_PAGE_DISCARD = 1;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_BLANK_PAGE_JOB_SEPARATOR"]/*' />
    [NativeTypeName("#define WIA_BLANK_PAGE_JOB_SEPARATOR 2")]
    public const int WIA_BLANK_PAGE_JOB_SEPARATOR = 2;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_MULTI_FEED_DETECT_DISABLED"]/*' />
    [NativeTypeName("#define WIA_MULTI_FEED_DETECT_DISABLED 0")]
    public const int WIA_MULTI_FEED_DETECT_DISABLED = 0;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_MULTI_FEED_DETECT_STOP_ERROR"]/*' />
    [NativeTypeName("#define WIA_MULTI_FEED_DETECT_STOP_ERROR 1")]
    public const int WIA_MULTI_FEED_DETECT_STOP_ERROR = 1;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_MULTI_FEED_DETECT_STOP_SUCCESS"]/*' />
    [NativeTypeName("#define WIA_MULTI_FEED_DETECT_STOP_SUCCESS 2")]
    public const int WIA_MULTI_FEED_DETECT_STOP_SUCCESS = 2;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_MULTI_FEED_DETECT_CONTINUE"]/*' />
    [NativeTypeName("#define WIA_MULTI_FEED_DETECT_CONTINUE 3")]
    public const int WIA_MULTI_FEED_DETECT_CONTINUE = 3;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_MULTI_FEED_DETECT_METHOD_LENGTH"]/*' />
    [NativeTypeName("#define WIA_MULTI_FEED_DETECT_METHOD_LENGTH 0")]
    public const int WIA_MULTI_FEED_DETECT_METHOD_LENGTH = 0;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_MULTI_FEED_DETECT_METHOD_OVERLAP"]/*' />
    [NativeTypeName("#define WIA_MULTI_FEED_DETECT_METHOD_OVERLAP 1")]
    public const int WIA_MULTI_FEED_DETECT_METHOD_OVERLAP = 1;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_AUTO_CROP_DISABLED"]/*' />
    [NativeTypeName("#define WIA_AUTO_CROP_DISABLED 0")]
    public const int WIA_AUTO_CROP_DISABLED = 0;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_AUTO_CROP_SINGLE"]/*' />
    [NativeTypeName("#define WIA_AUTO_CROP_SINGLE 1")]
    public const int WIA_AUTO_CROP_SINGLE = 1;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_AUTO_CROP_MULTI"]/*' />
    [NativeTypeName("#define WIA_AUTO_CROP_MULTI 2")]
    public const int WIA_AUTO_CROP_MULTI = 2;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_OVER_SCAN_DISABLED"]/*' />
    [NativeTypeName("#define WIA_OVER_SCAN_DISABLED 0")]
    public const int WIA_OVER_SCAN_DISABLED = 0;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_OVER_SCAN_TOP_BOTTOM"]/*' />
    [NativeTypeName("#define WIA_OVER_SCAN_TOP_BOTTOM 1")]
    public const int WIA_OVER_SCAN_TOP_BOTTOM = 1;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_OVER_SCAN_LEFT_RIGHT"]/*' />
    [NativeTypeName("#define WIA_OVER_SCAN_LEFT_RIGHT 2")]
    public const int WIA_OVER_SCAN_LEFT_RIGHT = 2;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_OVER_SCAN_ALL"]/*' />
    [NativeTypeName("#define WIA_OVER_SCAN_ALL 3")]
    public const int WIA_OVER_SCAN_ALL = 3;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_COLOR_DROP_DISABLED"]/*' />
    [NativeTypeName("#define WIA_COLOR_DROP_DISABLED 0")]
    public const int WIA_COLOR_DROP_DISABLED = 0;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_COLOR_DROP_RED"]/*' />
    [NativeTypeName("#define WIA_COLOR_DROP_RED 1")]
    public const int WIA_COLOR_DROP_RED = 1;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_COLOR_DROP_GREEN"]/*' />
    [NativeTypeName("#define WIA_COLOR_DROP_GREEN 2")]
    public const int WIA_COLOR_DROP_GREEN = 2;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_COLOR_DROP_BLUE"]/*' />
    [NativeTypeName("#define WIA_COLOR_DROP_BLUE 3")]
    public const int WIA_COLOR_DROP_BLUE = 3;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_COLOR_DROP_RGB"]/*' />
    [NativeTypeName("#define WIA_COLOR_DROP_RGB 4")]
    public const int WIA_COLOR_DROP_RGB = 4;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_SCAN_AHEAD_DISABLED"]/*' />
    [NativeTypeName("#define WIA_SCAN_AHEAD_DISABLED 0")]
    public const int WIA_SCAN_AHEAD_DISABLED = 0;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_SCAN_AHEAD_ENABLED"]/*' />
    [NativeTypeName("#define WIA_SCAN_AHEAD_ENABLED 1")]
    public const int WIA_SCAN_AHEAD_ENABLED = 1;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_FEEDER_CONTROL_AUTO"]/*' />
    [NativeTypeName("#define WIA_FEEDER_CONTROL_AUTO 0")]
    public const int WIA_FEEDER_CONTROL_AUTO = 0;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_FEEDER_CONTROL_MANUAL"]/*' />
    [NativeTypeName("#define WIA_FEEDER_CONTROL_MANUAL 1")]
    public const int WIA_FEEDER_CONTROL_MANUAL = 1;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_PRINT_PADDING_NONE"]/*' />
    [NativeTypeName("#define WIA_PRINT_PADDING_NONE 0")]
    public const int WIA_PRINT_PADDING_NONE = 0;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_PRINT_PADDING_ZERO"]/*' />
    [NativeTypeName("#define WIA_PRINT_PADDING_ZERO 1")]
    public const int WIA_PRINT_PADDING_ZERO = 1;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_PRINT_PADDING_BLANK"]/*' />
    [NativeTypeName("#define WIA_PRINT_PADDING_BLANK 2")]
    public const int WIA_PRINT_PADDING_BLANK = 2;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_PRINT_FONT_NORMAL"]/*' />
    [NativeTypeName("#define WIA_PRINT_FONT_NORMAL 0")]
    public const int WIA_PRINT_FONT_NORMAL = 0;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_PRINT_FONT_BOLD"]/*' />
    [NativeTypeName("#define WIA_PRINT_FONT_BOLD 1")]
    public const int WIA_PRINT_FONT_BOLD = 1;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_PRINT_FONT_EXTRA_BOLD"]/*' />
    [NativeTypeName("#define WIA_PRINT_FONT_EXTRA_BOLD 2")]
    public const int WIA_PRINT_FONT_EXTRA_BOLD = 2;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_PRINT_FONT_ITALIC_BOLD"]/*' />
    [NativeTypeName("#define WIA_PRINT_FONT_ITALIC_BOLD 3")]
    public const int WIA_PRINT_FONT_ITALIC_BOLD = 3;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_PRINT_FONT_ITALIC_EXTRA_BOLD"]/*' />
    [NativeTypeName("#define WIA_PRINT_FONT_ITALIC_EXTRA_BOLD 4")]
    public const int WIA_PRINT_FONT_ITALIC_EXTRA_BOLD = 4;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_PRINT_FONT_ITALIC"]/*' />
    [NativeTypeName("#define WIA_PRINT_FONT_ITALIC 5")]
    public const int WIA_PRINT_FONT_ITALIC = 5;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_PRINT_FONT_SMALL"]/*' />
    [NativeTypeName("#define WIA_PRINT_FONT_SMALL 6")]
    public const int WIA_PRINT_FONT_SMALL = 6;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_PRINT_FONT_SMALL_BOLD"]/*' />
    [NativeTypeName("#define WIA_PRINT_FONT_SMALL_BOLD 7")]
    public const int WIA_PRINT_FONT_SMALL_BOLD = 7;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_PRINT_FONT_SMALL_EXTRA_BOLD"]/*' />
    [NativeTypeName("#define WIA_PRINT_FONT_SMALL_EXTRA_BOLD 8")]
    public const int WIA_PRINT_FONT_SMALL_EXTRA_BOLD = 8;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_PRINT_FONT_SMALL_ITALIC_BOLD"]/*' />
    [NativeTypeName("#define WIA_PRINT_FONT_SMALL_ITALIC_BOLD 9")]
    public const int WIA_PRINT_FONT_SMALL_ITALIC_BOLD = 9;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_PRINT_FONT_SMALL_ITALIC_EXTRA_BOLD"]/*' />
    [NativeTypeName("#define WIA_PRINT_FONT_SMALL_ITALIC_EXTRA_BOLD 10")]
    public const int WIA_PRINT_FONT_SMALL_ITALIC_EXTRA_BOLD = 10;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_PRINT_FONT_SMALL_ITALIC"]/*' />
    [NativeTypeName("#define WIA_PRINT_FONT_SMALL_ITALIC 11")]
    public const int WIA_PRINT_FONT_SMALL_ITALIC = 11;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_PRINT_FONT_LARGE"]/*' />
    [NativeTypeName("#define WIA_PRINT_FONT_LARGE 12")]
    public const int WIA_PRINT_FONT_LARGE = 12;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_PRINT_FONT_LARGE_BOLD"]/*' />
    [NativeTypeName("#define WIA_PRINT_FONT_LARGE_BOLD 13")]
    public const int WIA_PRINT_FONT_LARGE_BOLD = 13;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_PRINT_FONT_LARGE_EXTRA_BOLD"]/*' />
    [NativeTypeName("#define WIA_PRINT_FONT_LARGE_EXTRA_BOLD 14")]
    public const int WIA_PRINT_FONT_LARGE_EXTRA_BOLD = 14;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_PRINT_FONT_LARGE_ITALIC_BOLD"]/*' />
    [NativeTypeName("#define WIA_PRINT_FONT_LARGE_ITALIC_BOLD 15")]
    public const int WIA_PRINT_FONT_LARGE_ITALIC_BOLD = 15;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_PRINT_FONT_LARGE_ITALIC_EXTRA_BOLD"]/*' />
    [NativeTypeName("#define WIA_PRINT_FONT_LARGE_ITALIC_EXTRA_BOLD 16")]
    public const int WIA_PRINT_FONT_LARGE_ITALIC_EXTRA_BOLD = 16;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_PRINT_FONT_LARGE_ITALIC"]/*' />
    [NativeTypeName("#define WIA_PRINT_FONT_LARGE_ITALIC 17")]
    public const int WIA_PRINT_FONT_LARGE_ITALIC = 17;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_ALARM_NONE"]/*' />
    [NativeTypeName("#define WIA_ALARM_NONE 0")]
    public const int WIA_ALARM_NONE = 0;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_ALARM_BEEP1"]/*' />
    [NativeTypeName("#define WIA_ALARM_BEEP1 1")]
    public const int WIA_ALARM_BEEP1 = 1;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_ALARM_BEEP2"]/*' />
    [NativeTypeName("#define WIA_ALARM_BEEP2 2")]
    public const int WIA_ALARM_BEEP2 = 2;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_ALARM_BEEP3"]/*' />
    [NativeTypeName("#define WIA_ALARM_BEEP3 3")]
    public const int WIA_ALARM_BEEP3 = 3;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_ALARM_BEEP4"]/*' />
    [NativeTypeName("#define WIA_ALARM_BEEP4 4")]
    public const int WIA_ALARM_BEEP4 = 4;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_ALARM_BEEP5"]/*' />
    [NativeTypeName("#define WIA_ALARM_BEEP5 5")]
    public const int WIA_ALARM_BEEP5 = 5;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_ALARM_BEEP6"]/*' />
    [NativeTypeName("#define WIA_ALARM_BEEP6 6")]
    public const int WIA_ALARM_BEEP6 = 6;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_ALARM_BEEP7"]/*' />
    [NativeTypeName("#define WIA_ALARM_BEEP7 7")]
    public const int WIA_ALARM_BEEP7 = 7;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_ALARM_BEEP8"]/*' />
    [NativeTypeName("#define WIA_ALARM_BEEP8 8")]
    public const int WIA_ALARM_BEEP8 = 8;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_ALARM_BEEP9"]/*' />
    [NativeTypeName("#define WIA_ALARM_BEEP9 9")]
    public const int WIA_ALARM_BEEP9 = 9;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_ALARM_BEEP10"]/*' />
    [NativeTypeName("#define WIA_ALARM_BEEP10 10")]
    public const int WIA_ALARM_BEEP10 = 10;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_PRIVATE_DEVPROP"]/*' />
    [NativeTypeName("#define WIA_PRIVATE_DEVPROP 38914")]
    public const int WIA_PRIVATE_DEVPROP = 38914;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_PRIVATE_ITEMPROP"]/*' />
    [NativeTypeName("#define WIA_PRIVATE_ITEMPROP 71682")]
    public const int WIA_PRIVATE_ITEMPROP = 71682;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_ERROR_GENERAL_ERROR"]/*' />
    [NativeTypeName("#define WIA_ERROR_GENERAL_ERROR MAKE_HRESULT(SEVERITY_ERROR, FACILITY_WIA, 1)")]
    public const int WIA_ERROR_GENERAL_ERROR = unchecked((int)(((uint)(1) << 31) | ((uint)(33) << 16) | ((uint)(1))));

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_ERROR_PAPER_JAM"]/*' />
    [NativeTypeName("#define WIA_ERROR_PAPER_JAM MAKE_HRESULT(SEVERITY_ERROR, FACILITY_WIA, 2)")]
    public const int WIA_ERROR_PAPER_JAM = unchecked((int)(((uint)(1) << 31) | ((uint)(33) << 16) | ((uint)(2))));

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_ERROR_PAPER_EMPTY"]/*' />
    [NativeTypeName("#define WIA_ERROR_PAPER_EMPTY MAKE_HRESULT(SEVERITY_ERROR, FACILITY_WIA, 3)")]
    public const int WIA_ERROR_PAPER_EMPTY = unchecked((int)(((uint)(1) << 31) | ((uint)(33) << 16) | ((uint)(3))));

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_ERROR_PAPER_PROBLEM"]/*' />
    [NativeTypeName("#define WIA_ERROR_PAPER_PROBLEM MAKE_HRESULT(SEVERITY_ERROR, FACILITY_WIA, 4)")]
    public const int WIA_ERROR_PAPER_PROBLEM = unchecked((int)(((uint)(1) << 31) | ((uint)(33) << 16) | ((uint)(4))));

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_ERROR_OFFLINE"]/*' />
    [NativeTypeName("#define WIA_ERROR_OFFLINE MAKE_HRESULT(SEVERITY_ERROR, FACILITY_WIA, 5)")]
    public const int WIA_ERROR_OFFLINE = unchecked((int)(((uint)(1) << 31) | ((uint)(33) << 16) | ((uint)(5))));

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_ERROR_BUSY"]/*' />
    [NativeTypeName("#define WIA_ERROR_BUSY MAKE_HRESULT(SEVERITY_ERROR, FACILITY_WIA, 6)")]
    public const int WIA_ERROR_BUSY = unchecked((int)(((uint)(1) << 31) | ((uint)(33) << 16) | ((uint)(6))));

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_ERROR_WARMING_UP"]/*' />
    [NativeTypeName("#define WIA_ERROR_WARMING_UP MAKE_HRESULT(SEVERITY_ERROR, FACILITY_WIA, 7)")]
    public const int WIA_ERROR_WARMING_UP = unchecked((int)(((uint)(1) << 31) | ((uint)(33) << 16) | ((uint)(7))));

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_ERROR_USER_INTERVENTION"]/*' />
    [NativeTypeName("#define WIA_ERROR_USER_INTERVENTION MAKE_HRESULT(SEVERITY_ERROR, FACILITY_WIA, 8)")]
    public const int WIA_ERROR_USER_INTERVENTION = unchecked((int)(((uint)(1) << 31) | ((uint)(33) << 16) | ((uint)(8))));

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_ERROR_ITEM_DELETED"]/*' />
    [NativeTypeName("#define WIA_ERROR_ITEM_DELETED MAKE_HRESULT(SEVERITY_ERROR, FACILITY_WIA, 9)")]
    public const int WIA_ERROR_ITEM_DELETED = unchecked((int)(((uint)(1) << 31) | ((uint)(33) << 16) | ((uint)(9))));

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_ERROR_DEVICE_COMMUNICATION"]/*' />
    [NativeTypeName("#define WIA_ERROR_DEVICE_COMMUNICATION MAKE_HRESULT(SEVERITY_ERROR, FACILITY_WIA, 10)")]
    public const int WIA_ERROR_DEVICE_COMMUNICATION = unchecked((int)(((uint)(1) << 31) | ((uint)(33) << 16) | ((uint)(10))));

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_ERROR_INVALID_COMMAND"]/*' />
    [NativeTypeName("#define WIA_ERROR_INVALID_COMMAND MAKE_HRESULT(SEVERITY_ERROR, FACILITY_WIA, 11)")]
    public const int WIA_ERROR_INVALID_COMMAND = unchecked((int)(((uint)(1) << 31) | ((uint)(33) << 16) | ((uint)(11))));

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_ERROR_INCORRECT_HARDWARE_SETTING"]/*' />
    [NativeTypeName("#define WIA_ERROR_INCORRECT_HARDWARE_SETTING MAKE_HRESULT(SEVERITY_ERROR, FACILITY_WIA, 12)")]
    public const int WIA_ERROR_INCORRECT_HARDWARE_SETTING = unchecked((int)(((uint)(1) << 31) | ((uint)(33) << 16) | ((uint)(12))));

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_ERROR_DEVICE_LOCKED"]/*' />
    [NativeTypeName("#define WIA_ERROR_DEVICE_LOCKED MAKE_HRESULT(SEVERITY_ERROR, FACILITY_WIA, 13)")]
    public const int WIA_ERROR_DEVICE_LOCKED = unchecked((int)(((uint)(1) << 31) | ((uint)(33) << 16) | ((uint)(13))));

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_ERROR_EXCEPTION_IN_DRIVER"]/*' />
    [NativeTypeName("#define WIA_ERROR_EXCEPTION_IN_DRIVER MAKE_HRESULT(SEVERITY_ERROR, FACILITY_WIA, 14)")]
    public const int WIA_ERROR_EXCEPTION_IN_DRIVER = unchecked((int)(((uint)(1) << 31) | ((uint)(33) << 16) | ((uint)(14))));

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_ERROR_INVALID_DRIVER_RESPONSE"]/*' />
    [NativeTypeName("#define WIA_ERROR_INVALID_DRIVER_RESPONSE MAKE_HRESULT(SEVERITY_ERROR, FACILITY_WIA, 15)")]
    public const int WIA_ERROR_INVALID_DRIVER_RESPONSE = unchecked((int)(((uint)(1) << 31) | ((uint)(33) << 16) | ((uint)(15))));

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_ERROR_COVER_OPEN"]/*' />
    [NativeTypeName("#define WIA_ERROR_COVER_OPEN MAKE_HRESULT(SEVERITY_ERROR, FACILITY_WIA, 16)")]
    public const int WIA_ERROR_COVER_OPEN = unchecked((int)(((uint)(1) << 31) | ((uint)(33) << 16) | ((uint)(16))));

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_ERROR_LAMP_OFF"]/*' />
    [NativeTypeName("#define WIA_ERROR_LAMP_OFF MAKE_HRESULT(SEVERITY_ERROR, FACILITY_WIA, 17)")]
    public const int WIA_ERROR_LAMP_OFF = unchecked((int)(((uint)(1) << 31) | ((uint)(33) << 16) | ((uint)(17))));

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_ERROR_DESTINATION"]/*' />
    [NativeTypeName("#define WIA_ERROR_DESTINATION MAKE_HRESULT(SEVERITY_ERROR, FACILITY_WIA, 18)")]
    public const int WIA_ERROR_DESTINATION = unchecked((int)(((uint)(1) << 31) | ((uint)(33) << 16) | ((uint)(18))));

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_ERROR_NETWORK_RESERVATION_FAILED"]/*' />
    [NativeTypeName("#define WIA_ERROR_NETWORK_RESERVATION_FAILED MAKE_HRESULT(SEVERITY_ERROR, FACILITY_WIA, 19)")]
    public const int WIA_ERROR_NETWORK_RESERVATION_FAILED = unchecked((int)(((uint)(1) << 31) | ((uint)(33) << 16) | ((uint)(19))));

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_ERROR_MULTI_FEED"]/*' />
    [NativeTypeName("#define WIA_ERROR_MULTI_FEED MAKE_HRESULT(SEVERITY_ERROR, FACILITY_WIA, 20)")]
    public const int WIA_ERROR_MULTI_FEED = unchecked((int)(((uint)(1) << 31) | ((uint)(33) << 16) | ((uint)(20))));

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_ERROR_MAXIMUM_PRINTER_ENDORSER_COUNTER"]/*' />
    [NativeTypeName("#define WIA_ERROR_MAXIMUM_PRINTER_ENDORSER_COUNTER MAKE_HRESULT(SEVERITY_ERROR, FACILITY_WIA, 21)")]
    public const int WIA_ERROR_MAXIMUM_PRINTER_ENDORSER_COUNTER = unchecked((int)(((uint)(1) << 31) | ((uint)(33) << 16) | ((uint)(21))));

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_STATUS_END_OF_MEDIA"]/*' />
    [NativeTypeName("#define WIA_STATUS_END_OF_MEDIA MAKE_HRESULT(SEVERITY_SUCCESS, FACILITY_WIA, 1)")]
    public const int WIA_STATUS_END_OF_MEDIA = unchecked((int)(((uint)(0) << 31) | ((uint)(33) << 16) | ((uint)(1))));

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_STATUS_WARMING_UP"]/*' />
    [NativeTypeName("#define WIA_STATUS_WARMING_UP MAKE_HRESULT(SEVERITY_SUCCESS, FACILITY_WIA, 2)")]
    public const int WIA_STATUS_WARMING_UP = unchecked((int)(((uint)(0) << 31) | ((uint)(33) << 16) | ((uint)(2))));

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_STATUS_CALIBRATING"]/*' />
    [NativeTypeName("#define WIA_STATUS_CALIBRATING MAKE_HRESULT(SEVERITY_SUCCESS, FACILITY_WIA, 3)")]
    public const int WIA_STATUS_CALIBRATING = unchecked((int)(((uint)(0) << 31) | ((uint)(33) << 16) | ((uint)(3))));

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_STATUS_RESERVING_NETWORK_DEVICE"]/*' />
    [NativeTypeName("#define WIA_STATUS_RESERVING_NETWORK_DEVICE MAKE_HRESULT(SEVERITY_SUCCESS, FACILITY_WIA, 6)")]
    public const int WIA_STATUS_RESERVING_NETWORK_DEVICE = unchecked((int)(((uint)(0) << 31) | ((uint)(33) << 16) | ((uint)(6))));

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_STATUS_NETWORK_DEVICE_RESERVED"]/*' />
    [NativeTypeName("#define WIA_STATUS_NETWORK_DEVICE_RESERVED MAKE_HRESULT(SEVERITY_SUCCESS, FACILITY_WIA, 7)")]
    public const int WIA_STATUS_NETWORK_DEVICE_RESERVED = unchecked((int)(((uint)(0) << 31) | ((uint)(33) << 16) | ((uint)(7))));

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_STATUS_CLEAR"]/*' />
    [NativeTypeName("#define WIA_STATUS_CLEAR MAKE_HRESULT(SEVERITY_SUCCESS, FACILITY_WIA, 8)")]
    public const int WIA_STATUS_CLEAR = unchecked((int)(((uint)(0) << 31) | ((uint)(33) << 16) | ((uint)(8))));

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_STATUS_SKIP_ITEM"]/*' />
    [NativeTypeName("#define WIA_STATUS_SKIP_ITEM MAKE_HRESULT(SEVERITY_SUCCESS, FACILITY_WIA, 9)")]
    public const int WIA_STATUS_SKIP_ITEM = unchecked((int)(((uint)(0) << 31) | ((uint)(33) << 16) | ((uint)(9))));

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_STATUS_NOT_HANDLED"]/*' />
    [NativeTypeName("#define WIA_STATUS_NOT_HANDLED MAKE_HRESULT(SEVERITY_SUCCESS, FACILITY_WIA, 10)")]
    public const int WIA_STATUS_NOT_HANDLED = unchecked((int)(((uint)(0) << 31) | ((uint)(33) << 16) | ((uint)(10))));

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_S_CHANGE_DEVICE"]/*' />
    [NativeTypeName("#define WIA_S_CHANGE_DEVICE MAKE_HRESULT(SEVERITY_SUCCESS, FACILITY_WIA, 11)")]
    public const int WIA_S_CHANGE_DEVICE = unchecked((int)(((uint)(0) << 31) | ((uint)(33) << 16) | ((uint)(11))));

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_S_NO_DEVICE_AVAILABLE"]/*' />
    [NativeTypeName("#define WIA_S_NO_DEVICE_AVAILABLE MAKE_HRESULT(SEVERITY_ERROR, FACILITY_WIA, 21)")]
    public const int WIA_S_NO_DEVICE_AVAILABLE = unchecked((int)(((uint)(1) << 31) | ((uint)(33) << 16) | ((uint)(21))));

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_SELECT_DEVICE_NODEFAULT"]/*' />
    [NativeTypeName("#define WIA_SELECT_DEVICE_NODEFAULT 0x00000001")]
    public const int WIA_SELECT_DEVICE_NODEFAULT = 0x00000001;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DEVICE_DIALOG_SINGLE_IMAGE"]/*' />
    [NativeTypeName("#define WIA_DEVICE_DIALOG_SINGLE_IMAGE 0x00000002")]
    public const int WIA_DEVICE_DIALOG_SINGLE_IMAGE = 0x00000002;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DEVICE_DIALOG_USE_COMMON_UI"]/*' />
    [NativeTypeName("#define WIA_DEVICE_DIALOG_USE_COMMON_UI 0x00000004")]
    public const int WIA_DEVICE_DIALOG_USE_COMMON_UI = 0x00000004;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_REGISTER_EVENT_CALLBACK"]/*' />
    [NativeTypeName("#define WIA_REGISTER_EVENT_CALLBACK 0x00000001")]
    public const int WIA_REGISTER_EVENT_CALLBACK = 0x00000001;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_UNREGISTER_EVENT_CALLBACK"]/*' />
    [NativeTypeName("#define WIA_UNREGISTER_EVENT_CALLBACK 0x00000002")]
    public const int WIA_UNREGISTER_EVENT_CALLBACK = 0x00000002;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_SET_DEFAULT_HANDLER"]/*' />
    [NativeTypeName("#define WIA_SET_DEFAULT_HANDLER 0x00000004")]
    public const int WIA_SET_DEFAULT_HANDLER = 0x00000004;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_NOTIFICATION_EVENT"]/*' />
    [NativeTypeName("#define WIA_NOTIFICATION_EVENT 0x00000001")]
    public const int WIA_NOTIFICATION_EVENT = 0x00000001;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_ACTION_EVENT"]/*' />
    [NativeTypeName("#define WIA_ACTION_EVENT 0x00000002")]
    public const int WIA_ACTION_EVENT = 0x00000002;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_LINE_ORDER_TOP_TO_BOTTOM"]/*' />
    [NativeTypeName("#define WIA_LINE_ORDER_TOP_TO_BOTTOM 0x00000001")]
    public const int WIA_LINE_ORDER_TOP_TO_BOTTOM = 0x00000001;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_LINE_ORDER_BOTTOM_TO_TOP"]/*' />
    [NativeTypeName("#define WIA_LINE_ORDER_BOTTOM_TO_TOP 0x00000002")]
    public const int WIA_LINE_ORDER_BOTTOM_TO_TOP = 0x00000002;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IS_DEFAULT_HANDLER"]/*' />
    [NativeTypeName("#define WIA_IS_DEFAULT_HANDLER 0x00000001")]
    public const int WIA_IS_DEFAULT_HANDLER = 0x00000001;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_EVENT_DEVICE_DISCONNECTED_STR"]/*' />
    [NativeTypeName("#define WIA_EVENT_DEVICE_DISCONNECTED_STR L\"Device Disconnected\"")]
    public const string WIA_EVENT_DEVICE_DISCONNECTED_STR = "Device Disconnected";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_EVENT_DEVICE_CONNECTED_STR"]/*' />
    [NativeTypeName("#define WIA_EVENT_DEVICE_CONNECTED_STR L\"Device Connected\"")]
    public const string WIA_EVENT_DEVICE_CONNECTED_STR = "Device Connected";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_ICON_DEVICE_DISCONNECTED"]/*' />
    [NativeTypeName("#define WIA_ICON_DEVICE_DISCONNECTED (L\"sti.dll,-1001\")")]
    public const string WIA_ICON_DEVICE_DISCONNECTED = ("sti.dll,-1001");

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_ICON_DEVICE_CONNECTED"]/*' />
    [NativeTypeName("#define WIA_ICON_DEVICE_CONNECTED (L\"sti.dll,-1001\")")]
    public const string WIA_ICON_DEVICE_CONNECTED = ("sti.dll,-1001");

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_ICON_ITEM_DELETED"]/*' />
    [NativeTypeName("#define WIA_ICON_ITEM_DELETED (L\"sti.dll,-1001\")")]
    public const string WIA_ICON_ITEM_DELETED = ("sti.dll,-1001");

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_ICON_ITEM_CREATED"]/*' />
    [NativeTypeName("#define WIA_ICON_ITEM_CREATED (L\"sti.dll,-1001\")")]
    public const string WIA_ICON_ITEM_CREATED = ("sti.dll,-1001");

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_ICON_TREE_UPDATED"]/*' />
    [NativeTypeName("#define WIA_ICON_TREE_UPDATED (L\"sti.dll,-1001\")")]
    public const string WIA_ICON_TREE_UPDATED = ("sti.dll,-1001");

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_ICON_VOLUME_INSERT"]/*' />
    [NativeTypeName("#define WIA_ICON_VOLUME_INSERT (L\"sti.dll,-1001\")")]
    public const string WIA_ICON_VOLUME_INSERT = ("sti.dll,-1001");

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_ICON_SCAN_BUTTON_PRESS"]/*' />
    [NativeTypeName("#define WIA_ICON_SCAN_BUTTON_PRESS (L\"sti.dll,-1001\")")]
    public const string WIA_ICON_SCAN_BUTTON_PRESS = ("sti.dll,-1001");

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_ICON_DEVICE_NOT_READY"]/*' />
    [NativeTypeName("#define WIA_ICON_DEVICE_NOT_READY (L\"sti.dll,-1001\")")]
    public const string WIA_ICON_DEVICE_NOT_READY = ("sti.dll,-1001");

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_ICON_DEVICE_READY"]/*' />
    [NativeTypeName("#define WIA_ICON_DEVICE_READY (L\"sti.dll,-1001\")")]
    public const string WIA_ICON_DEVICE_READY = ("sti.dll,-1001");

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_ICON_FLATBED_LID_OPEN"]/*' />
    [NativeTypeName("#define WIA_ICON_FLATBED_LID_OPEN (L\"sti.dll,-1001\")")]
    public const string WIA_ICON_FLATBED_LID_OPEN = ("sti.dll,-1001");

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_ICON_FLATBED_LID_CLOSED"]/*' />
    [NativeTypeName("#define WIA_ICON_FLATBED_LID_CLOSED (L\"sti.dll,-1001\")")]
    public const string WIA_ICON_FLATBED_LID_CLOSED = ("sti.dll,-1001");

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_ICON_FEEDER_LOADED"]/*' />
    [NativeTypeName("#define WIA_ICON_FEEDER_LOADED (L\"sti.dll,-1001\")")]
    public const string WIA_ICON_FEEDER_LOADED = ("sti.dll,-1001");

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_ICON_FEEDER_EMPTIED"]/*' />
    [NativeTypeName("#define WIA_ICON_FEEDER_EMPTIED (L\"sti.dll,-1001\")")]
    public const string WIA_ICON_FEEDER_EMPTIED = ("sti.dll,-1001");

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_ICON_COVER_OPEN"]/*' />
    [NativeTypeName("#define WIA_ICON_COVER_OPEN (L\"sti.dll,-1001\")")]
    public const string WIA_ICON_COVER_OPEN = ("sti.dll,-1001");

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_ICON_COVER_CLOSED"]/*' />
    [NativeTypeName("#define WIA_ICON_COVER_CLOSED (L\"sti.dll,-1001\")")]
    public const string WIA_ICON_COVER_CLOSED = ("sti.dll,-1001");

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_ICON_START_FEEDER"]/*' />
    [NativeTypeName("#define WIA_ICON_START_FEEDER (L\"sti.dll,-1001\")")]
    public const string WIA_ICON_START_FEEDER = ("sti.dll,-1001");

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_ICON_STOP_FEEDER"]/*' />
    [NativeTypeName("#define WIA_ICON_STOP_FEEDER (L\"sti.dll,-1001\")")]
    public const string WIA_ICON_STOP_FEEDER = ("sti.dll,-1001");

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_ICON_SYNCHRONIZE"]/*' />
    [NativeTypeName("#define WIA_ICON_SYNCHRONIZE (L\"sti.dll,-2000\")")]
    public const string WIA_ICON_SYNCHRONIZE = ("sti.dll,-2000");

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_ICON_TAKE_PICTURE"]/*' />
    [NativeTypeName("#define WIA_ICON_TAKE_PICTURE (L\"sti.dll,-2001\")")]
    public const string WIA_ICON_TAKE_PICTURE = ("sti.dll,-2001");

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_ICON_DELETE_ALL_ITEMS"]/*' />
    [NativeTypeName("#define WIA_ICON_DELETE_ALL_ITEMS (L\"sti.dll,-2002\")")]
    public const string WIA_ICON_DELETE_ALL_ITEMS = ("sti.dll,-2002");

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_ICON_CHANGE_DOCUMENT"]/*' />
    [NativeTypeName("#define WIA_ICON_CHANGE_DOCUMENT (L\"sti.dll,-2003\")")]
    public const string WIA_ICON_CHANGE_DOCUMENT = ("sti.dll,-2003");

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_ICON_UNLOAD_DOCUMENT"]/*' />
    [NativeTypeName("#define WIA_ICON_UNLOAD_DOCUMENT (L\"sti.dll,-2004\")")]
    public const string WIA_ICON_UNLOAD_DOCUMENT = ("sti.dll,-2004");

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_ICON_DELETE_DEVICE_TREE"]/*' />
    [NativeTypeName("#define WIA_ICON_DELETE_DEVICE_TREE (L\"sti.dll,-2005\")")]
    public const string WIA_ICON_DELETE_DEVICE_TREE = ("sti.dll,-2005");

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_ICON_BUILD_DEVICE_TREE"]/*' />
    [NativeTypeName("#define WIA_ICON_BUILD_DEVICE_TREE (L\"sti.dll,-2006\")")]
    public const string WIA_ICON_BUILD_DEVICE_TREE = ("sti.dll,-2006");

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_TRANSFER_ACQUIRE_CHILDREN"]/*' />
    [NativeTypeName("#define WIA_TRANSFER_ACQUIRE_CHILDREN 0x0001")]
    public const int WIA_TRANSFER_ACQUIRE_CHILDREN = 0x0001;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_TRANSFER_MSG_STATUS"]/*' />
    [NativeTypeName("#define WIA_TRANSFER_MSG_STATUS 0x00001")]
    public const int WIA_TRANSFER_MSG_STATUS = 0x00001;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_TRANSFER_MSG_END_OF_STREAM"]/*' />
    [NativeTypeName("#define WIA_TRANSFER_MSG_END_OF_STREAM 0x00002")]
    public const int WIA_TRANSFER_MSG_END_OF_STREAM = 0x00002;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_TRANSFER_MSG_END_OF_TRANSFER"]/*' />
    [NativeTypeName("#define WIA_TRANSFER_MSG_END_OF_TRANSFER 0x00003")]
    public const int WIA_TRANSFER_MSG_END_OF_TRANSFER = 0x00003;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_TRANSFER_MSG_DEVICE_STATUS"]/*' />
    [NativeTypeName("#define WIA_TRANSFER_MSG_DEVICE_STATUS 0x00005")]
    public const int WIA_TRANSFER_MSG_DEVICE_STATUS = 0x00005;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_TRANSFER_MSG_NEW_PAGE"]/*' />
    [NativeTypeName("#define WIA_TRANSFER_MSG_NEW_PAGE 0x00006")]
    public const int WIA_TRANSFER_MSG_NEW_PAGE = 0x00006;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_MAJOR_EVENT_DEVICE_CONNECT"]/*' />
    [NativeTypeName("#define WIA_MAJOR_EVENT_DEVICE_CONNECT 0x01")]
    public const int WIA_MAJOR_EVENT_DEVICE_CONNECT = 0x01;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_MAJOR_EVENT_DEVICE_DISCONNECT"]/*' />
    [NativeTypeName("#define WIA_MAJOR_EVENT_DEVICE_DISCONNECT 0x02")]
    public const int WIA_MAJOR_EVENT_DEVICE_DISCONNECT = 0x02;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_MAJOR_EVENT_PICTURE_TAKEN"]/*' />
    [NativeTypeName("#define WIA_MAJOR_EVENT_PICTURE_TAKEN 0x03")]
    public const int WIA_MAJOR_EVENT_PICTURE_TAKEN = 0x03;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_MAJOR_EVENT_PICTURE_DELETED"]/*' />
    [NativeTypeName("#define WIA_MAJOR_EVENT_PICTURE_DELETED 0x04")]
    public const int WIA_MAJOR_EVENT_PICTURE_DELETED = 0x04;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DEVICE_NOT_CONNECTED"]/*' />
    [NativeTypeName("#define WIA_DEVICE_NOT_CONNECTED 0")]
    public const int WIA_DEVICE_NOT_CONNECTED = 0;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DEVICE_CONNECTED"]/*' />
    [NativeTypeName("#define WIA_DEVICE_CONNECTED 1")]
    public const int WIA_DEVICE_CONNECTED = 1;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DEVICE_COMMANDS"]/*' />
    [NativeTypeName("#define WIA_DEVICE_COMMANDS 1")]
    public const int WIA_DEVICE_COMMANDS = 1;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DEVICE_EVENTS"]/*' />
    [NativeTypeName("#define WIA_DEVICE_EVENTS 2")]
    public const int WIA_DEVICE_EVENTS = 2;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DEVINFO_ENUM_ALL"]/*' />
    [NativeTypeName("#define WIA_DEVINFO_ENUM_ALL 0x0000000F")]
    public const int WIA_DEVINFO_ENUM_ALL = 0x0000000F;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DEVINFO_ENUM_LOCAL"]/*' />
    [NativeTypeName("#define WIA_DEVINFO_ENUM_LOCAL 0x00000010")]
    public const int WIA_DEVINFO_ENUM_LOCAL = 0x00000010;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_MAX_CTX_SIZE"]/*' />
    [NativeTypeName("#define WIA_MAX_CTX_SIZE 0x01000000")]
    public const int WIA_MAX_CTX_SIZE = 0x01000000;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_PROP_READ"]/*' />
    [NativeTypeName("#define WIA_PROP_READ 0x01")]
    public const int WIA_PROP_READ = 0x01;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_PROP_WRITE"]/*' />
    [NativeTypeName("#define WIA_PROP_WRITE 0x02")]
    public const int WIA_PROP_WRITE = 0x02;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_PROP_RW"]/*' />
    [NativeTypeName("#define WIA_PROP_RW (WIA_PROP_READ | WIA_PROP_WRITE)")]
    public const int WIA_PROP_RW = (0x01 | 0x02);

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_PROP_SYNC_REQUIRED"]/*' />
    [NativeTypeName("#define WIA_PROP_SYNC_REQUIRED 0x04")]
    public const int WIA_PROP_SYNC_REQUIRED = 0x04;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_PROP_NONE"]/*' />
    [NativeTypeName("#define WIA_PROP_NONE 0x08")]
    public const int WIA_PROP_NONE = 0x08;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_PROP_RANGE"]/*' />
    [NativeTypeName("#define WIA_PROP_RANGE 0x10")]
    public const int WIA_PROP_RANGE = 0x10;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_PROP_LIST"]/*' />
    [NativeTypeName("#define WIA_PROP_LIST 0x20")]
    public const int WIA_PROP_LIST = 0x20;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_PROP_FLAG"]/*' />
    [NativeTypeName("#define WIA_PROP_FLAG 0x40")]
    public const int WIA_PROP_FLAG = 0x40;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_PROP_CACHEABLE"]/*' />
    [NativeTypeName("#define WIA_PROP_CACHEABLE 0x10000")]
    public const int WIA_PROP_CACHEABLE = 0x10000;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_ITEM_CAN_BE_DELETED"]/*' />
    [NativeTypeName("#define WIA_ITEM_CAN_BE_DELETED 0x80")]
    public const int WIA_ITEM_CAN_BE_DELETED = 0x80;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_ITEM_READ"]/*' />
    [NativeTypeName("#define WIA_ITEM_READ WIA_PROP_READ")]
    public const int WIA_ITEM_READ = 0x01;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_ITEM_WRITE"]/*' />
    [NativeTypeName("#define WIA_ITEM_WRITE WIA_PROP_WRITE")]
    public const int WIA_ITEM_WRITE = 0x02;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_ITEM_RD"]/*' />
    [NativeTypeName("#define WIA_ITEM_RD (WIA_ITEM_READ | WIA_ITEM_CAN_BE_DELETED)")]
    public const int WIA_ITEM_RD = (0x01 | 0x80);

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_ITEM_RWD"]/*' />
    [NativeTypeName("#define WIA_ITEM_RWD (WIA_ITEM_READ | WIA_ITEM_WRITE | WIA_ITEM_CAN_BE_DELETED)")]
    public const int WIA_ITEM_RWD = (0x01 | 0x02 | 0x80);

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_RANGE_MIN"]/*' />
    [NativeTypeName("#define WIA_RANGE_MIN 0")]
    public const int WIA_RANGE_MIN = 0;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_RANGE_NOM"]/*' />
    [NativeTypeName("#define WIA_RANGE_NOM 1")]
    public const int WIA_RANGE_NOM = 1;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_RANGE_MAX"]/*' />
    [NativeTypeName("#define WIA_RANGE_MAX 2")]
    public const int WIA_RANGE_MAX = 2;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_RANGE_STEP"]/*' />
    [NativeTypeName("#define WIA_RANGE_STEP 3")]
    public const int WIA_RANGE_STEP = 3;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_RANGE_NUM_ELEMS"]/*' />
    [NativeTypeName("#define WIA_RANGE_NUM_ELEMS 4")]
    public const int WIA_RANGE_NUM_ELEMS = 4;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_LIST_COUNT"]/*' />
    [NativeTypeName("#define WIA_LIST_COUNT 0")]
    public const int WIA_LIST_COUNT = 0;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_LIST_NOM"]/*' />
    [NativeTypeName("#define WIA_LIST_NOM 1")]
    public const int WIA_LIST_NOM = 1;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_LIST_VALUES"]/*' />
    [NativeTypeName("#define WIA_LIST_VALUES 2")]
    public const int WIA_LIST_VALUES = 2;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_LIST_NUM_ELEMS"]/*' />
    [NativeTypeName("#define WIA_LIST_NUM_ELEMS 2")]
    public const int WIA_LIST_NUM_ELEMS = 2;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_FLAG_NOM"]/*' />
    [NativeTypeName("#define WIA_FLAG_NOM 0")]
    public const int WIA_FLAG_NOM = 0;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_FLAG_VALUES"]/*' />
    [NativeTypeName("#define WIA_FLAG_VALUES 1")]
    public const int WIA_FLAG_VALUES = 1;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_FLAG_NUM_ELEMS"]/*' />
    [NativeTypeName("#define WIA_FLAG_NUM_ELEMS 2")]
    public const int WIA_FLAG_NUM_ELEMS = 2;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DIP_FIRST"]/*' />
    [NativeTypeName("#define WIA_DIP_FIRST 2")]
    public const int WIA_DIP_FIRST = 2;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPA_FIRST"]/*' />
    [NativeTypeName("#define WIA_IPA_FIRST 4098")]
    public const int WIA_IPA_FIRST = 4098;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPF_FIRST"]/*' />
    [NativeTypeName("#define WIA_DPF_FIRST 3330")]
    public const int WIA_DPF_FIRST = 3330;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPS_FIRST"]/*' />
    [NativeTypeName("#define WIA_IPS_FIRST 6146")]
    public const int WIA_IPS_FIRST = 6146;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DPS_FIRST"]/*' />
    [NativeTypeName("#define WIA_DPS_FIRST 3074")]
    public const int WIA_DPS_FIRST = 3074;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_IPC_FIRST"]/*' />
    [NativeTypeName("#define WIA_IPC_FIRST 5122")]
    public const int WIA_IPC_FIRST = 5122;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_NUM_IPC"]/*' />
    [NativeTypeName("#define WIA_NUM_IPC 9")]
    public const int WIA_NUM_IPC = 9;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_RESERVED_FOR_NEW_PROPS"]/*' />
    [NativeTypeName("#define WIA_RESERVED_FOR_NEW_PROPS 1024")]
    public const int WIA_RESERVED_FOR_NEW_PROPS = 1024;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_SCAN_AHEAD_ALL"]/*' />
    [NativeTypeName("#define WIA_SCAN_AHEAD_ALL 0")]
    public const int WIA_SCAN_AHEAD_ALL = 0;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_FINAL_SCAN"]/*' />
    [NativeTypeName("#define WIA_FINAL_SCAN 0")]
    public const int WIA_FINAL_SCAN = 0;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_PREVIEW_SCAN"]/*' />
    [NativeTypeName("#define WIA_PREVIEW_SCAN 1")]
    public const int WIA_PREVIEW_SCAN = 1;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_SHOW_PREVIEW_CONTROL"]/*' />
    [NativeTypeName("#define WIA_SHOW_PREVIEW_CONTROL 0")]
    public const int WIA_SHOW_PREVIEW_CONTROL = 0;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DONT_SHOW_PREVIEW_CONTROL"]/*' />
    [NativeTypeName("#define WIA_DONT_SHOW_PREVIEW_CONTROL 1")]
    public const int WIA_DONT_SHOW_PREVIEW_CONTROL = 1;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_ENDORSER_TOK_DATE"]/*' />
    [NativeTypeName("#define WIA_ENDORSER_TOK_DATE L\"$DATE$\"")]
    public const string WIA_ENDORSER_TOK_DATE = "$DATE$";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_ENDORSER_TOK_TIME"]/*' />
    [NativeTypeName("#define WIA_ENDORSER_TOK_TIME L\"$TIME$\"")]
    public const string WIA_ENDORSER_TOK_TIME = "$TIME$";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_ENDORSER_TOK_PAGE_COUNT"]/*' />
    [NativeTypeName("#define WIA_ENDORSER_TOK_PAGE_COUNT L\"$PAGE_COUNT$\"")]
    public const string WIA_ENDORSER_TOK_PAGE_COUNT = "$PAGE_COUNT$";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_ENDORSER_TOK_DAY"]/*' />
    [NativeTypeName("#define WIA_ENDORSER_TOK_DAY L\"$DAY$\"")]
    public const string WIA_ENDORSER_TOK_DAY = "$DAY$";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_ENDORSER_TOK_MONTH"]/*' />
    [NativeTypeName("#define WIA_ENDORSER_TOK_MONTH L\"$MONTH$\"")]
    public const string WIA_ENDORSER_TOK_MONTH = "$MONTH$";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_ENDORSER_TOK_YEAR"]/*' />
    [NativeTypeName("#define WIA_ENDORSER_TOK_YEAR L\"$YEAR$\"")]
    public const string WIA_ENDORSER_TOK_YEAR = "$YEAR$";

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_PAGE_A4"]/*' />
    [NativeTypeName("#define WIA_PAGE_A4 0")]
    public const int WIA_PAGE_A4 = 0;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_PAGE_LETTER"]/*' />
    [NativeTypeName("#define WIA_PAGE_LETTER 1")]
    public const int WIA_PAGE_LETTER = 1;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_PAGE_CUSTOM"]/*' />
    [NativeTypeName("#define WIA_PAGE_CUSTOM 2")]
    public const int WIA_PAGE_CUSTOM = 2;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_PAGE_USLEGAL"]/*' />
    [NativeTypeName("#define WIA_PAGE_USLEGAL 3")]
    public const int WIA_PAGE_USLEGAL = 3;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_PAGE_USLETTER"]/*' />
    [NativeTypeName("#define WIA_PAGE_USLETTER WIA_PAGE_LETTER")]
    public const int WIA_PAGE_USLETTER = 1;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_PAGE_USLEDGER"]/*' />
    [NativeTypeName("#define WIA_PAGE_USLEDGER 4")]
    public const int WIA_PAGE_USLEDGER = 4;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_PAGE_USSTATEMENT"]/*' />
    [NativeTypeName("#define WIA_PAGE_USSTATEMENT 5")]
    public const int WIA_PAGE_USSTATEMENT = 5;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_PAGE_BUSINESSCARD"]/*' />
    [NativeTypeName("#define WIA_PAGE_BUSINESSCARD 6")]
    public const int WIA_PAGE_BUSINESSCARD = 6;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_PAGE_ISO_A0"]/*' />
    [NativeTypeName("#define WIA_PAGE_ISO_A0 7")]
    public const int WIA_PAGE_ISO_A0 = 7;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_PAGE_ISO_A1"]/*' />
    [NativeTypeName("#define WIA_PAGE_ISO_A1 8")]
    public const int WIA_PAGE_ISO_A1 = 8;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_PAGE_ISO_A2"]/*' />
    [NativeTypeName("#define WIA_PAGE_ISO_A2 9")]
    public const int WIA_PAGE_ISO_A2 = 9;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_PAGE_ISO_A3"]/*' />
    [NativeTypeName("#define WIA_PAGE_ISO_A3 10")]
    public const int WIA_PAGE_ISO_A3 = 10;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_PAGE_ISO_A4"]/*' />
    [NativeTypeName("#define WIA_PAGE_ISO_A4 WIA_PAGE_A4")]
    public const int WIA_PAGE_ISO_A4 = 0;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_PAGE_ISO_A5"]/*' />
    [NativeTypeName("#define WIA_PAGE_ISO_A5 11")]
    public const int WIA_PAGE_ISO_A5 = 11;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_PAGE_ISO_A6"]/*' />
    [NativeTypeName("#define WIA_PAGE_ISO_A6 12")]
    public const int WIA_PAGE_ISO_A6 = 12;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_PAGE_ISO_A7"]/*' />
    [NativeTypeName("#define WIA_PAGE_ISO_A7 13")]
    public const int WIA_PAGE_ISO_A7 = 13;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_PAGE_ISO_A8"]/*' />
    [NativeTypeName("#define WIA_PAGE_ISO_A8 14")]
    public const int WIA_PAGE_ISO_A8 = 14;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_PAGE_ISO_A9"]/*' />
    [NativeTypeName("#define WIA_PAGE_ISO_A9 15")]
    public const int WIA_PAGE_ISO_A9 = 15;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_PAGE_ISO_A10"]/*' />
    [NativeTypeName("#define WIA_PAGE_ISO_A10 16")]
    public const int WIA_PAGE_ISO_A10 = 16;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_PAGE_ISO_B0"]/*' />
    [NativeTypeName("#define WIA_PAGE_ISO_B0 17")]
    public const int WIA_PAGE_ISO_B0 = 17;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_PAGE_ISO_B1"]/*' />
    [NativeTypeName("#define WIA_PAGE_ISO_B1 18")]
    public const int WIA_PAGE_ISO_B1 = 18;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_PAGE_ISO_B2"]/*' />
    [NativeTypeName("#define WIA_PAGE_ISO_B2 19")]
    public const int WIA_PAGE_ISO_B2 = 19;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_PAGE_ISO_B3"]/*' />
    [NativeTypeName("#define WIA_PAGE_ISO_B3 20")]
    public const int WIA_PAGE_ISO_B3 = 20;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_PAGE_ISO_B4"]/*' />
    [NativeTypeName("#define WIA_PAGE_ISO_B4 21")]
    public const int WIA_PAGE_ISO_B4 = 21;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_PAGE_ISO_B5"]/*' />
    [NativeTypeName("#define WIA_PAGE_ISO_B5 22")]
    public const int WIA_PAGE_ISO_B5 = 22;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_PAGE_ISO_B6"]/*' />
    [NativeTypeName("#define WIA_PAGE_ISO_B6 23")]
    public const int WIA_PAGE_ISO_B6 = 23;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_PAGE_ISO_B7"]/*' />
    [NativeTypeName("#define WIA_PAGE_ISO_B7 24")]
    public const int WIA_PAGE_ISO_B7 = 24;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_PAGE_ISO_B8"]/*' />
    [NativeTypeName("#define WIA_PAGE_ISO_B8 25")]
    public const int WIA_PAGE_ISO_B8 = 25;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_PAGE_ISO_B9"]/*' />
    [NativeTypeName("#define WIA_PAGE_ISO_B9 26")]
    public const int WIA_PAGE_ISO_B9 = 26;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_PAGE_ISO_B10"]/*' />
    [NativeTypeName("#define WIA_PAGE_ISO_B10 27")]
    public const int WIA_PAGE_ISO_B10 = 27;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_PAGE_ISO_C0"]/*' />
    [NativeTypeName("#define WIA_PAGE_ISO_C0 28")]
    public const int WIA_PAGE_ISO_C0 = 28;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_PAGE_ISO_C1"]/*' />
    [NativeTypeName("#define WIA_PAGE_ISO_C1 29")]
    public const int WIA_PAGE_ISO_C1 = 29;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_PAGE_ISO_C2"]/*' />
    [NativeTypeName("#define WIA_PAGE_ISO_C2 30")]
    public const int WIA_PAGE_ISO_C2 = 30;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_PAGE_ISO_C3"]/*' />
    [NativeTypeName("#define WIA_PAGE_ISO_C3 31")]
    public const int WIA_PAGE_ISO_C3 = 31;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_PAGE_ISO_C4"]/*' />
    [NativeTypeName("#define WIA_PAGE_ISO_C4 32")]
    public const int WIA_PAGE_ISO_C4 = 32;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_PAGE_ISO_C5"]/*' />
    [NativeTypeName("#define WIA_PAGE_ISO_C5 33")]
    public const int WIA_PAGE_ISO_C5 = 33;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_PAGE_ISO_C6"]/*' />
    [NativeTypeName("#define WIA_PAGE_ISO_C6 34")]
    public const int WIA_PAGE_ISO_C6 = 34;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_PAGE_ISO_C7"]/*' />
    [NativeTypeName("#define WIA_PAGE_ISO_C7 35")]
    public const int WIA_PAGE_ISO_C7 = 35;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_PAGE_ISO_C8"]/*' />
    [NativeTypeName("#define WIA_PAGE_ISO_C8 36")]
    public const int WIA_PAGE_ISO_C8 = 36;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_PAGE_ISO_C9"]/*' />
    [NativeTypeName("#define WIA_PAGE_ISO_C9 37")]
    public const int WIA_PAGE_ISO_C9 = 37;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_PAGE_ISO_C10"]/*' />
    [NativeTypeName("#define WIA_PAGE_ISO_C10 38")]
    public const int WIA_PAGE_ISO_C10 = 38;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_PAGE_JIS_B0"]/*' />
    [NativeTypeName("#define WIA_PAGE_JIS_B0 39")]
    public const int WIA_PAGE_JIS_B0 = 39;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_PAGE_JIS_B1"]/*' />
    [NativeTypeName("#define WIA_PAGE_JIS_B1 40")]
    public const int WIA_PAGE_JIS_B1 = 40;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_PAGE_JIS_B2"]/*' />
    [NativeTypeName("#define WIA_PAGE_JIS_B2 41")]
    public const int WIA_PAGE_JIS_B2 = 41;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_PAGE_JIS_B3"]/*' />
    [NativeTypeName("#define WIA_PAGE_JIS_B3 42")]
    public const int WIA_PAGE_JIS_B3 = 42;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_PAGE_JIS_B4"]/*' />
    [NativeTypeName("#define WIA_PAGE_JIS_B4 43")]
    public const int WIA_PAGE_JIS_B4 = 43;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_PAGE_JIS_B5"]/*' />
    [NativeTypeName("#define WIA_PAGE_JIS_B5 44")]
    public const int WIA_PAGE_JIS_B5 = 44;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_PAGE_JIS_B6"]/*' />
    [NativeTypeName("#define WIA_PAGE_JIS_B6 45")]
    public const int WIA_PAGE_JIS_B6 = 45;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_PAGE_JIS_B7"]/*' />
    [NativeTypeName("#define WIA_PAGE_JIS_B7 46")]
    public const int WIA_PAGE_JIS_B7 = 46;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_PAGE_JIS_B8"]/*' />
    [NativeTypeName("#define WIA_PAGE_JIS_B8 47")]
    public const int WIA_PAGE_JIS_B8 = 47;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_PAGE_JIS_B9"]/*' />
    [NativeTypeName("#define WIA_PAGE_JIS_B9 48")]
    public const int WIA_PAGE_JIS_B9 = 48;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_PAGE_JIS_B10"]/*' />
    [NativeTypeName("#define WIA_PAGE_JIS_B10 49")]
    public const int WIA_PAGE_JIS_B10 = 49;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_PAGE_JIS_2A"]/*' />
    [NativeTypeName("#define WIA_PAGE_JIS_2A 50")]
    public const int WIA_PAGE_JIS_2A = 50;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_PAGE_JIS_4A"]/*' />
    [NativeTypeName("#define WIA_PAGE_JIS_4A 51")]
    public const int WIA_PAGE_JIS_4A = 51;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_PAGE_DIN_2B"]/*' />
    [NativeTypeName("#define WIA_PAGE_DIN_2B 52")]
    public const int WIA_PAGE_DIN_2B = 52;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_PAGE_DIN_4B"]/*' />
    [NativeTypeName("#define WIA_PAGE_DIN_4B 53")]
    public const int WIA_PAGE_DIN_4B = 53;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_PAGE_AUTO"]/*' />
    [NativeTypeName("#define WIA_PAGE_AUTO 100")]
    public const int WIA_PAGE_AUTO = 100;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_PAGE_CUSTOM_BASE"]/*' />
    [NativeTypeName("#define WIA_PAGE_CUSTOM_BASE 0x8000")]
    public const int WIA_PAGE_CUSTOM_BASE = 0x8000;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_COMPRESSION_NONE"]/*' />
    [NativeTypeName("#define WIA_COMPRESSION_NONE 0")]
    public const int WIA_COMPRESSION_NONE = 0;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_COMPRESSION_BI_RLE4"]/*' />
    [NativeTypeName("#define WIA_COMPRESSION_BI_RLE4 1")]
    public const int WIA_COMPRESSION_BI_RLE4 = 1;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_COMPRESSION_BI_RLE8"]/*' />
    [NativeTypeName("#define WIA_COMPRESSION_BI_RLE8 2")]
    public const int WIA_COMPRESSION_BI_RLE8 = 2;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_COMPRESSION_G3"]/*' />
    [NativeTypeName("#define WIA_COMPRESSION_G3 3")]
    public const int WIA_COMPRESSION_G3 = 3;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_COMPRESSION_G4"]/*' />
    [NativeTypeName("#define WIA_COMPRESSION_G4 4")]
    public const int WIA_COMPRESSION_G4 = 4;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_COMPRESSION_JPEG"]/*' />
    [NativeTypeName("#define WIA_COMPRESSION_JPEG 5")]
    public const int WIA_COMPRESSION_JPEG = 5;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_COMPRESSION_JBIG"]/*' />
    [NativeTypeName("#define WIA_COMPRESSION_JBIG 6")]
    public const int WIA_COMPRESSION_JBIG = 6;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_COMPRESSION_JPEG2K"]/*' />
    [NativeTypeName("#define WIA_COMPRESSION_JPEG2K 7")]
    public const int WIA_COMPRESSION_JPEG2K = 7;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_COMPRESSION_PNG"]/*' />
    [NativeTypeName("#define WIA_COMPRESSION_PNG 8")]
    public const int WIA_COMPRESSION_PNG = 8;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_COMPRESSION_AUTO"]/*' />
    [NativeTypeName("#define WIA_COMPRESSION_AUTO 100")]
    public const int WIA_COMPRESSION_AUTO = 100;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_PACKED_PIXEL"]/*' />
    [NativeTypeName("#define WIA_PACKED_PIXEL 0")]
    public const int WIA_PACKED_PIXEL = 0;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_PLANAR"]/*' />
    [NativeTypeName("#define WIA_PLANAR 1")]
    public const int WIA_PLANAR = 1;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DATA_THRESHOLD"]/*' />
    [NativeTypeName("#define WIA_DATA_THRESHOLD 0")]
    public const int WIA_DATA_THRESHOLD = 0;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DATA_DITHER"]/*' />
    [NativeTypeName("#define WIA_DATA_DITHER 1")]
    public const int WIA_DATA_DITHER = 1;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DATA_GRAYSCALE"]/*' />
    [NativeTypeName("#define WIA_DATA_GRAYSCALE 2")]
    public const int WIA_DATA_GRAYSCALE = 2;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DATA_COLOR"]/*' />
    [NativeTypeName("#define WIA_DATA_COLOR 3")]
    public const int WIA_DATA_COLOR = 3;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DATA_COLOR_THRESHOLD"]/*' />
    [NativeTypeName("#define WIA_DATA_COLOR_THRESHOLD 4")]
    public const int WIA_DATA_COLOR_THRESHOLD = 4;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DATA_COLOR_DITHER"]/*' />
    [NativeTypeName("#define WIA_DATA_COLOR_DITHER 5")]
    public const int WIA_DATA_COLOR_DITHER = 5;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DATA_RAW_RGB"]/*' />
    [NativeTypeName("#define WIA_DATA_RAW_RGB 6")]
    public const int WIA_DATA_RAW_RGB = 6;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DATA_RAW_BGR"]/*' />
    [NativeTypeName("#define WIA_DATA_RAW_BGR 7")]
    public const int WIA_DATA_RAW_BGR = 7;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DATA_RAW_YUV"]/*' />
    [NativeTypeName("#define WIA_DATA_RAW_YUV 8")]
    public const int WIA_DATA_RAW_YUV = 8;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DATA_RAW_YUVK"]/*' />
    [NativeTypeName("#define WIA_DATA_RAW_YUVK 9")]
    public const int WIA_DATA_RAW_YUVK = 9;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DATA_RAW_CMY"]/*' />
    [NativeTypeName("#define WIA_DATA_RAW_CMY 10")]
    public const int WIA_DATA_RAW_CMY = 10;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DATA_RAW_CMYK"]/*' />
    [NativeTypeName("#define WIA_DATA_RAW_CMYK 11")]
    public const int WIA_DATA_RAW_CMYK = 11;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DATA_AUTO"]/*' />
    [NativeTypeName("#define WIA_DATA_AUTO 100")]
    public const int WIA_DATA_AUTO = 100;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_DEPTH_AUTO"]/*' />
    [NativeTypeName("#define WIA_DEPTH_AUTO 0")]
    public const int WIA_DEPTH_AUTO = 0;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_PHOTO_WHITE_1"]/*' />
    [NativeTypeName("#define WIA_PHOTO_WHITE_1 0")]
    public const int WIA_PHOTO_WHITE_1 = 0;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_PHOTO_WHITE_0"]/*' />
    [NativeTypeName("#define WIA_PHOTO_WHITE_0 1")]
    public const int WIA_PHOTO_WHITE_0 = 1;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_PROPPAGE_SCANNER_ITEM_GENERAL"]/*' />
    [NativeTypeName("#define WIA_PROPPAGE_SCANNER_ITEM_GENERAL 0x00000001")]
    public const int WIA_PROPPAGE_SCANNER_ITEM_GENERAL = 0x00000001;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_PROPPAGE_CAMERA_ITEM_GENERAL"]/*' />
    [NativeTypeName("#define WIA_PROPPAGE_CAMERA_ITEM_GENERAL 0x00000002")]
    public const int WIA_PROPPAGE_CAMERA_ITEM_GENERAL = 0x00000002;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_PROPPAGE_DEVICE_GENERAL"]/*' />
    [NativeTypeName("#define WIA_PROPPAGE_DEVICE_GENERAL 0x00000004")]
    public const int WIA_PROPPAGE_DEVICE_GENERAL = 0x00000004;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_INTENT_NONE"]/*' />
    [NativeTypeName("#define WIA_INTENT_NONE 0x00000000")]
    public const int WIA_INTENT_NONE = 0x00000000;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_INTENT_IMAGE_TYPE_COLOR"]/*' />
    [NativeTypeName("#define WIA_INTENT_IMAGE_TYPE_COLOR 0x00000001")]
    public const int WIA_INTENT_IMAGE_TYPE_COLOR = 0x00000001;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_INTENT_IMAGE_TYPE_GRAYSCALE"]/*' />
    [NativeTypeName("#define WIA_INTENT_IMAGE_TYPE_GRAYSCALE 0x00000002")]
    public const int WIA_INTENT_IMAGE_TYPE_GRAYSCALE = 0x00000002;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_INTENT_IMAGE_TYPE_TEXT"]/*' />
    [NativeTypeName("#define WIA_INTENT_IMAGE_TYPE_TEXT 0x00000004")]
    public const int WIA_INTENT_IMAGE_TYPE_TEXT = 0x00000004;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_INTENT_IMAGE_TYPE_MASK"]/*' />
    [NativeTypeName("#define WIA_INTENT_IMAGE_TYPE_MASK 0x0000000F")]
    public const int WIA_INTENT_IMAGE_TYPE_MASK = 0x0000000F;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_INTENT_MINIMIZE_SIZE"]/*' />
    [NativeTypeName("#define WIA_INTENT_MINIMIZE_SIZE 0x00010000")]
    public const int WIA_INTENT_MINIMIZE_SIZE = 0x00010000;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_INTENT_MAXIMIZE_QUALITY"]/*' />
    [NativeTypeName("#define WIA_INTENT_MAXIMIZE_QUALITY 0x00020000")]
    public const int WIA_INTENT_MAXIMIZE_QUALITY = 0x00020000;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_INTENT_BEST_PREVIEW"]/*' />
    [NativeTypeName("#define WIA_INTENT_BEST_PREVIEW 0x00040000")]
    public const int WIA_INTENT_BEST_PREVIEW = 0x00040000;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_INTENT_SIZE_MASK"]/*' />
    [NativeTypeName("#define WIA_INTENT_SIZE_MASK 0x000F0000")]
    public const int WIA_INTENT_SIZE_MASK = 0x000F0000;

    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_NUM_DIP"]/*' />
    [NativeTypeName("#define WIA_NUM_DIP 16")]
    public const int WIA_NUM_DIP = 16;
}
