// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wia_lh.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='WIA_DITHER_PATTERN_DATA.xml' path='doc/member[@name="WIA_DITHER_PATTERN_DATA"]/*' />
public unsafe partial struct WIA_DITHER_PATTERN_DATA
{
    /// <include file='WIA_DITHER_PATTERN_DATA.xml' path='doc/member[@name="WIA_DITHER_PATTERN_DATA.lSize"]/*' />
    [NativeTypeName("LONG")]
    public int lSize;

    /// <include file='WIA_DITHER_PATTERN_DATA.xml' path='doc/member[@name="WIA_DITHER_PATTERN_DATA.bstrPatternName"]/*' />
    [NativeTypeName("BSTR")]
    public char* bstrPatternName;

    /// <include file='WIA_DITHER_PATTERN_DATA.xml' path='doc/member[@name="WIA_DITHER_PATTERN_DATA.lPatternWidth"]/*' />
    [NativeTypeName("LONG")]
    public int lPatternWidth;

    /// <include file='WIA_DITHER_PATTERN_DATA.xml' path='doc/member[@name="WIA_DITHER_PATTERN_DATA.lPatternLength"]/*' />
    [NativeTypeName("LONG")]
    public int lPatternLength;

    /// <include file='WIA_DITHER_PATTERN_DATA.xml' path='doc/member[@name="WIA_DITHER_PATTERN_DATA.cbPattern"]/*' />
    [NativeTypeName("LONG")]
    public int cbPattern;

    /// <include file='WIA_DITHER_PATTERN_DATA.xml' path='doc/member[@name="WIA_DITHER_PATTERN_DATA.pbPattern"]/*' />
    public byte* pbPattern;
}
