// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("F286FA56-C1FD-4270-8E67-B3EB790A81E8")]
    public unsafe partial struct IWinInetHttpTimeouts
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IWinInetHttpTimeouts*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IWinInetHttpTimeouts*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IWinInetHttpTimeouts*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetRequestTimeouts([NativeTypeName("DWORD *")] uint* pdwConnectTimeout, [NativeTypeName("DWORD *")] uint* pdwSendTimeout, [NativeTypeName("DWORD *")] uint* pdwReceiveTimeout)
        {
            return lpVtbl->GetRequestTimeouts((IWinInetHttpTimeouts*)Unsafe.AsPointer(ref this), pdwConnectTimeout, pdwSendTimeout, pdwReceiveTimeout);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IWinInetHttpTimeouts*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IWinInetHttpTimeouts*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IWinInetHttpTimeouts*, uint> Release;

            [NativeTypeName("HRESULT (DWORD *, DWORD *, DWORD *) __attribute__((stdcall))")]
            public delegate* stdcall<IWinInetHttpTimeouts*, uint*, uint*, uint*, int> GetRequestTimeouts;
        }
    }
}
