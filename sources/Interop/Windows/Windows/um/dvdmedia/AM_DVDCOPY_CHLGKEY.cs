// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dvdmedia.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='AM_DVDCOPY_CHLGKEY.xml' path='doc/member[@name="AM_DVDCOPY_CHLGKEY"]/*' />
public partial struct AM_DVDCOPY_CHLGKEY
{
    /// <include file='AM_DVDCOPY_CHLGKEY.xml' path='doc/member[@name="AM_DVDCOPY_CHLGKEY.ChlgKey"]/*' />
    [NativeTypeName("BYTE[10]")]
    public _ChlgKey_e__FixedBuffer ChlgKey;

    /// <include file='AM_DVDCOPY_CHLGKEY.xml' path='doc/member[@name="AM_DVDCOPY_CHLGKEY.Reserved"]/*' />
    [NativeTypeName("BYTE[2]")]
    public _Reserved_e__FixedBuffer Reserved;

    /// <include file='_ChlgKey_e__FixedBuffer.xml' path='doc/member[@name="_ChlgKey_e__FixedBuffer"]/*' />
    [InlineArray(10)]
    public partial struct _ChlgKey_e__FixedBuffer
    {
        public byte e0;
    }

    /// <include file='_Reserved_e__FixedBuffer.xml' path='doc/member[@name="_Reserved_e__FixedBuffer"]/*' />
    [InlineArray(2)]
    public partial struct _Reserved_e__FixedBuffer
    {
        public byte e0;
    }
}
