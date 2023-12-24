// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3DVS_RASTOUT_OFFSETS.xml' path='doc/member[@name="D3DVS_RASTOUT_OFFSETS"]/*' />
public enum D3DVS_RASTOUT_OFFSETS
{
    /// <include file='D3DVS_RASTOUT_OFFSETS.xml' path='doc/member[@name="D3DVS_RASTOUT_OFFSETS.D3DSRO_POSITION"]/*' />
    D3DSRO_POSITION = 0,

    /// <include file='D3DVS_RASTOUT_OFFSETS.xml' path='doc/member[@name="D3DVS_RASTOUT_OFFSETS.D3DSRO_FOG"]/*' />
    D3DSRO_FOG,

    /// <include file='D3DVS_RASTOUT_OFFSETS.xml' path='doc/member[@name="D3DVS_RASTOUT_OFFSETS.D3DSRO_POINT_SIZE"]/*' />
    D3DSRO_POINT_SIZE,

    /// <include file='D3DVS_RASTOUT_OFFSETS.xml' path='doc/member[@name="D3DVS_RASTOUT_OFFSETS.D3DSRO_FORCE_DWORD"]/*' />
    D3DSRO_FORCE_DWORD = 0x7fffffff,
}
