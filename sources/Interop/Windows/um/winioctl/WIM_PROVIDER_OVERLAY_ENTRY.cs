// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public partial struct WIM_PROVIDER_OVERLAY_ENTRY
    {
        [NativeTypeName("DWORD")]
        public uint NextEntryOffset;

        public LARGE_INTEGER DataSourceId;

        [NativeTypeName("GUID")]
        public Guid WimGuid;

        [NativeTypeName("DWORD")]
        public uint WimFileNameOffset;

        [NativeTypeName("DWORD")]
        public uint WimType;

        [NativeTypeName("DWORD")]
        public uint WimIndex;

        [NativeTypeName("DWORD")]
        public uint Flags;
    }
}
