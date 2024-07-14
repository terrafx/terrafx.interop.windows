// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dinput.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.DirectX;

/// <include file='DIJOYSTATE.xml' path='doc/member[@name="DIJOYSTATE"]/*' />
public partial struct DIJOYSTATE
{
    /// <include file='DIJOYSTATE.xml' path='doc/member[@name="DIJOYSTATE.lX"]/*' />
    [NativeTypeName("LONG")]
    public int lX;

    /// <include file='DIJOYSTATE.xml' path='doc/member[@name="DIJOYSTATE.lY"]/*' />
    [NativeTypeName("LONG")]
    public int lY;

    /// <include file='DIJOYSTATE.xml' path='doc/member[@name="DIJOYSTATE.lZ"]/*' />
    [NativeTypeName("LONG")]
    public int lZ;

    /// <include file='DIJOYSTATE.xml' path='doc/member[@name="DIJOYSTATE.lRx"]/*' />
    [NativeTypeName("LONG")]
    public int lRx;

    /// <include file='DIJOYSTATE.xml' path='doc/member[@name="DIJOYSTATE.lRy"]/*' />
    [NativeTypeName("LONG")]
    public int lRy;

    /// <include file='DIJOYSTATE.xml' path='doc/member[@name="DIJOYSTATE.lRz"]/*' />
    [NativeTypeName("LONG")]
    public int lRz;

    /// <include file='DIJOYSTATE.xml' path='doc/member[@name="DIJOYSTATE.rglSlider"]/*' />
    [NativeTypeName("LONG[2]")]
    public _rglSlider_e__FixedBuffer rglSlider;

    /// <include file='DIJOYSTATE.xml' path='doc/member[@name="DIJOYSTATE.rgdwPOV"]/*' />
    [NativeTypeName("DWORD[4]")]
    public _rgdwPOV_e__FixedBuffer rgdwPOV;

    /// <include file='DIJOYSTATE.xml' path='doc/member[@name="DIJOYSTATE.rgbButtons"]/*' />
    [NativeTypeName("BYTE[32]")]
    public _rgbButtons_e__FixedBuffer rgbButtons;

    /// <include file='_rglSlider_e__FixedBuffer.xml' path='doc/member[@name="_rglSlider_e__FixedBuffer"]/*' />
    [InlineArray(2)]
    public partial struct _rglSlider_e__FixedBuffer
    {
        public int e0;
    }

    /// <include file='_rgdwPOV_e__FixedBuffer.xml' path='doc/member[@name="_rgdwPOV_e__FixedBuffer"]/*' />
    [InlineArray(4)]
    public partial struct _rgdwPOV_e__FixedBuffer
    {
        public uint e0;
    }

    /// <include file='_rgbButtons_e__FixedBuffer.xml' path='doc/member[@name="_rgbButtons_e__FixedBuffer"]/*' />
    [InlineArray(32)]
    public partial struct _rgbButtons_e__FixedBuffer
    {
        public byte e0;
    }
}
