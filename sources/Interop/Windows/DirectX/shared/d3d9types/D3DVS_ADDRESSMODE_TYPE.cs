// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3DVS_ADDRESSMODE_TYPE.xml' path='doc/member[@name="D3DVS_ADDRESSMODE_TYPE"]/*' />
public enum D3DVS_ADDRESSMODE_TYPE
{
    /// <include file='D3DVS_ADDRESSMODE_TYPE.xml' path='doc/member[@name="D3DVS_ADDRESSMODE_TYPE.D3DVS_ADDRMODE_ABSOLUTE"]/*' />
    D3DVS_ADDRMODE_ABSOLUTE = (0 << 13),

    /// <include file='D3DVS_ADDRESSMODE_TYPE.xml' path='doc/member[@name="D3DVS_ADDRESSMODE_TYPE.D3DVS_ADDRMODE_RELATIVE"]/*' />
    D3DVS_ADDRMODE_RELATIVE = (1 << 13),

    /// <include file='D3DVS_ADDRESSMODE_TYPE.xml' path='doc/member[@name="D3DVS_ADDRESSMODE_TYPE.D3DVS_ADDRMODE_FORCE_DWORD"]/*' />
    D3DVS_ADDRMODE_FORCE_DWORD = 0x7fffffff,
}
