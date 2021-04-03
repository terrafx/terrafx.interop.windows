// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct WS_OPERATION_DESCRIPTION
    {
        [NativeTypeName("ULONG")]
        public uint versionInfo;

        public WS_MESSAGE_DESCRIPTION* inputMessageDescription;

        public WS_MESSAGE_DESCRIPTION* outputMessageDescription;

        [NativeTypeName("ULONG")]
        public uint inputMessageOptions;

        [NativeTypeName("ULONG")]
        public uint outputMessageOptions;

        [NativeTypeName("USHORT")]
        public ushort parameterCount;

        public WS_PARAMETER_DESCRIPTION* parameterDescription;

        [NativeTypeName("WS_SERVICE_STUB_CALLBACK")]
        public delegate* unmanaged<IntPtr, void*, void*, WS_ASYNC_CONTEXT*, IntPtr, int> stubCallback;

        public WS_OPERATION_STYLE style;
    }
}
