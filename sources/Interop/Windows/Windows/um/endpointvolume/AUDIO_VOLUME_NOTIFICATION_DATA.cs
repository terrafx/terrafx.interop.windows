// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/endpointvolume.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.Windows;

public unsafe partial struct AUDIO_VOLUME_NOTIFICATION_DATA
{
    public Guid guidEventContext;

    public BOOL bMuted;

    public float fMasterVolume;

    public uint nChannels;

    [NativeTypeName("float [1]")]
    public fixed float afChannelVolumes[1];
}
