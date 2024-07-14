// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.background.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='MediaProcessingTriggerResult.xml' path='doc/member[@name="MediaProcessingTriggerResult"]/*' />
public enum MediaProcessingTriggerResult
{
    /// <include file='MediaProcessingTriggerResult.xml' path='doc/member[@name="MediaProcessingTriggerResult.MediaProcessingTriggerResult_Allowed"]/*' />
    MediaProcessingTriggerResult_Allowed = 0,

    /// <include file='MediaProcessingTriggerResult.xml' path='doc/member[@name="MediaProcessingTriggerResult.MediaProcessingTriggerResult_CurrentlyRunning"]/*' />
    MediaProcessingTriggerResult_CurrentlyRunning = 1,

    /// <include file='MediaProcessingTriggerResult.xml' path='doc/member[@name="MediaProcessingTriggerResult.MediaProcessingTriggerResult_DisabledByPolicy"]/*' />
    MediaProcessingTriggerResult_DisabledByPolicy = 2,

    /// <include file='MediaProcessingTriggerResult.xml' path='doc/member[@name="MediaProcessingTriggerResult.MediaProcessingTriggerResult_UnknownError"]/*' />
    MediaProcessingTriggerResult_UnknownError = 3,
}
