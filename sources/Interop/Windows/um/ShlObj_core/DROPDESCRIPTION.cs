// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe partial struct DROPDESCRIPTION
    {
        public DROPIMAGETYPE type;

        [NativeTypeName("WCHAR [260]")]
        public fixed ushort szMessage[260];

        [NativeTypeName("WCHAR [260]")]
        public fixed ushort szInsert[260];
    }
}
