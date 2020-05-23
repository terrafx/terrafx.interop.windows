// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct D3D12_META_COMMAND_DESC
    {
        [NativeTypeName("GUID")]
        public Guid Id;

        [NativeTypeName("LPCWSTR")]
        public ushort* Name;

        public D3D12_GRAPHICS_STATES InitializationDirtyState;

        public D3D12_GRAPHICS_STATES ExecutionDirtyState;
    }
}
