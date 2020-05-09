// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct SYSTEM_AUDIT_CALLBACK_ACE
    {
        public ACE_HEADER Header;

        [NativeTypeName("ACCESS_MASK")]
        public uint Mask;

        [NativeTypeName("DWORD")]
        public uint SidStart;
    }
}
