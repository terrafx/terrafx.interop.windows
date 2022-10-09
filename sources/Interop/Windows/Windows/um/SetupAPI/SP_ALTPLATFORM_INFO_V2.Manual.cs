// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[StructLayout(LayoutKind.Explicit)]
public unsafe partial struct SP_ALTPLATFORM_INFO_V2
{
    public static uint SizeOf
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return (uint)(sizeof(SP_ALTPLATFORM_INFO32_V2));
            }
            else
            {
                return (uint)(sizeof(SP_ALTPLATFORM_INFO64_V2));
            }
        }
    }

    [FieldOffset(0)]
    public SP_ALTPLATFORM_INFO32_V2 _value32;

    [FieldOffset(0)]
    public SP_ALTPLATFORM_INFO64_V2 _value64;

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
    public ref uint Platform
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref _value32.Platform;
            }
            else
            {
                return ref _value64.Platform;
            }
        }
    }

    [NativeTypeName("DWORD")]
    [UnscopedRef]
    public ref uint MajorVersion
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref _value32.MajorVersion;
            }
            else
            {
                return ref _value64.MajorVersion;
            }
        }
    }

    [NativeTypeName("DWORD")]
    [UnscopedRef]
    public ref uint MinorVersion
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref _value32.MinorVersion;
            }
            else
            {
                return ref _value64.MinorVersion;
            }
        }
    }

    [NativeTypeName("WORD")]
    [UnscopedRef]
    public ref ushort ProcessorArchitecture
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref _value32.ProcessorArchitecture;
            }
            else
            {
                return ref _value64.ProcessorArchitecture;
            }
        }
    }

    [NativeTypeName("DWORD")]
    [UnscopedRef]
    public ref uint FirstValidatedMajorVersion
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref _value32.FirstValidatedMajorVersion;
            }
            else
            {
                return ref _value64.FirstValidatedMajorVersion;
            }
        }
    }

    [NativeTypeName("DWORD")]
    [UnscopedRef]
    public ref uint FirstValidatedMinorVersion
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref _value32.FirstValidatedMinorVersion;
            }
            else
            {
                return ref _value64.FirstValidatedMinorVersion;
            }
        }
    }

    [UnscopedRef]
    public ref ushort Reserved
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

    [UnscopedRef]
    public ref ushort Flags
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
}
