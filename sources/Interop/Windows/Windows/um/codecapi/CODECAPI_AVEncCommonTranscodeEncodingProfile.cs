// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='CODECAPI_AVEncCommonTranscodeEncodingProfile.xml' path='doc/member[@name="CODECAPI_AVEncCommonTranscodeEncodingProfile"]/*' />
[Guid("6947787C-F508-4EA9-B1E9-A1FE3A49FBC9")]
public unsafe partial struct CODECAPI_AVEncCommonTranscodeEncodingProfile : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_CODECAPI_AVEncCommonTranscodeEncodingProfile));
}
