// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3DRESOURCETYPE.xml' path='doc/member[@name="D3DRESOURCETYPE"]/*' />
public enum D3DRESOURCETYPE
{
    /// <include file='D3DRESOURCETYPE.xml' path='doc/member[@name="D3DRESOURCETYPE.D3DRTYPE_SURFACE"]/*' />
    D3DRTYPE_SURFACE = 1,

    /// <include file='D3DRESOURCETYPE.xml' path='doc/member[@name="D3DRESOURCETYPE.D3DRTYPE_VOLUME"]/*' />
    D3DRTYPE_VOLUME = 2,

    /// <include file='D3DRESOURCETYPE.xml' path='doc/member[@name="D3DRESOURCETYPE.D3DRTYPE_TEXTURE"]/*' />
    D3DRTYPE_TEXTURE = 3,

    /// <include file='D3DRESOURCETYPE.xml' path='doc/member[@name="D3DRESOURCETYPE.D3DRTYPE_VOLUMETEXTURE"]/*' />
    D3DRTYPE_VOLUMETEXTURE = 4,

    /// <include file='D3DRESOURCETYPE.xml' path='doc/member[@name="D3DRESOURCETYPE.D3DRTYPE_CUBETEXTURE"]/*' />
    D3DRTYPE_CUBETEXTURE = 5,

    /// <include file='D3DRESOURCETYPE.xml' path='doc/member[@name="D3DRESOURCETYPE.D3DRTYPE_VERTEXBUFFER"]/*' />
    D3DRTYPE_VERTEXBUFFER = 6,

    /// <include file='D3DRESOURCETYPE.xml' path='doc/member[@name="D3DRESOURCETYPE.D3DRTYPE_INDEXBUFFER"]/*' />
    D3DRTYPE_INDEXBUFFER = 7,

    /// <include file='D3DRESOURCETYPE.xml' path='doc/member[@name="D3DRESOURCETYPE.D3DRTYPE_FORCE_DWORD"]/*' />
    D3DRTYPE_FORCE_DWORD = 0x7fffffff,
}
