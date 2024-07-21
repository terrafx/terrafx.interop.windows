// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='DISPLAY_DEVICEA.xml' path='doc/member[@name="DISPLAY_DEVICEA"]/*' />
public partial struct DISPLAY_DEVICEA
{
    /// <include file='DISPLAY_DEVICEA.xml' path='doc/member[@name="DISPLAY_DEVICEA.cb"]/*' />
    [NativeTypeName("DWORD")]
    public uint cb;

    /// <include file='DISPLAY_DEVICEA.xml' path='doc/member[@name="DISPLAY_DEVICEA.DeviceName"]/*' />
    [NativeTypeName("CHAR[32]")]
    public _DeviceName_e__FixedBuffer DeviceName;

    /// <include file='DISPLAY_DEVICEA.xml' path='doc/member[@name="DISPLAY_DEVICEA.DeviceString"]/*' />
    [NativeTypeName("CHAR[128]")]
    public _DeviceString_e__FixedBuffer DeviceString;

    /// <include file='DISPLAY_DEVICEA.xml' path='doc/member[@name="DISPLAY_DEVICEA.StateFlags"]/*' />
    [NativeTypeName("DWORD")]
    public uint StateFlags;

    /// <include file='DISPLAY_DEVICEA.xml' path='doc/member[@name="DISPLAY_DEVICEA.DeviceID"]/*' />
    [NativeTypeName("CHAR[128]")]
    public _DeviceID_e__FixedBuffer DeviceID;

    /// <include file='DISPLAY_DEVICEA.xml' path='doc/member[@name="DISPLAY_DEVICEA.DeviceKey"]/*' />
    [NativeTypeName("CHAR[128]")]
    public _DeviceKey_e__FixedBuffer DeviceKey;

    /// <include file='_DeviceName_e__FixedBuffer.xml' path='doc/member[@name="_DeviceName_e__FixedBuffer"]/*' />
    [InlineArray(32)]
    public partial struct _DeviceName_e__FixedBuffer
    {
        public sbyte e0;
    }

    /// <include file='_DeviceString_e__FixedBuffer.xml' path='doc/member[@name="_DeviceString_e__FixedBuffer"]/*' />
    [InlineArray(128)]
    public partial struct _DeviceString_e__FixedBuffer
    {
        public sbyte e0;
    }

    /// <include file='_DeviceID_e__FixedBuffer.xml' path='doc/member[@name="_DeviceID_e__FixedBuffer"]/*' />
    [InlineArray(128)]
    public partial struct _DeviceID_e__FixedBuffer
    {
        public sbyte e0;
    }

    /// <include file='_DeviceKey_e__FixedBuffer.xml' path='doc/member[@name="_DeviceKey_e__FixedBuffer"]/*' />
    [InlineArray(128)]
    public partial struct _DeviceKey_e__FixedBuffer
    {
        public sbyte e0;
    }
}
