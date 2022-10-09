// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[StructLayout(LayoutKind.Explicit)]
public unsafe partial struct CABINET_INFO_W
{
    public static uint SizeOf
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return (uint)(sizeof(CABINET_INFO32_W));
            }
            else
            {
                return (uint)(sizeof(CABINET_INFO64_W));
            }
        }
    }

    [FieldOffset(0)]
    public CABINET_INFO32_W _value32;

    [FieldOffset(0)]
    public CABINET_INFO64_W _value64;

    [NativeTypeName("PCWSTR")]
    [UnscopedRef]
    public ref ushort* CabinetPath
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref _value32.CabinetPath;
            }
            else
            {
                return ref _value64.CabinetPath;
            }
        }
    }

    [NativeTypeName("PCWSTR")]
    [UnscopedRef]
    public ref ushort* CabinetFile
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref _value32.CabinetFile;
            }
            else
            {
                return ref _value64.CabinetFile;
            }
        }
    }

    [NativeTypeName("PCWSTR")]
    [UnscopedRef]
    public ref ushort* DiskName
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref _value32.DiskName;
            }
            else
            {
                return ref _value64.DiskName;
            }
        }
    }

    [NativeTypeName("USHORT")]
    [UnscopedRef]
    public ref ushort SetId
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref _value32.SetId;
            }
            else
            {
                return ref _value64.SetId;
            }
        }
    }

    [NativeTypeName("USHORT")]
    [UnscopedRef]
    public ref ushort CabinetNumber
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref _value32.CabinetNumber;
            }
            else
            {
                return ref _value64.CabinetNumber;
            }
        }
    }
}
