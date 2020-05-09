// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct ACL
    {
        [NativeTypeName("BYTE")]
        public byte AclRevision;

        [NativeTypeName("BYTE")]
        public byte Sbz1;

        [NativeTypeName("WORD")]
        public ushort AclSize;

        [NativeTypeName("WORD")]
        public ushort AceCount;

        [NativeTypeName("WORD")]
        public ushort Sbz2;
    }
}
