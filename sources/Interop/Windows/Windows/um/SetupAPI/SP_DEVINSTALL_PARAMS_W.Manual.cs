// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[StructLayout(LayoutKind.Explicit)]
public unsafe partial struct SP_DEVINSTALL_PARAMS_W
{
    public static uint SizeOf
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return (uint)(sizeof(SP_DEVINSTALL_PARAMS32_W));
            }
            else
            {
                return (uint)(sizeof(SP_DEVINSTALL_PARAMS64_W));
            }
        }
    }

    [FieldOffset(0)]
    public SP_DEVINSTALL_PARAMS32_W _value32;

    [FieldOffset(0)]
    public SP_DEVINSTALL_PARAMS64_W _value64;

    [NativeTypeName("DWORD")]
    public ref uint cbSize
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value32.cbSize, 1));
            }
            else
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value64.cbSize, 1));
            }
        }
    }

    [NativeTypeName("DWORD")]
    public ref uint Flags
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value32.Flags, 1));
            }
            else
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value64.Flags, 1));
            }
        }
    }

    [NativeTypeName("DWORD")]
    public ref uint FlagsEx
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value32.FlagsEx, 1));
            }
            else
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value64.FlagsEx, 1));
            }
        }
    }

    public ref HWND hwndParent
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value32.hwndParent, 1));
            }
            else
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value64.hwndParent, 1));
            }
        }
    }

    [NativeTypeName("PSP_FILE_CALLBACK_W")]
    public ref delegate* unmanaged<void*, uint, nuint, nuint, uint> InstallMsgHandler
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value32, 1)).InstallMsgHandler;
            }
            else
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value64, 1)).InstallMsgHandler;
            }
        }
    }

    [NativeTypeName("PVOID")]
    public ref void* InstallMsgHandlerContext
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value32, 1)).InstallMsgHandlerContext;
            }
            else
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value64, 1)).InstallMsgHandlerContext;
            }
        }
    }

    public ref HSPFILEQ FileQueue
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value32.FileQueue, 1));
            }
            else
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value64.FileQueue, 1));
            }
        }
    }

    [NativeTypeName("ULONG_PTR")]
    public ref nuint ClassInstallReserved
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value32.ClassInstallReserved, 1));
            }
            else
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value64.ClassInstallReserved, 1));
            }
        }
    }

    [NativeTypeName("DWORD")]
    public ref uint Reserved
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value32.Reserved, 1));
            }
            else
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value64.Reserved, 1));
            }
        }
    }

    [NativeTypeName("WCHAR [260]")]
    public Span<ushort> DriverPath
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return MemoryMarshal.CreateSpan(ref _value32.DriverPath[0], 1);
            }
            else
            {
                return MemoryMarshal.CreateSpan(ref _value64.DriverPath[0], 1);
            }
        }
    }
}
