// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dinput.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.DirectX;

/// <include file='DIJOYSTATE2.xml' path='doc/member[@name="DIJOYSTATE2"]/*' />
public partial struct DIJOYSTATE2
{
    /// <include file='DIJOYSTATE2.xml' path='doc/member[@name="DIJOYSTATE2.lX"]/*' />
    [NativeTypeName("LONG")]
    public int lX;

    /// <include file='DIJOYSTATE2.xml' path='doc/member[@name="DIJOYSTATE2.lY"]/*' />
    [NativeTypeName("LONG")]
    public int lY;

    /// <include file='DIJOYSTATE2.xml' path='doc/member[@name="DIJOYSTATE2.lZ"]/*' />
    [NativeTypeName("LONG")]
    public int lZ;

    /// <include file='DIJOYSTATE2.xml' path='doc/member[@name="DIJOYSTATE2.lRx"]/*' />
    [NativeTypeName("LONG")]
    public int lRx;

    /// <include file='DIJOYSTATE2.xml' path='doc/member[@name="DIJOYSTATE2.lRy"]/*' />
    [NativeTypeName("LONG")]
    public int lRy;

    /// <include file='DIJOYSTATE2.xml' path='doc/member[@name="DIJOYSTATE2.lRz"]/*' />
    [NativeTypeName("LONG")]
    public int lRz;

    /// <include file='DIJOYSTATE2.xml' path='doc/member[@name="DIJOYSTATE2.rglSlider"]/*' />
    [NativeTypeName("LONG[2]")]
    public _rglSlider_e__FixedBuffer rglSlider;

    /// <include file='DIJOYSTATE2.xml' path='doc/member[@name="DIJOYSTATE2.rgdwPOV"]/*' />
    [NativeTypeName("DWORD[4]")]
    public _rgdwPOV_e__FixedBuffer rgdwPOV;

    /// <include file='DIJOYSTATE2.xml' path='doc/member[@name="DIJOYSTATE2.rgbButtons"]/*' />
    [NativeTypeName("BYTE[128]")]
    public _rgbButtons_e__FixedBuffer rgbButtons;

    /// <include file='DIJOYSTATE2.xml' path='doc/member[@name="DIJOYSTATE2.lVX"]/*' />
    [NativeTypeName("LONG")]
    public int lVX;

    /// <include file='DIJOYSTATE2.xml' path='doc/member[@name="DIJOYSTATE2.lVY"]/*' />
    [NativeTypeName("LONG")]
    public int lVY;

    /// <include file='DIJOYSTATE2.xml' path='doc/member[@name="DIJOYSTATE2.lVZ"]/*' />
    [NativeTypeName("LONG")]
    public int lVZ;

    /// <include file='DIJOYSTATE2.xml' path='doc/member[@name="DIJOYSTATE2.lVRx"]/*' />
    [NativeTypeName("LONG")]
    public int lVRx;

    /// <include file='DIJOYSTATE2.xml' path='doc/member[@name="DIJOYSTATE2.lVRy"]/*' />
    [NativeTypeName("LONG")]
    public int lVRy;

    /// <include file='DIJOYSTATE2.xml' path='doc/member[@name="DIJOYSTATE2.lVRz"]/*' />
    [NativeTypeName("LONG")]
    public int lVRz;

    /// <include file='DIJOYSTATE2.xml' path='doc/member[@name="DIJOYSTATE2.rglVSlider"]/*' />
    [NativeTypeName("LONG[2]")]
    public _rglVSlider_e__FixedBuffer rglVSlider;

    /// <include file='DIJOYSTATE2.xml' path='doc/member[@name="DIJOYSTATE2.lAX"]/*' />
    [NativeTypeName("LONG")]
    public int lAX;

    /// <include file='DIJOYSTATE2.xml' path='doc/member[@name="DIJOYSTATE2.lAY"]/*' />
    [NativeTypeName("LONG")]
    public int lAY;

    /// <include file='DIJOYSTATE2.xml' path='doc/member[@name="DIJOYSTATE2.lAZ"]/*' />
    [NativeTypeName("LONG")]
    public int lAZ;

    /// <include file='DIJOYSTATE2.xml' path='doc/member[@name="DIJOYSTATE2.lARx"]/*' />
    [NativeTypeName("LONG")]
    public int lARx;

    /// <include file='DIJOYSTATE2.xml' path='doc/member[@name="DIJOYSTATE2.lARy"]/*' />
    [NativeTypeName("LONG")]
    public int lARy;

    /// <include file='DIJOYSTATE2.xml' path='doc/member[@name="DIJOYSTATE2.lARz"]/*' />
    [NativeTypeName("LONG")]
    public int lARz;

    /// <include file='DIJOYSTATE2.xml' path='doc/member[@name="DIJOYSTATE2.rglASlider"]/*' />
    [NativeTypeName("LONG[2]")]
    public _rglASlider_e__FixedBuffer rglASlider;

    /// <include file='DIJOYSTATE2.xml' path='doc/member[@name="DIJOYSTATE2.lFX"]/*' />
    [NativeTypeName("LONG")]
    public int lFX;

    /// <include file='DIJOYSTATE2.xml' path='doc/member[@name="DIJOYSTATE2.lFY"]/*' />
    [NativeTypeName("LONG")]
    public int lFY;

    /// <include file='DIJOYSTATE2.xml' path='doc/member[@name="DIJOYSTATE2.lFZ"]/*' />
    [NativeTypeName("LONG")]
    public int lFZ;

    /// <include file='DIJOYSTATE2.xml' path='doc/member[@name="DIJOYSTATE2.lFRx"]/*' />
    [NativeTypeName("LONG")]
    public int lFRx;

    /// <include file='DIJOYSTATE2.xml' path='doc/member[@name="DIJOYSTATE2.lFRy"]/*' />
    [NativeTypeName("LONG")]
    public int lFRy;

    /// <include file='DIJOYSTATE2.xml' path='doc/member[@name="DIJOYSTATE2.lFRz"]/*' />
    [NativeTypeName("LONG")]
    public int lFRz;

    /// <include file='DIJOYSTATE2.xml' path='doc/member[@name="DIJOYSTATE2.rglFSlider"]/*' />
    [NativeTypeName("LONG[2]")]
    public _rglFSlider_e__FixedBuffer rglFSlider;

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
    [InlineArray(128)]
    public partial struct _rgbButtons_e__FixedBuffer
    {
        public byte e0;
    }

    /// <include file='_rglVSlider_e__FixedBuffer.xml' path='doc/member[@name="_rglVSlider_e__FixedBuffer"]/*' />
    [InlineArray(2)]
    public partial struct _rglVSlider_e__FixedBuffer
    {
        public int e0;
    }

    /// <include file='_rglASlider_e__FixedBuffer.xml' path='doc/member[@name="_rglASlider_e__FixedBuffer"]/*' />
    [InlineArray(2)]
    public partial struct _rglASlider_e__FixedBuffer
    {
        public int e0;
    }

    /// <include file='_rglFSlider_e__FixedBuffer.xml' path='doc/member[@name="_rglFSlider_e__FixedBuffer"]/*' />
    [InlineArray(2)]
    public partial struct _rglFSlider_e__FixedBuffer
    {
        public int e0;
    }
}
