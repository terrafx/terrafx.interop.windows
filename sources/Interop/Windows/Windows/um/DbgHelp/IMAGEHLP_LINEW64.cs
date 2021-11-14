// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DbgHelp.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public unsafe partial struct IMAGEHLP_LINEW64
    {
        [NativeTypeName("DWORD")]
        public uint SizeOfStruct;

        [NativeTypeName("PVOID")]
        public void* Key;

        [NativeTypeName("DWORD")]
        public uint LineNumber;

        [NativeTypeName("PWSTR")]
        public ushort* FileName;

        [NativeTypeName("DWORD64")]
        public ulong Address;
    }
}
