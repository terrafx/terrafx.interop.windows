// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mmeapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='WAVEOUTCAPS2W.xml' path='doc/member[@name="WAVEOUTCAPS2W"]/*' />
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct WAVEOUTCAPS2W
{
    /// <include file='WAVEOUTCAPS2W.xml' path='doc/member[@name="WAVEOUTCAPS2W.wMid"]/*' />
    [NativeTypeName("WORD")]
    public ushort wMid;

    /// <include file='WAVEOUTCAPS2W.xml' path='doc/member[@name="WAVEOUTCAPS2W.wPid"]/*' />
    [NativeTypeName("WORD")]
    public ushort wPid;

    /// <include file='WAVEOUTCAPS2W.xml' path='doc/member[@name="WAVEOUTCAPS2W.vDriverVersion"]/*' />
    [NativeTypeName("MMVERSION")]
    public uint vDriverVersion;

    /// <include file='WAVEOUTCAPS2W.xml' path='doc/member[@name="WAVEOUTCAPS2W.szPname"]/*' />
    [NativeTypeName("WCHAR[32]")]
    public _szPname_e__FixedBuffer szPname;

    /// <include file='WAVEOUTCAPS2W.xml' path='doc/member[@name="WAVEOUTCAPS2W.dwFormats"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwFormats;

    /// <include file='WAVEOUTCAPS2W.xml' path='doc/member[@name="WAVEOUTCAPS2W.wChannels"]/*' />
    [NativeTypeName("WORD")]
    public ushort wChannels;

    /// <include file='WAVEOUTCAPS2W.xml' path='doc/member[@name="WAVEOUTCAPS2W.wReserved1"]/*' />
    [NativeTypeName("WORD")]
    public ushort wReserved1;

    /// <include file='WAVEOUTCAPS2W.xml' path='doc/member[@name="WAVEOUTCAPS2W.dwSupport"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwSupport;

    /// <include file='WAVEOUTCAPS2W.xml' path='doc/member[@name="WAVEOUTCAPS2W.ManufacturerGuid"]/*' />
    public Guid ManufacturerGuid;

    /// <include file='WAVEOUTCAPS2W.xml' path='doc/member[@name="WAVEOUTCAPS2W.ProductGuid"]/*' />
    public Guid ProductGuid;

    /// <include file='WAVEOUTCAPS2W.xml' path='doc/member[@name="WAVEOUTCAPS2W.NameGuid"]/*' />
    public Guid NameGuid;

    /// <include file='_szPname_e__FixedBuffer.xml' path='doc/member[@name="_szPname_e__FixedBuffer"]/*' />
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    [InlineArray(32)]
    public partial struct _szPname_e__FixedBuffer
    {
        public char e0;
    }
}
