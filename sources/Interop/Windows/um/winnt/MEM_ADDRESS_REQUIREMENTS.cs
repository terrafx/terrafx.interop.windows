// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct MEM_ADDRESS_REQUIREMENTS
    {
        [NativeTypeName("PVOID")]
        public void* LowestStartingAddress;

        [NativeTypeName("PVOID")]
        public void* HighestEndingAddress;

        [NativeTypeName("SIZE_T")]
        public nuint Alignment;
    }
}
