// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;

namespace TerraFX.Interop
{
    public unsafe partial struct WS_XML_WRITER_BINARY_ENCODING
    {
        public WS_XML_WRITER_ENCODING encoding;

        [NativeTypeName("WS_XML_DICTIONARY *")]
        public WS_XML_DICTIONARY* staticDictionary;

        [NativeTypeName("WS_DYNAMIC_STRING_CALLBACK")]
#if !NETSTANDARD2_0
        public delegate* unmanaged<void*, WS_XML_STRING*, int*, uint*, IntPtr, int> dynamicStringCallback;
#else
        public void* _dynamicStringCallback;

        public delegate* unmanaged[Stdcall]<void*, WS_XML_STRING*, int*, uint*, IntPtr, int> dynamicStringCallback
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (delegate* unmanaged[Stdcall]<void*, WS_XML_STRING*, int*, uint*, IntPtr, int>)_dynamicStringCallback;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _dynamicStringCallback = value;
            }
        }
#endif

        [NativeTypeName("void *")]
        public void* dynamicStringCallbackState;
    }
}
