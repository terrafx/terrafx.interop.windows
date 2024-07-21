// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='PackageVersion.xml' path='doc/member[@name="PackageVersion"]/*' />
public partial struct PackageVersion
{
    /// <include file='PackageVersion.xml' path='doc/member[@name="PackageVersion.Major"]/*' />
    [NativeTypeName("UINT16")]
    public ushort Major;

    /// <include file='PackageVersion.xml' path='doc/member[@name="PackageVersion.Minor"]/*' />
    [NativeTypeName("UINT16")]
    public ushort Minor;

    /// <include file='PackageVersion.xml' path='doc/member[@name="PackageVersion.Build"]/*' />
    [NativeTypeName("UINT16")]
    public ushort Build;

    /// <include file='PackageVersion.xml' path='doc/member[@name="PackageVersion.Revision"]/*' />
    [NativeTypeName("UINT16")]
    public ushort Revision;
}
