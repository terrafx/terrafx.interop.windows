// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dxdiag.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX;

[Guid("9C6B4CB0-23F8-49CC-A3ED-45A55000A6D2")]
public partial struct IDxDiagProvider
{
    static ref readonly Guid IHaveNativeGuid.GUID => ref IID_IDxDiagProvider;
}
