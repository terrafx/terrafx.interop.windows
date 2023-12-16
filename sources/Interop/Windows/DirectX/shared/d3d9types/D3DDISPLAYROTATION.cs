// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3DDISPLAYROTATION.xml' path='doc/member[@name="D3DDISPLAYROTATION"]/*' />
public enum D3DDISPLAYROTATION
{
    /// <include file='D3DDISPLAYROTATION.xml' path='doc/member[@name="D3DDISPLAYROTATION.D3DDISPLAYROTATION_IDENTITY"]/*' />
    D3DDISPLAYROTATION_IDENTITY = 1,

    /// <include file='D3DDISPLAYROTATION.xml' path='doc/member[@name="D3DDISPLAYROTATION.D3DDISPLAYROTATION_90"]/*' />
    D3DDISPLAYROTATION_90 = 2,

    /// <include file='D3DDISPLAYROTATION.xml' path='doc/member[@name="D3DDISPLAYROTATION.D3DDISPLAYROTATION_180"]/*' />
    D3DDISPLAYROTATION_180 = 3,

    /// <include file='D3DDISPLAYROTATION.xml' path='doc/member[@name="D3DDISPLAYROTATION.D3DDISPLAYROTATION_270"]/*' />
    D3DDISPLAYROTATION_270 = 4,
}
