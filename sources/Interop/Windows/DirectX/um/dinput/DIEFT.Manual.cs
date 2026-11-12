// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

namespace TerraFX.Interop.DirectX;

public static partial class DIEFT
{
    public static byte DIEFT_GETTYPE(uint n) => (byte)(n & 0xFF);
}
