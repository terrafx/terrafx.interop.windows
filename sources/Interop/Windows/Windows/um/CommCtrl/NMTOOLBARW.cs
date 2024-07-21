// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='NMTOOLBARW.xml' path='doc/member[@name="NMTOOLBARW"]/*' />
public unsafe partial struct NMTOOLBARW
{
    /// <include file='NMTOOLBARW.xml' path='doc/member[@name="NMTOOLBARW.hdr"]/*' />
    public NMHDR hdr;

    /// <include file='NMTOOLBARW.xml' path='doc/member[@name="NMTOOLBARW.iItem"]/*' />
    public int iItem;

    /// <include file='NMTOOLBARW.xml' path='doc/member[@name="NMTOOLBARW.tbButton"]/*' />
    public TBBUTTON tbButton;

    /// <include file='NMTOOLBARW.xml' path='doc/member[@name="NMTOOLBARW.cchText"]/*' />
    public int cchText;

    /// <include file='NMTOOLBARW.xml' path='doc/member[@name="NMTOOLBARW.pszText"]/*' />
    [NativeTypeName("LPWSTR")]
    public char* pszText;

    /// <include file='NMTOOLBARW.xml' path='doc/member[@name="NMTOOLBARW.rcButton"]/*' />
    public RECT rcButton;
}
