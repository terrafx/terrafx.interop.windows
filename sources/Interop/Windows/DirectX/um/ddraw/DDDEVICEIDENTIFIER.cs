// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ddraw.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;

/// <include file='DDDEVICEIDENTIFIER.xml' path='doc/member[@name="DDDEVICEIDENTIFIER"]/*' />
public partial struct DDDEVICEIDENTIFIER
{
    /// <include file='DDDEVICEIDENTIFIER.xml' path='doc/member[@name="DDDEVICEIDENTIFIER.szDriver"]/*' />
    [NativeTypeName("char[512]")]
    public _szDriver_e__FixedBuffer szDriver;

    /// <include file='DDDEVICEIDENTIFIER.xml' path='doc/member[@name="DDDEVICEIDENTIFIER.szDescription"]/*' />
    [NativeTypeName("char[512]")]
    public _szDescription_e__FixedBuffer szDescription;

    /// <include file='DDDEVICEIDENTIFIER.xml' path='doc/member[@name="DDDEVICEIDENTIFIER.liDriverVersion"]/*' />
    public LARGE_INTEGER liDriverVersion;

    /// <include file='DDDEVICEIDENTIFIER.xml' path='doc/member[@name="DDDEVICEIDENTIFIER.dwVendorId"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwVendorId;

    /// <include file='DDDEVICEIDENTIFIER.xml' path='doc/member[@name="DDDEVICEIDENTIFIER.dwDeviceId"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwDeviceId;

    /// <include file='DDDEVICEIDENTIFIER.xml' path='doc/member[@name="DDDEVICEIDENTIFIER.dwSubSysId"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwSubSysId;

    /// <include file='DDDEVICEIDENTIFIER.xml' path='doc/member[@name="DDDEVICEIDENTIFIER.dwRevision"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwRevision;

    /// <include file='DDDEVICEIDENTIFIER.xml' path='doc/member[@name="DDDEVICEIDENTIFIER.guidDeviceIdentifier"]/*' />
    public Guid guidDeviceIdentifier;

    /// <include file='_szDriver_e__FixedBuffer.xml' path='doc/member[@name="_szDriver_e__FixedBuffer"]/*' />
    [InlineArray(512)]
    public partial struct _szDriver_e__FixedBuffer
    {
        public sbyte e0;
    }

    /// <include file='_szDescription_e__FixedBuffer.xml' path='doc/member[@name="_szDescription_e__FixedBuffer"]/*' />
    [InlineArray(512)]
    public partial struct _szDescription_e__FixedBuffer
    {
        public sbyte e0;
    }
}
