// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.data.text.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='UnicodeNumericType.xml' path='doc/member[@name="UnicodeNumericType"]/*' />
public enum UnicodeNumericType
{
    /// <include file='UnicodeNumericType.xml' path='doc/member[@name="UnicodeNumericType.UnicodeNumericType_None"]/*' />
    UnicodeNumericType_None = 0,

    /// <include file='UnicodeNumericType.xml' path='doc/member[@name="UnicodeNumericType.UnicodeNumericType_Decimal"]/*' />
    UnicodeNumericType_Decimal = 1,

    /// <include file='UnicodeNumericType.xml' path='doc/member[@name="UnicodeNumericType.UnicodeNumericType_Digit"]/*' />
    UnicodeNumericType_Digit = 2,

    /// <include file='UnicodeNumericType.xml' path='doc/member[@name="UnicodeNumericType.UnicodeNumericType_Numeric"]/*' />
    UnicodeNumericType_Numeric = 3,
}
