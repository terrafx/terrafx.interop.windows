// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/in6addr.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='IN6_ADDR.xml' path='doc/member[@name="IN6_ADDR"]/*' />
public partial struct IN6_ADDR
{
    /// <include file='IN6_ADDR.xml' path='doc/member[@name="IN6_ADDR.u"]/*' />
    [NativeTypeName("__AnonymousRecord_in6addr_L26_C5")]
    public _u_e__Union u;

    /// <include file='_u_e__Union.xml' path='doc/member[@name="_u_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _u_e__Union
    {
        /// <include file='_u_e__Union.xml' path='doc/member[@name="_u_e__Union.Byte"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("UCHAR[16]")]
        public _Byte_e__FixedBuffer Byte;

        /// <include file='_u_e__Union.xml' path='doc/member[@name="_u_e__Union.Word"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("USHORT[8]")]
        public _Word_e__FixedBuffer Word;

        /// <include file='_Byte_e__FixedBuffer.xml' path='doc/member[@name="_Byte_e__FixedBuffer"]/*' />
        [InlineArray(16)]
        public partial struct _Byte_e__FixedBuffer
        {
            public byte e0;
        }

        /// <include file='_Word_e__FixedBuffer.xml' path='doc/member[@name="_Word_e__FixedBuffer"]/*' />
        [InlineArray(8)]
        public partial struct _Word_e__FixedBuffer
        {
            public ushort e0;
        }
    }
}
