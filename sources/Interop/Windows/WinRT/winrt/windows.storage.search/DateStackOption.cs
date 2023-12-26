// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.search.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='DateStackOption.xml' path='doc/member[@name="DateStackOption"]/*' />
public enum DateStackOption
{
    /// <include file='DateStackOption.xml' path='doc/member[@name="DateStackOption.DateStackOption_None"]/*' />
    DateStackOption_None = 0,

    /// <include file='DateStackOption.xml' path='doc/member[@name="DateStackOption.DateStackOption_Year"]/*' />
    DateStackOption_Year = 1,

    /// <include file='DateStackOption.xml' path='doc/member[@name="DateStackOption.DateStackOption_Month"]/*' />
    DateStackOption_Month = 2,
}
