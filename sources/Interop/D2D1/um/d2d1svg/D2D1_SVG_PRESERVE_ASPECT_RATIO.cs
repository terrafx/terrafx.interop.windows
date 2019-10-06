// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1svg.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    /// <summary>Represents all SVG preserveAspectRatio settings.</summary>
    public partial struct D2D1_SVG_PRESERVE_ASPECT_RATIO
    {
        /// <summary>Sets the 'defer' portion of the preserveAspectRatio settings. This field only has an effect on an 'image' element that references another SVG document. As this is not currently supported, the field has no impact on rendering.</summary>
        [NativeTypeName("BOOL")]
        public int defer;

        /// <summary>Sets the align portion of the preserveAspectRatio settings.</summary>
        public D2D1_SVG_ASPECT_ALIGN align;

        /// <summary>Sets the meetOrSlice portion of the preserveAspectRatio settings.</summary>
        public D2D1_SVG_ASPECT_SCALING meetOrSlice;
    }
}
