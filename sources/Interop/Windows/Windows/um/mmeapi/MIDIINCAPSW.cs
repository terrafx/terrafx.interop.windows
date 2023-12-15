// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mmeapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='MIDIINCAPSW.xml' path='doc/member[@name="MIDIINCAPSW"]/*' />
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct MIDIINCAPSW
{
    /// <include file='MIDIINCAPSW.xml' path='doc/member[@name="MIDIINCAPSW.wMid"]/*' />
    [NativeTypeName("WORD")]
    public ushort wMid;

    /// <include file='MIDIINCAPSW.xml' path='doc/member[@name="MIDIINCAPSW.wPid"]/*' />
    [NativeTypeName("WORD")]
    public ushort wPid;

    /// <include file='MIDIINCAPSW.xml' path='doc/member[@name="MIDIINCAPSW.vDriverVersion"]/*' />
    [NativeTypeName("MMVERSION")]
    public uint vDriverVersion;

    /// <include file='MIDIINCAPSW.xml' path='doc/member[@name="MIDIINCAPSW.szPname"]/*' />
    [NativeTypeName("WCHAR[32]")]
    public _szPname_e__FixedBuffer szPname;

    /// <include file='MIDIINCAPSW.xml' path='doc/member[@name="MIDIINCAPSW.dwSupport"]/*' />
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
