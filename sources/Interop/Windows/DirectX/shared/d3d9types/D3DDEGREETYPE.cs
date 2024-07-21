// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3DDEGREETYPE.xml' path='doc/member[@name="D3DDEGREETYPE"]/*' />
public enum D3DDEGREETYPE
{
    /// <include file='D3DDEGREETYPE.xml' path='doc/member[@name="D3DDEGREETYPE.D3DDEGREE_LINEAR"]/*' />
    D3DDEGREE_LINEAR = 1,

    /// <include file='D3DDEGREETYPE.xml' path='doc/member[@name="D3DDEGREETYPE.D3DDEGREE_QUADRATIC"]/*' />
    D3DDEGREE_QUADRATIC = 2,

    /// <include file='D3DDEGREETYPE.xml' path='doc/member[@name="D3DDEGREETYPE.D3DDEGREE_CUBIC"]/*' />
    D3DDEGREE_CUBIC = 3,

    /// <include file='D3DDEGREETYPE.xml' path='doc/member[@name="D3DDEGREETYPE.D3DDEGREE_QUINTIC"]/*' />
    D3DDEGREE_QUINTIC = 5,

    /// <include file='D3DDEGREETYPE.xml' path='doc/member[@name="D3DDEGREETYPE.D3DDEGREE_FORCE_DWORD"]/*' />
    D3DDEGREE_FORCE_DWORD = 0x7fffffff,
}
