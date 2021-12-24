// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/gdiplusenums.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Gdiplus;

/// <include file='DashCap.xml' path='doc/member[@name="DashCap"]/*' />
public enum DashCap
{
    /// <include file='DashCap.xml' path='doc/member[@name="DashCap.DashCapFlat"]/*' />
    DashCapFlat = 0,

    /// <include file='DashCap.xml' path='doc/member[@name="DashCap.DashCapRound"]/*' />
    DashCapRound = 2,

    /// <include file='DashCap.xml' path='doc/member[@name="DashCap.DashCapTriangle"]/*' />
    DashCapTriangle = 3,
}
