// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='CODECAPI_AVEncMuxOutputStreamType.xml' path='doc/member[@name="CODECAPI_AVEncMuxOutputStreamType"]/*' />
[Guid("CEDD9E8F-34D3-44DB-A1D8-F81520254F3E")]
public partial struct CODECAPI_AVEncMuxOutputStreamType : IHaveNativeGuid
{
    static ref readonly Guid IHaveNativeGuid.GUID => ref IID_CODECAPI_AVEncMuxOutputStreamType;
}
