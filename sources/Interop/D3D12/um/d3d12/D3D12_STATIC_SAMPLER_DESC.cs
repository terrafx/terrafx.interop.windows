// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d3d12.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using static TerraFX.Interop.D3D12;
using static TerraFX.Interop.D3D12_COMPARISON_FUNC;
using static TerraFX.Interop.D3D12_FILTER;
using static TerraFX.Interop.D3D12_SHADER_VISIBILITY;
using static TerraFX.Interop.D3D12_STATIC_BORDER_COLOR;
using static TerraFX.Interop.D3D12_TEXTURE_ADDRESS_MODE;

namespace TerraFX.Interop
{
    public unsafe partial struct D3D12_STATIC_SAMPLER_DESC
    {
        public D3D12_FILTER Filter;

        public D3D12_TEXTURE_ADDRESS_MODE AddressU;

        public D3D12_TEXTURE_ADDRESS_MODE AddressV;

        public D3D12_TEXTURE_ADDRESS_MODE AddressW;

        [NativeTypeName("FLOAT")]
        public float MipLODBias;

        [NativeTypeName("UINT")]
        public uint MaxAnisotropy;

        public D3D12_COMPARISON_FUNC ComparisonFunc;

        public D3D12_STATIC_BORDER_COLOR BorderColor;

        [NativeTypeName("FLOAT")]
        public float MinLOD;

        [NativeTypeName("FLOAT")]
        public float MaxLOD;

        [NativeTypeName("UINT")]
        public uint ShaderRegister;

        [NativeTypeName("UINT")]
        public uint RegisterSpace;

        public D3D12_SHADER_VISIBILITY ShaderVisibility;

        public D3D12_STATIC_SAMPLER_DESC(uint shaderRegister, D3D12_FILTER filter = D3D12_FILTER_ANISOTROPIC, D3D12_TEXTURE_ADDRESS_MODE addressU = D3D12_TEXTURE_ADDRESS_MODE_WRAP, D3D12_TEXTURE_ADDRESS_MODE addressV = D3D12_TEXTURE_ADDRESS_MODE_WRAP, D3D12_TEXTURE_ADDRESS_MODE addressW = D3D12_TEXTURE_ADDRESS_MODE_WRAP, float mipLODBias = 0, uint maxAnisotropy = 16, D3D12_COMPARISON_FUNC comparisonFunc = D3D12_COMPARISON_FUNC_LESS_EQUAL, D3D12_STATIC_BORDER_COLOR borderColor = D3D12_STATIC_BORDER_COLOR_OPAQUE_WHITE, float minLOD = 0, float maxLOD = D3D12_FLOAT32_MAX, D3D12_SHADER_VISIBILITY shaderVisibility = D3D12_SHADER_VISIBILITY_ALL, uint registerSpace = 0)
        {
            fixed (D3D12_STATIC_SAMPLER_DESC* pThis = &this)
            {
                Init(pThis, shaderRegister, filter, addressU, addressV, addressW, mipLODBias, maxAnisotropy, comparisonFunc, borderColor, minLOD, maxLOD, shaderVisibility, registerSpace);
            }
        }

        public static void Init(D3D12_STATIC_SAMPLER_DESC* samplerDesc, uint shaderRegister, D3D12_FILTER filter = D3D12_FILTER_ANISOTROPIC, D3D12_TEXTURE_ADDRESS_MODE addressU = D3D12_TEXTURE_ADDRESS_MODE_WRAP, D3D12_TEXTURE_ADDRESS_MODE addressV = D3D12_TEXTURE_ADDRESS_MODE_WRAP, D3D12_TEXTURE_ADDRESS_MODE addressW = D3D12_TEXTURE_ADDRESS_MODE_WRAP, float mipLODBias = 0, uint maxAnisotropy = 16, D3D12_COMPARISON_FUNC comparisonFunc = D3D12_COMPARISON_FUNC_LESS_EQUAL, D3D12_STATIC_BORDER_COLOR borderColor = D3D12_STATIC_BORDER_COLOR_OPAQUE_WHITE, float minLOD = 0, float maxLOD = D3D12_FLOAT32_MAX, D3D12_SHADER_VISIBILITY shaderVisibility = D3D12_SHADER_VISIBILITY_ALL, uint registerSpace = 0)
        {
            samplerDesc->ShaderRegister = shaderRegister;
            samplerDesc->Filter = filter;
            samplerDesc->AddressU = addressU;
            samplerDesc->AddressV = addressV;
            samplerDesc->AddressW = addressW;
            samplerDesc->MipLODBias = mipLODBias;
            samplerDesc->MaxAnisotropy = maxAnisotropy;
            samplerDesc->ComparisonFunc = comparisonFunc;
            samplerDesc->BorderColor = borderColor;
            samplerDesc->MinLOD = minLOD;
            samplerDesc->MaxLOD = maxLOD;
            samplerDesc->ShaderVisibility = shaderVisibility;
            samplerDesc->RegisterSpace = registerSpace;
        }
        public void Init(uint shaderRegister, D3D12_FILTER filter = D3D12_FILTER_ANISOTROPIC, D3D12_TEXTURE_ADDRESS_MODE addressU = D3D12_TEXTURE_ADDRESS_MODE_WRAP, D3D12_TEXTURE_ADDRESS_MODE addressV = D3D12_TEXTURE_ADDRESS_MODE_WRAP, D3D12_TEXTURE_ADDRESS_MODE addressW = D3D12_TEXTURE_ADDRESS_MODE_WRAP, float mipLODBias = 0, uint maxAnisotropy = 16, D3D12_COMPARISON_FUNC comparisonFunc = D3D12_COMPARISON_FUNC_LESS_EQUAL, D3D12_STATIC_BORDER_COLOR borderColor = D3D12_STATIC_BORDER_COLOR_OPAQUE_WHITE, float minLOD = 0, float maxLOD = D3D12_FLOAT32_MAX, D3D12_SHADER_VISIBILITY shaderVisibility = D3D12_SHADER_VISIBILITY_ALL, uint registerSpace = 0)
        {
            fixed (D3D12_STATIC_SAMPLER_DESC* pThis = &this)
            {
                Init(pThis, shaderRegister, filter, addressU, addressV, addressW, mipLODBias, maxAnisotropy, comparisonFunc, borderColor, minLOD, maxLOD, shaderVisibility, registerSpace);
            }
        }
    }
}
