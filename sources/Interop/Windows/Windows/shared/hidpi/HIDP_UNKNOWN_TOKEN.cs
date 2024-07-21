// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/hidpi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='HIDP_UNKNOWN_TOKEN.xml' path='doc/member[@name="HIDP_UNKNOWN_TOKEN"]/*' />
public partial struct HIDP_UNKNOWN_TOKEN
{
    /// <include file='HIDP_UNKNOWN_TOKEN.xml' path='doc/member[@name="HIDP_UNKNOWN_TOKEN.Token"]/*' />
    [NativeTypeName("UCHAR")]
    public byte Token;

    /// <include file='HIDP_UNKNOWN_TOKEN.xml' path='doc/member[@name="HIDP_UNKNOWN_TOKEN.Reserved"]/*' />
    [NativeTypeName("UCHAR[3]")]
    public _Reserved_e__FixedBuffer Reserved;

    /// <include file='HIDP_UNKNOWN_TOKEN.xml' path='doc/member[@name="HIDP_UNKNOWN_TOKEN.BitField"]/*' />
    [NativeTypeName("ULONG")]
    public uint BitField;

    /// <include file='_Reserved_e__FixedBuffer.xml' path='doc/member[@name="_Reserved_e__FixedBuffer"]/*' />
    [InlineArray(3)]
    public partial struct _Reserved_e__FixedBuffer
    {
        public byte e0;
    }
}
