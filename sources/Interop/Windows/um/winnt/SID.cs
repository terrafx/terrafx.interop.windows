// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct SID
    {
        [NativeTypeName("BYTE")]
        public byte Revision;

        [NativeTypeName("BYTE")]
        public byte SubAuthorityCount;

        public SID_IDENTIFIER_AUTHORITY IdentifierAuthority;

        [NativeTypeName("DWORD [1]")]
        public fixed uint SubAuthority[1];
    }
}
