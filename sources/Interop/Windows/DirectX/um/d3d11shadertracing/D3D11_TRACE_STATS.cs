// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11shadertracing.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.Versioning;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D11_TRACE_STATS.xml' path='doc/member[@name="D3D11_TRACE_STATS"]/*' />
[SupportedOSPlatform("windows6.2")]
public partial struct D3D11_TRACE_STATS
{
    /// <include file='D3D11_TRACE_STATS.xml' path='doc/member[@name="D3D11_TRACE_STATS.TraceDesc"]/*' />
    public D3D11_SHADER_TRACE_DESC TraceDesc;

    /// <include file='D3D11_TRACE_STATS.xml' path='doc/member[@name="D3D11_TRACE_STATS.NumInvocationsInStamp"]/*' />
    [NativeTypeName("UINT8")]
    public byte NumInvocationsInStamp;

    /// <include file='D3D11_TRACE_STATS.xml' path='doc/member[@name="D3D11_TRACE_STATS.TargetStampIndex"]/*' />
    [NativeTypeName("UINT8")]
    public byte TargetStampIndex;

    /// <include file='D3D11_TRACE_STATS.xml' path='doc/member[@name="D3D11_TRACE_STATS.NumTraceSteps"]/*' />
    public uint NumTraceSteps;

    /// <include file='D3D11_TRACE_STATS.xml' path='doc/member[@name="D3D11_TRACE_STATS.InputMask"]/*' />
    [NativeTypeName("D3D11_TRACE_COMPONENT_MASK[32]")]
    public _InputMask_e__FixedBuffer InputMask;

    /// <include file='D3D11_TRACE_STATS.xml' path='doc/member[@name="D3D11_TRACE_STATS.OutputMask"]/*' />
    [NativeTypeName("D3D11_TRACE_COMPONENT_MASK[32]")]
    public _OutputMask_e__FixedBuffer OutputMask;

    /// <include file='D3D11_TRACE_STATS.xml' path='doc/member[@name="D3D11_TRACE_STATS.NumTemps"]/*' />
    [NativeTypeName("UINT16")]
    public ushort NumTemps;

    /// <include file='D3D11_TRACE_STATS.xml' path='doc/member[@name="D3D11_TRACE_STATS.MaxIndexableTempIndex"]/*' />
    [NativeTypeName("UINT16")]
    public ushort MaxIndexableTempIndex;

    /// <include file='D3D11_TRACE_STATS.xml' path='doc/member[@name="D3D11_TRACE_STATS.IndexableTempSize"]/*' />
    [NativeTypeName("UINT16[4096]")]
    public _IndexableTempSize_e__FixedBuffer IndexableTempSize;

    /// <include file='D3D11_TRACE_STATS.xml' path='doc/member[@name="D3D11_TRACE_STATS.ImmediateConstantBufferSize"]/*' />
    [NativeTypeName("UINT16")]
    public ushort ImmediateConstantBufferSize;

    /// <include file='D3D11_TRACE_STATS.xml' path='doc/member[@name="D3D11_TRACE_STATS.PixelPosition"]/*' />
    [NativeTypeName("UINT[4][2]")]
    public _PixelPosition_e__FixedBuffer PixelPosition;

    /// <include file='D3D11_TRACE_STATS.xml' path='doc/member[@name="D3D11_TRACE_STATS.PixelCoverageMask"]/*' />
    [NativeTypeName("UINT64[4]")]
    public _PixelCoverageMask_e__FixedBuffer PixelCoverageMask;

    /// <include file='D3D11_TRACE_STATS.xml' path='doc/member[@name="D3D11_TRACE_STATS.PixelDiscardedMask"]/*' />
    [NativeTypeName("UINT64[4]")]
    public _PixelDiscardedMask_e__FixedBuffer PixelDiscardedMask;

    /// <include file='D3D11_TRACE_STATS.xml' path='doc/member[@name="D3D11_TRACE_STATS.PixelCoverageMaskAfterShader"]/*' />
    [NativeTypeName("UINT64[4]")]
    public _PixelCoverageMaskAfterShader_e__FixedBuffer PixelCoverageMaskAfterShader;

    /// <include file='D3D11_TRACE_STATS.xml' path='doc/member[@name="D3D11_TRACE_STATS.PixelCoverageMaskAfterA2CSampleMask"]/*' />
    [NativeTypeName("UINT64[4]")]
    public _PixelCoverageMaskAfterA2CSampleMask_e__FixedBuffer PixelCoverageMaskAfterA2CSampleMask;

    /// <include file='D3D11_TRACE_STATS.xml' path='doc/member[@name="D3D11_TRACE_STATS.PixelCoverageMaskAfterA2CSampleMaskDepth"]/*' />
    [NativeTypeName("UINT64[4]")]
    public _PixelCoverageMaskAfterA2CSampleMaskDepth_e__FixedBuffer PixelCoverageMaskAfterA2CSampleMaskDepth;

    /// <include file='D3D11_TRACE_STATS.xml' path='doc/member[@name="D3D11_TRACE_STATS.PixelCoverageMaskAfterA2CSampleMaskDepthStencil"]/*' />
    [NativeTypeName("UINT64[4]")]
    public _PixelCoverageMaskAfterA2CSampleMaskDepthStencil_e__FixedBuffer PixelCoverageMaskAfterA2CSampleMaskDepthStencil;

    /// <include file='D3D11_TRACE_STATS.xml' path='doc/member[@name="D3D11_TRACE_STATS.PSOutputsDepth"]/*' />
    public BOOL PSOutputsDepth;

    /// <include file='D3D11_TRACE_STATS.xml' path='doc/member[@name="D3D11_TRACE_STATS.PSOutputsMask"]/*' />
    public BOOL PSOutputsMask;

    /// <include file='D3D11_TRACE_STATS.xml' path='doc/member[@name="D3D11_TRACE_STATS.GSInputPrimitive"]/*' />
    public D3D11_TRACE_GS_INPUT_PRIMITIVE GSInputPrimitive;

    /// <include file='D3D11_TRACE_STATS.xml' path='doc/member[@name="D3D11_TRACE_STATS.GSInputsPrimitiveID"]/*' />
    public BOOL GSInputsPrimitiveID;

    /// <include file='D3D11_TRACE_STATS.xml' path='doc/member[@name="D3D11_TRACE_STATS.HSOutputPatchConstantMask"]/*' />
    [NativeTypeName("D3D11_TRACE_COMPONENT_MASK[32]")]
    public _HSOutputPatchConstantMask_e__FixedBuffer HSOutputPatchConstantMask;

    /// <include file='D3D11_TRACE_STATS.xml' path='doc/member[@name="D3D11_TRACE_STATS.DSInputPatchConstantMask"]/*' />
    [NativeTypeName("D3D11_TRACE_COMPONENT_MASK[32]")]
    public _DSInputPatchConstantMask_e__FixedBuffer DSInputPatchConstantMask;

    /// <include file='_InputMask_e__FixedBuffer.xml' path='doc/member[@name="_InputMask_e__FixedBuffer"]/*' />
    [InlineArray(32)]
    public partial struct _InputMask_e__FixedBuffer
    {
        public byte e0;
    }

    /// <include file='_OutputMask_e__FixedBuffer.xml' path='doc/member[@name="_OutputMask_e__FixedBuffer"]/*' />
    [InlineArray(32)]
    public partial struct _OutputMask_e__FixedBuffer
    {
        public byte e0;
    }

    /// <include file='_IndexableTempSize_e__FixedBuffer.xml' path='doc/member[@name="_IndexableTempSize_e__FixedBuffer"]/*' />
    [InlineArray(4096)]
    public partial struct _IndexableTempSize_e__FixedBuffer
    {
        public ushort e0;
    }

    /// <include file='_PixelPosition_e__FixedBuffer.xml' path='doc/member[@name="_PixelPosition_e__FixedBuffer"]/*' />
    [InlineArray(4 * 2)]
    public partial struct _PixelPosition_e__FixedBuffer
    {
        public uint e0_0;
    }

    /// <include file='_PixelCoverageMask_e__FixedBuffer.xml' path='doc/member[@name="_PixelCoverageMask_e__FixedBuffer"]/*' />
    [InlineArray(4)]
    public partial struct _PixelCoverageMask_e__FixedBuffer
    {
        public ulong e0;
    }

    /// <include file='_PixelDiscardedMask_e__FixedBuffer.xml' path='doc/member[@name="_PixelDiscardedMask_e__FixedBuffer"]/*' />
    [InlineArray(4)]
    public partial struct _PixelDiscardedMask_e__FixedBuffer
    {
        public ulong e0;
    }

    /// <include file='_PixelCoverageMaskAfterShader_e__FixedBuffer.xml' path='doc/member[@name="_PixelCoverageMaskAfterShader_e__FixedBuffer"]/*' />
    [InlineArray(4)]
    public partial struct _PixelCoverageMaskAfterShader_e__FixedBuffer
    {
        public ulong e0;
    }

    /// <include file='_PixelCoverageMaskAfterA2CSampleMask_e__FixedBuffer.xml' path='doc/member[@name="_PixelCoverageMaskAfterA2CSampleMask_e__FixedBuffer"]/*' />
    [InlineArray(4)]
    public partial struct _PixelCoverageMaskAfterA2CSampleMask_e__FixedBuffer
    {
        public ulong e0;
    }

    /// <include file='_PixelCoverageMaskAfterA2CSampleMaskDepth_e__FixedBuffer.xml' path='doc/member[@name="_PixelCoverageMaskAfterA2CSampleMaskDepth_e__FixedBuffer"]/*' />
    [InlineArray(4)]
    public partial struct _PixelCoverageMaskAfterA2CSampleMaskDepth_e__FixedBuffer
    {
        public ulong e0;
    }

    /// <include file='_PixelCoverageMaskAfterA2CSampleMaskDepthStencil_e__FixedBuffer.xml' path='doc/member[@name="_PixelCoverageMaskAfterA2CSampleMaskDepthStencil_e__FixedBuffer"]/*' />
    [InlineArray(4)]
    public partial struct _PixelCoverageMaskAfterA2CSampleMaskDepthStencil_e__FixedBuffer
    {
        public ulong e0;
    }

    /// <include file='_HSOutputPatchConstantMask_e__FixedBuffer.xml' path='doc/member[@name="_HSOutputPatchConstantMask_e__FixedBuffer"]/*' />
    [InlineArray(32)]
    public partial struct _HSOutputPatchConstantMask_e__FixedBuffer
    {
        public byte e0;
    }

    /// <include file='_DSInputPatchConstantMask_e__FixedBuffer.xml' path='doc/member[@name="_DSInputPatchConstantMask_e__FixedBuffer"]/*' />
    [InlineArray(32)]
    public partial struct _DSInputPatchConstantMask_e__FixedBuffer
    {
        public byte e0;
    }
}
