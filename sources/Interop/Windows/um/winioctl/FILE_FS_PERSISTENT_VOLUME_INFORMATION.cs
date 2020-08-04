// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct FILE_FS_PERSISTENT_VOLUME_INFORMATION
    {
        [NativeTypeName("DWORD")]
        public uint VolumeFlags;

        [NativeTypeName("DWORD")]
        public uint FlagMask;

        [NativeTypeName("DWORD")]
        public uint Version;

        [NativeTypeName("DWORD")]
        public uint Reserved;
    }
}
