// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[StructLayout(LayoutKind.Explicit)]
public unsafe partial struct SP_INF_SIGNER_INFO_V1_A
{
    public static uint SizeOf
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return (uint)(sizeof(SP_INF_SIGNER_INFO32_V1_A));
            }
            else
            {
                return (uint)(sizeof(SP_INF_SIGNER_INFO64_V1_A));
            }
        }
    }

    [FieldOffset(0)]
    public SP_INF_SIGNER_INFO32_V1_A _value32;

    [FieldOffset(0)]
    public SP_INF_SIGNER_INFO64_V1_A _value64;

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

    [NativeTypeName("CHAR [260]")]
    [UnscopedRef]
    public Span<sbyte> CatalogFile
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
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

    [NativeTypeName("CHAR [260]")]
    [UnscopedRef]
    public Span<sbyte> DigitalSigner
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
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

    [NativeTypeName("CHAR[260]")]
    [UnscopedRef]
    public Span<sbyte> DigitalSignerVersion
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
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
