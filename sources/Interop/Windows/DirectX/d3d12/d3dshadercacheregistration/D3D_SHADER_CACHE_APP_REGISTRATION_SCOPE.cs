// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3dshadercacheregistration.h in microsoft/DirectX-Headers tag v1.618.5
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D_SHADER_CACHE_APP_REGISTRATION_SCOPE.xml' path='doc/member[@name="D3D_SHADER_CACHE_APP_REGISTRATION_SCOPE"]/*' />
public enum D3D_SHADER_CACHE_APP_REGISTRATION_SCOPE
{
    /// <include file='D3D_SHADER_CACHE_APP_REGISTRATION_SCOPE.xml' path='doc/member[@name="D3D_SHADER_CACHE_APP_REGISTRATION_SCOPE.D3D_SHADER_CACHE_APP_REGISTRATION_SCOPE_USER"]/*' />
    D3D_SHADER_CACHE_APP_REGISTRATION_SCOPE_USER = 0,

    /// <include file='D3D_SHADER_CACHE_APP_REGISTRATION_SCOPE.xml' path='doc/member[@name="D3D_SHADER_CACHE_APP_REGISTRATION_SCOPE.D3D_SHADER_CACHE_APP_REGISTRATION_SCOPE_SYSTEM"]/*' />
    D3D_SHADER_CACHE_APP_REGISTRATION_SCOPE_SYSTEM = (D3D_SHADER_CACHE_APP_REGISTRATION_SCOPE_USER + 1),
}
