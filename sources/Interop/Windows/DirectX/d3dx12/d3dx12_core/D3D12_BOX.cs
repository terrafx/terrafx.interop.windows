// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3dx12_core.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_BOX.xml' path='doc/member[@name="D3D12_BOX"]/*' />
[NativeTypeName("struct CD3DX12_BOX : D3D12_BOX")]
[NativeInheritance("D3D12_BOX")]
public partial struct D3D12_BOX
{
    public D3D12_BOX([NativeTypeName("LONG")] int Left, [NativeTypeName("LONG")] int Right)
    {
        left = (uint)(Left);
        top = 0;
        front = 0;
        right = (uint)(Right);
        bottom = 1;
        back = 1;
    }

    public D3D12_BOX([NativeTypeName("LONG")] int Left, [NativeTypeName("LONG")] int Top, [NativeTypeName("LONG")] int Right, [NativeTypeName("LONG")] int Bottom)
    {
        left = (uint)(Left);
        top = (uint)(Top);
        front = 0;
        right = (uint)(Right);
        bottom = (uint)(Bottom);
        back = 1;
    }

    public D3D12_BOX([NativeTypeName("LONG")] int Left, [NativeTypeName("LONG")] int Top, [NativeTypeName("LONG")] int Front, [NativeTypeName("LONG")] int Right, [NativeTypeName("LONG")] int Bottom, [NativeTypeName("LONG")] int Back)
    {
        left = (uint)(Left);
        top = (uint)(Top);
        front = (uint)(Front);
        right = (uint)(Right);
        bottom = (uint)(Bottom);
        back = (uint)(Back);
    }
}
