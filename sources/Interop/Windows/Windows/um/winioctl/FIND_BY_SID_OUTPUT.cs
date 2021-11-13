// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public unsafe partial struct FIND_BY_SID_OUTPUT
    {
        [NativeTypeName("DWORD")]
        public uint NextEntryOffset;

        [NativeTypeName("DWORD")]
        public uint FileIndex;

        [NativeTypeName("DWORD")]
        public uint FileNameLength;

        [NativeTypeName("WCHAR [1]")]
        public fixed ushort FileName[1];
    }
}
