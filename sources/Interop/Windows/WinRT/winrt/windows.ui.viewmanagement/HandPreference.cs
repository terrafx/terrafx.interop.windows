// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.viewmanagement.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='HandPreference.xml' path='doc/member[@name="HandPreference"]/*' />
public enum HandPreference
{
    /// <include file='HandPreference.xml' path='doc/member[@name="HandPreference.HandPreference_LeftHanded"]/*' />
    HandPreference_LeftHanded = 0,

    /// <include file='HandPreference.xml' path='doc/member[@name="HandPreference.HandPreference_RightHanded"]/*' />
    HandPreference_RightHanded = 1,
}
