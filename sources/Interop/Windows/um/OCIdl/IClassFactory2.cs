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

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IClassFactory2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IClassFactory2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IClassFactory2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateInstance([NativeTypeName("IUnknown *")] IUnknown* pUnkOuter, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->CreateInstance((IClassFactory2*)Unsafe.AsPointer(ref this), pUnkOuter, riid, ppvObject);
        }

        [return: NativeTypeName("HRESULT")]
        public int LockServer([NativeTypeName("BOOL")] int fLock)
        {
            return lpVtbl->LockServer((IClassFactory2*)Unsafe.AsPointer(ref this), fLock);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetLicInfo([NativeTypeName("LICINFO *")] LICINFO* pLicInfo)
        {
            return lpVtbl->GetLicInfo((IClassFactory2*)Unsafe.AsPointer(ref this), pLicInfo);
        }

        [return: NativeTypeName("HRESULT")]
        public int RequestLicKey([NativeTypeName("DWORD")] uint dwReserved, [NativeTypeName("BSTR *")] ushort** pBstrKey)
        {
            return lpVtbl->RequestLicKey((IClassFactory2*)Unsafe.AsPointer(ref this), dwReserved, pBstrKey);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateInstanceLic([NativeTypeName("IUnknown *")] IUnknown* pUnkOuter, [NativeTypeName("IUnknown *")] IUnknown* pUnkReserved, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("BSTR")] ushort* bstrKey, [NativeTypeName("PVOID *")] void** ppvObj)
        {
            return lpVtbl->CreateInstanceLic((IClassFactory2*)Unsafe.AsPointer(ref this), pUnkOuter, pUnkReserved, riid, bstrKey, ppvObj);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IClassFactory2*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IClassFactory2*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IClassFactory2*, uint> Release;

            [NativeTypeName("HRESULT (IUnknown *, const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IClassFactory2*, IUnknown*, Guid*, void**, int> CreateInstance;

            [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
            public delegate* stdcall<IClassFactory2*, int, int> LockServer;

            [NativeTypeName("HRESULT (LICINFO *) __attribute__((stdcall))")]
            public delegate* stdcall<IClassFactory2*, LICINFO*, int> GetLicInfo;

            [NativeTypeName("HRESULT (DWORD, BSTR *) __attribute__((stdcall))")]
            public delegate* stdcall<IClassFactory2*, uint, ushort**, int> RequestLicKey;

            [NativeTypeName("HRESULT (IUnknown *, IUnknown *, const IID &, BSTR, PVOID *) __attribute__((stdcall))")]
            public delegate* stdcall<IClassFactory2*, IUnknown*, IUnknown*, Guid*, ushort*, void**, int> CreateInstanceLic;
        }
    }
}
