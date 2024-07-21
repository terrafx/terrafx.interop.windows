// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dinput.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;

namespace TerraFX.Interop.DirectX;

/// <include file='DIDEVICEOBJECTINSTANCE_DX3A.xml' path='doc/member[@name="DIDEVICEOBJECTINSTANCE_DX3A"]/*' />
public partial struct DIDEVICEOBJECTINSTANCE_DX3A
{
    /// <include file='DIDEVICEOBJECTINSTANCE_DX3A.xml' path='doc/member[@name="DIDEVICEOBJECTINSTANCE_DX3A.dwSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwSize;

    /// <include file='DIDEVICEOBJECTINSTANCE_DX3A.xml' path='doc/member[@name="DIDEVICEOBJECTINSTANCE_DX3A.guidType"]/*' />
    public Guid guidType;

    /// <include file='DIDEVICEOBJECTINSTANCE_DX3A.xml' path='doc/member[@name="DIDEVICEOBJECTINSTANCE_DX3A.dwOfs"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwOfs;

    /// <include file='DIDEVICEOBJECTINSTANCE_DX3A.xml' path='doc/member[@name="DIDEVICEOBJECTINSTANCE_DX3A.dwType"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwType;

    /// <include file='DIDEVICEOBJECTINSTANCE_DX3A.xml' path='doc/member[@name="DIDEVICEOBJECTINSTANCE_DX3A.dwFlags"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwFlags;

    /// <include file='DIDEVICEOBJECTINSTANCE_DX3A.xml' path='doc/member[@name="DIDEVICEOBJECTINSTANCE_DX3A.tszName"]/*' />
    [NativeTypeName("CHAR[260]")]
    public _tszName_e__FixedBuffer tszName;

    /// <include file='_tszName_e__FixedBuffer.xml' path='doc/member[@name="_tszName_e__FixedBuffer"]/*' />
    [InlineArray(260)]
    public partial struct _tszName_e__FixedBuffer
    {
        public sbyte e0;
    }
}
