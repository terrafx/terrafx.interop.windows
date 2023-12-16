// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='NMTBSAVE.xml' path='doc/member[@name="NMTBSAVE"]/*' />
public unsafe partial struct NMTBSAVE
{
    /// <include file='NMTBSAVE.xml' path='doc/member[@name="NMTBSAVE.hdr"]/*' />
    public NMHDR hdr;

    /// <include file='NMTBSAVE.xml' path='doc/member[@name="NMTBSAVE.pData"]/*' />
    [NativeTypeName("DWORD *")]
    public uint* pData;

    /// <include file='NMTBSAVE.xml' path='doc/member[@name="NMTBSAVE.pCurrent"]/*' />
    [NativeTypeName("DWORD *")]
    public uint* pCurrent;

    /// <include file='NMTBSAVE.xml' path='doc/member[@name="NMTBSAVE.cbData"]/*' />
    public uint cbData;

    /// <include file='NMTBSAVE.xml' path='doc/member[@name="NMTBSAVE.iItem"]/*' />
    public int iItem;

    /// <include file='NMTBSAVE.xml' path='doc/member[@name="NMTBSAVE.cButtons"]/*' />
    public int cButtons;

    /// <include file='NMTBSAVE.xml' path='doc/member[@name="NMTBSAVE.tbButton"]/*' />
    public TBBUTTON tbButton;
}
