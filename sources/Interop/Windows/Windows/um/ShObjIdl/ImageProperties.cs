// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='ImageProperties.xml' path='doc/member[@name="ImageProperties"]/*' />
[Guid("7AB770C7-0E23-4D7A-8AA2-19BFAD479829")]
public partial struct ImageProperties : IHaveNativeGuid
{
    static ref readonly Guid IHaveNativeGuid.GUID => ref IID_ImageProperties;
}
