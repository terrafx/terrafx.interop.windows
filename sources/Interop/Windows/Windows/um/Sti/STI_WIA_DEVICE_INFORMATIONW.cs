// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Sti.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='STI_WIA_DEVICE_INFORMATIONW.xml' path='doc/member[@name="STI_WIA_DEVICE_INFORMATIONW"]/*' />
public unsafe partial struct STI_WIA_DEVICE_INFORMATIONW
{
    /// <include file='STI_WIA_DEVICE_INFORMATIONW.xml' path='doc/member[@name="STI_WIA_DEVICE_INFORMATIONW.dwSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwSize;

    /// <include file='STI_WIA_DEVICE_INFORMATIONW.xml' path='doc/member[@name="STI_WIA_DEVICE_INFORMATIONW.DeviceType"]/*' />
    [NativeTypeName("STI_DEVICE_TYPE")]
    public uint DeviceType;

    /// <include file='STI_WIA_DEVICE_INFORMATIONW.xml' path='doc/member[@name="STI_WIA_DEVICE_INFORMATIONW.szDeviceInternalName"]/*' />
    [NativeTypeName("WCHAR[128]")]
    public _szDeviceInternalName_e__FixedBuffer szDeviceInternalName;

    /// <include file='STI_WIA_DEVICE_INFORMATIONW.xml' path='doc/member[@name="STI_WIA_DEVICE_INFORMATIONW.DeviceCapabilitiesW"]/*' />
    public STI_DEV_CAPS DeviceCapabilitiesW;

    /// <include file='STI_WIA_DEVICE_INFORMATIONW.xml' path='doc/member[@name="STI_WIA_DEVICE_INFORMATIONW.dwHardwareConfiguration"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwHardwareConfiguration;

    /// <include file='STI_WIA_DEVICE_INFORMATIONW.xml' path='doc/member[@name="STI_WIA_DEVICE_INFORMATIONW.pszVendorDescription"]/*' />
    [NativeTypeName("LPWSTR")]
    public char* pszVendorDescription;

    /// <include file='STI_WIA_DEVICE_INFORMATIONW.xml' path='doc/member[@name="STI_WIA_DEVICE_INFORMATIONW.pszDeviceDescription"]/*' />
    [NativeTypeName("LPWSTR")]
    public char* pszDeviceDescription;

    /// <include file='STI_WIA_DEVICE_INFORMATIONW.xml' path='doc/member[@name="STI_WIA_DEVICE_INFORMATIONW.pszPortName"]/*' />
    [NativeTypeName("LPWSTR")]
    public char* pszPortName;

    /// <include file='STI_WIA_DEVICE_INFORMATIONW.xml' path='doc/member[@name="STI_WIA_DEVICE_INFORMATIONW.pszPropProvider"]/*' />
    [NativeTypeName("LPWSTR")]
    public char* pszPropProvider;

    /// <include file='STI_WIA_DEVICE_INFORMATIONW.xml' path='doc/member[@name="STI_WIA_DEVICE_INFORMATIONW.pszLocalName"]/*' />
    [NativeTypeName("LPWSTR")]
    public char* pszLocalName;

    /// <include file='STI_WIA_DEVICE_INFORMATIONW.xml' path='doc/member[@name="STI_WIA_DEVICE_INFORMATIONW.pszUiDll"]/*' />
    [NativeTypeName("LPWSTR")]
    public char* pszUiDll;

    /// <include file='STI_WIA_DEVICE_INFORMATIONW.xml' path='doc/member[@name="STI_WIA_DEVICE_INFORMATIONW.pszServer"]/*' />
    [NativeTypeName("LPWSTR")]
    public char* pszServer;

    /// <include file='_szDeviceInternalName_e__FixedBuffer.xml' path='doc/member[@name="_szDeviceInternalName_e__FixedBuffer"]/*' />
    [InlineArray(128)]
    public partial struct _szDeviceInternalName_e__FixedBuffer
    {
        public char e0;
    }
}
