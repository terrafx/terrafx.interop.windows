// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public static unsafe partial class Windows
    {
        public static uint DWRITE_MAKE_OPENTYPE_TAG(byte a, byte b, byte c, byte d) => ((uint)d << 24) | ((uint)c << 16) | ((uint)b << 8) | a;

        public static HRESULT MAKE_DWRITE_HR(int severity, int code) => MAKE_HRESULT(severity, FACILITY_DWRITE, DWRITE_ERR_BASE + code);

        public static HRESULT MAKE_DWRITE_HR_ERR(int code) => MAKE_DWRITE_HR(SEVERITY_ERROR, code);
    }
}
