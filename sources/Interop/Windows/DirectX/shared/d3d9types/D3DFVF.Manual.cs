// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

namespace TerraFX.Interop.DirectX;

public static partial class D3DFVF
{
    public static int D3DFVF_TEXCOORDSIZE1(int CoordIndex) => D3DFVF_TEXTUREFORMAT1 << (CoordIndex * 2 + 16);

    public static int D3DFVF_TEXCOORDSIZE2(int CoordIndex) => D3DFVF_TEXTUREFORMAT2;

    public static int D3DFVF_TEXCOORDSIZE3(int CoordIndex) => D3DFVF_TEXTUREFORMAT3 << (CoordIndex * 2 + 16);

    public static int D3DFVF_TEXCOORDSIZE4(int CoordIndex) => D3DFVF_TEXTUREFORMAT4 << (CoordIndex * 2 + 16);
}
