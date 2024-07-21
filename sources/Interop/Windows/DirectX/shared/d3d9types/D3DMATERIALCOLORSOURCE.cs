// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3DMATERIALCOLORSOURCE.xml' path='doc/member[@name="D3DMATERIALCOLORSOURCE"]/*' />
public enum D3DMATERIALCOLORSOURCE
{
    /// <include file='D3DMATERIALCOLORSOURCE.xml' path='doc/member[@name="D3DMATERIALCOLORSOURCE.D3DMCS_MATERIAL"]/*' />
    D3DMCS_MATERIAL = 0,

    /// <include file='D3DMATERIALCOLORSOURCE.xml' path='doc/member[@name="D3DMATERIALCOLORSOURCE.D3DMCS_COLOR1"]/*' />
    D3DMCS_COLOR1 = 1,

    /// <include file='D3DMATERIALCOLORSOURCE.xml' path='doc/member[@name="D3DMATERIALCOLORSOURCE.D3DMCS_COLOR2"]/*' />
    D3DMCS_COLOR2 = 2,

    /// <include file='D3DMATERIALCOLORSOURCE.xml' path='doc/member[@name="D3DMATERIALCOLORSOURCE.D3DMCS_FORCE_DWORD"]/*' />
    D3DMCS_FORCE_DWORD = 0x7fffffff,
}
