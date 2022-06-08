// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='CODECAPI_AVEncVideoOutputColorTransferMatrix.xml' path='doc/member[@name="CODECAPI_AVEncVideoOutputColorTransferMatrix"]/*' />
[Guid("A9B90444-AF40-4310-8FBE-ED6D933F892B")]
public partial struct CODECAPI_AVEncVideoOutputColorTransferMatrix : IHaveNativeGuid
{
    static ref readonly Guid IHaveNativeGuid.GUID => ref IID_CODECAPI_AVEncVideoOutputColorTransferMatrix;
}
