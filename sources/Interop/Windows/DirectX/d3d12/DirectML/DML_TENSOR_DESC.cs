// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from DirectML.h in microsoft/DirectX-Headers tag v1.618.5
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='DML_TENSOR_DESC.xml' path='doc/member[@name="DML_TENSOR_DESC"]/*' />
public unsafe partial struct DML_TENSOR_DESC
{
    /// <include file='DML_TENSOR_DESC.xml' path='doc/member[@name="DML_TENSOR_DESC.Type"]/*' />
    public DML_TENSOR_TYPE Type;

    /// <include file='DML_TENSOR_DESC.xml' path='doc/member[@name="DML_TENSOR_DESC.Desc"]/*' />
    [NativeTypeName("const void *")]
    public void* Desc;
}
