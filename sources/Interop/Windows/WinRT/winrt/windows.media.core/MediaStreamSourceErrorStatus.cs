// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='MediaStreamSourceErrorStatus.xml' path='doc/member[@name="MediaStreamSourceErrorStatus"]/*' />
public enum MediaStreamSourceErrorStatus
{
    /// <include file='MediaStreamSourceErrorStatus.xml' path='doc/member[@name="MediaStreamSourceErrorStatus.MediaStreamSourceErrorStatus_Other"]/*' />
    MediaStreamSourceErrorStatus_Other = 0,

    /// <include file='MediaStreamSourceErrorStatus.xml' path='doc/member[@name="MediaStreamSourceErrorStatus.MediaStreamSourceErrorStatus_OutOfMemory"]/*' />
    MediaStreamSourceErrorStatus_OutOfMemory = 1,

    /// <include file='MediaStreamSourceErrorStatus.xml' path='doc/member[@name="MediaStreamSourceErrorStatus.MediaStreamSourceErrorStatus_FailedToOpenFile"]/*' />
    MediaStreamSourceErrorStatus_FailedToOpenFile = 2,

    /// <include file='MediaStreamSourceErrorStatus.xml' path='doc/member[@name="MediaStreamSourceErrorStatus.MediaStreamSourceErrorStatus_FailedToConnectToServer"]/*' />
    MediaStreamSourceErrorStatus_FailedToConnectToServer = 3,

    /// <include file='MediaStreamSourceErrorStatus.xml' path='doc/member[@name="MediaStreamSourceErrorStatus.MediaStreamSourceErrorStatus_ConnectionToServerLost"]/*' />
    MediaStreamSourceErrorStatus_ConnectionToServerLost = 4,

    /// <include file='MediaStreamSourceErrorStatus.xml' path='doc/member[@name="MediaStreamSourceErrorStatus.MediaStreamSourceErrorStatus_UnspecifiedNetworkError"]/*' />
    MediaStreamSourceErrorStatus_UnspecifiedNetworkError = 5,

    /// <include file='MediaStreamSourceErrorStatus.xml' path='doc/member[@name="MediaStreamSourceErrorStatus.MediaStreamSourceErrorStatus_DecodeError"]/*' />
    MediaStreamSourceErrorStatus_DecodeError = 6,

    /// <include file='MediaStreamSourceErrorStatus.xml' path='doc/member[@name="MediaStreamSourceErrorStatus.MediaStreamSourceErrorStatus_UnsupportedMediaFormat"]/*' />
    MediaStreamSourceErrorStatus_UnsupportedMediaFormat = 7,
}
