// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='CODECAPI_GUID_AVDecAudioInputDolby.xml' path='doc/member[@name="CODECAPI_GUID_AVDecAudioInputDolby"]/*' />
[Guid("8E4228A0-F000-4E0B-8F54-AB8D24AD61A2")]
public unsafe partial struct CODECAPI_GUID_AVDecAudioInputDolby : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_CODECAPI_GUID_AVDecAudioInputDolby));
}
