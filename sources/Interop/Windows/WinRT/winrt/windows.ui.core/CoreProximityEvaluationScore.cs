// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='CoreProximityEvaluationScore.xml' path='doc/member[@name="CoreProximityEvaluationScore"]/*' />
public enum CoreProximityEvaluationScore
{
    /// <include file='CoreProximityEvaluationScore.xml' path='doc/member[@name="CoreProximityEvaluationScore.CoreProximityEvaluationScore_Closest"]/*' />
    CoreProximityEvaluationScore_Closest = 0,

    /// <include file='CoreProximityEvaluationScore.xml' path='doc/member[@name="CoreProximityEvaluationScore.CoreProximityEvaluationScore_Farthest"]/*' />
    CoreProximityEvaluationScore_Farthest = 2147483647,
}
