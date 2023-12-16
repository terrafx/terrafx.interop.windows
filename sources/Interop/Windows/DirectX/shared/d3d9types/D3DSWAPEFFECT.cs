// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3DSWAPEFFECT.xml' path='doc/member[@name="D3DSWAPEFFECT"]/*' />
public enum D3DSWAPEFFECT
{
    /// <include file='D3DSWAPEFFECT.xml' path='doc/member[@name="D3DSWAPEFFECT.D3DSWAPEFFECT_DISCARD"]/*' />
    D3DSWAPEFFECT_DISCARD = 1,

    /// <include file='D3DSWAPEFFECT.xml' path='doc/member[@name="D3DSWAPEFFECT.D3DSWAPEFFECT_FLIP"]/*' />
    D3DSWAPEFFECT_FLIP = 2,

    /// <include file='D3DSWAPEFFECT.xml' path='doc/member[@name="D3DSWAPEFFECT.D3DSWAPEFFECT_COPY"]/*' />
    D3DSWAPEFFECT_COPY = 3,

    /// <include file='D3DSWAPEFFECT.xml' path='doc/member[@name="D3DSWAPEFFECT.D3DSWAPEFFECT_OVERLAY"]/*' />
    D3DSWAPEFFECT_OVERLAY = 4,

    /// <include file='D3DSWAPEFFECT.xml' path='doc/member[@name="D3DSWAPEFFECT.D3DSWAPEFFECT_FLIPEX"]/*' />
    D3DSWAPEFFECT_FLIPEX = 5,

    /// <include file='D3DSWAPEFFECT.xml' path='doc/member[@name="D3DSWAPEFFECT.D3DSWAPEFFECT_FORCE_DWORD"]/*' />
    D3DSWAPEFFECT_FORCE_DWORD = 0x7fffffff,
}
