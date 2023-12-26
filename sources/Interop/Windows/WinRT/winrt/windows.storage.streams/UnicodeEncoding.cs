// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.streams.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='UnicodeEncoding.xml' path='doc/member[@name="UnicodeEncoding"]/*' />
public enum UnicodeEncoding
{
    /// <include file='UnicodeEncoding.xml' path='doc/member[@name="UnicodeEncoding.UnicodeEncoding_Utf8"]/*' />
    UnicodeEncoding_Utf8 = 0,

    /// <include file='UnicodeEncoding.xml' path='doc/member[@name="UnicodeEncoding.UnicodeEncoding_Utf16LE"]/*' />
    UnicodeEncoding_Utf16LE = 1,

    /// <include file='UnicodeEncoding.xml' path='doc/member[@name="UnicodeEncoding.UnicodeEncoding_Utf16BE"]/*' />
    UnicodeEncoding_Utf16BE = 2,
}
