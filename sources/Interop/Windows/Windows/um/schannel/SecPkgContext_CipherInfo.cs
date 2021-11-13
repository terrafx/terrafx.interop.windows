// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/schannel.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public unsafe partial struct SecPkgContext_CipherInfo
    {
        [NativeTypeName("DWORD")]
        public uint dwVersion;

        [NativeTypeName("DWORD")]
        public uint dwProtocol;

        [NativeTypeName("DWORD")]
        public uint dwCipherSuite;

        [NativeTypeName("DWORD")]
        public uint dwBaseCipherSuite;

        [NativeTypeName("WCHAR [64]")]
        public fixed ushort szCipherSuite[64];

        [NativeTypeName("WCHAR [64]")]
        public fixed ushort szCipher[64];

        [NativeTypeName("DWORD")]
        public uint dwCipherLen;

        [NativeTypeName("DWORD")]
        public uint dwCipherBlockLen;

        [NativeTypeName("WCHAR [64]")]
        public fixed ushort szHash[64];

        [NativeTypeName("DWORD")]
        public uint dwHashLen;

        [NativeTypeName("WCHAR [64]")]
        public fixed ushort szExchange[64];

        [NativeTypeName("DWORD")]
        public uint dwMinExchangeLen;

        [NativeTypeName("DWORD")]
        public uint dwMaxExchangeLen;

        [NativeTypeName("WCHAR [64]")]
        public fixed ushort szCertificate[64];

        [NativeTypeName("DWORD")]
        public uint dwKeyType;
    }
}
