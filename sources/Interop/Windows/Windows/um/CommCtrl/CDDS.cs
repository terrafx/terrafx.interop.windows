// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class CDDS
{
    /// <include file='CDDS.xml' path='doc/member[@name="CDDS.CDDS_PREPAINT"]/*' />
    [NativeTypeName("#define CDDS_PREPAINT 0x00000001")]
    public const int CDDS_PREPAINT = 0x00000001;

    /// <include file='CDDS.xml' path='doc/member[@name="CDDS.CDDS_POSTPAINT"]/*' />
    [NativeTypeName("#define CDDS_POSTPAINT 0x00000002")]
    public const int CDDS_POSTPAINT = 0x00000002;

    /// <include file='CDDS.xml' path='doc/member[@name="CDDS.CDDS_PREERASE"]/*' />
    [NativeTypeName("#define CDDS_PREERASE 0x00000003")]
    public const int CDDS_PREERASE = 0x00000003;

    /// <include file='CDDS.xml' path='doc/member[@name="CDDS.CDDS_POSTERASE"]/*' />
    [NativeTypeName("#define CDDS_POSTERASE 0x00000004")]
    public const int CDDS_POSTERASE = 0x00000004;

    /// <include file='CDDS.xml' path='doc/member[@name="CDDS.CDDS_ITEM"]/*' />
    [NativeTypeName("#define CDDS_ITEM 0x00010000")]
    public const int CDDS_ITEM = 0x00010000;

    /// <include file='CDDS.xml' path='doc/member[@name="CDDS.CDDS_ITEMPREPAINT"]/*' />
    [NativeTypeName("#define CDDS_ITEMPREPAINT (CDDS_ITEM | CDDS_PREPAINT)")]
    public const int CDDS_ITEMPREPAINT = (0x00010000 | 0x00000001);

    /// <include file='CDDS.xml' path='doc/member[@name="CDDS.CDDS_ITEMPOSTPAINT"]/*' />
    [NativeTypeName("#define CDDS_ITEMPOSTPAINT (CDDS_ITEM | CDDS_POSTPAINT)")]
    public const int CDDS_ITEMPOSTPAINT = (0x00010000 | 0x00000002);

    /// <include file='CDDS.xml' path='doc/member[@name="CDDS.CDDS_ITEMPREERASE"]/*' />
    [NativeTypeName("#define CDDS_ITEMPREERASE (CDDS_ITEM | CDDS_PREERASE)")]
    public const int CDDS_ITEMPREERASE = (0x00010000 | 0x00000003);

    /// <include file='CDDS.xml' path='doc/member[@name="CDDS.CDDS_ITEMPOSTERASE"]/*' />
    [NativeTypeName("#define CDDS_ITEMPOSTERASE (CDDS_ITEM | CDDS_POSTERASE)")]
    public const int CDDS_ITEMPOSTERASE = (0x00010000 | 0x00000004);

    /// <include file='CDDS.xml' path='doc/member[@name="CDDS.CDDS_SUBITEM"]/*' />
    [NativeTypeName("#define CDDS_SUBITEM 0x00020000")]
    public const int CDDS_SUBITEM = 0x00020000;
}
