// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='NMCBEDRAGBEGINW.xml' path='doc/member[@name="NMCBEDRAGBEGINW"]/*' />
public partial struct NMCBEDRAGBEGINW
{
    /// <include file='NMCBEDRAGBEGINW.xml' path='doc/member[@name="NMCBEDRAGBEGINW.hdr"]/*' />
    public NMHDR hdr;

    /// <include file='NMCBEDRAGBEGINW.xml' path='doc/member[@name="NMCBEDRAGBEGINW.iItemid"]/*' />
    public int iItemid;

    /// <include file='NMCBEDRAGBEGINW.xml' path='doc/member[@name="NMCBEDRAGBEGINW.szText"]/*' />
    [NativeTypeName("WCHAR[260]")]
    public _szText_e__FixedBuffer szText;

    /// <include file='_szText_e__FixedBuffer.xml' path='doc/member[@name="_szText_e__FixedBuffer"]/*' />
    [InlineArray(260)]
    public partial struct _szText_e__FixedBuffer
    {
        public char e0;
    }
}
