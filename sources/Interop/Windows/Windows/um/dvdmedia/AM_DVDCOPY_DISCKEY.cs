// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dvdmedia.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='AM_DVDCOPY_DISCKEY.xml' path='doc/member[@name="AM_DVDCOPY_DISCKEY"]/*' />
public partial struct AM_DVDCOPY_DISCKEY
{
    /// <include file='AM_DVDCOPY_DISCKEY.xml' path='doc/member[@name="AM_DVDCOPY_DISCKEY.DiscKey"]/*' />
    [NativeTypeName("BYTE[2048]")]
    public _DiscKey_e__FixedBuffer DiscKey;

    /// <include file='_DiscKey_e__FixedBuffer.xml' path='doc/member[@name="_DiscKey_e__FixedBuffer"]/*' />
    [InlineArray(2048)]
    public partial struct _DiscKey_e__FixedBuffer
    {
        public byte e0;
    }
}
