// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from dia2.h in the Debug Interface Access SDK
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).

namespace TerraFX.Interop.Windows;

/// <include file='NameSearchOptions.xml' path='doc/member[@name="NameSearchOptions"]/*' />
public enum NameSearchOptions
{
    /// <include file='NameSearchOptions.xml' path='doc/member[@name="NameSearchOptions.nsNone"]/*' />
    nsNone = 0,

    /// <include file='NameSearchOptions.xml' path='doc/member[@name="NameSearchOptions.nsfCaseSensitive"]/*' />
    nsfCaseSensitive = 0x1,

    /// <include file='NameSearchOptions.xml' path='doc/member[@name="NameSearchOptions.nsfCaseInsensitive"]/*' />
    nsfCaseInsensitive = 0x2,

    /// <include file='NameSearchOptions.xml' path='doc/member[@name="NameSearchOptions.nsfFNameExt"]/*' />
    nsfFNameExt = 0x4,

    /// <include file='NameSearchOptions.xml' path='doc/member[@name="NameSearchOptions.nsfRegularExpression"]/*' />
    nsfRegularExpression = 0x8,

    /// <include file='NameSearchOptions.xml' path='doc/member[@name="NameSearchOptions.nsfUndecoratedName"]/*' />
    nsfUndecoratedName = 0x10,

    /// <include file='NameSearchOptions.xml' path='doc/member[@name="NameSearchOptions.nsCaseSensitive"]/*' />
    nsCaseSensitive = nsfCaseSensitive,

    /// <include file='NameSearchOptions.xml' path='doc/member[@name="NameSearchOptions.nsCaseInsensitive"]/*' />
    nsCaseInsensitive = nsfCaseInsensitive,

    /// <include file='NameSearchOptions.xml' path='doc/member[@name="NameSearchOptions.nsFNameExt"]/*' />
    nsFNameExt = (nsfCaseInsensitive | nsfFNameExt),

    /// <include file='NameSearchOptions.xml' path='doc/member[@name="NameSearchOptions.nsRegularExpression"]/*' />
    nsRegularExpression = (nsfRegularExpression | nsfCaseSensitive),

    /// <include file='NameSearchOptions.xml' path='doc/member[@name="NameSearchOptions.nsCaseInRegularExpression"]/*' />
    nsCaseInRegularExpression = (nsfRegularExpression | nsfCaseInsensitive),
}
