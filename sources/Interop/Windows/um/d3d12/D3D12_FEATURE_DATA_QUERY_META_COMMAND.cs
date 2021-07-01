// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct D3D12_FEATURE_DATA_QUERY_META_COMMAND
    {
        [NativeTypeName("GUID")]
        public Guid CommandId;

        [NativeTypeName("UINT")]
        public uint NodeMask;

        [NativeTypeName("const void *")]
        public void* pQueryInputData;

        [NativeTypeName("SIZE_T")]
        public nuint QueryInputDataSizeInBytes;

        public void* pQueryOutputData;

        [NativeTypeName("SIZE_T")]
        public nuint QueryOutputDataSizeInBytes;
    }
}
