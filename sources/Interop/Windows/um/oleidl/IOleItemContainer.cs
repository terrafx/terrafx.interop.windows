// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/oleidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("0000011C-0000-0000-C000-000000000046")]
    public unsafe partial struct IOleItemContainer
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IOleItemContainer*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IOleItemContainer*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IOleItemContainer*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int ParseDisplayName([NativeTypeName("IBindCtx *")] IBindCtx* pbc, [NativeTypeName("LPOLESTR")] ushort* pszDisplayName, [NativeTypeName("ULONG *")] uint* pchEaten, [NativeTypeName("IMoniker **")] IMoniker** ppmkOut)
        {
            return lpVtbl->ParseDisplayName((IOleItemContainer*)Unsafe.AsPointer(ref this), pbc, pszDisplayName, pchEaten, ppmkOut);
        }

        [return: NativeTypeName("HRESULT")]
        public int EnumObjects([NativeTypeName("DWORD")] uint grfFlags, [NativeTypeName("IEnumUnknown **")] IEnumUnknown** ppenum)
        {
            return lpVtbl->EnumObjects((IOleItemContainer*)Unsafe.AsPointer(ref this), grfFlags, ppenum);
        }

        [return: NativeTypeName("HRESULT")]
        public int LockContainer([NativeTypeName("BOOL")] int fLock)
        {
            return lpVtbl->LockContainer((IOleItemContainer*)Unsafe.AsPointer(ref this), fLock);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetObjectA([NativeTypeName("LPOLESTR")] ushort* pszItem, [NativeTypeName("DWORD")] uint dwSpeedNeeded, [NativeTypeName("IBindCtx *")] IBindCtx* pbc, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->GetObjectA((IOleItemContainer*)Unsafe.AsPointer(ref this), pszItem, dwSpeedNeeded, pbc, riid, ppvObject);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetObjectStorage([NativeTypeName("LPOLESTR")] ushort* pszItem, [NativeTypeName("IBindCtx *")] IBindCtx* pbc, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvStorage)
        {
            return lpVtbl->GetObjectStorage((IOleItemContainer*)Unsafe.AsPointer(ref this), pszItem, pbc, riid, ppvStorage);
        }

        [return: NativeTypeName("HRESULT")]
        public int IsRunning([NativeTypeName("LPOLESTR")] ushort* pszItem)
        {
            return lpVtbl->IsRunning((IOleItemContainer*)Unsafe.AsPointer(ref this), pszItem);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IOleItemContainer*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IOleItemContainer*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IOleItemContainer*, uint> Release;

            [NativeTypeName("HRESULT (IBindCtx *, LPOLESTR, ULONG *, IMoniker **) __attribute__((stdcall))")]
            public delegate* stdcall<IOleItemContainer*, IBindCtx*, ushort*, uint*, IMoniker**, int> ParseDisplayName;

            [NativeTypeName("HRESULT (DWORD, IEnumUnknown **) __attribute__((stdcall))")]
            public delegate* stdcall<IOleItemContainer*, uint, IEnumUnknown**, int> EnumObjects;

            [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
            public delegate* stdcall<IOleItemContainer*, int, int> LockContainer;

            [NativeTypeName("HRESULT (LPOLESTR, DWORD, IBindCtx *, const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IOleItemContainer*, ushort*, uint, IBindCtx*, Guid*, void**, int> GetObjectA;

            [NativeTypeName("HRESULT (LPOLESTR, IBindCtx *, const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IOleItemContainer*, ushort*, IBindCtx*, Guid*, void**, int> GetObjectStorage;

            [NativeTypeName("HRESULT (LPOLESTR) __attribute__((stdcall))")]
            public delegate* stdcall<IOleItemContainer*, ushort*, int> IsRunning;
        }
    }
}
