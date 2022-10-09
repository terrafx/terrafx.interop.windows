// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[StructLayout(LayoutKind.Explicit)]
public unsafe partial struct SP_DETECTDEVICE_PARAMS
{
    public static uint SizeOf
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return (uint)(sizeof(SP_DETECTDEVICE_PARAMS32));
            }
            else
            {
                return (uint)(sizeof(SP_DETECTDEVICE_PARAMS64));
            }
        }
    }

    [FieldOffset(0)]
    public SP_DETECTDEVICE_PARAMS32 _value32;

    [FieldOffset(0)]
    public SP_DETECTDEVICE_PARAMS64 _value64;

    [UnscopedRef]
    public ref SP_CLASSINSTALL_HEADER ClassInstallHeader
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref Unsafe.As<SP_CLASSINSTALL_HEADER32, SP_CLASSINSTALL_HEADER>(ref _value32.ClassInstallHeader);
            }
            else
            {
                return ref Unsafe.As<SP_CLASSINSTALL_HEADER64, SP_CLASSINSTALL_HEADER>(ref _value64.ClassInstallHeader);
            }
        }
    }

    [NativeTypeName("PDETECT_PROGRESS_NOTIFY")]
    [UnscopedRef]
    public ref delegate* unmanaged<void*, uint, int> DetectProgressNotify
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref _value32.DetectProgressNotify;
            }
            else
            {
                return ref _value64.DetectProgressNotify;
            }
        }
    }

    [NativeTypeName("PVOID")]
    [UnscopedRef]
    public ref void* ProgressNotifyParam
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref _value32.ProgressNotifyParam;
            }
            else
            {
                return ref _value64.ProgressNotifyParam;
            }
        }
    }
}
