// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("0000000F-0000-0000-C000-000000000046")]
    public unsafe partial struct IMoniker
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IMoniker*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IMoniker*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IMoniker*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetClassID([NativeTypeName("CLSID *")] Guid* pClassID)
        {
            return lpVtbl->GetClassID((IMoniker*)Unsafe.AsPointer(ref this), pClassID);
        }

        [return: NativeTypeName("HRESULT")]
        public int IsDirty()
        {
            return lpVtbl->IsDirty((IMoniker*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Load([NativeTypeName("IStream *")] IStream* pStm)
        {
            return lpVtbl->Load((IMoniker*)Unsafe.AsPointer(ref this), pStm);
        }

        [return: NativeTypeName("HRESULT")]
        public int Save([NativeTypeName("IStream *")] IStream* pStm, [NativeTypeName("BOOL")] int fClearDirty)
        {
            return lpVtbl->Save((IMoniker*)Unsafe.AsPointer(ref this), pStm, fClearDirty);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSizeMax([NativeTypeName("ULARGE_INTEGER *")] ULARGE_INTEGER* pcbSize)
        {
            return lpVtbl->GetSizeMax((IMoniker*)Unsafe.AsPointer(ref this), pcbSize);
        }

        [return: NativeTypeName("HRESULT")]
        public int BindToObject([NativeTypeName("IBindCtx *")] IBindCtx* pbc, [NativeTypeName("IMoniker *")] IMoniker* pmkToLeft, [NativeTypeName("const IID &")] Guid* riidResult, [NativeTypeName("void **")] void** ppvResult)
        {
            return lpVtbl->BindToObject((IMoniker*)Unsafe.AsPointer(ref this), pbc, pmkToLeft, riidResult, ppvResult);
        }

        [return: NativeTypeName("HRESULT")]
        public int BindToStorage([NativeTypeName("IBindCtx *")] IBindCtx* pbc, [NativeTypeName("IMoniker *")] IMoniker* pmkToLeft, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObj)
        {
            return lpVtbl->BindToStorage((IMoniker*)Unsafe.AsPointer(ref this), pbc, pmkToLeft, riid, ppvObj);
        }

        [return: NativeTypeName("HRESULT")]
        public int Reduce([NativeTypeName("IBindCtx *")] IBindCtx* pbc, [NativeTypeName("DWORD")] uint dwReduceHowFar, [NativeTypeName("IMoniker **")] IMoniker** ppmkToLeft, [NativeTypeName("IMoniker **")] IMoniker** ppmkReduced)
        {
            return lpVtbl->Reduce((IMoniker*)Unsafe.AsPointer(ref this), pbc, dwReduceHowFar, ppmkToLeft, ppmkReduced);
        }

        [return: NativeTypeName("HRESULT")]
        public int ComposeWith([NativeTypeName("IMoniker *")] IMoniker* pmkRight, [NativeTypeName("BOOL")] int fOnlyIfNotGeneric, [NativeTypeName("IMoniker **")] IMoniker** ppmkComposite)
        {
            return lpVtbl->ComposeWith((IMoniker*)Unsafe.AsPointer(ref this), pmkRight, fOnlyIfNotGeneric, ppmkComposite);
        }

        [return: NativeTypeName("HRESULT")]
        public int Enum([NativeTypeName("BOOL")] int fForward, [NativeTypeName("IEnumMoniker **")] IEnumMoniker** ppenumMoniker)
        {
            return lpVtbl->Enum((IMoniker*)Unsafe.AsPointer(ref this), fForward, ppenumMoniker);
        }

        [return: NativeTypeName("HRESULT")]
        public int IsEqual([NativeTypeName("IMoniker *")] IMoniker* pmkOtherMoniker)
        {
            return lpVtbl->IsEqual((IMoniker*)Unsafe.AsPointer(ref this), pmkOtherMoniker);
        }

        [return: NativeTypeName("HRESULT")]
        public int Hash([NativeTypeName("DWORD *")] uint* pdwHash)
        {
            return lpVtbl->Hash((IMoniker*)Unsafe.AsPointer(ref this), pdwHash);
        }

        [return: NativeTypeName("HRESULT")]
        public int IsRunning([NativeTypeName("IBindCtx *")] IBindCtx* pbc, [NativeTypeName("IMoniker *")] IMoniker* pmkToLeft, [NativeTypeName("IMoniker *")] IMoniker* pmkNewlyRunning)
        {
            return lpVtbl->IsRunning((IMoniker*)Unsafe.AsPointer(ref this), pbc, pmkToLeft, pmkNewlyRunning);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTimeOfLastChange([NativeTypeName("IBindCtx *")] IBindCtx* pbc, [NativeTypeName("IMoniker *")] IMoniker* pmkToLeft, [NativeTypeName("FILETIME *")] FILETIME* pFileTime)
        {
            return lpVtbl->GetTimeOfLastChange((IMoniker*)Unsafe.AsPointer(ref this), pbc, pmkToLeft, pFileTime);
        }

        [return: NativeTypeName("HRESULT")]
        public int Inverse([NativeTypeName("IMoniker **")] IMoniker** ppmk)
        {
            return lpVtbl->Inverse((IMoniker*)Unsafe.AsPointer(ref this), ppmk);
        }

        [return: NativeTypeName("HRESULT")]
        public int CommonPrefixWith([NativeTypeName("IMoniker *")] IMoniker* pmkOther, [NativeTypeName("IMoniker **")] IMoniker** ppmkPrefix)
        {
            return lpVtbl->CommonPrefixWith((IMoniker*)Unsafe.AsPointer(ref this), pmkOther, ppmkPrefix);
        }

        [return: NativeTypeName("HRESULT")]
        public int RelativePathTo([NativeTypeName("IMoniker *")] IMoniker* pmkOther, [NativeTypeName("IMoniker **")] IMoniker** ppmkRelPath)
        {
            return lpVtbl->RelativePathTo((IMoniker*)Unsafe.AsPointer(ref this), pmkOther, ppmkRelPath);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDisplayName([NativeTypeName("IBindCtx *")] IBindCtx* pbc, [NativeTypeName("IMoniker *")] IMoniker* pmkToLeft, [NativeTypeName("LPOLESTR *")] ushort** ppszDisplayName)
        {
            return lpVtbl->GetDisplayName((IMoniker*)Unsafe.AsPointer(ref this), pbc, pmkToLeft, ppszDisplayName);
        }

        [return: NativeTypeName("HRESULT")]
        public int ParseDisplayName([NativeTypeName("IBindCtx *")] IBindCtx* pbc, [NativeTypeName("IMoniker *")] IMoniker* pmkToLeft, [NativeTypeName("LPOLESTR")] ushort* pszDisplayName, [NativeTypeName("ULONG *")] uint* pchEaten, [NativeTypeName("IMoniker **")] IMoniker** ppmkOut)
        {
            return lpVtbl->ParseDisplayName((IMoniker*)Unsafe.AsPointer(ref this), pbc, pmkToLeft, pszDisplayName, pchEaten, ppmkOut);
        }

        [return: NativeTypeName("HRESULT")]
        public int IsSystemMoniker([NativeTypeName("DWORD *")] uint* pdwMksys)
        {
            return lpVtbl->IsSystemMoniker((IMoniker*)Unsafe.AsPointer(ref this), pdwMksys);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IMoniker*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IMoniker*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IMoniker*, uint> Release;

            [NativeTypeName("HRESULT (CLSID *) __attribute__((stdcall))")]
            public delegate* stdcall<IMoniker*, Guid*, int> GetClassID;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* stdcall<IMoniker*, int> IsDirty;

            [NativeTypeName("HRESULT (IStream *) __attribute__((stdcall))")]
            public delegate* stdcall<IMoniker*, IStream*, int> Load;

            [NativeTypeName("HRESULT (IStream *, BOOL) __attribute__((stdcall))")]
            public delegate* stdcall<IMoniker*, IStream*, int, int> Save;

            [NativeTypeName("HRESULT (ULARGE_INTEGER *) __attribute__((stdcall))")]
            public delegate* stdcall<IMoniker*, ULARGE_INTEGER*, int> GetSizeMax;

            [NativeTypeName("HRESULT (IBindCtx *, IMoniker *, const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IMoniker*, IBindCtx*, IMoniker*, Guid*, void**, int> BindToObject;

            [NativeTypeName("HRESULT (IBindCtx *, IMoniker *, const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IMoniker*, IBindCtx*, IMoniker*, Guid*, void**, int> BindToStorage;

            [NativeTypeName("HRESULT (IBindCtx *, DWORD, IMoniker **, IMoniker **) __attribute__((stdcall))")]
            public delegate* stdcall<IMoniker*, IBindCtx*, uint, IMoniker**, IMoniker**, int> Reduce;

            [NativeTypeName("HRESULT (IMoniker *, BOOL, IMoniker **) __attribute__((stdcall))")]
            public delegate* stdcall<IMoniker*, IMoniker*, int, IMoniker**, int> ComposeWith;

            [NativeTypeName("HRESULT (BOOL, IEnumMoniker **) __attribute__((stdcall))")]
            public delegate* stdcall<IMoniker*, int, IEnumMoniker**, int> Enum;

            [NativeTypeName("HRESULT (IMoniker *) __attribute__((stdcall))")]
            public delegate* stdcall<IMoniker*, IMoniker*, int> IsEqual;

            [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
            public delegate* stdcall<IMoniker*, uint*, int> Hash;

            [NativeTypeName("HRESULT (IBindCtx *, IMoniker *, IMoniker *) __attribute__((stdcall))")]
            public delegate* stdcall<IMoniker*, IBindCtx*, IMoniker*, IMoniker*, int> IsRunning;

            [NativeTypeName("HRESULT (IBindCtx *, IMoniker *, FILETIME *) __attribute__((stdcall))")]
            public delegate* stdcall<IMoniker*, IBindCtx*, IMoniker*, FILETIME*, int> GetTimeOfLastChange;

            [NativeTypeName("HRESULT (IMoniker **) __attribute__((stdcall))")]
            public delegate* stdcall<IMoniker*, IMoniker**, int> Inverse;

            [NativeTypeName("HRESULT (IMoniker *, IMoniker **) __attribute__((stdcall))")]
            public delegate* stdcall<IMoniker*, IMoniker*, IMoniker**, int> CommonPrefixWith;

            [NativeTypeName("HRESULT (IMoniker *, IMoniker **) __attribute__((stdcall))")]
            public delegate* stdcall<IMoniker*, IMoniker*, IMoniker**, int> RelativePathTo;

            [NativeTypeName("HRESULT (IBindCtx *, IMoniker *, LPOLESTR *) __attribute__((stdcall))")]
            public delegate* stdcall<IMoniker*, IBindCtx*, IMoniker*, ushort**, int> GetDisplayName;

            [NativeTypeName("HRESULT (IBindCtx *, IMoniker *, LPOLESTR, ULONG *, IMoniker **) __attribute__((stdcall))")]
            public delegate* stdcall<IMoniker*, IBindCtx*, IMoniker*, ushort*, uint*, IMoniker**, int> ParseDisplayName;

            [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
            public delegate* stdcall<IMoniker*, uint*, int> IsSystemMoniker;
        }
    }
}
