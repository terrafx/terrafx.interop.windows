// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_COMMAND_LIST_FLAGS.xml' path='doc/member[@name="D3D12_COMMAND_LIST_FLAGS"]/*' />
[Flags]
public enum D3D12_COMMAND_LIST_FLAGS
{
    /// <include file='D3D12_COMMAND_LIST_FLAGS.xml' path='doc/member[@name="D3D12_COMMAND_LIST_FLAGS.D3D12_COMMAND_LIST_FLAG_NONE"]/*' />
    D3D12_COMMAND_LIST_FLAG_NONE = 0,
}
