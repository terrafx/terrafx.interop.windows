// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mmeapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='WAVEINCAPS2A.xml' path='doc/member[@name="WAVEINCAPS2A"]/*' />
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct WAVEINCAPS2A
{
    /// <include file='WAVEINCAPS2A.xml' path='doc/member[@name="WAVEINCAPS2A.wMid"]/*' />
    [NativeTypeName("WORD")]
    public ushort wMid;

    /// <include file='WAVEINCAPS2A.xml' path='doc/member[@name="WAVEINCAPS2A.wPid"]/*' />
    [NativeTypeName("WORD")]
    public ushort wPid;

    /// <include file='WAVEINCAPS2A.xml' path='doc/member[@name="WAVEINCAPS2A.vDriverVersion"]/*' />
    [NativeTypeName("MMVERSION")]
    public uint vDriverVersion;

    /// <include file='WAVEINCAPS2A.xml' path='doc/member[@name="WAVEINCAPS2A.szPname"]/*' />
    [NativeTypeName("CHAR[32]")]
    public _szPname_e__FixedBuffer szPname;

    /// <include file='WAVEINCAPS2A.xml' path='doc/member[@name="WAVEINCAPS2A.dwFormats"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwFormats;

    /// <include file='WAVEINCAPS2A.xml' path='doc/member[@name="WAVEINCAPS2A.wChannels"]/*' />
    [NativeTypeName("WORD")]
    public ushort wChannels;

    /// <include file='WAVEINCAPS2A.xml' path='doc/member[@name="WAVEINCAPS2A.wReserved1"]/*' />
    [NativeTypeName("WORD")]
    public ushort wReserved1;

    /// <include file='WAVEINCAPS2A.xml' path='doc/member[@name="WAVEINCAPS2A.ManufacturerGuid"]/*' />
    public Guid ManufacturerGuid;

    /// <include file='WAVEINCAPS2A.xml' path='doc/member[@name="WAVEINCAPS2A.ProductGuid"]/*' />
    public Guid ProductGuid;

    /// <include file='WAVEINCAPS2A.xml' path='doc/member[@name="WAVEINCAPS2A.NameGuid"]/*' />
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
