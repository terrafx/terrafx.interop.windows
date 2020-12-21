// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;

namespace TerraFX.Interop
{
    public unsafe partial struct WS_CUSTOM_CERT_CREDENTIAL
    {
        public WS_CERT_CREDENTIAL credential;

        [NativeTypeName("WS_GET_CERT_CALLBACK")]
#if !NETSTANDARD2_0
        public delegate* unmanaged<void*, WS_ENDPOINT_ADDRESS*, WS_STRING*, CERT_CONTEXT**, IntPtr, int> getCertCallback;
#else
        public void* _getCertCallback;

        public delegate* unmanaged[Stdcall]<void*, WS_ENDPOINT_ADDRESS*, WS_STRING*, CERT_CONTEXT**, IntPtr, int> getCertCallback
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (delegate* unmanaged[Stdcall]<void*, WS_ENDPOINT_ADDRESS*, WS_STRING*, CERT_CONTEXT**, IntPtr, int>)_getCertCallback;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _getCertCallback = value;
            }
        }
#endif

        [NativeTypeName("void *")]
        public void* getCertCallbackState;

        [NativeTypeName("WS_CERT_ISSUER_LIST_NOTIFICATION_CALLBACK")]
#if !NETSTANDARD2_0
        public delegate* unmanaged<void*, SecPkgContext_IssuerListInfoEx*, IntPtr, int> certIssuerListNotificationCallback;
#else
        public void* _certIssuerListNotificationCallback;

        public delegate* unmanaged[Stdcall]<void*, SecPkgContext_IssuerListInfoEx*, IntPtr, int> certIssuerListNotificationCallback
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (delegate* unmanaged[Stdcall]<void*, SecPkgContext_IssuerListInfoEx*, IntPtr, int>)_certIssuerListNotificationCallback;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _certIssuerListNotificationCallback = value;
            }
        }
#endif

        [NativeTypeName("void *")]
        public void* certIssuerListNotificationCallbackState;
    }
}
