// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.620.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_DEVICE_ERROR_CODE.xml' path='doc/member[@name="D3D12_DEVICE_ERROR_CODE"]/*' />
public enum D3D12_DEVICE_ERROR_CODE
{
    /// <include file='D3D12_DEVICE_ERROR_CODE.xml' path='doc/member[@name="D3D12_DEVICE_ERROR_CODE.D3D12_DEVICE_ERROR_NONE"]/*' />
    D3D12_DEVICE_ERROR_NONE = 0,

    /// <include file='D3D12_DEVICE_ERROR_CODE.xml' path='doc/member[@name="D3D12_DEVICE_ERROR_CODE.D3D12_DEVICE_ERROR_DEVICE_HUNG"]/*' />
    D3D12_DEVICE_ERROR_DEVICE_HUNG = 7,

    /// <include file='D3D12_DEVICE_ERROR_CODE.xml' path='doc/member[@name="D3D12_DEVICE_ERROR_CODE.D3D12_DEVICE_ERROR_PAGE_FAULT"]/*' />
    D3D12_DEVICE_ERROR_PAGE_FAULT = 9,

    /// <include file='D3D12_DEVICE_ERROR_CODE.xml' path='doc/member[@name="D3D12_DEVICE_ERROR_CODE.D3D12_DEVICE_ERROR_UNKNOWN"]/*' />
    D3D12_DEVICE_ERROR_UNKNOWN = unchecked((int)(0x88000000)),
}
