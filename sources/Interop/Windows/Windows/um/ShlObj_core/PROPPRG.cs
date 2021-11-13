// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe partial struct PROPPRG
    {
        [NativeTypeName("WORD")]
        public ushort flPrg;

        [NativeTypeName("WORD")]
        public ushort flPrgInit;

        [NativeTypeName("CHAR [30]")]
        public fixed sbyte achTitle[30];

        [NativeTypeName("CHAR [128]")]
        public fixed sbyte achCmdLine[128];

        [NativeTypeName("CHAR [64]")]
        public fixed sbyte achWorkDir[64];

        [NativeTypeName("WORD")]
        public ushort wHotKey;

        [NativeTypeName("CHAR [80]")]
        public fixed sbyte achIconFile[80];

        [NativeTypeName("WORD")]
        public ushort wIconIndex;

        [NativeTypeName("DWORD")]
        public uint dwEnhModeFlags;

        [NativeTypeName("DWORD")]
        public uint dwRealModeFlags;

        [NativeTypeName("CHAR [80]")]
        public fixed sbyte achOtherFile[80];

        [NativeTypeName("CHAR [260]")]
        public fixed sbyte achPIFFile[260];
    }
}
