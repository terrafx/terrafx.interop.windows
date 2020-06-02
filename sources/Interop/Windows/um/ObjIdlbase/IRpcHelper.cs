// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdlbase.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00000149-0000-0000-C000-000000000046")]
    public unsafe partial struct IRpcHelper
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IRpcHelper*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IRpcHelper*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IRpcHelper*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDCOMProtocolVersion([NativeTypeName("DWORD *")] uint* pComVersion)
        {
            return lpVtbl->GetDCOMProtocolVersion((IRpcHelper*)Unsafe.AsPointer(ref this), pComVersion);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetIIDFromOBJREF([NativeTypeName("void *")] void* pObjRef, [NativeTypeName("IID **")] Guid** piid)
        {
            return lpVtbl->GetIIDFromOBJREF((IRpcHelper*)Unsafe.AsPointer(ref this), pObjRef, piid);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IRpcHelper*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IRpcHelper*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IRpcHelper*, uint> Release;

            [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
            public delegate* stdcall<IRpcHelper*, uint*, int> GetDCOMProtocolVersion;

            [NativeTypeName("HRESULT (void *, IID **) __attribute__((stdcall))")]
            public delegate* stdcall<IRpcHelper*, void*, Guid**, int> GetIIDFromOBJREF;
        }
    }
}
