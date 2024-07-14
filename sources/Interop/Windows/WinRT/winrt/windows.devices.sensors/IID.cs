// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.sensors.h in the Windows SDK for Windows 10.0.26100.0
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
    public static Guid* IID_IDetectedPerson = typeof(IDetectedPerson).GUID;

    [NativeTypeName("const IID &")]
    public static Guid* IID_IHeadOrientation = typeof(IHeadOrientation).GUID;

    [NativeTypeName("const IID &")]
    public static Guid* IID_IHeadPosition = typeof(IHeadPosition).GUID;

    [NativeTypeName("const IID &")]
    public static Guid* IID_IHumanPresenceSensor3 = typeof(IHumanPresenceSensor3).GUID;

    [NativeTypeName("const IID &")]
    public static Guid* IID_IHumanPresenceSensorReading3 = typeof(IHumanPresenceSensorReading3).GUID;

    public static ref readonly Guid IID_IDetectedPerson
    {
        get
        {
            ReadOnlySpan<byte> data = [
                0xD9, 0xC0, 0x8C, 0x16,
                0x05, 0x3F,
                0x29, 0x50,
                0xA0,
                0xBF,
                0xCD,
                0xCA,
                0xB4,
                0xBE,
                0x3F,
                0x9E
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHeadOrientation
    {
        get
        {
            ReadOnlySpan<byte> data = [
                0xA9, 0x54, 0x9F, 0x51,
                0x3E, 0x51,
                0xE8, 0x55,
                0x9C,
                0x35,
                0x3E,
                0x8D,
                0xA2,
                0x1D,
                0xEE,
                0x69
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHeadPosition
    {
        get
        {
            ReadOnlySpan<byte> data = [
                0x65, 0xEB, 0x5A, 0x58,
                0x35, 0xCF,
                0x6D, 0x5E,
                0xA7,
                0x6A,
                0x37,
                0xDB,
                0x13,
                0x1E,
                0x17,
                0xDE
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHumanPresenceSensor3
    {
        get
        {
            ReadOnlySpan<byte> data = [
                0x6D, 0x00, 0x3F, 0x96,
                0x0D, 0x09,
                0x2C, 0x53,
                0x9E,
                0xAF,
                0x80,
                0x3A,
                0x9F,
                0x69,
                0x28,
                0x5B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHumanPresenceSensorReading3
    {
        get
        {
            ReadOnlySpan<byte> data = [
                0x18, 0xD9, 0x76, 0xB8,
                0x69, 0xF0,
                0x6F, 0x58,
                0x90,
                0xE3,
                0x7C,
                0x6F,
                0xA5,
                0xC5,
                0xD3,
                0x3A
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
