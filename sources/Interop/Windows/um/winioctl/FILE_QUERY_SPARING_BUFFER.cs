// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct FILE_QUERY_SPARING_BUFFER
    {
        [NativeTypeName("DWORD")]
        public uint SparingUnitBytes;

        [NativeTypeName("BOOLEAN")]
        public byte SoftwareSparing;

        [NativeTypeName("DWORD")]
        public uint TotalSpareBlocks;

        [NativeTypeName("DWORD")]
        public uint FreeSpareBlocks;
    }
}
