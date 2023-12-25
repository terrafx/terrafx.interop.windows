// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.transcoding.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='MediaVideoProcessingAlgorithm.xml' path='doc/member[@name="MediaVideoProcessingAlgorithm"]/*' />
public enum MediaVideoProcessingAlgorithm
{
    /// <include file='MediaVideoProcessingAlgorithm.xml' path='doc/member[@name="MediaVideoProcessingAlgorithm.MediaVideoProcessingAlgorithm_Default"]/*' />
    MediaVideoProcessingAlgorithm_Default = 0,

    /// <include file='MediaVideoProcessingAlgorithm.xml' path='doc/member[@name="MediaVideoProcessingAlgorithm.MediaVideoProcessingAlgorithm_MrfCrf444"]/*' />
    MediaVideoProcessingAlgorithm_MrfCrf444 = 1,
}
