// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[StructLayout(LayoutKind.Explicit)]
public unsafe partial struct FILEPATHS_SIGNERINFO_W
{
    public static uint SizeOf
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return (uint)(sizeof(FILEPATHS_SIGNERINFO32_W));
            }
            else
            {
                return (uint)(sizeof(FILEPATHS_SIGNERINFO64_W));
            }
        }
    }

    [FieldOffset(0)]
    public FILEPATHS_SIGNERINFO32_W _value32;

    [FieldOffset(0)]
    public FILEPATHS_SIGNERINFO64_W _value64;

    [NativeTypeName("PCWSTR")]
    [UnscopedRef]
    public ref ushort* Target
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref _value32.Target;
            }
            else
            {
                return ref _value64.Target;
            }
        }
    }

    [NativeTypeName("PCWSTR")]
    [UnscopedRef]
    public ref ushort* Source
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref _value32.Source;
            }
            else
            {
                return ref _value64.Source;
            }
        }
    }

    [UnscopedRef]
    public ref uint Win32Error
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref _value32.Win32Error;
            }
            else
            {
                return ref _value64.Win32Error;
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

    [NativeTypeName("PCWSTR")]
    [UnscopedRef]
    public ref ushort* DigitalSigner
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref _value32.DigitalSigner;
            }
            else
            {
                return ref _value64.DigitalSigner;
            }
        }
    }

    [NativeTypeName("PCWSTR")]
    [UnscopedRef]
    public ref ushort* Version
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref _value32.Version;
            }
            else
            {
                return ref _value64.Version;
            }
        }
    }

    [NativeTypeName("PCWSTR")]
    [UnscopedRef]
    public ref ushort* CatalogFile
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref _value32.CatalogFile;
            }
            else
            {
                return ref _value64.CatalogFile;
            }
        }
    }
}
