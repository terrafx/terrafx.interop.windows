// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public unsafe partial struct SP_DETECTDEVICE_PARAMS64
{
    public SP_CLASSINSTALL_HEADER64 ClassInstallHeader;

    [NativeTypeName("PDETECT_PROGRESS_NOTIFY")]
    public delegate* unmanaged<void*, uint, int> DetectProgressNotify;

    [NativeTypeName("PVOID")]
    public void* ProgressNotifyParam;
}
