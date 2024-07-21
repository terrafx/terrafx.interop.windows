// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/dxgi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.DirectX;

/// <include file='DXGI_DISPLAY_COLOR_SPACE.xml' path='doc/member[@name="DXGI_DISPLAY_COLOR_SPACE"]/*' />
public partial struct DXGI_DISPLAY_COLOR_SPACE
{
    /// <include file='DXGI_DISPLAY_COLOR_SPACE.xml' path='doc/member[@name="DXGI_DISPLAY_COLOR_SPACE.PrimaryCoordinates"]/*' />
    [NativeTypeName("FLOAT[8][2]")]
    public _PrimaryCoordinates_e__FixedBuffer PrimaryCoordinates;

    /// <include file='DXGI_DISPLAY_COLOR_SPACE.xml' path='doc/member[@name="DXGI_DISPLAY_COLOR_SPACE.WhitePoints"]/*' />
    [NativeTypeName("FLOAT[16][2]")]
    public _WhitePoints_e__FixedBuffer WhitePoints;

    /// <include file='_PrimaryCoordinates_e__FixedBuffer.xml' path='doc/member[@name="_PrimaryCoordinates_e__FixedBuffer"]/*' />
    [InlineArray(8 * 2)]
    public partial struct _PrimaryCoordinates_e__FixedBuffer
    {
        public float e0_0;
    }

    /// <include file='_WhitePoints_e__FixedBuffer.xml' path='doc/member[@name="_WhitePoints_e__FixedBuffer"]/*' />
    [InlineArray(16 * 2)]
    public partial struct _WhitePoints_e__FixedBuffer
    {
        public float e0_0;
    }
}
