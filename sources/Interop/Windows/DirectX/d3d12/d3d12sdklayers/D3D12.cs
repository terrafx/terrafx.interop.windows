// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12sdklayers.h in microsoft/DirectX-Headers tag v1.620.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

public static partial class D3D12
{
    /// <include file='D3D12.xml' path='doc/member[@name="D3D12.D3D12_INFO_QUEUE_DEFAULT_MESSAGE_COUNT_LIMIT"]/*' />
    [NativeTypeName("#define D3D12_INFO_QUEUE_DEFAULT_MESSAGE_COUNT_LIMIT 1024")]
    public const int D3D12_INFO_QUEUE_DEFAULT_MESSAGE_COUNT_LIMIT = 1024;
}
