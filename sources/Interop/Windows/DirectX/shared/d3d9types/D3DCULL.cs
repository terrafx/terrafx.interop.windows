// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3DCULL.xml' path='doc/member[@name="D3DCULL"]/*' />
public enum D3DCULL
{
    /// <include file='D3DCULL.xml' path='doc/member[@name="D3DCULL.D3DCULL_NONE"]/*' />
    D3DCULL_NONE = 1,

    /// <include file='D3DCULL.xml' path='doc/member[@name="D3DCULL.D3DCULL_CW"]/*' />
    D3DCULL_CW = 2,

    /// <include file='D3DCULL.xml' path='doc/member[@name="D3DCULL.D3DCULL_CCW"]/*' />
    D3DCULL_CCW = 3,

    /// <include file='D3DCULL.xml' path='doc/member[@name="D3DCULL.D3DCULL_FORCE_DWORD"]/*' />
    D3DCULL_FORCE_DWORD = 0x7fffffff,
}
