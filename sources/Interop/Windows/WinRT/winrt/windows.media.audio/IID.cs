// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.audio.h in the Windows SDK for Windows 10.0.26100.0
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
    public static Guid* IID_IAudioEffectsPackConfiguration = typeof(IAudioEffectsPackConfiguration).GUID;

    [NativeTypeName("const IID &")]
    public static Guid* IID_IAudioEffectsPackConfigurationStatics = typeof(IAudioEffectsPackConfigurationStatics).GUID;

    public static ref readonly Guid IID_IAudioEffectsPackConfiguration
    {
        get
        {
            ReadOnlySpan<byte> data = [
                0x7D, 0x62, 0xD7, 0x71,
                0xC1, 0x70,
                0x6C, 0x53,
                0xA8,
                0xF8,
                0x6F,
                0x98,
                0x01,
                0x5A,
                0x7F,
                0x06
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAudioEffectsPackConfigurationStatics
    {
        get
        {
            ReadOnlySpan<byte> data = [
                0x13, 0x04, 0xC2, 0x61,
                0x0C, 0x53,
                0xFF, 0x55,
                0xBA,
                0x2B,
                0x8E,
                0x68,
                0xA9,
                0xB5,
                0x6A,
                0x04
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
