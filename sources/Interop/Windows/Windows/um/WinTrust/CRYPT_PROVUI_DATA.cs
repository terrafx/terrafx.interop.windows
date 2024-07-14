// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinTrust.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='CRYPT_PROVUI_DATA.xml' path='doc/member[@name="CRYPT_PROVUI_DATA"]/*' />
public unsafe partial struct CRYPT_PROVUI_DATA
{
    /// <include file='CRYPT_PROVUI_DATA.xml' path='doc/member[@name="CRYPT_PROVUI_DATA.cbStruct"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbStruct;

    /// <include file='CRYPT_PROVUI_DATA.xml' path='doc/member[@name="CRYPT_PROVUI_DATA.dwFinalError"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwFinalError;

    /// <include file='CRYPT_PROVUI_DATA.xml' path='doc/member[@name="CRYPT_PROVUI_DATA.pYesButtonText"]/*' />
    [NativeTypeName("WCHAR *")]
    public char* pYesButtonText;

    /// <include file='CRYPT_PROVUI_DATA.xml' path='doc/member[@name="CRYPT_PROVUI_DATA.pNoButtonText"]/*' />
    [NativeTypeName("WCHAR *")]
    public char* pNoButtonText;

    /// <include file='CRYPT_PROVUI_DATA.xml' path='doc/member[@name="CRYPT_PROVUI_DATA.pMoreInfoButtonText"]/*' />
    [NativeTypeName("WCHAR *")]
    public char* pMoreInfoButtonText;

    /// <include file='CRYPT_PROVUI_DATA.xml' path='doc/member[@name="CRYPT_PROVUI_DATA.pAdvancedLinkText"]/*' />
    [NativeTypeName("WCHAR *")]
    public char* pAdvancedLinkText;

    /// <include file='CRYPT_PROVUI_DATA.xml' path='doc/member[@name="CRYPT_PROVUI_DATA.pCopyActionText"]/*' />
    [NativeTypeName("WCHAR *")]
    public char* pCopyActionText;

    /// <include file='CRYPT_PROVUI_DATA.xml' path='doc/member[@name="CRYPT_PROVUI_DATA.pCopyActionTextNoTS"]/*' />
    [NativeTypeName("WCHAR *")]
    public char* pCopyActionTextNoTS;

    /// <include file='CRYPT_PROVUI_DATA.xml' path='doc/member[@name="CRYPT_PROVUI_DATA.pCopyActionTextNotSigned"]/*' />
    [NativeTypeName("WCHAR *")]
    public char* pCopyActionTextNotSigned;
}
