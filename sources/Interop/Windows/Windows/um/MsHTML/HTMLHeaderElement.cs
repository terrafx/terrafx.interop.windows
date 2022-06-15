// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='HTMLHeaderElement.xml' path='doc/member[@name="HTMLHeaderElement"]/*' />
[Guid("3050F27A-98B5-11CF-BB82-00AA00BDCE0B")]
public partial struct HTMLHeaderElement : IHaveNativeGuid
{
    static ref readonly Guid IHaveNativeGuid.GUID => ref IID_HTMLHeaderElement;
}
