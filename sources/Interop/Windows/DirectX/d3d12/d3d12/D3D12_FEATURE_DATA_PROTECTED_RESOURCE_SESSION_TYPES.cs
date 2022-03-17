// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_FEATURE_DATA_PROTECTED_RESOURCE_SESSION_TYPES.xml' path='doc/member[@name="D3D12_FEATURE_DATA_PROTECTED_RESOURCE_SESSION_TYPES"]/*' />
public unsafe partial struct D3D12_FEATURE_DATA_PROTECTED_RESOURCE_SESSION_TYPES
{
    /// <include file='D3D12_FEATURE_DATA_PROTECTED_RESOURCE_SESSION_TYPES.xml' path='doc/member[@name="D3D12_FEATURE_DATA_PROTECTED_RESOURCE_SESSION_TYPES.NodeIndex"]/*' />
    public uint NodeIndex;

    /// <include file='D3D12_FEATURE_DATA_PROTECTED_RESOURCE_SESSION_TYPES.xml' path='doc/member[@name="D3D12_FEATURE_DATA_PROTECTED_RESOURCE_SESSION_TYPES.Count"]/*' />
    public uint Count;

    /// <include file='D3D12_FEATURE_DATA_PROTECTED_RESOURCE_SESSION_TYPES.xml' path='doc/member[@name="D3D12_FEATURE_DATA_PROTECTED_RESOURCE_SESSION_TYPES.pTypes"]/*' />
    public Guid* pTypes;
}
