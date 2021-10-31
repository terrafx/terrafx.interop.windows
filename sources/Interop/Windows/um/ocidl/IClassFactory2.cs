// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ocidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("B196B28F-BAB4-101A-B69C-00AA00341D07")]
    [NativeTypeName("struct IClassFactory2 : IClassFactory")]
    [NativeInheritance("IClassFactory")]
    public unsafe partial struct IClassFactory2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IClassFactory2*, Guid*, void**, int>)(lpVtbl[0]))((IClassFactory2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IClassFactory2*, uint>)(lpVtbl[1]))((IClassFactory2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IClassFactory2*, uint>)(lpVtbl[2]))((IClassFactory2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int CreateInstance(IUnknown* pUnkOuter, [NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IClassFactory2*, IUnknown*, Guid*, void**, int>)(lpVtbl[3]))((IClassFactory2*)Unsafe.AsPointer(ref this), pUnkOuter, riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int LockServer(BOOL fLock)
        {
            return ((delegate* unmanaged<IClassFactory2*, BOOL, int>)(lpVtbl[4]))((IClassFactory2*)Unsafe.AsPointer(ref this), fLock);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetLicInfo(LICINFO* pLicInfo)
        {
            return ((delegate* unmanaged<IClassFactory2*, LICINFO*, int>)(lpVtbl[5]))((IClassFactory2*)Unsafe.AsPointer(ref this), pLicInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int RequestLicKey([NativeTypeName("DWORD")] uint dwReserved, [NativeTypeName("BSTR *")] ushort** pBstrKey)
        {
            return ((delegate* unmanaged<IClassFactory2*, uint, ushort**, int>)(lpVtbl[6]))((IClassFactory2*)Unsafe.AsPointer(ref this), dwReserved, pBstrKey);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int CreateInstanceLic(IUnknown* pUnkOuter, IUnknown* pUnkReserved, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("BSTR")] ushort* bstrKey, [NativeTypeName("PVOID *")] void** ppvObj)
        {
            return ((delegate* unmanaged<IClassFactory2*, IUnknown*, IUnknown*, Guid*, ushort*, void**, int>)(lpVtbl[7]))((IClassFactory2*)Unsafe.AsPointer(ref this), pUnkOuter, pUnkReserved, riid, bstrKey, ppvObj);
        }
    }
}
