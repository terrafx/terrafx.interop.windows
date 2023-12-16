// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3DVERTEXBLENDFLAGS.xml' path='doc/member[@name="D3DVERTEXBLENDFLAGS"]/*' />
public enum D3DVERTEXBLENDFLAGS
{
    /// <include file='D3DVERTEXBLENDFLAGS.xml' path='doc/member[@name="D3DVERTEXBLENDFLAGS.D3DVBF_DISABLE"]/*' />
    D3DVBF_DISABLE = 0,

    /// <include file='D3DVERTEXBLENDFLAGS.xml' path='doc/member[@name="D3DVERTEXBLENDFLAGS.D3DVBF_1WEIGHTS"]/*' />
    D3DVBF_1WEIGHTS = 1,

    /// <include file='D3DVERTEXBLENDFLAGS.xml' path='doc/member[@name="D3DVERTEXBLENDFLAGS.D3DVBF_2WEIGHTS"]/*' />
    D3DVBF_2WEIGHTS = 2,

    /// <include file='D3DVERTEXBLENDFLAGS.xml' path='doc/member[@name="D3DVERTEXBLENDFLAGS.D3DVBF_3WEIGHTS"]/*' />
    D3DVBF_3WEIGHTS = 3,

    /// <include file='D3DVERTEXBLENDFLAGS.xml' path='doc/member[@name="D3DVERTEXBLENDFLAGS.D3DVBF_TWEENING"]/*' />
    D3DVBF_TWEENING = 255,

    /// <include file='D3DVERTEXBLENDFLAGS.xml' path='doc/member[@name="D3DVERTEXBLENDFLAGS.D3DVBF_0WEIGHTS"]/*' />
    D3DVBF_0WEIGHTS = 256,

    /// <include file='D3DVERTEXBLENDFLAGS.xml' path='doc/member[@name="D3DVERTEXBLENDFLAGS.D3DVBF_FORCE_DWORD"]/*' />
    D3DVBF_FORCE_DWORD = 0x7fffffff,
}
