// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from https://github.com/microsoft/DirectXShaderCompiler/blob/main/projects/dxilconv/include/DxbcConverter.h
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the University of Illinois Open Source License.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

public static partial class IID
{
    public static ref readonly Guid IID_IDxbcConverter
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xD5, 0x6E, 0x95, 0x5F,
                0xD1, 0x78,
                0x15, 0x4B,
                0x82,
                0x47,
                0xF7,
                0x18,
                0x76,
                0x14,
                0xA0,
                0x41
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
