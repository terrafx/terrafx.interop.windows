// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='HTMLWindow2.xml' path='doc/member[@name="HTMLWindow2"]/*' />
[Guid("D48A6EC6-6A4A-11CF-94A7-444553540000")]
public partial struct HTMLWindow2 : IHaveNativeGuid
{
    static ref readonly Guid IHaveNativeGuid.GUID => ref IID_HTMLWindow2;
}
