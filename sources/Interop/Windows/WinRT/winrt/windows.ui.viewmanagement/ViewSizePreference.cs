// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.viewmanagement.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='ViewSizePreference.xml' path='doc/member[@name="ViewSizePreference"]/*' />
public enum ViewSizePreference
{
    /// <include file='ViewSizePreference.xml' path='doc/member[@name="ViewSizePreference.ViewSizePreference_Default"]/*' />
    ViewSizePreference_Default = 0,

    /// <include file='ViewSizePreference.xml' path='doc/member[@name="ViewSizePreference.ViewSizePreference_UseLess"]/*' />
    ViewSizePreference_UseLess = 1,

    /// <include file='ViewSizePreference.xml' path='doc/member[@name="ViewSizePreference.ViewSizePreference_UseHalf"]/*' />
    ViewSizePreference_UseHalf = 2,

    /// <include file='ViewSizePreference.xml' path='doc/member[@name="ViewSizePreference.ViewSizePreference_UseMore"]/*' />
    ViewSizePreference_UseMore = 3,

    /// <include file='ViewSizePreference.xml' path='doc/member[@name="ViewSizePreference.ViewSizePreference_UseMinimum"]/*' />
    ViewSizePreference_UseMinimum = 4,

    /// <include file='ViewSizePreference.xml' path='doc/member[@name="ViewSizePreference.ViewSizePreference_UseNone"]/*' />
    ViewSizePreference_UseNone = 5,

    /// <include file='ViewSizePreference.xml' path='doc/member[@name="ViewSizePreference.ViewSizePreference_Custom"]/*' />
    ViewSizePreference_Custom = 6,
}
