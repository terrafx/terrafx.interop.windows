// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='DISPLAY_DEVICEW.xml' path='doc/member[@name="DISPLAY_DEVICEW"]/*' />
public partial struct DISPLAY_DEVICEW
{
    /// <include file='DISPLAY_DEVICEW.xml' path='doc/member[@name="DISPLAY_DEVICEW.cb"]/*' />
    [NativeTypeName("DWORD")]
    public uint cb;

    /// <include file='DISPLAY_DEVICEW.xml' path='doc/member[@name="DISPLAY_DEVICEW.DeviceName"]/*' />
    [NativeTypeName("WCHAR[32]")]
    public _DeviceName_e__FixedBuffer DeviceName;

    /// <include file='DISPLAY_DEVICEW.xml' path='doc/member[@name="DISPLAY_DEVICEW.DeviceString"]/*' />
    [NativeTypeName("WCHAR[128]")]
    public _DeviceString_e__FixedBuffer DeviceString;

    /// <include file='DISPLAY_DEVICEW.xml' path='doc/member[@name="DISPLAY_DEVICEW.StateFlags"]/*' />
    [NativeTypeName("DWORD")]
    public uint StateFlags;

    /// <include file='DISPLAY_DEVICEW.xml' path='doc/member[@name="DISPLAY_DEVICEW.DeviceID"]/*' />
    [NativeTypeName("WCHAR[128]")]
    public _DeviceID_e__FixedBuffer DeviceID;

    /// <include file='DISPLAY_DEVICEW.xml' path='doc/member[@name="DISPLAY_DEVICEW.DeviceKey"]/*' />
    [NativeTypeName("WCHAR[128]")]
    public _DeviceKey_e__FixedBuffer DeviceKey;

    /// <include file='_DeviceName_e__FixedBuffer.xml' path='doc/member[@name="_DeviceName_e__FixedBuffer"]/*' />
    [InlineArray(32)]
    [Obsolete("Possible string represented as a fixed-sized buffer.")]
    public partial struct _DeviceName_e__FixedBuffer
    {
        public char e0;
    }

    /// <include file='_DeviceString_e__FixedBuffer.xml' path='doc/member[@name="_DeviceString_e__FixedBuffer"]/*' />
    [InlineArray(128)]
    [Obsolete("Possible string represented as a fixed-sized buffer.")]
    public partial struct _DeviceString_e__FixedBuffer
    {
        public char e0;
    }

    /// <include file='_DeviceID_e__FixedBuffer.xml' path='doc/member[@name="_DeviceID_e__FixedBuffer"]/*' />
    [InlineArray(128)]
    [Obsolete("Possible string represented as a fixed-sized buffer.")]
    public partial struct _DeviceID_e__FixedBuffer
    {
        public char e0;
    }

    /// <include file='_DeviceKey_e__FixedBuffer.xml' path='doc/member[@name="_DeviceKey_e__FixedBuffer"]/*' />
    [InlineArray(128)]
    [Obsolete("Possible string represented as a fixed-sized buffer.")]
    public partial struct _DeviceKey_e__FixedBuffer
    {
        public char e0;
    }
}
