// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.Windows;

/// <include file='KNOWNFOLDER_DEFINITION.xml' path='doc/member[@name="KNOWNFOLDER_DEFINITION"]/*' />
public unsafe partial struct KNOWNFOLDER_DEFINITION
{
    /// <include file='KNOWNFOLDER_DEFINITION.xml' path='doc/member[@name="KNOWNFOLDER_DEFINITION.category"]/*' />
    public KF_CATEGORY category;

    /// <include file='KNOWNFOLDER_DEFINITION.xml' path='doc/member[@name="KNOWNFOLDER_DEFINITION.pszName"]/*' />
    [NativeTypeName("LPWSTR")]
    public char* pszName;

    /// <include file='KNOWNFOLDER_DEFINITION.xml' path='doc/member[@name="KNOWNFOLDER_DEFINITION.pszDescription"]/*' />
    [NativeTypeName("LPWSTR")]
    public char* pszDescription;

    /// <include file='KNOWNFOLDER_DEFINITION.xml' path='doc/member[@name="KNOWNFOLDER_DEFINITION.fidParent"]/*' />
    [NativeTypeName("KNOWNFOLDERID")]
    public Guid fidParent;

    /// <include file='KNOWNFOLDER_DEFINITION.xml' path='doc/member[@name="KNOWNFOLDER_DEFINITION.pszRelativePath"]/*' />
    [NativeTypeName("LPWSTR")]
    public char* pszRelativePath;

    /// <include file='KNOWNFOLDER_DEFINITION.xml' path='doc/member[@name="KNOWNFOLDER_DEFINITION.pszParsingName"]/*' />
    [NativeTypeName("LPWSTR")]
    public char* pszParsingName;

    /// <include file='KNOWNFOLDER_DEFINITION.xml' path='doc/member[@name="KNOWNFOLDER_DEFINITION.pszTooltip"]/*' />
    [NativeTypeName("LPWSTR")]
    public char* pszTooltip;

    /// <include file='KNOWNFOLDER_DEFINITION.xml' path='doc/member[@name="KNOWNFOLDER_DEFINITION.pszLocalizedName"]/*' />
    [NativeTypeName("LPWSTR")]
    public char* pszLocalizedName;

    /// <include file='KNOWNFOLDER_DEFINITION.xml' path='doc/member[@name="KNOWNFOLDER_DEFINITION.pszIcon"]/*' />
    [NativeTypeName("LPWSTR")]
    public char* pszIcon;

    /// <include file='KNOWNFOLDER_DEFINITION.xml' path='doc/member[@name="KNOWNFOLDER_DEFINITION.pszSecurity"]/*' />
    [NativeTypeName("LPWSTR")]
    public char* pszSecurity;

    /// <include file='KNOWNFOLDER_DEFINITION.xml' path='doc/member[@name="KNOWNFOLDER_DEFINITION.dwAttributes"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwAttributes;

    /// <include file='KNOWNFOLDER_DEFINITION.xml' path='doc/member[@name="KNOWNFOLDER_DEFINITION.kfdFlags"]/*' />
    [NativeTypeName("KF_DEFINITION_FLAGS")]
    public uint kfdFlags;

    /// <include file='KNOWNFOLDER_DEFINITION.xml' path='doc/member[@name="KNOWNFOLDER_DEFINITION.ftidType"]/*' />
    [NativeTypeName("FOLDERTYPEID")]
    public Guid ftidType;
}
