// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mmeapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='AUXCAPS2A.xml' path='doc/member[@name="AUXCAPS2A"]/*' />
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct AUXCAPS2A
{
    /// <include file='AUXCAPS2A.xml' path='doc/member[@name="AUXCAPS2A.wMid"]/*' />
    [NativeTypeName("WORD")]
    public ushort wMid;

    /// <include file='AUXCAPS2A.xml' path='doc/member[@name="AUXCAPS2A.wPid"]/*' />
    [NativeTypeName("WORD")]
    public ushort wPid;

    /// <include file='AUXCAPS2A.xml' path='doc/member[@name="AUXCAPS2A.vDriverVersion"]/*' />
    [NativeTypeName("MMVERSION")]
    public uint vDriverVersion;

    /// <include file='AUXCAPS2A.xml' path='doc/member[@name="AUXCAPS2A.szPname"]/*' />
    [NativeTypeName("CHAR[32]")]
    public _szPname_e__FixedBuffer szPname;

    /// <include file='AUXCAPS2A.xml' path='doc/member[@name="AUXCAPS2A.wTechnology"]/*' />
    [NativeTypeName("WORD")]
    public ushort wTechnology;

    /// <include file='AUXCAPS2A.xml' path='doc/member[@name="AUXCAPS2A.wReserved1"]/*' />
    [NativeTypeName("WORD")]
    public ushort wReserved1;

    /// <include file='AUXCAPS2A.xml' path='doc/member[@name="AUXCAPS2A.dwSupport"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwSupport;

    /// <include file='AUXCAPS2A.xml' path='doc/member[@name="AUXCAPS2A.ManufacturerGuid"]/*' />
    public Guid ManufacturerGuid;

    /// <include file='AUXCAPS2A.xml' path='doc/member[@name="AUXCAPS2A.ProductGuid"]/*' />
    public Guid ProductGuid;

    /// <include file='AUXCAPS2A.xml' path='doc/member[@name="AUXCAPS2A.NameGuid"]/*' />
    public Guid NameGuid;

    /// <include file='_szPname_e__FixedBuffer.xml' path='doc/member[@name="_szPname_e__FixedBuffer"]/*' />
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    [InlineArray(32)]
    [Obsolete("Possible string represented as a fixed-sized buffer.")]
    public partial struct _szPname_e__FixedBuffer
    {
        public sbyte e0;
    }
}
