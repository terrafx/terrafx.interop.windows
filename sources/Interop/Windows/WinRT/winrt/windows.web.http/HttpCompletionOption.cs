// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.web.http.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='HttpCompletionOption.xml' path='doc/member[@name="HttpCompletionOption"]/*' />
public enum HttpCompletionOption
{
    /// <include file='HttpCompletionOption.xml' path='doc/member[@name="HttpCompletionOption.HttpCompletionOption_ResponseContentRead"]/*' />
    HttpCompletionOption_ResponseContentRead = 0,

    /// <include file='HttpCompletionOption.xml' path='doc/member[@name="HttpCompletionOption.HttpCompletionOption_ResponseHeadersRead"]/*' />
    HttpCompletionOption_ResponseHeadersRead = 1,
}
