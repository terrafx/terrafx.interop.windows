// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from DirectML.h in microsoft/DirectX-Headers tag v1.618.5
// Original source is Copyright © Microsoft. Licensed under the MIT license

using System.Runtime.Versioning;

namespace TerraFX.Interop.DirectX;

/// <include file='DML_MAX_POOLING1_OPERATOR_DESC.xml' path='doc/member[@name="DML_MAX_POOLING1_OPERATOR_DESC"]/*' />
[SupportedOSPlatform("windows10.0.19041.0")]
public unsafe partial struct DML_MAX_POOLING1_OPERATOR_DESC
{
    /// <include file='DML_MAX_POOLING1_OPERATOR_DESC.xml' path='doc/member[@name="DML_MAX_POOLING1_OPERATOR_DESC.InputTensor"]/*' />
    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DML_TENSOR_DESC* InputTensor;

    /// <include file='DML_MAX_POOLING1_OPERATOR_DESC.xml' path='doc/member[@name="DML_MAX_POOLING1_OPERATOR_DESC.OutputTensor"]/*' />
    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DML_TENSOR_DESC* OutputTensor;

    /// <include file='DML_MAX_POOLING1_OPERATOR_DESC.xml' path='doc/member[@name="DML_MAX_POOLING1_OPERATOR_DESC.OutputIndicesTensor"]/*' />
    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DML_TENSOR_DESC* OutputIndicesTensor;

    /// <include file='DML_MAX_POOLING1_OPERATOR_DESC.xml' path='doc/member[@name="DML_MAX_POOLING1_OPERATOR_DESC.DimensionCount"]/*' />
    public uint DimensionCount;

    /// <include file='DML_MAX_POOLING1_OPERATOR_DESC.xml' path='doc/member[@name="DML_MAX_POOLING1_OPERATOR_DESC.Strides"]/*' />
    [NativeTypeName("const UINT *")]
    public uint* Strides;

    /// <include file='DML_MAX_POOLING1_OPERATOR_DESC.xml' path='doc/member[@name="DML_MAX_POOLING1_OPERATOR_DESC.WindowSize"]/*' />
    [NativeTypeName("const UINT *")]
    public uint* WindowSize;

    /// <include file='DML_MAX_POOLING1_OPERATOR_DESC.xml' path='doc/member[@name="DML_MAX_POOLING1_OPERATOR_DESC.StartPadding"]/*' />
    [NativeTypeName("const UINT *")]
    public uint* StartPadding;

    /// <include file='DML_MAX_POOLING1_OPERATOR_DESC.xml' path='doc/member[@name="DML_MAX_POOLING1_OPERATOR_DESC.EndPadding"]/*' />
    [NativeTypeName("const UINT *")]
    public uint* EndPadding;
}
