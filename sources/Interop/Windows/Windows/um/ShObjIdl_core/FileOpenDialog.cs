// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='FileOpenDialog.xml' path='doc/member[@name="FileOpenDialog"]/*' />
[Guid("DC1C5A9C-E88A-4DDE-A5A1-60F82A20AEF7")]
public partial struct FileOpenDialog : IHaveNativeGuid
{
    static ref readonly Guid IHaveNativeGuid.GUID => ref IID_FileOpenDialog;
}
