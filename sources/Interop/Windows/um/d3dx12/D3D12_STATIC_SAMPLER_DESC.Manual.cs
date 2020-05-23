// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3dx12.h in DirectX-Graphics-Samples commit a7a87f1853b5540f10920518021d91ae641033fb
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
        public D3D12_STATIC_SAMPLER_DESC([NativeTypeName("UINT")] uint shaderRegister, D3D12_FILTER filter = D3D12_FILTER_ANISOTROPIC, D3D12_TEXTURE_ADDRESS_MODE addressU = D3D12_TEXTURE_ADDRESS_MODE_WRAP, D3D12_TEXTURE_ADDRESS_MODE addressV = D3D12_TEXTURE_ADDRESS_MODE_WRAP, D3D12_TEXTURE_ADDRESS_MODE addressW = D3D12_TEXTURE_ADDRESS_MODE_WRAP, [NativeTypeName("FLOAT")] float mipLODBias = 0, [NativeTypeName("UINT")] uint maxAnisotropy = 16, D3D12_COMPARISON_FUNC comparisonFunc = D3D12_COMPARISON_FUNC_LESS_EQUAL, D3D12_STATIC_BORDER_COLOR borderColor = D3D12_STATIC_BORDER_COLOR_OPAQUE_WHITE, [NativeTypeName("FLOAT")] float minLOD = 0, [NativeTypeName("FLOAT")] float maxLOD = D3D12_FLOAT32_MAX, D3D12_SHADER_VISIBILITY shaderVisibility = D3D12_SHADER_VISIBILITY_ALL, [NativeTypeName("UINT")] uint registerSpace = 0)
        {
            Init(out this, shaderRegister, filter, addressU, addressV, addressW, mipLODBias, maxAnisotropy, comparisonFunc, borderColor, minLOD, maxLOD, shaderVisibility, registerSpace);
        }

        public static void Init([NativeTypeName("D3D12_STATIC_SAMPLER_DESC &")] out D3D12_STATIC_SAMPLER_DESC samplerDesc, [NativeTypeName("UINT")] uint shaderRegister, D3D12_FILTER filter = D3D12_FILTER_ANISOTROPIC, D3D12_TEXTURE_ADDRESS_MODE addressU = D3D12_TEXTURE_ADDRESS_MODE_WRAP, D3D12_TEXTURE_ADDRESS_MODE addressV = D3D12_TEXTURE_ADDRESS_MODE_WRAP, D3D12_TEXTURE_ADDRESS_MODE addressW = D3D12_TEXTURE_ADDRESS_MODE_WRAP, [NativeTypeName("FLOAT")] float mipLODBias = 0, [NativeTypeName("UINT")] uint maxAnisotropy = 16, D3D12_COMPARISON_FUNC comparisonFunc = D3D12_COMPARISON_FUNC_LESS_EQUAL, D3D12_STATIC_BORDER_COLOR borderColor = D3D12_STATIC_BORDER_COLOR_OPAQUE_WHITE, [NativeTypeName("FLOAT")] float minLOD = 0, [NativeTypeName("FLOAT")] float maxLOD = D3D12_FLOAT32_MAX, D3D12_SHADER_VISIBILITY shaderVisibility = D3D12_SHADER_VISIBILITY_ALL, [NativeTypeName("UINT")] uint registerSpace = 0)
        {
            samplerDesc.ShaderRegister = shaderRegister;
            samplerDesc.Filter = filter;
            samplerDesc.AddressU = addressU;
            samplerDesc.AddressV = addressV;
            samplerDesc.AddressW = addressW;
            samplerDesc.MipLODBias = mipLODBias;
            samplerDesc.MaxAnisotropy = maxAnisotropy;
            samplerDesc.ComparisonFunc = comparisonFunc;
            samplerDesc.BorderColor = borderColor;
            samplerDesc.MinLOD = minLOD;
            samplerDesc.MaxLOD = maxLOD;
            samplerDesc.ShaderVisibility = shaderVisibility;
            samplerDesc.RegisterSpace = registerSpace;
        }

        public void Init([NativeTypeName("UINT")] uint shaderRegister, D3D12_FILTER filter = D3D12_FILTER_ANISOTROPIC, D3D12_TEXTURE_ADDRESS_MODE addressU = D3D12_TEXTURE_ADDRESS_MODE_WRAP, D3D12_TEXTURE_ADDRESS_MODE addressV = D3D12_TEXTURE_ADDRESS_MODE_WRAP, D3D12_TEXTURE_ADDRESS_MODE addressW = D3D12_TEXTURE_ADDRESS_MODE_WRAP, [NativeTypeName("FLOAT")] float mipLODBias = 0, [NativeTypeName("UINT")] uint maxAnisotropy = 16, D3D12_COMPARISON_FUNC comparisonFunc = D3D12_COMPARISON_FUNC_LESS_EQUAL, D3D12_STATIC_BORDER_COLOR borderColor = D3D12_STATIC_BORDER_COLOR_OPAQUE_WHITE, [NativeTypeName("FLOAT")] float minLOD = 0, [NativeTypeName("FLOAT")] float maxLOD = D3D12_FLOAT32_MAX, D3D12_SHADER_VISIBILITY shaderVisibility = D3D12_SHADER_VISIBILITY_ALL, [NativeTypeName("UINT")] uint registerSpace = 0)
        {
            Init(out this, shaderRegister, filter, addressU, addressV, addressW, mipLODBias, maxAnisotropy, comparisonFunc, borderColor, minLOD, maxLOD, shaderVisibility, registerSpace);
        }
    }
}
