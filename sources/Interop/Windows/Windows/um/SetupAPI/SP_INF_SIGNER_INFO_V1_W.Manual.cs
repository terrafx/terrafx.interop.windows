// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[StructLayout(LayoutKind.Explicit)]
public unsafe partial struct SP_INF_SIGNER_INFO_V1_W
{
    public static uint SizeOf
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return (uint)(sizeof(SP_INF_SIGNER_INFO32_V1_W));
            }
            else
            {
                return (uint)(sizeof(SP_INF_SIGNER_INFO64_V1_W));
            }
        }
    }

    [FieldOffset(0)]
    public SP_INF_SIGNER_INFO32_V1_W _value32;

    [FieldOffset(0)]
    public SP_INF_SIGNER_INFO64_V1_W _value64;

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

    [NativeTypeName("WCHAR[260]")]
    [UnscopedRef]
    public Span<char> CatalogFile
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return _value32.CatalogFile;
            }
            else
            {
                return _value64.CatalogFile;
            }
        }
    }

    [NativeTypeName("WCHAR[260]")]
    [UnscopedRef]
    public Span<char> DigitalSigner
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return _value32.DigitalSigner;
            }
            else
            {
                return _value64.DigitalSigner;
            }
        }
    }

    [NativeTypeName("WCHAR [260]")]
    [UnscopedRef]
    public Span<char> DigitalSignerVersion
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return _value32.DigitalSignerVersion;
            }
            else
            {
                return _value64.DigitalSignerVersion;
            }
        }
    }
}
