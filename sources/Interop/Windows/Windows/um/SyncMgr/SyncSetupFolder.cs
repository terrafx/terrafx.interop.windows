// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SyncMgr.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='SyncSetupFolder.xml' path='doc/member[@name="SyncSetupFolder"]/*' />
[Guid("2E9E59C0-B437-4981-A647-9C34B9B90891")]
public partial struct SyncSetupFolder : IHaveNativeGuid
{
    static ref readonly Guid IHaveNativeGuid.GUID => ref IID_SyncSetupFolder;
}
