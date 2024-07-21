// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d10_1shader.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D10_SHADER_DEBUG_OUTPUTREG_INFO.xml' path='doc/member[@name="D3D10_SHADER_DEBUG_OUTPUTREG_INFO"]/*' />
public partial struct D3D10_SHADER_DEBUG_OUTPUTREG_INFO
{
    /// <include file='D3D10_SHADER_DEBUG_OUTPUTREG_INFO.xml' path='doc/member[@name="D3D10_SHADER_DEBUG_OUTPUTREG_INFO.OutputRegisterSet"]/*' />
    public D3D10_SHADER_DEBUG_REGTYPE OutputRegisterSet;

    /// <include file='D3D10_SHADER_DEBUG_OUTPUTREG_INFO.xml' path='doc/member[@name="D3D10_SHADER_DEBUG_OUTPUTREG_INFO.OutputReg"]/*' />
    public uint OutputReg;

    /// <include file='D3D10_SHADER_DEBUG_OUTPUTREG_INFO.xml' path='doc/member[@name="D3D10_SHADER_DEBUG_OUTPUTREG_INFO.TempArrayReg"]/*' />
    public uint TempArrayReg;

    /// <include file='D3D10_SHADER_DEBUG_OUTPUTREG_INFO.xml' path='doc/member[@name="D3D10_SHADER_DEBUG_OUTPUTREG_INFO.OutputComponents"]/*' />
    [NativeTypeName("UINT[4]")]
    public _OutputComponents_e__FixedBuffer OutputComponents;

    /// <include file='D3D10_SHADER_DEBUG_OUTPUTREG_INFO.xml' path='doc/member[@name="D3D10_SHADER_DEBUG_OUTPUTREG_INFO.OutputVars"]/*' />
    [NativeTypeName("D3D10_SHADER_DEBUG_OUTPUTVAR[4]")]
    public _OutputVars_e__FixedBuffer OutputVars;

    /// <include file='D3D10_SHADER_DEBUG_OUTPUTREG_INFO.xml' path='doc/member[@name="D3D10_SHADER_DEBUG_OUTPUTREG_INFO.IndexReg"]/*' />
    public uint IndexReg;

    /// <include file='D3D10_SHADER_DEBUG_OUTPUTREG_INFO.xml' path='doc/member[@name="D3D10_SHADER_DEBUG_OUTPUTREG_INFO.IndexComp"]/*' />
    public uint IndexComp;

    /// <include file='_OutputComponents_e__FixedBuffer.xml' path='doc/member[@name="_OutputComponents_e__FixedBuffer"]/*' />
    [InlineArray(4)]
    public partial struct _OutputComponents_e__FixedBuffer
    {
        public uint e0;
    }

    /// <include file='_OutputVars_e__FixedBuffer.xml' path='doc/member[@name="_OutputVars_e__FixedBuffer"]/*' />
    [InlineArray(4)]
    public partial struct _OutputVars_e__FixedBuffer
    {
        public D3D10_SHADER_DEBUG_OUTPUTVAR e0;
    }
}
