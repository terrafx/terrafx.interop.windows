// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from DirectXHelpers.h in the microsoft/DirectXTK12 tag jan2021
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the University of Illinois Open Source License.

using TerraFX.Interop.Windows;
using static TerraFX.Interop.DirectX.D3D_ROOT_SIGNATURE_VERSION;
using static TerraFX.Interop.Windows.Windows;

namespace TerraFX.Interop.DirectX;

public static unsafe partial class DirectX
{
    public static HRESULT CreateRootSignature(ID3D12Device* device, [NativeTypeName("const D3D12_ROOT_SIGNATURE_DESC *")] D3D12_ROOT_SIGNATURE_DESC* rootSignatureDesc, ID3D12RootSignature** rootSignature)
    {
        using ComPtr<ID3DBlob> pSignature = new ComPtr<ID3DBlob>();
        using ComPtr<ID3DBlob> pError = new ComPtr<ID3DBlob>();

        HRESULT hr = D3D12SerializeRootSignature(rootSignatureDesc, D3D_ROOT_SIGNATURE_VERSION_1, pSignature.GetAddressOf(), pError.GetAddressOf());

        if (SUCCEEDED(hr))
        {
            hr = device->CreateRootSignature(0, pSignature.Get()->GetBufferPointer(), pSignature.Get()->GetBufferSize(), __uuidof<ID3D12RootSignature>(), (void**)rootSignature);
        }

        return hr;
    }
}
