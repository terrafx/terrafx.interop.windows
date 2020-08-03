// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2derr.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        public static int MAKE_D2DHR(int sev, int code) => MAKE_HRESULT(sev, FACILITY_D2D, code);

        public static int MAKE_D2DHR_ERR(int code) => MAKE_D2DHR(1, code);
    }
}
