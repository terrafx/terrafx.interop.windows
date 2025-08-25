// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.bluetooth.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.WinRT;

namespace TerraFX.Interop.Windows;

public static unsafe partial class IID
{
    public static ref readonly Guid IID_IBluetoothAdapter4
    {
        get
        {
            ReadOnlySpan<byte> data = [
                0xE1, 0xF3, 0x75, 0xF8,
                0x9A, 0x6D,
                0x5E, 0x5D,
                0xAE,
                0xE5,
                0xA1,
                0x72,
                0x48,
                0xE5,
                0xF6,
                0xDD
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
