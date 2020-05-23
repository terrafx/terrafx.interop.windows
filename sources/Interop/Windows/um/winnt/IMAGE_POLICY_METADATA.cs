// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct IMAGE_POLICY_METADATA
    {
        [NativeTypeName("BYTE")]
        public byte Version;

        [NativeTypeName("BYTE [7]")]
        public fixed byte Reserved0[7];

        [NativeTypeName("ULONGLONG")]
        public ulong ApplicationId;

        [NativeTypeName("IMAGE_POLICY_ENTRY []")]
        public IMAGE_POLICY_ENTRY Policies;
    }
}
