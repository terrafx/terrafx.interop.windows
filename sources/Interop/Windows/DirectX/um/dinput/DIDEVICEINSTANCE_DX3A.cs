// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dinput.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;

namespace TerraFX.Interop.DirectX;

/// <include file='DIDEVICEINSTANCE_DX3A.xml' path='doc/member[@name="DIDEVICEINSTANCE_DX3A"]/*' />
public partial struct DIDEVICEINSTANCE_DX3A
{
    /// <include file='DIDEVICEINSTANCE_DX3A.xml' path='doc/member[@name="DIDEVICEINSTANCE_DX3A.dwSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwSize;

    /// <include file='DIDEVICEINSTANCE_DX3A.xml' path='doc/member[@name="DIDEVICEINSTANCE_DX3A.guidInstance"]/*' />
    public Guid guidInstance;

    /// <include file='DIDEVICEINSTANCE_DX3A.xml' path='doc/member[@name="DIDEVICEINSTANCE_DX3A.guidProduct"]/*' />
    public Guid guidProduct;

    /// <include file='DIDEVICEINSTANCE_DX3A.xml' path='doc/member[@name="DIDEVICEINSTANCE_DX3A.dwDevType"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwDevType;

    /// <include file='DIDEVICEINSTANCE_DX3A.xml' path='doc/member[@name="DIDEVICEINSTANCE_DX3A.tszInstanceName"]/*' />
    [NativeTypeName("CHAR[260]")]
    public _tszInstanceName_e__FixedBuffer tszInstanceName;

    /// <include file='DIDEVICEINSTANCE_DX3A.xml' path='doc/member[@name="DIDEVICEINSTANCE_DX3A.tszProductName"]/*' />
    [NativeTypeName("CHAR[260]")]
    public _tszProductName_e__FixedBuffer tszProductName;

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
