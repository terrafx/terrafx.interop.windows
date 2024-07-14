// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3DPRIMITIVETYPE.xml' path='doc/member[@name="D3DPRIMITIVETYPE"]/*' />
public enum D3DPRIMITIVETYPE
{
    /// <include file='D3DPRIMITIVETYPE.xml' path='doc/member[@name="D3DPRIMITIVETYPE.D3DPT_POINTLIST"]/*' />
    D3DPT_POINTLIST = 1,

    /// <include file='D3DPRIMITIVETYPE.xml' path='doc/member[@name="D3DPRIMITIVETYPE.D3DPT_LINELIST"]/*' />
    D3DPT_LINELIST = 2,

    /// <include file='D3DPRIMITIVETYPE.xml' path='doc/member[@name="D3DPRIMITIVETYPE.D3DPT_LINESTRIP"]/*' />
    D3DPT_LINESTRIP = 3,

    /// <include file='D3DPRIMITIVETYPE.xml' path='doc/member[@name="D3DPRIMITIVETYPE.D3DPT_TRIANGLELIST"]/*' />
    D3DPT_TRIANGLELIST = 4,

    /// <include file='D3DPRIMITIVETYPE.xml' path='doc/member[@name="D3DPRIMITIVETYPE.D3DPT_TRIANGLESTRIP"]/*' />
    D3DPT_TRIANGLESTRIP = 5,

    /// <include file='D3DPRIMITIVETYPE.xml' path='doc/member[@name="D3DPRIMITIVETYPE.D3DPT_TRIANGLEFAN"]/*' />
    D3DPT_TRIANGLEFAN = 6,

    /// <include file='D3DPRIMITIVETYPE.xml' path='doc/member[@name="D3DPRIMITIVETYPE.D3DPT_FORCE_DWORD"]/*' />
    D3DPT_FORCE_DWORD = 0x7fffffff,
}
