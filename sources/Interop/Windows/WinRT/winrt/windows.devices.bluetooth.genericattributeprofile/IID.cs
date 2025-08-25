// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.bluetooth.genericattributeprofile.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.WinRT;

namespace TerraFX.Interop.Windows;

public static unsafe partial class IID
{
    public static ref readonly Guid IID_IGattServiceProvider2
    {
        get
        {
            ReadOnlySpan<byte> data = [
                0xA9, 0x31, 0xF5, 0x9E,
                0x12, 0xCF,
                0xA3, 0x59,
                0xA8,
                0x1C,
                0x36,
                0x2F,
                0x4A,
                0xAB,
                0xAA,
                0xCF
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IGattServiceProviderAdvertisingParameters3
    {
        get
        {
            ReadOnlySpan<byte> data = [
                0xB2, 0x46, 0x35, 0xA2,
                0x16, 0xB2,
                0x29, 0x59,
                0x90,
                0x55,
                0xF1,
                0x31,
                0x3D,
                0xD5,
                0x3E,
                0x2A
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
