// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/imapi2.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.CLSID;

namespace TerraFX.Interop.Windows;

/// <include file='MsftWriteEngine2.xml' path='doc/member[@name="MsftWriteEngine2"]/*' />
[Guid("2735412C-7F64-5B0F-8F00-5D77AFBE261E")]
public partial struct MsftWriteEngine2 : IHaveNativeGuid
{
    static ref readonly Guid IHaveNativeGuid.GUID => ref CLSID_MsftWriteEngine2;
}
