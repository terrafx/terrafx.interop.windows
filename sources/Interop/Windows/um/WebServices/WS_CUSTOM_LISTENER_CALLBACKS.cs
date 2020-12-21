// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;

namespace TerraFX.Interop
{
    public unsafe partial struct WS_CUSTOM_LISTENER_CALLBACKS
    {
        [NativeTypeName("WS_CREATE_LISTENER_CALLBACK")]
#if !NETSTANDARD2_0
        public delegate* unmanaged<WS_CHANNEL_TYPE, void*, uint, void**, IntPtr, int> createListenerCallback;
#else
        public void* _createListenerCallback;

        public delegate* unmanaged[Stdcall]<WS_CHANNEL_TYPE, void*, uint, void**, IntPtr, int> createListenerCallback
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (delegate* unmanaged[Stdcall]<WS_CHANNEL_TYPE, void*, uint, void**, IntPtr, int>)_createListenerCallback;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _createListenerCallback = value;
            }
        }
#endif

        [NativeTypeName("WS_FREE_LISTENER_CALLBACK")]
#if !NETSTANDARD2_0
        public delegate* unmanaged<void*, void> freeListenerCallback;
#else
        public void* _freeListenerCallback;

        public delegate* unmanaged[Stdcall]<void*, void> freeListenerCallback
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (delegate* unmanaged[Stdcall]<void*, void>)_freeListenerCallback;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _freeListenerCallback = value;
            }
        }
#endif

        [NativeTypeName("WS_RESET_LISTENER_CALLBACK")]
#if !NETSTANDARD2_0
        public delegate* unmanaged<void*, IntPtr, int> resetListenerCallback;
#else
        public void* _resetListenerCallback;

        public delegate* unmanaged[Stdcall]<void*, IntPtr, int> resetListenerCallback
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (delegate* unmanaged[Stdcall]<void*, IntPtr, int>)_resetListenerCallback;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _resetListenerCallback = value;
            }
        }
#endif

        [NativeTypeName("WS_OPEN_LISTENER_CALLBACK")]
#if !NETSTANDARD2_0
        public delegate* unmanaged<void*, WS_STRING*, WS_ASYNC_CONTEXT*, IntPtr, int> openListenerCallback;
#else
        public void* _openListenerCallback;

        public delegate* unmanaged[Stdcall]<void*, WS_STRING*, WS_ASYNC_CONTEXT*, IntPtr, int> openListenerCallback
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (delegate* unmanaged[Stdcall]<void*, WS_STRING*, WS_ASYNC_CONTEXT*, IntPtr, int>)_openListenerCallback;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _openListenerCallback = value;
            }
        }
#endif

        [NativeTypeName("WS_CLOSE_LISTENER_CALLBACK")]
#if !NETSTANDARD2_0
        public delegate* unmanaged<void*, WS_ASYNC_CONTEXT*, IntPtr, int> closeListenerCallback;
#else
        public void* _closeListenerCallback;

        public delegate* unmanaged[Stdcall]<void*, WS_ASYNC_CONTEXT*, IntPtr, int> closeListenerCallback
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (delegate* unmanaged[Stdcall]<void*, WS_ASYNC_CONTEXT*, IntPtr, int>)_closeListenerCallback;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _closeListenerCallback = value;
            }
        }
#endif

        [NativeTypeName("WS_ABORT_LISTENER_CALLBACK")]
#if !NETSTANDARD2_0
        public delegate* unmanaged<void*, IntPtr, int> abortListenerCallback;
#else
        public void* _abortListenerCallback;

        public delegate* unmanaged[Stdcall]<void*, IntPtr, int> abortListenerCallback
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (delegate* unmanaged[Stdcall]<void*, IntPtr, int>)_abortListenerCallback;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _abortListenerCallback = value;
            }
        }
#endif

        [NativeTypeName("WS_GET_LISTENER_PROPERTY_CALLBACK")]
#if !NETSTANDARD2_0
        public delegate* unmanaged<void*, WS_LISTENER_PROPERTY_ID, void*, uint, IntPtr, int> getListenerPropertyCallback;
#else
        public void* _getListenerPropertyCallback;

        public delegate* unmanaged[Stdcall]<void*, WS_LISTENER_PROPERTY_ID, void*, uint, IntPtr, int> getListenerPropertyCallback
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (delegate* unmanaged[Stdcall]<void*, WS_LISTENER_PROPERTY_ID, void*, uint, IntPtr, int>)_getListenerPropertyCallback;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _getListenerPropertyCallback = value;
            }
        }
#endif

        [NativeTypeName("WS_SET_LISTENER_PROPERTY_CALLBACK")]
#if !NETSTANDARD2_0
        public delegate* unmanaged<void*, WS_LISTENER_PROPERTY_ID, void*, uint, IntPtr, int> setListenerPropertyCallback;
#else
        public void* _setListenerPropertyCallback;

        public delegate* unmanaged[Stdcall]<void*, WS_LISTENER_PROPERTY_ID, void*, uint, IntPtr, int> setListenerPropertyCallback
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (delegate* unmanaged[Stdcall]<void*, WS_LISTENER_PROPERTY_ID, void*, uint, IntPtr, int>)_setListenerPropertyCallback;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _setListenerPropertyCallback = value;
            }
        }
#endif

        [NativeTypeName("WS_CREATE_CHANNEL_FOR_LISTENER_CALLBACK")]
#if !NETSTANDARD2_0
        public delegate* unmanaged<void*, void*, uint, void**, IntPtr, int> createChannelForListenerCallback;
#else
        public void* _createChannelForListenerCallback;

        public delegate* unmanaged[Stdcall]<void*, void*, uint, void**, IntPtr, int> createChannelForListenerCallback
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (delegate* unmanaged[Stdcall]<void*, void*, uint, void**, IntPtr, int>)_createChannelForListenerCallback;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _createChannelForListenerCallback = value;
            }
        }
#endif

        [NativeTypeName("WS_ACCEPT_CHANNEL_CALLBACK")]
#if !NETSTANDARD2_0
        public delegate* unmanaged<void*, void*, WS_ASYNC_CONTEXT*, IntPtr, int> acceptChannelCallback;
#else
        public void* _acceptChannelCallback;

        public delegate* unmanaged[Stdcall]<void*, void*, WS_ASYNC_CONTEXT*, IntPtr, int> acceptChannelCallback
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (delegate* unmanaged[Stdcall]<void*, void*, WS_ASYNC_CONTEXT*, IntPtr, int>)_acceptChannelCallback;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _acceptChannelCallback = value;
            }
        }
#endif
    }
}
