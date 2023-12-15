// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='CORRELATION_VECTOR.xml' path='doc/member[@name="CORRELATION_VECTOR"]/*' />
public partial struct CORRELATION_VECTOR
{
    /// <include file='CORRELATION_VECTOR.xml' path='doc/member[@name="CORRELATION_VECTOR.Version"]/*' />
    [NativeTypeName("CHAR")]
    public sbyte Version;

    /// <include file='CORRELATION_VECTOR.xml' path='doc/member[@name="CORRELATION_VECTOR.Vector"]/*' />
    [NativeTypeName("CHAR[129]")]
    public _Vector_e__FixedBuffer Vector;

    /// <include file='_Vector_e__FixedBuffer.xml' path='doc/member[@name="_Vector_e__FixedBuffer"]/*' />
    [InlineArray(129)]
    [Obsolete("Possible string represented as a fixed-sized buffer.")]
    public partial struct _Vector_e__FixedBuffer
    {
        public sbyte e0;
    }
}
