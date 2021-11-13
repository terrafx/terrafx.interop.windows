// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d10_1shader.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX
{
    public partial struct D3D10_SHADER_DEBUG_OUTPUTVAR
    {
        public uint Var;

        public uint uValueMin;

        public uint uValueMax;

        public int iValueMin;

        public int iValueMax;

        public float fValueMin;

        public float fValueMax;

        public BOOL bNaNPossible;

        public BOOL bInfPossible;
    }
}
