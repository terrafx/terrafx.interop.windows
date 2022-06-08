// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='ApplicationActivationManager.xml' path='doc/member[@name="ApplicationActivationManager"]/*' />
[Guid("45BA127D-10A8-46EA-8AB7-56EA9078943C")]
public partial struct ApplicationActivationManager : IHaveNativeGuid
{
    static ref readonly Guid IHaveNativeGuid.GUID => ref IID_ApplicationActivationManager;
}
