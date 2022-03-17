// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_PROTECTED_RESOURCE_SESSION_DESC1.xml' path='doc/member[@name="D3D12_PROTECTED_RESOURCE_SESSION_DESC1"]/*' />
public partial struct D3D12_PROTECTED_RESOURCE_SESSION_DESC1
{
    /// <include file='D3D12_PROTECTED_RESOURCE_SESSION_DESC1.xml' path='doc/member[@name="D3D12_PROTECTED_RESOURCE_SESSION_DESC1.NodeMask"]/*' />
    public uint NodeMask;

    /// <include file='D3D12_PROTECTED_RESOURCE_SESSION_DESC1.xml' path='doc/member[@name="D3D12_PROTECTED_RESOURCE_SESSION_DESC1.Flags"]/*' />
    public D3D12_PROTECTED_RESOURCE_SESSION_FLAGS Flags;

    /// <include file='D3D12_PROTECTED_RESOURCE_SESSION_DESC1.xml' path='doc/member[@name="D3D12_PROTECTED_RESOURCE_SESSION_DESC1.ProtectionType"]/*' />
    public Guid ProtectionType;
}
