// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='ENUMLOGFONTW.xml' path='doc/member[@name="ENUMLOGFONTW"]/*' />
public partial struct ENUMLOGFONTW
{
    /// <include file='ENUMLOGFONTW.xml' path='doc/member[@name="ENUMLOGFONTW.elfLogFont"]/*' />
    public LOGFONTW elfLogFont;

    /// <include file='ENUMLOGFONTW.xml' path='doc/member[@name="ENUMLOGFONTW.elfFullName"]/*' />
    [NativeTypeName("WCHAR[64]")]
    public _elfFullName_e__FixedBuffer elfFullName;

    /// <include file='ENUMLOGFONTW.xml' path='doc/member[@name="ENUMLOGFONTW.elfStyle"]/*' />
    [NativeTypeName("WCHAR[32]")]
    public _elfStyle_e__FixedBuffer elfStyle;

    /// <include file='_elfFullName_e__FixedBuffer.xml' path='doc/member[@name="_elfFullName_e__FixedBuffer"]/*' />
    [InlineArray(64)]
    [Obsolete("Possible string represented as a fixed-sized buffer.")]
    public partial struct _elfFullName_e__FixedBuffer
    {
        public char e0;
    }

    /// <include file='_elfStyle_e__FixedBuffer.xml' path='doc/member[@name="_elfStyle_e__FixedBuffer"]/*' />
    [InlineArray(32)]
    [Obsolete("Possible string represented as a fixed-sized buffer.")]
    public partial struct _elfStyle_e__FixedBuffer
    {
        public char e0;
    }
}
