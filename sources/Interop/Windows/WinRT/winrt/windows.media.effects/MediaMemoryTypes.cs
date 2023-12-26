// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.effects.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='MediaMemoryTypes.xml' path='doc/member[@name="MediaMemoryTypes"]/*' />
public enum MediaMemoryTypes
{
    /// <include file='MediaMemoryTypes.xml' path='doc/member[@name="MediaMemoryTypes.MediaMemoryTypes_Gpu"]/*' />
    MediaMemoryTypes_Gpu = 0,

    /// <include file='MediaMemoryTypes.xml' path='doc/member[@name="MediaMemoryTypes.MediaMemoryTypes_Cpu"]/*' />
    MediaMemoryTypes_Cpu = 1,

    /// <include file='MediaMemoryTypes.xml' path='doc/member[@name="MediaMemoryTypes.MediaMemoryTypes_GpuAndCpu"]/*' />
    MediaMemoryTypes_GpuAndCpu = 2,
}
