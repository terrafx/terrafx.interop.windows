// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/imapi2.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

public static partial class CLSID
{
    public static ref readonly Guid CLSID_MsftDiscRecorder2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x2D, 0x41, 0x35, 0x27,
                0x64, 0x7F,
                0x0F, 0x5B,
                0x8F,
                0x00,
                0x5D,
                0x77,
                0xAF,
                0xBE,
                0x26,
                0x1E
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_MsftWriteEngine2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x2C, 0x41, 0x35, 0x27,
                0x64, 0x7F,
                0x0F, 0x5B,
                0x8F,
                0x00,
                0x5D,
                0x77,
                0xAF,
                0xBE,
                0x26,
                0x1E
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_MsftDiscFormat2Erase
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x2B, 0x41, 0x35, 0x27,
                0x64, 0x7F,
                0x0F, 0x5B,
                0x8F,
                0x00,
                0x5D,
                0x77,
                0xAF,
                0xBE,
                0x26,
                0x1E
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_MsftDiscFormat2Data
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x2A, 0x41, 0x35, 0x27,
                0x64, 0x7F,
                0x0F, 0x5B,
                0x8F,
                0x00,
                0x5D,
                0x77,
                0xAF,
                0xBE,
                0x26,
                0x1E
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_MsftDiscFormat2TrackAtOnce
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x29, 0x41, 0x35, 0x27,
                0x64, 0x7F,
                0x0F, 0x5B,
                0x8F,
                0x00,
                0x5D,
                0x77,
                0xAF,
                0xBE,
                0x26,
                0x1E
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_MsftDiscFormat2RawCD
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x28, 0x41, 0x35, 0x27,
                0x64, 0x7F,
                0x0F, 0x5B,
                0x8F,
                0x00,
                0x5D,
                0x77,
                0xAF,
                0xBE,
                0x26,
                0x1E
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_MsftStreamZero
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x27, 0x41, 0x35, 0x27,
                0x64, 0x7F,
                0x0F, 0x5B,
                0x8F,
                0x00,
                0x5D,
                0x77,
                0xAF,
                0xBE,
                0x26,
                0x1E
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_MsftStreamPrng001
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x26, 0x41, 0x35, 0x27,
                0x64, 0x7F,
                0x0F, 0x5B,
                0x8F,
                0x00,
                0x5D,
                0x77,
                0xAF,
                0xBE,
                0x26,
                0x1E
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_MsftStreamConcatenate
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x25, 0x41, 0x35, 0x27,
                0x64, 0x7F,
                0x0F, 0x5B,
                0x8F,
                0x00,
                0x5D,
                0x77,
                0xAF,
                0xBE,
                0x26,
                0x1E
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_MsftStreamInterleave
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x24, 0x41, 0x35, 0x27,
                0x64, 0x7F,
                0x0F, 0x5B,
                0x8F,
                0x00,
                0x5D,
                0x77,
                0xAF,
                0xBE,
                0x26,
                0x1E
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_MsftWriteSpeedDescriptor
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x23, 0x41, 0x35, 0x27,
                0x64, 0x7F,
                0x0F, 0x5B,
                0x8F,
                0x00,
                0x5D,
                0x77,
                0xAF,
                0xBE,
                0x26,
                0x1E
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_MsftMultisessionSequential
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x22, 0x41, 0x35, 0x27,
                0x64, 0x7F,
                0x0F, 0x5B,
                0x8F,
                0x00,
                0x5D,
                0x77,
                0xAF,
                0xBE,
                0x26,
                0x1E
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_MsftMultisessionRandomWrite
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x24, 0xCA, 0x07, 0xB5,
                0x04, 0x22,
                0xDD, 0x11,
                0x96,
                0x6A,
                0x00,
                0x1A,
                0xA0,
                0x1B,
                0xBC,
                0x58
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_MsftRawCDImageCreator
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x61, 0x35, 0x98, 0x25,
                0x65, 0x9D,
                0xCE, 0x49,
                0xB3,
                0x35,
                0x40,
                0x63,
                0x0D,
                0x90,
                0x12,
                0x27
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
