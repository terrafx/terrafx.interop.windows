// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/vssym32.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='GLYPHTYPE.xml' path='doc/member[@name="GLYPHTYPE"]/*' />
public enum GLYPHTYPE
{
    /// <include file='GLYPHTYPE.xml' path='doc/member[@name="GLYPHTYPE.GT_NONE"]/*' />
    GT_NONE = 0,

    /// <include file='GLYPHTYPE.xml' path='doc/member[@name="GLYPHTYPE.GT_IMAGEGLYPH"]/*' />
    GT_IMAGEGLYPH = 1,

    /// <include file='GLYPHTYPE.xml' path='doc/member[@name="GLYPHTYPE.GT_FONTGLYPH"]/*' />
    GT_FONTGLYPH = 2,
}
