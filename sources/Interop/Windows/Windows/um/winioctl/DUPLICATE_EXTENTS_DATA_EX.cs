// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public partial struct DUPLICATE_EXTENTS_DATA_EX
    {
        [NativeTypeName("SIZE_T")]
        public nuint Size;

        public HANDLE FileHandle;

        public LARGE_INTEGER SourceFileOffset;

        public LARGE_INTEGER TargetFileOffset;

        public LARGE_INTEGER ByteCount;

        [NativeTypeName("DWORD")]
        public uint Flags;
    }
}
