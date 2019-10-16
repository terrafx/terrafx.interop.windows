// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11shader.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct D3D11_FUNCTION_DESC
    {
        [NativeTypeName("UINT")]
        public uint Version;

        [NativeTypeName("LPCSTR")]
        public sbyte* Creator;

        [NativeTypeName("UINT")]
        public uint Flags;

        [NativeTypeName("UINT")]
        public uint ConstantBuffers;

        [NativeTypeName("UINT")]
        public uint BoundResources;

        [NativeTypeName("UINT")]
        public uint InstructionCount;

        [NativeTypeName("UINT")]
        public uint TempRegisterCount;

        [NativeTypeName("UINT")]
        public uint TempArrayCount;

        [NativeTypeName("UINT")]
        public uint DefCount;

        [NativeTypeName("UINT")]
        public uint DclCount;

        [NativeTypeName("UINT")]
        public uint TextureNormalInstructions;

        [NativeTypeName("UINT")]
        public uint TextureLoadInstructions;

        [NativeTypeName("UINT")]
        public uint TextureCompInstructions;

        [NativeTypeName("UINT")]
        public uint TextureBiasInstructions;

        [NativeTypeName("UINT")]
        public uint TextureGradientInstructions;

        [NativeTypeName("UINT")]
        public uint FloatInstructionCount;

        [NativeTypeName("UINT")]
        public uint IntInstructionCount;

        [NativeTypeName("UINT")]
        public uint UintInstructionCount;

        [NativeTypeName("UINT")]
        public uint StaticFlowControlCount;

        [NativeTypeName("UINT")]
        public uint DynamicFlowControlCount;

        [NativeTypeName("UINT")]
        public uint MacroInstructionCount;

        [NativeTypeName("UINT")]
        public uint ArrayInstructionCount;

        [NativeTypeName("UINT")]
        public uint MovInstructionCount;

        [NativeTypeName("UINT")]
        public uint MovcInstructionCount;

        [NativeTypeName("UINT")]
        public uint ConversionInstructionCount;

        [NativeTypeName("UINT")]
        public uint BitwiseInstructionCount;

        public D3D_FEATURE_LEVEL MinFeatureLevel;

        [NativeTypeName("UINT64")]
        public ulong RequiredFeatureFlags;

        [NativeTypeName("LPCSTR")]
        public sbyte* Name;

        [NativeTypeName("INT")]
        public int FunctionParameterCount;

        [NativeTypeName("BOOL")]
        public int HasReturn;

        [NativeTypeName("BOOL")]
        public int Has10Level9VertexShader;

        [NativeTypeName("BOOL")]
        public int Has10Level9PixelShader;
    }
}
