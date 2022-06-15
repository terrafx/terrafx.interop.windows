// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='CODECAPI_AVEncVideoForceKeyFrame.xml' path='doc/member[@name="CODECAPI_AVEncVideoForceKeyFrame"]/*' />
[Guid("398C1B98-8353-475A-9EF2-8F265D260345")]
public partial struct CODECAPI_AVEncVideoForceKeyFrame : IHaveNativeGuid
{
    static ref readonly Guid IHaveNativeGuid.GUID => ref IID_CODECAPI_AVEncVideoForceKeyFrame;
}
