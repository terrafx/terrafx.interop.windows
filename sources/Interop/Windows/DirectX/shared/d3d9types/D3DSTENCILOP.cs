// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3DSTENCILOP.xml' path='doc/member[@name="D3DSTENCILOP"]/*' />
public enum D3DSTENCILOP
{
    /// <include file='D3DSTENCILOP.xml' path='doc/member[@name="D3DSTENCILOP.D3DSTENCILOP_KEEP"]/*' />
    D3DSTENCILOP_KEEP = 1,

    /// <include file='D3DSTENCILOP.xml' path='doc/member[@name="D3DSTENCILOP.D3DSTENCILOP_ZERO"]/*' />
    D3DSTENCILOP_ZERO = 2,

    /// <include file='D3DSTENCILOP.xml' path='doc/member[@name="D3DSTENCILOP.D3DSTENCILOP_REPLACE"]/*' />
    D3DSTENCILOP_REPLACE = 3,

    /// <include file='D3DSTENCILOP.xml' path='doc/member[@name="D3DSTENCILOP.D3DSTENCILOP_INCRSAT"]/*' />
    D3DSTENCILOP_INCRSAT = 4,

    /// <include file='D3DSTENCILOP.xml' path='doc/member[@name="D3DSTENCILOP.D3DSTENCILOP_DECRSAT"]/*' />
    D3DSTENCILOP_DECRSAT = 5,

    /// <include file='D3DSTENCILOP.xml' path='doc/member[@name="D3DSTENCILOP.D3DSTENCILOP_INVERT"]/*' />
    D3DSTENCILOP_INVERT = 6,

    /// <include file='D3DSTENCILOP.xml' path='doc/member[@name="D3DSTENCILOP.D3DSTENCILOP_INCR"]/*' />
    D3DSTENCILOP_INCR = 7,

    /// <include file='D3DSTENCILOP.xml' path='doc/member[@name="D3DSTENCILOP.D3DSTENCILOP_DECR"]/*' />
    D3DSTENCILOP_DECR = 8,

    /// <include file='D3DSTENCILOP.xml' path='doc/member[@name="D3DSTENCILOP.D3DSTENCILOP_FORCE_DWORD"]/*' />
    D3DSTENCILOP_FORCE_DWORD = 0x7fffffff,
}
