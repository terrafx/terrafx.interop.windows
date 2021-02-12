// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d10effect.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [NativeTypeName("const GUID")]
        public static readonly Guid IID_ID3D10StateBlock = new Guid(0x803425a, 0x57f5, 0x4dd6, 0x94, 0x65, 0xa8, 0x75, 0x70, 0x83, 0x4a, 0x8);

        [DllImport("d3d10", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3D10StateBlockMaskUnion([NativeTypeName("D3D10_STATE_BLOCK_MASK *")] D3D10_STATE_BLOCK_MASK* pA, [NativeTypeName("D3D10_STATE_BLOCK_MASK *")] D3D10_STATE_BLOCK_MASK* pB, [NativeTypeName("D3D10_STATE_BLOCK_MASK *")] D3D10_STATE_BLOCK_MASK* pResult);

        [DllImport("d3d10", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3D10StateBlockMaskIntersect([NativeTypeName("D3D10_STATE_BLOCK_MASK *")] D3D10_STATE_BLOCK_MASK* pA, [NativeTypeName("D3D10_STATE_BLOCK_MASK *")] D3D10_STATE_BLOCK_MASK* pB, [NativeTypeName("D3D10_STATE_BLOCK_MASK *")] D3D10_STATE_BLOCK_MASK* pResult);

        [DllImport("d3d10", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3D10StateBlockMaskDifference([NativeTypeName("D3D10_STATE_BLOCK_MASK *")] D3D10_STATE_BLOCK_MASK* pA, [NativeTypeName("D3D10_STATE_BLOCK_MASK *")] D3D10_STATE_BLOCK_MASK* pB, [NativeTypeName("D3D10_STATE_BLOCK_MASK *")] D3D10_STATE_BLOCK_MASK* pResult);

        [DllImport("d3d10", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3D10StateBlockMaskEnableCapture([NativeTypeName("D3D10_STATE_BLOCK_MASK *")] D3D10_STATE_BLOCK_MASK* pMask, D3D10_DEVICE_STATE_TYPES StateType, [NativeTypeName("UINT")] uint RangeStart, [NativeTypeName("UINT")] uint RangeLength);

        [DllImport("d3d10", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3D10StateBlockMaskDisableCapture([NativeTypeName("D3D10_STATE_BLOCK_MASK *")] D3D10_STATE_BLOCK_MASK* pMask, D3D10_DEVICE_STATE_TYPES StateType, [NativeTypeName("UINT")] uint RangeStart, [NativeTypeName("UINT")] uint RangeLength);

        [DllImport("d3d10", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3D10StateBlockMaskEnableAll([NativeTypeName("D3D10_STATE_BLOCK_MASK *")] D3D10_STATE_BLOCK_MASK* pMask);

        [DllImport("d3d10", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3D10StateBlockMaskDisableAll([NativeTypeName("D3D10_STATE_BLOCK_MASK *")] D3D10_STATE_BLOCK_MASK* pMask);

        [DllImport("d3d10", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int D3D10StateBlockMaskGetSetting([NativeTypeName("D3D10_STATE_BLOCK_MASK *")] D3D10_STATE_BLOCK_MASK* pMask, D3D10_DEVICE_STATE_TYPES StateType, [NativeTypeName("UINT")] uint Entry);

        [DllImport("d3d10", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3D10CreateStateBlock([NativeTypeName("ID3D10Device *")] ID3D10Device* pDevice, [NativeTypeName("D3D10_STATE_BLOCK_MASK *")] D3D10_STATE_BLOCK_MASK* pStateBlockMask, [NativeTypeName("ID3D10StateBlock **")] ID3D10StateBlock** ppStateBlock);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_ID3D10EffectType = new Guid(0x4e9e1ddc, 0xcd9d, 0x4772, 0xa8, 0x37, 0x0, 0x18, 0xb, 0x9b, 0x88, 0xfd);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_ID3D10EffectVariable = new Guid(0xae897105, 0xe6, 0x45bf, 0xbb, 0x8e, 0x28, 0x1d, 0xd6, 0xdb, 0x8e, 0x1b);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_ID3D10EffectScalarVariable = new Guid(0xe48f7b, 0xd2c8, 0x49e8, 0xa8, 0x6c, 0x2, 0x2d, 0xee, 0x53, 0x43, 0x1f);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_ID3D10EffectVectorVariable = new Guid(0x62b98c44, 0x1f82, 0x4c67, 0xbc, 0xd0, 0x72, 0xcf, 0x8f, 0x21, 0x7e, 0x81);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_ID3D10EffectMatrixVariable = new Guid(0x50666c24, 0xb82f, 0x4eed, 0xa1, 0x72, 0x5b, 0x6e, 0x7e, 0x85, 0x22, 0xe0);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_ID3D10EffectStringVariable = new Guid(0x71417501, 0x8df9, 0x4e0a, 0xa7, 0x8a, 0x25, 0x5f, 0x97, 0x56, 0xba, 0xff);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_ID3D10EffectShaderResourceVariable = new Guid(0xc0a7157b, 0xd872, 0x4b1d, 0x80, 0x73, 0xef, 0xc2, 0xac, 0xd4, 0xb1, 0xfc);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_ID3D10EffectRenderTargetViewVariable = new Guid(0x28ca0cc3, 0xc2c9, 0x40bb, 0xb5, 0x7f, 0x67, 0xb7, 0x37, 0x12, 0x2b, 0x17);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_ID3D10EffectDepthStencilViewVariable = new Guid(0x3e02c918, 0xcc79, 0x4985, 0xb6, 0x22, 0x2d, 0x92, 0xad, 0x70, 0x16, 0x23);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_ID3D10EffectConstantBuffer = new Guid(0x56648f4d, 0xcc8b, 0x4444, 0xa5, 0xad, 0xb5, 0xa3, 0xd7, 0x6e, 0x91, 0xb3);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_ID3D10EffectShaderVariable = new Guid(0x80849279, 0xc799, 0x4797, 0x8c, 0x33, 0x4, 0x7, 0xa0, 0x7d, 0x9e, 0x6);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_ID3D10EffectBlendVariable = new Guid(0x1fcd2294, 0xdf6d, 0x4eae, 0x86, 0xb3, 0xe, 0x91, 0x60, 0xcf, 0xb0, 0x7b);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_ID3D10EffectDepthStencilVariable = new Guid(0xaf482368, 0x330a, 0x46a5, 0x9a, 0x5c, 0x1, 0xc7, 0x1a, 0xf2, 0x4c, 0x8d);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_ID3D10EffectRasterizerVariable = new Guid(0x21af9f0e, 0x4d94, 0x4ea9, 0x97, 0x85, 0x2c, 0xb7, 0x6b, 0x8c, 0xb, 0x34);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_ID3D10EffectSamplerVariable = new Guid(0x6530d5c7, 0x7e9, 0x4271, 0xa4, 0x18, 0xe7, 0xce, 0x4b, 0xd1, 0xe4, 0x80);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_ID3D10EffectPass = new Guid(0x5cfbeb89, 0x1a06, 0x46e0, 0xb2, 0x82, 0xe3, 0xf9, 0xbf, 0xa3, 0x6a, 0x54);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_ID3D10EffectTechnique = new Guid(0xdb122ce8, 0xd1c9, 0x4292, 0xb2, 0x37, 0x24, 0xed, 0x3d, 0xe8, 0xb1, 0x75);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_ID3D10Effect = new Guid(0x51b0ca8b, 0xec0b, 0x4519, 0x87, 0xd, 0x8e, 0xe1, 0xcb, 0x50, 0x17, 0xc7);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_ID3D10EffectPool = new Guid(0x9537ab04, 0x3250, 0x412e, 0x82, 0x13, 0xfc, 0xd2, 0xf8, 0x67, 0x79, 0x33);

        [DllImport("d3d10", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3D10CompileEffectFromMemory([NativeTypeName("void *")] void* pData, [NativeTypeName("SIZE_T")] nuint DataLength, [NativeTypeName("LPCSTR")] sbyte* pSrcFileName, [NativeTypeName("const D3D10_SHADER_MACRO *")] D3D_SHADER_MACRO* pDefines, [NativeTypeName("ID3D10Include *")] ID3DInclude* pInclude, [NativeTypeName("UINT")] uint HLSLFlags, [NativeTypeName("UINT")] uint FXFlags, [NativeTypeName("ID3D10Blob **")] ID3DBlob** ppCompiledEffect, [NativeTypeName("ID3D10Blob **")] ID3DBlob** ppErrors);

        [DllImport("d3d10", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3D10CreateEffectFromMemory([NativeTypeName("void *")] void* pData, [NativeTypeName("SIZE_T")] nuint DataLength, [NativeTypeName("UINT")] uint FXFlags, [NativeTypeName("ID3D10Device *")] ID3D10Device* pDevice, [NativeTypeName("ID3D10EffectPool *")] ID3D10EffectPool* pEffectPool, [NativeTypeName("ID3D10Effect **")] ID3D10Effect** ppEffect);

        [DllImport("d3d10", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3D10CreateEffectPoolFromMemory([NativeTypeName("void *")] void* pData, [NativeTypeName("SIZE_T")] nuint DataLength, [NativeTypeName("UINT")] uint FXFlags, [NativeTypeName("ID3D10Device *")] ID3D10Device* pDevice, [NativeTypeName("ID3D10EffectPool **")] ID3D10EffectPool** ppEffectPool);

        [DllImport("d3d10", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3D10DisassembleEffect([NativeTypeName("ID3D10Effect *")] ID3D10Effect* pEffect, [NativeTypeName("BOOL")] int EnableColorCode, [NativeTypeName("ID3D10Blob **")] ID3DBlob** ppDisassembly);

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
