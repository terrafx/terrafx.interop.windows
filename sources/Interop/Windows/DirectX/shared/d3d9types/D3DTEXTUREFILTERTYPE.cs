// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3DTEXTUREFILTERTYPE.xml' path='doc/member[@name="D3DTEXTUREFILTERTYPE"]/*' />
public enum D3DTEXTUREFILTERTYPE
{
    /// <include file='D3DTEXTUREFILTERTYPE.xml' path='doc/member[@name="D3DTEXTUREFILTERTYPE.D3DTEXF_NONE"]/*' />
    D3DTEXF_NONE = 0,

    /// <include file='D3DTEXTUREFILTERTYPE.xml' path='doc/member[@name="D3DTEXTUREFILTERTYPE.D3DTEXF_POINT"]/*' />
    D3DTEXF_POINT = 1,

    /// <include file='D3DTEXTUREFILTERTYPE.xml' path='doc/member[@name="D3DTEXTUREFILTERTYPE.D3DTEXF_LINEAR"]/*' />
    D3DTEXF_LINEAR = 2,

    /// <include file='D3DTEXTUREFILTERTYPE.xml' path='doc/member[@name="D3DTEXTUREFILTERTYPE.D3DTEXF_ANISOTROPIC"]/*' />
    D3DTEXF_ANISOTROPIC = 3,

    /// <include file='D3DTEXTUREFILTERTYPE.xml' path='doc/member[@name="D3DTEXTUREFILTERTYPE.D3DTEXF_PYRAMIDALQUAD"]/*' />
    D3DTEXF_PYRAMIDALQUAD = 6,

    /// <include file='D3DTEXTUREFILTERTYPE.xml' path='doc/member[@name="D3DTEXTUREFILTERTYPE.D3DTEXF_GAUSSIANQUAD"]/*' />
    D3DTEXF_GAUSSIANQUAD = 7,

    /// <include file='D3DTEXTUREFILTERTYPE.xml' path='doc/member[@name="D3DTEXTUREFILTERTYPE.D3DTEXF_CONVOLUTIONMONO"]/*' />
    D3DTEXF_CONVOLUTIONMONO = 8,

    /// <include file='D3DTEXTUREFILTERTYPE.xml' path='doc/member[@name="D3DTEXTUREFILTERTYPE.D3DTEXF_FORCE_DWORD"]/*' />
    D3DTEXF_FORCE_DWORD = 0x7fffffff,
}
