// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='EXTRASEARCH.xml' path='doc/member[@name="EXTRASEARCH"]/*' />
public partial struct EXTRASEARCH
{
    /// <include file='EXTRASEARCH.xml' path='doc/member[@name="EXTRASEARCH.guidSearch"]/*' />
    public Guid guidSearch;

    /// <include file='EXTRASEARCH.xml' path='doc/member[@name="EXTRASEARCH.wszFriendlyName"]/*' />
    [NativeTypeName("WCHAR[80]")]
    public _wszFriendlyName_e__FixedBuffer wszFriendlyName;

    /// <include file='EXTRASEARCH.xml' path='doc/member[@name="EXTRASEARCH.wszUrl"]/*' />
    [NativeTypeName("WCHAR[2084]")]
    public _wszUrl_e__FixedBuffer wszUrl;

    /// <include file='_wszFriendlyName_e__FixedBuffer.xml' path='doc/member[@name="_wszFriendlyName_e__FixedBuffer"]/*' />
    [InlineArray(80)]
    [Obsolete("Possible string represented as a fixed-sized buffer.")]
    public partial struct _wszFriendlyName_e__FixedBuffer
    {
        public char e0;
    }

    /// <include file='_wszUrl_e__FixedBuffer.xml' path='doc/member[@name="_wszUrl_e__FixedBuffer"]/*' />
    [InlineArray(2084)]
    [Obsolete("Possible string represented as a fixed-sized buffer.")]
    public partial struct _wszUrl_e__FixedBuffer
    {
        public char e0;
    }
}
