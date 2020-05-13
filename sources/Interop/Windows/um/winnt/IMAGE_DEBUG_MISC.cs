// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct IMAGE_DEBUG_MISC
    {
        [NativeTypeName("DWORD")]
        public uint DataType;

        [NativeTypeName("DWORD")]
        public uint Length;

        [NativeTypeName("BOOLEAN")]
        public byte Unicode;

        [NativeTypeName("BYTE [3]")]
        public fixed byte Reserved[3];

        [NativeTypeName("BYTE [1]")]
        public fixed byte Data[1];
    }
}
