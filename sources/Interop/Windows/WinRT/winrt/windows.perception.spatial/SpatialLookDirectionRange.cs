// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.perception.spatial.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='SpatialLookDirectionRange.xml' path='doc/member[@name="SpatialLookDirectionRange"]/*' />
public enum SpatialLookDirectionRange
{
    /// <include file='SpatialLookDirectionRange.xml' path='doc/member[@name="SpatialLookDirectionRange.SpatialLookDirectionRange_ForwardOnly"]/*' />
    SpatialLookDirectionRange_ForwardOnly = 0,

    /// <include file='SpatialLookDirectionRange.xml' path='doc/member[@name="SpatialLookDirectionRange.SpatialLookDirectionRange_Omnidirectional"]/*' />
    SpatialLookDirectionRange_Omnidirectional = 1,
}
