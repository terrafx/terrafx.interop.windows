// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MSAAText.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='AccClientDocMgr.xml' path='doc/member[@name="AccClientDocMgr"]/*' />
[Guid("FC48CC30-4F3E-4FA1-803B-AD0E196A83B1")]
public partial struct AccClientDocMgr : IHaveNativeGuid
{
    static ref readonly Guid IHaveNativeGuid.GUID => ref IID_AccClientDocMgr;
}
