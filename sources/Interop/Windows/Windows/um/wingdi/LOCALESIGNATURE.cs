// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='LOCALESIGNATURE.xml' path='doc/member[@name="LOCALESIGNATURE"]/*' />
public partial struct LOCALESIGNATURE
{
    /// <include file='LOCALESIGNATURE.xml' path='doc/member[@name="LOCALESIGNATURE.lsUsb"]/*' />
    [NativeTypeName("DWORD[4]")]
    public _lsUsb_e__FixedBuffer lsUsb;

    /// <include file='LOCALESIGNATURE.xml' path='doc/member[@name="LOCALESIGNATURE.lsCsbDefault"]/*' />
    [NativeTypeName("DWORD[2]")]
    public _lsCsbDefault_e__FixedBuffer lsCsbDefault;

    /// <include file='LOCALESIGNATURE.xml' path='doc/member[@name="LOCALESIGNATURE.lsCsbSupported"]/*' />
    [NativeTypeName("DWORD[2]")]
    public _lsCsbSupported_e__FixedBuffer lsCsbSupported;

    /// <include file='_lsUsb_e__FixedBuffer.xml' path='doc/member[@name="_lsUsb_e__FixedBuffer"]/*' />
    [InlineArray(4)]
    public partial struct _lsUsb_e__FixedBuffer
    {
        public uint e0;
    }

    /// <include file='_lsCsbDefault_e__FixedBuffer.xml' path='doc/member[@name="_lsCsbDefault_e__FixedBuffer"]/*' />
    [InlineArray(2)]
    public partial struct _lsCsbDefault_e__FixedBuffer
    {
        public uint e0;
    }

    /// <include file='_lsCsbSupported_e__FixedBuffer.xml' path='doc/member[@name="_lsCsbSupported_e__FixedBuffer"]/*' />
    [InlineArray(2)]
    public partial struct _lsCsbSupported_e__FixedBuffer
    {
        public uint e0;
    }
}
