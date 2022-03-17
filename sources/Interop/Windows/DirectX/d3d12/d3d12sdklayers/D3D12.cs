// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12sdklayers.h in Microsoft.Direct3D.D3D12 v1.600.10
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

public static partial class D3D12
{
    [NativeTypeName("#define D3D12_INFO_QUEUE_DEFAULT_MESSAGE_COUNT_LIMIT 1024")]
    public const int D3D12_INFO_QUEUE_DEFAULT_MESSAGE_COUNT_LIMIT = 1024;
}
