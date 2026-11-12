// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

namespace TerraFX.Interop.DirectX;

public static partial class DXC
{
    public static uint DXC_FOURCC(char ch0, char ch1, char ch2, char ch3)
        => unchecked((uint)(byte)ch0) | (unchecked((uint)(byte)ch1) << 8) | (unchecked((uint)(byte)ch2) << 16) | (unchecked((uint)(byte)ch3) << 24);
}
