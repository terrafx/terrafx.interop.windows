// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.CLSID;

namespace TerraFX.Interop.Windows;

/// <include file='SpInProcRecoContext.xml' path='doc/member[@name="SpInProcRecoContext"]/*' />
[Guid("73AD6842-ACE0-45E8-A4DD-8795881A2C2A")]
public partial struct SpInProcRecoContext : IHaveNativeGuid
{
    static ref readonly Guid IHaveNativeGuid.GUID => ref CLSID_SpInProcRecoContext;
}
