// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;

namespace TerraFX.Interop
{
    public unsafe partial struct WS_SERVICE_ENDPOINT
    {
        public WS_ENDPOINT_ADDRESS address;

        public WS_CHANNEL_BINDING channelBinding;

        public WS_CHANNEL_TYPE channelType;

        [NativeTypeName("const WS_SECURITY_DESCRIPTION *")]
        public WS_SECURITY_DESCRIPTION* securityDescription;

        [NativeTypeName("const WS_SERVICE_CONTRACT *")]
        public WS_SERVICE_CONTRACT* contract;

        [NativeTypeName("WS_SERVICE_SECURITY_CALLBACK")]
#if !NETSTANDARD2_0
        public delegate* unmanaged<IntPtr, int*, IntPtr, int> authorizationCallback;
#else
        public void* _authorizationCallback;

        public delegate* unmanaged[Stdcall]<IntPtr, int*, IntPtr, int> authorizationCallback
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (delegate* unmanaged[Stdcall]<IntPtr, int*, IntPtr, int>)_authorizationCallback;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _authorizationCallback = value;
            }
        }
#endif

        [NativeTypeName("const WS_SERVICE_ENDPOINT_PROPERTY *")]
        public WS_SERVICE_ENDPOINT_PROPERTY* properties;

        [NativeTypeName("ULONG")]
        public uint propertyCount;

        public WS_CHANNEL_PROPERTIES channelProperties;
    }
}
