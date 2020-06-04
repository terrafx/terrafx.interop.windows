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
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IMoniker*, Guid*, void**, int>)(lpVtbl[0]))((IMoniker*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IMoniker*, uint>)(lpVtbl[1]))((IMoniker*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IMoniker*, uint>)(lpVtbl[2]))((IMoniker*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetClassID([NativeTypeName("CLSID *")] Guid* pClassID)
        {
            return ((delegate* stdcall<IMoniker*, Guid*, int>)(lpVtbl[3]))((IMoniker*)Unsafe.AsPointer(ref this), pClassID);
        }

        [return: NativeTypeName("HRESULT")]
        public int IsDirty()
        {
            return ((delegate* stdcall<IMoniker*, int>)(lpVtbl[4]))((IMoniker*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Load([NativeTypeName("IStream *")] IStream* pStm)
        {
            return ((delegate* stdcall<IMoniker*, IStream*, int>)(lpVtbl[5]))((IMoniker*)Unsafe.AsPointer(ref this), pStm);
        }

        [return: NativeTypeName("HRESULT")]
        public int Save([NativeTypeName("IStream *")] IStream* pStm, [NativeTypeName("BOOL")] int fClearDirty)
        {
            return ((delegate* stdcall<IMoniker*, IStream*, int, int>)(lpVtbl[6]))((IMoniker*)Unsafe.AsPointer(ref this), pStm, fClearDirty);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSizeMax([NativeTypeName("ULARGE_INTEGER *")] ULARGE_INTEGER* pcbSize)
        {
            return ((delegate* stdcall<IMoniker*, ULARGE_INTEGER*, int>)(lpVtbl[7]))((IMoniker*)Unsafe.AsPointer(ref this), pcbSize);
        }

        [return: NativeTypeName("HRESULT")]
        public int BindToObject([NativeTypeName("IBindCtx *")] IBindCtx* pbc, [NativeTypeName("IMoniker *")] IMoniker* pmkToLeft, [NativeTypeName("const IID &")] Guid* riidResult, [NativeTypeName("void **")] void** ppvResult)
        {
            return ((delegate* stdcall<IMoniker*, IBindCtx*, IMoniker*, Guid*, void**, int>)(lpVtbl[8]))((IMoniker*)Unsafe.AsPointer(ref this), pbc, pmkToLeft, riidResult, ppvResult);
        }

        [return: NativeTypeName("HRESULT")]
        public int BindToStorage([NativeTypeName("IBindCtx *")] IBindCtx* pbc, [NativeTypeName("IMoniker *")] IMoniker* pmkToLeft, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObj)
        {
            return ((delegate* stdcall<IMoniker*, IBindCtx*, IMoniker*, Guid*, void**, int>)(lpVtbl[9]))((IMoniker*)Unsafe.AsPointer(ref this), pbc, pmkToLeft, riid, ppvObj);
        }

        [return: NativeTypeName("HRESULT")]
        public int Reduce([NativeTypeName("IBindCtx *")] IBindCtx* pbc, [NativeTypeName("DWORD")] uint dwReduceHowFar, [NativeTypeName("IMoniker **")] IMoniker** ppmkToLeft, [NativeTypeName("IMoniker **")] IMoniker** ppmkReduced)
        {
            return ((delegate* stdcall<IMoniker*, IBindCtx*, uint, IMoniker**, IMoniker**, int>)(lpVtbl[10]))((IMoniker*)Unsafe.AsPointer(ref this), pbc, dwReduceHowFar, ppmkToLeft, ppmkReduced);
        }

        [return: NativeTypeName("HRESULT")]
        public int ComposeWith([NativeTypeName("IMoniker *")] IMoniker* pmkRight, [NativeTypeName("BOOL")] int fOnlyIfNotGeneric, [NativeTypeName("IMoniker **")] IMoniker** ppmkComposite)
        {
            return ((delegate* stdcall<IMoniker*, IMoniker*, int, IMoniker**, int>)(lpVtbl[11]))((IMoniker*)Unsafe.AsPointer(ref this), pmkRight, fOnlyIfNotGeneric, ppmkComposite);
        }

        [return: NativeTypeName("HRESULT")]
        public int Enum([NativeTypeName("BOOL")] int fForward, [NativeTypeName("IEnumMoniker **")] IEnumMoniker** ppenumMoniker)
        {
            return ((delegate* stdcall<IMoniker*, int, IEnumMoniker**, int>)(lpVtbl[12]))((IMoniker*)Unsafe.AsPointer(ref this), fForward, ppenumMoniker);
        }

        [return: NativeTypeName("HRESULT")]
        public int IsEqual([NativeTypeName("IMoniker *")] IMoniker* pmkOtherMoniker)
        {
            return ((delegate* stdcall<IMoniker*, IMoniker*, int>)(lpVtbl[13]))((IMoniker*)Unsafe.AsPointer(ref this), pmkOtherMoniker);
        }

        [return: NativeTypeName("HRESULT")]
        public int Hash([NativeTypeName("DWORD *")] uint* pdwHash)
        {
            return ((delegate* stdcall<IMoniker*, uint*, int>)(lpVtbl[14]))((IMoniker*)Unsafe.AsPointer(ref this), pdwHash);
        }

        [return: NativeTypeName("HRESULT")]
        public int IsRunning([NativeTypeName("IBindCtx *")] IBindCtx* pbc, [NativeTypeName("IMoniker *")] IMoniker* pmkToLeft, [NativeTypeName("IMoniker *")] IMoniker* pmkNewlyRunning)
        {
            return ((delegate* stdcall<IMoniker*, IBindCtx*, IMoniker*, IMoniker*, int>)(lpVtbl[15]))((IMoniker*)Unsafe.AsPointer(ref this), pbc, pmkToLeft, pmkNewlyRunning);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTimeOfLastChange([NativeTypeName("IBindCtx *")] IBindCtx* pbc, [NativeTypeName("IMoniker *")] IMoniker* pmkToLeft, [NativeTypeName("FILETIME *")] FILETIME* pFileTime)
        {
            return ((delegate* stdcall<IMoniker*, IBindCtx*, IMoniker*, FILETIME*, int>)(lpVtbl[16]))((IMoniker*)Unsafe.AsPointer(ref this), pbc, pmkToLeft, pFileTime);
        }

        [return: NativeTypeName("HRESULT")]
        public int Inverse([NativeTypeName("IMoniker **")] IMoniker** ppmk)
        {
            return ((delegate* stdcall<IMoniker*, IMoniker**, int>)(lpVtbl[17]))((IMoniker*)Unsafe.AsPointer(ref this), ppmk);
        }

        [return: NativeTypeName("HRESULT")]
        public int CommonPrefixWith([NativeTypeName("IMoniker *")] IMoniker* pmkOther, [NativeTypeName("IMoniker **")] IMoniker** ppmkPrefix)
        {
            return ((delegate* stdcall<IMoniker*, IMoniker*, IMoniker**, int>)(lpVtbl[18]))((IMoniker*)Unsafe.AsPointer(ref this), pmkOther, ppmkPrefix);
        }

        [return: NativeTypeName("HRESULT")]
        public int RelativePathTo([NativeTypeName("IMoniker *")] IMoniker* pmkOther, [NativeTypeName("IMoniker **")] IMoniker** ppmkRelPath)
        {
            return ((delegate* stdcall<IMoniker*, IMoniker*, IMoniker**, int>)(lpVtbl[19]))((IMoniker*)Unsafe.AsPointer(ref this), pmkOther, ppmkRelPath);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDisplayName([NativeTypeName("IBindCtx *")] IBindCtx* pbc, [NativeTypeName("IMoniker *")] IMoniker* pmkToLeft, [NativeTypeName("LPOLESTR *")] ushort** ppszDisplayName)
        {
            return ((delegate* stdcall<IMoniker*, IBindCtx*, IMoniker*, ushort**, int>)(lpVtbl[20]))((IMoniker*)Unsafe.AsPointer(ref this), pbc, pmkToLeft, ppszDisplayName);
        }

        [return: NativeTypeName("HRESULT")]
        public int ParseDisplayName([NativeTypeName("IBindCtx *")] IBindCtx* pbc, [NativeTypeName("IMoniker *")] IMoniker* pmkToLeft, [NativeTypeName("LPOLESTR")] ushort* pszDisplayName, [NativeTypeName("ULONG *")] uint* pchEaten, [NativeTypeName("IMoniker **")] IMoniker** ppmkOut)
        {
            return ((delegate* stdcall<IMoniker*, IBindCtx*, IMoniker*, ushort*, uint*, IMoniker**, int>)(lpVtbl[21]))((IMoniker*)Unsafe.AsPointer(ref this), pbc, pmkToLeft, pszDisplayName, pchEaten, ppmkOut);
        }

        [return: NativeTypeName("HRESULT")]
        public int IsSystemMoniker([NativeTypeName("DWORD *")] uint* pdwMksys)
        {
            return ((delegate* stdcall<IMoniker*, uint*, int>)(lpVtbl[22]))((IMoniker*)Unsafe.AsPointer(ref this), pdwMksys);
        }
    }
}
