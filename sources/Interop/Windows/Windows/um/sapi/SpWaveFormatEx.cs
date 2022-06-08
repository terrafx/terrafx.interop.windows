// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.CLSID;

namespace TerraFX.Interop.Windows;

/// <include file='SpWaveFormatEx.xml' path='doc/member[@name="SpWaveFormatEx"]/*' />
[Guid("C79A574C-63BE-44B9-801F-283F87F898BE")]
public partial struct SpWaveFormatEx : IHaveNativeGuid
{
    static ref readonly Guid IHaveNativeGuid.GUID => ref CLSID_SpWaveFormatEx;
}
