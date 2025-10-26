// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3dshadercacheregistration.h in microsoft/DirectX-Headers tag v1.618.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.DirectX;

namespace TerraFX.Interop.Windows;

public static partial class CLSID
{
    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_D3DShaderCacheInstallerFactory
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x0B, 0x5A, 0x19, 0x16,
                0x7C, 0x60,
                0xF1, 0x41,
                0xBF,
                0x03,
                0xC7,
                0x69,
                0x4D,
                0x60,
                0xA8,
                0xD4
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
