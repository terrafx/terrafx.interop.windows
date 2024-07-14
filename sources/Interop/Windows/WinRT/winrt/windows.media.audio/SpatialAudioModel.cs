// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.audio.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='SpatialAudioModel.xml' path='doc/member[@name="SpatialAudioModel"]/*' />
public enum SpatialAudioModel
{
    /// <include file='SpatialAudioModel.xml' path='doc/member[@name="SpatialAudioModel.SpatialAudioModel_ObjectBased"]/*' />
    SpatialAudioModel_ObjectBased = 0,

    /// <include file='SpatialAudioModel.xml' path='doc/member[@name="SpatialAudioModel.SpatialAudioModel_FoldDown"]/*' />
    SpatialAudioModel_FoldDown = 1,
}
