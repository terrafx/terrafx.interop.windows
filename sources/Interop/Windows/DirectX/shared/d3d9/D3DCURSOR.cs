// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

public static partial class D3DCURSOR
{
    [NativeTypeName("#define D3DCURSOR_IMMEDIATE_UPDATE 0x00000001L")]
    public const int D3DCURSOR_IMMEDIATE_UPDATE = 0x00000001;
}
