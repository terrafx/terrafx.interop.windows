// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from cvconst.h in the Debug Interface Access SDK
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).

namespace TerraFX.Interop.Windows;

/// <include file='UdtKind.xml' path='doc/member[@name="UdtKind"]/*' />
public enum UdtKind
{
    /// <include file='UdtKind.xml' path='doc/member[@name="UdtKind.UdtStruct"]/*' />
    UdtStruct,

    /// <include file='UdtKind.xml' path='doc/member[@name="UdtKind.UdtClass"]/*' />
    UdtClass,

    /// <include file='UdtKind.xml' path='doc/member[@name="UdtKind.UdtUnion"]/*' />
    UdtUnion,

    /// <include file='UdtKind.xml' path='doc/member[@name="UdtKind.UdtInterface"]/*' />
    UdtInterface,

    /// <include file='UdtKind.xml' path='doc/member[@name="UdtKind.UdtTaggedUnion"]/*' />
    UdtTaggedUnion,
}
