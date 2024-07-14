// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.playback.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='MediaCommandEnablingRule.xml' path='doc/member[@name="MediaCommandEnablingRule"]/*' />
public enum MediaCommandEnablingRule
{
    /// <include file='MediaCommandEnablingRule.xml' path='doc/member[@name="MediaCommandEnablingRule.MediaCommandEnablingRule_Auto"]/*' />
    MediaCommandEnablingRule_Auto = 0,

    /// <include file='MediaCommandEnablingRule.xml' path='doc/member[@name="MediaCommandEnablingRule.MediaCommandEnablingRule_Always"]/*' />
    MediaCommandEnablingRule_Always = 1,

    /// <include file='MediaCommandEnablingRule.xml' path='doc/member[@name="MediaCommandEnablingRule.MediaCommandEnablingRule_Never"]/*' />
    MediaCommandEnablingRule_Never = 2,
}
