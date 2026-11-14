// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class ES
{
    /// <include file='ES.xml' path='doc/member[@name="ES.ES_EX_ALLOWEOL_CR"]/*' />
    [NativeTypeName("#define ES_EX_ALLOWEOL_CR 0x0001L")]
    public const int ES_EX_ALLOWEOL_CR = 0x0001;

    /// <include file='ES.xml' path='doc/member[@name="ES.ES_EX_ALLOWEOL_LF"]/*' />
    [NativeTypeName("#define ES_EX_ALLOWEOL_LF 0x0002L")]
    public const int ES_EX_ALLOWEOL_LF = 0x0002;

    /// <include file='ES.xml' path='doc/member[@name="ES.ES_EX_ALLOWEOL_ALL"]/*' />
    [NativeTypeName("#define ES_EX_ALLOWEOL_ALL (ES_EX_ALLOWEOL_CR | ES_EX_ALLOWEOL_LF)")]
    public const int ES_EX_ALLOWEOL_ALL = (0x0001 | 0x0002);

    /// <include file='ES.xml' path='doc/member[@name="ES.ES_EX_CONVERT_EOL_ON_PASTE"]/*' />
    [NativeTypeName("#define ES_EX_CONVERT_EOL_ON_PASTE 0x0004L")]
    public const int ES_EX_CONVERT_EOL_ON_PASTE = 0x0004;

    /// <include file='ES.xml' path='doc/member[@name="ES.ES_EX_ZOOMABLE"]/*' />
    [NativeTypeName("#define ES_EX_ZOOMABLE 0x0010L")]
    public const int ES_EX_ZOOMABLE = 0x0010;
}
