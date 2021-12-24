// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/gdiplusenums.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Gdiplus;

/// <include file='CoordinateSpace.xml' path='doc/member[@name="CoordinateSpace"]/*' />
public enum CoordinateSpace
{
    /// <include file='CoordinateSpace.xml' path='doc/member[@name="CoordinateSpace.CoordinateSpaceWorld"]/*' />
    CoordinateSpaceWorld,

    /// <include file='CoordinateSpace.xml' path='doc/member[@name="CoordinateSpace.CoordinateSpacePage"]/*' />
    CoordinateSpacePage,

    /// <include file='CoordinateSpace.xml' path='doc/member[@name="CoordinateSpace.CoordinateSpaceDevice"]/*' />
    CoordinateSpaceDevice,
}
