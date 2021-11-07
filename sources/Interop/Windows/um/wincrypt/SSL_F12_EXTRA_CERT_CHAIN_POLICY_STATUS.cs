// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace TerraFX.Interop
{
    [SupportedOSPlatform("windows10.0")]
    public unsafe partial struct SSL_F12_EXTRA_CERT_CHAIN_POLICY_STATUS
    {
        [NativeTypeName("DWORD")]
        public uint cbSize;

        [NativeTypeName("DWORD")]
        public uint dwErrorLevel;

        [NativeTypeName("DWORD")]
        public uint dwErrorCategory;

        [NativeTypeName("DWORD")]
        public uint dwReserved;

        [NativeTypeName("WCHAR [256]")]
        public fixed ushort wszErrorText[256];
    }
}
