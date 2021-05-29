// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct _KERNEL_CET_CONTEXT
    {
        [NativeTypeName("DWORD64")]
        public ulong Ssp;

        [NativeTypeName("DWORD64")]
        public ulong Rip;

        [NativeTypeName("WORD")]
        public ushort SegCs;

        [NativeTypeName("WORD [3]")]
        public fixed ushort Fill[3];
    }
}
