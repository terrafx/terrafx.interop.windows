// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ExDisp.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='InternetExplorer.xml' path='doc/member[@name="InternetExplorer"]/*' />
[Guid("0002DF01-0000-0000-C000-000000000046")]
public partial struct InternetExplorer : IHaveNativeGuid
{
    static ref readonly Guid IHaveNativeGuid.GUID => ref IID_InternetExplorer;
}
