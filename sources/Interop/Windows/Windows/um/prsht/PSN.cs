// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/prsht.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class PSN
{
    /// <include file='PSN.xml' path='doc/member[@name="PSN.PSN_FIRST"]/*' />
    [NativeTypeName("#define PSN_FIRST (0U-200U)")]
    public const uint PSN_FIRST = unchecked(0U - 200U);

    /// <include file='PSN.xml' path='doc/member[@name="PSN.PSN_LAST"]/*' />
    [NativeTypeName("#define PSN_LAST (0U-299U)")]
    public const uint PSN_LAST = unchecked(0U - 299U);

    /// <include file='PSN.xml' path='doc/member[@name="PSN.PSN_SETACTIVE"]/*' />
    [NativeTypeName("#define PSN_SETACTIVE (PSN_FIRST-0)")]
    public const uint PSN_SETACTIVE = unchecked((0U - 200U) - 0);

    /// <include file='PSN.xml' path='doc/member[@name="PSN.PSN_KILLACTIVE"]/*' />
    [NativeTypeName("#define PSN_KILLACTIVE (PSN_FIRST-1)")]
    public const uint PSN_KILLACTIVE = unchecked((0U - 200U) - 1);

    /// <include file='PSN.xml' path='doc/member[@name="PSN.PSN_APPLY"]/*' />
    [NativeTypeName("#define PSN_APPLY (PSN_FIRST-2)")]
    public const uint PSN_APPLY = unchecked((0U - 200U) - 2);

    /// <include file='PSN.xml' path='doc/member[@name="PSN.PSN_RESET"]/*' />
    [NativeTypeName("#define PSN_RESET (PSN_FIRST-3)")]
    public const uint PSN_RESET = unchecked((0U - 200U) - 3);

    /// <include file='PSN.xml' path='doc/member[@name="PSN.PSN_HELP"]/*' />
    [NativeTypeName("#define PSN_HELP (PSN_FIRST-5)")]
    public const uint PSN_HELP = unchecked((0U - 200U) - 5);

    /// <include file='PSN.xml' path='doc/member[@name="PSN.PSN_WIZBACK"]/*' />
    [NativeTypeName("#define PSN_WIZBACK (PSN_FIRST-6)")]
    public const uint PSN_WIZBACK = unchecked((0U - 200U) - 6);

    /// <include file='PSN.xml' path='doc/member[@name="PSN.PSN_WIZNEXT"]/*' />
    [NativeTypeName("#define PSN_WIZNEXT (PSN_FIRST-7)")]
    public const uint PSN_WIZNEXT = unchecked((0U - 200U) - 7);

    /// <include file='PSN.xml' path='doc/member[@name="PSN.PSN_WIZFINISH"]/*' />
    [NativeTypeName("#define PSN_WIZFINISH (PSN_FIRST-8)")]
    public const uint PSN_WIZFINISH = unchecked((0U - 200U) - 8);

    /// <include file='PSN.xml' path='doc/member[@name="PSN.PSN_QUERYCANCEL"]/*' />
    [NativeTypeName("#define PSN_QUERYCANCEL (PSN_FIRST-9)")]
    public const uint PSN_QUERYCANCEL = unchecked((0U - 200U) - 9);

    /// <include file='PSN.xml' path='doc/member[@name="PSN.PSN_GETOBJECT"]/*' />
    [NativeTypeName("#define PSN_GETOBJECT (PSN_FIRST-10)")]
    public const uint PSN_GETOBJECT = unchecked((0U - 200U) - 10);

    /// <include file='PSN.xml' path='doc/member[@name="PSN.PSN_TRANSLATEACCELERATOR"]/*' />
    [NativeTypeName("#define PSN_TRANSLATEACCELERATOR (PSN_FIRST-12)")]
    public const uint PSN_TRANSLATEACCELERATOR = unchecked((0U - 200U) - 12);

    /// <include file='PSN.xml' path='doc/member[@name="PSN.PSN_QUERYINITIALFOCUS"]/*' />
    [NativeTypeName("#define PSN_QUERYINITIALFOCUS (PSN_FIRST-13)")]
    public const uint PSN_QUERYINITIALFOCUS = unchecked((0U - 200U) - 13);
}
