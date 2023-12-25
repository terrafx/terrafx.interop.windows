// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='PackageRelationship.xml' path='doc/member[@name="PackageRelationship"]/*' />
public enum PackageRelationship
{
    /// <include file='PackageRelationship.xml' path='doc/member[@name="PackageRelationship.PackageRelationship_Dependencies"]/*' />
    PackageRelationship_Dependencies = 0,

    /// <include file='PackageRelationship.xml' path='doc/member[@name="PackageRelationship.PackageRelationship_Dependents"]/*' />
    PackageRelationship_Dependents = 1,

    /// <include file='PackageRelationship.xml' path='doc/member[@name="PackageRelationship.PackageRelationship_All"]/*' />
    PackageRelationship_All = 2,
}
