// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/shappmgr.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='APPINFODATA.xml' path='doc/member[@name="APPINFODATA"]/*' />
public unsafe partial struct APPINFODATA
{
    /// <include file='APPINFODATA.xml' path='doc/member[@name="APPINFODATA.cbSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbSize;

    /// <include file='APPINFODATA.xml' path='doc/member[@name="APPINFODATA.dwMask"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwMask;

    /// <include file='APPINFODATA.xml' path='doc/member[@name="APPINFODATA.pszDisplayName"]/*' />
    [NativeTypeName("LPWSTR")]
    public char* pszDisplayName;

    /// <include file='APPINFODATA.xml' path='doc/member[@name="APPINFODATA.pszVersion"]/*' />
    [NativeTypeName("LPWSTR")]
    public char* pszVersion;

    /// <include file='APPINFODATA.xml' path='doc/member[@name="APPINFODATA.pszPublisher"]/*' />
    [NativeTypeName("LPWSTR")]
    public char* pszPublisher;

    /// <include file='APPINFODATA.xml' path='doc/member[@name="APPINFODATA.pszProductID"]/*' />
    [NativeTypeName("LPWSTR")]
    public char* pszProductID;

    /// <include file='APPINFODATA.xml' path='doc/member[@name="APPINFODATA.pszRegisteredOwner"]/*' />
    [NativeTypeName("LPWSTR")]
    public char* pszRegisteredOwner;

    /// <include file='APPINFODATA.xml' path='doc/member[@name="APPINFODATA.pszRegisteredCompany"]/*' />
    [NativeTypeName("LPWSTR")]
    public char* pszRegisteredCompany;

    /// <include file='APPINFODATA.xml' path='doc/member[@name="APPINFODATA.pszLanguage"]/*' />
    [NativeTypeName("LPWSTR")]
    public char* pszLanguage;

    /// <include file='APPINFODATA.xml' path='doc/member[@name="APPINFODATA.pszSupportUrl"]/*' />
    [NativeTypeName("LPWSTR")]
    public char* pszSupportUrl;

    /// <include file='APPINFODATA.xml' path='doc/member[@name="APPINFODATA.pszSupportTelephone"]/*' />
    [NativeTypeName("LPWSTR")]
    public char* pszSupportTelephone;

    /// <include file='APPINFODATA.xml' path='doc/member[@name="APPINFODATA.pszHelpLink"]/*' />
    [NativeTypeName("LPWSTR")]
    public char* pszHelpLink;

    /// <include file='APPINFODATA.xml' path='doc/member[@name="APPINFODATA.pszInstallLocation"]/*' />
    [NativeTypeName("LPWSTR")]
    public char* pszInstallLocation;

    /// <include file='APPINFODATA.xml' path='doc/member[@name="APPINFODATA.pszInstallSource"]/*' />
    [NativeTypeName("LPWSTR")]
    public char* pszInstallSource;

    /// <include file='APPINFODATA.xml' path='doc/member[@name="APPINFODATA.pszInstallDate"]/*' />
    [NativeTypeName("LPWSTR")]
    public char* pszInstallDate;

    /// <include file='APPINFODATA.xml' path='doc/member[@name="APPINFODATA.pszContact"]/*' />
    [NativeTypeName("LPWSTR")]
    public char* pszContact;

    /// <include file='APPINFODATA.xml' path='doc/member[@name="APPINFODATA.pszComments"]/*' />
    [NativeTypeName("LPWSTR")]
    public char* pszComments;

    /// <include file='APPINFODATA.xml' path='doc/member[@name="APPINFODATA.pszImage"]/*' />
    [NativeTypeName("LPWSTR")]
    public char* pszImage;

    /// <include file='APPINFODATA.xml' path='doc/member[@name="APPINFODATA.pszReadmeUrl"]/*' />
    [NativeTypeName("LPWSTR")]
    public char* pszReadmeUrl;

    /// <include file='APPINFODATA.xml' path='doc/member[@name="APPINFODATA.pszUpdateInfoUrl"]/*' />
    [NativeTypeName("LPWSTR")]
    public char* pszUpdateInfoUrl;
}
