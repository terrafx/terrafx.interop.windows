// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/credentialprovider.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

public static partial class IID
{
    public static ref readonly Guid IID_ICredentialProviderCredential
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x93, 0x3A, 0x91, 0x63,
                0xC1, 0x40,
                0x1A, 0x48,
                0x81,
                0x8D,
                0x40,
                0x72,
                0xFF,
                0x8C,
                0x70,
                0xCC
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IQueryContinueWithStatus
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x5B, 0xBE, 0x90, 0x90,
                0x2B, 0x50,
                0xFB, 0x41,
                0xBC,
                0xCC,
                0x00,
                0x49,
                0xA6,
                0xC7,
                0x25,
                0x4B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IConnectableCredentialProviderCredential
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x8B, 0x92, 0x87, 0x93,
                0x75, 0xAC,
                0xF9, 0x4B,
                0x8A,
                0xB2,
                0x2B,
                0x93,
                0xC4,
                0xA5,
                0x52,
                0x90
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ICredentialProviderCredentialEvents
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x6B, 0xA7, 0x6F, 0xFA,
                0xB7, 0x66,
                0x11, 0x4B,
                0x95,
                0xF1,
                0x86,
                0x17,
                0x11,
                0x18,
                0xE8,
                0x16
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ICredentialProvider
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x81, 0x34, 0x7C, 0xD2,
                0x1C, 0x5A,
                0xB2, 0x45,
                0x8A,
                0xAA,
                0xC2,
                0x0E,
                0xBB,
                0xE8,
                0x22,
                0x9E
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ICredentialProviderEvents
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x5A, 0x1E, 0x20, 0x34,
                0x87, 0xA7,
                0xA3, 0x41,
                0xA5,
                0xA4,
                0xBD,
                0x6D,
                0xCF,
                0x2A,
                0x85,
                0x4E
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ICredentialProviderFilter
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xF9, 0x53, 0xDA, 0xA5,
                0x75, 0xD4,
                0x80, 0x40,
                0xA1,
                0x20,
                0x91,
                0x0C,
                0x4A,
                0x73,
                0x98,
                0x80
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ICredentialProviderCredential2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x54, 0x2C, 0x67, 0xFD,
                0xEA, 0x40,
                0x6E, 0x4D,
                0x9B,
                0x49,
                0xCF,
                0xB1,
                0xA7,
                0x50,
                0x7B,
                0xD7
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ICredentialProviderCredentialWithFieldOptions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x30, 0xFB, 0xC6, 0xDB,
                0x43, 0xC8,
                0xE3, 0x49,
                0xA6,
                0x45,
                0x57,
                0x3E,
                0x6F,
                0x39,
                0x44,
                0x6A
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ICredentialProviderCredentialEvents2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xB6, 0x00, 0x3C, 0xB5,
                0x22, 0x99,
                0x78, 0x4B,
                0xB1,
                0xF4,
                0xDD,
                0xFE,
                0x77,
                0x4D,
                0xC3,
                0x9B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ICredentialProviderUser
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x85, 0x32, 0x79, 0x13,
                0xA6, 0x3E,
                0xFD, 0x40,
                0xB4,
                0x20,
                0x15,
                0xF4,
                0x7D,
                0xA4,
                0x1F,
                0xBB
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ICredentialProviderUserArray
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xAE, 0x19, 0xC1, 0x90,
                0x18, 0x0F,
                0x20, 0x45,
                0xA1,
                0xF1,
                0x11,
                0x43,
                0x66,
                0xA4,
                0x0F,
                0xE8
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ICredentialProviderSetUserArray
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x84, 0x14, 0x5C, 0x09,
                0x0C, 0x1C,
                0x88, 0x43,
                0x9C,
                0x6D,
                0x50,
                0x0E,
                0x61,
                0xBF,
                0x84,
                0xBD
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
