// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2derr.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using static TerraFX.Interop.Windows;

namespace TerraFX.Interop
{
    public static partial class D2D1
    {
        public const int FACILITY_D2D = 0x899;

        public const int D2DERR_UNSUPPORTED_PIXEL_FORMAT = WINCODEC_ERR_UNSUPPORTEDPIXELFORMAT;

        public const int D2DERR_INSUFFICIENT_BUFFER = unchecked((int)(ERROR_INSUFFICIENT_BUFFER | (FACILITY_WIN32 << 16) | 0x80000000));

        public const int D2DERR_FILE_NOT_FOUND = unchecked((int)(ERROR_FILE_NOT_FOUND | (FACILITY_WIN32 << 16) | 0x80000000));

        public static int MAKE_D2DHR(int sev, int code) => MAKE_HRESULT(sev, FACILITY_D2D, code);

        public static int MAKE_D2DHR_ERR(int code) => MAKE_D2DHR(1, code);
    }
}
