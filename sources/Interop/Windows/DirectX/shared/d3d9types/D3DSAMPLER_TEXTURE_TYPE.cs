// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3DSAMPLER_TEXTURE_TYPE.xml' path='doc/member[@name="D3DSAMPLER_TEXTURE_TYPE"]/*' />
public enum D3DSAMPLER_TEXTURE_TYPE
{
    /// <include file='D3DSAMPLER_TEXTURE_TYPE.xml' path='doc/member[@name="D3DSAMPLER_TEXTURE_TYPE.D3DSTT_UNKNOWN"]/*' />
    D3DSTT_UNKNOWN = 0 << 27,

    /// <include file='D3DSAMPLER_TEXTURE_TYPE.xml' path='doc/member[@name="D3DSAMPLER_TEXTURE_TYPE.D3DSTT_2D"]/*' />
    D3DSTT_2D = 2 << 27,

    /// <include file='D3DSAMPLER_TEXTURE_TYPE.xml' path='doc/member[@name="D3DSAMPLER_TEXTURE_TYPE.D3DSTT_CUBE"]/*' />
    D3DSTT_CUBE = 3 << 27,

    /// <include file='D3DSAMPLER_TEXTURE_TYPE.xml' path='doc/member[@name="D3DSAMPLER_TEXTURE_TYPE.D3DSTT_VOLUME"]/*' />
    D3DSTT_VOLUME = 4 << 27,

    /// <include file='D3DSAMPLER_TEXTURE_TYPE.xml' path='doc/member[@name="D3DSAMPLER_TEXTURE_TYPE.D3DSTT_FORCE_DWORD"]/*' />
    D3DSTT_FORCE_DWORD = 0x7fffffff,
}
