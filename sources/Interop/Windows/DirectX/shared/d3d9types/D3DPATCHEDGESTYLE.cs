// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3DPATCHEDGESTYLE.xml' path='doc/member[@name="D3DPATCHEDGESTYLE"]/*' />
public enum D3DPATCHEDGESTYLE
{
    /// <include file='D3DPATCHEDGESTYLE.xml' path='doc/member[@name="D3DPATCHEDGESTYLE.D3DPATCHEDGE_DISCRETE"]/*' />
    D3DPATCHEDGE_DISCRETE = 0,

    /// <include file='D3DPATCHEDGESTYLE.xml' path='doc/member[@name="D3DPATCHEDGESTYLE.D3DPATCHEDGE_CONTINUOUS"]/*' />
    D3DPATCHEDGE_CONTINUOUS = 1,

    /// <include file='D3DPATCHEDGESTYLE.xml' path='doc/member[@name="D3DPATCHEDGESTYLE.D3DPATCHEDGE_FORCE_DWORD"]/*' />
    D3DPATCHEDGE_FORCE_DWORD = 0x7fffffff,
}
