// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mmeapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='WAVEOUTCAPSA.xml' path='doc/member[@name="WAVEOUTCAPSA"]/*' />
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct WAVEOUTCAPSA
{
    /// <include file='WAVEOUTCAPSA.xml' path='doc/member[@name="WAVEOUTCAPSA.wMid"]/*' />
    [NativeTypeName("WORD")]
    public ushort wMid;

    /// <include file='WAVEOUTCAPSA.xml' path='doc/member[@name="WAVEOUTCAPSA.wPid"]/*' />
    [NativeTypeName("WORD")]
    public ushort wPid;

    /// <include file='WAVEOUTCAPSA.xml' path='doc/member[@name="WAVEOUTCAPSA.vDriverVersion"]/*' />
    [NativeTypeName("MMVERSION")]
    public uint vDriverVersion;

    /// <include file='WAVEOUTCAPSA.xml' path='doc/member[@name="WAVEOUTCAPSA.szPname"]/*' />
    [NativeTypeName("CHAR[32]")]
    public _szPname_e__FixedBuffer szPname;

    /// <include file='WAVEOUTCAPSA.xml' path='doc/member[@name="WAVEOUTCAPSA.dwFormats"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwFormats;

    /// <include file='WAVEOUTCAPSA.xml' path='doc/member[@name="WAVEOUTCAPSA.wChannels"]/*' />
    [NativeTypeName("WORD")]
    public ushort wChannels;

    /// <include file='WAVEOUTCAPSA.xml' path='doc/member[@name="WAVEOUTCAPSA.wReserved1"]/*' />
    [NativeTypeName("WORD")]
    public ushort wReserved1;

    /// <include file='WAVEOUTCAPSA.xml' path='doc/member[@name="WAVEOUTCAPSA.dwSupport"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwSupport;

    /// <include file='_szPname_e__FixedBuffer.xml' path='doc/member[@name="_szPname_e__FixedBuffer"]/*' />
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    [InlineArray(32)]
    [Obsolete("Possible string represented as a fixed-sized buffer.")]
    public partial struct _szPname_e__FixedBuffer
    {
        public sbyte e0;
    }
}
