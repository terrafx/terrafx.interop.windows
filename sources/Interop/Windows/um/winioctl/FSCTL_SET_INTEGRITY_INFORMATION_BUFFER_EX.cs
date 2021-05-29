// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct FSCTL_SET_INTEGRITY_INFORMATION_BUFFER_EX
    {
        [NativeTypeName("BYTE")]
        public byte EnableIntegrity;

        [NativeTypeName("BYTE")]
        public byte KeepIntegrityStateUnchanged;

        [NativeTypeName("WORD")]
        public ushort Reserved;

        [NativeTypeName("DWORD")]
        public uint Flags;

        [NativeTypeName("BYTE")]
        public byte Version;

        [NativeTypeName("BYTE [7]")]
        public fixed byte Reserved2[7];
    }
}
