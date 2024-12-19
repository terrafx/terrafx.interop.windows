// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/UIAnimation.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='PresentStatisticsKind.xml' path='doc/member[@name="PresentStatisticsKind"]/*' />
public enum PresentStatisticsKind
{
    /// <include file='PresentStatisticsKind.xml' path='doc/member[@name="PresentStatisticsKind.PresentStatisticsKind_PresentStatus"]/*' />
    PresentStatisticsKind_PresentStatus = 1,

    /// <include file='PresentStatisticsKind.xml' path='doc/member[@name="PresentStatisticsKind.PresentStatisticsKind_CompositionFrame"]/*' />
    PresentStatisticsKind_CompositionFrame = 2,

    /// <include file='PresentStatisticsKind.xml' path='doc/member[@name="PresentStatisticsKind.PresentStatisticsKind_IndependentFlipFrame"]/*' />
    PresentStatisticsKind_IndependentFlipFrame = 3,
}
