// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfplay.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public unsafe partial struct MFP_PLAYBACK_ENDED_EVENT
    {
        public MFP_EVENT_HEADER header;

        public IMFPMediaItem* pMediaItem;
    }
}
