// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct CERT_NAME_VALUE
    {
        [NativeTypeName("DWORD")]
        public uint dwValueType;

        [NativeTypeName("CERT_RDN_VALUE_BLOB")]
        public CRYPTOAPI_BLOB Value;
    }
}
