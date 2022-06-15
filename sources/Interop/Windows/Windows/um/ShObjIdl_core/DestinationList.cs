// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='DestinationList.xml' path='doc/member[@name="DestinationList"]/*' />
[Guid("77F10CF0-3DB5-4966-B520-B7C54FD35ED6")]
public partial struct DestinationList : IHaveNativeGuid
{
    static ref readonly Guid IHaveNativeGuid.GUID => ref IID_DestinationList;
}
