// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwmapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='DWM_SOURCE_FRAME_SAMPLING.xml' path='doc/member[@name="DWM_SOURCE_FRAME_SAMPLING"]/*' />
public enum DWM_SOURCE_FRAME_SAMPLING
{
    /// <include file='DWM_SOURCE_FRAME_SAMPLING.xml' path='doc/member[@name="DWM_SOURCE_FRAME_SAMPLING.DWM_SOURCE_FRAME_SAMPLING_POINT"]/*' />
    DWM_SOURCE_FRAME_SAMPLING_POINT,

    /// <include file='DWM_SOURCE_FRAME_SAMPLING.xml' path='doc/member[@name="DWM_SOURCE_FRAME_SAMPLING.DWM_SOURCE_FRAME_SAMPLING_COVERAGE"]/*' />
    DWM_SOURCE_FRAME_SAMPLING_COVERAGE,

    /// <include file='DWM_SOURCE_FRAME_SAMPLING.xml' path='doc/member[@name="DWM_SOURCE_FRAME_SAMPLING.DWM_SOURCE_FRAME_SAMPLING_LAST"]/*' />
    DWM_SOURCE_FRAME_SAMPLING_LAST,
}
