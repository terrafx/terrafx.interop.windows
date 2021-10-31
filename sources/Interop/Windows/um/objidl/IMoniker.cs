// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/objidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("0000000F-0000-0000-C000-000000000046")]
    [NativeTypeName("struct IMoniker : IPersistStream")]
    [NativeInheritance("IPersistStream")]
    public unsafe partial struct IMoniker
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMoniker*, Guid*, void**, int>)(lpVtbl[0]))((IMoniker*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMoniker*, uint>)(lpVtbl[1]))((IMoniker*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMoniker*, uint>)(lpVtbl[2]))((IMoniker*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetClassID([NativeTypeName("CLSID *")] Guid* pClassID)
        {
            return ((delegate* unmanaged<IMoniker*, Guid*, int>)(lpVtbl[3]))((IMoniker*)Unsafe.AsPointer(ref this), pClassID);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int IsDirty()
        {
            return ((delegate* unmanaged<IMoniker*, int>)(lpVtbl[4]))((IMoniker*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int Load(IStream* pStm)
        {
            return ((delegate* unmanaged<IMoniker*, IStream*, int>)(lpVtbl[5]))((IMoniker*)Unsafe.AsPointer(ref this), pStm);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int Save(IStream* pStm, BOOL fClearDirty)
        {
            return ((delegate* unmanaged<IMoniker*, IStream*, BOOL, int>)(lpVtbl[6]))((IMoniker*)Unsafe.AsPointer(ref this), pStm, fClearDirty);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int GetSizeMax(ULARGE_INTEGER* pcbSize)
        {
            return ((delegate* unmanaged<IMoniker*, ULARGE_INTEGER*, int>)(lpVtbl[7]))((IMoniker*)Unsafe.AsPointer(ref this), pcbSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int BindToObject(IBindCtx* pbc, IMoniker* pmkToLeft, [NativeTypeName("const IID &")] Guid* riidResult, void** ppvResult)
        {
            return ((delegate* unmanaged<IMoniker*, IBindCtx*, IMoniker*, Guid*, void**, int>)(lpVtbl[8]))((IMoniker*)Unsafe.AsPointer(ref this), pbc, pmkToLeft, riidResult, ppvResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int BindToStorage(IBindCtx* pbc, IMoniker* pmkToLeft, [NativeTypeName("const IID &")] Guid* riid, void** ppvObj)
        {
            return ((delegate* unmanaged<IMoniker*, IBindCtx*, IMoniker*, Guid*, void**, int>)(lpVtbl[9]))((IMoniker*)Unsafe.AsPointer(ref this), pbc, pmkToLeft, riid, ppvObj);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int Reduce(IBindCtx* pbc, [NativeTypeName("DWORD")] uint dwReduceHowFar, IMoniker** ppmkToLeft, IMoniker** ppmkReduced)
        {
            return ((delegate* unmanaged<IMoniker*, IBindCtx*, uint, IMoniker**, IMoniker**, int>)(lpVtbl[10]))((IMoniker*)Unsafe.AsPointer(ref this), pbc, dwReduceHowFar, ppmkToLeft, ppmkReduced);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int ComposeWith(IMoniker* pmkRight, BOOL fOnlyIfNotGeneric, IMoniker** ppmkComposite)
        {
            return ((delegate* unmanaged<IMoniker*, IMoniker*, BOOL, IMoniker**, int>)(lpVtbl[11]))((IMoniker*)Unsafe.AsPointer(ref this), pmkRight, fOnlyIfNotGeneric, ppmkComposite);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int Enum(BOOL fForward, IEnumMoniker** ppenumMoniker)
        {
            return ((delegate* unmanaged<IMoniker*, BOOL, IEnumMoniker**, int>)(lpVtbl[12]))((IMoniker*)Unsafe.AsPointer(ref this), fForward, ppenumMoniker);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int IsEqual(IMoniker* pmkOtherMoniker)
        {
            return ((delegate* unmanaged<IMoniker*, IMoniker*, int>)(lpVtbl[13]))((IMoniker*)Unsafe.AsPointer(ref this), pmkOtherMoniker);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int Hash([NativeTypeName("DWORD *")] uint* pdwHash)
        {
            return ((delegate* unmanaged<IMoniker*, uint*, int>)(lpVtbl[14]))((IMoniker*)Unsafe.AsPointer(ref this), pdwHash);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("HRESULT")]
        public int IsRunning(IBindCtx* pbc, IMoniker* pmkToLeft, IMoniker* pmkNewlyRunning)
        {
            return ((delegate* unmanaged<IMoniker*, IBindCtx*, IMoniker*, IMoniker*, int>)(lpVtbl[15]))((IMoniker*)Unsafe.AsPointer(ref this), pbc, pmkToLeft, pmkNewlyRunning);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        [return: NativeTypeName("HRESULT")]
        public int GetTimeOfLastChange(IBindCtx* pbc, IMoniker* pmkToLeft, FILETIME* pFileTime)
        {
            return ((delegate* unmanaged<IMoniker*, IBindCtx*, IMoniker*, FILETIME*, int>)(lpVtbl[16]))((IMoniker*)Unsafe.AsPointer(ref this), pbc, pmkToLeft, pFileTime);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        [return: NativeTypeName("HRESULT")]
        public int Inverse(IMoniker** ppmk)
        {
            return ((delegate* unmanaged<IMoniker*, IMoniker**, int>)(lpVtbl[17]))((IMoniker*)Unsafe.AsPointer(ref this), ppmk);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        [return: NativeTypeName("HRESULT")]
        public int CommonPrefixWith(IMoniker* pmkOther, IMoniker** ppmkPrefix)
        {
            return ((delegate* unmanaged<IMoniker*, IMoniker*, IMoniker**, int>)(lpVtbl[18]))((IMoniker*)Unsafe.AsPointer(ref this), pmkOther, ppmkPrefix);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        [return: NativeTypeName("HRESULT")]
        public int RelativePathTo(IMoniker* pmkOther, IMoniker** ppmkRelPath)
        {
            return ((delegate* unmanaged<IMoniker*, IMoniker*, IMoniker**, int>)(lpVtbl[19]))((IMoniker*)Unsafe.AsPointer(ref this), pmkOther, ppmkRelPath);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        [return: NativeTypeName("HRESULT")]
        public int GetDisplayName(IBindCtx* pbc, IMoniker* pmkToLeft, [NativeTypeName("LPOLESTR *")] ushort** ppszDisplayName)
        {
            return ((delegate* unmanaged<IMoniker*, IBindCtx*, IMoniker*, ushort**, int>)(lpVtbl[20]))((IMoniker*)Unsafe.AsPointer(ref this), pbc, pmkToLeft, ppszDisplayName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        [return: NativeTypeName("HRESULT")]
        public int ParseDisplayName(IBindCtx* pbc, IMoniker* pmkToLeft, [NativeTypeName("LPOLESTR")] ushort* pszDisplayName, [NativeTypeName("ULONG *")] uint* pchEaten, IMoniker** ppmkOut)
        {
            return ((delegate* unmanaged<IMoniker*, IBindCtx*, IMoniker*, ushort*, uint*, IMoniker**, int>)(lpVtbl[21]))((IMoniker*)Unsafe.AsPointer(ref this), pbc, pmkToLeft, pszDisplayName, pchEaten, ppmkOut);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        [return: NativeTypeName("HRESULT")]
        public int IsSystemMoniker([NativeTypeName("DWORD *")] uint* pdwMksys)
        {
            return ((delegate* unmanaged<IMoniker*, uint*, int>)(lpVtbl[22]))((IMoniker*)Unsafe.AsPointer(ref this), pdwMksys);
        }
    }
}
