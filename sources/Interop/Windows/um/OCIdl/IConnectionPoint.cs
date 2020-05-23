// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OCIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("B196B286-BAB4-101A-B69C-00AA00341D07")]
    public unsafe partial struct IConnectionPoint
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IConnectionPoint* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IConnectionPoint* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IConnectionPoint* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetConnectionInterface(IConnectionPoint* pThis, [NativeTypeName("IID *")] Guid* pIID);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetConnectionPointContainer(IConnectionPoint* pThis, [NativeTypeName("IConnectionPointContainer **")] IConnectionPointContainer** ppCPC);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Advise(IConnectionPoint* pThis, [NativeTypeName("IUnknown *")] IUnknown* pUnkSink, [NativeTypeName("DWORD *")] uint* pdwCookie);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Unadvise(IConnectionPoint* pThis, [NativeTypeName("DWORD")] uint dwCookie);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _EnumConnections(IConnectionPoint* pThis, [NativeTypeName("IEnumConnections **")] IEnumConnections** ppEnum);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IConnectionPoint*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IConnectionPoint*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IConnectionPoint*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetConnectionInterface([NativeTypeName("IID *")] Guid* pIID)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetConnectionInterface>(lpVtbl->GetConnectionInterface)((IConnectionPoint*)Unsafe.AsPointer(ref this), pIID);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetConnectionPointContainer([NativeTypeName("IConnectionPointContainer **")] IConnectionPointContainer** ppCPC)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetConnectionPointContainer>(lpVtbl->GetConnectionPointContainer)((IConnectionPoint*)Unsafe.AsPointer(ref this), ppCPC);
        }

        [return: NativeTypeName("HRESULT")]
        public int Advise([NativeTypeName("IUnknown *")] IUnknown* pUnkSink, [NativeTypeName("DWORD *")] uint* pdwCookie)
        {
            return Marshal.GetDelegateForFunctionPointer<_Advise>(lpVtbl->Advise)((IConnectionPoint*)Unsafe.AsPointer(ref this), pUnkSink, pdwCookie);
        }

        [return: NativeTypeName("HRESULT")]
        public int Unadvise([NativeTypeName("DWORD")] uint dwCookie)
        {
            return Marshal.GetDelegateForFunctionPointer<_Unadvise>(lpVtbl->Unadvise)((IConnectionPoint*)Unsafe.AsPointer(ref this), dwCookie);
        }

        [return: NativeTypeName("HRESULT")]
        public int EnumConnections([NativeTypeName("IEnumConnections **")] IEnumConnections** ppEnum)
        {
            return Marshal.GetDelegateForFunctionPointer<_EnumConnections>(lpVtbl->EnumConnections)((IConnectionPoint*)Unsafe.AsPointer(ref this), ppEnum);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (IID *) __attribute__((stdcall))")]
            public IntPtr GetConnectionInterface;

            [NativeTypeName("HRESULT (IConnectionPointContainer **) __attribute__((stdcall))")]
            public IntPtr GetConnectionPointContainer;

            [NativeTypeName("HRESULT (IUnknown *, DWORD *) __attribute__((stdcall))")]
            public IntPtr Advise;

            [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
            public IntPtr Unadvise;

            [NativeTypeName("HRESULT (IEnumConnections **) __attribute__((stdcall))")]
            public IntPtr EnumConnections;
        }
    }
}
