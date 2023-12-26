// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.datatransfer.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='ShareUITheme.xml' path='doc/member[@name="ShareUITheme"]/*' />
public enum ShareUITheme
{
    /// <include file='ShareUITheme.xml' path='doc/member[@name="ShareUITheme.ShareUITheme_Default"]/*' />
    ShareUITheme_Default = 0,

    /// <include file='ShareUITheme.xml' path='doc/member[@name="ShareUITheme.ShareUITheme_Light"]/*' />
    ShareUITheme_Light = 1,

    /// <include file='ShareUITheme.xml' path='doc/member[@name="ShareUITheme.ShareUITheme_Dark"]/*' />
    ShareUITheme_Dark = 2,
}
