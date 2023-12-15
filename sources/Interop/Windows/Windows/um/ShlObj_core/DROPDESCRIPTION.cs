// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='DROPDESCRIPTION.xml' path='doc/member[@name="DROPDESCRIPTION"]/*' />
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct DROPDESCRIPTION
{
    /// <include file='DROPDESCRIPTION.xml' path='doc/member[@name="DROPDESCRIPTION.type"]/*' />
    public DROPIMAGETYPE type;

    /// <include file='DROPDESCRIPTION.xml' path='doc/member[@name="DROPDESCRIPTION.szMessage"]/*' />
    [NativeTypeName("WCHAR[260]")]
    public _szMessage_e__FixedBuffer szMessage;

    /// <include file='DROPDESCRIPTION.xml' path='doc/member[@name="DROPDESCRIPTION.szInsert"]/*' />
    [NativeTypeName("WCHAR[260]")]
    public _szInsert_e__FixedBuffer szInsert;

    /// <include file='_szMessage_e__FixedBuffer.xml' path='doc/member[@name="_szMessage_e__FixedBuffer"]/*' />
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    [InlineArray(260)]
    [Obsolete("Possible string represented as a fixed-sized buffer.")]
    public partial struct _szMessage_e__FixedBuffer
    {
        public char e0;
    }

    /// <include file='_szInsert_e__FixedBuffer.xml' path='doc/member[@name="_szInsert_e__FixedBuffer"]/*' />
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    [InlineArray(260)]
    [Obsolete("Possible string represented as a fixed-sized buffer.")]
    public partial struct _szInsert_e__FixedBuffer
    {
        public char e0;
    }
}
