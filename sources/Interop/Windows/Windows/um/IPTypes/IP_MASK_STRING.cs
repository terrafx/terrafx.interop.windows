// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/IPTypes.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='IP_MASK_STRING.xml' path='doc/member[@name="IP_MASK_STRING"]/*' />
public partial struct IP_MASK_STRING
{
    /// <include file='IP_MASK_STRING.xml' path='doc/member[@name="IP_MASK_STRING.String"]/*' />
    [NativeTypeName("char[16]")]
    public _String_e__FixedBuffer String;

    /// <include file='_String_e__FixedBuffer.xml' path='doc/member[@name="_String_e__FixedBuffer"]/*' />
    [InlineArray(16)]
    public partial struct _String_e__FixedBuffer
    {
        public sbyte e0;
    }
}
