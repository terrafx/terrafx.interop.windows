// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[StructLayout(LayoutKind.Explicit)]
public unsafe partial struct CABINET_INFO_A
{
    public static uint SizeOf
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return (uint)(sizeof(CABINET_INFO32_A));
            }
            else
            {
                return (uint)(sizeof(CABINET_INFO64_A));
            }
        }
    }

    [FieldOffset(0)]
    public CABINET_INFO32_A _value32;

    [FieldOffset(0)]
    public CABINET_INFO64_A _value64;

    [NativeTypeName("PCSTR")]
    public ref sbyte* CabinetPath
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value32, 1)).CabinetPath;
            }
            else
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value64, 1)).CabinetPath;
            }
        }
    }

    [NativeTypeName("PCSTR")]
    public ref sbyte* CabinetFile
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value32, 1)).CabinetFile;
            }
            else
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value64, 1)).CabinetFile;
            }
        }
    }

    [NativeTypeName("PCSTR")]
    public ref sbyte* DiskName
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value32, 1)).DiskName;
            }
            else
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value64, 1)).DiskName;
            }
        }
    }

    [NativeTypeName("USHORT")]
    public ref ushort SetId
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value32.SetId, 1));
            }
            else
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value64.SetId, 1));
            }
        }
    }

    [NativeTypeName("USHORT")]
    public ref ushort CabinetNumber
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value32.CabinetNumber, 1));
            }
            else
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value64.CabinetNumber, 1));
            }
        }
    }
}
