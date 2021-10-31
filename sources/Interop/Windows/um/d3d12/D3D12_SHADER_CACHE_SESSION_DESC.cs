// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public partial struct D3D12_SHADER_CACHE_SESSION_DESC
    {
        public Guid Identifier;

        public D3D12_SHADER_CACHE_MODE Mode;

        public D3D12_SHADER_CACHE_FLAGS Flags;

        public uint MaximumInMemoryCacheSizeBytes;

        public uint MaximumInMemoryCacheEntries;

        public uint MaximumValueFileSizeBytes;

        [NativeTypeName("UINT64")]
        public ulong Version;
    }
}
