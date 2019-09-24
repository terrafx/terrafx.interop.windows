// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\dwrite.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    /// <summary>The DWRITE_OVERHANG_METRICS public structure holds how much any visible pixels (in DIPs) overshoot each side of the layout or inline objects.</summary>
    /// <remarks>Positive overhangs indicate that the visible area extends outside the layout box or inline object, while negative values mean there is whitespace inside. The returned values are unaffected by rendering transforms or pixel snapping. Additionally, they may not exactly match final target's pixel bounds after applying grid fitting and hinting.</remarks>
    public struct DWRITE_OVERHANG_METRICS
    {
        /// <summary>The distance from the left-most visible DIP to its left alignment edge.</summary>
        [NativeTypeName("FLOAT")]
        public float left;

        /// <summary>The distance from the top-most visible DIP to its top alignment edge.</summary>
        [NativeTypeName("FLOAT")]
        public float top;

        /// <summary>The distance from the right-most visible DIP to its right alignment edge.</summary>
        [NativeTypeName("FLOAT")]
        public float right;

        /// <summary>The distance from the bottom-most visible DIP to its bottom alignment edge.</summary>
        [NativeTypeName("FLOAT")]
        public float bottom;
    }
}
