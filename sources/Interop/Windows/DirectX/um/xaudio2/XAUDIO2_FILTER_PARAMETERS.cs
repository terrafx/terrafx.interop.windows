// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/xaudio2.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop.DirectX
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct XAUDIO2_FILTER_PARAMETERS
    {
        public XAUDIO2_FILTER_TYPE Type;

        public float Frequency;

        public float OneOverQ;
    }
}
