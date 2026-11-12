// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

namespace TerraFX.Interop.DirectX;

public static partial class D3DTS
{
    public static D3DTRANSFORMSTATETYPE D3DTS_WORLDMATRIX(int index)
        => unchecked((D3DTRANSFORMSTATETYPE)(index + 256));
}
