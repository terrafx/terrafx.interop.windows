// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/IPTypes.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='IP_ADAPTER_DNS_SUFFIX.xml' path='doc/member[@name="IP_ADAPTER_DNS_SUFFIX"]/*' />
public unsafe partial struct IP_ADAPTER_DNS_SUFFIX
{
    /// <include file='IP_ADAPTER_DNS_SUFFIX.xml' path='doc/member[@name="IP_ADAPTER_DNS_SUFFIX.Next"]/*' />
    [NativeTypeName("struct _IP_ADAPTER_DNS_SUFFIX *")]
    public IP_ADAPTER_DNS_SUFFIX* Next;

    /// <include file='IP_ADAPTER_DNS_SUFFIX.xml' path='doc/member[@name="IP_ADAPTER_DNS_SUFFIX.String"]/*' />
    [NativeTypeName("WCHAR[256]")]
    public _String_e__FixedBuffer String;

    /// <include file='_String_e__FixedBuffer.xml' path='doc/member[@name="_String_e__FixedBuffer"]/*' />
    [InlineArray(256)]
    [Obsolete("Possible string represented as a fixed-sized buffer.")]
    public partial struct _String_e__FixedBuffer
    {
        public char e0;
    }
}
