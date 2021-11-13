// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winhttp.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public unsafe partial struct WINHTTP_CURRENT_USER_IE_PROXY_CONFIG
    {
        public BOOL fAutoDetect;

        [NativeTypeName("LPWSTR")]
        public ushort* lpszAutoConfigUrl;

        [NativeTypeName("LPWSTR")]
        public ushort* lpszProxy;

        [NativeTypeName("LPWSTR")]
        public ushort* lpszProxyBypass;
    }
}
