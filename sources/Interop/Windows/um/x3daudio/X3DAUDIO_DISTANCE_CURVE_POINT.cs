// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/x3daudio.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct X3DAUDIO_DISTANCE_CURVE_POINT
    {
        [NativeTypeName("FLOAT32")]
        public float Distance;

        [NativeTypeName("FLOAT32")]
        public float DSPSetting;
    }
}
