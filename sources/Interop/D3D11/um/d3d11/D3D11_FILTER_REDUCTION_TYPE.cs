// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d3d11.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum D3D11_FILTER_REDUCTION_TYPE
    {
        D3D11_FILTER_REDUCTION_TYPE_STANDARD = 0,
        D3D11_FILTER_REDUCTION_TYPE_COMPARISON = 1,
        D3D11_FILTER_REDUCTION_TYPE_MINIMUM = 2,
        D3D11_FILTER_REDUCTION_TYPE_MAXIMUM = 3,
    }
}
