// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct CERT_FORTEZZA_DATA_PROP
    {
        [NativeTypeName("unsigned char [8]")]
        public fixed byte SerialNumber[8];

        public int CertIndex;

        [NativeTypeName("unsigned char [36]")]
        public fixed byte CertLabel[36];
    }
}
