// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DbgHelp.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.Windows
{
    public unsafe partial struct IMAGEHLP_MODULE64
    {
        [NativeTypeName("DWORD")]
        public uint SizeOfStruct;

        [NativeTypeName("DWORD64")]
        public ulong BaseOfImage;

        [NativeTypeName("DWORD")]
        public uint ImageSize;

        [NativeTypeName("DWORD")]
        public uint TimeDateStamp;

        [NativeTypeName("DWORD")]
        public uint CheckSum;

        [NativeTypeName("DWORD")]
        public uint NumSyms;

        public SYM_TYPE SymType;

        [NativeTypeName("CHAR [32]")]
        public fixed sbyte ModuleName[32];

        [NativeTypeName("CHAR [256]")]
        public fixed sbyte ImageName[256];

        [NativeTypeName("CHAR [256]")]
        public fixed sbyte LoadedImageName[256];

        [NativeTypeName("CHAR [256]")]
        public fixed sbyte LoadedPdbName[256];

        [NativeTypeName("DWORD")]
        public uint CVSig;

        [NativeTypeName("CHAR [780]")]
        public fixed sbyte CVData[780];

        [NativeTypeName("DWORD")]
        public uint PdbSig;

        public Guid PdbSig70;

        [NativeTypeName("DWORD")]
        public uint PdbAge;

        public BOOL PdbUnmatched;

        public BOOL DbgUnmatched;

        public BOOL LineNumbers;

        public BOOL GlobalSymbols;

        public BOOL TypeInfo;

        public BOOL SourceIndexed;

        public BOOL Publics;

        [NativeTypeName("DWORD")]
        public uint MachineType;

        [NativeTypeName("DWORD")]
        public uint Reserved;
    }
}
