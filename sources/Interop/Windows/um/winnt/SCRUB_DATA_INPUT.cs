// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct SCRUB_DATA_INPUT
    {
        [NativeTypeName("DWORD")]
        public uint Size;

        [NativeTypeName("DWORD")]
        public uint Flags;

        [NativeTypeName("DWORD")]
        public uint MaximumIos;

        [NativeTypeName("DWORD [4]")]
        public fixed uint ObjectId[4];

        [NativeTypeName("DWORD [25]")]
        public fixed uint Reserved[25];

        [NativeTypeName("BYTE [816]")]
        public fixed byte ResumeContext[816];
    }
}
