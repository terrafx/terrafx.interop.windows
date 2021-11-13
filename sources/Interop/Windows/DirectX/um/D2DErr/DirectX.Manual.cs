// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2derr.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.Windows;

namespace TerraFX.Interop.DirectX
{
    public static partial class DirectX
    {
        public static HRESULT MAKE_D2DHR(int sev, int code) => MAKE_HRESULT(sev, FACILITY_D2D, code);

        public static HRESULT MAKE_D2DHR_ERR(int code) => MAKE_D2DHR(1, code);
    }
}
