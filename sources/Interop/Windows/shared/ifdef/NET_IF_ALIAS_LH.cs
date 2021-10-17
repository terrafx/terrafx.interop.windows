// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/ifdef.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct NET_IF_ALIAS_LH
    {
        [NativeTypeName("USHORT")]
        public ushort ifAliasLength;

        [NativeTypeName("USHORT")]
        public ushort ifAliasOffset;
    }
}
