// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dxcapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the University of Illinois Open Source License.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.DirectX;

/// <include file='DxcShaderHash.xml' path='doc/member[@name="DxcShaderHash"]/*' />
public partial struct DxcShaderHash
{
    /// <include file='DxcShaderHash.xml' path='doc/member[@name="DxcShaderHash.Flags"]/*' />
    [NativeTypeName("UINT32")]
    public uint Flags;

    /// <include file='DxcShaderHash.xml' path='doc/member[@name="DxcShaderHash.HashDigest"]/*' />
    [NativeTypeName("BYTE[16]")]
    public _HashDigest_e__FixedBuffer HashDigest;

    /// <include file='_HashDigest_e__FixedBuffer.xml' path='doc/member[@name="_HashDigest_e__FixedBuffer"]/*' />
    [InlineArray(16)]
    public partial struct _HashDigest_e__FixedBuffer
    {
        public byte e0;
    }
}
