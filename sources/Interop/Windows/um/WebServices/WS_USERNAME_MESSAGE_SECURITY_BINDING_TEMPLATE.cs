// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;

namespace TerraFX.Interop
{
    public unsafe partial struct WS_USERNAME_MESSAGE_SECURITY_BINDING_TEMPLATE
    {
        public WS_SECURITY_BINDING_PROPERTIES securityBindingProperties;

        [NativeTypeName("WS_USERNAME_CREDENTIAL *")]
        public WS_USERNAME_CREDENTIAL* clientCredential;

        [NativeTypeName("WS_VALIDATE_PASSWORD_CALLBACK")]
#if !NETSTANDARD2_0
        public delegate* unmanaged<void*, WS_STRING*, WS_STRING*, WS_ASYNC_CONTEXT*, IntPtr, int> passwordValidator;
#else
        public void* _passwordValidator;

        public delegate* unmanaged[Stdcall]<void*, WS_STRING*, WS_STRING*, WS_ASYNC_CONTEXT*, IntPtr, int> passwordValidator
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (delegate* unmanaged[Stdcall]<void*, WS_STRING*, WS_STRING*, WS_ASYNC_CONTEXT*, IntPtr, int>)_passwordValidator;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _passwordValidator = value;
            }
        }
#endif

        [NativeTypeName("void *")]
        public void* passwordValidatorCallbackState;
    }
}
