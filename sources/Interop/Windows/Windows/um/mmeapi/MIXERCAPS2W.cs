// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mmeapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='MIXERCAPS2W.xml' path='doc/member[@name="MIXERCAPS2W"]/*' />
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct MIXERCAPS2W
{
    /// <include file='MIXERCAPS2W.xml' path='doc/member[@name="MIXERCAPS2W.wMid"]/*' />
    [NativeTypeName("WORD")]
    public ushort wMid;

    /// <include file='MIXERCAPS2W.xml' path='doc/member[@name="MIXERCAPS2W.wPid"]/*' />
    [NativeTypeName("WORD")]
    public ushort wPid;

    /// <include file='MIXERCAPS2W.xml' path='doc/member[@name="MIXERCAPS2W.vDriverVersion"]/*' />
    [NativeTypeName("MMVERSION")]
    public uint vDriverVersion;

    /// <include file='MIXERCAPS2W.xml' path='doc/member[@name="MIXERCAPS2W.szPname"]/*' />
    [NativeTypeName("WCHAR[32]")]
    public _szPname_e__FixedBuffer szPname;

    /// <include file='MIXERCAPS2W.xml' path='doc/member[@name="MIXERCAPS2W.fdwSupport"]/*' />
    [NativeTypeName("DWORD")]
    public uint fdwSupport;

    /// <include file='MIXERCAPS2W.xml' path='doc/member[@name="MIXERCAPS2W.cDestinations"]/*' />
    [NativeTypeName("DWORD")]
    public uint cDestinations;

    /// <include file='MIXERCAPS2W.xml' path='doc/member[@name="MIXERCAPS2W.ManufacturerGuid"]/*' />
    public Guid ManufacturerGuid;

    /// <include file='MIXERCAPS2W.xml' path='doc/member[@name="MIXERCAPS2W.ProductGuid"]/*' />
    public Guid ProductGuid;

    /// <include file='MIXERCAPS2W.xml' path='doc/member[@name="MIXERCAPS2W.NameGuid"]/*' />
    public Guid NameGuid;

    /// <include file='_szPname_e__FixedBuffer.xml' path='doc/member[@name="_szPname_e__FixedBuffer"]/*' />
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    [InlineArray(32)]
    public partial struct _szPname_e__FixedBuffer
    {
        public char e0;
    }
}
