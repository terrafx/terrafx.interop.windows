// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='CODECAPI_AVDecAACDownmixMode.xml' path='doc/member[@name="CODECAPI_AVDecAACDownmixMode"]/*' />
[Guid("01274475-F6BB-4017-B084-81A763C942D4")]
public partial struct CODECAPI_AVDecAACDownmixMode : IHaveNativeGuid
{
    static ref readonly Guid IHaveNativeGuid.GUID => ref IID_CODECAPI_AVDecAACDownmixMode;
}
