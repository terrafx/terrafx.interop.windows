// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ddraw.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;

/// <include file='DDDEVICEIDENTIFIER2.xml' path='doc/member[@name="DDDEVICEIDENTIFIER2"]/*' />
public partial struct DDDEVICEIDENTIFIER2
{
    /// <include file='DDDEVICEIDENTIFIER2.xml' path='doc/member[@name="DDDEVICEIDENTIFIER2.szDriver"]/*' />
    [NativeTypeName("char[512]")]
    public _szDriver_e__FixedBuffer szDriver;

    /// <include file='DDDEVICEIDENTIFIER2.xml' path='doc/member[@name="DDDEVICEIDENTIFIER2.szDescription"]/*' />
    [NativeTypeName("char[512]")]
    public _szDescription_e__FixedBuffer szDescription;

    /// <include file='DDDEVICEIDENTIFIER2.xml' path='doc/member[@name="DDDEVICEIDENTIFIER2.liDriverVersion"]/*' />
    public LARGE_INTEGER liDriverVersion;

    /// <include file='DDDEVICEIDENTIFIER2.xml' path='doc/member[@name="DDDEVICEIDENTIFIER2.dwVendorId"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwVendorId;

    /// <include file='DDDEVICEIDENTIFIER2.xml' path='doc/member[@name="DDDEVICEIDENTIFIER2.dwDeviceId"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwDeviceId;

    /// <include file='DDDEVICEIDENTIFIER2.xml' path='doc/member[@name="DDDEVICEIDENTIFIER2.dwSubSysId"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwSubSysId;

    /// <include file='DDDEVICEIDENTIFIER2.xml' path='doc/member[@name="DDDEVICEIDENTIFIER2.dwRevision"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwRevision;

    /// <include file='DDDEVICEIDENTIFIER2.xml' path='doc/member[@name="DDDEVICEIDENTIFIER2.guidDeviceIdentifier"]/*' />
    public Guid guidDeviceIdentifier;

    /// <include file='DDDEVICEIDENTIFIER2.xml' path='doc/member[@name="DDDEVICEIDENTIFIER2.dwWHQLLevel"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwWHQLLevel;

    /// <include file='_szDriver_e__FixedBuffer.xml' path='doc/member[@name="_szDriver_e__FixedBuffer"]/*' />
    [InlineArray(512)]
    [Obsolete("Possible string represented as a fixed-sized buffer.")]
    public partial struct _szDriver_e__FixedBuffer
    {
        public sbyte e0;
    }

    /// <include file='_szDescription_e__FixedBuffer.xml' path='doc/member[@name="_szDescription_e__FixedBuffer"]/*' />
    [InlineArray(512)]
    [Obsolete("Possible string represented as a fixed-sized buffer.")]
    public partial struct _szDescription_e__FixedBuffer
    {
        public sbyte e0;
    }
}
