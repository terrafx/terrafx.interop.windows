// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SpatialAudioHrtf.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [StructLayout(LayoutKind.Explicit)]
    public partial struct SpatialAudioHrtfDirectivityUnion
    {
        [FieldOffset(0)]
        public SpatialAudioHrtfDirectivityCone Cone;

        [FieldOffset(0)]
        public SpatialAudioHrtfDirectivityCardioid Cardiod;

        [FieldOffset(0)]
        public SpatialAudioHrtfDirectivity Omni;
    }
}
