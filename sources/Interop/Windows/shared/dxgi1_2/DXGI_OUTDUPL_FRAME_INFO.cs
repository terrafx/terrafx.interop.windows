// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/dxgi1_2.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct DXGI_OUTDUPL_FRAME_INFO
    {
        public LARGE_INTEGER LastPresentTime;

        public LARGE_INTEGER LastMouseUpdateTime;

        public uint AccumulatedFrames;

        public BOOL RectsCoalesced;

        public BOOL ProtectedContentMaskedOut;

        public DXGI_OUTDUPL_POINTER_POSITION PointerPosition;

        public uint TotalMetadataBufferSize;

        public uint PointerShapeBufferSize;
    }
}
