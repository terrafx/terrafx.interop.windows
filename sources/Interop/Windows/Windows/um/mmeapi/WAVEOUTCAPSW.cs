// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mmeapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='WAVEOUTCAPSW.xml' path='doc/member[@name="WAVEOUTCAPSW"]/*' />
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct WAVEOUTCAPSW
{
    /// <include file='WAVEOUTCAPSW.xml' path='doc/member[@name="WAVEOUTCAPSW.wMid"]/*' />
    [NativeTypeName("WORD")]
    public ushort wMid;

    /// <include file='WAVEOUTCAPSW.xml' path='doc/member[@name="WAVEOUTCAPSW.wPid"]/*' />
    [NativeTypeName("WORD")]
    public ushort wPid;

    /// <include file='WAVEOUTCAPSW.xml' path='doc/member[@name="WAVEOUTCAPSW.vDriverVersion"]/*' />
    [NativeTypeName("MMVERSION")]
    public uint vDriverVersion;

    /// <include file='WAVEOUTCAPSW.xml' path='doc/member[@name="WAVEOUTCAPSW.szPname"]/*' />
    [NativeTypeName("WCHAR[32]")]
    public _szPname_e__FixedBuffer szPname;

    /// <include file='WAVEOUTCAPSW.xml' path='doc/member[@name="WAVEOUTCAPSW.dwFormats"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwFormats;

    /// <include file='WAVEOUTCAPSW.xml' path='doc/member[@name="WAVEOUTCAPSW.wChannels"]/*' />
    [NativeTypeName("WORD")]
    public ushort wChannels;

    /// <include file='WAVEOUTCAPSW.xml' path='doc/member[@name="WAVEOUTCAPSW.wReserved1"]/*' />
    [NativeTypeName("WORD")]
    public ushort wReserved1;

    /// <include file='WAVEOUTCAPSW.xml' path='doc/member[@name="WAVEOUTCAPSW.dwSupport"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwSupport;

    /// <include file='_szPname_e__FixedBuffer.xml' path='doc/member[@name="_szPname_e__FixedBuffer"]/*' />
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    [InlineArray(32)]
    [Obsolete("Possible string represented as a fixed-sized buffer.")]
    public partial struct _szPname_e__FixedBuffer
    {
        public char e0;
    }
}
