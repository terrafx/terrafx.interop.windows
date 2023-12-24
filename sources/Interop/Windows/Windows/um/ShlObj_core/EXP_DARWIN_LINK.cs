// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='EXP_DARWIN_LINK.xml' path='doc/member[@name="EXP_DARWIN_LINK"]/*' />
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct EXP_DARWIN_LINK
{
    /// <include file='EXP_DARWIN_LINK.xml' path='doc/member[@name="EXP_DARWIN_LINK.dbh"]/*' />
    public DATABLOCK_HEADER dbh;

    /// <include file='EXP_DARWIN_LINK.xml' path='doc/member[@name="EXP_DARWIN_LINK.szDarwinID"]/*' />
    [NativeTypeName("CHAR[260]")]
    public _szDarwinID_e__FixedBuffer szDarwinID;

    /// <include file='EXP_DARWIN_LINK.xml' path='doc/member[@name="EXP_DARWIN_LINK.szwDarwinID"]/*' />
    [NativeTypeName("WCHAR[260]")]
    public _szwDarwinID_e__FixedBuffer szwDarwinID;

    /// <include file='_szDarwinID_e__FixedBuffer.xml' path='doc/member[@name="_szDarwinID_e__FixedBuffer"]/*' />
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    [InlineArray(260)]
    public partial struct _szDarwinID_e__FixedBuffer
    {
        public sbyte e0;
    }

    /// <include file='_szwDarwinID_e__FixedBuffer.xml' path='doc/member[@name="_szwDarwinID_e__FixedBuffer"]/*' />
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    [InlineArray(260)]
    public partial struct _szwDarwinID_e__FixedBuffer
    {
        public char e0;
    }
}
