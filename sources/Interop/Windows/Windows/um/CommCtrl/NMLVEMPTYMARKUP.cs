// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='NMLVEMPTYMARKUP.xml' path='doc/member[@name="NMLVEMPTYMARKUP"]/*' />
public partial struct NMLVEMPTYMARKUP
{
    /// <include file='NMLVEMPTYMARKUP.xml' path='doc/member[@name="NMLVEMPTYMARKUP.hdr"]/*' />
    public NMHDR hdr;

    /// <include file='NMLVEMPTYMARKUP.xml' path='doc/member[@name="NMLVEMPTYMARKUP.dwFlags"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwFlags;

    /// <include file='NMLVEMPTYMARKUP.xml' path='doc/member[@name="NMLVEMPTYMARKUP.szMarkup"]/*' />
    [NativeTypeName("WCHAR[2084]")]
    public _szMarkup_e__FixedBuffer szMarkup;

    /// <include file='_szMarkup_e__FixedBuffer.xml' path='doc/member[@name="_szMarkup_e__FixedBuffer"]/*' />
    [InlineArray(2084)]
    public partial struct _szMarkup_e__FixedBuffer
    {
        public char e0;
    }
}
