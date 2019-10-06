// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\dwrite.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    /// <summary>The DWRITE_FONT_FEATURE public partial structure specifies properties used to identify and execute typographic feature in the font.</summary>
    public partial struct DWRITE_FONT_FEATURE
    {
        /// <summary>The feature OpenType name identifier.</summary>
        public DWRITE_FONT_FEATURE_TAG nameTag;

        /// <summary>Execution parameter of the feature.</summary>
        /// <remarks>The parameter should be non-zero to enable the feature.  Once enabled, a feature can't be disabled again within the same range.  Features requiring a selector use this value to indicate the selector index.</remarks>
        [NativeTypeName("UINT32")]
        public uint parameter;
    }
}
