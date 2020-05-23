// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OCIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("B196B28F-BAB4-101A-B69C-00AA00341D07")]
    public unsafe partial struct IClassFactory2
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IClassFactory2* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IClassFactory2* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IClassFactory2* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateInstance(IClassFactory2* pThis, [NativeTypeName("IUnknown *")] IUnknown* pUnkOuter, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _LockServer(IClassFactory2* pThis, [NativeTypeName("BOOL")] int fLock);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetLicInfo(IClassFactory2* pThis, [NativeTypeName("LICINFO *")] LICINFO* pLicInfo);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _RequestLicKey(IClassFactory2* pThis, [NativeTypeName("DWORD")] uint dwReserved, [NativeTypeName("BSTR *")] ushort** pBstrKey);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateInstanceLic(IClassFactory2* pThis, [NativeTypeName("IUnknown *")] IUnknown* pUnkOuter, [NativeTypeName("IUnknown *")] IUnknown* pUnkReserved, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("BSTR")] ushort* bstrKey, [NativeTypeName("PVOID *")] void** ppvObj);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IClassFactory2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IClassFactory2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IClassFactory2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateInstance([NativeTypeName("IUnknown *")] IUnknown* pUnkOuter, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateInstance>(lpVtbl->CreateInstance)((IClassFactory2*)Unsafe.AsPointer(ref this), pUnkOuter, riid, ppvObject);
        }

        [return: NativeTypeName("HRESULT")]
        public int LockServer([NativeTypeName("BOOL")] int fLock)
        {
            return Marshal.GetDelegateForFunctionPointer<_LockServer>(lpVtbl->LockServer)((IClassFactory2*)Unsafe.AsPointer(ref this), fLock);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetLicInfo([NativeTypeName("LICINFO *")] LICINFO* pLicInfo)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetLicInfo>(lpVtbl->GetLicInfo)((IClassFactory2*)Unsafe.AsPointer(ref this), pLicInfo);
        }

        [return: NativeTypeName("HRESULT")]
        public int RequestLicKey([NativeTypeName("DWORD")] uint dwReserved, [NativeTypeName("BSTR *")] ushort** pBstrKey)
        {
            return Marshal.GetDelegateForFunctionPointer<_RequestLicKey>(lpVtbl->RequestLicKey)((IClassFactory2*)Unsafe.AsPointer(ref this), dwReserved, pBstrKey);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateInstanceLic([NativeTypeName("IUnknown *")] IUnknown* pUnkOuter, [NativeTypeName("IUnknown *")] IUnknown* pUnkReserved, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("BSTR")] ushort* bstrKey, [NativeTypeName("PVOID *")] void** ppvObj)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateInstanceLic>(lpVtbl->CreateInstanceLic)((IClassFactory2*)Unsafe.AsPointer(ref this), pUnkOuter, pUnkReserved, riid, bstrKey, ppvObj);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (IUnknown *, const IID &, void **) __attribute__((stdcall))")]
            public IntPtr CreateInstance;

            [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
            public IntPtr LockServer;

            [NativeTypeName("HRESULT (LICINFO *) __attribute__((stdcall))")]
            public IntPtr GetLicInfo;

            [NativeTypeName("HRESULT (DWORD, BSTR *) __attribute__((stdcall))")]
            public IntPtr RequestLicKey;

            [NativeTypeName("HRESULT (IUnknown *, IUnknown *, const IID &, BSTR, PVOID *) __attribute__((stdcall))")]
            public IntPtr CreateInstanceLic;
        }
    }
}
