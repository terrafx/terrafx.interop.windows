// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dinput.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;

/// <include file='DIDEVICEIMAGEINFOW.xml' path='doc/member[@name="DIDEVICEIMAGEINFOW"]/*' />
public partial struct DIDEVICEIMAGEINFOW
{
    /// <include file='DIDEVICEIMAGEINFOW.xml' path='doc/member[@name="DIDEVICEIMAGEINFOW.tszImagePath"]/*' />
    [NativeTypeName("WCHAR[260]")]
    public _tszImagePath_e__FixedBuffer tszImagePath;

    /// <include file='DIDEVICEIMAGEINFOW.xml' path='doc/member[@name="DIDEVICEIMAGEINFOW.dwFlags"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwFlags;

    /// <include file='DIDEVICEIMAGEINFOW.xml' path='doc/member[@name="DIDEVICEIMAGEINFOW.dwViewID"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwViewID;

    /// <include file='DIDEVICEIMAGEINFOW.xml' path='doc/member[@name="DIDEVICEIMAGEINFOW.rcOverlay"]/*' />
    public RECT rcOverlay;

    /// <include file='DIDEVICEIMAGEINFOW.xml' path='doc/member[@name="DIDEVICEIMAGEINFOW.dwObjID"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwObjID;

    /// <include file='DIDEVICEIMAGEINFOW.xml' path='doc/member[@name="DIDEVICEIMAGEINFOW.dwcValidPts"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwcValidPts;

    /// <include file='DIDEVICEIMAGEINFOW.xml' path='doc/member[@name="DIDEVICEIMAGEINFOW.rgptCalloutLine"]/*' />
    [NativeTypeName("POINT[5]")]
    public _rgptCalloutLine_e__FixedBuffer rgptCalloutLine;

    /// <include file='DIDEVICEIMAGEINFOW.xml' path='doc/member[@name="DIDEVICEIMAGEINFOW.rcCalloutRect"]/*' />
    public RECT rcCalloutRect;

    /// <include file='DIDEVICEIMAGEINFOW.xml' path='doc/member[@name="DIDEVICEIMAGEINFOW.dwTextAlign"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwTextAlign;

    /// <include file='_tszImagePath_e__FixedBuffer.xml' path='doc/member[@name="_tszImagePath_e__FixedBuffer"]/*' />
    [InlineArray(260)]
    [Obsolete("Possible string represented as a fixed-sized buffer.")]
    public partial struct _tszImagePath_e__FixedBuffer
    {
        public char e0;
    }

    /// <include file='_rgptCalloutLine_e__FixedBuffer.xml' path='doc/member[@name="_rgptCalloutLine_e__FixedBuffer"]/*' />
    [InlineArray(5)]
    public partial struct _rgptCalloutLine_e__FixedBuffer
    {
        public POINT e0;
    }
}
