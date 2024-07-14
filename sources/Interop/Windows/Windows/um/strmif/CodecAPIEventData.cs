// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='CodecAPIEventData.xml' path='doc/member[@name="CodecAPIEventData"]/*' />
public partial struct CodecAPIEventData
{
    /// <include file='CodecAPIEventData.xml' path='doc/member[@name="CodecAPIEventData.guid"]/*' />
    public Guid guid;

    /// <include file='CodecAPIEventData.xml' path='doc/member[@name="CodecAPIEventData.dataLength"]/*' />
    [NativeTypeName("DWORD")]
    public uint dataLength;

    /// <include file='CodecAPIEventData.xml' path='doc/member[@name="CodecAPIEventData.reserved"]/*' />
    [NativeTypeName("DWORD[3]")]
    public _reserved_e__FixedBuffer reserved;

    /// <include file='_reserved_e__FixedBuffer.xml' path='doc/member[@name="_reserved_e__FixedBuffer"]/*' />
    [InlineArray(3)]
    public partial struct _reserved_e__FixedBuffer
    {
        public uint e0;
    }
}
