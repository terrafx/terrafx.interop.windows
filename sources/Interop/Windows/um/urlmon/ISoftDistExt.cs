// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("B15B8DC1-C7E1-11D0-8680-00AA00BDCB71")]
    public unsafe partial struct ISoftDistExt
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(ISoftDistExt* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(ISoftDistExt* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(ISoftDistExt* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _ProcessSoftDist(ISoftDistExt* pThis, [NativeTypeName("LPCWSTR")] ushort* szCDFURL, [NativeTypeName("IXMLElement *")] IXMLElement* pSoftDistElement, [NativeTypeName("LPSOFTDISTINFO")] SOFTDISTINFO* lpsdi);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetFirstCodeBase(ISoftDistExt* pThis, [NativeTypeName("LPWSTR *")] ushort** szCodeBase, [NativeTypeName("LPDWORD")] uint* dwMaxSize);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetNextCodeBase(ISoftDistExt* pThis, [NativeTypeName("LPWSTR *")] ushort** szCodeBase, [NativeTypeName("LPDWORD")] uint* dwMaxSize);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _AsyncInstallDistributionUnit(ISoftDistExt* pThis, [NativeTypeName("IBindCtx *")] IBindCtx* pbc, [NativeTypeName("LPVOID")] void* pvReserved, [NativeTypeName("DWORD")] uint flags, [NativeTypeName("LPCODEBASEHOLD")] CODEBASEHOLD* lpcbh);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((ISoftDistExt*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((ISoftDistExt*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((ISoftDistExt*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int ProcessSoftDist([NativeTypeName("LPCWSTR")] ushort* szCDFURL, [NativeTypeName("IXMLElement *")] IXMLElement* pSoftDistElement, [NativeTypeName("LPSOFTDISTINFO")] SOFTDISTINFO* lpsdi)
        {
            return Marshal.GetDelegateForFunctionPointer<_ProcessSoftDist>(lpVtbl->ProcessSoftDist)((ISoftDistExt*)Unsafe.AsPointer(ref this), szCDFURL, pSoftDistElement, lpsdi);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFirstCodeBase([NativeTypeName("LPWSTR *")] ushort** szCodeBase, [NativeTypeName("LPDWORD")] uint* dwMaxSize)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetFirstCodeBase>(lpVtbl->GetFirstCodeBase)((ISoftDistExt*)Unsafe.AsPointer(ref this), szCodeBase, dwMaxSize);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetNextCodeBase([NativeTypeName("LPWSTR *")] ushort** szCodeBase, [NativeTypeName("LPDWORD")] uint* dwMaxSize)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetNextCodeBase>(lpVtbl->GetNextCodeBase)((ISoftDistExt*)Unsafe.AsPointer(ref this), szCodeBase, dwMaxSize);
        }

        [return: NativeTypeName("HRESULT")]
        public int AsyncInstallDistributionUnit([NativeTypeName("IBindCtx *")] IBindCtx* pbc, [NativeTypeName("LPVOID")] void* pvReserved, [NativeTypeName("DWORD")] uint flags, [NativeTypeName("LPCODEBASEHOLD")] CODEBASEHOLD* lpcbh)
        {
            return Marshal.GetDelegateForFunctionPointer<_AsyncInstallDistributionUnit>(lpVtbl->AsyncInstallDistributionUnit)((ISoftDistExt*)Unsafe.AsPointer(ref this), pbc, pvReserved, flags, lpcbh);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (LPCWSTR, IXMLElement *, LPSOFTDISTINFO) __attribute__((stdcall))")]
            public IntPtr ProcessSoftDist;

            [NativeTypeName("HRESULT (LPWSTR *, LPDWORD) __attribute__((stdcall))")]
            public IntPtr GetFirstCodeBase;

            [NativeTypeName("HRESULT (LPWSTR *, LPDWORD) __attribute__((stdcall))")]
            public IntPtr GetNextCodeBase;

            [NativeTypeName("HRESULT (IBindCtx *, LPVOID, DWORD, LPCODEBASEHOLD) __attribute__((stdcall))")]
            public IntPtr AsyncInstallDistributionUnit;
        }
    }
}
