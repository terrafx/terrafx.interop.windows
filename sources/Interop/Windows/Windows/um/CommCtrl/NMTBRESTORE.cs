// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='NMTBRESTORE.xml' path='doc/member[@name="NMTBRESTORE"]/*' />
public unsafe partial struct NMTBRESTORE
{
    /// <include file='NMTBRESTORE.xml' path='doc/member[@name="NMTBRESTORE.hdr"]/*' />
    public NMHDR hdr;

    /// <include file='NMTBRESTORE.xml' path='doc/member[@name="NMTBRESTORE.pData"]/*' />
    [NativeTypeName("DWORD *")]
    public uint* pData;

    /// <include file='NMTBRESTORE.xml' path='doc/member[@name="NMTBRESTORE.pCurrent"]/*' />
    [NativeTypeName("DWORD *")]
    public uint* pCurrent;

    /// <include file='NMTBRESTORE.xml' path='doc/member[@name="NMTBRESTORE.cbData"]/*' />
    public uint cbData;

    /// <include file='NMTBRESTORE.xml' path='doc/member[@name="NMTBRESTORE.iItem"]/*' />
    public int iItem;

    /// <include file='NMTBRESTORE.xml' path='doc/member[@name="NMTBRESTORE.cButtons"]/*' />
    public int cButtons;

    /// <include file='NMTBRESTORE.xml' path='doc/member[@name="NMTBRESTORE.cbBytesPerRecord"]/*' />
    public int cbBytesPerRecord;

    /// <include file='NMTBRESTORE.xml' path='doc/member[@name="NMTBRESTORE.tbButton"]/*' />
    public TBBUTTON tbButton;
}
