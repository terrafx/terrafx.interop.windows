// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.calls.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.WinRT;

namespace TerraFX.Interop.Windows;

public static unsafe partial class IID
{
    public static ref readonly Guid IID_IAcceptedVoipPhoneCallOptions
    {
        get
        {
            ReadOnlySpan<byte> data = [
                0x26, 0xC7, 0x19, 0xE5,
                0x6F, 0xB8,
                0xDD, 0x5A,
                0x8A,
                0xE2,
                0x0F,
                0x46,
                0xAC,
                0xD9,
                0x23,
                0x2D
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAcceptedVoipPhoneCallOptionsFactory
    {
        get
        {
            ReadOnlySpan<byte> data = [
                0x9B, 0xA7, 0xF8, 0x6C,
                0xC1, 0xAC,
                0xCE, 0x54,
                0xA7,
                0x5D,
                0xCC,
                0x78,
                0xD1,
                0x76,
                0x90,
                0xC8
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAppInitiatedVoipPhoneCallOptions
    {
        get
        {
            ReadOnlySpan<byte> data = [
                0x63, 0xBF, 0xBE, 0x86,
                0x5A, 0xFF,
                0xFD, 0x57,
                0x84,
                0xC6,
                0x2D,
                0x2C,
                0xF1,
                0x83,
                0x02,
                0xF8
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAppInitiatedVoipPhoneCallOptionsFactory
    {
        get
        {
            ReadOnlySpan<byte> data = [
                0x0C, 0xC3, 0x46, 0xCA,
                0x79, 0xF7,
                0x3B, 0x5F,
                0x8E,
                0xBC,
                0xA6,
                0x35,
                0xE7,
                0xF6,
                0x52,
                0xB5
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ICallAnswerEventArgs2
    {
        get
        {
            ReadOnlySpan<byte> data = [
                0xF7, 0x08, 0x82, 0x40,
                0xF7, 0xC3,
                0x9A, 0x57,
                0x80,
                0x0D,
                0x54,
                0x10,
                0x82,
                0xCB,
                0xA0,
                0x51
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IIncomingVoipPhoneCallOptions
    {
        get
        {
            ReadOnlySpan<byte> data = [
                0xD6, 0xFC, 0x79, 0x43,
                0xD0, 0xDD,
                0x9B, 0x5E,
                0x81,
                0xD8,
                0x51,
                0x10,
                0x49,
                0x57,
                0x64,
                0xAE
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IIncomingVoipPhoneCallOptionsFactory
    {
        get
        {
            ReadOnlySpan<byte> data = [
                0xE4, 0x2D, 0x06, 0x74,
                0xF0, 0x08,
                0x49, 0x56,
                0xBD,
                0x80,
                0x89,
                0xEA,
                0x87,
                0x18,
                0x5C,
                0x78
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IOutgoingVoipPhoneCallOptions
    {
        get
        {
            ReadOnlySpan<byte> data = [
                0x57, 0x9B, 0xC5, 0xD6,
                0xBE, 0x57,
                0x4F, 0x52,
                0x9D,
                0xC1,
                0xF2,
                0xC1,
                0x2E,
                0x5D,
                0x1B,
                0xCC
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IOutgoingVoipPhoneCallOptionsFactory
    {
        get
        {
            ReadOnlySpan<byte> data = [
                0xF4, 0xC6, 0xA2, 0x2E,
                0x7A, 0x0B,
                0x89, 0x57,
                0x9D,
                0x33,
                0xFE,
                0x32,
                0x71,
                0xFD,
                0xEF,
                0xA8
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IVoipCallCoordinator5
    {
        get
        {
            ReadOnlySpan<byte> data = [
                0x17, 0x90, 0xF7, 0xD4,
                0xC1, 0xD1,
                0x20, 0x58,
                0x95,
                0x5E,
                0x7A,
                0x16,
                0x76,
                0x35,
                0x5D,
                0x00
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IVoipCallCoordinatorStatics2
    {
        get
        {
            ReadOnlySpan<byte> data = [
                0x8B, 0x28, 0xD0, 0xB8,
                0xEA, 0x01,
                0x78, 0x54,
                0x84,
                0x04,
                0xA1,
                0xFB,
                0x06,
                0xF2,
                0xB8,
                0x3B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IVoipPhoneCall4
    {
        get
        {
            ReadOnlySpan<byte> data = [
                0x90, 0x62, 0xA6, 0xEB,
                0x6D, 0xAD,
                0x99, 0x58,
                0xBD,
                0xDA,
                0x81,
                0xBF,
                0xE9,
                0xF9,
                0x99,
                0xA1
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
