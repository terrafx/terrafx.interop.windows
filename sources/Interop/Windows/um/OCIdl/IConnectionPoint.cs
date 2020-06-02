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

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IConnectionPoint*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IConnectionPoint*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IConnectionPoint*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetConnectionInterface([NativeTypeName("IID *")] Guid* pIID)
        {
            return lpVtbl->GetConnectionInterface((IConnectionPoint*)Unsafe.AsPointer(ref this), pIID);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetConnectionPointContainer([NativeTypeName("IConnectionPointContainer **")] IConnectionPointContainer** ppCPC)
        {
            return lpVtbl->GetConnectionPointContainer((IConnectionPoint*)Unsafe.AsPointer(ref this), ppCPC);
        }

        [return: NativeTypeName("HRESULT")]
        public int Advise([NativeTypeName("IUnknown *")] IUnknown* pUnkSink, [NativeTypeName("DWORD *")] uint* pdwCookie)
        {
            return lpVtbl->Advise((IConnectionPoint*)Unsafe.AsPointer(ref this), pUnkSink, pdwCookie);
        }

        [return: NativeTypeName("HRESULT")]
        public int Unadvise([NativeTypeName("DWORD")] uint dwCookie)
        {
            return lpVtbl->Unadvise((IConnectionPoint*)Unsafe.AsPointer(ref this), dwCookie);
        }

        [return: NativeTypeName("HRESULT")]
        public int EnumConnections([NativeTypeName("IEnumConnections **")] IEnumConnections** ppEnum)
        {
            return lpVtbl->EnumConnections((IConnectionPoint*)Unsafe.AsPointer(ref this), ppEnum);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IConnectionPoint*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IConnectionPoint*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IConnectionPoint*, uint> Release;

            [NativeTypeName("HRESULT (IID *) __attribute__((stdcall))")]
            public delegate* stdcall<IConnectionPoint*, Guid*, int> GetConnectionInterface;

            [NativeTypeName("HRESULT (IConnectionPointContainer **) __attribute__((stdcall))")]
            public delegate* stdcall<IConnectionPoint*, IConnectionPointContainer**, int> GetConnectionPointContainer;

            [NativeTypeName("HRESULT (IUnknown *, DWORD *) __attribute__((stdcall))")]
            public delegate* stdcall<IConnectionPoint*, IUnknown*, uint*, int> Advise;

            [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
            public delegate* stdcall<IConnectionPoint*, uint, int> Unadvise;

            [NativeTypeName("HRESULT (IEnumConnections **) __attribute__((stdcall))")]
            public delegate* stdcall<IConnectionPoint*, IEnumConnections**, int> EnumConnections;
        }
    }
}
