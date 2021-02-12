// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwmapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct MilMatrix3x2D
    {
        [NativeTypeName("DOUBLE")]
        public double S_11;

        [NativeTypeName("DOUBLE")]
        public double S_12;

        [NativeTypeName("DOUBLE")]
        public double S_21;

        [NativeTypeName("DOUBLE")]
        public double S_22;

        [NativeTypeName("DOUBLE")]
        public double DX;

        [NativeTypeName("DOUBLE")]
        public double DY;
    }
}
