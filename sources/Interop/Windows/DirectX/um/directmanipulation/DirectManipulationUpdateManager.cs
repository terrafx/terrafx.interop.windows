// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/directmanipulation.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.CLSID;

namespace TerraFX.Interop.DirectX;

/// <include file='DirectManipulationUpdateManager.xml' path='doc/member[@name="DirectManipulationUpdateManager"]/*' />
[Guid("9FC1BFD5-1835-441A-B3B1-B6CC74B727D0")]
public partial struct DirectManipulationUpdateManager : IHaveNativeGuid
{
    static ref readonly Guid IHaveNativeGuid.GUID => ref CLSID_DirectManipulationUpdateManager;
}
