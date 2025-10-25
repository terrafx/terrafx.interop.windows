// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Mobsync.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

public static partial class IID
{
    public static ref readonly Guid IID_ISyncMgrSynchronizeCallback
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x41, 0xDF, 0x95, 0x62,
                0xEE, 0x35,
                0xD1, 0x11,
                0x87,
                0x07,
                0x00,
                0xC0,
                0x4F,
                0xD9,
                0x33,
                0x27
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISyncMgrEnumItems
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x2A, 0xDF, 0x95, 0x62,
                0xEE, 0x35,
                0xD1, 0x11,
                0x87,
                0x07,
                0x00,
                0xC0,
                0x4F,
                0xD9,
                0x33,
                0x27
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISyncMgrSynchronize
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x40, 0xDF, 0x95, 0x62,
                0xEE, 0x35,
                0xD1, 0x11,
                0x87,
                0x07,
                0x00,
                0xC0,
                0x4F,
                0xD9,
                0x33,
                0x27
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISyncMgrSynchronizeInvoke
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x2C, 0xDF, 0x95, 0x62,
                0xEE, 0x35,
                0xD1, 0x11,
                0x87,
                0x07,
                0x00,
                0xC0,
                0x4F,
                0xD9,
                0x33,
                0x27
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISyncMgrRegister
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x42, 0xDF, 0x95, 0x62,
                0xEE, 0x35,
                0xD1, 0x11,
                0x87,
                0x07,
                0x00,
                0xC0,
                0x4F,
                0xD9,
                0x33,
                0x27
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SyncMgr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x27, 0xDF, 0x95, 0x62,
                0xEE, 0x35,
                0xD1, 0x11,
                0x87,
                0x07,
                0x00,
                0xC0,
                0x4F,
                0xD9,
                0x33,
                0x27
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
