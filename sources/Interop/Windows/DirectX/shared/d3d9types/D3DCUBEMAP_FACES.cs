// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3DCUBEMAP_FACES.xml' path='doc/member[@name="D3DCUBEMAP_FACES"]/*' />
public enum D3DCUBEMAP_FACES
{
    /// <include file='D3DCUBEMAP_FACES.xml' path='doc/member[@name="D3DCUBEMAP_FACES.D3DCUBEMAP_FACE_POSITIVE_X"]/*' />
    D3DCUBEMAP_FACE_POSITIVE_X = 0,

    /// <include file='D3DCUBEMAP_FACES.xml' path='doc/member[@name="D3DCUBEMAP_FACES.D3DCUBEMAP_FACE_NEGATIVE_X"]/*' />
    D3DCUBEMAP_FACE_NEGATIVE_X = 1,

    /// <include file='D3DCUBEMAP_FACES.xml' path='doc/member[@name="D3DCUBEMAP_FACES.D3DCUBEMAP_FACE_POSITIVE_Y"]/*' />
    D3DCUBEMAP_FACE_POSITIVE_Y = 2,

    /// <include file='D3DCUBEMAP_FACES.xml' path='doc/member[@name="D3DCUBEMAP_FACES.D3DCUBEMAP_FACE_NEGATIVE_Y"]/*' />
    D3DCUBEMAP_FACE_NEGATIVE_Y = 3,

    /// <include file='D3DCUBEMAP_FACES.xml' path='doc/member[@name="D3DCUBEMAP_FACES.D3DCUBEMAP_FACE_POSITIVE_Z"]/*' />
    D3DCUBEMAP_FACE_POSITIVE_Z = 4,

    /// <include file='D3DCUBEMAP_FACES.xml' path='doc/member[@name="D3DCUBEMAP_FACES.D3DCUBEMAP_FACE_NEGATIVE_Z"]/*' />
    D3DCUBEMAP_FACE_NEGATIVE_Z = 5,

    /// <include file='D3DCUBEMAP_FACES.xml' path='doc/member[@name="D3DCUBEMAP_FACES.D3DCUBEMAP_FACE_FORCE_DWORD"]/*' />
    D3DCUBEMAP_FACE_FORCE_DWORD = 0x7fffffff,
}
