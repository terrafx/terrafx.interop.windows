// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct SHUFFLE_FILE_DATA
    {
        [NativeTypeName("LONGLONG")]
        public long StartingOffset;

        [NativeTypeName("LONGLONG")]
        public long Length;

        [NativeTypeName("DWORD")]
        public uint Flags;
    }
}
