// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from dia2.h in the Debug Interface Access SDK
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='DiaTagValue.xml' path='doc/member[@name="DiaTagValue"]/*' />
public partial struct DiaTagValue
{
    /// <include file='DiaTagValue.xml' path='doc/member[@name="DiaTagValue.value"]/*' />
    [NativeTypeName("BYTE[16]")]
    public _value_e__FixedBuffer value;

    /// <include file='DiaTagValue.xml' path='doc/member[@name="DiaTagValue.valueSizeBytes"]/*' />
    public byte valueSizeBytes;

    /// <include file='_value_e__FixedBuffer.xml' path='doc/member[@name="_value_e__FixedBuffer"]/*' />
    [InlineArray(16)]
    public partial struct _value_e__FixedBuffer
    {
        public byte e0;
    }
}
