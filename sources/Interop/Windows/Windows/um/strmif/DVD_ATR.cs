// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='DVD_ATR.xml' path='doc/member[@name="DVD_ATR"]/*' />
public partial struct DVD_ATR
{
    /// <include file='DVD_ATR.xml' path='doc/member[@name="DVD_ATR.ulCAT"]/*' />
    [NativeTypeName("ULONG")]
    public uint ulCAT;

    /// <include file='DVD_ATR.xml' path='doc/member[@name="DVD_ATR.pbATRI"]/*' />
    [NativeTypeName("BYTE[768]")]
    public _pbATRI_e__FixedBuffer pbATRI;

    /// <include file='_pbATRI_e__FixedBuffer.xml' path='doc/member[@name="_pbATRI_e__FixedBuffer"]/*' />
    [InlineArray(768)]
    public partial struct _pbATRI_e__FixedBuffer
    {
        public byte e0;
    }
}
