// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public unsafe partial struct DEVICE_DSM_LOST_QUERY_OUTPUT
    {
        [NativeTypeName("DWORD")]
        public uint Version;

        [NativeTypeName("DWORD")]
        public uint Size;

        [NativeTypeName("DWORDLONG")]
        public ulong Alignment;

        [NativeTypeName("DWORD")]
        public uint NumberOfBits;

        [NativeTypeName("DWORD [1]")]
        public fixed uint BitMap[1];
    }
}
