// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfplay.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='MFP_PLAYBACK_ENDED_EVENT.xml' path='doc/member[@name="MFP_PLAYBACK_ENDED_EVENT"]/*' />
public unsafe partial struct MFP_PLAYBACK_ENDED_EVENT
{
    /// <include file='MFP_PLAYBACK_ENDED_EVENT.xml' path='doc/member[@name="MFP_PLAYBACK_ENDED_EVENT.header"]/*' />
    public MFP_EVENT_HEADER header;

    /// <include file='MFP_PLAYBACK_ENDED_EVENT.xml' path='doc/member[@name="MFP_PLAYBACK_ENDED_EVENT.pMediaItem"]/*' />
    public IMFPMediaItem* pMediaItem;
}
