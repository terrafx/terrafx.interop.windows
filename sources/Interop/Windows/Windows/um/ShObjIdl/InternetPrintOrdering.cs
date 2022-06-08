// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='InternetPrintOrdering.xml' path='doc/member[@name="InternetPrintOrdering"]/*' />
[Guid("ADD36AA8-751A-4579-A266-D66F5202CCBB")]
public partial struct InternetPrintOrdering : IHaveNativeGuid
{
    static ref readonly Guid IHaveNativeGuid.GUID => ref IID_InternetPrintOrdering;
}
