// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public partial struct DRIVE_LAYOUT_INFORMATION_GPT
    {
        [NativeTypeName("GUID")]
        public Guid DiskId;

        public LARGE_INTEGER StartingUsableOffset;

        public LARGE_INTEGER UsableLength;

        [NativeTypeName("DWORD")]
        public uint MaxPartitionCount;
    }
}
