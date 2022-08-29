// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[StructLayout(LayoutKind.Explicit)]
public unsafe partial struct INFCONTEXT
{
    public static uint SizeOf
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return (uint)(sizeof(INFCONTEXT32));
            }
            else
            {
                return (uint)(sizeof(INFCONTEXT64));
            }
        }
    }

    [FieldOffset(0)]
    public INFCONTEXT32 _value32;

    [FieldOffset(0)]
    public INFCONTEXT64 _value64;

    [NativeTypeName("PVOID")]
    [UnscopedRef]
    public ref void* Inf
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref _value32.Inf;
            }
            else
            {
                return ref _value64.Inf;
            }
        }
    }

    [NativeTypeName("PVOID")]
    [UnscopedRef]
    public ref void* CurrentInf
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref _value32.CurrentInf;
            }
            else
            {
                return ref _value64.CurrentInf;
            }
        }
    }

    [UnscopedRef]
    public ref uint Section
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref _value32.Section;
            }
            else
            {
                return ref _value64.Section;
            }
        }
    }

    [UnscopedRef]
    public ref uint Line
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref _value32.Line;
            }
            else
            {
                return ref _value64.Line;
            }
        }
    }
}
