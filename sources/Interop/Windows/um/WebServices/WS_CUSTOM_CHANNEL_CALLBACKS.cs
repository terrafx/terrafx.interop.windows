// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct WS_CUSTOM_CHANNEL_CALLBACKS
    {
        [NativeTypeName("WS_CREATE_CHANNEL_CALLBACK")]
        public delegate* unmanaged<WS_CHANNEL_TYPE, void*, uint, void**, IntPtr, int> createChannelCallback;

        [NativeTypeName("WS_FREE_CHANNEL_CALLBACK")]
        public delegate* unmanaged<void*, void> freeChannelCallback;

        [NativeTypeName("WS_RESET_CHANNEL_CALLBACK")]
        public delegate* unmanaged<void*, IntPtr, int> resetChannelCallback;

        [NativeTypeName("WS_OPEN_CHANNEL_CALLBACK")]
        public delegate* unmanaged<void*, WS_ENDPOINT_ADDRESS*, WS_ASYNC_CONTEXT*, IntPtr, int> openChannelCallback;

        [NativeTypeName("WS_CLOSE_CHANNEL_CALLBACK")]
        public delegate* unmanaged<void*, WS_ASYNC_CONTEXT*, IntPtr, int> closeChannelCallback;

        [NativeTypeName("WS_ABORT_CHANNEL_CALLBACK")]
        public delegate* unmanaged<void*, IntPtr, int> abortChannelCallback;

        [NativeTypeName("WS_GET_CHANNEL_PROPERTY_CALLBACK")]
        public delegate* unmanaged<void*, WS_CHANNEL_PROPERTY_ID, void*, uint, IntPtr, int> getChannelPropertyCallback;

        [NativeTypeName("WS_SET_CHANNEL_PROPERTY_CALLBACK")]
        public delegate* unmanaged<void*, WS_CHANNEL_PROPERTY_ID, void*, uint, IntPtr, int> setChannelPropertyCallback;

        [NativeTypeName("WS_WRITE_MESSAGE_START_CALLBACK")]
        public delegate* unmanaged<void*, IntPtr, WS_ASYNC_CONTEXT*, IntPtr, int> writeMessageStartCallback;

        [NativeTypeName("WS_WRITE_MESSAGE_END_CALLBACK")]
        public delegate* unmanaged<void*, IntPtr, WS_ASYNC_CONTEXT*, IntPtr, int> writeMessageEndCallback;

        [NativeTypeName("WS_READ_MESSAGE_START_CALLBACK")]
        public delegate* unmanaged<void*, IntPtr, WS_ASYNC_CONTEXT*, IntPtr, int> readMessageStartCallback;

        [NativeTypeName("WS_READ_MESSAGE_END_CALLBACK")]
        public delegate* unmanaged<void*, IntPtr, WS_ASYNC_CONTEXT*, IntPtr, int> readMessageEndCallback;

        [NativeTypeName("WS_ABANDON_MESSAGE_CALLBACK")]
        public delegate* unmanaged<void*, IntPtr, IntPtr, int> abandonMessageCallback;

        [NativeTypeName("WS_SHUTDOWN_SESSION_CHANNEL_CALLBACK")]
        public delegate* unmanaged<void*, WS_ASYNC_CONTEXT*, IntPtr, int> shutdownSessionChannelCallback;
    }
}
