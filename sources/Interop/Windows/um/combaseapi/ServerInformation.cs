// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/combaseapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct ServerInformation
    {
        [NativeTypeName("DWORD")]
        public uint dwServerPid;

        [NativeTypeName("DWORD")]
        public uint dwServerTid;

        [NativeTypeName("UINT64")]
        public ulong ui64ServerAddress;
    }
}
