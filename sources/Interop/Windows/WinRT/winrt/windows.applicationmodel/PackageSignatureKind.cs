// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='PackageSignatureKind.xml' path='doc/member[@name="PackageSignatureKind"]/*' />
public enum PackageSignatureKind
{
    /// <include file='PackageSignatureKind.xml' path='doc/member[@name="PackageSignatureKind.PackageSignatureKind_None"]/*' />
    PackageSignatureKind_None = 0,

    /// <include file='PackageSignatureKind.xml' path='doc/member[@name="PackageSignatureKind.PackageSignatureKind_Developer"]/*' />
    PackageSignatureKind_Developer = 1,

    /// <include file='PackageSignatureKind.xml' path='doc/member[@name="PackageSignatureKind.PackageSignatureKind_Enterprise"]/*' />
    PackageSignatureKind_Enterprise = 2,

    /// <include file='PackageSignatureKind.xml' path='doc/member[@name="PackageSignatureKind.PackageSignatureKind_Store"]/*' />
    PackageSignatureKind_Store = 3,

    /// <include file='PackageSignatureKind.xml' path='doc/member[@name="PackageSignatureKind.PackageSignatureKind_System"]/*' />
    PackageSignatureKind_System = 4,
}
