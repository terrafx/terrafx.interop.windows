// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='TimedMetadataTrackErrorCode.xml' path='doc/member[@name="TimedMetadataTrackErrorCode"]/*' />
public enum TimedMetadataTrackErrorCode
{
    /// <include file='TimedMetadataTrackErrorCode.xml' path='doc/member[@name="TimedMetadataTrackErrorCode.TimedMetadataTrackErrorCode_None"]/*' />
    TimedMetadataTrackErrorCode_None = 0,

    /// <include file='TimedMetadataTrackErrorCode.xml' path='doc/member[@name="TimedMetadataTrackErrorCode.TimedMetadataTrackErrorCode_DataFormatError"]/*' />
    TimedMetadataTrackErrorCode_DataFormatError = 1,

    /// <include file='TimedMetadataTrackErrorCode.xml' path='doc/member[@name="TimedMetadataTrackErrorCode.TimedMetadataTrackErrorCode_NetworkError"]/*' />
    TimedMetadataTrackErrorCode_NetworkError = 2,

    /// <include file='TimedMetadataTrackErrorCode.xml' path='doc/member[@name="TimedMetadataTrackErrorCode.TimedMetadataTrackErrorCode_InternalError"]/*' />
    TimedMetadataTrackErrorCode_InternalError = 3,
}
