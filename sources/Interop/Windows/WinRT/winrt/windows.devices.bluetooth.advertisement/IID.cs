// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.bluetooth.advertisement.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.WinRT;

namespace TerraFX.Interop.Windows;

public static unsafe partial class IID
{
    public static ref readonly Guid IID_IBluetoothLEAdvertisementPublisher3
    {
        get
        {
            ReadOnlySpan<byte> data = [
                0x02, 0x39, 0xFF, 0x1C,
                0xEC, 0x61,
                0x76, 0x57,
                0xAB,
                0x86,
                0x9B,
                0x41,
                0xF9,
                0x4B,
                0x1E,
                0x66
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IBluetoothLEAdvertisementReceivedEventArgs3
    {
        get
        {
            ReadOnlySpan<byte> data = [
                0x54, 0x4B, 0x20, 0x8D,
                0x86, 0xFF,
                0x84, 0x5D,
                0xA2,
                0x5A,
                0x13,
                0x7D,
                0xCC,
                0xD9,
                0x6F,
                0x7A
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IBluetoothLEAdvertisementScanParameters
    {
        get
        {
            ReadOnlySpan<byte> data = [
                0x13, 0x14, 0xF9, 0x94,
                0xD9, 0x63,
                0xBD, 0x53,
                0xAF,
                0x4C,
                0xE6,
                0xB1,
                0xA6,
                0x51,
                0x45,
                0x95
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IBluetoothLEAdvertisementScanParametersStatics
    {
        get
        {
            ReadOnlySpan<byte> data = [
                0xCD, 0x39, 0x8E, 0x54,
                0x9E, 0x3C,
                0x8D, 0x5F,
                0xB5,
                0xE1,
                0xAD,
                0xEB,
                0xED,
                0x5C,
                0x35,
                0x7C
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IBluetoothLEAdvertisementWatcher3
    {
        get
        {
            ReadOnlySpan<byte> data = [
                0xBE, 0x80, 0xD9, 0x14,
                0x02, 0x40,
                0xBE, 0x5D,
                0x85,
                0x19,
                0xFF,
                0xCA,
                0x6C,
                0xA3,
                0x89,
                0xF0
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
