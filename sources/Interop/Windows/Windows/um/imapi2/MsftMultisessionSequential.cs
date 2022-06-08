// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/imapi2.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.CLSID;

namespace TerraFX.Interop.Windows;

/// <include file='MsftMultisessionSequential.xml' path='doc/member[@name="MsftMultisessionSequential"]/*' />
[Guid("27354122-7F64-5B0F-8F00-5D77AFBE261E")]
public partial struct MsftMultisessionSequential : IHaveNativeGuid
{
    static ref readonly Guid IHaveNativeGuid.GUID => ref CLSID_MsftMultisessionSequential;
}
