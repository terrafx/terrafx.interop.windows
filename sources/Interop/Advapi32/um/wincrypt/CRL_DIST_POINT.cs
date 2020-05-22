// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct CRL_DIST_POINT
    {
        public CRL_DIST_POINT_NAME DistPointName;

        public CRYPT_BIT_BLOB ReasonFlags;

        public CERT_ALT_NAME_INFO CRLIssuer;
    }
}
