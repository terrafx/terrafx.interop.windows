// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdlbase.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("000001CE-0000-0000-C000-000000000046")]
    public unsafe partial struct IComThreadingInfo
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IComThreadingInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IComThreadingInfo*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IComThreadingInfo*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetCurrentApartmentType([NativeTypeName("APTTYPE *")] APTTYPE* pAptType)
        {
            return lpVtbl->GetCurrentApartmentType((IComThreadingInfo*)Unsafe.AsPointer(ref this), pAptType);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetCurrentThreadType([NativeTypeName("THDTYPE *")] THDTYPE* pThreadType)
        {
            return lpVtbl->GetCurrentThreadType((IComThreadingInfo*)Unsafe.AsPointer(ref this), pThreadType);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetCurrentLogicalThreadId([NativeTypeName("GUID *")] Guid* pguidLogicalThreadId)
        {
            return lpVtbl->GetCurrentLogicalThreadId((IComThreadingInfo*)Unsafe.AsPointer(ref this), pguidLogicalThreadId);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetCurrentLogicalThreadId([NativeTypeName("const GUID &")] Guid* rguid)
        {
            return lpVtbl->SetCurrentLogicalThreadId((IComThreadingInfo*)Unsafe.AsPointer(ref this), rguid);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IComThreadingInfo*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IComThreadingInfo*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IComThreadingInfo*, uint> Release;

            [NativeTypeName("HRESULT (APTTYPE *) __attribute__((stdcall))")]
            public delegate* stdcall<IComThreadingInfo*, APTTYPE*, int> GetCurrentApartmentType;

            [NativeTypeName("HRESULT (THDTYPE *) __attribute__((stdcall))")]
            public delegate* stdcall<IComThreadingInfo*, THDTYPE*, int> GetCurrentThreadType;

            [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
            public delegate* stdcall<IComThreadingInfo*, Guid*, int> GetCurrentLogicalThreadId;

            [NativeTypeName("HRESULT (const GUID &) __attribute__((stdcall))")]
            public delegate* stdcall<IComThreadingInfo*, Guid*, int> SetCurrentLogicalThreadId;
        }
    }
}
