// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public unsafe partial struct FILE_NOTIFY_INFORMATION
    {
        [NativeTypeName("DWORD")]
        public uint NextEntryOffset;

        [NativeTypeName("DWORD")]
        public uint Action;

        [NativeTypeName("DWORD")]
        public uint FileNameLength;

        [NativeTypeName("WCHAR [1]")]
        public fixed ushort FileName[1];
    }
}
