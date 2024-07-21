// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dvdmedia.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='AM_DVDCOPY_TITLEKEY.xml' path='doc/member[@name="AM_DVDCOPY_TITLEKEY"]/*' />
public partial struct AM_DVDCOPY_TITLEKEY
{
    /// <include file='AM_DVDCOPY_TITLEKEY.xml' path='doc/member[@name="AM_DVDCOPY_TITLEKEY.KeyFlags"]/*' />
    [NativeTypeName("ULONG")]
    public uint KeyFlags;

    /// <include file='AM_DVDCOPY_TITLEKEY.xml' path='doc/member[@name="AM_DVDCOPY_TITLEKEY.Reserved1"]/*' />
    [NativeTypeName("ULONG[2]")]
    public _Reserved1_e__FixedBuffer Reserved1;

    /// <include file='AM_DVDCOPY_TITLEKEY.xml' path='doc/member[@name="AM_DVDCOPY_TITLEKEY.TitleKey"]/*' />
    [NativeTypeName("UCHAR[6]")]
    public _TitleKey_e__FixedBuffer TitleKey;

    /// <include file='AM_DVDCOPY_TITLEKEY.xml' path='doc/member[@name="AM_DVDCOPY_TITLEKEY.Reserved2"]/*' />
    [NativeTypeName("UCHAR[2]")]
    public _Reserved2_e__FixedBuffer Reserved2;

    /// <include file='_Reserved1_e__FixedBuffer.xml' path='doc/member[@name="_Reserved1_e__FixedBuffer"]/*' />
    [InlineArray(2)]
    public partial struct _Reserved1_e__FixedBuffer
    {
        public uint e0;
    }

    /// <include file='_TitleKey_e__FixedBuffer.xml' path='doc/member[@name="_TitleKey_e__FixedBuffer"]/*' />
    [InlineArray(6)]
    public partial struct _TitleKey_e__FixedBuffer
    {
        public byte e0;
    }

    /// <include file='_Reserved2_e__FixedBuffer.xml' path='doc/member[@name="_Reserved2_e__FixedBuffer"]/*' />
    [InlineArray(2)]
    public partial struct _Reserved2_e__FixedBuffer
    {
        public byte e0;
    }
}
