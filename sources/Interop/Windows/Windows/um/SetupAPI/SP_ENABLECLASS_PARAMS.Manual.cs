// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[StructLayout(LayoutKind.Explicit)]
public unsafe partial struct SP_ENABLECLASS_PARAMS
{
    public static uint SizeOf
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return (uint)(sizeof(SP_ENABLECLASS_PARAMS32));
            }
            else
            {
                return (uint)(sizeof(SP_ENABLECLASS_PARAMS64));
            }
        }
    }

    [FieldOffset(0)]
    public SP_ENABLECLASS_PARAMS32 _value32;

    [FieldOffset(0)]
    public SP_ENABLECLASS_PARAMS64 _value64;

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

    [UnscopedRef]
    public ref Guid ClassGuid
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref _value32.ClassGuid;
            }
            else
            {
                return ref _value64.ClassGuid;
            }
        }
    }

    [NativeTypeName("DWORD")]
    [UnscopedRef]
    public ref uint EnableMessage
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref _value32.EnableMessage;
            }
            else
            {
                return ref _value64.EnableMessage;
            }
        }
    }
}
