// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3DSTATEBLOCKTYPE.xml' path='doc/member[@name="D3DSTATEBLOCKTYPE"]/*' />
public enum D3DSTATEBLOCKTYPE
{
    /// <include file='D3DSTATEBLOCKTYPE.xml' path='doc/member[@name="D3DSTATEBLOCKTYPE.D3DSBT_ALL"]/*' />
    D3DSBT_ALL = 1,

    /// <include file='D3DSTATEBLOCKTYPE.xml' path='doc/member[@name="D3DSTATEBLOCKTYPE.D3DSBT_PIXELSTATE"]/*' />
    D3DSBT_PIXELSTATE = 2,

    /// <include file='D3DSTATEBLOCKTYPE.xml' path='doc/member[@name="D3DSTATEBLOCKTYPE.D3DSBT_VERTEXSTATE"]/*' />
    D3DSBT_VERTEXSTATE = 3,

    /// <include file='D3DSTATEBLOCKTYPE.xml' path='doc/member[@name="D3DSTATEBLOCKTYPE.D3DSBT_FORCE_DWORD"]/*' />
    D3DSBT_FORCE_DWORD = 0x7fffffff,
}
