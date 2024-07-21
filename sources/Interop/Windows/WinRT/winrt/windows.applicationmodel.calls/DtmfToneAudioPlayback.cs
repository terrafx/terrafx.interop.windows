// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.calls.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='DtmfToneAudioPlayback.xml' path='doc/member[@name="DtmfToneAudioPlayback"]/*' />
public enum DtmfToneAudioPlayback
{
    /// <include file='DtmfToneAudioPlayback.xml' path='doc/member[@name="DtmfToneAudioPlayback.DtmfToneAudioPlayback_Play"]/*' />
    DtmfToneAudioPlayback_Play = 0,

    /// <include file='DtmfToneAudioPlayback.xml' path='doc/member[@name="DtmfToneAudioPlayback.DtmfToneAudioPlayback_DoNotPlay"]/*' />
    DtmfToneAudioPlayback_DoNotPlay = 1,
}
