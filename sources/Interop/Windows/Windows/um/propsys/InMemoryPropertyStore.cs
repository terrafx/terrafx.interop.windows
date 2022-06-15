// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/propsys.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.CLSID;

namespace TerraFX.Interop.Windows;

/// <include file='InMemoryPropertyStore.xml' path='doc/member[@name="InMemoryPropertyStore"]/*' />
[Guid("9A02E012-6303-4E1E-B9A1-630F802592C5")]
public partial struct InMemoryPropertyStore : IHaveNativeGuid
{
    static ref readonly Guid IHaveNativeGuid.GUID => ref CLSID_InMemoryPropertyStore;
}
