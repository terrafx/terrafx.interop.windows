// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='MediaSourceStatus.xml' path='doc/member[@name="MediaSourceStatus"]/*' />
public enum MediaSourceStatus
{
    /// <include file='MediaSourceStatus.xml' path='doc/member[@name="MediaSourceStatus.MediaSourceStatus_FullySupported"]/*' />
    MediaSourceStatus_FullySupported = 0,

    /// <include file='MediaSourceStatus.xml' path='doc/member[@name="MediaSourceStatus.MediaSourceStatus_Unknown"]/*' />
    MediaSourceStatus_Unknown = 1,
}
