// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.background.h in the Windows SDK for Windows 10.0.26100.0
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
    public static Guid* IID_IBackgroundTaskBuilder6 = typeof(IBackgroundTaskBuilder6).GUID;

    [NativeTypeName("const IID &")]
    public static Guid* IID_IBackgroundTaskBuilderStatics = typeof(IBackgroundTaskBuilderStatics).GUID;

    [NativeTypeName("const IID &")]
    public static Guid* IID_IBackgroundTaskRegistration4 = typeof(IBackgroundTaskRegistration4).GUID;

    [NativeTypeName("const IID &")]
    public static Guid* IID_IBackgroundWorkCostStatics2 = typeof(IBackgroundWorkCostStatics2).GUID;

    public static ref readonly Guid IID_IBackgroundTaskBuilder6
    {
        get
        {
            ReadOnlySpan<byte> data = [
                0x17, 0x7B, 0xB4, 0x80,
                0x8B, 0xEC,
                0x53, 0x56,
                0x85,
                0x0B,
                0x75,
                0x08,
                0xA0,
                0x1F,
                0x52,
                0xE7
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IBackgroundTaskBuilderStatics
    {
        get
        {
            ReadOnlySpan<byte> data = [
                0x46, 0x50, 0xEB, 0xD1,
                0xF2, 0x06,
                0xB4, 0x55,
                0x9B,
                0xB7,
                0xA6,
                0x45,
                0x7E,
                0xBF,
                0x33,
                0x00
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IBackgroundTaskRegistration4
    {
        get
        {
            ReadOnlySpan<byte> data = [
                0xC9, 0x09, 0x9C, 0x16,
                0xDE, 0xB0,
                0x76, 0x55,
                0xA0,
                0x5B,
                0xA0,
                0x20,
                0x67,
                0x98,
                0x98,
                0x79
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IBackgroundWorkCostStatics2
    {
        get
        {
            ReadOnlySpan<byte> data = [
                0x76, 0xC9, 0x68, 0xD8,
                0xF6, 0x81,
                0xC8, 0x57,
                0xAB,
                0x2B,
                0x40,
                0x0B,
                0x74,
                0x9E,
                0x21,
                0xD6
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
