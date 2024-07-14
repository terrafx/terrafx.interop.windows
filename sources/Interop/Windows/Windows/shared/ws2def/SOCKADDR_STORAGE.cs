// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/ws2def.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='SOCKADDR_STORAGE.xml' path='doc/member[@name="SOCKADDR_STORAGE"]/*' />
public partial struct SOCKADDR_STORAGE
{
    /// <include file='SOCKADDR_STORAGE.xml' path='doc/member[@name="SOCKADDR_STORAGE.ss_family"]/*' />
    [NativeTypeName("ADDRESS_FAMILY")]
    public ushort ss_family;

    /// <include file='SOCKADDR_STORAGE.xml' path='doc/member[@name="SOCKADDR_STORAGE.__ss_pad1"]/*' />
    [NativeTypeName("CHAR[6]")]
    public ___ss_pad1_e__FixedBuffer __ss_pad1;

    /// <include file='SOCKADDR_STORAGE.xml' path='doc/member[@name="SOCKADDR_STORAGE.__ss_align"]/*' />
    [NativeTypeName("long long")]
    public long __ss_align;

    /// <include file='SOCKADDR_STORAGE.xml' path='doc/member[@name="SOCKADDR_STORAGE.__ss_pad2"]/*' />
    [NativeTypeName("CHAR[112]")]
    public ___ss_pad2_e__FixedBuffer __ss_pad2;

    /// <include file='___ss_pad1_e__FixedBuffer.xml' path='doc/member[@name="___ss_pad1_e__FixedBuffer"]/*' />
    [InlineArray(6)]
    public partial struct ___ss_pad1_e__FixedBuffer
    {
        public sbyte e0;
    }

    /// <include file='___ss_pad2_e__FixedBuffer.xml' path='doc/member[@name="___ss_pad2_e__FixedBuffer"]/*' />
    [InlineArray(112)]
    public partial struct ___ss_pad2_e__FixedBuffer
    {
        public sbyte e0;
    }
}
