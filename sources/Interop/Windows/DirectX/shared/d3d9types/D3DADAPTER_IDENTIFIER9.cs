// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;

/// <include file='D3DADAPTER_IDENTIFIER9.xml' path='doc/member[@name="D3DADAPTER_IDENTIFIER9"]/*' />
public partial struct D3DADAPTER_IDENTIFIER9
{
    /// <include file='D3DADAPTER_IDENTIFIER9.xml' path='doc/member[@name="D3DADAPTER_IDENTIFIER9.Driver"]/*' />
    [NativeTypeName("char[512]")]
    public _Driver_e__FixedBuffer Driver;

    /// <include file='D3DADAPTER_IDENTIFIER9.xml' path='doc/member[@name="D3DADAPTER_IDENTIFIER9.Description"]/*' />
    [NativeTypeName("char[512]")]
    public _Description_e__FixedBuffer Description;

    /// <include file='D3DADAPTER_IDENTIFIER9.xml' path='doc/member[@name="D3DADAPTER_IDENTIFIER9.DeviceName"]/*' />
    [NativeTypeName("char[32]")]
    public _DeviceName_e__FixedBuffer DeviceName;

    /// <include file='D3DADAPTER_IDENTIFIER9.xml' path='doc/member[@name="D3DADAPTER_IDENTIFIER9.DriverVersion"]/*' />
    public LARGE_INTEGER DriverVersion;

    /// <include file='D3DADAPTER_IDENTIFIER9.xml' path='doc/member[@name="D3DADAPTER_IDENTIFIER9.VendorId"]/*' />
    [NativeTypeName("DWORD")]
    public uint VendorId;

    /// <include file='D3DADAPTER_IDENTIFIER9.xml' path='doc/member[@name="D3DADAPTER_IDENTIFIER9.DeviceId"]/*' />
    [NativeTypeName("DWORD")]
    public uint DeviceId;

    /// <include file='D3DADAPTER_IDENTIFIER9.xml' path='doc/member[@name="D3DADAPTER_IDENTIFIER9.SubSysId"]/*' />
    [NativeTypeName("DWORD")]
    public uint SubSysId;

    /// <include file='D3DADAPTER_IDENTIFIER9.xml' path='doc/member[@name="D3DADAPTER_IDENTIFIER9.Revision"]/*' />
    [NativeTypeName("DWORD")]
    public uint Revision;

    /// <include file='D3DADAPTER_IDENTIFIER9.xml' path='doc/member[@name="D3DADAPTER_IDENTIFIER9.DeviceIdentifier"]/*' />
    public Guid DeviceIdentifier;

    /// <include file='D3DADAPTER_IDENTIFIER9.xml' path='doc/member[@name="D3DADAPTER_IDENTIFIER9.WHQLLevel"]/*' />
    [NativeTypeName("DWORD")]
    public uint WHQLLevel;

    /// <include file='_Driver_e__FixedBuffer.xml' path='doc/member[@name="_Driver_e__FixedBuffer"]/*' />
    [InlineArray(512)]
    public partial struct _Driver_e__FixedBuffer
    {
        public sbyte e0;
    }

    /// <include file='_Description_e__FixedBuffer.xml' path='doc/member[@name="_Description_e__FixedBuffer"]/*' />
    [InlineArray(512)]
    public partial struct _Description_e__FixedBuffer
    {
        public sbyte e0;
    }

    /// <include file='_DeviceName_e__FixedBuffer.xml' path='doc/member[@name="_DeviceName_e__FixedBuffer"]/*' />
    [InlineArray(32)]
    public partial struct _DeviceName_e__FixedBuffer
    {
        public sbyte e0;
    }
}
