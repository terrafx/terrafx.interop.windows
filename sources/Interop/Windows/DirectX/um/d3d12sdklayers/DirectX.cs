// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12sdklayers.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.DirectX
{
    public static partial class DirectX
    {
        [NativeTypeName("const GUID")]
        public static ref readonly Guid WKPDID_D3DAutoDebugObjectNameW
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x36, 0x2E, 0x90, 0xD4,
                    0x7A, 0x75,
                    0x42, 0x49,
                    0x95,
                    0x94,
                    0xB6,
                    0x76,
                    0x9A,
                    0xFA,
                    0x43,
                    0xCD
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }
    }
}
