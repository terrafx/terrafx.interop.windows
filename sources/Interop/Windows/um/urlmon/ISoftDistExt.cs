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

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((ISoftDistExt*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((ISoftDistExt*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((ISoftDistExt*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int ProcessSoftDist([NativeTypeName("LPCWSTR")] ushort* szCDFURL, [NativeTypeName("IXMLElement *")] IXMLElement* pSoftDistElement, [NativeTypeName("LPSOFTDISTINFO")] SOFTDISTINFO* lpsdi)
        {
            return lpVtbl->ProcessSoftDist((ISoftDistExt*)Unsafe.AsPointer(ref this), szCDFURL, pSoftDistElement, lpsdi);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFirstCodeBase([NativeTypeName("LPWSTR *")] ushort** szCodeBase, [NativeTypeName("LPDWORD")] uint* dwMaxSize)
        {
            return lpVtbl->GetFirstCodeBase((ISoftDistExt*)Unsafe.AsPointer(ref this), szCodeBase, dwMaxSize);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetNextCodeBase([NativeTypeName("LPWSTR *")] ushort** szCodeBase, [NativeTypeName("LPDWORD")] uint* dwMaxSize)
        {
            return lpVtbl->GetNextCodeBase((ISoftDistExt*)Unsafe.AsPointer(ref this), szCodeBase, dwMaxSize);
        }

        [return: NativeTypeName("HRESULT")]
        public int AsyncInstallDistributionUnit([NativeTypeName("IBindCtx *")] IBindCtx* pbc, [NativeTypeName("LPVOID")] void* pvReserved, [NativeTypeName("DWORD")] uint flags, [NativeTypeName("LPCODEBASEHOLD")] CODEBASEHOLD* lpcbh)
        {
            return lpVtbl->AsyncInstallDistributionUnit((ISoftDistExt*)Unsafe.AsPointer(ref this), pbc, pvReserved, flags, lpcbh);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<ISoftDistExt*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ISoftDistExt*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ISoftDistExt*, uint> Release;

            [NativeTypeName("HRESULT (LPCWSTR, IXMLElement *, LPSOFTDISTINFO) __attribute__((stdcall))")]
            public delegate* stdcall<ISoftDistExt*, ushort*, IXMLElement*, SOFTDISTINFO*, int> ProcessSoftDist;

            [NativeTypeName("HRESULT (LPWSTR *, LPDWORD) __attribute__((stdcall))")]
            public delegate* stdcall<ISoftDistExt*, ushort**, uint*, int> GetFirstCodeBase;

            [NativeTypeName("HRESULT (LPWSTR *, LPDWORD) __attribute__((stdcall))")]
            public delegate* stdcall<ISoftDistExt*, ushort**, uint*, int> GetNextCodeBase;

            [NativeTypeName("HRESULT (IBindCtx *, LPVOID, DWORD, LPCODEBASEHOLD) __attribute__((stdcall))")]
            public delegate* stdcall<ISoftDistExt*, IBindCtx*, void*, uint, CODEBASEHOLD*, int> AsyncInstallDistributionUnit;
        }
    }
}
