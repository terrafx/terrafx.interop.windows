// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3DDECLMETHOD.xml' path='doc/member[@name="D3DDECLMETHOD"]/*' />
public enum D3DDECLMETHOD
{
    /// <include file='D3DDECLMETHOD.xml' path='doc/member[@name="D3DDECLMETHOD.D3DDECLMETHOD_DEFAULT"]/*' />
    D3DDECLMETHOD_DEFAULT = 0,

    /// <include file='D3DDECLMETHOD.xml' path='doc/member[@name="D3DDECLMETHOD.D3DDECLMETHOD_PARTIALU"]/*' />
    D3DDECLMETHOD_PARTIALU,

    /// <include file='D3DDECLMETHOD.xml' path='doc/member[@name="D3DDECLMETHOD.D3DDECLMETHOD_PARTIALV"]/*' />
    D3DDECLMETHOD_PARTIALV,

    /// <include file='D3DDECLMETHOD.xml' path='doc/member[@name="D3DDECLMETHOD.D3DDECLMETHOD_CROSSUV"]/*' />
    D3DDECLMETHOD_CROSSUV,

    /// <include file='D3DDECLMETHOD.xml' path='doc/member[@name="D3DDECLMETHOD.D3DDECLMETHOD_UV"]/*' />
    D3DDECLMETHOD_UV,

    /// <include file='D3DDECLMETHOD.xml' path='doc/member[@name="D3DDECLMETHOD.D3DDECLMETHOD_LOOKUP"]/*' />
    D3DDECLMETHOD_LOOKUP,

    /// <include file='D3DDECLMETHOD.xml' path='doc/member[@name="D3DDECLMETHOD.D3DDECLMETHOD_LOOKUPPRESAMPLED"]/*' />
    D3DDECLMETHOD_LOOKUPPRESAMPLED,
}
