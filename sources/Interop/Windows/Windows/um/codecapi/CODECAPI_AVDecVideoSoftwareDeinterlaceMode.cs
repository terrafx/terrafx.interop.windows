// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='CODECAPI_AVDecVideoSoftwareDeinterlaceMode.xml' path='doc/member[@name="CODECAPI_AVDecVideoSoftwareDeinterlaceMode"]/*' />
[Guid("0C08D1CE-9CED-4540-BAE3-CEB380141109")]
public partial struct CODECAPI_AVDecVideoSoftwareDeinterlaceMode : IHaveNativeGuid
{
    static ref readonly Guid IHaveNativeGuid.GUID => ref IID_CODECAPI_AVDecVideoSoftwareDeinterlaceMode;
}
