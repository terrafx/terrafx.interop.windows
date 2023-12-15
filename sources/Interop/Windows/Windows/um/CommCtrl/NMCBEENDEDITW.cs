// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='NMCBEENDEDITW.xml' path='doc/member[@name="NMCBEENDEDITW"]/*' />
public partial struct NMCBEENDEDITW
{
    /// <include file='NMCBEENDEDITW.xml' path='doc/member[@name="NMCBEENDEDITW.hdr"]/*' />
    public NMHDR hdr;

    /// <include file='NMCBEENDEDITW.xml' path='doc/member[@name="NMCBEENDEDITW.fChanged"]/*' />
    public BOOL fChanged;

    /// <include file='NMCBEENDEDITW.xml' path='doc/member[@name="NMCBEENDEDITW.iNewSelection"]/*' />
    public int iNewSelection;

    /// <include file='NMCBEENDEDITW.xml' path='doc/member[@name="NMCBEENDEDITW.szText"]/*' />
    [NativeTypeName("WCHAR[260]")]
    public _szText_e__FixedBuffer szText;

    /// <include file='NMCBEENDEDITW.xml' path='doc/member[@name="NMCBEENDEDITW.iWhy"]/*' />
    public int iWhy;

    /// <include file='_szText_e__FixedBuffer.xml' path='doc/member[@name="_szText_e__FixedBuffer"]/*' />
    [InlineArray(260)]
    [Obsolete("Possible string represented as a fixed-sized buffer.")]
    public partial struct _szText_e__FixedBuffer
    {
        public char e0;
    }
}
