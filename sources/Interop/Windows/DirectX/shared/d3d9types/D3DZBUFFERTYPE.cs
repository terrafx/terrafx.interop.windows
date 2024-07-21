// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3DZBUFFERTYPE.xml' path='doc/member[@name="D3DZBUFFERTYPE"]/*' />
public enum D3DZBUFFERTYPE
{
    /// <include file='D3DZBUFFERTYPE.xml' path='doc/member[@name="D3DZBUFFERTYPE.D3DZB_FALSE"]/*' />
    D3DZB_FALSE = 0,

    /// <include file='D3DZBUFFERTYPE.xml' path='doc/member[@name="D3DZBUFFERTYPE.D3DZB_TRUE"]/*' />
    D3DZB_TRUE = 1,

    /// <include file='D3DZBUFFERTYPE.xml' path='doc/member[@name="D3DZBUFFERTYPE.D3DZB_USEW"]/*' />
    D3DZB_USEW = 2,

    /// <include file='D3DZBUFFERTYPE.xml' path='doc/member[@name="D3DZBUFFERTYPE.D3DZB_FORCE_DWORD"]/*' />
    D3DZB_FORCE_DWORD = 0x7fffffff,
}
