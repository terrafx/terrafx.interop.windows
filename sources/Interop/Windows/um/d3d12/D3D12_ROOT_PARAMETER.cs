// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d3d12.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;
using static TerraFX.Interop.D3D12_ROOT_PARAMETER_TYPE;
using static TerraFX.Interop.D3D12_SHADER_VISIBILITY;

namespace TerraFX.Interop
{
    public unsafe struct D3D12_ROOT_PARAMETER
    {
        #region Fields
        public D3D12_ROOT_PARAMETER_TYPE ParameterType;

        public _Anonymous_e__Union Anonymous;

        public D3D12_SHADER_VISIBILITY ShaderVisibility;
        #endregion

        #region Methods
        public static void InitAsDescriptorTable(D3D12_ROOT_PARAMETER* rootParam, uint numDescriptorRanges, D3D12_DESCRIPTOR_RANGE* pDescriptorRanges, D3D12_SHADER_VISIBILITY visibility = D3D12_SHADER_VISIBILITY_ALL)
        {
            rootParam->ParameterType = D3D12_ROOT_PARAMETER_TYPE_DESCRIPTOR_TABLE;
            rootParam->ShaderVisibility = visibility;
            D3D12_ROOT_DESCRIPTOR_TABLE.Init(&rootParam->Anonymous.DescriptorTable, numDescriptorRanges, pDescriptorRanges);
        }

        public static void InitAsConstants(D3D12_ROOT_PARAMETER* rootParam, uint num32BitValues, uint shaderRegister, uint registerSpace = 0, D3D12_SHADER_VISIBILITY visibility = D3D12_SHADER_VISIBILITY_ALL)
        {
            rootParam->ParameterType = D3D12_ROOT_PARAMETER_TYPE_32BIT_CONSTANTS;
            rootParam->ShaderVisibility = visibility;
            D3D12_ROOT_CONSTANTS.Init(&rootParam->Anonymous.Constants, num32BitValues, shaderRegister, registerSpace);
        }

        public static void InitAsConstantBufferView(D3D12_ROOT_PARAMETER* rootParam, uint shaderRegister, uint registerSpace = 0, D3D12_SHADER_VISIBILITY visibility = D3D12_SHADER_VISIBILITY_ALL)
        {
            rootParam->ParameterType = D3D12_ROOT_PARAMETER_TYPE_CBV;
            rootParam->ShaderVisibility = visibility;
            D3D12_ROOT_DESCRIPTOR.Init(&rootParam->Anonymous.Descriptor, shaderRegister, registerSpace);
        }

        public static void InitAsShaderResourceView(D3D12_ROOT_PARAMETER* rootParam, uint shaderRegister, uint registerSpace = 0, D3D12_SHADER_VISIBILITY visibility = D3D12_SHADER_VISIBILITY_ALL)
        {
            rootParam->ParameterType = D3D12_ROOT_PARAMETER_TYPE_SRV;
            rootParam->ShaderVisibility = visibility;
            D3D12_ROOT_DESCRIPTOR.Init(&rootParam->Anonymous.Descriptor, shaderRegister, registerSpace);
        }

        public static void InitAsUnorderedAccessView(D3D12_ROOT_PARAMETER* rootParam, uint shaderRegister, uint registerSpace = 0, D3D12_SHADER_VISIBILITY visibility = D3D12_SHADER_VISIBILITY_ALL)
        {
            rootParam->ParameterType = D3D12_ROOT_PARAMETER_TYPE_UAV;
            rootParam->ShaderVisibility = visibility;
            D3D12_ROOT_DESCRIPTOR.Init(&rootParam->Anonymous.Descriptor, shaderRegister, registerSpace);
        }

        public void InitAsDescriptorTable(uint numDescriptorRanges, D3D12_DESCRIPTOR_RANGE* pDescriptorRanges, D3D12_SHADER_VISIBILITY visibility = D3D12_SHADER_VISIBILITY_ALL)
        {
            fixed (D3D12_ROOT_PARAMETER* pThis = &this)
            {
                InitAsDescriptorTable(pThis, numDescriptorRanges, pDescriptorRanges, visibility);
            }
        }
    
        public void InitAsConstants(uint num32BitValues, uint shaderRegister, uint registerSpace = 0, D3D12_SHADER_VISIBILITY visibility = D3D12_SHADER_VISIBILITY_ALL)
        {
            fixed (D3D12_ROOT_PARAMETER* pThis = &this)
            {
                InitAsConstants(pThis, num32BitValues, shaderRegister, registerSpace, visibility);
            }
        }

        public void InitAsConstantBufferView(uint shaderRegister, uint registerSpace = 0, D3D12_SHADER_VISIBILITY visibility = D3D12_SHADER_VISIBILITY_ALL)
        {
            fixed (D3D12_ROOT_PARAMETER* pThis = &this)
            {
                InitAsConstantBufferView(pThis, shaderRegister, registerSpace, visibility);
            }
        }

        public void InitAsShaderResourceView(uint shaderRegister, uint registerSpace = 0, D3D12_SHADER_VISIBILITY visibility = D3D12_SHADER_VISIBILITY_ALL)
        {
            fixed (D3D12_ROOT_PARAMETER* pThis = &this)
            {
                InitAsShaderResourceView(pThis, shaderRegister, registerSpace, visibility);
            }
        }

        public void InitAsUnorderedAccessView(uint shaderRegister, uint registerSpace = 0, D3D12_SHADER_VISIBILITY visibility = D3D12_SHADER_VISIBILITY_ALL)
        {
            fixed (D3D12_ROOT_PARAMETER* pThis = &this)
            {
                InitAsUnorderedAccessView(pThis, shaderRegister, registerSpace, visibility);
            }
        }
        #endregion

        #region Structs
        [StructLayout(LayoutKind.Explicit)]
        public struct _Anonymous_e__Union
        {
            #region Fields
            [FieldOffset(0)]
            public D3D12_ROOT_DESCRIPTOR_TABLE DescriptorTable;

            [FieldOffset(0)]
            public D3D12_ROOT_CONSTANTS Constants;

            [FieldOffset(0)]
            public D3D12_ROOT_DESCRIPTOR Descriptor;
            #endregion
        }
        #endregion
    }
}
