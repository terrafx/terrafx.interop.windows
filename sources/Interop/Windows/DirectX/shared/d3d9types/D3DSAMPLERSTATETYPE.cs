// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3DSAMPLERSTATETYPE.xml' path='doc/member[@name="D3DSAMPLERSTATETYPE"]/*' />
public enum D3DSAMPLERSTATETYPE
{
    /// <include file='D3DSAMPLERSTATETYPE.xml' path='doc/member[@name="D3DSAMPLERSTATETYPE.D3DSAMP_ADDRESSU"]/*' />
    D3DSAMP_ADDRESSU = 1,

    /// <include file='D3DSAMPLERSTATETYPE.xml' path='doc/member[@name="D3DSAMPLERSTATETYPE.D3DSAMP_ADDRESSV"]/*' />
    D3DSAMP_ADDRESSV = 2,

    /// <include file='D3DSAMPLERSTATETYPE.xml' path='doc/member[@name="D3DSAMPLERSTATETYPE.D3DSAMP_ADDRESSW"]/*' />
    D3DSAMP_ADDRESSW = 3,

    /// <include file='D3DSAMPLERSTATETYPE.xml' path='doc/member[@name="D3DSAMPLERSTATETYPE.D3DSAMP_BORDERCOLOR"]/*' />
    D3DSAMP_BORDERCOLOR = 4,

    /// <include file='D3DSAMPLERSTATETYPE.xml' path='doc/member[@name="D3DSAMPLERSTATETYPE.D3DSAMP_MAGFILTER"]/*' />
    D3DSAMP_MAGFILTER = 5,

    /// <include file='D3DSAMPLERSTATETYPE.xml' path='doc/member[@name="D3DSAMPLERSTATETYPE.D3DSAMP_MINFILTER"]/*' />
    D3DSAMP_MINFILTER = 6,

    /// <include file='D3DSAMPLERSTATETYPE.xml' path='doc/member[@name="D3DSAMPLERSTATETYPE.D3DSAMP_MIPFILTER"]/*' />
    D3DSAMP_MIPFILTER = 7,

    /// <include file='D3DSAMPLERSTATETYPE.xml' path='doc/member[@name="D3DSAMPLERSTATETYPE.D3DSAMP_MIPMAPLODBIAS"]/*' />
    D3DSAMP_MIPMAPLODBIAS = 8,

    /// <include file='D3DSAMPLERSTATETYPE.xml' path='doc/member[@name="D3DSAMPLERSTATETYPE.D3DSAMP_MAXMIPLEVEL"]/*' />
    D3DSAMP_MAXMIPLEVEL = 9,

    /// <include file='D3DSAMPLERSTATETYPE.xml' path='doc/member[@name="D3DSAMPLERSTATETYPE.D3DSAMP_MAXANISOTROPY"]/*' />
    D3DSAMP_MAXANISOTROPY = 10,

    /// <include file='D3DSAMPLERSTATETYPE.xml' path='doc/member[@name="D3DSAMPLERSTATETYPE.D3DSAMP_SRGBTEXTURE"]/*' />
    D3DSAMP_SRGBTEXTURE = 11,

    /// <include file='D3DSAMPLERSTATETYPE.xml' path='doc/member[@name="D3DSAMPLERSTATETYPE.D3DSAMP_ELEMENTINDEX"]/*' />
    D3DSAMP_ELEMENTINDEX = 12,

    /// <include file='D3DSAMPLERSTATETYPE.xml' path='doc/member[@name="D3DSAMPLERSTATETYPE.D3DSAMP_DMAPOFFSET"]/*' />
    D3DSAMP_DMAPOFFSET = 13,

    /// <include file='D3DSAMPLERSTATETYPE.xml' path='doc/member[@name="D3DSAMPLERSTATETYPE.D3DSAMP_FORCE_DWORD"]/*' />
    D3DSAMP_FORCE_DWORD = 0x7fffffff,
}
