// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='OFSTRUCT.xml' path='doc/member[@name="OFSTRUCT"]/*' />
public partial struct OFSTRUCT
{
    /// <include file='OFSTRUCT.xml' path='doc/member[@name="OFSTRUCT.cBytes"]/*' />
    public byte cBytes;

    /// <include file='OFSTRUCT.xml' path='doc/member[@name="OFSTRUCT.fFixedDisk"]/*' />
    public byte fFixedDisk;

    /// <include file='OFSTRUCT.xml' path='doc/member[@name="OFSTRUCT.nErrCode"]/*' />
    [NativeTypeName("WORD")]
    public ushort nErrCode;

    /// <include file='OFSTRUCT.xml' path='doc/member[@name="OFSTRUCT.Reserved1"]/*' />
    [NativeTypeName("WORD")]
    public ushort Reserved1;

    /// <include file='OFSTRUCT.xml' path='doc/member[@name="OFSTRUCT.Reserved2"]/*' />
    [NativeTypeName("WORD")]
    public ushort Reserved2;

    /// <include file='OFSTRUCT.xml' path='doc/member[@name="OFSTRUCT.szPathName"]/*' />
    [NativeTypeName("CHAR[128]")]
    public _szPathName_e__FixedBuffer szPathName;

    /// <include file='_szPathName_e__FixedBuffer.xml' path='doc/member[@name="_szPathName_e__FixedBuffer"]/*' />
    [InlineArray(128)]
    [Obsolete("Possible string represented as a fixed-sized buffer.")]
    public partial struct _szPathName_e__FixedBuffer
    {
        public sbyte e0;
    }
}
