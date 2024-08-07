// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='CODECAPI_AVDecVideoDXVAMode.xml' path='doc/member[@name="CODECAPI_AVDecVideoDXVAMode"]/*' />
[Guid("F758F09E-7337-4AE7-8387-73DC2D54E67D")]
public unsafe partial struct CODECAPI_AVDecVideoDXVAMode : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_CODECAPI_AVDecVideoDXVAMode));
}
