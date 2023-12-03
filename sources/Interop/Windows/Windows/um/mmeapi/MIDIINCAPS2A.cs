// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mmeapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='MIDIINCAPS2A.xml' path='doc/member[@name="MIDIINCAPS2A"]/*' />
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct MIDIINCAPS2A
{
    /// <include file='MIDIINCAPS2A.xml' path='doc/member[@name="MIDIINCAPS2A.wMid"]/*' />
    [NativeTypeName("WORD")]
    public ushort wMid;

    /// <include file='MIDIINCAPS2A.xml' path='doc/member[@name="MIDIINCAPS2A.wPid"]/*' />
    [NativeTypeName("WORD")]
    public ushort wPid;

    /// <include file='MIDIINCAPS2A.xml' path='doc/member[@name="MIDIINCAPS2A.vDriverVersion"]/*' />
    [NativeTypeName("MMVERSION")]
    public uint vDriverVersion;

    /// <include file='MIDIINCAPS2A.xml' path='doc/member[@name="MIDIINCAPS2A.szPname"]/*' />
    [NativeTypeName("CHAR[32]")]
    public _szPname_e__FixedBuffer szPname;

    /// <include file='MIDIINCAPS2A.xml' path='doc/member[@name="MIDIINCAPS2A.dwSupport"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwSupport;

    /// <include file='MIDIINCAPS2A.xml' path='doc/member[@name="MIDIINCAPS2A.ManufacturerGuid"]/*' />
    public Guid ManufacturerGuid;

    /// <include file='MIDIINCAPS2A.xml' path='doc/member[@name="MIDIINCAPS2A.ProductGuid"]/*' />
    public Guid ProductGuid;

    /// <include file='MIDIINCAPS2A.xml' path='doc/member[@name="MIDIINCAPS2A.NameGuid"]/*' />
    public Guid NameGuid;

    /// <include file='_szPname_e__FixedBuffer.xml' path='doc/member[@name="_szPname_e__FixedBuffer"]/*' />
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    [InlineArray(32)]
    public partial struct _szPname_e__FixedBuffer
    {
        public sbyte e0;
    }
}
