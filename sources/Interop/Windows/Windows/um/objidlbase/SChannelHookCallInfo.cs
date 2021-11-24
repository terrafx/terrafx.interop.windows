// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/objidlbase.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.Windows;

public unsafe partial struct SChannelHookCallInfo
{
    [NativeTypeName("IID")]
    public Guid iid;

    [NativeTypeName("DWORD")]
    public uint cbSize;

    public Guid uCausality;

    [NativeTypeName("DWORD")]
    public uint dwServerPid;

    [NativeTypeName("DWORD")]
    public uint iMethod;

    public void* pObject;
}
