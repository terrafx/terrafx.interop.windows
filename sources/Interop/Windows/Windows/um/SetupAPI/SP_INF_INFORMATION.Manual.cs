// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[StructLayout(LayoutKind.Explicit)]
public unsafe partial struct SP_INF_INFORMATION
{
    public static uint SizeOf
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return (uint)(sizeof(SP_INF_INFORMATION32));
            }
            else
            {
                return (uint)(sizeof(SP_INF_INFORMATION64));
            }
        }
    }

    [FieldOffset(0)]
    public SP_INF_INFORMATION32 _value32;

    [FieldOffset(0)]
    public SP_INF_INFORMATION64 _value64;

    [NativeTypeName("DWORD")]
    public ref uint InfStyle
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value32.InfStyle, 1));
            }
            else
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value64.InfStyle, 1));
            }
        }
    }

    [NativeTypeName("DWORD")]
    public ref uint InfCount
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value32.InfCount, 1));
            }
            else
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value64.InfCount, 1));
            }
        }
    }

    [NativeTypeName("BYTE [1]")]
    public Span<byte> VersionData
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return MemoryMarshal.CreateSpan(ref _value32.VersionData[0], 1);
            }
            else
            {
                return MemoryMarshal.CreateSpan(ref _value64.VersionData[0], 1);
            }
        }
    }
}
