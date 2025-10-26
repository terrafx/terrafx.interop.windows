// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from DirectML.h in microsoft/DirectX-Headers tag v1.618.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='DML_BUFFER_BINDING.xml' path='doc/member[@name="DML_BUFFER_BINDING"]/*' />
public unsafe partial struct DML_BUFFER_BINDING
{
    /// <include file='DML_BUFFER_BINDING.xml' path='doc/member[@name="DML_BUFFER_BINDING.Buffer"]/*' />
    public ID3D12Resource* Buffer;

    /// <include file='DML_BUFFER_BINDING.xml' path='doc/member[@name="DML_BUFFER_BINDING.Offset"]/*' />
    [NativeTypeName("UINT64")]
    public ulong Offset;

    /// <include file='DML_BUFFER_BINDING.xml' path='doc/member[@name="DML_BUFFER_BINDING.SizeInBytes"]/*' />
    [NativeTypeName("UINT64")]
    public ulong SizeInBytes;
}
