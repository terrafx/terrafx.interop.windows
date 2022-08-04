// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[StructLayout(LayoutKind.Explicit)]
public unsafe partial struct SP_DEVINSTALL_PARAMS_A
{
    public static uint SizeOf
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return (uint)(sizeof(SP_DEVINSTALL_PARAMS32_A));
            }
            else
            {
                return (uint)(sizeof(SP_DEVINSTALL_PARAMS64_A));
            }
        }
    }

    [FieldOffset(0)]
    public SP_DEVINSTALL_PARAMS32_A _value32;

    [FieldOffset(0)]
    public SP_DEVINSTALL_PARAMS64_A _value64;

    [NativeTypeName("DWORD")]
    [UnscopedRef]
    public ref uint cbSize
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref _value32.cbSize;
            }
            else
            {
                return ref _value64.cbSize;
            }
        }
    }

    [NativeTypeName("DWORD")]
    [UnscopedRef]
    public ref uint Flags
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref _value32.Flags;
            }
            else
            {
                return ref _value64.Flags;
            }
        }
    }

    [NativeTypeName("DWORD")]
    [UnscopedRef]
    public ref uint FlagsEx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref _value32.FlagsEx;
            }
            else
            {
                return ref _value64.FlagsEx;
            }
        }
    }

    [UnscopedRef]
    public ref HWND hwndParent
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref _value32.hwndParent;
            }
            else
            {
                return ref _value64.hwndParent;
            }
        }
    }

    [NativeTypeName("PSP_FILE_CALLBACK_W")]
    [UnscopedRef]
    public ref delegate* unmanaged<void*, uint, nuint, nuint, uint> InstallMsgHandler
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref _value32.InstallMsgHandler;
            }
            else
            {
                return ref _value64.InstallMsgHandler;
            }
        }
    }

    [NativeTypeName("PVOID")]
    [UnscopedRef]
    public ref void* InstallMsgHandlerContext
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref _value32.InstallMsgHandlerContext;
            }
            else
            {
                return ref _value64.InstallMsgHandlerContext;
            }
        }
    }

    [UnscopedRef]
    public ref HSPFILEQ FileQueue
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref _value32.FileQueue;
            }
            else
            {
                return ref _value64.FileQueue;
            }
        }
    }

    [NativeTypeName("ULONG_PTR")]
    [UnscopedRef]
    public ref nuint ClassInstallReserved
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref _value32.ClassInstallReserved;
            }
            else
            {
                return ref _value64.ClassInstallReserved;
            }
        }
    }

    [NativeTypeName("DWORD")]
    [UnscopedRef]
    public ref uint Reserved
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref _value32.Reserved;
            }
            else
            {
                return ref _value64.Reserved;
            }
        }
    }

    [NativeTypeName("CHAR [260]")]
    public Span<sbyte> DriverPath
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return MemoryMarshal.CreateSpan(ref _value32.DriverPath[0], 260);
            }
            else
            {
                return MemoryMarshal.CreateSpan(ref _value64.DriverPath[0], 260);
            }
        }
    }
}
