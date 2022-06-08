// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='PropertiesUI.xml' path='doc/member[@name="PropertiesUI"]/*' />
[Guid("D912F8CF-0396-4915-884E-FB425D32943B")]
public partial struct PropertiesUI : IHaveNativeGuid
{
    static ref readonly Guid IHaveNativeGuid.GUID => ref IID_PropertiesUI;
}
