// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='NamespaceWalker.xml' path='doc/member[@name="NamespaceWalker"]/*' />
[Guid("72EB61E0-8672-4303-9175-F2E4C68B2E7C")]
public partial struct NamespaceWalker : IHaveNativeGuid
{
    static ref readonly Guid IHaveNativeGuid.GUID => ref IID_NamespaceWalker;
}
