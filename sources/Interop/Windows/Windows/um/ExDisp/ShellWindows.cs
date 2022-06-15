// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ExDisp.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='ShellWindows.xml' path='doc/member[@name="ShellWindows"]/*' />
[Guid("9BA05972-F6A8-11CF-A442-00A0C90A8F39")]
public partial struct ShellWindows : IHaveNativeGuid
{
    static ref readonly Guid IHaveNativeGuid.GUID => ref IID_ShellWindows;
}
