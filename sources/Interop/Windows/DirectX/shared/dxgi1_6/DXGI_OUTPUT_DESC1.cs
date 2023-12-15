// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/dxgi1_6.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;

/// <include file='DXGI_OUTPUT_DESC1.xml' path='doc/member[@name="DXGI_OUTPUT_DESC1"]/*' />
public partial struct DXGI_OUTPUT_DESC1
{
    /// <include file='DXGI_OUTPUT_DESC1.xml' path='doc/member[@name="DXGI_OUTPUT_DESC1.DeviceName"]/*' />
    [NativeTypeName("WCHAR[32]")]
    public _DeviceName_e__FixedBuffer DeviceName;

    /// <include file='DXGI_OUTPUT_DESC1.xml' path='doc/member[@name="DXGI_OUTPUT_DESC1.DesktopCoordinates"]/*' />
    public RECT DesktopCoordinates;

    /// <include file='DXGI_OUTPUT_DESC1.xml' path='doc/member[@name="DXGI_OUTPUT_DESC1.AttachedToDesktop"]/*' />
    public BOOL AttachedToDesktop;

    /// <include file='DXGI_OUTPUT_DESC1.xml' path='doc/member[@name="DXGI_OUTPUT_DESC1.Rotation"]/*' />
    public DXGI_MODE_ROTATION Rotation;

    /// <include file='DXGI_OUTPUT_DESC1.xml' path='doc/member[@name="DXGI_OUTPUT_DESC1.Monitor"]/*' />
    public HMONITOR Monitor;

    /// <include file='DXGI_OUTPUT_DESC1.xml' path='doc/member[@name="DXGI_OUTPUT_DESC1.BitsPerColor"]/*' />
    public uint BitsPerColor;

    /// <include file='DXGI_OUTPUT_DESC1.xml' path='doc/member[@name="DXGI_OUTPUT_DESC1.ColorSpace"]/*' />
    public DXGI_COLOR_SPACE_TYPE ColorSpace;

    /// <include file='DXGI_OUTPUT_DESC1.xml' path='doc/member[@name="DXGI_OUTPUT_DESC1.RedPrimary"]/*' />
    [NativeTypeName("FLOAT[2]")]
    public _RedPrimary_e__FixedBuffer RedPrimary;

    /// <include file='DXGI_OUTPUT_DESC1.xml' path='doc/member[@name="DXGI_OUTPUT_DESC1.GreenPrimary"]/*' />
    [NativeTypeName("FLOAT[2]")]
    public _GreenPrimary_e__FixedBuffer GreenPrimary;

    /// <include file='DXGI_OUTPUT_DESC1.xml' path='doc/member[@name="DXGI_OUTPUT_DESC1.BluePrimary"]/*' />
    [NativeTypeName("FLOAT[2]")]
    public _BluePrimary_e__FixedBuffer BluePrimary;

    /// <include file='DXGI_OUTPUT_DESC1.xml' path='doc/member[@name="DXGI_OUTPUT_DESC1.WhitePoint"]/*' />
    [NativeTypeName("FLOAT[2]")]
    public _WhitePoint_e__FixedBuffer WhitePoint;

    /// <include file='DXGI_OUTPUT_DESC1.xml' path='doc/member[@name="DXGI_OUTPUT_DESC1.MinLuminance"]/*' />
    public float MinLuminance;

    /// <include file='DXGI_OUTPUT_DESC1.xml' path='doc/member[@name="DXGI_OUTPUT_DESC1.MaxLuminance"]/*' />
    public float MaxLuminance;

    /// <include file='DXGI_OUTPUT_DESC1.xml' path='doc/member[@name="DXGI_OUTPUT_DESC1.MaxFullFrameLuminance"]/*' />
    public float MaxFullFrameLuminance;

    /// <include file='_DeviceName_e__FixedBuffer.xml' path='doc/member[@name="_DeviceName_e__FixedBuffer"]/*' />
    [InlineArray(32)]
    [Obsolete("Possible string represented as a fixed-sized buffer.")]
    public partial struct _DeviceName_e__FixedBuffer
    {
        public char e0;
    }

    /// <include file='_RedPrimary_e__FixedBuffer.xml' path='doc/member[@name="_RedPrimary_e__FixedBuffer"]/*' />
    [InlineArray(2)]
    public partial struct _RedPrimary_e__FixedBuffer
    {
        public float e0;
    }

    /// <include file='_GreenPrimary_e__FixedBuffer.xml' path='doc/member[@name="_GreenPrimary_e__FixedBuffer"]/*' />
    [InlineArray(2)]
    public partial struct _GreenPrimary_e__FixedBuffer
    {
        public float e0;
    }

    /// <include file='_BluePrimary_e__FixedBuffer.xml' path='doc/member[@name="_BluePrimary_e__FixedBuffer"]/*' />
    [InlineArray(2)]
    public partial struct _BluePrimary_e__FixedBuffer
    {
        public float e0;
    }

    /// <include file='_WhitePoint_e__FixedBuffer.xml' path='doc/member[@name="_WhitePoint_e__FixedBuffer"]/*' />
    [InlineArray(2)]
    public partial struct _WhitePoint_e__FixedBuffer
    {
        public float e0;
    }
}
