// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='NMCBEDRAGBEGINA.xml' path='doc/member[@name="NMCBEDRAGBEGINA"]/*' />
public partial struct NMCBEDRAGBEGINA
{
    /// <include file='NMCBEDRAGBEGINA.xml' path='doc/member[@name="NMCBEDRAGBEGINA.hdr"]/*' />
    public NMHDR hdr;

    /// <include file='NMCBEDRAGBEGINA.xml' path='doc/member[@name="NMCBEDRAGBEGINA.iItemid"]/*' />
    public int iItemid;

    /// <include file='NMCBEDRAGBEGINA.xml' path='doc/member[@name="NMCBEDRAGBEGINA.szText"]/*' />
    [NativeTypeName("char[260]")]
    public _szText_e__FixedBuffer szText;

    /// <include file='_szText_e__FixedBuffer.xml' path='doc/member[@name="_szText_e__FixedBuffer"]/*' />
    [InlineArray(260)]
    public partial struct _szText_e__FixedBuffer
    {
        public sbyte e0;
    }
}
