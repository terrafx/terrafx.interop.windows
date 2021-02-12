// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/dxc/dxcapi.h in the microsoft/DirectXCompiler commit e0cde072b09b51506c0460697b2695d6cccca59d
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the University of Illinois Open Source License.

namespace TerraFX.Interop
{
    public unsafe partial struct DxcBuffer
    {
        [NativeTypeName("LPCVOID")]
        public void* Ptr;

        [NativeTypeName("SIZE_T")]
        public nuint Size;

        [NativeTypeName("UINT")]
        public uint Encoding;
    }
}
