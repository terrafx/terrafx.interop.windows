// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.enumeration.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.WinRT;

namespace TerraFX.Interop.Windows;

public static unsafe partial class IID
{
    [NativeTypeName("const IID &")]
    public static Guid* IID_IDeviceAccessChangedEventArgs3 = typeof(IDeviceAccessChangedEventArgs3).GUID;

    [NativeTypeName("const IID &")]
    public static Guid* IID_IDeviceAccessInformation2 = typeof(IDeviceAccessInformation2).GUID;

    [NativeTypeName("const IID &")]
    public static Guid* IID_IDeviceEnumerationSettings = typeof(IDeviceEnumerationSettings).GUID;

    [NativeTypeName("const IID &")]
    public static Guid* IID_IDeviceInformationCustomPairing2 = typeof(IDeviceInformationCustomPairing2).GUID;

    [NativeTypeName("const IID &")]
    public static Guid* IID_IDeviceInformationStatics3 = typeof(IDeviceInformationStatics3).GUID;

    [NativeTypeName("const IID &")]
    public static Guid* IID_IDevicePairingRequestedEventArgs3 = typeof(IDevicePairingRequestedEventArgs3).GUID;

    [NativeTypeName("const IID &")]
    public static Guid* IID_IDevicePairingSetMembersRequestedEventArgs = typeof(IDevicePairingSetMembersRequestedEventArgs).GUID;

    public static ref readonly Guid IID_IDeviceAccessChangedEventArgs3
    {
        get
        {
            ReadOnlySpan<byte> data = [
                0x78, 0xA8, 0x80, 0x75,
                0xD9, 0x7F,
                0xD7, 0x5C,
                0x85,
                0x60,
                0x3C,
                0x64,
                0x4B,
                0x9B,
                0x10,
                0xDB
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDeviceAccessInformation2
    {
        get
        {
            ReadOnlySpan<byte> data = [
                0xF6, 0xDF, 0xB9, 0xE2,
                0x8F, 0xE8,
                0x0A, 0x5D,
                0x9C,
                0x1E,
                0xD7,
                0x88,
                0x80,
                0x8D,
                0xF4,
                0x7B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDeviceEnumerationSettings
    {
        get
        {
            ReadOnlySpan<byte> data = [
                0x66, 0x0F, 0x71, 0xF7,
                0xF3, 0x9F,
                0xC8, 0x41,
                0x85,
                0xEB,
                0x87,
                0xF8,
                0x11,
                0x48,
                0xA3,
                0x0F
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDeviceInformationCustomPairing2
    {
        get
        {
            ReadOnlySpan<byte> data = [
                0x62, 0xA6, 0xBD, 0x0E,
                0x96, 0xE6,
                0xA9, 0x5F,
                0x8F,
                0x72,
                0x80,
                0xCF,
                0xEB,
                0xCD,
                0x85,
                0x1D
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDeviceInformationStatics3
    {
        get
        {
            ReadOnlySpan<byte> data = [
                0x79, 0x62, 0xF0, 0x25,
                0x64, 0x93,
                0x6C, 0x5A,
                0x8A,
                0x54,
                0x5D,
                0x4A,
                0x6D,
                0x3D,
                0x92,
                0x2A
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDevicePairingRequestedEventArgs3
    {
        get
        {
            ReadOnlySpan<byte> data = [
                0x38, 0x5A, 0x5E, 0x19,
                0xDC, 0x43,
                0x2F, 0x56,
                0xBA,
                0xBE,
                0xEF,
                0xC8,
                0xB1,
                0x10,
                0x08,
                0x8B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDevicePairingSetMembersRequestedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data = [
                0xFF, 0x2C, 0xB4, 0x7F,
                0xAC, 0xEC,
                0x12, 0x50,
                0x8D,
                0x7D,
                0xA1,
                0x89,
                0x46,
                0x80,
                0xA3,
                0x49
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
