// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3DDEBUGMONITORTOKENS.xml' path='doc/member[@name="D3DDEBUGMONITORTOKENS"]/*' />
public enum D3DDEBUGMONITORTOKENS
{
    /// <include file='D3DDEBUGMONITORTOKENS.xml' path='doc/member[@name="D3DDEBUGMONITORTOKENS.D3DDMT_ENABLE"]/*' />
    D3DDMT_ENABLE = 0,

    /// <include file='D3DDEBUGMONITORTOKENS.xml' path='doc/member[@name="D3DDEBUGMONITORTOKENS.D3DDMT_DISABLE"]/*' />
    D3DDMT_DISABLE = 1,

    /// <include file='D3DDEBUGMONITORTOKENS.xml' path='doc/member[@name="D3DDEBUGMONITORTOKENS.D3DDMT_FORCE_DWORD"]/*' />
    D3DDMT_FORCE_DWORD = 0x7fffffff,
}
