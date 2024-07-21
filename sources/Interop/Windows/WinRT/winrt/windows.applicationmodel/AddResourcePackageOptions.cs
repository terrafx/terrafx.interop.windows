// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='AddResourcePackageOptions.xml' path='doc/member[@name="AddResourcePackageOptions"]/*' />
[NativeTypeName("unsigned int")]
public enum AddResourcePackageOptions : uint
{
    /// <include file='AddResourcePackageOptions.xml' path='doc/member[@name="AddResourcePackageOptions.AddResourcePackageOptions_None"]/*' />
    AddResourcePackageOptions_None = 0,

    /// <include file='AddResourcePackageOptions.xml' path='doc/member[@name="AddResourcePackageOptions.AddResourcePackageOptions_ForceTargetAppShutdown"]/*' />
    AddResourcePackageOptions_ForceTargetAppShutdown = 0x1,

    /// <include file='AddResourcePackageOptions.xml' path='doc/member[@name="AddResourcePackageOptions.AddResourcePackageOptions_ApplyUpdateIfAvailable"]/*' />
    AddResourcePackageOptions_ApplyUpdateIfAvailable = 0x2,
}
