// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='StreamedFileFailureMode.xml' path='doc/member[@name="StreamedFileFailureMode"]/*' />
public enum StreamedFileFailureMode
{
    /// <include file='StreamedFileFailureMode.xml' path='doc/member[@name="StreamedFileFailureMode.StreamedFileFailureMode_Failed"]/*' />
    StreamedFileFailureMode_Failed = 0,

    /// <include file='StreamedFileFailureMode.xml' path='doc/member[@name="StreamedFileFailureMode.StreamedFileFailureMode_CurrentlyUnavailable"]/*' />
    StreamedFileFailureMode_CurrentlyUnavailable = 1,

    /// <include file='StreamedFileFailureMode.xml' path='doc/member[@name="StreamedFileFailureMode.StreamedFileFailureMode_Incomplete"]/*' />
    StreamedFileFailureMode_Incomplete = 2,
}
