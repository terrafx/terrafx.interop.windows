// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1svg.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    /// <summary>Defines the type of SVG string attribute to set or get.</summary>
    public enum D2D1_SVG_ATTRIBUTE_STRING_TYPE : uint
    {
        /// <summary>The attribute is a string in the same form as it would appear in the SVG XML. Note that when getting values of this type, the value returned may not exactly match the value that was set. Instead, the output value is a normalized version of the value. For example, an input color of 'red' may be output as '#FF0000'.</summary>
        D2D1_SVG_ATTRIBUTE_STRING_TYPE_SVG = 0,

        /// <summary>The attribute is an element ID.</summary>
        D2D1_SVG_ATTRIBUTE_STRING_TYPE_ID = 1,

        D2D1_SVG_ATTRIBUTE_STRING_TYPE_FORCE_DWORD = 0xFFFFFFFF
    }
}
