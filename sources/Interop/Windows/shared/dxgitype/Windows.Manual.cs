// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/dxgitype.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        public static int MAKE_DXGI_HRESULT(int code) => MAKE_HRESULT(1, _FACDXGI, code);

        public static int MAKE_DXGI_STATUS(int code) => MAKE_HRESULT(0, _FACDXGI, code);
    }
}
