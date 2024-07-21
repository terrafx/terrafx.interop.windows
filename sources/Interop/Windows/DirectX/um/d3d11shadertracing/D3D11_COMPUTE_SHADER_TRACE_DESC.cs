// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11shadertracing.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D11_COMPUTE_SHADER_TRACE_DESC.xml' path='doc/member[@name="D3D11_COMPUTE_SHADER_TRACE_DESC"]/*' />
[SupportedOSPlatform("windows6.2")]
public partial struct D3D11_COMPUTE_SHADER_TRACE_DESC
{
    /// <include file='D3D11_COMPUTE_SHADER_TRACE_DESC.xml' path='doc/member[@name="D3D11_COMPUTE_SHADER_TRACE_DESC.Invocation"]/*' />
    [NativeTypeName("UINT64")]
    public ulong Invocation;

    /// <include file='D3D11_COMPUTE_SHADER_TRACE_DESC.xml' path='doc/member[@name="D3D11_COMPUTE_SHADER_TRACE_DESC.ThreadIDInGroup"]/*' />
    [NativeTypeName("UINT[3]")]
    public _ThreadIDInGroup_e__FixedBuffer ThreadIDInGroup;

    /// <include file='D3D11_COMPUTE_SHADER_TRACE_DESC.xml' path='doc/member[@name="D3D11_COMPUTE_SHADER_TRACE_DESC.ThreadGroupID"]/*' />
    [NativeTypeName("UINT[3]")]
    public _ThreadGroupID_e__FixedBuffer ThreadGroupID;

    /// <include file='_ThreadIDInGroup_e__FixedBuffer.xml' path='doc/member[@name="_ThreadIDInGroup_e__FixedBuffer"]/*' />
    [InlineArray(3)]
    public partial struct _ThreadIDInGroup_e__FixedBuffer
    {
        public uint e0;
    }

    /// <include file='_ThreadGroupID_e__FixedBuffer.xml' path='doc/member[@name="_ThreadGroupID_e__FixedBuffer"]/*' />
    [InlineArray(3)]
    public partial struct _ThreadGroupID_e__FixedBuffer
    {
        public uint e0;
    }
}
