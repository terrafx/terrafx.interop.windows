// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/xapo.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe partial struct XAPO_REGISTRATION_PROPERTIES
    {
        [NativeTypeName("CLSID")]
        public Guid clsid;

        [NativeTypeName("WCHAR [256]")]
        public fixed ushort FriendlyName[256];

        [NativeTypeName("WCHAR [256]")]
        public fixed ushort CopyrightInfo[256];

        [NativeTypeName("UINT32")]
        public uint MajorVersion;

        [NativeTypeName("UINT32")]
        public uint MinorVersion;

        [NativeTypeName("UINT32")]
        public uint Flags;

        [NativeTypeName("UINT32")]
        public uint MinInputBufferCount;

        [NativeTypeName("UINT32")]
        public uint MaxInputBufferCount;

        [NativeTypeName("UINT32")]
        public uint MinOutputBufferCount;

        [NativeTypeName("UINT32")]
        public uint MaxOutputBufferCount;
    }
}
