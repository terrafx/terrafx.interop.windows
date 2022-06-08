// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from cvconst.h in the Debug Interface Access SDK
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).

namespace TerraFX.Interop.Windows;

/// <include file='THUNK_ORDINAL.xml' path='doc/member[@name="THUNK_ORDINAL"]/*' />
public enum THUNK_ORDINAL
{
    /// <include file='THUNK_ORDINAL.xml' path='doc/member[@name="THUNK_ORDINAL.THUNK_ORDINAL_NOTYPE"]/*' />
    THUNK_ORDINAL_NOTYPE,

    /// <include file='THUNK_ORDINAL.xml' path='doc/member[@name="THUNK_ORDINAL.THUNK_ORDINAL_ADJUSTOR"]/*' />
    THUNK_ORDINAL_ADJUSTOR,

    /// <include file='THUNK_ORDINAL.xml' path='doc/member[@name="THUNK_ORDINAL.THUNK_ORDINAL_VCALL"]/*' />
    THUNK_ORDINAL_VCALL,

    /// <include file='THUNK_ORDINAL.xml' path='doc/member[@name="THUNK_ORDINAL.THUNK_ORDINAL_PCODE"]/*' />
    THUNK_ORDINAL_PCODE,

    /// <include file='THUNK_ORDINAL.xml' path='doc/member[@name="THUNK_ORDINAL.THUNK_ORDINAL_LOAD"]/*' />
    THUNK_ORDINAL_LOAD,

    /// <include file='THUNK_ORDINAL.xml' path='doc/member[@name="THUNK_ORDINAL.THUNK_ORDINAL_TRAMP_INCREMENTAL"]/*' />
    THUNK_ORDINAL_TRAMP_INCREMENTAL,

    /// <include file='THUNK_ORDINAL.xml' path='doc/member[@name="THUNK_ORDINAL.THUNK_ORDINAL_TRAMP_BRANCHISLAND"]/*' />
    THUNK_ORDINAL_TRAMP_BRANCHISLAND,

    /// <include file='THUNK_ORDINAL.xml' path='doc/member[@name="THUNK_ORDINAL.THUNK_ORDINAL_TRAMP_STRICTICF"]/*' />
    THUNK_ORDINAL_TRAMP_STRICTICF,

    /// <include file='THUNK_ORDINAL.xml' path='doc/member[@name="THUNK_ORDINAL.THUNK_ORDINAL_TRAMP_ARM64XSAMEADDRESS"]/*' />
    THUNK_ORDINAL_TRAMP_ARM64XSAMEADDRESS,

    /// <include file='THUNK_ORDINAL.xml' path='doc/member[@name="THUNK_ORDINAL.THUNK_ORDINAL_TRAMP_FUNCOVERRIDING"]/*' />
    THUNK_ORDINAL_TRAMP_FUNCOVERRIDING,
}
