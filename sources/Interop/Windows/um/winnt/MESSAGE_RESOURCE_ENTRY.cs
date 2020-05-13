// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct MESSAGE_RESOURCE_ENTRY
    {
        [NativeTypeName("WORD")]
        public ushort Length;

        [NativeTypeName("WORD")]
        public ushort Flags;

        [NativeTypeName("BYTE [1]")]
        public fixed byte Text[1];
    }
}
