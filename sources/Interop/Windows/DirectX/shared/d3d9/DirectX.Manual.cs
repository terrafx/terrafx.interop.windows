// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.Windows;

namespace TerraFX.Interop.DirectX;

public static unsafe partial class DirectX
{
    public static HRESULT MAKE_D3DHRESULT(int code)
    {
        return MAKE_HRESULT(1, _FACD3D, code);
    }

    public static HRESULT MAKE_D3DSTATUS(int code)
    {
        return MAKE_HRESULT(0, _FACD3D, code);
    }
}
