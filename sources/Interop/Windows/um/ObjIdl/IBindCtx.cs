// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("0000000e-0000-0000-C000-000000000046")]
    public unsafe partial struct IBindCtx
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IBindCtx*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IBindCtx*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IBindCtx*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int RegisterObjectBound([NativeTypeName("IUnknown *")] IUnknown* punk)
        {
            return lpVtbl->RegisterObjectBound((IBindCtx*)Unsafe.AsPointer(ref this), punk);
        }

        [return: NativeTypeName("HRESULT")]
        public int RevokeObjectBound([NativeTypeName("IUnknown *")] IUnknown* punk)
        {
            return lpVtbl->RevokeObjectBound((IBindCtx*)Unsafe.AsPointer(ref this), punk);
        }

        [return: NativeTypeName("HRESULT")]
        public int ReleaseBoundObjects()
        {
            return lpVtbl->ReleaseBoundObjects((IBindCtx*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetBindOptions([NativeTypeName("BIND_OPTS *")] BIND_OPTS* pbindopts)
        {
            return lpVtbl->SetBindOptions((IBindCtx*)Unsafe.AsPointer(ref this), pbindopts);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetBindOptions([NativeTypeName("BIND_OPTS *")] BIND_OPTS* pbindopts)
        {
            return lpVtbl->GetBindOptions((IBindCtx*)Unsafe.AsPointer(ref this), pbindopts);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetRunningObjectTable([NativeTypeName("IRunningObjectTable **")] IRunningObjectTable** pprot)
        {
            return lpVtbl->GetRunningObjectTable((IBindCtx*)Unsafe.AsPointer(ref this), pprot);
        }

        [return: NativeTypeName("HRESULT")]
        public int RegisterObjectParam([NativeTypeName("LPOLESTR")] ushort* pszKey, [NativeTypeName("IUnknown *")] IUnknown* punk)
        {
            return lpVtbl->RegisterObjectParam((IBindCtx*)Unsafe.AsPointer(ref this), pszKey, punk);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetObjectParam([NativeTypeName("LPOLESTR")] ushort* pszKey, [NativeTypeName("IUnknown **")] IUnknown** ppunk)
        {
            return lpVtbl->GetObjectParam((IBindCtx*)Unsafe.AsPointer(ref this), pszKey, ppunk);
        }

        [return: NativeTypeName("HRESULT")]
        public int EnumObjectParam([NativeTypeName("IEnumString **")] IEnumString** ppenum)
        {
            return lpVtbl->EnumObjectParam((IBindCtx*)Unsafe.AsPointer(ref this), ppenum);
        }

        [return: NativeTypeName("HRESULT")]
        public int RevokeObjectParam([NativeTypeName("LPOLESTR")] ushort* pszKey)
        {
            return lpVtbl->RevokeObjectParam((IBindCtx*)Unsafe.AsPointer(ref this), pszKey);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IBindCtx*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IBindCtx*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IBindCtx*, uint> Release;

            [NativeTypeName("HRESULT (IUnknown *) __attribute__((stdcall))")]
            public delegate* stdcall<IBindCtx*, IUnknown*, int> RegisterObjectBound;

            [NativeTypeName("HRESULT (IUnknown *) __attribute__((stdcall))")]
            public delegate* stdcall<IBindCtx*, IUnknown*, int> RevokeObjectBound;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* stdcall<IBindCtx*, int> ReleaseBoundObjects;

            [NativeTypeName("HRESULT (BIND_OPTS *) __attribute__((stdcall))")]
            public delegate* stdcall<IBindCtx*, BIND_OPTS*, int> SetBindOptions;

            [NativeTypeName("HRESULT (BIND_OPTS *) __attribute__((stdcall))")]
            public delegate* stdcall<IBindCtx*, BIND_OPTS*, int> GetBindOptions;

            [NativeTypeName("HRESULT (IRunningObjectTable **) __attribute__((stdcall))")]
            public delegate* stdcall<IBindCtx*, IRunningObjectTable**, int> GetRunningObjectTable;

            [NativeTypeName("HRESULT (LPOLESTR, IUnknown *) __attribute__((stdcall))")]
            public delegate* stdcall<IBindCtx*, ushort*, IUnknown*, int> RegisterObjectParam;

            [NativeTypeName("HRESULT (LPOLESTR, IUnknown **) __attribute__((stdcall))")]
            public delegate* stdcall<IBindCtx*, ushort*, IUnknown**, int> GetObjectParam;

            [NativeTypeName("HRESULT (IEnumString **) __attribute__((stdcall))")]
            public delegate* stdcall<IBindCtx*, IEnumString**, int> EnumObjectParam;

            [NativeTypeName("HRESULT (LPOLESTR) __attribute__((stdcall))")]
            public delegate* stdcall<IBindCtx*, ushort*, int> RevokeObjectParam;
        }
    }
}
