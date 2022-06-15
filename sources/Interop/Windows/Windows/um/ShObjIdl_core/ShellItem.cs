// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='ShellItem.xml' path='doc/member[@name="ShellItem"]/*' />
[Guid("9AC9FBE1-E0A2-4AD6-B4EE-E212013EA917")]
public partial struct ShellItem : IHaveNativeGuid
{
    static ref readonly Guid IHaveNativeGuid.GUID => ref IID_ShellItem;
}
