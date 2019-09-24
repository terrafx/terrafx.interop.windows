// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\dwrite.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    /// <summary>Defines a set of typographic features to be applied during shaping. Notice the character range which this feature list spans is specified as a separate parameter to GetGlyphs.</summary>
    public unsafe struct DWRITE_TYPOGRAPHIC_FEATURES
    {
        /// <summary>Array of font features.</summary>
        [NativeTypeName("DWRITE_FONT_FEATURE[]")]
        public DWRITE_FONT_FEATURE* features;

        /// <summary>The number of features.</summary>
        [NativeTypeName("UINT32")]
        public uint featureCount;
    }
}
