// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dinput.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;

namespace TerraFX.Interop.DirectX;

/// <include file='DIDEVICEOBJECTINSTANCE_DX3.xml' path='doc/member[@name="DIDEVICEOBJECTINSTANCE_DX3"]/*' />
public partial struct DIDEVICEOBJECTINSTANCE_DX3
{
    /// <include file='DIDEVICEOBJECTINSTANCE_DX3.xml' path='doc/member[@name="DIDEVICEOBJECTINSTANCE_DX3.dwSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwSize;

    /// <include file='DIDEVICEOBJECTINSTANCE_DX3.xml' path='doc/member[@name="DIDEVICEOBJECTINSTANCE_DX3.guidType"]/*' />
    public Guid guidType;

    /// <include file='DIDEVICEOBJECTINSTANCE_DX3.xml' path='doc/member[@name="DIDEVICEOBJECTINSTANCE_DX3.dwOfs"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwOfs;

    /// <include file='DIDEVICEOBJECTINSTANCE_DX3.xml' path='doc/member[@name="DIDEVICEOBJECTINSTANCE_DX3.dwType"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwType;

    /// <include file='DIDEVICEOBJECTINSTANCE_DX3.xml' path='doc/member[@name="DIDEVICEOBJECTINSTANCE_DX3.dwFlags"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwFlags;

    /// <include file='DIDEVICEOBJECTINSTANCE_DX3.xml' path='doc/member[@name="DIDEVICEOBJECTINSTANCE_DX3.tszName"]/*' />
    [NativeTypeName("WCHAR[260]")]
    public _tszName_e__FixedBuffer tszName;

    /// <include file='_tszName_e__FixedBuffer.xml' path='doc/member[@name="_tszName_e__FixedBuffer"]/*' />
    [InlineArray(260)]
    public partial struct _tszName_e__FixedBuffer
    {
        public char e0;
    }
}
