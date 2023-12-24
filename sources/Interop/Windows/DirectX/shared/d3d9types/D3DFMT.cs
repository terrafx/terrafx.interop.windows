// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

public static partial class D3DFMT
{
    [NativeTypeName("#define D3DFMT_A1_SURFACE_MAXWIDTH 8192")]
    public const int D3DFMT_A1_SURFACE_MAXWIDTH = 8192;

    [NativeTypeName("#define D3DFMT_A1_SURFACE_MAXHEIGHT 2048")]
    public const int D3DFMT_A1_SURFACE_MAXHEIGHT = 2048;
}
