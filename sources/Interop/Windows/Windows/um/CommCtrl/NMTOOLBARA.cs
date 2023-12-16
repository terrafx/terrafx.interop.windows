// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='NMTOOLBARA.xml' path='doc/member[@name="NMTOOLBARA"]/*' />
public unsafe partial struct NMTOOLBARA
{
    /// <include file='NMTOOLBARA.xml' path='doc/member[@name="NMTOOLBARA.hdr"]/*' />
    public NMHDR hdr;

    /// <include file='NMTOOLBARA.xml' path='doc/member[@name="NMTOOLBARA.iItem"]/*' />
    public int iItem;

    /// <include file='NMTOOLBARA.xml' path='doc/member[@name="NMTOOLBARA.tbButton"]/*' />
    public TBBUTTON tbButton;

    /// <include file='NMTOOLBARA.xml' path='doc/member[@name="NMTOOLBARA.cchText"]/*' />
    public int cchText;

    /// <include file='NMTOOLBARA.xml' path='doc/member[@name="NMTOOLBARA.pszText"]/*' />
    [NativeTypeName("LPSTR")]
    public sbyte* pszText;

    /// <include file='NMTOOLBARA.xml' path='doc/member[@name="NMTOOLBARA.rcButton"]/*' />
    public RECT rcButton;
}
