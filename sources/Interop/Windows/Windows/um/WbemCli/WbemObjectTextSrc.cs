// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WbemCli.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='WbemObjectTextSrc.xml' path='doc/member[@name="WbemObjectTextSrc"]/*' />
[Guid("8D1C559D-84F0-4BB3-A7D5-56A7435A9BA6")]
public partial struct WbemObjectTextSrc : IHaveNativeGuid
{
    static ref readonly Guid IHaveNativeGuid.GUID => ref IID_WbemObjectTextSrc;
}
