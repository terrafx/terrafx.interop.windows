// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct REQUEST_OPLOCK_OUTPUT_BUFFER
    {
        [NativeTypeName("WORD")]
        public ushort StructureVersion;

        [NativeTypeName("WORD")]
        public ushort StructureLength;

        [NativeTypeName("DWORD")]
        public uint OriginalOplockLevel;

        [NativeTypeName("DWORD")]
        public uint NewOplockLevel;

        [NativeTypeName("DWORD")]
        public uint Flags;

        [NativeTypeName("ACCESS_MASK")]
        public uint AccessMode;

        [NativeTypeName("WORD")]
        public ushort ShareMode;
    }
}
