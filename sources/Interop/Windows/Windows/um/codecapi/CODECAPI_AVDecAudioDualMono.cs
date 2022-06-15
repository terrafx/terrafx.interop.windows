// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='CODECAPI_AVDecAudioDualMono.xml' path='doc/member[@name="CODECAPI_AVDecAudioDualMono"]/*' />
[Guid("4A52CDA8-30F8-4216-BE0F-BA0B2025921D")]
public partial struct CODECAPI_AVDecAudioDualMono : IHaveNativeGuid
{
    static ref readonly Guid IHaveNativeGuid.GUID => ref IID_CODECAPI_AVDecAudioDualMono;
}
