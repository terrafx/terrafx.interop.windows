// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='OpenControlPanel.xml' path='doc/member[@name="OpenControlPanel"]/*' />
[Guid("06622D85-6856-4460-8DE1-A81921B41C4B")]
public partial struct OpenControlPanel : IHaveNativeGuid
{
    static ref readonly Guid IHaveNativeGuid.GUID => ref IID_OpenControlPanel;
}
