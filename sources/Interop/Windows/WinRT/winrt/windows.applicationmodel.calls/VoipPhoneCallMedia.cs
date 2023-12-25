// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.calls.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='VoipPhoneCallMedia.xml' path='doc/member[@name="VoipPhoneCallMedia"]/*' />
[NativeTypeName("unsigned int")]
public enum VoipPhoneCallMedia : uint
{
    /// <include file='VoipPhoneCallMedia.xml' path='doc/member[@name="VoipPhoneCallMedia.VoipPhoneCallMedia_None"]/*' />
    VoipPhoneCallMedia_None = 0,

    /// <include file='VoipPhoneCallMedia.xml' path='doc/member[@name="VoipPhoneCallMedia.VoipPhoneCallMedia_Audio"]/*' />
    VoipPhoneCallMedia_Audio = 0x1,

    /// <include file='VoipPhoneCallMedia.xml' path='doc/member[@name="VoipPhoneCallMedia.VoipPhoneCallMedia_Video"]/*' />
    VoipPhoneCallMedia_Video = 0x2,
}
