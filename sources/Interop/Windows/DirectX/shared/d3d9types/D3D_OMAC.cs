// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D_OMAC.xml' path='doc/member[@name="D3D_OMAC"]/*' />
public partial struct D3D_OMAC
{
    /// <include file='D3D_OMAC.xml' path='doc/member[@name="D3D_OMAC.Omac"]/*' />
    [NativeTypeName("BYTE[16]")]
    public _Omac_e__FixedBuffer Omac;

    /// <include file='_Omac_e__FixedBuffer.xml' path='doc/member[@name="_Omac_e__FixedBuffer"]/*' />
    [InlineArray(16)]
    public partial struct _Omac_e__FixedBuffer
    {
        public byte e0;
    }
}
