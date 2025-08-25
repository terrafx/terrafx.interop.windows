// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.security.authentication.web.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.WinRT;

namespace TerraFX.Interop.Windows;

public static unsafe partial class IID
{
    public static ref readonly Guid IID_IWebAuthenticationAddAccountResponse
    {
        get
        {
            ReadOnlySpan<byte> data = [
                0xE8, 0x13, 0xB0, 0x7F,
                0xD8, 0x0B,
                0x2B, 0x54,
                0xB4,
                0x86,
                0x83,
                0x23,
                0x16,
                0x3A,
                0x4B,
                0x85
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IWebAuthenticationAddAccountResponseFactory
    {
        get
        {
            ReadOnlySpan<byte> data = [
                0x3E, 0x90, 0x5F, 0x32,
                0xBE, 0x77,
                0x65, 0x53,
                0x81,
                0xD9,
                0x03,
                0x21,
                0xCD,
                0xD8,
                0x21,
                0x95
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IWebAuthenticationAddAccountResult
    {
        get
        {
            ReadOnlySpan<byte> data = [
                0x3C, 0xD0, 0xFA, 0x88,
                0x1D, 0x90,
                0xFA, 0x5F,
                0x92,
                0x59,
                0x70,
                0x1D,
                0x3C,
                0xA0,
                0x8E,
                0xF2
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IWebAuthenticationCoreManagerStatics5
    {
        get
        {
            ReadOnlySpan<byte> data = [
                0xED, 0x1D, 0x7C, 0xD0,
                0x0F, 0x27,
                0x54, 0x45,
                0x99,
                0x66,
                0x27,
                0xB7,
                0xDF,
                0x05,
                0xB9,
                0x65
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IWebAuthenticationTransferTokenRequest
    {
        get
        {
            ReadOnlySpan<byte> data = [
                0xB6, 0xA5, 0xCF, 0x7A,
                0x9D, 0x52,
                0x76, 0x5E,
                0x98,
                0x46,
                0xF3,
                0xFD,
                0x99,
                0x93,
                0x04,
                0xD0
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IWebAuthenticationTransferTokenRequestFactory
    {
        get
        {
            ReadOnlySpan<byte> data = [
                0x27, 0xB6, 0x16, 0x5F,
                0xC4, 0x04,
                0x0B, 0x5F,
                0x86,
                0x83,
                0x8B,
                0xAB,
                0x58,
                0x96,
                0x56,
                0x56
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
