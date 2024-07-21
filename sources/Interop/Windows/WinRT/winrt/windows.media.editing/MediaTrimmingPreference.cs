// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.editing.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='MediaTrimmingPreference.xml' path='doc/member[@name="MediaTrimmingPreference"]/*' />
public enum MediaTrimmingPreference
{
    /// <include file='MediaTrimmingPreference.xml' path='doc/member[@name="MediaTrimmingPreference.MediaTrimmingPreference_Fast"]/*' />
    MediaTrimmingPreference_Fast = 0,

    /// <include file='MediaTrimmingPreference.xml' path='doc/member[@name="MediaTrimmingPreference.MediaTrimmingPreference_Precise"]/*' />
    MediaTrimmingPreference_Precise = 1,
}
