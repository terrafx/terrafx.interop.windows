// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.security.authentication.web.provider.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='WebAccountSelectionOptions.xml' path='doc/member[@name="WebAccountSelectionOptions"]/*' />
[NativeTypeName("unsigned int")]
public enum WebAccountSelectionOptions : uint
{
    /// <include file='WebAccountSelectionOptions.xml' path='doc/member[@name="WebAccountSelectionOptions.WebAccountSelectionOptions_Default"]/*' />
    WebAccountSelectionOptions_Default = 0,

    /// <include file='WebAccountSelectionOptions.xml' path='doc/member[@name="WebAccountSelectionOptions.WebAccountSelectionOptions_New"]/*' />
    WebAccountSelectionOptions_New = 0x1,
}
