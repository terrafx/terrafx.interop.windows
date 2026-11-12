// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.620.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_FEATURE_DATA_USER_DEFINED_ANNOTATION.xml' path='doc/member[@name="D3D12_FEATURE_DATA_USER_DEFINED_ANNOTATION"]/*' />
public partial struct D3D12_FEATURE_DATA_USER_DEFINED_ANNOTATION
{
    /// <include file='D3D12_FEATURE_DATA_USER_DEFINED_ANNOTATION.xml' path='doc/member[@name="D3D12_FEATURE_DATA_USER_DEFINED_ANNOTATION.Supported"]/*' />
    public BOOL Supported;
}
