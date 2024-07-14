// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3DFOGMODE.xml' path='doc/member[@name="D3DFOGMODE"]/*' />
public enum D3DFOGMODE
{
    /// <include file='D3DFOGMODE.xml' path='doc/member[@name="D3DFOGMODE.D3DFOG_NONE"]/*' />
    D3DFOG_NONE = 0,

    /// <include file='D3DFOGMODE.xml' path='doc/member[@name="D3DFOGMODE.D3DFOG_EXP"]/*' />
    D3DFOG_EXP = 1,

    /// <include file='D3DFOGMODE.xml' path='doc/member[@name="D3DFOGMODE.D3DFOG_EXP2"]/*' />
    D3DFOG_EXP2 = 2,

    /// <include file='D3DFOGMODE.xml' path='doc/member[@name="D3DFOGMODE.D3DFOG_LINEAR"]/*' />
    D3DFOG_LINEAR = 3,

    /// <include file='D3DFOGMODE.xml' path='doc/member[@name="D3DFOGMODE.D3DFOG_FORCE_DWORD"]/*' />
    D3DFOG_FORCE_DWORD = 0x7fffffff,
}
