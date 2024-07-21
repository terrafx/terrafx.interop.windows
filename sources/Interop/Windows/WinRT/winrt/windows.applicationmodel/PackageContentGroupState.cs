// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='PackageContentGroupState.xml' path='doc/member[@name="PackageContentGroupState"]/*' />
public enum PackageContentGroupState
{
    /// <include file='PackageContentGroupState.xml' path='doc/member[@name="PackageContentGroupState.PackageContentGroupState_NotStaged"]/*' />
    PackageContentGroupState_NotStaged = 0,

    /// <include file='PackageContentGroupState.xml' path='doc/member[@name="PackageContentGroupState.PackageContentGroupState_Queued"]/*' />
    PackageContentGroupState_Queued = 1,

    /// <include file='PackageContentGroupState.xml' path='doc/member[@name="PackageContentGroupState.PackageContentGroupState_Staging"]/*' />
    PackageContentGroupState_Staging = 2,

    /// <include file='PackageContentGroupState.xml' path='doc/member[@name="PackageContentGroupState.PackageContentGroupState_Staged"]/*' />
    PackageContentGroupState_Staged = 3,
}
