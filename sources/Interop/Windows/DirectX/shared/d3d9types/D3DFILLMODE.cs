// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3DFILLMODE.xml' path='doc/member[@name="D3DFILLMODE"]/*' />
public enum D3DFILLMODE
{
    /// <include file='D3DFILLMODE.xml' path='doc/member[@name="D3DFILLMODE.D3DFILL_POINT"]/*' />
    D3DFILL_POINT = 1,

    /// <include file='D3DFILLMODE.xml' path='doc/member[@name="D3DFILLMODE.D3DFILL_WIREFRAME"]/*' />
    D3DFILL_WIREFRAME = 2,

    /// <include file='D3DFILLMODE.xml' path='doc/member[@name="D3DFILLMODE.D3DFILL_SOLID"]/*' />
    D3DFILL_SOLID = 3,

    /// <include file='D3DFILLMODE.xml' path='doc/member[@name="D3DFILLMODE.D3DFILL_FORCE_DWORD"]/*' />
    D3DFILL_FORCE_DWORD = 0x7fffffff,
}
