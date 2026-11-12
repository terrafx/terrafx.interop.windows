// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

namespace TerraFX.Interop.DirectX;

public static partial class DIDFT
{
    public static uint DIDFT_MAKEINSTANCE(uint n) => (uint)(unchecked((ushort)n) << 8);

    public static byte DIDFT_GETTYPE(uint n) => (byte)(n & 0xFF);

    public static ushort DIDFT_GETINSTANCE(uint n) => unchecked((ushort)(n >> 8));

    public static uint DIDFT_ENUMCOLLECTION(uint n) => (uint)(unchecked((ushort)n) << 8);
}
