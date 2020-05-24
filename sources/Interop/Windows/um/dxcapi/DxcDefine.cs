// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from DirectXShaderCompiler, include/dxc/dxcapi.h, at commit d356a8bc546da38612cac13d1e643de17a0ba38f
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct DxcDefine
    {
        [NativeTypeName("LPCWSTR")]
        public ushort* Name;

        [NativeTypeName("LPCWSTR")]
        public ushort* Value;
    }
}
