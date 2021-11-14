// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe partial struct FILE_ATTRIBUTES_ARRAY
    {
        public uint cItems;

        [NativeTypeName("DWORD")]
        public uint dwSumFileAttributes;

        [NativeTypeName("DWORD")]
        public uint dwProductFileAttributes;

        [NativeTypeName("DWORD [1]")]
        public fixed uint rgdwFileAttributes[1];
    }
}
