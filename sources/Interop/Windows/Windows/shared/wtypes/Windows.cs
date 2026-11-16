// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/wtypes.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class Windows
{
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ROT_COMPARE_MAX"]/*' />
    [NativeTypeName("#define ROT_COMPARE_MAX 2048")]
    public const int ROT_COMPARE_MAX = 2048;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WDT_INPROC_CALL"]/*' />
    [NativeTypeName("#define WDT_INPROC_CALL ( 0x48746457 )")]
    public const int WDT_INPROC_CALL = (0x48746457);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WDT_REMOTE_CALL"]/*' />
    [NativeTypeName("#define WDT_REMOTE_CALL ( 0x52746457 )")]
    public const int WDT_REMOTE_CALL = (0x52746457);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WDT_INPROC64_CALL"]/*' />
    [NativeTypeName("#define WDT_INPROC64_CALL ( 0x50746457 )")]
    public const int WDT_INPROC64_CALL = (0x50746457);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DECIMAL_NEG"]/*' />
    [NativeTypeName("#define DECIMAL_NEG ((BYTE)0x80)")]
    public const byte DECIMAL_NEG = ((byte)(0x80));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VARIANT_TRUE"]/*' />
    [NativeTypeName("#define VARIANT_TRUE ((VARIANT_BOOL)-1)")]
    public const short VARIANT_TRUE = ((short)(-1));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VARIANT_FALSE"]/*' />
    [NativeTypeName("#define VARIANT_FALSE ((VARIANT_BOOL)0)")]
    public const short VARIANT_FALSE = ((short)(0));
}
