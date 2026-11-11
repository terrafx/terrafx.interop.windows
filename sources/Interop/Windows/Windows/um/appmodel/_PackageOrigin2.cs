// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/appmodel.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='_PackageOrigin2.xml' path='doc/member[@name="_PackageOrigin2"]/*' />
public enum _PackageOrigin2
{
    /// <include file='_PackageOrigin2.xml' path='doc/member[@name="_PackageOrigin2.PackageOrigin2_Unknown"]/*' />
    PackageOrigin2_Unknown = 0,

    /// <include file='_PackageOrigin2.xml' path='doc/member[@name="_PackageOrigin2.PackageOrigin2_Unsigned"]/*' />
    PackageOrigin2_Unsigned = 1,

    /// <include file='_PackageOrigin2.xml' path='doc/member[@name="_PackageOrigin2.PackageOrigin2_Inbox"]/*' />
    PackageOrigin2_Inbox = 2,

    /// <include file='_PackageOrigin2.xml' path='doc/member[@name="_PackageOrigin2.PackageOrigin2_Store"]/*' />
    PackageOrigin2_Store = 3,

    /// <include file='_PackageOrigin2.xml' path='doc/member[@name="_PackageOrigin2.PackageOrigin2_DeveloperUnsigned"]/*' />
    PackageOrigin2_DeveloperUnsigned = 4,

    /// <include file='_PackageOrigin2.xml' path='doc/member[@name="_PackageOrigin2.PackageOrigin2_DeveloperSigned"]/*' />
    PackageOrigin2_DeveloperSigned = 5,

    /// <include file='_PackageOrigin2.xml' path='doc/member[@name="_PackageOrigin2.PackageOrigin2_LineOfBusiness"]/*' />
    PackageOrigin2_LineOfBusiness = 6,

    /// <include file='_PackageOrigin2.xml' path='doc/member[@name="_PackageOrigin2.PackageOrigin2_SignedSBOM"]/*' />
    PackageOrigin2_SignedSBOM = 7,
}
