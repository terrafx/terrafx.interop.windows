// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OAIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct wireBRECORD
    {
        [NativeTypeName("ULONG")]
        public uint fFlags;

        [NativeTypeName("ULONG")]
        public uint clSize;

        [NativeTypeName("IRecordInfo *")]
        public IRecordInfo* pRecInfo;

        [NativeTypeName("byte *")]
        public byte* pRecord;
    }
}
