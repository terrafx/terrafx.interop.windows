// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.devices.h in the Windows SDK for Windows 10.0.26100.0
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
    public static Guid* IID_IAudioDeviceController2 = typeof(IAudioDeviceController2).GUID;

    public static ref readonly Guid IID_IAudioDeviceController2
    {
        get
        {
            ReadOnlySpan<byte> data = [
                0x99, 0x65, 0x32, 0x85,
                0x24, 0x4C,
                0xB0, 0x48,
                0x81,
                0xDD,
                0x0C,
                0x5C,
                0xC7,
                0x9D,
                0xDF,
                0x05
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
