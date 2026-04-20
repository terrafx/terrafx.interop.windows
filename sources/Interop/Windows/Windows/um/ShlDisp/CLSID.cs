// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlDisp.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

public static partial class CLSID
{
    public static ref readonly Guid CLSID_ShellFolderViewOC
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x71, 0x59, 0xA0, 0x9B,
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

    public static ref readonly Guid CLSID_ShellFolderItem
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xEA, 0x52, 0xE3, 0x2F,
                0x1F, 0xFD,
                0xD2, 0x11,
                0xB1,
                0xF4,
                0x00,
                0xC0,
                0x4F,
                0x8E,
                0xEB,
                0x3E
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_ShellLinkObject
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x20, 0x94, 0x21, 0x11,
                0x68, 0x17,
                0xD1, 0x11,
                0x95,
                0xBE,
                0x00,
                0x60,
                0x97,
                0x97,
                0xEA,
                0x4F
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_ShellFolderView
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xA1, 0x2A, 0x11, 0x62,
                0xE4, 0xEB,
                0xCF, 0x11,
                0xA5,
                0xFB,
                0x00,
                0x20,
                0xAF,
                0xE7,
                0x29,
                0x2D
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_Shell
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x20, 0x96, 0x70, 0x13,
                0x79, 0xC2,
                0xCE, 0x11,
                0xA4,
                0x9E,
                0x44,
                0x45,
                0x53,
                0x54,
                0x00,
                0x00
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_ShellDispatchInproc
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x60, 0xA8, 0x89, 0x0A,
                0xB1, 0xD7,
                0xCE, 0x11,
                0x83,
                0x50,
                0x44,
                0x45,
                0x53,
                0x54,
                0x00,
                0x00
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_FileSearchBand
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xF3, 0x31, 0xEE, 0xC4,
                0x68, 0x47,
                0xD2, 0x11,
                0xBE,
                0x5C,
                0x00,
                0xA0,
                0xC9,
                0xA8,
                0x3D,
                0xA1
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
