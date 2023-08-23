// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/dxgitype.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.DirectX;

/// <include file='DXGI_GAMMA_CONTROL.xml' path='doc/member[@name="DXGI_GAMMA_CONTROL"]/*' />
public partial struct DXGI_GAMMA_CONTROL
{
    /// <include file='DXGI_GAMMA_CONTROL.xml' path='doc/member[@name="DXGI_GAMMA_CONTROL.Scale"]/*' />
    public DXGI_RGB Scale;

    /// <include file='DXGI_GAMMA_CONTROL.xml' path='doc/member[@name="DXGI_GAMMA_CONTROL.Offset"]/*' />
    public DXGI_RGB Offset;

    /// <include file='DXGI_GAMMA_CONTROL.xml' path='doc/member[@name="DXGI_GAMMA_CONTROL.GammaCurve"]/*' />
    [NativeTypeName("DXGI_RGB[1025]")]
    public _GammaCurve_e__FixedBuffer GammaCurve;

    /// <include file='_GammaCurve_e__FixedBuffer.xml' path='doc/member[@name="_GammaCurve_e__FixedBuffer"]/*' />
    [InlineArray(1025)]
    public partial struct _GammaCurve_e__FixedBuffer
    {
        public DXGI_RGB e0;
    }
}
