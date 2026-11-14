// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlObj.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class DBCID
{
    /// <include file='DBCID.xml' path='doc/member[@name="DBCID.DBCID_EMPTY"]/*' />
    public const int DBCID_EMPTY = 0;
    /// <include file='DBCID.xml' path='doc/member[@name="DBCID.DBCID_ONDRAG"]/*' />
    public const int DBCID_ONDRAG = 1;
    /// <include file='DBCID.xml' path='doc/member[@name="DBCID.DBCID_CLSIDOFBAR"]/*' />
    public const int DBCID_CLSIDOFBAR = 2;
    /// <include file='DBCID.xml' path='doc/member[@name="DBCID.DBCID_RESIZE"]/*' />
    public const int DBCID_RESIZE = 3;
    /// <include file='DBCID.xml' path='doc/member[@name="DBCID.DBCID_GETBAR"]/*' />
    public const int DBCID_GETBAR = 4;
    /// <include file='DBCID.xml' path='doc/member[@name="DBCID.DBCID_UPDATESIZE"]/*' />
    public const int DBCID_UPDATESIZE = 5;
}
