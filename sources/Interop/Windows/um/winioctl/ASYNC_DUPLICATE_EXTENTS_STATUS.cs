// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct ASYNC_DUPLICATE_EXTENTS_STATUS
    {
        [NativeTypeName("DWORD")]
        public uint Version;

        public DUPLICATE_EXTENTS_STATE State;

        [NativeTypeName("DWORDLONG")]
        public ulong SourceFileOffset;

        [NativeTypeName("DWORDLONG")]
        public ulong TargetFileOffset;

        [NativeTypeName("DWORDLONG")]
        public ulong ByteCount;

        [NativeTypeName("DWORDLONG")]
        public ulong BytesDuplicated;
    }
}
