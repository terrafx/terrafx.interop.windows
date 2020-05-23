// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using static TerraFX.Interop.D3D11_COMPARISON_FUNC;
using static TerraFX.Interop.D3D11_FILTER;
using static TerraFX.Interop.D3D11_TEXTURE_ADDRESS_MODE;

namespace TerraFX.Interop
{
    public unsafe partial struct D3D11_SAMPLER_DESC
    {
        public static readonly D3D11_SAMPLER_DESC DEFAULT = new D3D11_SAMPLER_DESC(
            filter: D3D11_FILTER_MIN_MAG_MIP_LINEAR,
            addressU: D3D11_TEXTURE_ADDRESS_CLAMP,
            addressV: D3D11_TEXTURE_ADDRESS_CLAMP,
            addressW: D3D11_TEXTURE_ADDRESS_CLAMP,
            mipLODBias: 0,
            maxAnisotropy: 1,
            comparisonFunc: D3D11_COMPARISON_NEVER,
            borderColor: null,
            minLOD: float.MinValue,
            maxLOD: float.MaxValue
        );

        public D3D11_SAMPLER_DESC(D3D11_FILTER filter, D3D11_TEXTURE_ADDRESS_MODE addressU, D3D11_TEXTURE_ADDRESS_MODE addressV, D3D11_TEXTURE_ADDRESS_MODE addressW, [NativeTypeName("FLOAT")] float mipLODBias, [NativeTypeName("UINT")] uint maxAnisotropy, D3D11_COMPARISON_FUNC comparisonFunc, [NativeTypeName("FLOAT [4]")] float* borderColor, [NativeTypeName("FLOAT")] float minLOD, [NativeTypeName("FLOAT")] float maxLOD)
        {
            Filter = filter;
            AddressU = addressU;
            AddressV = addressV;
            AddressW = addressW;
            MipLODBias = mipLODBias;
            MaxAnisotropy = maxAnisotropy;
            ComparisonFunc = comparisonFunc;

            var defaultColor = stackalloc float[4] { 1.0f, 1.0f, 1.0f, 1.0f };

            if (borderColor == null)
            {
                borderColor = defaultColor;
            }

            BorderColor[0] = borderColor[0];
            BorderColor[1] = borderColor[1];
            BorderColor[2] = borderColor[2];
            BorderColor[3] = borderColor[3];
            MinLOD = minLOD;
            MaxLOD = maxLOD;
        }
    }
}
