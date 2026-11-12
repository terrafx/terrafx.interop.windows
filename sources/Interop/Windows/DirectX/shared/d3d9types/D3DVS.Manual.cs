// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

namespace TerraFX.Interop.DirectX;

public static partial class D3DVS
{
    public static uint D3DVS_VERSION(uint Major, uint Minor) => 0xFFFE0000u | (Major << 8) | Minor;

    public static uint D3DVS_END() => 0x0000FFFFu;
}
