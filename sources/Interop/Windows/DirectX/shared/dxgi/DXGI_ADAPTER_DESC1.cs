// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/dxgi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;

/// <include file='DXGI_ADAPTER_DESC1.xml' path='doc/member[@name="DXGI_ADAPTER_DESC1"]/*' />
public partial struct DXGI_ADAPTER_DESC1
{
    /// <include file='DXGI_ADAPTER_DESC1.xml' path='doc/member[@name="DXGI_ADAPTER_DESC1.Description"]/*' />
    [NativeTypeName("WCHAR[128]")]
    public _Description_e__FixedBuffer Description;

    /// <include file='DXGI_ADAPTER_DESC1.xml' path='doc/member[@name="DXGI_ADAPTER_DESC1.VendorId"]/*' />
    public uint VendorId;

    /// <include file='DXGI_ADAPTER_DESC1.xml' path='doc/member[@name="DXGI_ADAPTER_DESC1.DeviceId"]/*' />
    public uint DeviceId;

    /// <include file='DXGI_ADAPTER_DESC1.xml' path='doc/member[@name="DXGI_ADAPTER_DESC1.SubSysId"]/*' />
    public uint SubSysId;

    /// <include file='DXGI_ADAPTER_DESC1.xml' path='doc/member[@name="DXGI_ADAPTER_DESC1.Revision"]/*' />
    public uint Revision;

    /// <include file='DXGI_ADAPTER_DESC1.xml' path='doc/member[@name="DXGI_ADAPTER_DESC1.DedicatedVideoMemory"]/*' />
    [NativeTypeName("SIZE_T")]
    public nuint DedicatedVideoMemory;

    /// <include file='DXGI_ADAPTER_DESC1.xml' path='doc/member[@name="DXGI_ADAPTER_DESC1.DedicatedSystemMemory"]/*' />
    [NativeTypeName("SIZE_T")]
    public nuint DedicatedSystemMemory;

    /// <include file='DXGI_ADAPTER_DESC1.xml' path='doc/member[@name="DXGI_ADAPTER_DESC1.SharedSystemMemory"]/*' />
    [NativeTypeName("SIZE_T")]
    public nuint SharedSystemMemory;

    /// <include file='DXGI_ADAPTER_DESC1.xml' path='doc/member[@name="DXGI_ADAPTER_DESC1.AdapterLuid"]/*' />
    public LUID AdapterLuid;

    /// <include file='DXGI_ADAPTER_DESC1.xml' path='doc/member[@name="DXGI_ADAPTER_DESC1.Flags"]/*' />
    public uint Flags;

    /// <include file='_Description_e__FixedBuffer.xml' path='doc/member[@name="_Description_e__FixedBuffer"]/*' />
    [InlineArray(128)]
    public partial struct _Description_e__FixedBuffer
    {
        public char e0;
    }
}
