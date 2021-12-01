// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/dxgicommon.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='DXGI_SAMPLE_DESC.xml' path='doc/member[@name="DXGI_SAMPLE_DESC"]/*' />
public partial struct DXGI_SAMPLE_DESC
{
    /// <include file='DXGI_SAMPLE_DESC.xml' path='doc/member[@name="DXGI_SAMPLE_DESC.Count"]/*' />
    public uint Count;

    /// <include file='DXGI_SAMPLE_DESC.xml' path='doc/member[@name="DXGI_SAMPLE_DESC.Quality"]/*' />
    public uint Quality;
}
