// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3DTRANSFORMSTATETYPE.xml' path='doc/member[@name="D3DTRANSFORMSTATETYPE"]/*' />
public enum D3DTRANSFORMSTATETYPE
{
    /// <include file='D3DTRANSFORMSTATETYPE.xml' path='doc/member[@name="D3DTRANSFORMSTATETYPE.D3DTS_VIEW"]/*' />
    D3DTS_VIEW = 2,

    /// <include file='D3DTRANSFORMSTATETYPE.xml' path='doc/member[@name="D3DTRANSFORMSTATETYPE.D3DTS_PROJECTION"]/*' />
    D3DTS_PROJECTION = 3,

    /// <include file='D3DTRANSFORMSTATETYPE.xml' path='doc/member[@name="D3DTRANSFORMSTATETYPE.D3DTS_TEXTURE0"]/*' />
    D3DTS_TEXTURE0 = 16,

    /// <include file='D3DTRANSFORMSTATETYPE.xml' path='doc/member[@name="D3DTRANSFORMSTATETYPE.D3DTS_TEXTURE1"]/*' />
    D3DTS_TEXTURE1 = 17,

    /// <include file='D3DTRANSFORMSTATETYPE.xml' path='doc/member[@name="D3DTRANSFORMSTATETYPE.D3DTS_TEXTURE2"]/*' />
    D3DTS_TEXTURE2 = 18,

    /// <include file='D3DTRANSFORMSTATETYPE.xml' path='doc/member[@name="D3DTRANSFORMSTATETYPE.D3DTS_TEXTURE3"]/*' />
    D3DTS_TEXTURE3 = 19,

    /// <include file='D3DTRANSFORMSTATETYPE.xml' path='doc/member[@name="D3DTRANSFORMSTATETYPE.D3DTS_TEXTURE4"]/*' />
    D3DTS_TEXTURE4 = 20,

    /// <include file='D3DTRANSFORMSTATETYPE.xml' path='doc/member[@name="D3DTRANSFORMSTATETYPE.D3DTS_TEXTURE5"]/*' />
    D3DTS_TEXTURE5 = 21,

    /// <include file='D3DTRANSFORMSTATETYPE.xml' path='doc/member[@name="D3DTRANSFORMSTATETYPE.D3DTS_TEXTURE6"]/*' />
    D3DTS_TEXTURE6 = 22,

    /// <include file='D3DTRANSFORMSTATETYPE.xml' path='doc/member[@name="D3DTRANSFORMSTATETYPE.D3DTS_TEXTURE7"]/*' />
    D3DTS_TEXTURE7 = 23,

    /// <include file='D3DTRANSFORMSTATETYPE.xml' path='doc/member[@name="D3DTRANSFORMSTATETYPE.D3DTS_FORCE_DWORD"]/*' />
    D3DTS_FORCE_DWORD = 0x7fffffff,
}
