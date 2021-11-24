// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;

public partial struct D3D11_CLASS_INSTANCE_DESC
{
    public uint InstanceId;

    public uint InstanceIndex;

    public uint TypeId;

    public uint ConstantBuffer;

    public uint BaseConstantBufferOffset;

    public uint BaseTexture;

    public uint BaseSampler;

    public BOOL Created;
}
