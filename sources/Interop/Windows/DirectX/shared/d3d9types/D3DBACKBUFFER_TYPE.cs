// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3DBACKBUFFER_TYPE.xml' path='doc/member[@name="D3DBACKBUFFER_TYPE"]/*' />
public enum D3DBACKBUFFER_TYPE
{
    /// <include file='D3DBACKBUFFER_TYPE.xml' path='doc/member[@name="D3DBACKBUFFER_TYPE.D3DBACKBUFFER_TYPE_MONO"]/*' />
    D3DBACKBUFFER_TYPE_MONO = 0,

    /// <include file='D3DBACKBUFFER_TYPE.xml' path='doc/member[@name="D3DBACKBUFFER_TYPE.D3DBACKBUFFER_TYPE_LEFT"]/*' />
    D3DBACKBUFFER_TYPE_LEFT = 1,

    /// <include file='D3DBACKBUFFER_TYPE.xml' path='doc/member[@name="D3DBACKBUFFER_TYPE.D3DBACKBUFFER_TYPE_RIGHT"]/*' />
    D3DBACKBUFFER_TYPE_RIGHT = 2,

    /// <include file='D3DBACKBUFFER_TYPE.xml' path='doc/member[@name="D3DBACKBUFFER_TYPE.D3DBACKBUFFER_TYPE_FORCE_DWORD"]/*' />
    D3DBACKBUFFER_TYPE_FORCE_DWORD = 0x7fffffff,
}
