// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.bluetooth.background.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.WinRT;

namespace TerraFX.Interop.Windows;

public static unsafe partial class IID
{
    public static ref readonly Guid IID_IGattServiceProviderConnection2
    {
        get
        {
            ReadOnlySpan<byte> data = [
                0xE0, 0x2B, 0xD1, 0x90,
                0xC0, 0xEB,
                0x4F, 0x48,
                0xAE,
                0x0A,
                0x7E,
                0xB8,
                0xB6,
                0x26,
                0x6B,
                0xAC
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
