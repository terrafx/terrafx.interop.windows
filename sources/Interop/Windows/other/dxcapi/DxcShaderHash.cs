// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from dxcapi.h in the microsoft/DirectXCompiler commit 747ee519eb9b65f893bb891bc6d229dfe9687e6a
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the University of Illinois Open Source License.

namespace TerraFX.Interop
{
    public unsafe partial struct DxcShaderHash
    {
        [NativeTypeName("UINT32")]
        public uint Flags;

        [NativeTypeName("BYTE [16]")]
        public fixed byte HashDigest[16];
    }
}
