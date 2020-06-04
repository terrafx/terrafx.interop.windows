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
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IClassFactory2*, Guid*, void**, int>)(lpVtbl[0]))((IClassFactory2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IClassFactory2*, uint>)(lpVtbl[1]))((IClassFactory2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IClassFactory2*, uint>)(lpVtbl[2]))((IClassFactory2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateInstance([NativeTypeName("IUnknown *")] IUnknown* pUnkOuter, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IClassFactory2*, IUnknown*, Guid*, void**, int>)(lpVtbl[3]))((IClassFactory2*)Unsafe.AsPointer(ref this), pUnkOuter, riid, ppvObject);
        }

        [return: NativeTypeName("HRESULT")]
        public int LockServer([NativeTypeName("BOOL")] int fLock)
        {
            return ((delegate* stdcall<IClassFactory2*, int, int>)(lpVtbl[4]))((IClassFactory2*)Unsafe.AsPointer(ref this), fLock);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetLicInfo([NativeTypeName("LICINFO *")] LICINFO* pLicInfo)
        {
            return ((delegate* stdcall<IClassFactory2*, LICINFO*, int>)(lpVtbl[5]))((IClassFactory2*)Unsafe.AsPointer(ref this), pLicInfo);
        }

        [return: NativeTypeName("HRESULT")]
        public int RequestLicKey([NativeTypeName("DWORD")] uint dwReserved, [NativeTypeName("BSTR *")] ushort** pBstrKey)
        {
            return ((delegate* stdcall<IClassFactory2*, uint, ushort**, int>)(lpVtbl[6]))((IClassFactory2*)Unsafe.AsPointer(ref this), dwReserved, pBstrKey);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateInstanceLic([NativeTypeName("IUnknown *")] IUnknown* pUnkOuter, [NativeTypeName("IUnknown *")] IUnknown* pUnkReserved, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("BSTR")] ushort* bstrKey, [NativeTypeName("PVOID *")] void** ppvObj)
        {
            return ((delegate* stdcall<IClassFactory2*, IUnknown*, IUnknown*, Guid*, ushort*, void**, int>)(lpVtbl[7]))((IClassFactory2*)Unsafe.AsPointer(ref this), pUnkOuter, pUnkReserved, riid, bstrKey, ppvObj);
        }
    }
}
