// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class ELEMENT
{
    /// <include file='ELEMENT.xml' path='doc/member[@name="ELEMENT.ELEMENT_STATUS_FULL"]/*' />
    [NativeTypeName("#define ELEMENT_STATUS_FULL 0x00000001")]
    public const int ELEMENT_STATUS_FULL = 0x00000001;

    /// <include file='ELEMENT.xml' path='doc/member[@name="ELEMENT.ELEMENT_STATUS_IMPEXP"]/*' />
    [NativeTypeName("#define ELEMENT_STATUS_IMPEXP 0x00000002")]
    public const int ELEMENT_STATUS_IMPEXP = 0x00000002;

    /// <include file='ELEMENT.xml' path='doc/member[@name="ELEMENT.ELEMENT_STATUS_EXCEPT"]/*' />
    [NativeTypeName("#define ELEMENT_STATUS_EXCEPT 0x00000004")]
    public const int ELEMENT_STATUS_EXCEPT = 0x00000004;

    /// <include file='ELEMENT.xml' path='doc/member[@name="ELEMENT.ELEMENT_STATUS_ACCESS"]/*' />
    [NativeTypeName("#define ELEMENT_STATUS_ACCESS 0x00000008")]
    public const int ELEMENT_STATUS_ACCESS = 0x00000008;

    /// <include file='ELEMENT.xml' path='doc/member[@name="ELEMENT.ELEMENT_STATUS_EXENAB"]/*' />
    [NativeTypeName("#define ELEMENT_STATUS_EXENAB 0x00000010")]
    public const int ELEMENT_STATUS_EXENAB = 0x00000010;

    /// <include file='ELEMENT.xml' path='doc/member[@name="ELEMENT.ELEMENT_STATUS_INENAB"]/*' />
    [NativeTypeName("#define ELEMENT_STATUS_INENAB 0x00000020")]
    public const int ELEMENT_STATUS_INENAB = 0x00000020;

    /// <include file='ELEMENT.xml' path='doc/member[@name="ELEMENT.ELEMENT_STATUS_PRODUCT_DATA"]/*' />
    [NativeTypeName("#define ELEMENT_STATUS_PRODUCT_DATA 0x00000040")]
    public const int ELEMENT_STATUS_PRODUCT_DATA = 0x00000040;

    /// <include file='ELEMENT.xml' path='doc/member[@name="ELEMENT.ELEMENT_STATUS_LUN_VALID"]/*' />
    [NativeTypeName("#define ELEMENT_STATUS_LUN_VALID 0x00001000")]
    public const int ELEMENT_STATUS_LUN_VALID = 0x00001000;

    /// <include file='ELEMENT.xml' path='doc/member[@name="ELEMENT.ELEMENT_STATUS_ID_VALID"]/*' />
    [NativeTypeName("#define ELEMENT_STATUS_ID_VALID 0x00002000")]
    public const int ELEMENT_STATUS_ID_VALID = 0x00002000;

    /// <include file='ELEMENT.xml' path='doc/member[@name="ELEMENT.ELEMENT_STATUS_NOT_BUS"]/*' />
    [NativeTypeName("#define ELEMENT_STATUS_NOT_BUS 0x00008000")]
    public const int ELEMENT_STATUS_NOT_BUS = 0x00008000;

    /// <include file='ELEMENT.xml' path='doc/member[@name="ELEMENT.ELEMENT_STATUS_INVERT"]/*' />
    [NativeTypeName("#define ELEMENT_STATUS_INVERT 0x00400000")]
    public const int ELEMENT_STATUS_INVERT = 0x00400000;

    /// <include file='ELEMENT.xml' path='doc/member[@name="ELEMENT.ELEMENT_STATUS_SVALID"]/*' />
    [NativeTypeName("#define ELEMENT_STATUS_SVALID 0x00800000")]
    public const int ELEMENT_STATUS_SVALID = 0x00800000;

    /// <include file='ELEMENT.xml' path='doc/member[@name="ELEMENT.ELEMENT_STATUS_PVOLTAG"]/*' />
    [NativeTypeName("#define ELEMENT_STATUS_PVOLTAG 0x10000000")]
    public const int ELEMENT_STATUS_PVOLTAG = 0x10000000;

    /// <include file='ELEMENT.xml' path='doc/member[@name="ELEMENT.ELEMENT_STATUS_AVOLTAG"]/*' />
    [NativeTypeName("#define ELEMENT_STATUS_AVOLTAG 0x20000000")]
    public const int ELEMENT_STATUS_AVOLTAG = 0x20000000;
}
