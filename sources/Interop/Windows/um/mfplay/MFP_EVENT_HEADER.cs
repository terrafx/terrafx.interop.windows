// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfplay.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct MFP_EVENT_HEADER
    {
        public MFP_EVENT_TYPE eEventType;

        public HRESULT hrEvent;

        public IMFPMediaPlayer* pMediaPlayer;

        public MFP_MEDIAPLAYER_STATE eState;

        public IPropertyStore* pPropertyStore;
    }
}
