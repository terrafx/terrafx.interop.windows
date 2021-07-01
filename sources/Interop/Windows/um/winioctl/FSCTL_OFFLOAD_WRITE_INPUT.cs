// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct FSCTL_OFFLOAD_WRITE_INPUT
    {
        [NativeTypeName("DWORD")]
        public uint Size;

        [NativeTypeName("DWORD")]
        public uint Flags;

        [NativeTypeName("DWORDLONG")]
        public ulong FileOffset;

        [NativeTypeName("DWORDLONG")]
        public ulong CopyLength;

        [NativeTypeName("DWORDLONG")]
        public ulong TransferOffset;

        [NativeTypeName("BYTE [512]")]
        public fixed byte Token[512];
    }
}
