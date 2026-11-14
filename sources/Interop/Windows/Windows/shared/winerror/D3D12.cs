// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/winerror.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;

public static partial class D3D12
{
    /// <include file='D3D12.xml' path='doc/member[@name="D3D12.D3D12_ERROR_ADAPTER_NOT_FOUND"]/*' />
    [NativeTypeName("#define D3D12_ERROR_ADAPTER_NOT_FOUND _HRESULT_TYPEDEF_(0x887E0001L)")]
    public const int D3D12_ERROR_ADAPTER_NOT_FOUND = unchecked((int)(0x887E0001));

    /// <include file='D3D12.xml' path='doc/member[@name="D3D12.D3D12_ERROR_DRIVER_VERSION_MISMATCH"]/*' />
    [NativeTypeName("#define D3D12_ERROR_DRIVER_VERSION_MISMATCH _HRESULT_TYPEDEF_(0x887E0002L)")]
    public const int D3D12_ERROR_DRIVER_VERSION_MISMATCH = unchecked((int)(0x887E0002));

    /// <include file='D3D12.xml' path='doc/member[@name="D3D12.D3D12_ERROR_INVALID_REDIST"]/*' />
    [NativeTypeName("#define D3D12_ERROR_INVALID_REDIST _HRESULT_TYPEDEF_(0x887E0003L)")]
    public const int D3D12_ERROR_INVALID_REDIST = unchecked((int)(0x887E0003));
}
