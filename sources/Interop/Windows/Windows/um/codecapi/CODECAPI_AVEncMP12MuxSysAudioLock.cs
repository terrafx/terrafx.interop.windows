// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='CODECAPI_AVEncMP12MuxSysAudioLock.xml' path='doc/member[@name="CODECAPI_AVEncMP12MuxSysAudioLock"]/*' />
[Guid("0FBB5752-1D43-47BF-BD79-F2293D8CE337")]
public partial struct CODECAPI_AVEncMP12MuxSysAudioLock : IHaveNativeGuid
{
    static ref readonly Guid IHaveNativeGuid.GUID => ref IID_CODECAPI_AVEncMP12MuxSysAudioLock;
}
