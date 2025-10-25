// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/credentialprovider.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

public static partial class CLSID
{
    public static ref readonly Guid CLSID_PasswordCredentialProvider
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x88, 0x8E, 0xB7, 0x60,
                0xD8, 0xEA,
                0x5C, 0x44,
                0x9C,
                0xFD,
                0x0B,
                0x87,
                0xF7,
                0x4E,
                0xA6,
                0xCD
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_V1PasswordCredentialProvider
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x1E, 0xDC, 0x45, 0x6F,
                0x84, 0x53,
                0x7A, 0x45,
                0xBC,
                0x13,
                0x2C,
                0xD8,
                0x1B,
                0x0D,
                0x28,
                0xED
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_PINLogonCredentialProvider
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x12, 0xEA, 0x82, 0xCB,
                0x71, 0x9F,
                0x6D, 0x44,
                0x89,
                0xE1,
                0x8D,
                0x09,
                0x24,
                0xE1,
                0x25,
                0x6E
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_NPCredentialProvider
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xC0, 0xBE, 0xD6, 0x3D,
                0x93, 0x81,
                0xFE, 0x4F,
                0xAE,
                0x25,
                0xE0,
                0x8E,
                0x39,
                0xEA,
                0x40,
                0x63
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_SmartcardCredentialProvider
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x9C, 0xE1, 0xD7, 0x8F,
                0xF7, 0x3B,
                0x9B, 0x48,
                0xA7,
                0x2C,
                0x84,
                0x6A,
                0xB3,
                0x67,
                0x8C,
                0x96
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_V1SmartcardCredentialProvider
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x10, 0xA9, 0xF9, 0x8B,
                0xFF, 0xA8,
                0x7F, 0x45,
                0x99,
                0x9F,
                0xA5,
                0xCA,
                0x10,
                0xB4,
                0xA8,
                0x85
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_SmartcardPinProvider
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x7E, 0x6C, 0x59, 0x94,
                0x44, 0x37,
                0xCE, 0x41,
                0x89,
                0x3E,
                0xBB,
                0xF0,
                0x91,
                0x22,
                0xF7,
                0x6A
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_SmartcardReaderSelectionProvider
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x61, 0x38, 0x28, 0x1B,
                0x4F, 0x75,
                0x22, 0x40,
                0xAD,
                0x47,
                0xA5,
                0xEA,
                0xAA,
                0x61,
                0x88,
                0x94
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_SmartcardWinRTProvider
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x7F, 0x33, 0xE7, 0x1E,
                0xAC, 0x85,
                0xE2, 0x45,
                0xA2,
                0x3C,
                0x37,
                0xC7,
                0x53,
                0x20,
                0x97,
                0x69
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_GenericCredentialProvider
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x96, 0xB9, 0xCB, 0x25,
                0xED, 0x92,
                0x7E, 0x45,
                0xB2,
                0x8C,
                0x47,
                0x74,
                0x08,
                0x4B,
                0xD5,
                0x62
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_RASProvider
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x83, 0xE2, 0x37, 0x55,
                0xE7, 0xB1,
                0xF8, 0x4E,
                0x9C,
                0x6E,
                0x7A,
                0xB0,
                0xAF,
                0xE5,
                0x05,
                0x6D
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_OnexCredentialProvider
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x86, 0x08, 0xAA, 0x07,
                0x8D, 0xCC,
                0x19, 0x4E,
                0xA4,
                0x10,
                0x1C,
                0x75,
                0xAF,
                0x68,
                0x6E,
                0x62
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_OnexPlapSmartcardCredentialProvider
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xD6, 0x6C, 0xC8, 0x33,
                0x5F, 0x70,
                0xA1, 0x4B,
                0x9A,
                0xDB,
                0x67,
                0x07,
                0x0B,
                0x83,
                0x77,
                0x75
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_VaultProvider
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xD0, 0x39, 0x37, 0x50,
                0x5E, 0x4C,
                0xFD, 0x4C,
                0xB3,
                0xBA,
                0xD8,
                0x81,
                0x33,
                0x4F,
                0x0D,
                0xF2
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_WinBioCredentialProvider
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x23, 0x92, 0xC0, 0xBE,
                0x18, 0xB0,
                0x6D, 0x41,
                0xA0,
                0xAC,
                0x52,
                0x39,
                0x71,
                0xB6,
                0x39,
                0xF5
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_V1WinBioCredentialProvider
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x49, 0xC2, 0x3A, 0xAC,
                0x20, 0xE8,
                0x43, 0x43,
                0xA6,
                0x5B,
                0x37,
                0x7A,
                0xC6,
                0x34,
                0xDC,
                0x09
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
