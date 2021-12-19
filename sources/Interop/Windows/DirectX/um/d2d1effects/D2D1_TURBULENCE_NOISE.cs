// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1effects.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D2D1_TURBULENCE_NOISE.xml' path='doc/member[@name="D2D1_TURBULENCE_NOISE"]/*' />
public enum D2D1_TURBULENCE_NOISE : uint
{
    /// <include file='D2D1_TURBULENCE_NOISE.xml' path='doc/member[@name="D2D1_TURBULENCE_NOISE.D2D1_TURBULENCE_NOISE_FRACTAL_SUM"]/*' />
    D2D1_TURBULENCE_NOISE_FRACTAL_SUM = 0,

    /// <include file='D2D1_TURBULENCE_NOISE.xml' path='doc/member[@name="D2D1_TURBULENCE_NOISE.D2D1_TURBULENCE_NOISE_TURBULENCE"]/*' />
    D2D1_TURBULENCE_NOISE_TURBULENCE = 1,

    /// <include file='D2D1_TURBULENCE_NOISE.xml' path='doc/member[@name="D2D1_TURBULENCE_NOISE.D2D1_TURBULENCE_NOISE_FORCE_DWORD"]/*' />
    D2D1_TURBULENCE_NOISE_FORCE_DWORD = 0xffffffff,
}
