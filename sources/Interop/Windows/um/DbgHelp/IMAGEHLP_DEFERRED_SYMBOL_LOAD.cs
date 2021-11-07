// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DbgHelp.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct IMAGEHLP_DEFERRED_SYMBOL_LOAD
    {
        [NativeTypeName("DWORD")]
        public uint SizeOfStruct;

        [NativeTypeName("DWORD")]
        public uint BaseOfImage;

        [NativeTypeName("DWORD")]
        public uint CheckSum;

        [NativeTypeName("DWORD")]
        public uint TimeDateStamp;

        [NativeTypeName("CHAR [260]")]
        public fixed sbyte FileName[260];

        [NativeTypeName("BOOLEAN")]
        public byte Reparse;

        public HANDLE hFile;
    }
}
