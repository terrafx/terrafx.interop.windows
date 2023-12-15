// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/dxgi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;

/// <include file='DXGI_ADAPTER_DESC.xml' path='doc/member[@name="DXGI_ADAPTER_DESC"]/*' />
public partial struct DXGI_ADAPTER_DESC
{
    /// <include file='DXGI_ADAPTER_DESC.xml' path='doc/member[@name="DXGI_ADAPTER_DESC.Description"]/*' />
    [NativeTypeName("WCHAR[128]")]
    public _Description_e__FixedBuffer Description;

    /// <include file='DXGI_ADAPTER_DESC.xml' path='doc/member[@name="DXGI_ADAPTER_DESC.VendorId"]/*' />
    public uint VendorId;

    /// <include file='DXGI_ADAPTER_DESC.xml' path='doc/member[@name="DXGI_ADAPTER_DESC.DeviceId"]/*' />
    public uint DeviceId;

    /// <include file='DXGI_ADAPTER_DESC.xml' path='doc/member[@name="DXGI_ADAPTER_DESC.SubSysId"]/*' />
    public uint SubSysId;

    /// <include file='DXGI_ADAPTER_DESC.xml' path='doc/member[@name="DXGI_ADAPTER_DESC.Revision"]/*' />
    public uint Revision;

    /// <include file='DXGI_ADAPTER_DESC.xml' path='doc/member[@name="DXGI_ADAPTER_DESC.DedicatedVideoMemory"]/*' />
    [NativeTypeName("SIZE_T")]
    public nuint DedicatedVideoMemory;

    /// <include file='DXGI_ADAPTER_DESC.xml' path='doc/member[@name="DXGI_ADAPTER_DESC.DedicatedSystemMemory"]/*' />
    [NativeTypeName("SIZE_T")]
    public nuint DedicatedSystemMemory;

    /// <include file='DXGI_ADAPTER_DESC.xml' path='doc/member[@name="DXGI_ADAPTER_DESC.SharedSystemMemory"]/*' />
    [NativeTypeName("SIZE_T")]
    public nuint SharedSystemMemory;

    /// <include file='DXGI_ADAPTER_DESC.xml' path='doc/member[@name="DXGI_ADAPTER_DESC.AdapterLuid"]/*' />
    public LUID AdapterLuid;

    /// <include file='_Description_e__FixedBuffer.xml' path='doc/member[@name="_Description_e__FixedBuffer"]/*' />
    [InlineArray(128)]
    public partial struct _Description_e__FixedBuffer
    {
        public char e0;
    }
}
