// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d10effect.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX
{
    public static unsafe partial class DirectX
    {
        [DllImport("d3d10", ExactSpelling = true)]
        public static extern HRESULT D3D10StateBlockMaskUnion(D3D10_STATE_BLOCK_MASK* pA, D3D10_STATE_BLOCK_MASK* pB, D3D10_STATE_BLOCK_MASK* pResult);

        [DllImport("d3d10", ExactSpelling = true)]
        public static extern HRESULT D3D10StateBlockMaskIntersect(D3D10_STATE_BLOCK_MASK* pA, D3D10_STATE_BLOCK_MASK* pB, D3D10_STATE_BLOCK_MASK* pResult);

        [DllImport("d3d10", ExactSpelling = true)]
        public static extern HRESULT D3D10StateBlockMaskDifference(D3D10_STATE_BLOCK_MASK* pA, D3D10_STATE_BLOCK_MASK* pB, D3D10_STATE_BLOCK_MASK* pResult);

        [DllImport("d3d10", ExactSpelling = true)]
        public static extern HRESULT D3D10StateBlockMaskEnableCapture(D3D10_STATE_BLOCK_MASK* pMask, D3D10_DEVICE_STATE_TYPES StateType, uint RangeStart, uint RangeLength);

        [DllImport("d3d10", ExactSpelling = true)]
        public static extern HRESULT D3D10StateBlockMaskDisableCapture(D3D10_STATE_BLOCK_MASK* pMask, D3D10_DEVICE_STATE_TYPES StateType, uint RangeStart, uint RangeLength);

        [DllImport("d3d10", ExactSpelling = true)]
        public static extern HRESULT D3D10StateBlockMaskEnableAll(D3D10_STATE_BLOCK_MASK* pMask);

        [DllImport("d3d10", ExactSpelling = true)]
        public static extern HRESULT D3D10StateBlockMaskDisableAll(D3D10_STATE_BLOCK_MASK* pMask);

        [DllImport("d3d10", ExactSpelling = true)]
        public static extern BOOL D3D10StateBlockMaskGetSetting(D3D10_STATE_BLOCK_MASK* pMask, D3D10_DEVICE_STATE_TYPES StateType, uint Entry);

        [DllImport("d3d10", ExactSpelling = true)]
        public static extern HRESULT D3D10CreateStateBlock(ID3D10Device* pDevice, D3D10_STATE_BLOCK_MASK* pStateBlockMask, ID3D10StateBlock** ppStateBlock);

        [DllImport("d3d10", ExactSpelling = true)]
        public static extern HRESULT D3D10CompileEffectFromMemory(void* pData, [NativeTypeName("SIZE_T")] nuint DataLength, [NativeTypeName("LPCSTR")] sbyte* pSrcFileName, [NativeTypeName("const D3D10_SHADER_MACRO *")] D3D_SHADER_MACRO* pDefines, [NativeTypeName("ID3D10Include *")] ID3DInclude* pInclude, uint HLSLFlags, uint FXFlags, [NativeTypeName("ID3D10Blob **")] ID3DBlob** ppCompiledEffect, [NativeTypeName("ID3D10Blob **")] ID3DBlob** ppErrors);

        [DllImport("d3d10", ExactSpelling = true)]
        public static extern HRESULT D3D10CreateEffectFromMemory(void* pData, [NativeTypeName("SIZE_T")] nuint DataLength, uint FXFlags, ID3D10Device* pDevice, ID3D10EffectPool* pEffectPool, ID3D10Effect** ppEffect);

        [DllImport("d3d10", ExactSpelling = true)]
        public static extern HRESULT D3D10CreateEffectPoolFromMemory(void* pData, [NativeTypeName("SIZE_T")] nuint DataLength, uint FXFlags, ID3D10Device* pDevice, ID3D10EffectPool** ppEffectPool);

        [DllImport("d3d10", ExactSpelling = true)]
        public static extern HRESULT D3D10DisassembleEffect(ID3D10Effect* pEffect, BOOL EnableColorCode, [NativeTypeName("ID3D10Blob **")] ID3DBlob** ppDisassembly);

        [NativeTypeName("#define D3D10_EFFECT_COMPILE_CHILD_EFFECT (1 << 0)")]
        public const int D3D10_EFFECT_COMPILE_CHILD_EFFECT = (1 << 0);

        [NativeTypeName("#define D3D10_EFFECT_COMPILE_ALLOW_SLOW_OPS (1 << 1)")]
        public const int D3D10_EFFECT_COMPILE_ALLOW_SLOW_OPS = (1 << 1);

        [NativeTypeName("#define D3D10_EFFECT_SINGLE_THREADED (1 << 3)")]
        public const int D3D10_EFFECT_SINGLE_THREADED = (1 << 3);

        [NativeTypeName("#define D3D10_EFFECT_VARIABLE_POOLED (1 << 0)")]
        public const int D3D10_EFFECT_VARIABLE_POOLED = (1 << 0);

        [NativeTypeName("#define D3D10_EFFECT_VARIABLE_ANNOTATION (1 << 1)")]
        public const int D3D10_EFFECT_VARIABLE_ANNOTATION = (1 << 1);

        [NativeTypeName("#define D3D10_EFFECT_VARIABLE_EXPLICIT_BIND_POINT (1 << 2)")]
        public const int D3D10_EFFECT_VARIABLE_EXPLICIT_BIND_POINT = (1 << 2);
    }
}
