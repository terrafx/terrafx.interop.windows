// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\dwrite_3.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    /// <summary>Font property used for filtering font sets and building a font set with explicit properties.</summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public unsafe struct DWRITE_FONT_PROPERTY
    {
        #region Fields
        /// <summary>Specifies the requested font property, such as DWRITE_FONT_PROPERTY_ID_FAMILY_NAME.</summary>
        public DWRITE_FONT_PROPERTY_ID propertyId;

        /// <summary>Specifies the property value, such as "Segoe UI".</summary>
        [NativeTypeName("WCHAR[]")]
        public char* propertyValue;

        /// <summary>Specifies the language / locale to use, such as "en-US". </summary>
        /// <remarks> When passing property information to AddFontFaceReference, localeName indicates the language of the property value. BCP 47 language tags should be used. If a property value is inherently non-linguistic, this can be left empty.
        /// When used for font set filtering, leave this empty: a match will be found regardless of language associated with property values.</remarks>
        [NativeTypeName("WCHAR[]")]
        public char* localeName;
        #endregion
    }
}
