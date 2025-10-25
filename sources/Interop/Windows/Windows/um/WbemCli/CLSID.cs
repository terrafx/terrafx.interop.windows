// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WbemCli.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

public static partial class CLSID
{
    public static ref readonly Guid CLSID_WbemLocator
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x11, 0xF8, 0x90, 0x45,
                0x3A, 0x1D,
                0xD0, 0x11,
                0x89,
                0x1F,
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

    public static ref readonly Guid CLSID_WbemContext
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x98, 0x66, 0x4B, 0x67,
                0x92, 0xEE,
                0xD0, 0x11,
                0xAD,
                0x71,
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

    public static ref readonly Guid CLSID_UnsecuredApartment
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x28, 0x20, 0xBD, 0x49,
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

    public static ref readonly Guid CLSID_WbemClassObject
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x86, 0x30, 0x65, 0x9A,
                0x4F, 0x17,
                0xD2, 0x11,
                0xB5,
                0xF9,
                0x00,
                0x10,
                0x4B,
                0x70,
                0x3E,
                0xFD
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_MofCompiler
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x57, 0x97, 0xAF, 0x6D,
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

    public static ref readonly Guid CLSID_WbemStatusCodeText
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xBD, 0xE1, 0x87, 0xEB,
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

    public static ref readonly Guid CLSID_WbemBackupRestore
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xC6, 0x32, 0x9E, 0xC4,
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

    public static ref readonly Guid CLSID_WbemRefresher
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xF2, 0x66, 0x15, 0xC7,
                0x1E, 0x56,
                0xD1, 0x11,
                0xAD,
                0x87,
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

    public static ref readonly Guid CLSID_WbemObjectTextSrc
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x9D, 0x55, 0x1C, 0x8D,
                0xF0, 0x84,
                0xB3, 0x4B,
                0xA7,
                0xD5,
                0x56,
                0xA7,
                0x43,
                0x5A,
                0x9B,
                0xA6
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
