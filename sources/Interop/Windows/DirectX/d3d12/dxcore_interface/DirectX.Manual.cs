// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from dxcore_interface.h in microsoft/DirectX-Headers tag v1.618.2
// Original source is Copyright © Microsoft. All rights reserved.

using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.Windows;

namespace TerraFX.Interop.DirectX;

public static partial class DirectX
{
    public static HRESULT MAKE_DXCORE_HRESULT(int code) => MAKE_HRESULT(1, _FACDXCORE, code);
}
