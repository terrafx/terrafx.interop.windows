// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.devices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='InfraredTorchMode.xml' path='doc/member[@name="InfraredTorchMode"]/*' />
public enum InfraredTorchMode
{
    /// <include file='InfraredTorchMode.xml' path='doc/member[@name="InfraredTorchMode.InfraredTorchMode_Off"]/*' />
    InfraredTorchMode_Off = 0,

    /// <include file='InfraredTorchMode.xml' path='doc/member[@name="InfraredTorchMode.InfraredTorchMode_On"]/*' />
    InfraredTorchMode_On = 1,

    /// <include file='InfraredTorchMode.xml' path='doc/member[@name="InfraredTorchMode.InfraredTorchMode_AlternatingFrameIllumination"]/*' />
    InfraredTorchMode_AlternatingFrameIllumination = 2,
}
