// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.power.h in the Windows SDK for Windows 10.0.26100.0
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
    public static Guid* IID_IPowerGridData = typeof(IPowerGridData).GUID;

    [NativeTypeName("const IID &")]
    public static Guid* IID_IPowerGridForecast = typeof(IPowerGridForecast).GUID;

    [NativeTypeName("const IID &")]
    public static Guid* IID_IPowerGridForecastStatics = typeof(IPowerGridForecastStatics).GUID;

    public static ref readonly Guid IID_IPowerGridData
    {
        get
        {
            ReadOnlySpan<byte> data = [
                0x17, 0xFB, 0x60, 0xC3,
                0x92, 0xFC,
                0x6E, 0x5F,
                0x99,
                0x9D,
                0x16,
                0xA4,
                0xCF,
                0x9D,
                0x6C,
                0x40
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IPowerGridForecast
    {
        get
        {
            ReadOnlySpan<byte> data = [
                0xE9, 0x4D, 0x7E, 0x07,
                0x60, 0xED,
                0xBB, 0x58,
                0xA8,
                0x50,
                0x00,
                0x3C,
                0x6A,
                0x13,
                0x86,
                0x85
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IPowerGridForecastStatics
    {
        get
        {
            ReadOnlySpan<byte> data = [
                0x06, 0xC8, 0x78, 0x5B,
                0x4E, 0x2E,
                0xCC, 0x5B,
                0xBB,
                0x34,
                0xCB,
                0x81,
                0xC6,
                0x0F,
                0x9E,
                0x12
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
