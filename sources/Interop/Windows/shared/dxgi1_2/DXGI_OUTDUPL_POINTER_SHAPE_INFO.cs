// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/dxgi1_2.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct DXGI_OUTDUPL_POINTER_SHAPE_INFO
    {
        public uint Type;

        public uint Width;

        public uint Height;

        public uint Pitch;

        public POINT HotSpot;
    }
}
