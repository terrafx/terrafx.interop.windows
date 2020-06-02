// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdlbase.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00000146-0000-0000-C000-000000000046")]
    public unsafe partial struct IGlobalInterfaceTable
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IGlobalInterfaceTable*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IGlobalInterfaceTable*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IGlobalInterfaceTable*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int RegisterInterfaceInGlobal([NativeTypeName("IUnknown *")] IUnknown* pUnk, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("DWORD *")] uint* pdwCookie)
        {
            return lpVtbl->RegisterInterfaceInGlobal((IGlobalInterfaceTable*)Unsafe.AsPointer(ref this), pUnk, riid, pdwCookie);
        }

        [return: NativeTypeName("HRESULT")]
        public int RevokeInterfaceFromGlobal([NativeTypeName("DWORD")] uint dwCookie)
        {
            return lpVtbl->RevokeInterfaceFromGlobal((IGlobalInterfaceTable*)Unsafe.AsPointer(ref this), dwCookie);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetInterfaceFromGlobal([NativeTypeName("DWORD")] uint dwCookie, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppv)
        {
            return lpVtbl->GetInterfaceFromGlobal((IGlobalInterfaceTable*)Unsafe.AsPointer(ref this), dwCookie, riid, ppv);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IGlobalInterfaceTable*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IGlobalInterfaceTable*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IGlobalInterfaceTable*, uint> Release;

            [NativeTypeName("HRESULT (IUnknown *, const IID &, DWORD *) __attribute__((stdcall))")]
            public delegate* stdcall<IGlobalInterfaceTable*, IUnknown*, Guid*, uint*, int> RegisterInterfaceInGlobal;

            [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
            public delegate* stdcall<IGlobalInterfaceTable*, uint, int> RevokeInterfaceFromGlobal;

            [NativeTypeName("HRESULT (DWORD, const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IGlobalInterfaceTable*, uint, Guid*, void**, int> GetInterfaceFromGlobal;
        }
    }
}
