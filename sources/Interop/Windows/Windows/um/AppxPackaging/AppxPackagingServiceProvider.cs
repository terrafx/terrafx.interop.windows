// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='AppxPackagingServiceProvider.xml' path='doc/member[@name="AppxPackagingServiceProvider"]/*' />
[Guid("FB1B3839-09DA-404F-B002-9CBB8DA5CA4F")]
public unsafe partial struct AppxPackagingServiceProvider : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_AppxPackagingServiceProvider);
}
