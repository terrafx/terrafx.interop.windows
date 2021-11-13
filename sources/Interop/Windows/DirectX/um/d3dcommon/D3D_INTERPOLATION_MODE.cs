// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3dcommon.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX
{
    public enum D3D_INTERPOLATION_MODE
    {
        D3D_INTERPOLATION_UNDEFINED = 0,
        D3D_INTERPOLATION_CONSTANT = 1,
        D3D_INTERPOLATION_LINEAR = 2,
        D3D_INTERPOLATION_LINEAR_CENTROID = 3,
        D3D_INTERPOLATION_LINEAR_NOPERSPECTIVE = 4,
        D3D_INTERPOLATION_LINEAR_NOPERSPECTIVE_CENTROID = 5,
        D3D_INTERPOLATION_LINEAR_SAMPLE = 6,
        D3D_INTERPOLATION_LINEAR_NOPERSPECTIVE_SAMPLE = 7,
    }
}
