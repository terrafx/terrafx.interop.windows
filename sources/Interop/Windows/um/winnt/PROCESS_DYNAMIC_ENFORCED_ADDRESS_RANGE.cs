// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct PROCESS_DYNAMIC_ENFORCED_ADDRESS_RANGE
    {
        [NativeTypeName("ULONG_PTR")]
        public nuint BaseAddress;

        [NativeTypeName("SIZE_T")]
        public nuint Size;

        [NativeTypeName("DWORD")]
        public uint Flags;
    }
}
