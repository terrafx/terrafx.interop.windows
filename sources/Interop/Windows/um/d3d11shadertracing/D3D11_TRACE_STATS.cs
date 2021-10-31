// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11shadertracing.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct D3D11_TRACE_STATS
    {
        public D3D11_SHADER_TRACE_DESC TraceDesc;

        [NativeTypeName("UINT8")]
        public byte NumInvocationsInStamp;

        [NativeTypeName("UINT8")]
        public byte TargetStampIndex;

        public uint NumTraceSteps;

        [NativeTypeName("D3D11_TRACE_COMPONENT_MASK [32]")]
        public fixed byte InputMask[32];

        [NativeTypeName("D3D11_TRACE_COMPONENT_MASK [32]")]
        public fixed byte OutputMask[32];

        [NativeTypeName("UINT16")]
        public ushort NumTemps;

        [NativeTypeName("UINT16")]
        public ushort MaxIndexableTempIndex;

        [NativeTypeName("UINT16 [4096]")]
        public fixed ushort IndexableTempSize[4096];

        [NativeTypeName("UINT16")]
        public ushort ImmediateConstantBufferSize;

        [NativeTypeName("UINT [4][2]")]
        public fixed uint PixelPosition[4 * 2];

        [NativeTypeName("UINT64 [4]")]
        public fixed ulong PixelCoverageMask[4];

        [NativeTypeName("UINT64 [4]")]
        public fixed ulong PixelDiscardedMask[4];

        [NativeTypeName("UINT64 [4]")]
        public fixed ulong PixelCoverageMaskAfterShader[4];

        [NativeTypeName("UINT64 [4]")]
        public fixed ulong PixelCoverageMaskAfterA2CSampleMask[4];

        [NativeTypeName("UINT64 [4]")]
        public fixed ulong PixelCoverageMaskAfterA2CSampleMaskDepth[4];

        [NativeTypeName("UINT64 [4]")]
        public fixed ulong PixelCoverageMaskAfterA2CSampleMaskDepthStencil[4];

        public BOOL PSOutputsDepth;

        public BOOL PSOutputsMask;

        public D3D11_TRACE_GS_INPUT_PRIMITIVE GSInputPrimitive;

        public BOOL GSInputsPrimitiveID;

        [NativeTypeName("D3D11_TRACE_COMPONENT_MASK [32]")]
        public fixed byte HSOutputPatchConstantMask[32];

        [NativeTypeName("D3D11_TRACE_COMPONENT_MASK [32]")]
        public fixed byte DSInputPatchConstantMask[32];
    }
}
