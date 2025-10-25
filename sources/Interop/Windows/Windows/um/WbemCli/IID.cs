// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WbemCli.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

public static partial class IID
{
    public static ref readonly Guid IID_IWbemClassObject
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x81, 0xA6, 0x12, 0xDC,
                0x7F, 0x73,
                0xCF, 0x11,
                0x88,
                0x4D,
                0x00,
                0xAA,
                0x00,
                0x4B,
                0x2E,
                0x24
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IWbemObjectAccess
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x9A, 0x3C, 0x35, 0x49,
                0x6B, 0x51,
                0xD1, 0x11,
                0xAE,
                0xA6,
                0x00,
                0xC0,
                0x4F,
                0xB6,
                0x88,
                0x20
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IWbemQualifierSet
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x80, 0xA6, 0x12, 0xDC,
                0x7F, 0x73,
                0xCF, 0x11,
                0x88,
                0x4D,
                0x00,
                0xAA,
                0x00,
                0x4B,
                0x2E,
                0x24
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IWbemServices
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x99, 0xDC, 0x56, 0x95,
                0x8C, 0x82,
                0xCF, 0x11,
                0xA3,
                0x7E,
                0x00,
                0xAA,
                0x00,
                0x32,
                0x40,
                0xC7
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IWbemLocator
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x87, 0xA6, 0x12, 0xDC,
                0x7F, 0x73,
                0xCF, 0x11,
                0x88,
                0x4D,
                0x00,
                0xAA,
                0x00,
                0x4B,
                0x2E,
                0x24
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IWbemObjectSink
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x01, 0x78, 0x85, 0x7C,
                0x81, 0x73,
                0xCF, 0x11,
                0x88,
                0x4D,
                0x00,
                0xAA,
                0x00,
                0x4B,
                0x2E,
                0x24
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IEnumWbemClassObject
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xE1, 0x47, 0x79, 0x02,
                0x31, 0xD7,
                0xCE, 0x11,
                0xA3,
                0x57,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x01
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IWbemCallResult
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x75, 0xA6, 0xAC, 0x44,
                0xFC, 0xE8,
                0xD0, 0x11,
                0xA0,
                0x7C,
                0x00,
                0xC0,
                0x4F,
                0xB6,
                0x88,
                0x20
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IWbemContext
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x74, 0xA6, 0xAC, 0x44,
                0xFC, 0xE8,
                0xD0, 0x11,
                0xA0,
                0x7C,
                0x00,
                0xC0,
                0x4F,
                0xB6,
                0x88,
                0x20
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IUnsecuredApartment
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x8C, 0xBA, 0xFA, 0x1C,
                0x23, 0x15,
                0xD1, 0x11,
                0xAD,
                0x79,
                0x00,
                0xC0,
                0x4F,
                0xD8,
                0xFD,
                0xFF
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IWbemUnsecuredApartment
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x04, 0x9D, 0x73, 0x31,
                0x71, 0x34,
                0xF4, 0x4C,
                0x9A,
                0x7C,
                0x57,
                0xA4,
                0x4A,
                0xE7,
                0x19,
                0x56
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IWbemStatusCodeText
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xBC, 0xE1, 0x87, 0xEB,
                0x33, 0x32,
                0xD2, 0x11,
                0xAE,
                0xC9,
                0x00,
                0xC0,
                0x4F,
                0xB6,
                0x88,
                0x20
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IWbemBackupRestore
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xC7, 0x32, 0x9E, 0xC4,
                0x8B, 0xBC,
                0xD2, 0x11,
                0x85,
                0xD4,
                0x00,
                0x10,
                0x5A,
                0x1F,
                0x83,
                0x04
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IWbemBackupRestoreEx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xC5, 0xDE, 0x59, 0xA3,
                0x13, 0xE8,
                0x34, 0x48,
                0x8A,
                0x2A,
                0xBA,
                0x7F,
                0x1D,
                0x77,
                0x7D,
                0x76
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IWbemRefresher
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x99, 0x3C, 0x35, 0x49,
                0x6B, 0x51,
                0xD1, 0x11,
                0xAE,
                0xA6,
                0x00,
                0xC0,
                0x4F,
                0xB6,
                0x88,
                0x20
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IWbemHiPerfEnum
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x88, 0xC2, 0x05, 0x27,
                0xAE, 0x79,
                0xD2, 0x11,
                0xB3,
                0x48,
                0x00,
                0x10,
                0x5A,
                0x1F,
                0x81,
                0x77
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IWbemConfigureRefresher
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x92, 0x3C, 0x35, 0x49,
                0x6B, 0x51,
                0xD1, 0x11,
                0xAE,
                0xA6,
                0x00,
                0xC0,
                0x4F,
                0xB6,
                0x88,
                0x20
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IWbemObjectSinkEx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xFA, 0x5C, 0xD3, 0xE7,
                0x8B, 0x34,
                0x5E, 0x48,
                0xB5,
                0x24,
                0x25,
                0x27,
                0x25,
                0xD6,
                0x97,
                0xCA
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IWbemShutdown
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xF9, 0x1D, 0xB3, 0xB7,
                0x15, 0xD5,
                0xD3, 0x11,
                0xA1,
                0x1C,
                0x00,
                0x10,
                0x5A,
                0x1F,
                0x51,
                0x5A
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IWbemObjectTextSrc
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x3A, 0x88, 0xBF, 0xBF,
                0xD7, 0xCA,
                0xD3, 0x11,
                0xA1,
                0x1B,
                0x00,
                0x10,
                0x5A,
                0x1F,
                0x51,
                0x5A
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMofCompiler
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x4E, 0x97, 0xAF, 0x6D,
                0x37, 0x2E,
                0xD2, 0x11,
                0xAE,
                0xC9,
                0x00,
                0xC0,
                0x4F,
                0xB6,
                0x88,
                0x20
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
