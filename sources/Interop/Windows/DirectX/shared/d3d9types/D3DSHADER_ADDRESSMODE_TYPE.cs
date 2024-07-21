// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3DSHADER_ADDRESSMODE_TYPE.xml' path='doc/member[@name="D3DSHADER_ADDRESSMODE_TYPE"]/*' />
public enum D3DSHADER_ADDRESSMODE_TYPE
{
    /// <include file='D3DSHADER_ADDRESSMODE_TYPE.xml' path='doc/member[@name="D3DSHADER_ADDRESSMODE_TYPE.D3DSHADER_ADDRMODE_ABSOLUTE"]/*' />
    D3DSHADER_ADDRMODE_ABSOLUTE = (0 << 13),

    /// <include file='D3DSHADER_ADDRESSMODE_TYPE.xml' path='doc/member[@name="D3DSHADER_ADDRESSMODE_TYPE.D3DSHADER_ADDRMODE_RELATIVE"]/*' />
    D3DSHADER_ADDRMODE_RELATIVE = (1 << 13),

    /// <include file='D3DSHADER_ADDRESSMODE_TYPE.xml' path='doc/member[@name="D3DSHADER_ADDRESSMODE_TYPE.D3DSHADER_ADDRMODE_FORCE_DWORD"]/*' />
    D3DSHADER_ADDRMODE_FORCE_DWORD = 0x7fffffff,
}
