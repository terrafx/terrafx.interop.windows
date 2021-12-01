// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from cvconst.h in the Debug Interface Access SDK
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).

namespace TerraFX.Interop.Windows;

/// <include file='DataKind.xml' path='doc/member[@name="DataKind"]/*' />
public enum DataKind
{
    /// <include file='DataKind.xml' path='doc/member[@name="DataKind.DataIsUnknown"]/*' />
    DataIsUnknown,

    /// <include file='DataKind.xml' path='doc/member[@name="DataKind.DataIsLocal"]/*' />
    DataIsLocal,

    /// <include file='DataKind.xml' path='doc/member[@name="DataKind.DataIsStaticLocal"]/*' />
    DataIsStaticLocal,

    /// <include file='DataKind.xml' path='doc/member[@name="DataKind.DataIsParam"]/*' />
    DataIsParam,

    /// <include file='DataKind.xml' path='doc/member[@name="DataKind.DataIsObjectPtr"]/*' />
    DataIsObjectPtr,

    /// <include file='DataKind.xml' path='doc/member[@name="DataKind.DataIsFileStatic"]/*' />
    DataIsFileStatic,

    /// <include file='DataKind.xml' path='doc/member[@name="DataKind.DataIsGlobal"]/*' />
    DataIsGlobal,

    /// <include file='DataKind.xml' path='doc/member[@name="DataKind.DataIsMember"]/*' />
    DataIsMember,

    /// <include file='DataKind.xml' path='doc/member[@name="DataKind.DataIsStaticMember"]/*' />
    DataIsStaticMember,

    /// <include file='DataKind.xml' path='doc/member[@name="DataKind.DataIsConstant"]/*' />
    DataIsConstant,
}
