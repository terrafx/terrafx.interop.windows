// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.calls.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='PhoneCallMedia.xml' path='doc/member[@name="PhoneCallMedia"]/*' />
public enum PhoneCallMedia
{
    /// <include file='PhoneCallMedia.xml' path='doc/member[@name="PhoneCallMedia.PhoneCallMedia_Audio"]/*' />
    PhoneCallMedia_Audio = 0,

    /// <include file='PhoneCallMedia.xml' path='doc/member[@name="PhoneCallMedia.PhoneCallMedia_AudioAndVideo"]/*' />
    PhoneCallMedia_AudioAndVideo = 1,

    /// <include file='PhoneCallMedia.xml' path='doc/member[@name="PhoneCallMedia.PhoneCallMedia_AudioAndRealTimeText"]/*' />
    PhoneCallMedia_AudioAndRealTimeText = 2,
}
