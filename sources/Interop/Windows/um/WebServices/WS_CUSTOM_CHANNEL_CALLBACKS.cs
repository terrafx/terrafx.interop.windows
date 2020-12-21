// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;

namespace TerraFX.Interop
{
    public unsafe partial struct WS_CUSTOM_CHANNEL_CALLBACKS
    {
        [NativeTypeName("WS_CREATE_CHANNEL_CALLBACK")]
#if !NETSTANDARD2_0
        public delegate* unmanaged<WS_CHANNEL_TYPE, void*, uint, void**, IntPtr, int> createChannelCallback;
#else
        public void* _createChannelCallback;

        public delegate* unmanaged[Stdcall]<WS_CHANNEL_TYPE, void*, uint, void**, IntPtr, int> createChannelCallback
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (delegate* unmanaged[Stdcall]<WS_CHANNEL_TYPE, void*, uint, void**, IntPtr, int>)_createChannelCallback;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _createChannelCallback = value;
            }
        }
#endif

        [NativeTypeName("WS_FREE_CHANNEL_CALLBACK")]
#if !NETSTANDARD2_0
        public delegate* unmanaged<void*, void> freeChannelCallback;
#else
        public void* _freeChannelCallback;

        public delegate* unmanaged[Stdcall]<void*, void> freeChannelCallback
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (delegate* unmanaged[Stdcall]<void*, void>)_freeChannelCallback;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _freeChannelCallback = value;
            }
        }
#endif

        [NativeTypeName("WS_RESET_CHANNEL_CALLBACK")]
#if !NETSTANDARD2_0
        public delegate* unmanaged<void*, IntPtr, int> resetChannelCallback;
#else
        public void* _resetChannelCallback;

        public delegate* unmanaged[Stdcall]<void*, IntPtr, int> resetChannelCallback
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (delegate* unmanaged[Stdcall]<void*, IntPtr, int>)_resetChannelCallback;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _resetChannelCallback = value;
            }
        }
#endif

        [NativeTypeName("WS_OPEN_CHANNEL_CALLBACK")]
#if !NETSTANDARD2_0
        public delegate* unmanaged<void*, WS_ENDPOINT_ADDRESS*, WS_ASYNC_CONTEXT*, IntPtr, int> openChannelCallback;
#else
        public void* _openChannelCallback;

        public delegate* unmanaged[Stdcall]<void*, WS_ENDPOINT_ADDRESS*, WS_ASYNC_CONTEXT*, IntPtr, int> openChannelCallback
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (delegate* unmanaged[Stdcall]<void*, WS_ENDPOINT_ADDRESS*, WS_ASYNC_CONTEXT*, IntPtr, int>)_openChannelCallback;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _openChannelCallback = value;
            }
        }
#endif

        [NativeTypeName("WS_CLOSE_CHANNEL_CALLBACK")]
#if !NETSTANDARD2_0
        public delegate* unmanaged<void*, WS_ASYNC_CONTEXT*, IntPtr, int> closeChannelCallback;
#else
        public void* _closeChannelCallback;

        public delegate* unmanaged[Stdcall]<void*, WS_ASYNC_CONTEXT*, IntPtr, int> closeChannelCallback
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (delegate* unmanaged[Stdcall]<void*, WS_ASYNC_CONTEXT*, IntPtr, int>)_closeChannelCallback;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _closeChannelCallback = value;
            }
        }
#endif

        [NativeTypeName("WS_ABORT_CHANNEL_CALLBACK")]
#if !NETSTANDARD2_0
        public delegate* unmanaged<void*, IntPtr, int> abortChannelCallback;
#else
        public void* _abortChannelCallback;

        public delegate* unmanaged[Stdcall]<void*, IntPtr, int> abortChannelCallback
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (delegate* unmanaged[Stdcall]<void*, IntPtr, int>)_abortChannelCallback;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _abortChannelCallback = value;
            }
        }
#endif

        [NativeTypeName("WS_GET_CHANNEL_PROPERTY_CALLBACK")]
#if !NETSTANDARD2_0
        public delegate* unmanaged<void*, WS_CHANNEL_PROPERTY_ID, void*, uint, IntPtr, int> getChannelPropertyCallback;
#else
        public void* _getChannelPropertyCallback;

        public delegate* unmanaged[Stdcall]<void*, WS_CHANNEL_PROPERTY_ID, void*, uint, IntPtr, int> getChannelPropertyCallback
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (delegate* unmanaged[Stdcall]<void*, WS_CHANNEL_PROPERTY_ID, void*, uint, IntPtr, int>)_getChannelPropertyCallback;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _getChannelPropertyCallback = value;
            }
        }
#endif

        [NativeTypeName("WS_SET_CHANNEL_PROPERTY_CALLBACK")]
#if !NETSTANDARD2_0
        public delegate* unmanaged<void*, WS_CHANNEL_PROPERTY_ID, void*, uint, IntPtr, int> setChannelPropertyCallback;
#else
        public void* _setChannelPropertyCallback;

        public delegate* unmanaged[Stdcall]<void*, WS_CHANNEL_PROPERTY_ID, void*, uint, IntPtr, int> setChannelPropertyCallback
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (delegate* unmanaged[Stdcall]<void*, WS_CHANNEL_PROPERTY_ID, void*, uint, IntPtr, int>)_setChannelPropertyCallback;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _setChannelPropertyCallback = value;
            }
        }
#endif

        [NativeTypeName("WS_WRITE_MESSAGE_START_CALLBACK")]
#if !NETSTANDARD2_0
        public delegate* unmanaged<void*, IntPtr, WS_ASYNC_CONTEXT*, IntPtr, int> writeMessageStartCallback;
#else
        public void* _writeMessageStartCallback;

        public delegate* unmanaged[Stdcall]<void*, IntPtr, WS_ASYNC_CONTEXT*, IntPtr, int> writeMessageStartCallback
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (delegate* unmanaged[Stdcall]<void*, IntPtr, WS_ASYNC_CONTEXT*, IntPtr, int>)_writeMessageStartCallback;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _writeMessageStartCallback = value;
            }
        }
#endif

        [NativeTypeName("WS_WRITE_MESSAGE_END_CALLBACK")]
#if !NETSTANDARD2_0
        public delegate* unmanaged<void*, IntPtr, WS_ASYNC_CONTEXT*, IntPtr, int> writeMessageEndCallback;
#else
        public void* _writeMessageEndCallback;

        public delegate* unmanaged[Stdcall]<void*, IntPtr, WS_ASYNC_CONTEXT*, IntPtr, int> writeMessageEndCallback
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (delegate* unmanaged[Stdcall]<void*, IntPtr, WS_ASYNC_CONTEXT*, IntPtr, int>)_writeMessageEndCallback;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _writeMessageEndCallback = value;
            }
        }
#endif

        [NativeTypeName("WS_READ_MESSAGE_START_CALLBACK")]
#if !NETSTANDARD2_0
        public delegate* unmanaged<void*, IntPtr, WS_ASYNC_CONTEXT*, IntPtr, int> readMessageStartCallback;
#else
        public void* _readMessageStartCallback;

        public delegate* unmanaged[Stdcall]<void*, IntPtr, WS_ASYNC_CONTEXT*, IntPtr, int> readMessageStartCallback
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (delegate* unmanaged[Stdcall]<void*, IntPtr, WS_ASYNC_CONTEXT*, IntPtr, int>)_readMessageStartCallback;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _readMessageStartCallback = value;
            }
        }
#endif

        [NativeTypeName("WS_READ_MESSAGE_END_CALLBACK")]
#if !NETSTANDARD2_0
        public delegate* unmanaged<void*, IntPtr, WS_ASYNC_CONTEXT*, IntPtr, int> readMessageEndCallback;
#else
        public void* _readMessageEndCallback;

        public delegate* unmanaged[Stdcall]<void*, IntPtr, WS_ASYNC_CONTEXT*, IntPtr, int> readMessageEndCallback
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (delegate* unmanaged[Stdcall]<void*, IntPtr, WS_ASYNC_CONTEXT*, IntPtr, int>)_readMessageEndCallback;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _readMessageEndCallback = value;
            }
        }
#endif

        [NativeTypeName("WS_ABANDON_MESSAGE_CALLBACK")]
#if !NETSTANDARD2_0
        public delegate* unmanaged<void*, IntPtr, IntPtr, int> abandonMessageCallback;
#else
        public void* _abandonMessageCallback;

        public delegate* unmanaged[Stdcall]<void*, IntPtr, IntPtr, int> abandonMessageCallback
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (delegate* unmanaged[Stdcall]<void*, IntPtr, IntPtr, int>)_abandonMessageCallback;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _abandonMessageCallback = value;
            }
        }
#endif

        [NativeTypeName("WS_SHUTDOWN_SESSION_CHANNEL_CALLBACK")]
#if !NETSTANDARD2_0
        public delegate* unmanaged<void*, WS_ASYNC_CONTEXT*, IntPtr, int> shutdownSessionChannelCallback;
#else
        public void* _shutdownSessionChannelCallback;

        public delegate* unmanaged[Stdcall]<void*, WS_ASYNC_CONTEXT*, IntPtr, int> shutdownSessionChannelCallback
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (delegate* unmanaged[Stdcall]<void*, WS_ASYNC_CONTEXT*, IntPtr, int>)_shutdownSessionChannelCallback;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _shutdownSessionChannelCallback = value;
            }
        }
#endif
    }
}
