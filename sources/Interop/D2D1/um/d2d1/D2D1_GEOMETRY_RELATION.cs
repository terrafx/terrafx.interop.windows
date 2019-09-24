// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    /// <summary>Describes how one geometry object is spatially related to another geometry object.</summary>
    public enum D2D1_GEOMETRY_RELATION : uint
    {
        /// <summary>The relation between the geometries couldn't be determined. This value is never
        /// returned by any D2D method.</summary>
        D2D1_GEOMETRY_RELATION_UNKNOWN = 0,

        /// <summary>The two geometries do not intersect at all.</summary>
        D2D1_GEOMETRY_RELATION_DISJOINT = 1,

        /// <summary>The passed in geometry is entirely contained by the object.</summary>
        D2D1_GEOMETRY_RELATION_IS_CONTAINED = 2,

        /// <summary>The object entirely contains the passed in geometry.</summary>
        D2D1_GEOMETRY_RELATION_CONTAINS = 3,

        /// <summary>The two geometries overlap but neither completely contains the other.</summary>
        D2D1_GEOMETRY_RELATION_OVERLAP = 4,

        D2D1_GEOMETRY_RELATION_FORCE_DWORD = 0xFFFFFFFF
    }
}
