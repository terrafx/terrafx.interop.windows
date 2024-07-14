// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.printers.h in the Windows SDK for Windows 10.0.26100.0
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
    public static Guid* IID_IIppPrintDevice3 = typeof(IIppPrintDevice3).GUID;

    [NativeTypeName("const IID &")]
    public static Guid* IID_IIppPrintDevice4 = typeof(IIppPrintDevice4).GUID;

    public static ref readonly Guid IID_IIppPrintDevice3
    {
        get
        {
            ReadOnlySpan<byte> data = [
                0x6D, 0x8F, 0x25, 0xB6,
                0x6D, 0xA4,
                0x37, 0x5E,
                0x80,
                0xCE,
                0x5F,
                0x69,
                0xD5,
                0x54,
                0x47,
                0x12
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IIppPrintDevice4
    {
        get
        {
            ReadOnlySpan<byte> data = [
                0x7E, 0x24, 0x48, 0x8C,
                0x69, 0xE8,
                0xFB, 0x59,
                0xBC,
                0x6D,
                0xDA,
                0xEA,
                0x06,
                0x14,
                0xF9,
                0x3E
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
