// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wia_lh.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

public static partial class IID
{
    public static ref readonly Guid IID_IWiaDevMgr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x2A, 0x50, 0xB2, 0x5E,
                0xF1, 0x8C,
                0xD1, 0x11,
                0xBF,
                0x92,
                0x00,
                0x60,
                0x08,
                0x1E,
                0xD8,
                0x11
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IEnumWIA_DEV_INFO
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x3C, 0xB8, 0x38, 0x5E,
                0xF1, 0x8C,
                0xD1, 0x11,
                0xBF,
                0x92,
                0x00,
                0x60,
                0x08,
                0x1E,
                0xD8,
                0x11
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IWiaEventCallback
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xB0, 0x87, 0x62, 0xAE,
                0x84, 0x00,
                0xD2, 0x11,
                0x97,
                0x3B,
                0x00,
                0xA0,
                0xC9,
                0x06,
                0x8F,
                0x2E
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IWiaDataCallback
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x66, 0xA8, 0x58, 0xA5,
                0xB0, 0xA5,
                0xD2, 0x11,
                0xA0,
                0x8F,
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

    public static ref readonly Guid IID_IWiaDataTransfer
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x98, 0xF9, 0xCE, 0xA6,
                0xB0, 0xA5,
                0xD2, 0x11,
                0xA0,
                0x8F,
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

    public static ref readonly Guid IID_IWiaItem
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x10, 0xAD, 0xB1, 0x4D,
                0x91, 0x33,
                0xD2, 0x11,
                0x9A,
                0x33,
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

    public static ref readonly Guid IID_IWiaPropertyStorage
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xA0, 0xE8, 0xB5, 0x98,
                0xCC, 0x29,
                0x1A, 0x49,
                0xAA,
                0xC0,
                0xE6,
                0xDB,
                0x4F,
                0xDC,
                0xCE,
                0xB6
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IEnumWiaItem
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xFC, 0x83, 0x83, 0x5E,
                0x91, 0x33,
                0xD2, 0x11,
                0x9A,
                0x33,
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

    public static ref readonly Guid IID_IEnumWIA_DEV_CAPS
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x87, 0x42, 0xCC, 0x1F,
                0xA6, 0xAC,
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

    public static ref readonly Guid IID_IEnumWIA_FORMAT_INFO
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x5B, 0xFC, 0xBE, 0x81,
                0x6D, 0x65,
                0xF1, 0x44,
                0xB2,
                0x4C,
                0xD4,
                0x1D,
                0x51,
                0xB4,
                0xDC,
                0x81
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IWiaLog
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xB6, 0x10, 0x0C, 0xA0,
                0xA1, 0x82,
                0x2F, 0x45,
                0x8B,
                0x6C,
                0x86,
                0x06,
                0x2A,
                0xAD,
                0x68,
                0x90
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IWiaLogEx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xAC, 0x22, 0x1F, 0xAF,
                0x40, 0x7A,
                0x87, 0x47,
                0xB4,
                0x21,
                0xAE,
                0xB4,
                0x7A,
                0x1F,
                0xBD,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IWiaNotifyDevMgr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xA0, 0x1E, 0x68, 0x70,
                0xBF, 0xE7,
                0x91, 0x42,
                0x9F,
                0xB1,
                0x4E,
                0x88,
                0x13,
                0xA3,
                0xF7,
                0x8E
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IWiaItemExtras
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x2C, 0xEF, 0x91, 0x62,
                0xEF, 0x36,
                0x32, 0x45,
                0x87,
                0x6A,
                0x8E,
                0x13,
                0x25,
                0x93,
                0x77,
                0x8D
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IWiaAppErrorHandler
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x6C, 0x18, 0x16, 0x6C,
                0xA6, 0xD0,
                0x0C, 0x40,
                0x80,
                0xF4,
                0xD2,
                0x69,
                0x86,
                0xA0,
                0xE7,
                0x34
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IWiaErrorHandler
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xB1, 0x51, 0x4A, 0x0E,
                0x1F, 0xBC,
                0x3D, 0x44,
                0xA8,
                0x35,
                0x72,
                0xE8,
                0x90,
                0x75,
                0x9E,
                0xF3
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IWiaTransfer
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x42, 0x69, 0x9D, 0xC3,
                0x4E, 0x2F,
                0x04, 0x4D,
                0x92,
                0xFE,
                0x4E,
                0xF4,
                0xD3,
                0xA1,
                0xDE,
                0x5A
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IWiaTransferCallback
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xAF, 0xEA, 0xD4, 0x27,
                0xA6, 0x28,
                0xA5, 0x4C,
                0x9A,
                0xAB,
                0xE6,
                0x78,
                0x16,
                0x8B,
                0x95,
                0x27
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IWiaSegmentationFilter
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x97, 0xA6, 0x46, 0xEC,
                0x04, 0xAC,
                0x47, 0x44,
                0x8F,
                0x65,
                0xFF,
                0x63,
                0xD5,
                0x15,
                0x4B,
                0x21
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IWiaImageFilter
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xFA, 0x9F, 0xA7, 0xA8,
                0x0B, 0x45,
                0xF1, 0x41,
                0x8F,
                0x87,
                0x84,
                0x9C,
                0xCD,
                0x94,
                0xEB,
                0xF6
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IWiaPreview
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xFD, 0xB4, 0xC2, 0x95,
                0xF2, 0x33,
                0x86, 0x4D,
                0xAD,
                0x40,
                0x94,
                0x31,
                0xF0,
                0xDF,
                0x08,
                0xF7
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IEnumWiaItem2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xF4, 0x0A, 0x97, 0x59,
                0x0D, 0xCD,
                0xD9, 0x44,
                0xAB,
                0x24,
                0x52,
                0x29,
                0x56,
                0x30,
                0xE5,
                0x82
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IWiaItem2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x75, 0x00, 0xBA, 0x6C,
                0x87, 0x12,
                0x7D, 0x40,
                0x9B,
                0x77,
                0xCF,
                0x0E,
                0x03,
                0x04,
                0x35,
                0xCC
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IWiaDevMgr2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xF1, 0x7C, 0xC0, 0x79,
                0xDD, 0xCB,
                0xEE, 0x41,
                0x8E,
                0xC3,
                0xF0,
                0x00,
                0x80,
                0xCA,
                0xDA,
                0x7A
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
