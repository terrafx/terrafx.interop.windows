// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mmeapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='AUXCAPSW.xml' path='doc/member[@name="AUXCAPSW"]/*' />
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct AUXCAPSW
{
    /// <include file='AUXCAPSW.xml' path='doc/member[@name="AUXCAPSW.wMid"]/*' />
    [NativeTypeName("WORD")]
    public ushort wMid;

    /// <include file='AUXCAPSW.xml' path='doc/member[@name="AUXCAPSW.wPid"]/*' />
    [NativeTypeName("WORD")]
    public ushort wPid;

    /// <include file='AUXCAPSW.xml' path='doc/member[@name="AUXCAPSW.vDriverVersion"]/*' />
    [NativeTypeName("MMVERSION")]
    public uint vDriverVersion;

    /// <include file='AUXCAPSW.xml' path='doc/member[@name="AUXCAPSW.szPname"]/*' />
    [NativeTypeName("WCHAR[32]")]
    public _szPname_e__FixedBuffer szPname;

    /// <include file='AUXCAPSW.xml' path='doc/member[@name="AUXCAPSW.wTechnology"]/*' />
    [NativeTypeName("WORD")]
    public ushort wTechnology;

    /// <include file='AUXCAPSW.xml' path='doc/member[@name="AUXCAPSW.wReserved1"]/*' />
    [NativeTypeName("WORD")]
    public ushort wReserved1;

    /// <include file='AUXCAPSW.xml' path='doc/member[@name="AUXCAPSW.dwSupport"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwSupport;

    /// <include file='_szPname_e__FixedBuffer.xml' path='doc/member[@name="_szPname_e__FixedBuffer"]/*' />
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    [InlineArray(32)]
    public partial struct _szPname_e__FixedBuffer
    {
        public char e0;
    }
}
