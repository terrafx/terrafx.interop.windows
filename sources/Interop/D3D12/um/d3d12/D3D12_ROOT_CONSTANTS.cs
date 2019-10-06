// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d3d12.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct D3D12_ROOT_CONSTANTS
    {
        [NativeTypeName("UINT")]
        public uint ShaderRegister;

        [NativeTypeName("UINT")]
        public uint RegisterSpace;

        [NativeTypeName("UINT")]
        public uint Num32BitValues;

        public D3D12_ROOT_CONSTANTS(uint num32BitValues, uint shaderRegister, uint registerSpace = 0)
        {
            fixed (D3D12_ROOT_CONSTANTS* pThis = &this)
            {
                Init(pThis, num32BitValues, shaderRegister, registerSpace);
            }
        }

        public static void Init(D3D12_ROOT_CONSTANTS* rootConstants, uint num32BitValues, uint shaderRegister, uint registerSpace = 0)
        {
            rootConstants->Num32BitValues = num32BitValues;
            rootConstants->ShaderRegister = shaderRegister;
            rootConstants->RegisterSpace = registerSpace;
        }

        public void Init(uint num32BitValues, uint shaderRegister, uint registerSpace = 0)
        {
            fixed (D3D12_ROOT_CONSTANTS* pThis = &this)
            {
                Init(pThis, num32BitValues, shaderRegister, registerSpace);
            }
        }
    }
}
