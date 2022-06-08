// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/mmreg.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='KSDATAFORMAT_SUBTYPE_PCM.xml' path='doc/member[@name="KSDATAFORMAT_SUBTYPE_PCM"]/*' />
[Guid("00000001-0000-0010-8000-00AA00389B71")]
public partial struct KSDATAFORMAT_SUBTYPE_PCM : IHaveNativeGuid
{
    static ref readonly Guid IHaveNativeGuid.GUID => ref IID_KSDATAFORMAT_SUBTYPE_PCM;
}
