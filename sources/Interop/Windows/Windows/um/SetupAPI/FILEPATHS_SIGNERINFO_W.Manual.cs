// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

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
    public ref ushort* Target
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value32, 1)).Target;
            }
            else
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value64, 1)).Target;
            }
        }
    }

    [NativeTypeName("PCWSTR")]
    public ref ushort* Source
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value32, 1)).Source;
            }
            else
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value64, 1)).Source;
            }
        }
    }

    public ref uint Win32Error
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value32.Win32Error, 1));
            }
            else
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value64.Win32Error, 1));
            }
        }
    }

    [NativeTypeName("DWORD")]
    public ref uint Flags
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value32.Flags, 1));
            }
            else
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value64.Flags, 1));
            }
        }
    }

    [NativeTypeName("PCWSTR")]
    public ref ushort* DigitalSigner
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value32, 1)).DigitalSigner;
            }
            else
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value64, 1)).DigitalSigner;
            }
        }
    }

    [NativeTypeName("PCWSTR")]
    public ref ushort* Version
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value32, 1)).Version;
            }
            else
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value64, 1)).Version;
            }
        }
    }

    [NativeTypeName("PCWSTR")]
    public ref ushort* CatalogFile
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value32, 1)).CatalogFile;
            }
            else
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value64, 1)).CatalogFile;
            }
        }
    }
}
