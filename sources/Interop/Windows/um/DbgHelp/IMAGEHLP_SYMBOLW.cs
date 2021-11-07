// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DbgHelp.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct IMAGEHLP_SYMBOLW
    {
        [NativeTypeName("DWORD")]
        public uint SizeOfStruct;

        [NativeTypeName("DWORD")]
        public uint Address;

        [NativeTypeName("DWORD")]
        public uint Size;

        [NativeTypeName("DWORD")]
        public uint Flags;

        [NativeTypeName("DWORD")]
        public uint MaxNameLength;

        [NativeTypeName("WCHAR [1]")]
        public fixed ushort Name[1];
    }
}
