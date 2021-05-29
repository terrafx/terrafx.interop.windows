// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct WS_CUSTOM_LISTENER_CALLBACKS
    {
        [NativeTypeName("WS_CREATE_LISTENER_CALLBACK")]
        public delegate* unmanaged<WS_CHANNEL_TYPE, void*, uint, void**, IntPtr, int> createListenerCallback;

        [NativeTypeName("WS_FREE_LISTENER_CALLBACK")]
        public delegate* unmanaged<void*, void> freeListenerCallback;

        [NativeTypeName("WS_RESET_LISTENER_CALLBACK")]
        public delegate* unmanaged<void*, IntPtr, int> resetListenerCallback;

        [NativeTypeName("WS_OPEN_LISTENER_CALLBACK")]
        public delegate* unmanaged<void*, WS_STRING*, WS_ASYNC_CONTEXT*, IntPtr, int> openListenerCallback;

        [NativeTypeName("WS_CLOSE_LISTENER_CALLBACK")]
        public delegate* unmanaged<void*, WS_ASYNC_CONTEXT*, IntPtr, int> closeListenerCallback;

        [NativeTypeName("WS_ABORT_LISTENER_CALLBACK")]
        public delegate* unmanaged<void*, IntPtr, int> abortListenerCallback;

        [NativeTypeName("WS_GET_LISTENER_PROPERTY_CALLBACK")]
        public delegate* unmanaged<void*, WS_LISTENER_PROPERTY_ID, void*, uint, IntPtr, int> getListenerPropertyCallback;

        [NativeTypeName("WS_SET_LISTENER_PROPERTY_CALLBACK")]
        public delegate* unmanaged<void*, WS_LISTENER_PROPERTY_ID, void*, uint, IntPtr, int> setListenerPropertyCallback;

        [NativeTypeName("WS_CREATE_CHANNEL_FOR_LISTENER_CALLBACK")]
        public delegate* unmanaged<void*, void*, uint, void**, IntPtr, int> createChannelForListenerCallback;

        [NativeTypeName("WS_ACCEPT_CHANNEL_CALLBACK")]
        public delegate* unmanaged<void*, void*, WS_ASYNC_CONTEXT*, IntPtr, int> acceptChannelCallback;
    }
}
