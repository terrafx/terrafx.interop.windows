// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct SCM_LOGICAL_DEVICE_INSTANCE
    {
        [NativeTypeName("DWORD")]
        public uint Version;

        [NativeTypeName("DWORD")]
        public uint Size;

        [NativeTypeName("GUID")]
        public Guid DeviceGuid;

        [NativeTypeName("WCHAR [256]")]
        public fixed ushort SymbolicLink[256];
    }
}
