// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dvdmedia.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class AMINTERLACE
{
    /// <include file='AMINTERLACE.xml' path='doc/member[@name="AMINTERLACE.AMINTERLACE_IsInterlaced"]/*' />
    [NativeTypeName("#define AMINTERLACE_IsInterlaced 0x00000001")]
    public const int AMINTERLACE_IsInterlaced = 0x00000001;

    /// <include file='AMINTERLACE.xml' path='doc/member[@name="AMINTERLACE.AMINTERLACE_1FieldPerSample"]/*' />
    [NativeTypeName("#define AMINTERLACE_1FieldPerSample 0x00000002")]
    public const int AMINTERLACE_1FieldPerSample = 0x00000002;

    /// <include file='AMINTERLACE.xml' path='doc/member[@name="AMINTERLACE.AMINTERLACE_Field1First"]/*' />
    [NativeTypeName("#define AMINTERLACE_Field1First 0x00000004")]
    public const int AMINTERLACE_Field1First = 0x00000004;

    /// <include file='AMINTERLACE.xml' path='doc/member[@name="AMINTERLACE.AMINTERLACE_UNUSED"]/*' />
    [NativeTypeName("#define AMINTERLACE_UNUSED 0x00000008")]
    public const int AMINTERLACE_UNUSED = 0x00000008;

    /// <include file='AMINTERLACE.xml' path='doc/member[@name="AMINTERLACE.AMINTERLACE_FieldPatternMask"]/*' />
    [NativeTypeName("#define AMINTERLACE_FieldPatternMask 0x00000030")]
    public const int AMINTERLACE_FieldPatternMask = 0x00000030;

    /// <include file='AMINTERLACE.xml' path='doc/member[@name="AMINTERLACE.AMINTERLACE_FieldPatField1Only"]/*' />
    [NativeTypeName("#define AMINTERLACE_FieldPatField1Only 0x00000000")]
    public const int AMINTERLACE_FieldPatField1Only = 0x00000000;

    /// <include file='AMINTERLACE.xml' path='doc/member[@name="AMINTERLACE.AMINTERLACE_FieldPatField2Only"]/*' />
    [NativeTypeName("#define AMINTERLACE_FieldPatField2Only 0x00000010")]
    public const int AMINTERLACE_FieldPatField2Only = 0x00000010;

    /// <include file='AMINTERLACE.xml' path='doc/member[@name="AMINTERLACE.AMINTERLACE_FieldPatBothRegular"]/*' />
    [NativeTypeName("#define AMINTERLACE_FieldPatBothRegular 0x00000020")]
    public const int AMINTERLACE_FieldPatBothRegular = 0x00000020;

    /// <include file='AMINTERLACE.xml' path='doc/member[@name="AMINTERLACE.AMINTERLACE_FieldPatBothIrregular"]/*' />
    [NativeTypeName("#define AMINTERLACE_FieldPatBothIrregular 0x00000030")]
    public const int AMINTERLACE_FieldPatBothIrregular = 0x00000030;

    /// <include file='AMINTERLACE.xml' path='doc/member[@name="AMINTERLACE.AMINTERLACE_DisplayModeMask"]/*' />
    [NativeTypeName("#define AMINTERLACE_DisplayModeMask 0x000000c0")]
    public const int AMINTERLACE_DisplayModeMask = 0x000000c0;

    /// <include file='AMINTERLACE.xml' path='doc/member[@name="AMINTERLACE.AMINTERLACE_DisplayModeBobOnly"]/*' />
    [NativeTypeName("#define AMINTERLACE_DisplayModeBobOnly 0x00000000")]
    public const int AMINTERLACE_DisplayModeBobOnly = 0x00000000;

    /// <include file='AMINTERLACE.xml' path='doc/member[@name="AMINTERLACE.AMINTERLACE_DisplayModeWeaveOnly"]/*' />
    [NativeTypeName("#define AMINTERLACE_DisplayModeWeaveOnly 0x00000040")]
    public const int AMINTERLACE_DisplayModeWeaveOnly = 0x00000040;

    /// <include file='AMINTERLACE.xml' path='doc/member[@name="AMINTERLACE.AMINTERLACE_DisplayModeBobOrWeave"]/*' />
    [NativeTypeName("#define AMINTERLACE_DisplayModeBobOrWeave 0x00000080")]
    public const int AMINTERLACE_DisplayModeBobOrWeave = 0x00000080;
}
