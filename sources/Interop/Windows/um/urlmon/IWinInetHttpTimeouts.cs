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

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IWinInetHttpTimeouts* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IWinInetHttpTimeouts* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IWinInetHttpTimeouts* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetRequestTimeouts(IWinInetHttpTimeouts* pThis, [NativeTypeName("DWORD *")] uint* pdwConnectTimeout, [NativeTypeName("DWORD *")] uint* pdwSendTimeout, [NativeTypeName("DWORD *")] uint* pdwReceiveTimeout);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IWinInetHttpTimeouts*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IWinInetHttpTimeouts*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IWinInetHttpTimeouts*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetRequestTimeouts([NativeTypeName("DWORD *")] uint* pdwConnectTimeout, [NativeTypeName("DWORD *")] uint* pdwSendTimeout, [NativeTypeName("DWORD *")] uint* pdwReceiveTimeout)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetRequestTimeouts>(lpVtbl->GetRequestTimeouts)((IWinInetHttpTimeouts*)Unsafe.AsPointer(ref this), pdwConnectTimeout, pdwSendTimeout, pdwReceiveTimeout);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (DWORD *, DWORD *, DWORD *) __attribute__((stdcall))")]
            public IntPtr GetRequestTimeouts;
        }
    }
}
