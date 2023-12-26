// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='MediaDecoderStatus.xml' path='doc/member[@name="MediaDecoderStatus"]/*' />
public enum MediaDecoderStatus
{
    /// <include file='MediaDecoderStatus.xml' path='doc/member[@name="MediaDecoderStatus.MediaDecoderStatus_FullySupported"]/*' />
    MediaDecoderStatus_FullySupported = 0,

    /// <include file='MediaDecoderStatus.xml' path='doc/member[@name="MediaDecoderStatus.MediaDecoderStatus_UnsupportedSubtype"]/*' />
    MediaDecoderStatus_UnsupportedSubtype = 1,

    /// <include file='MediaDecoderStatus.xml' path='doc/member[@name="MediaDecoderStatus.MediaDecoderStatus_UnsupportedEncoderProperties"]/*' />
    MediaDecoderStatus_UnsupportedEncoderProperties = 2,

    /// <include file='MediaDecoderStatus.xml' path='doc/member[@name="MediaDecoderStatus.MediaDecoderStatus_Degraded"]/*' />
    MediaDecoderStatus_Degraded = 3,
}
