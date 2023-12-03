// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='DISPLAYCONFIG_TARGET_DEVICE_NAME.xml' path='doc/member[@name="DISPLAYCONFIG_TARGET_DEVICE_NAME"]/*' />
public partial struct DISPLAYCONFIG_TARGET_DEVICE_NAME
{
    /// <include file='DISPLAYCONFIG_TARGET_DEVICE_NAME.xml' path='doc/member[@name="DISPLAYCONFIG_TARGET_DEVICE_NAME.header"]/*' />
    public DISPLAYCONFIG_DEVICE_INFO_HEADER header;

    /// <include file='DISPLAYCONFIG_TARGET_DEVICE_NAME.xml' path='doc/member[@name="DISPLAYCONFIG_TARGET_DEVICE_NAME.flags"]/*' />
    public DISPLAYCONFIG_TARGET_DEVICE_NAME_FLAGS flags;

    /// <include file='DISPLAYCONFIG_TARGET_DEVICE_NAME.xml' path='doc/member[@name="DISPLAYCONFIG_TARGET_DEVICE_NAME.outputTechnology"]/*' />
    public DISPLAYCONFIG_VIDEO_OUTPUT_TECHNOLOGY outputTechnology;

    /// <include file='DISPLAYCONFIG_TARGET_DEVICE_NAME.xml' path='doc/member[@name="DISPLAYCONFIG_TARGET_DEVICE_NAME.edidManufactureId"]/*' />
    [NativeTypeName("UINT16")]
    public ushort edidManufactureId;

    /// <include file='DISPLAYCONFIG_TARGET_DEVICE_NAME.xml' path='doc/member[@name="DISPLAYCONFIG_TARGET_DEVICE_NAME.edidProductCodeId"]/*' />
    [NativeTypeName("UINT16")]
    public ushort edidProductCodeId;

    /// <include file='DISPLAYCONFIG_TARGET_DEVICE_NAME.xml' path='doc/member[@name="DISPLAYCONFIG_TARGET_DEVICE_NAME.connectorInstance"]/*' />
    [NativeTypeName("UINT32")]
    public uint connectorInstance;

    /// <include file='DISPLAYCONFIG_TARGET_DEVICE_NAME.xml' path='doc/member[@name="DISPLAYCONFIG_TARGET_DEVICE_NAME.monitorFriendlyDeviceName"]/*' />
    [NativeTypeName("WCHAR[64]")]
    public _monitorFriendlyDeviceName_e__FixedBuffer monitorFriendlyDeviceName;

    /// <include file='DISPLAYCONFIG_TARGET_DEVICE_NAME.xml' path='doc/member[@name="DISPLAYCONFIG_TARGET_DEVICE_NAME.monitorDevicePath"]/*' />
    [NativeTypeName("WCHAR[128]")]
    public _monitorDevicePath_e__FixedBuffer monitorDevicePath;

    /// <include file='_monitorFriendlyDeviceName_e__FixedBuffer.xml' path='doc/member[@name="_monitorFriendlyDeviceName_e__FixedBuffer"]/*' />
    [InlineArray(64)]
    public partial struct _monitorFriendlyDeviceName_e__FixedBuffer
    {
        public char e0;
    }

    /// <include file='_monitorDevicePath_e__FixedBuffer.xml' path='doc/member[@name="_monitorDevicePath_e__FixedBuffer"]/*' />
    [InlineArray(128)]
    public partial struct _monitorDevicePath_e__FixedBuffer
    {
        public char e0;
    }
}
