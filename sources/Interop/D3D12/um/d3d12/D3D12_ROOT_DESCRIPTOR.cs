// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d3d12.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct D3D12_ROOT_DESCRIPTOR
    {
        [NativeTypeName("UINT")]
        public uint ShaderRegister;

        [NativeTypeName("UINT")]
        public uint RegisterSpace;

        public D3D12_ROOT_DESCRIPTOR(uint shaderRegister, uint registerSpace = 0)
        {
            fixed (D3D12_ROOT_DESCRIPTOR* pThis = &this)
            {
                Init(pThis, shaderRegister, registerSpace);
            }
        }

        public static void Init(D3D12_ROOT_DESCRIPTOR* table, uint shaderRegister, uint registerSpace = 0)
        {
            table->ShaderRegister = shaderRegister;
            table->RegisterSpace = registerSpace;
        }

        public void Init(uint shaderRegister, uint registerSpace = 0)
        {
            fixed (D3D12_ROOT_DESCRIPTOR* pThis = &this)
            {
                Init(pThis, shaderRegister, registerSpace);
            }
        }
    }
}
