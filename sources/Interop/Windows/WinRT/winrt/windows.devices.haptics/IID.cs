// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.haptics.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.WinRT;

namespace TerraFX.Interop.Windows;

public static unsafe partial class IID
{
    public static ref readonly Guid IID_IInputHapticsManager
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xDF, 0x91, 0x0E, 0x04,
                0x3A, 0xBB,
                0x7C, 0x50,
                0x9E,
                0x25,
                0xA2,
                0xD2,
                0xC6,
                0x85,
                0xB2,
                0xE5
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IInputHapticsManagerStatics
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x77, 0x0F, 0xB4, 0x7B,
                0x87, 0xE1,
                0x22, 0x53,
                0x84,
                0x4E,
                0xAA,
                0x58,
                0x22,
                0x3C,
                0x28,
                0x1A
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IKnownSimpleHapticsControllerWaveformsStatics
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xF7, 0x7E, 0x57, 0x3D,
                0xEE, 0x4C,
                0xE6, 0x11,
                0xB5,
                0x35,
                0x00,
                0x1B,
                0xDC,
                0x06,
                0xAB,
                0x3B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IKnownSimpleHapticsControllerWaveformsStatics2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x27, 0x4C, 0xD2, 0xA7,
                0x9D, 0xB7,
                0x0A, 0x51,
                0xBF,
                0x79,
                0xFF,
                0x6D,
                0x49,
                0x17,
                0x3E,
                0x1D
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISimpleHapticsController
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xF9, 0x7E, 0x57, 0x3D,
                0xEE, 0x4C,
                0xE6, 0x11,
                0xB5,
                0x35,
                0x00,
                0x1B,
                0xDC,
                0x06,
                0xAB,
                0x3B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISimpleHapticsControllerFeedback
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xF8, 0x7E, 0x57, 0x3D,
                0xEE, 0x4C,
                0xE6, 0x11,
                0xB5,
                0x35,
                0x00,
                0x1B,
                0xDC,
                0x06,
                0xAB,
                0x3B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IVibrationDevice
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x3E, 0x1A, 0xF2, 0x40,
                0x44, 0x88,
                0xFF, 0x47,
                0xB3,
                0x12,
                0x06,
                0x18,
                0x5A,
                0x38,
                0x44,
                0xDA
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IVibrationDeviceStatics
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xED, 0xED, 0xE2, 0x53,
                0x90, 0x22,
                0xC9, 0x4A,
                0x8E,
                0xB3,
                0x1A,
                0x84,
                0x12,
                0x2E,
                0xB7,
                0x1C
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
