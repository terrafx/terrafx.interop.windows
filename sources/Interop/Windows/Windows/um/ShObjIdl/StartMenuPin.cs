// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='StartMenuPin.xml' path='doc/member[@name="StartMenuPin"]/*' />
[Guid("A2A9545D-A0C2-42B4-9708-A0B2BADD77C8")]
public partial struct StartMenuPin : IHaveNativeGuid
{
    static ref readonly Guid IHaveNativeGuid.GUID => ref IID_StartMenuPin;
}
