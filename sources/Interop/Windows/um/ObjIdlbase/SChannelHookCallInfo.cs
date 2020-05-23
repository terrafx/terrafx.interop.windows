// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdlbase.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct SChannelHookCallInfo
    {
        [NativeTypeName("IID")]
        public Guid iid;

        [NativeTypeName("DWORD")]
        public uint cbSize;

        [NativeTypeName("GUID")]
        public Guid uCausality;

        [NativeTypeName("DWORD")]
        public uint dwServerPid;

        [NativeTypeName("DWORD")]
        public uint iMethod;

        [NativeTypeName("void *")]
        public void* pObject;
    }
}
