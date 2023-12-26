// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.printers.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='IppAttributeValueKind.xml' path='doc/member[@name="IppAttributeValueKind"]/*' />
public enum IppAttributeValueKind
{
    /// <include file='IppAttributeValueKind.xml' path='doc/member[@name="IppAttributeValueKind.IppAttributeValueKind_Unsupported"]/*' />
    IppAttributeValueKind_Unsupported = 0,

    /// <include file='IppAttributeValueKind.xml' path='doc/member[@name="IppAttributeValueKind.IppAttributeValueKind_Unknown"]/*' />
    IppAttributeValueKind_Unknown = 1,

    /// <include file='IppAttributeValueKind.xml' path='doc/member[@name="IppAttributeValueKind.IppAttributeValueKind_NoValue"]/*' />
    IppAttributeValueKind_NoValue = 2,

    /// <include file='IppAttributeValueKind.xml' path='doc/member[@name="IppAttributeValueKind.IppAttributeValueKind_Integer"]/*' />
    IppAttributeValueKind_Integer = 3,

    /// <include file='IppAttributeValueKind.xml' path='doc/member[@name="IppAttributeValueKind.IppAttributeValueKind_Boolean"]/*' />
    IppAttributeValueKind_Boolean = 4,

    /// <include file='IppAttributeValueKind.xml' path='doc/member[@name="IppAttributeValueKind.IppAttributeValueKind_Enum"]/*' />
    IppAttributeValueKind_Enum = 5,

    /// <include file='IppAttributeValueKind.xml' path='doc/member[@name="IppAttributeValueKind.IppAttributeValueKind_OctetString"]/*' />
    IppAttributeValueKind_OctetString = 6,

    /// <include file='IppAttributeValueKind.xml' path='doc/member[@name="IppAttributeValueKind.IppAttributeValueKind_DateTime"]/*' />
    IppAttributeValueKind_DateTime = 7,

    /// <include file='IppAttributeValueKind.xml' path='doc/member[@name="IppAttributeValueKind.IppAttributeValueKind_Resolution"]/*' />
    IppAttributeValueKind_Resolution = 8,

    /// <include file='IppAttributeValueKind.xml' path='doc/member[@name="IppAttributeValueKind.IppAttributeValueKind_RangeOfInteger"]/*' />
    IppAttributeValueKind_RangeOfInteger = 9,

    /// <include file='IppAttributeValueKind.xml' path='doc/member[@name="IppAttributeValueKind.IppAttributeValueKind_Collection"]/*' />
    IppAttributeValueKind_Collection = 10,

    /// <include file='IppAttributeValueKind.xml' path='doc/member[@name="IppAttributeValueKind.IppAttributeValueKind_TextWithLanguage"]/*' />
    IppAttributeValueKind_TextWithLanguage = 11,

    /// <include file='IppAttributeValueKind.xml' path='doc/member[@name="IppAttributeValueKind.IppAttributeValueKind_NameWithLanguage"]/*' />
    IppAttributeValueKind_NameWithLanguage = 12,

    /// <include file='IppAttributeValueKind.xml' path='doc/member[@name="IppAttributeValueKind.IppAttributeValueKind_TextWithoutLanguage"]/*' />
    IppAttributeValueKind_TextWithoutLanguage = 13,

    /// <include file='IppAttributeValueKind.xml' path='doc/member[@name="IppAttributeValueKind.IppAttributeValueKind_NameWithoutLanguage"]/*' />
    IppAttributeValueKind_NameWithoutLanguage = 14,

    /// <include file='IppAttributeValueKind.xml' path='doc/member[@name="IppAttributeValueKind.IppAttributeValueKind_Keyword"]/*' />
    IppAttributeValueKind_Keyword = 15,

    /// <include file='IppAttributeValueKind.xml' path='doc/member[@name="IppAttributeValueKind.IppAttributeValueKind_Uri"]/*' />
    IppAttributeValueKind_Uri = 16,

    /// <include file='IppAttributeValueKind.xml' path='doc/member[@name="IppAttributeValueKind.IppAttributeValueKind_UriSchema"]/*' />
    IppAttributeValueKind_UriSchema = 17,

    /// <include file='IppAttributeValueKind.xml' path='doc/member[@name="IppAttributeValueKind.IppAttributeValueKind_Charset"]/*' />
    IppAttributeValueKind_Charset = 18,

    /// <include file='IppAttributeValueKind.xml' path='doc/member[@name="IppAttributeValueKind.IppAttributeValueKind_NaturalLanguage"]/*' />
    IppAttributeValueKind_NaturalLanguage = 19,

    /// <include file='IppAttributeValueKind.xml' path='doc/member[@name="IppAttributeValueKind.IppAttributeValueKind_MimeMediaType"]/*' />
    IppAttributeValueKind_MimeMediaType = 20,
}
