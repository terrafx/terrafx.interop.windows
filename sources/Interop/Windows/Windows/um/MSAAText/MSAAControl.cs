// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MSAAText.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='MSAAControl.xml' path='doc/member[@name="MSAAControl"]/*' />
[Guid("08CD963F-7A3E-4F5C-9BD8-D692BB043C5B")]
public partial struct MSAAControl : IHaveNativeGuid
{
    static ref readonly Guid IHaveNativeGuid.GUID => ref IID_MSAAControl;
}
