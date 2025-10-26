// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3dx12_root_signature.h in microsoft/DirectX-Headers tag v1.618.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

public unsafe partial struct D3D12_ROOT_DESCRIPTOR
{
    public D3D12_ROOT_DESCRIPTOR(uint shaderRegister, uint registerSpace = 0)
    {
        Init(shaderRegister, registerSpace);
    }

    public void Init(uint shaderRegister, uint registerSpace = 0)
    {
        Init(ref this, shaderRegister, registerSpace);
    }

    public static void Init([NativeTypeName("D3D12_ROOT_DESCRIPTOR &")] ref D3D12_ROOT_DESCRIPTOR table, uint shaderRegister, uint registerSpace = 0)
    {
        table.ShaderRegister = shaderRegister;
        table.RegisterSpace = registerSpace;
    }
}
