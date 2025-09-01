// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from DirectML.h in microsoft/DirectX-Headers tag v1.616.0
// Original source is Copyright © Microsoft. Licensed under the MIT license

using System.Runtime.Versioning;

namespace TerraFX.Interop.DirectX;

/// <include file='DML_RESAMPLE_OPERATOR_DESC.xml' path='doc/member[@name="DML_RESAMPLE_OPERATOR_DESC"]/*' />
[SupportedOSPlatform("windows10.0.19041.0")]
public unsafe partial struct DML_RESAMPLE_OPERATOR_DESC
{
    /// <include file='DML_RESAMPLE_OPERATOR_DESC.xml' path='doc/member[@name="DML_RESAMPLE_OPERATOR_DESC.InputTensor"]/*' />
    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DML_TENSOR_DESC* InputTensor;

    /// <include file='DML_RESAMPLE_OPERATOR_DESC.xml' path='doc/member[@name="DML_RESAMPLE_OPERATOR_DESC.OutputTensor"]/*' />
    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DML_TENSOR_DESC* OutputTensor;

    /// <include file='DML_RESAMPLE_OPERATOR_DESC.xml' path='doc/member[@name="DML_RESAMPLE_OPERATOR_DESC.InterpolationMode"]/*' />
    public DML_INTERPOLATION_MODE InterpolationMode;

    /// <include file='DML_RESAMPLE_OPERATOR_DESC.xml' path='doc/member[@name="DML_RESAMPLE_OPERATOR_DESC.ScaleCount"]/*' />
    public uint ScaleCount;

    /// <include file='DML_RESAMPLE_OPERATOR_DESC.xml' path='doc/member[@name="DML_RESAMPLE_OPERATOR_DESC.Scales"]/*' />
    [NativeTypeName("const FLOAT *")]
    public float* Scales;
}
