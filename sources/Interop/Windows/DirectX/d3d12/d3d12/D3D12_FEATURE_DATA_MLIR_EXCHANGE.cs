// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.620.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_FEATURE_DATA_MLIR_EXCHANGE.xml' path='doc/member[@name="D3D12_FEATURE_DATA_MLIR_EXCHANGE"]/*' />
public unsafe partial struct D3D12_FEATURE_DATA_MLIR_EXCHANGE
{
    /// <include file='D3D12_FEATURE_DATA_MLIR_EXCHANGE.xml' path='doc/member[@name="D3D12_FEATURE_DATA_MLIR_EXCHANGE.Type"]/*' />
    public D3D12_MLIR_EXCHANGE_TYPE Type;

    /// <include file='D3D12_FEATURE_DATA_MLIR_EXCHANGE.xml' path='doc/member[@name="D3D12_FEATURE_DATA_MLIR_EXCHANGE.IRVersion"]/*' />
    public D3D12_VERSION_NUMBER IRVersion;

    /// <include file='D3D12_FEATURE_DATA_MLIR_EXCHANGE.xml' path='doc/member[@name="D3D12_FEATURE_DATA_MLIR_EXCHANGE.pInputData"]/*' />
    [NativeTypeName("const void *")]
    public void* pInputData;

    /// <include file='D3D12_FEATURE_DATA_MLIR_EXCHANGE.xml' path='doc/member[@name="D3D12_FEATURE_DATA_MLIR_EXCHANGE.InputDataSizeInBytes"]/*' />
    [NativeTypeName("SIZE_T")]
    public nuint InputDataSizeInBytes;

    /// <include file='D3D12_FEATURE_DATA_MLIR_EXCHANGE.xml' path='doc/member[@name="D3D12_FEATURE_DATA_MLIR_EXCHANGE.pOutputData"]/*' />
    public void* pOutputData;

    /// <include file='D3D12_FEATURE_DATA_MLIR_EXCHANGE.xml' path='doc/member[@name="D3D12_FEATURE_DATA_MLIR_EXCHANGE.OutputDataSizeInBytes"]/*' />
    [NativeTypeName("SIZE_T *")]
    public nuint* OutputDataSizeInBytes;
}
