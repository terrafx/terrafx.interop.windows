// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/schannel.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct X509Certificate
    {
        [NativeTypeName("DWORD")]
        public uint Version;

        [NativeTypeName("DWORD [4]")]
        public fixed uint SerialNumber[4];

        [NativeTypeName("ALG_ID")]
        public uint SignatureAlgorithm;

        public FILETIME ValidFrom;

        public FILETIME ValidUntil;

        [NativeTypeName("PSTR")]
        public sbyte* pszIssuer;

        [NativeTypeName("PSTR")]
        public sbyte* pszSubject;

        public PctPublicKey* pPublicKey;
    }
}
