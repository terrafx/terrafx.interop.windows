// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ExDisp.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='ShellUIHelper.xml' path='doc/member[@name="ShellUIHelper"]/*' />
[Guid("64AB4BB7-111E-11D1-8F79-00C04FC2FBE1")]
public partial struct ShellUIHelper : IHaveNativeGuid
{
    static ref readonly Guid IHaveNativeGuid.GUID => ref IID_ShellUIHelper;
}
