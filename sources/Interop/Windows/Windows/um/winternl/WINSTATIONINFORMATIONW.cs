// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winternl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='WINSTATIONINFORMATIONW.xml' path='doc/member[@name="WINSTATIONINFORMATIONW"]/*' />
public partial struct WINSTATIONINFORMATIONW
{
    /// <include file='WINSTATIONINFORMATIONW.xml' path='doc/member[@name="WINSTATIONINFORMATIONW.Reserved2"]/*' />
    [NativeTypeName("BYTE[70]")]
    public _Reserved2_e__FixedBuffer Reserved2;

    /// <include file='WINSTATIONINFORMATIONW.xml' path='doc/member[@name="WINSTATIONINFORMATIONW.LogonId"]/*' />
    [NativeTypeName("ULONG")]
    public uint LogonId;

    /// <include file='WINSTATIONINFORMATIONW.xml' path='doc/member[@name="WINSTATIONINFORMATIONW.Reserved3"]/*' />
    [NativeTypeName("BYTE[1140]")]
    public _Reserved3_e__FixedBuffer Reserved3;

    /// <include file='_Reserved2_e__FixedBuffer.xml' path='doc/member[@name="_Reserved2_e__FixedBuffer"]/*' />
    [InlineArray(70)]
    public partial struct _Reserved2_e__FixedBuffer
    {
        public byte e0;
    }

    /// <include file='_Reserved3_e__FixedBuffer.xml' path='doc/member[@name="_Reserved3_e__FixedBuffer"]/*' />
    [InlineArray(1140)]
    public partial struct _Reserved3_e__FixedBuffer
    {
        public byte e0;
    }
}
