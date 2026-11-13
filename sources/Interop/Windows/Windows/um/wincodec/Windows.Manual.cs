// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class Windows
{
    public static HRESULT MAKE_WINCODECHR(int sev, int code)
        => MAKE_HRESULT(sev, FACILITY.FACILITY_WINCODEC_ERR, WINCODEC.WINCODEC_ERR_BASE + code);

    public static HRESULT MAKE_WINCODECHR_ERR(int code)
        => MAKE_WINCODECHR(1, code);
}
