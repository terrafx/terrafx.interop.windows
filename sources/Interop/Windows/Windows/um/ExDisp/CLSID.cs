// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ExDisp.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

public static partial class CLSID
{
    public static ref readonly Guid CLSID_WebBrowser_V1
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xC3, 0x2A, 0xB2, 0xEA,
                0xC1, 0x30,
                0xCF, 0x11,
                0xA7,
                0xEB,
                0x00,
                0x00,
                0xC0,
                0x5B,
                0xAE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_WebBrowser
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x61, 0xF9, 0x56, 0x88,
                0x0A, 0x34,
                0xD0, 0x11,
                0xA9,
                0x6B,
                0x00,
                0xC0,
                0x4F,
                0xD7,
                0x05,
                0xA2
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_InternetExplorer
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x01, 0xDF, 0x02, 0x00,
                0x00, 0x00,
                0x00, 0x00,
                0xC0,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x46
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_InternetExplorerMedium
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x1D, 0x04, 0xE8, 0xD5,
                0x0F, 0x92,
                0xE9, 0x45,
                0xB8,
                0xFB,
                0xB1,
                0xDE,
                0xB8,
                0x2C,
                0x6E,
                0x5E
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_ShellBrowserWindow
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x90, 0xFD, 0x8A, 0xC0,
                0xA1, 0xF2,
                0xD1, 0x11,
                0x84,
                0x55,
                0x00,
                0xA0,
                0xC9,
                0x1F,
                0x38,
                0x80
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_ShellWindows
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x72, 0x59, 0xA0, 0x9B,
                0xA8, 0xF6,
                0xCF, 0x11,
                0xA4,
                0x42,
                0x00,
                0xA0,
                0xC9,
                0x0A,
                0x8F,
                0x39
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_ShellUIHelper
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xB7, 0x4B, 0xAB, 0x64,
                0x1E, 0x11,
                0xD1, 0x11,
                0x8F,
                0x79,
                0x00,
                0xC0,
                0x4F,
                0xC2,
                0xFB,
                0xE1
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_ShellNameSpace
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x05, 0x68, 0x13, 0x55,
                0xDE, 0xB2,
                0xD1, 0x11,
                0xB9,
                0xF2,
                0x00,
                0xA0,
                0xC9,
                0x8B,
                0xC5,
                0x47
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_CScriptErrorList
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x00, 0x13, 0xD0, 0xEF,
                0x0F, 0x16,
                0xD2, 0x11,
                0xBB,
                0x2E,
                0x00,
                0x80,
                0x5F,
                0xF7,
                0xEF,
                0xCA
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
