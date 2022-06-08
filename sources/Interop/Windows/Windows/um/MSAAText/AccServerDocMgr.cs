// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MSAAText.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='AccServerDocMgr.xml' path='doc/member[@name="AccServerDocMgr"]/*' />
[Guid("6089A37E-EB8A-482D-BD6F-F9F46904D16D")]
public partial struct AccServerDocMgr : IHaveNativeGuid
{
    static ref readonly Guid IHaveNativeGuid.GUID => ref IID_AccServerDocMgr;
}
