// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/appmodel.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='AddPackageDependencyOptions2.xml' path='doc/member[@name="AddPackageDependencyOptions2"]/*' />
public enum AddPackageDependencyOptions2
{
    /// <include file='AddPackageDependencyOptions2.xml' path='doc/member[@name="AddPackageDependencyOptions2.AddPackageDependencyOptions2_None"]/*' />
    AddPackageDependencyOptions2_None = 0,

    /// <include file='AddPackageDependencyOptions2.xml' path='doc/member[@name="AddPackageDependencyOptions2.AddPackageDependencyOptions2_PrependIfRankCollision"]/*' />
    AddPackageDependencyOptions2_PrependIfRankCollision = 0x00000001,

    /// <include file='AddPackageDependencyOptions2.xml' path='doc/member[@name="AddPackageDependencyOptions2.AddPackageDependencyOptions2_SpecifiedPackageFamilyOnly"]/*' />
    AddPackageDependencyOptions2_SpecifiedPackageFamilyOnly = 0x00000002,
}
