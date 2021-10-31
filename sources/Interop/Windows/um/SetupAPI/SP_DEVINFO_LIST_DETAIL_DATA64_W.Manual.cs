// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct SP_DEVINFO_LIST_DETAIL_DATA64_W
    {
        [NativeTypeName("DWORD")]
        public uint cbSize;

        [NativeTypeName("GUID")]
        public Guid ClassGuid;

        public HANDLE RemoteMachineHandle;

        [NativeTypeName("WCHAR [263]")]
        public fixed ushort RemoteMachineName[263];
    }
}
