// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.search.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='SortEntry.xml' path='doc/member[@name="SortEntry"]/*' />
public partial struct SortEntry
{
    /// <include file='SortEntry.xml' path='doc/member[@name="SortEntry.PropertyName"]/*' />
    public HSTRING PropertyName;

    /// <include file='SortEntry.xml' path='doc/member[@name="SortEntry.AscendingOrder"]/*' />
    [NativeTypeName("boolean")]
    public byte AscendingOrder;
}
