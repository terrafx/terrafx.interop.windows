// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct STORAGE_OFFLOAD_READ_OUTPUT
    {
        [NativeTypeName("DWORD")]
        public uint OffloadReadFlags;

        [NativeTypeName("DWORD")]
        public uint Reserved;

        [NativeTypeName("DWORDLONG")]
        public ulong LengthProtected;

        [NativeTypeName("DWORD")]
        public uint TokenLength;

        public STORAGE_OFFLOAD_TOKEN Token;
    }
}
