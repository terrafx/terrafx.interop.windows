// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12sdklayers.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

public static partial class D3D12
{
    [NativeTypeName("#define D3D12_INFO_QUEUE_DEFAULT_MESSAGE_COUNT_LIMIT 1024")]
    public const int D3D12_INFO_QUEUE_DEFAULT_MESSAGE_COUNT_LIMIT = 1024;
}
