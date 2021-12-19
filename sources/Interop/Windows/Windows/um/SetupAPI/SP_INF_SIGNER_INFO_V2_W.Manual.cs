// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[StructLayout(LayoutKind.Explicit)]
public unsafe partial struct SP_INF_SIGNER_INFO_V2_W
{
    public static uint SizeOf
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return (uint)(sizeof(SP_INF_SIGNER_INFO32_V2_W));
            }
            else
            {
                return (uint)(sizeof(SP_INF_SIGNER_INFO64_V2_W));
            }
        }
    }

    [FieldOffset(0)]
    public SP_INF_SIGNER_INFO32_V2_W _value32;

    [FieldOffset(0)]
    public SP_INF_SIGNER_INFO64_V2_W _value64;

    [NativeTypeName("DWORD")]
    public ref uint cbSize
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value32.cbSize, 1));
            }
            else
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value64.cbSize, 1));
            }
        }
    }

    [NativeTypeName("WCHAR [260]")]
    public Span<ushort> CatalogFile
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return MemoryMarshal.CreateSpan(ref _value32.CatalogFile[0], 1);
            }
            else
            {
                return MemoryMarshal.CreateSpan(ref _value64.CatalogFile[0], 1);
            }
        }
    }

    [NativeTypeName("WCHAR [260]")]
    public Span<ushort> DigitalSigner
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return MemoryMarshal.CreateSpan(ref _value32.DigitalSigner[0], 1);
            }
            else
            {
                return MemoryMarshal.CreateSpan(ref _value64.DigitalSigner[0], 1);
            }
        }
    }

    [NativeTypeName("WCHAR [260]")]
    public Span<ushort> DigitalSignerVersion
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return MemoryMarshal.CreateSpan(ref _value32.DigitalSignerVersion[0], 1);
            }
            else
            {
                return MemoryMarshal.CreateSpan(ref _value64.DigitalSignerVersion[0], 1);
            }
        }
    }

    [NativeTypeName("DWORD")]
    public ref uint SignerScore
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value32.SignerScore, 1));
            }
            else
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value64.SignerScore, 1));
            }
        }
    }
}
