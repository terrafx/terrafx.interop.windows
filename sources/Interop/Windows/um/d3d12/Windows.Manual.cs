// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using static TerraFX.Interop.D3D12_FILTER_REDUCTION_TYPE;
using static TerraFX.Interop.D3D12_FILTER_TYPE;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        public static readonly Guid D3D12ComputeOnlyDevices = new Guid(0x50F7AB08, 0x4B6D, 0x4E14, 0x89, 0xA5, 0x5D, 0x16, 0xCD, 0x27, 0x25, 0x94);

        public static uint D3D12_ENCODE_SHADER_4_COMPONENT_MAPPING(D3D12_SHADER_COMPONENT_MAPPING Src0, D3D12_SHADER_COMPONENT_MAPPING Src1, D3D12_SHADER_COMPONENT_MAPPING Src2, D3D12_SHADER_COMPONENT_MAPPING Src3)
        {
            return ((uint)Src0 & D3D12_SHADER_COMPONENT_MAPPING_MASK)
                | (((uint)Src1 & D3D12_SHADER_COMPONENT_MAPPING_MASK) << unchecked((int)D3D12_SHADER_COMPONENT_MAPPING_SHIFT))
                | (((uint)Src2 & D3D12_SHADER_COMPONENT_MAPPING_MASK) << (unchecked((int)D3D12_SHADER_COMPONENT_MAPPING_SHIFT) * 2))
                | (((uint)Src3 & D3D12_SHADER_COMPONENT_MAPPING_MASK) << (unchecked((int)D3D12_SHADER_COMPONENT_MAPPING_SHIFT) * 3))
                | D3D12_SHADER_COMPONENT_MAPPING_ALWAYS_SET_BIT_AVOIDING_ZEROMEM_MISTAKES;
        }

        public static D3D12_SHADER_COMPONENT_MAPPING D3D12_DECODE_SHADER_4_COMPONENT_MAPPING(int ComponentToExtract, uint Mapping) => (D3D12_SHADER_COMPONENT_MAPPING)((Mapping >> (unchecked((int)D3D12_SHADER_COMPONENT_MAPPING_SHIFT) * ComponentToExtract)) & D3D12_SHADER_COMPONENT_MAPPING_MASK);

        public static D3D12_FILTER D3D12_ENCODE_BASIC_FILTER(D3D12_FILTER_TYPE min, D3D12_FILTER_TYPE mag, D3D12_FILTER_TYPE mip, D3D12_FILTER_REDUCTION_TYPE reduction)
        {
            return (D3D12_FILTER)((((uint)min & D3D12_FILTER_TYPE_MASK) << unchecked((int)D3D12_MIN_FILTER_SHIFT))
                                | (((uint)mag & D3D12_FILTER_TYPE_MASK) << unchecked((int)D3D12_MAG_FILTER_SHIFT))
                                | (((uint)mip & D3D12_FILTER_TYPE_MASK) << unchecked((int)D3D12_MIP_FILTER_SHIFT))
                                | (((uint)reduction & D3D12_FILTER_REDUCTION_TYPE_MASK) << unchecked((int)D3D12_FILTER_REDUCTION_TYPE_SHIFT)));
        }

        public static D3D12_FILTER D3D12_ENCODE_ANISOTROPIC_FILTER(D3D12_FILTER_REDUCTION_TYPE reduction) => (D3D12_FILTER)(D3D12_ANISOTROPIC_FILTERING_BIT | (uint)D3D12_ENCODE_BASIC_FILTER(D3D12_FILTER_TYPE_LINEAR, D3D12_FILTER_TYPE_LINEAR, D3D12_FILTER_TYPE_LINEAR, reduction));

        public static D3D12_FILTER_TYPE D3D12_DECODE_MIN_FILTER(D3D12_FILTER D3D12Filter) => (D3D12_FILTER_TYPE)(((uint)D3D12Filter >> unchecked((int)D3D12_MIN_FILTER_SHIFT)) & D3D12_FILTER_TYPE_MASK);

        public static D3D12_FILTER_TYPE D3D12_DECODE_MAG_FILTER(D3D12_FILTER D3D12Filter) => (D3D12_FILTER_TYPE)(((uint)D3D12Filter >> unchecked((int)D3D12_MAG_FILTER_SHIFT)) & D3D12_FILTER_TYPE_MASK);

        public static D3D12_FILTER_TYPE D3D12_DECODE_MIP_FILTER(D3D12_FILTER D3D12Filter) => (D3D12_FILTER_TYPE)(((uint)D3D12Filter >> unchecked((int)D3D12_MIP_FILTER_SHIFT)) & D3D12_FILTER_TYPE_MASK);

        public static D3D12_FILTER_REDUCTION_TYPE D3D12_DECODE_FILTER_REDUCTION(D3D12_FILTER D3D12Filter) => (D3D12_FILTER_REDUCTION_TYPE)(((uint)D3D12Filter >> unchecked((int)D3D12_FILTER_REDUCTION_TYPE_SHIFT)) & D3D12_FILTER_REDUCTION_TYPE_MASK);

        public static bool D3D12_DECODE_IS_COMPARISON_FILTER(D3D12_FILTER D3D12Filter) => D3D12_DECODE_FILTER_REDUCTION(D3D12Filter) == D3D12_FILTER_REDUCTION_TYPE_COMPARISON;

        public static bool D3D12_DECODE_IS_ANISOTROPIC_FILTER(D3D12_FILTER D3D12Filter)
        {
            return (((uint)D3D12Filter & D3D12_ANISOTROPIC_FILTERING_BIT) != 0)
                && (D3D12_FILTER_TYPE_LINEAR == D3D12_DECODE_MIN_FILTER(D3D12Filter))
                && (D3D12_FILTER_TYPE_LINEAR == D3D12_DECODE_MAG_FILTER(D3D12Filter))
                && (D3D12_FILTER_TYPE_LINEAR == D3D12_DECODE_MIP_FILTER(D3D12Filter));
        }

        public static uint D3D12_MAKE_COARSE_SHADING_RATE(uint x, uint y) => (x << unchecked((int)D3D12_SHADING_RATE_X_AXIS_SHIFT)) | y;

        public static uint D3D12_GET_COARSE_SHADING_RATE_X_AXIS(uint x) => (x >> unchecked((int)D3D12_SHADING_RATE_X_AXIS_SHIFT)) & D3D12_SHADING_RATE_VALID_MASK;

        public static uint D3D12_GET_COARSE_SHADING_RATE_Y_AXIS(uint y) => y & D3D12_SHADING_RATE_VALID_MASK;

        public static int D3D12ReflectLibrary(void* pSrcData, nuint SrcDataSize, ID3D12LibraryReflection** ppReflector)
        {
            var iid = IID_ID3D12LibraryReflection;
            return D3DReflectLibrary(pSrcData, SrcDataSize, &iid, (void**)ppReflector);
        }

        public static int D3D_SET_OBJECT_NAME_N_A(ID3D12Object* pObject, uint Chars, sbyte* pName)
        {
            var guid = WKPDID_D3DDebugObjectName;
            return pObject->SetPrivateData(&guid, Chars, pName);
        }

        public static int D3D_SET_OBJECT_NAME_A(ID3D12Object* pObject, sbyte* pName)
        {
            return D3D_SET_OBJECT_NAME_N_A(pObject, (uint)lstrlenA(pName), pName);
        }

        public static int D3D_SET_OBJECT_NAME_N_W(ID3D12Object* pObject, uint Chars, ushort* pName)
        {
            var guid = WKPDID_D3DDebugObjectNameW;
            return pObject->SetPrivateData(&guid, Chars * 2, pName);
        }

        public static int D3D_SET_OBJECT_NAME_W(ID3D12Object* pObject, ushort* pName)
        {
            return D3D_SET_OBJECT_NAME_N_W(pObject, (uint)lstrlenW(pName), pName);
        }
    }
}
