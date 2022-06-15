// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='NamespaceTreeControl.xml' path='doc/member[@name="NamespaceTreeControl"]/*' />
[Guid("AE054212-3535-4430-83ED-D501AA6680E6")]
public partial struct NamespaceTreeControl : IHaveNativeGuid
{
    static ref readonly Guid IHaveNativeGuid.GUID => ref IID_NamespaceTreeControl;
}
