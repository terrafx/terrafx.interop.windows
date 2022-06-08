// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WbemCli.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='WbemRefresher.xml' path='doc/member[@name="WbemRefresher"]/*' />
[Guid("C71566F2-561E-11D1-AD87-00C04FD8FDFF")]
public partial struct WbemRefresher : IHaveNativeGuid
{
    static ref readonly Guid IHaveNativeGuid.GUID => ref IID_WbemRefresher;
}
