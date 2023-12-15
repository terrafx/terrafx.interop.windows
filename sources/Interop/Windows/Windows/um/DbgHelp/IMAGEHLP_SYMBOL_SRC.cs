// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DbgHelp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='IMAGEHLP_SYMBOL_SRC.xml' path='doc/member[@name="IMAGEHLP_SYMBOL_SRC"]/*' />
public partial struct IMAGEHLP_SYMBOL_SRC
{
    /// <include file='IMAGEHLP_SYMBOL_SRC.xml' path='doc/member[@name="IMAGEHLP_SYMBOL_SRC.sizeofstruct"]/*' />
    [NativeTypeName("DWORD")]
    public uint sizeofstruct;

    /// <include file='IMAGEHLP_SYMBOL_SRC.xml' path='doc/member[@name="IMAGEHLP_SYMBOL_SRC.type"]/*' />
    [NativeTypeName("DWORD")]
    public uint type;

    /// <include file='IMAGEHLP_SYMBOL_SRC.xml' path='doc/member[@name="IMAGEHLP_SYMBOL_SRC.file"]/*' />
    [NativeTypeName("char[260]")]
    public _file_e__FixedBuffer file;

    /// <include file='_file_e__FixedBuffer.xml' path='doc/member[@name="_file_e__FixedBuffer"]/*' />
    [InlineArray(260)]
    [Obsolete("Possible string represented as a fixed-sized buffer.")]
    public partial struct _file_e__FixedBuffer
    {
        public sbyte e0;
    }
}
