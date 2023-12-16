// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3DPOOL.xml' path='doc/member[@name="D3DPOOL"]/*' />
public enum D3DPOOL
{
    /// <include file='D3DPOOL.xml' path='doc/member[@name="D3DPOOL.D3DPOOL_DEFAULT"]/*' />
    D3DPOOL_DEFAULT = 0,

    /// <include file='D3DPOOL.xml' path='doc/member[@name="D3DPOOL.D3DPOOL_MANAGED"]/*' />
    D3DPOOL_MANAGED = 1,

    /// <include file='D3DPOOL.xml' path='doc/member[@name="D3DPOOL.D3DPOOL_SYSTEMMEM"]/*' />
    D3DPOOL_SYSTEMMEM = 2,

    /// <include file='D3DPOOL.xml' path='doc/member[@name="D3DPOOL.D3DPOOL_SCRATCH"]/*' />
    D3DPOOL_SCRATCH = 3,

    /// <include file='D3DPOOL.xml' path='doc/member[@name="D3DPOOL.D3DPOOL_FORCE_DWORD"]/*' />
    D3DPOOL_FORCE_DWORD = 0x7fffffff,
}
