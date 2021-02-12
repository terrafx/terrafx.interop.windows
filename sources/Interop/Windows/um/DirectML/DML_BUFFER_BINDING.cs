// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DirectML.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct DML_BUFFER_BINDING
    {
        [NativeTypeName("ID3D12Resource *")]
        public ID3D12Resource* Buffer;

        [NativeTypeName("UINT64")]
        public ulong Offset;

        [NativeTypeName("UINT64")]
        public ulong SizeInBytes;
    }
}
