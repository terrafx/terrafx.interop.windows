// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dinput.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;

namespace TerraFX.Interop.DirectX;

/// <include file='DIDEVICEINSTANCEA.xml' path='doc/member[@name="DIDEVICEINSTANCEA"]/*' />
public partial struct DIDEVICEINSTANCEA
{
    /// <include file='DIDEVICEINSTANCEA.xml' path='doc/member[@name="DIDEVICEINSTANCEA.dwSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwSize;

    /// <include file='DIDEVICEINSTANCEA.xml' path='doc/member[@name="DIDEVICEINSTANCEA.guidInstance"]/*' />
    public Guid guidInstance;

    /// <include file='DIDEVICEINSTANCEA.xml' path='doc/member[@name="DIDEVICEINSTANCEA.guidProduct"]/*' />
    public Guid guidProduct;

    /// <include file='DIDEVICEINSTANCEA.xml' path='doc/member[@name="DIDEVICEINSTANCEA.dwDevType"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwDevType;

    /// <include file='DIDEVICEINSTANCEA.xml' path='doc/member[@name="DIDEVICEINSTANCEA.tszInstanceName"]/*' />
    [NativeTypeName("CHAR[260]")]
    public _tszInstanceName_e__FixedBuffer tszInstanceName;

    /// <include file='DIDEVICEINSTANCEA.xml' path='doc/member[@name="DIDEVICEINSTANCEA.tszProductName"]/*' />
    [NativeTypeName("CHAR[260]")]
    public _tszProductName_e__FixedBuffer tszProductName;

    /// <include file='DIDEVICEINSTANCEA.xml' path='doc/member[@name="DIDEVICEINSTANCEA.guidFFDriver"]/*' />
    public Guid guidFFDriver;

    /// <include file='DIDEVICEINSTANCEA.xml' path='doc/member[@name="DIDEVICEINSTANCEA.wUsagePage"]/*' />
    [NativeTypeName("WORD")]
    public ushort wUsagePage;

    /// <include file='DIDEVICEINSTANCEA.xml' path='doc/member[@name="DIDEVICEINSTANCEA.wUsage"]/*' />
    [NativeTypeName("WORD")]
    public ushort wUsage;

    /// <include file='_tszInstanceName_e__FixedBuffer.xml' path='doc/member[@name="_tszInstanceName_e__FixedBuffer"]/*' />
    [InlineArray(260)]
    public partial struct _tszInstanceName_e__FixedBuffer
    {
        public sbyte e0;
    }

    /// <include file='_tszProductName_e__FixedBuffer.xml' path='doc/member[@name="_tszProductName_e__FixedBuffer"]/*' />
    [InlineArray(260)]
    public partial struct _tszProductName_e__FixedBuffer
    {
        public sbyte e0;
    }
}
