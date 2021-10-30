// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct SOURCE_MEDIA64_W
    {
        [NativeTypeName("PCWSTR")]
        public ushort* Reserved;

        [NativeTypeName("PCWSTR")]
        public ushort* Tagfile;

        [NativeTypeName("PCWSTR")]
        public ushort* Description;

        [NativeTypeName("PCWSTR")]
        public ushort* SourcePath;

        [NativeTypeName("PCWSTR")]
        public ushort* SourceFile;

        [NativeTypeName("DWORD")]
        public uint Flags;
    }
}
