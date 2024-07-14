// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.effects.h in the Windows SDK for Windows 10.0.26100.0
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
    public static Guid* IID_IAcousticEchoCancellationConfiguration = typeof(IAcousticEchoCancellationConfiguration).GUID;

    [NativeTypeName("const IID &")]
    public static Guid* IID_IAudioEffect2 = typeof(IAudioEffect2).GUID;

    public static ref readonly Guid IID_IAcousticEchoCancellationConfiguration
    {
        get
        {
            ReadOnlySpan<byte> data = [
                0x5B, 0x73, 0x7E, 0x58,
                0x5B, 0x17,
                0x77, 0x51,
                0xA4,
                0x07,
                0x2E,
                0x33,
                0xBA,
                0xFE,
                0x33,
                0xA5
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAudioEffect2
    {
        get
        {
            ReadOnlySpan<byte> data = [
                0xB0, 0x3C, 0x70, 0x06,
                0x7E, 0x75,
                0x57, 0x57,
                0x8A,
                0xF0,
                0x6B,
                0xA5,
                0x8A,
                0x8B,
                0x29,
                0x90
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
