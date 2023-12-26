// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='CoreProximityEvaluation.xml' path='doc/member[@name="CoreProximityEvaluation"]/*' />
public partial struct CoreProximityEvaluation
{
    /// <include file='CoreProximityEvaluation.xml' path='doc/member[@name="CoreProximityEvaluation.Score"]/*' />
    [NativeTypeName("INT32")]
    public int Score;

    /// <include file='CoreProximityEvaluation.xml' path='doc/member[@name="CoreProximityEvaluation.AdjustedPoint"]/*' />
    [NativeTypeName("ABI::Windows::Foundation::Point")]
    public Point AdjustedPoint;
}
