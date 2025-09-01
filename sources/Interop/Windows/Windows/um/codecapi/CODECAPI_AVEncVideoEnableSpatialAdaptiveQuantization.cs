// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='CODECAPI_AVEncVideoEnableSpatialAdaptiveQuantization.xml' path='doc/member[@name="CODECAPI_AVEncVideoEnableSpatialAdaptiveQuantization"]/*' />
[Guid("659CB943-15CA-448D-B99A-875619DB4DE4")]
public unsafe partial struct CODECAPI_AVEncVideoEnableSpatialAdaptiveQuantization : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_CODECAPI_AVEncVideoEnableSpatialAdaptiveQuantization);
}
