// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

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
        public delegate* unmanaged<IntPtr, BOOL*, IntPtr, int> authorizationCallback;

        [NativeTypeName("const WS_SERVICE_ENDPOINT_PROPERTY *")]
        public WS_SERVICE_ENDPOINT_PROPERTY* properties;

        [NativeTypeName("ULONG")]
        public uint propertyCount;

        public WS_CHANNEL_PROPERTIES channelProperties;
    }
}
