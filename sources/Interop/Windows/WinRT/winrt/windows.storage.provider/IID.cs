// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.provider.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.WinRT;

namespace TerraFX.Interop.Windows;

public static unsafe partial class IID
{
    public static ref readonly Guid IID_IStorageProviderQueryResult
    {
        get
        {
            ReadOnlySpan<byte> data = [
                0xAE, 0x00, 0xCD, 0xF1,
                0xA9, 0xB4,
                0x20, 0x5D,
                0xA5,
                0x98,
                0x3E,
                0xB4,
                0xDD,
                0x8F,
                0xF8,
                0xF4
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IStorageProviderQueryResultSet
    {
        get
        {
            ReadOnlySpan<byte> data = [
                0x07, 0x84, 0xC2, 0x57,
                0x21, 0x7D,
                0x98, 0x5F,
                0xAC,
                0x52,
                0x09,
                0x26,
                0xA9,
                0x7F,
                0x32,
                0x59
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IStorageProviderQueryResultSetFactory
    {
        get
        {
            ReadOnlySpan<byte> data = [
                0xC2, 0x74, 0x19, 0x30,
                0x0A, 0x9B,
                0xD1, 0x51,
                0x84,
                0xB5,
                0x32,
                0x57,
                0x8E,
                0xE3,
                0x08,
                0x3D
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IStorageProviderSearchHandler
    {
        get
        {
            ReadOnlySpan<byte> data = [
                0x7D, 0x97, 0xCC, 0x69,
                0xAD, 0xAD,
                0xC9, 0x59,
                0x8F,
                0xD1,
                0xF3,
                0x0B,
                0x6F,
                0xAE,
                0x0F,
                0xD9
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IStorageProviderSearchHandlerFactory
    {
        get
        {
            ReadOnlySpan<byte> data = [
                0x80, 0xAD, 0xDC, 0xB0,
                0xF5, 0xF3,
                0x6B, 0x51,
                0x8A,
                0xCE,
                0x4E,
                0x77,
                0x02,
                0x2C,
                0x95,
                0x98
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IStorageProviderSearchQueryOptions
    {
        get
        {
            ReadOnlySpan<byte> data = [
                0xEB, 0x54, 0xD8, 0x93,
                0x07, 0x10,
                0x3C, 0x56,
                0xB2,
                0x13,
                0xCC,
                0x44,
                0xBD,
                0x88,
                0xFE,
                0xF2
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IStorageProviderSearchResult
    {
        get
        {
            ReadOnlySpan<byte> data = [
                0x49, 0x10, 0x16, 0xFC,
                0x95, 0x09,
                0x5F, 0x53,
                0x99,
                0xB7,
                0xFE,
                0x29,
                0x2C,
                0xBA,
                0xBA,
                0xF5
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
