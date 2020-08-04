// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct DEVICE_DSM_LOST_QUERY_PARAMETERS
    {
        [NativeTypeName("DWORD")]
        public uint Version;

        [NativeTypeName("DWORDLONG")]
        public ulong Granularity;
    }
}
