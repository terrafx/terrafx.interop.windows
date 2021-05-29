// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct CERT_AUTHORITY_INFO_ACCESS
    {
        [NativeTypeName("DWORD")]
        public uint cAccDescr;

        [NativeTypeName("PCERT_ACCESS_DESCRIPTION")]
        public CERT_ACCESS_DESCRIPTION* rgAccDescr;
    }
}
