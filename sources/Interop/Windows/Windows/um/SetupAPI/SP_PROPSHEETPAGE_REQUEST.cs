// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='SP_PROPSHEETPAGE_REQUEST.xml' path='doc/member[@name="SP_PROPSHEETPAGE_REQUEST"]/*' />
public unsafe partial struct SP_PROPSHEETPAGE_REQUEST
{
    /// <include file='SP_PROPSHEETPAGE_REQUEST.xml' path='doc/member[@name="SP_PROPSHEETPAGE_REQUEST.cbSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbSize;

    /// <include file='SP_PROPSHEETPAGE_REQUEST.xml' path='doc/member[@name="SP_PROPSHEETPAGE_REQUEST.PageRequested"]/*' />
    [NativeTypeName("DWORD")]
    public uint PageRequested;

    /// <include file='SP_PROPSHEETPAGE_REQUEST.xml' path='doc/member[@name="SP_PROPSHEETPAGE_REQUEST.DeviceInfoSet"]/*' />
    public HDEVINFO DeviceInfoSet;

    /// <include file='SP_PROPSHEETPAGE_REQUEST.xml' path='doc/member[@name="SP_PROPSHEETPAGE_REQUEST.DeviceInfoData"]/*' />
    [NativeTypeName("PSP_DEVINFO_DATA")]
    public SP_DEVINFO_DATA* DeviceInfoData;
}
