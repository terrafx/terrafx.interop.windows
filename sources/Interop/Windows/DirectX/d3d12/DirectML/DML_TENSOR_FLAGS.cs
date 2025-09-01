// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from DirectML.h in microsoft/DirectX-Headers tag v1.616.0
// Original source is Copyright © Microsoft. Licensed under the MIT license

using System;

namespace TerraFX.Interop.DirectX;

/// <include file='DML_TENSOR_FLAGS.xml' path='doc/member[@name="DML_TENSOR_FLAGS"]/*' />
[Flags]
public enum DML_TENSOR_FLAGS
{
    /// <include file='DML_TENSOR_FLAGS.xml' path='doc/member[@name="DML_TENSOR_FLAGS.DML_TENSOR_FLAG_NONE"]/*' />
    DML_TENSOR_FLAG_NONE = 0x0,

    /// <include file='DML_TENSOR_FLAGS.xml' path='doc/member[@name="DML_TENSOR_FLAGS.DML_TENSOR_FLAG_OWNED_BY_DML"]/*' />
    DML_TENSOR_FLAG_OWNED_BY_DML = 0x1,
}
