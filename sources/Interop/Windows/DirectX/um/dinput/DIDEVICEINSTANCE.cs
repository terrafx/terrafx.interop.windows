// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dinput.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;

namespace TerraFX.Interop.DirectX;

/// <include file='DIDEVICEINSTANCE.xml' path='doc/member[@name="DIDEVICEINSTANCE"]/*' />
public partial struct DIDEVICEINSTANCE
{
    /// <include file='DIDEVICEINSTANCE.xml' path='doc/member[@name="DIDEVICEINSTANCE.dwSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwSize;

    /// <include file='DIDEVICEINSTANCE.xml' path='doc/member[@name="DIDEVICEINSTANCE.guidInstance"]/*' />
    public Guid guidInstance;

    /// <include file='DIDEVICEINSTANCE.xml' path='doc/member[@name="DIDEVICEINSTANCE.guidProduct"]/*' />
    public Guid guidProduct;

    /// <include file='DIDEVICEINSTANCE.xml' path='doc/member[@name="DIDEVICEINSTANCE.dwDevType"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwDevType;

    /// <include file='DIDEVICEINSTANCE.xml' path='doc/member[@name="DIDEVICEINSTANCE.tszInstanceName"]/*' />
    [NativeTypeName("WCHAR[260]")]
    public _tszInstanceName_e__FixedBuffer tszInstanceName;

    /// <include file='DIDEVICEINSTANCE.xml' path='doc/member[@name="DIDEVICEINSTANCE.tszProductName"]/*' />
    [NativeTypeName("WCHAR[260]")]
    public _tszProductName_e__FixedBuffer tszProductName;

    /// <include file='DIDEVICEINSTANCE.xml' path='doc/member[@name="DIDEVICEINSTANCE.guidFFDriver"]/*' />
    public Guid guidFFDriver;

    /// <include file='DIDEVICEINSTANCE.xml' path='doc/member[@name="DIDEVICEINSTANCE.wUsagePage"]/*' />
    [NativeTypeName("WORD")]
    public ushort wUsagePage;

    /// <include file='DIDEVICEINSTANCE.xml' path='doc/member[@name="DIDEVICEINSTANCE.wUsage"]/*' />
    [NativeTypeName("WORD")]
    public ushort wUsage;

    /// <include file='_tszInstanceName_e__FixedBuffer.xml' path='doc/member[@name="_tszInstanceName_e__FixedBuffer"]/*' />
    [InlineArray(260)]
    [Obsolete("Possible string represented as a fixed-sized buffer.")]
    public partial struct _tszInstanceName_e__FixedBuffer
    {
        public char e0;
    }

    /// <include file='_tszProductName_e__FixedBuffer.xml' path='doc/member[@name="_tszProductName_e__FixedBuffer"]/*' />
    [InlineArray(260)]
    [Obsolete("Possible string represented as a fixed-sized buffer.")]
    public partial struct _tszProductName_e__FixedBuffer
    {
        public char e0;
    }
}
