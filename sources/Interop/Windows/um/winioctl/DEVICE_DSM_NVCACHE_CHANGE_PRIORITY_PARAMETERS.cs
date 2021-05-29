// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct DEVICE_DSM_NVCACHE_CHANGE_PRIORITY_PARAMETERS
    {
        [NativeTypeName("DWORD")]
        public uint Size;

        [NativeTypeName("BYTE")]
        public byte TargetPriority;

        [NativeTypeName("BYTE [3]")]
        public fixed byte Reserved[3];
    }
}
