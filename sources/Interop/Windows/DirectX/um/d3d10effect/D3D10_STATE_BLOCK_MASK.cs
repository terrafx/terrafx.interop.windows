// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d10effect.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D10_STATE_BLOCK_MASK.xml' path='doc/member[@name="D3D10_STATE_BLOCK_MASK"]/*' />
public partial struct D3D10_STATE_BLOCK_MASK
{
    /// <include file='D3D10_STATE_BLOCK_MASK.xml' path='doc/member[@name="D3D10_STATE_BLOCK_MASK.VS"]/*' />
    public byte VS;

    /// <include file='D3D10_STATE_BLOCK_MASK.xml' path='doc/member[@name="D3D10_STATE_BLOCK_MASK.VSSamplers"]/*' />
    [NativeTypeName("BYTE[2]")]
    public _VSSamplers_e__FixedBuffer VSSamplers;

    /// <include file='D3D10_STATE_BLOCK_MASK.xml' path='doc/member[@name="D3D10_STATE_BLOCK_MASK.VSShaderResources"]/*' />
    [NativeTypeName("BYTE[16]")]
    public _VSShaderResources_e__FixedBuffer VSShaderResources;

    /// <include file='D3D10_STATE_BLOCK_MASK.xml' path='doc/member[@name="D3D10_STATE_BLOCK_MASK.VSConstantBuffers"]/*' />
    [NativeTypeName("BYTE[2]")]
    public _VSConstantBuffers_e__FixedBuffer VSConstantBuffers;

    /// <include file='D3D10_STATE_BLOCK_MASK.xml' path='doc/member[@name="D3D10_STATE_BLOCK_MASK.GS"]/*' />
    public byte GS;

    /// <include file='D3D10_STATE_BLOCK_MASK.xml' path='doc/member[@name="D3D10_STATE_BLOCK_MASK.GSSamplers"]/*' />
    [NativeTypeName("BYTE[2]")]
    public _GSSamplers_e__FixedBuffer GSSamplers;

    /// <include file='D3D10_STATE_BLOCK_MASK.xml' path='doc/member[@name="D3D10_STATE_BLOCK_MASK.GSShaderResources"]/*' />
    [NativeTypeName("BYTE[16]")]
    public _GSShaderResources_e__FixedBuffer GSShaderResources;

    /// <include file='D3D10_STATE_BLOCK_MASK.xml' path='doc/member[@name="D3D10_STATE_BLOCK_MASK.GSConstantBuffers"]/*' />
    [NativeTypeName("BYTE[2]")]
    public _GSConstantBuffers_e__FixedBuffer GSConstantBuffers;

    /// <include file='D3D10_STATE_BLOCK_MASK.xml' path='doc/member[@name="D3D10_STATE_BLOCK_MASK.PS"]/*' />
    public byte PS;

    /// <include file='D3D10_STATE_BLOCK_MASK.xml' path='doc/member[@name="D3D10_STATE_BLOCK_MASK.PSSamplers"]/*' />
    [NativeTypeName("BYTE[2]")]
    public _PSSamplers_e__FixedBuffer PSSamplers;

    /// <include file='D3D10_STATE_BLOCK_MASK.xml' path='doc/member[@name="D3D10_STATE_BLOCK_MASK.PSShaderResources"]/*' />
    [NativeTypeName("BYTE[16]")]
    public _PSShaderResources_e__FixedBuffer PSShaderResources;

    /// <include file='D3D10_STATE_BLOCK_MASK.xml' path='doc/member[@name="D3D10_STATE_BLOCK_MASK.PSConstantBuffers"]/*' />
    [NativeTypeName("BYTE[2]")]
    public _PSConstantBuffers_e__FixedBuffer PSConstantBuffers;

    /// <include file='D3D10_STATE_BLOCK_MASK.xml' path='doc/member[@name="D3D10_STATE_BLOCK_MASK.IAVertexBuffers"]/*' />
    [NativeTypeName("BYTE[2]")]
    public _IAVertexBuffers_e__FixedBuffer IAVertexBuffers;

    /// <include file='D3D10_STATE_BLOCK_MASK.xml' path='doc/member[@name="D3D10_STATE_BLOCK_MASK.IAIndexBuffer"]/*' />
    public byte IAIndexBuffer;

    /// <include file='D3D10_STATE_BLOCK_MASK.xml' path='doc/member[@name="D3D10_STATE_BLOCK_MASK.IAInputLayout"]/*' />
    public byte IAInputLayout;

    /// <include file='D3D10_STATE_BLOCK_MASK.xml' path='doc/member[@name="D3D10_STATE_BLOCK_MASK.IAPrimitiveTopology"]/*' />
    public byte IAPrimitiveTopology;

    /// <include file='D3D10_STATE_BLOCK_MASK.xml' path='doc/member[@name="D3D10_STATE_BLOCK_MASK.OMRenderTargets"]/*' />
    public byte OMRenderTargets;

    /// <include file='D3D10_STATE_BLOCK_MASK.xml' path='doc/member[@name="D3D10_STATE_BLOCK_MASK.OMDepthStencilState"]/*' />
    public byte OMDepthStencilState;

    /// <include file='D3D10_STATE_BLOCK_MASK.xml' path='doc/member[@name="D3D10_STATE_BLOCK_MASK.OMBlendState"]/*' />
    public byte OMBlendState;

    /// <include file='D3D10_STATE_BLOCK_MASK.xml' path='doc/member[@name="D3D10_STATE_BLOCK_MASK.RSViewports"]/*' />
    public byte RSViewports;

    /// <include file='D3D10_STATE_BLOCK_MASK.xml' path='doc/member[@name="D3D10_STATE_BLOCK_MASK.RSScissorRects"]/*' />
    public byte RSScissorRects;

    /// <include file='D3D10_STATE_BLOCK_MASK.xml' path='doc/member[@name="D3D10_STATE_BLOCK_MASK.RSRasterizerState"]/*' />
    public byte RSRasterizerState;

    /// <include file='D3D10_STATE_BLOCK_MASK.xml' path='doc/member[@name="D3D10_STATE_BLOCK_MASK.SOBuffers"]/*' />
    public byte SOBuffers;

    /// <include file='D3D10_STATE_BLOCK_MASK.xml' path='doc/member[@name="D3D10_STATE_BLOCK_MASK.Predication"]/*' />
    public byte Predication;

    /// <include file='_VSSamplers_e__FixedBuffer.xml' path='doc/member[@name="_VSSamplers_e__FixedBuffer"]/*' />
    [InlineArray(2)]
    public partial struct _VSSamplers_e__FixedBuffer
    {
        public byte e0;
    }

    /// <include file='_VSShaderResources_e__FixedBuffer.xml' path='doc/member[@name="_VSShaderResources_e__FixedBuffer"]/*' />
    [InlineArray(16)]
    public partial struct _VSShaderResources_e__FixedBuffer
    {
        public byte e0;
    }

    /// <include file='_VSConstantBuffers_e__FixedBuffer.xml' path='doc/member[@name="_VSConstantBuffers_e__FixedBuffer"]/*' />
    [InlineArray(2)]
    public partial struct _VSConstantBuffers_e__FixedBuffer
    {
        public byte e0;
    }

    /// <include file='_GSSamplers_e__FixedBuffer.xml' path='doc/member[@name="_GSSamplers_e__FixedBuffer"]/*' />
    [InlineArray(2)]
    public partial struct _GSSamplers_e__FixedBuffer
    {
        public byte e0;
    }

    /// <include file='_GSShaderResources_e__FixedBuffer.xml' path='doc/member[@name="_GSShaderResources_e__FixedBuffer"]/*' />
    [InlineArray(16)]
    public partial struct _GSShaderResources_e__FixedBuffer
    {
        public byte e0;
    }

    /// <include file='_GSConstantBuffers_e__FixedBuffer.xml' path='doc/member[@name="_GSConstantBuffers_e__FixedBuffer"]/*' />
    [InlineArray(2)]
    public partial struct _GSConstantBuffers_e__FixedBuffer
    {
        public byte e0;
    }

    /// <include file='_PSSamplers_e__FixedBuffer.xml' path='doc/member[@name="_PSSamplers_e__FixedBuffer"]/*' />
    [InlineArray(2)]
    public partial struct _PSSamplers_e__FixedBuffer
    {
        public byte e0;
    }

    /// <include file='_PSShaderResources_e__FixedBuffer.xml' path='doc/member[@name="_PSShaderResources_e__FixedBuffer"]/*' />
    [InlineArray(16)]
    public partial struct _PSShaderResources_e__FixedBuffer
    {
        public byte e0;
    }

    /// <include file='_PSConstantBuffers_e__FixedBuffer.xml' path='doc/member[@name="_PSConstantBuffers_e__FixedBuffer"]/*' />
    [InlineArray(2)]
    public partial struct _PSConstantBuffers_e__FixedBuffer
    {
        public byte e0;
    }

    /// <include file='_IAVertexBuffers_e__FixedBuffer.xml' path='doc/member[@name="_IAVertexBuffers_e__FixedBuffer"]/*' />
    [InlineArray(2)]
    public partial struct _IAVertexBuffers_e__FixedBuffer
    {
        public byte e0;
    }
}
