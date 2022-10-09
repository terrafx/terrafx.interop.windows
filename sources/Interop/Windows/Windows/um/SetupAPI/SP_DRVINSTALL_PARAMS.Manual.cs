// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[StructLayout(LayoutKind.Explicit)]
public unsafe partial struct SP_DRVINSTALL_PARAMS
{
    public static uint SizeOf
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return (uint)(sizeof(SP_DRVINSTALL_PARAMS32));
            }
            else
            {
                return (uint)(sizeof(SP_DRVINSTALL_PARAMS64));
            }
        }
    }

    [FieldOffset(0)]
    public SP_DRVINSTALL_PARAMS32 _value32;

    [FieldOffset(0)]
    public SP_DRVINSTALL_PARAMS64 _value64;

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
    public ref uint Rank
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref _value32.Rank;
            }
            else
            {
                return ref _value64.Rank;
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

    [NativeTypeName("DWORD_PTR")]
    [UnscopedRef]
    public ref nuint PrivateData
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref _value32.PrivateData;
            }
            else
            {
                return ref _value64.PrivateData;
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
}
