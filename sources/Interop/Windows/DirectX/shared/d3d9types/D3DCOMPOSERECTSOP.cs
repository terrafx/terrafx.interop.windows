// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3DCOMPOSERECTSOP.xml' path='doc/member[@name="D3DCOMPOSERECTSOP"]/*' />
public enum D3DCOMPOSERECTSOP
{
    /// <include file='D3DCOMPOSERECTSOP.xml' path='doc/member[@name="D3DCOMPOSERECTSOP.D3DCOMPOSERECTS_COPY"]/*' />
    D3DCOMPOSERECTS_COPY = 1,

    /// <include file='D3DCOMPOSERECTSOP.xml' path='doc/member[@name="D3DCOMPOSERECTSOP.D3DCOMPOSERECTS_OR"]/*' />
    D3DCOMPOSERECTS_OR = 2,

    /// <include file='D3DCOMPOSERECTSOP.xml' path='doc/member[@name="D3DCOMPOSERECTSOP.D3DCOMPOSERECTS_AND"]/*' />
    D3DCOMPOSERECTS_AND = 3,

    /// <include file='D3DCOMPOSERECTSOP.xml' path='doc/member[@name="D3DCOMPOSERECTSOP.D3DCOMPOSERECTS_NEG"]/*' />
    D3DCOMPOSERECTS_NEG = 4,

    /// <include file='D3DCOMPOSERECTSOP.xml' path='doc/member[@name="D3DCOMPOSERECTSOP.D3DCOMPOSERECTS_FORCE_DWORD"]/*' />
    D3DCOMPOSERECTS_FORCE_DWORD = 0x7fffffff,
}
