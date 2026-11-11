// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12sdklayers.h in microsoft/DirectX-Headers tag v1.620.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;

public static unsafe partial class DirectX
{
    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.WKPDID_D3DAutoDebugObjectNameW"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid WKPDID_D3DAutoDebugObjectNameW
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.D3D12SDKLayersGetInterface"]/*' />
    [DllImport("d3d12sdklayers", ExactSpelling = true)]
    public static extern HRESULT D3D12SDKLayersGetInterface([NativeTypeName("const IID &")] Guid* rclsid, [NativeTypeName("const IID &")] Guid* riid, void** ppvInterface);
}
