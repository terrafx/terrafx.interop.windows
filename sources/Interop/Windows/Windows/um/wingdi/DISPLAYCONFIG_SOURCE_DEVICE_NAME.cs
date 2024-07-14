// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='DISPLAYCONFIG_SOURCE_DEVICE_NAME.xml' path='doc/member[@name="DISPLAYCONFIG_SOURCE_DEVICE_NAME"]/*' />
public partial struct DISPLAYCONFIG_SOURCE_DEVICE_NAME
{
    /// <include file='DISPLAYCONFIG_SOURCE_DEVICE_NAME.xml' path='doc/member[@name="DISPLAYCONFIG_SOURCE_DEVICE_NAME.header"]/*' />
    public DISPLAYCONFIG_DEVICE_INFO_HEADER header;

    /// <include file='DISPLAYCONFIG_SOURCE_DEVICE_NAME.xml' path='doc/member[@name="DISPLAYCONFIG_SOURCE_DEVICE_NAME.viewGdiDeviceName"]/*' />
    [NativeTypeName("WCHAR[32]")]
    public _viewGdiDeviceName_e__FixedBuffer viewGdiDeviceName;

    /// <include file='_viewGdiDeviceName_e__FixedBuffer.xml' path='doc/member[@name="_viewGdiDeviceName_e__FixedBuffer"]/*' />
    [InlineArray(32)]
    public partial struct _viewGdiDeviceName_e__FixedBuffer
    {
        public char e0;
    }
}
