// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3DTEXTURESTAGESTATETYPE.xml' path='doc/member[@name="D3DTEXTURESTAGESTATETYPE"]/*' />
public enum D3DTEXTURESTAGESTATETYPE
{
    /// <include file='D3DTEXTURESTAGESTATETYPE.xml' path='doc/member[@name="D3DTEXTURESTAGESTATETYPE.D3DTSS_COLOROP"]/*' />
    D3DTSS_COLOROP = 1,

    /// <include file='D3DTEXTURESTAGESTATETYPE.xml' path='doc/member[@name="D3DTEXTURESTAGESTATETYPE.D3DTSS_COLORARG1"]/*' />
    D3DTSS_COLORARG1 = 2,

    /// <include file='D3DTEXTURESTAGESTATETYPE.xml' path='doc/member[@name="D3DTEXTURESTAGESTATETYPE.D3DTSS_COLORARG2"]/*' />
    D3DTSS_COLORARG2 = 3,

    /// <include file='D3DTEXTURESTAGESTATETYPE.xml' path='doc/member[@name="D3DTEXTURESTAGESTATETYPE.D3DTSS_ALPHAOP"]/*' />
    D3DTSS_ALPHAOP = 4,

    /// <include file='D3DTEXTURESTAGESTATETYPE.xml' path='doc/member[@name="D3DTEXTURESTAGESTATETYPE.D3DTSS_ALPHAARG1"]/*' />
    D3DTSS_ALPHAARG1 = 5,

    /// <include file='D3DTEXTURESTAGESTATETYPE.xml' path='doc/member[@name="D3DTEXTURESTAGESTATETYPE.D3DTSS_ALPHAARG2"]/*' />
    D3DTSS_ALPHAARG2 = 6,

    /// <include file='D3DTEXTURESTAGESTATETYPE.xml' path='doc/member[@name="D3DTEXTURESTAGESTATETYPE.D3DTSS_BUMPENVMAT00"]/*' />
    D3DTSS_BUMPENVMAT00 = 7,

    /// <include file='D3DTEXTURESTAGESTATETYPE.xml' path='doc/member[@name="D3DTEXTURESTAGESTATETYPE.D3DTSS_BUMPENVMAT01"]/*' />
    D3DTSS_BUMPENVMAT01 = 8,

    /// <include file='D3DTEXTURESTAGESTATETYPE.xml' path='doc/member[@name="D3DTEXTURESTAGESTATETYPE.D3DTSS_BUMPENVMAT10"]/*' />
    D3DTSS_BUMPENVMAT10 = 9,

    /// <include file='D3DTEXTURESTAGESTATETYPE.xml' path='doc/member[@name="D3DTEXTURESTAGESTATETYPE.D3DTSS_BUMPENVMAT11"]/*' />
    D3DTSS_BUMPENVMAT11 = 10,

    /// <include file='D3DTEXTURESTAGESTATETYPE.xml' path='doc/member[@name="D3DTEXTURESTAGESTATETYPE.D3DTSS_TEXCOORDINDEX"]/*' />
    D3DTSS_TEXCOORDINDEX = 11,

    /// <include file='D3DTEXTURESTAGESTATETYPE.xml' path='doc/member[@name="D3DTEXTURESTAGESTATETYPE.D3DTSS_BUMPENVLSCALE"]/*' />
    D3DTSS_BUMPENVLSCALE = 22,

    /// <include file='D3DTEXTURESTAGESTATETYPE.xml' path='doc/member[@name="D3DTEXTURESTAGESTATETYPE.D3DTSS_BUMPENVLOFFSET"]/*' />
    D3DTSS_BUMPENVLOFFSET = 23,

    /// <include file='D3DTEXTURESTAGESTATETYPE.xml' path='doc/member[@name="D3DTEXTURESTAGESTATETYPE.D3DTSS_TEXTURETRANSFORMFLAGS"]/*' />
    D3DTSS_TEXTURETRANSFORMFLAGS = 24,

    /// <include file='D3DTEXTURESTAGESTATETYPE.xml' path='doc/member[@name="D3DTEXTURESTAGESTATETYPE.D3DTSS_COLORARG0"]/*' />
    D3DTSS_COLORARG0 = 26,

    /// <include file='D3DTEXTURESTAGESTATETYPE.xml' path='doc/member[@name="D3DTEXTURESTAGESTATETYPE.D3DTSS_ALPHAARG0"]/*' />
    D3DTSS_ALPHAARG0 = 27,

    /// <include file='D3DTEXTURESTAGESTATETYPE.xml' path='doc/member[@name="D3DTEXTURESTAGESTATETYPE.D3DTSS_RESULTARG"]/*' />
    D3DTSS_RESULTARG = 28,

    /// <include file='D3DTEXTURESTAGESTATETYPE.xml' path='doc/member[@name="D3DTEXTURESTAGESTATETYPE.D3DTSS_CONSTANT"]/*' />
    D3DTSS_CONSTANT = 32,

    /// <include file='D3DTEXTURESTAGESTATETYPE.xml' path='doc/member[@name="D3DTEXTURESTAGESTATETYPE.D3DTSS_FORCE_DWORD"]/*' />
    D3DTSS_FORCE_DWORD = 0x7fffffff,
}
