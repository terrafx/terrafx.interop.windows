// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mmdeviceapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using static TerraFX.Interop.Windows.Windows;

namespace TerraFX.Interop.Windows
{
    public static unsafe partial class E
    {
        [NativeTypeName("#define E_NOTFOUND HRESULT_FROM_WIN32(ERROR_NOT_FOUND)")]
        public static HRESULT E_NOTFOUND => HRESULT_FROM_WIN32(1168);

        [NativeTypeName("#define E_UNSUPPORTED_TYPE HRESULT_FROM_WIN32(ERROR_UNSUPPORTED_TYPE)")]
        public static HRESULT E_UNSUPPORTED_TYPE => HRESULT_FROM_WIN32(1630);
    }
}
