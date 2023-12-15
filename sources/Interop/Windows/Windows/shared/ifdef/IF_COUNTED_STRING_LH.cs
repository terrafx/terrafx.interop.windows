// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/ifdef.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='IF_COUNTED_STRING_LH.xml' path='doc/member[@name="IF_COUNTED_STRING_LH"]/*' />
public partial struct IF_COUNTED_STRING_LH
{
    /// <include file='IF_COUNTED_STRING_LH.xml' path='doc/member[@name="IF_COUNTED_STRING_LH.Length"]/*' />
    public ushort Length;

    /// <include file='IF_COUNTED_STRING_LH.xml' path='doc/member[@name="IF_COUNTED_STRING_LH.String"]/*' />
    [NativeTypeName("WCHAR[257]")]
    public _String_e__FixedBuffer String;

    /// <include file='_String_e__FixedBuffer.xml' path='doc/member[@name="_String_e__FixedBuffer"]/*' />
    [InlineArray(257)]
    [Obsolete("Possible string represented as a fixed-sized buffer.")]
    public partial struct _String_e__FixedBuffer
    {
        public char e0;
    }
}
