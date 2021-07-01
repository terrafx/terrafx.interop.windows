// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12shader.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct D3D12_SHADER_DESC
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
        public uint InputParameters;

        [NativeTypeName("UINT")]
        public uint OutputParameters;

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
        public uint CutInstructionCount;

        [NativeTypeName("UINT")]
        public uint EmitInstructionCount;

        public D3D_PRIMITIVE_TOPOLOGY GSOutputTopology;

        [NativeTypeName("UINT")]
        public uint GSMaxOutputVertexCount;

        public D3D_PRIMITIVE InputPrimitive;

        [NativeTypeName("UINT")]
        public uint PatchConstantParameters;

        [NativeTypeName("UINT")]
        public uint cGSInstanceCount;

        [NativeTypeName("UINT")]
        public uint cControlPoints;

        public D3D_TESSELLATOR_OUTPUT_PRIMITIVE HSOutputPrimitive;

        public D3D_TESSELLATOR_PARTITIONING HSPartitioning;

        public D3D_TESSELLATOR_DOMAIN TessellatorDomain;

        [NativeTypeName("UINT")]
        public uint cBarrierInstructions;

        [NativeTypeName("UINT")]
        public uint cInterlockedInstructions;

        [NativeTypeName("UINT")]
        public uint cTextureStoreInstructions;
    }
}
