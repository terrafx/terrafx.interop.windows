// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='SceneAnalysisRecommendation.xml' path='doc/member[@name="SceneAnalysisRecommendation"]/*' />
public enum SceneAnalysisRecommendation
{
    /// <include file='SceneAnalysisRecommendation.xml' path='doc/member[@name="SceneAnalysisRecommendation.SceneAnalysisRecommendation_Standard"]/*' />
    SceneAnalysisRecommendation_Standard = 0,

    /// <include file='SceneAnalysisRecommendation.xml' path='doc/member[@name="SceneAnalysisRecommendation.SceneAnalysisRecommendation_Hdr"]/*' />
    SceneAnalysisRecommendation_Hdr = 1,

    /// <include file='SceneAnalysisRecommendation.xml' path='doc/member[@name="SceneAnalysisRecommendation.SceneAnalysisRecommendation_LowLight"]/*' />
    SceneAnalysisRecommendation_LowLight = 2,
}
