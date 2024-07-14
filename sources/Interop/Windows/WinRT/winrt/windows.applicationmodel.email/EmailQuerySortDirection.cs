// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.email.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='EmailQuerySortDirection.xml' path='doc/member[@name="EmailQuerySortDirection"]/*' />
public enum EmailQuerySortDirection
{
    /// <include file='EmailQuerySortDirection.xml' path='doc/member[@name="EmailQuerySortDirection.EmailQuerySortDirection_Descending"]/*' />
    EmailQuerySortDirection_Descending = 0,

    /// <include file='EmailQuerySortDirection.xml' path='doc/member[@name="EmailQuerySortDirection.EmailQuerySortDirection_Ascending"]/*' />
    EmailQuerySortDirection_Ascending = 1,
}
