// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.transcoding.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='TranscodeFailureReason.xml' path='doc/member[@name="TranscodeFailureReason"]/*' />
public enum TranscodeFailureReason
{
    /// <include file='TranscodeFailureReason.xml' path='doc/member[@name="TranscodeFailureReason.TranscodeFailureReason_None"]/*' />
    TranscodeFailureReason_None = 0,

    /// <include file='TranscodeFailureReason.xml' path='doc/member[@name="TranscodeFailureReason.TranscodeFailureReason_Unknown"]/*' />
    TranscodeFailureReason_Unknown = 1,

    /// <include file='TranscodeFailureReason.xml' path='doc/member[@name="TranscodeFailureReason.TranscodeFailureReason_InvalidProfile"]/*' />
    TranscodeFailureReason_InvalidProfile = 2,

    /// <include file='TranscodeFailureReason.xml' path='doc/member[@name="TranscodeFailureReason.TranscodeFailureReason_CodecNotFound"]/*' />
    TranscodeFailureReason_CodecNotFound = 3,
}
