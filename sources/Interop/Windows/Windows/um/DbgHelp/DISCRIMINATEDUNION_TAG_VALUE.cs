// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DbgHelp.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='DISCRIMINATEDUNION_TAG_VALUE.xml' path='doc/member[@name="DISCRIMINATEDUNION_TAG_VALUE"]/*' />
public partial struct DISCRIMINATEDUNION_TAG_VALUE
{
    /// <include file='DISCRIMINATEDUNION_TAG_VALUE.xml' path='doc/member[@name="DISCRIMINATEDUNION_TAG_VALUE.value"]/*' />
    [NativeTypeName("BYTE[16]")]
    public _value_e__FixedBuffer value;

    /// <include file='DISCRIMINATEDUNION_TAG_VALUE.xml' path='doc/member[@name="DISCRIMINATEDUNION_TAG_VALUE.valueSizeBytes"]/*' />
    public byte valueSizeBytes;

    /// <include file='_value_e__FixedBuffer.xml' path='doc/member[@name="_value_e__FixedBuffer"]/*' />
    [InlineArray(16)]
    public partial struct _value_e__FixedBuffer
    {
        public byte e0;
    }
}
