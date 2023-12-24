// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='ENUMLOGFONTA.xml' path='doc/member[@name="ENUMLOGFONTA"]/*' />
public partial struct ENUMLOGFONTA
{
    /// <include file='ENUMLOGFONTA.xml' path='doc/member[@name="ENUMLOGFONTA.elfLogFont"]/*' />
    public LOGFONTA elfLogFont;

    /// <include file='ENUMLOGFONTA.xml' path='doc/member[@name="ENUMLOGFONTA.elfFullName"]/*' />
    [NativeTypeName("BYTE[64]")]
    public _elfFullName_e__FixedBuffer elfFullName;

    /// <include file='ENUMLOGFONTA.xml' path='doc/member[@name="ENUMLOGFONTA.elfStyle"]/*' />
    [NativeTypeName("BYTE[32]")]
    public _elfStyle_e__FixedBuffer elfStyle;

    /// <include file='_elfFullName_e__FixedBuffer.xml' path='doc/member[@name="_elfFullName_e__FixedBuffer"]/*' />
    [InlineArray(64)]
    public partial struct _elfFullName_e__FixedBuffer
    {
        public byte e0;
    }

    /// <include file='_elfStyle_e__FixedBuffer.xml' path='doc/member[@name="_elfStyle_e__FixedBuffer"]/*' />
    [InlineArray(32)]
    public partial struct _elfStyle_e__FixedBuffer
    {
        public byte e0;
    }
}
