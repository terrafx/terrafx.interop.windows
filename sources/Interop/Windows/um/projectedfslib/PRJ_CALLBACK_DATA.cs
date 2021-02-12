// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/projectedfslib.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct PRJ_CALLBACK_DATA
    {
        [NativeTypeName("UINT32")]
        public uint Size;

        public PRJ_CALLBACK_DATA_FLAGS Flags;

        [NativeTypeName("PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT")]
        public IntPtr NamespaceVirtualizationContext;

        [NativeTypeName("INT32")]
        public int CommandId;

        [NativeTypeName("GUID")]
        public Guid FileId;

        [NativeTypeName("GUID")]
        public Guid DataStreamId;

        [NativeTypeName("PCWSTR")]
        public ushort* FilePathName;

        [NativeTypeName("PRJ_PLACEHOLDER_VERSION_INFO *")]
        public PRJ_PLACEHOLDER_VERSION_INFO* VersionInfo;

        [NativeTypeName("UINT32")]
        public uint TriggeringProcessId;

        [NativeTypeName("PCWSTR")]
        public ushort* TriggeringProcessImageFileName;

        [NativeTypeName("void *")]
        public void* InstanceContext;
    }
}
