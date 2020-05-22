// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum D3D11_COUNTER_TYPE
    {
        D3D11_COUNTER_TYPE_FLOAT32 = 0,
        D3D11_COUNTER_TYPE_UINT16 = (D3D11_COUNTER_TYPE_FLOAT32 + 1),
        D3D11_COUNTER_TYPE_UINT32 = (D3D11_COUNTER_TYPE_UINT16 + 1),
        D3D11_COUNTER_TYPE_UINT64 = (D3D11_COUNTER_TYPE_UINT32 + 1),
    }
}
