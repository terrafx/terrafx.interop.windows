// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[StructLayout(LayoutKind.Explicit)]
public unsafe partial struct SP_UNREMOVEDEVICE_PARAMS
{
    public static uint SizeOf
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return (uint)(sizeof(SP_UNREMOVEDEVICE_PARAMS32));
            }
            else
            {
                return (uint)(sizeof(SP_UNREMOVEDEVICE_PARAMS64));
            }
        }
    }

    [FieldOffset(0)]
    public SP_UNREMOVEDEVICE_PARAMS32 _value32;

    [FieldOffset(0)]
    public SP_UNREMOVEDEVICE_PARAMS64 _value64;

    public ref SP_CLASSINSTALL_HEADER ClassInstallHeader
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Unsafe.As<SP_CLASSINSTALL_HEADER32, SP_CLASSINSTALL_HEADER>(ref _value32.ClassInstallHeader), 1));
            }
            else
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Unsafe.As<SP_CLASSINSTALL_HEADER64, SP_CLASSINSTALL_HEADER>(ref _value64.ClassInstallHeader), 1));
            }
        }
    }

    [NativeTypeName("DWORD")]
    public ref uint Scope
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value32.Scope, 1));
            }
            else
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value64.Scope, 1));
            }
        }
    }

    [NativeTypeName("DWORD")]
    public ref uint HwProfile
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value32.HwProfile, 1));
            }
            else
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value64.HwProfile, 1));
            }
        }
    }
}
