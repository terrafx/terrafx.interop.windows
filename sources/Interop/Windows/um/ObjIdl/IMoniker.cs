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

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IMoniker* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IMoniker* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IMoniker* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetClassID(IMoniker* pThis, [NativeTypeName("CLSID *")] Guid* pClassID);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _IsDirty(IMoniker* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Load(IMoniker* pThis, [NativeTypeName("IStream *")] IStream* pStm);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Save(IMoniker* pThis, [NativeTypeName("IStream *")] IStream* pStm, [NativeTypeName("BOOL")] int fClearDirty);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetSizeMax(IMoniker* pThis, [NativeTypeName("ULARGE_INTEGER *")] ULARGE_INTEGER* pcbSize);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _BindToObject(IMoniker* pThis, [NativeTypeName("IBindCtx *")] IBindCtx* pbc, [NativeTypeName("IMoniker *")] IMoniker* pmkToLeft, [NativeTypeName("const IID &")] Guid* riidResult, [NativeTypeName("void **")] void** ppvResult);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _BindToStorage(IMoniker* pThis, [NativeTypeName("IBindCtx *")] IBindCtx* pbc, [NativeTypeName("IMoniker *")] IMoniker* pmkToLeft, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObj);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Reduce(IMoniker* pThis, [NativeTypeName("IBindCtx *")] IBindCtx* pbc, [NativeTypeName("DWORD")] uint dwReduceHowFar, [NativeTypeName("IMoniker **")] IMoniker** ppmkToLeft, [NativeTypeName("IMoniker **")] IMoniker** ppmkReduced);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _ComposeWith(IMoniker* pThis, [NativeTypeName("IMoniker *")] IMoniker* pmkRight, [NativeTypeName("BOOL")] int fOnlyIfNotGeneric, [NativeTypeName("IMoniker **")] IMoniker** ppmkComposite);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Enum(IMoniker* pThis, [NativeTypeName("BOOL")] int fForward, [NativeTypeName("IEnumMoniker **")] IEnumMoniker** ppenumMoniker);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _IsEqual(IMoniker* pThis, [NativeTypeName("IMoniker *")] IMoniker* pmkOtherMoniker);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Hash(IMoniker* pThis, [NativeTypeName("DWORD *")] uint* pdwHash);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _IsRunning(IMoniker* pThis, [NativeTypeName("IBindCtx *")] IBindCtx* pbc, [NativeTypeName("IMoniker *")] IMoniker* pmkToLeft, [NativeTypeName("IMoniker *")] IMoniker* pmkNewlyRunning);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetTimeOfLastChange(IMoniker* pThis, [NativeTypeName("IBindCtx *")] IBindCtx* pbc, [NativeTypeName("IMoniker *")] IMoniker* pmkToLeft, [NativeTypeName("FILETIME *")] FILETIME* pFileTime);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Inverse(IMoniker* pThis, [NativeTypeName("IMoniker **")] IMoniker** ppmk);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CommonPrefixWith(IMoniker* pThis, [NativeTypeName("IMoniker *")] IMoniker* pmkOther, [NativeTypeName("IMoniker **")] IMoniker** ppmkPrefix);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _RelativePathTo(IMoniker* pThis, [NativeTypeName("IMoniker *")] IMoniker* pmkOther, [NativeTypeName("IMoniker **")] IMoniker** ppmkRelPath);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetDisplayName(IMoniker* pThis, [NativeTypeName("IBindCtx *")] IBindCtx* pbc, [NativeTypeName("IMoniker *")] IMoniker* pmkToLeft, [NativeTypeName("LPOLESTR *")] ushort** ppszDisplayName);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _ParseDisplayName(IMoniker* pThis, [NativeTypeName("IBindCtx *")] IBindCtx* pbc, [NativeTypeName("IMoniker *")] IMoniker* pmkToLeft, [NativeTypeName("LPOLESTR")] ushort* pszDisplayName, [NativeTypeName("ULONG *")] uint* pchEaten, [NativeTypeName("IMoniker **")] IMoniker** ppmkOut);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _IsSystemMoniker(IMoniker* pThis, [NativeTypeName("DWORD *")] uint* pdwMksys);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IMoniker*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IMoniker*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IMoniker*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetClassID([NativeTypeName("CLSID *")] Guid* pClassID)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetClassID>(lpVtbl->GetClassID)((IMoniker*)Unsafe.AsPointer(ref this), pClassID);
        }

        [return: NativeTypeName("HRESULT")]
        public int IsDirty()
        {
            return Marshal.GetDelegateForFunctionPointer<_IsDirty>(lpVtbl->IsDirty)((IMoniker*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Load([NativeTypeName("IStream *")] IStream* pStm)
        {
            return Marshal.GetDelegateForFunctionPointer<_Load>(lpVtbl->Load)((IMoniker*)Unsafe.AsPointer(ref this), pStm);
        }

        [return: NativeTypeName("HRESULT")]
        public int Save([NativeTypeName("IStream *")] IStream* pStm, [NativeTypeName("BOOL")] int fClearDirty)
        {
            return Marshal.GetDelegateForFunctionPointer<_Save>(lpVtbl->Save)((IMoniker*)Unsafe.AsPointer(ref this), pStm, fClearDirty);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSizeMax([NativeTypeName("ULARGE_INTEGER *")] ULARGE_INTEGER* pcbSize)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetSizeMax>(lpVtbl->GetSizeMax)((IMoniker*)Unsafe.AsPointer(ref this), pcbSize);
        }

        [return: NativeTypeName("HRESULT")]
        public int BindToObject([NativeTypeName("IBindCtx *")] IBindCtx* pbc, [NativeTypeName("IMoniker *")] IMoniker* pmkToLeft, [NativeTypeName("const IID &")] Guid* riidResult, [NativeTypeName("void **")] void** ppvResult)
        {
            return Marshal.GetDelegateForFunctionPointer<_BindToObject>(lpVtbl->BindToObject)((IMoniker*)Unsafe.AsPointer(ref this), pbc, pmkToLeft, riidResult, ppvResult);
        }

        [return: NativeTypeName("HRESULT")]
        public int BindToStorage([NativeTypeName("IBindCtx *")] IBindCtx* pbc, [NativeTypeName("IMoniker *")] IMoniker* pmkToLeft, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObj)
        {
            return Marshal.GetDelegateForFunctionPointer<_BindToStorage>(lpVtbl->BindToStorage)((IMoniker*)Unsafe.AsPointer(ref this), pbc, pmkToLeft, riid, ppvObj);
        }

        [return: NativeTypeName("HRESULT")]
        public int Reduce([NativeTypeName("IBindCtx *")] IBindCtx* pbc, [NativeTypeName("DWORD")] uint dwReduceHowFar, [NativeTypeName("IMoniker **")] IMoniker** ppmkToLeft, [NativeTypeName("IMoniker **")] IMoniker** ppmkReduced)
        {
            return Marshal.GetDelegateForFunctionPointer<_Reduce>(lpVtbl->Reduce)((IMoniker*)Unsafe.AsPointer(ref this), pbc, dwReduceHowFar, ppmkToLeft, ppmkReduced);
        }

        [return: NativeTypeName("HRESULT")]
        public int ComposeWith([NativeTypeName("IMoniker *")] IMoniker* pmkRight, [NativeTypeName("BOOL")] int fOnlyIfNotGeneric, [NativeTypeName("IMoniker **")] IMoniker** ppmkComposite)
        {
            return Marshal.GetDelegateForFunctionPointer<_ComposeWith>(lpVtbl->ComposeWith)((IMoniker*)Unsafe.AsPointer(ref this), pmkRight, fOnlyIfNotGeneric, ppmkComposite);
        }

        [return: NativeTypeName("HRESULT")]
        public int Enum([NativeTypeName("BOOL")] int fForward, [NativeTypeName("IEnumMoniker **")] IEnumMoniker** ppenumMoniker)
        {
            return Marshal.GetDelegateForFunctionPointer<_Enum>(lpVtbl->Enum)((IMoniker*)Unsafe.AsPointer(ref this), fForward, ppenumMoniker);
        }

        [return: NativeTypeName("HRESULT")]
        public int IsEqual([NativeTypeName("IMoniker *")] IMoniker* pmkOtherMoniker)
        {
            return Marshal.GetDelegateForFunctionPointer<_IsEqual>(lpVtbl->IsEqual)((IMoniker*)Unsafe.AsPointer(ref this), pmkOtherMoniker);
        }

        [return: NativeTypeName("HRESULT")]
        public int Hash([NativeTypeName("DWORD *")] uint* pdwHash)
        {
            return Marshal.GetDelegateForFunctionPointer<_Hash>(lpVtbl->Hash)((IMoniker*)Unsafe.AsPointer(ref this), pdwHash);
        }

        [return: NativeTypeName("HRESULT")]
        public int IsRunning([NativeTypeName("IBindCtx *")] IBindCtx* pbc, [NativeTypeName("IMoniker *")] IMoniker* pmkToLeft, [NativeTypeName("IMoniker *")] IMoniker* pmkNewlyRunning)
        {
            return Marshal.GetDelegateForFunctionPointer<_IsRunning>(lpVtbl->IsRunning)((IMoniker*)Unsafe.AsPointer(ref this), pbc, pmkToLeft, pmkNewlyRunning);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTimeOfLastChange([NativeTypeName("IBindCtx *")] IBindCtx* pbc, [NativeTypeName("IMoniker *")] IMoniker* pmkToLeft, [NativeTypeName("FILETIME *")] FILETIME* pFileTime)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetTimeOfLastChange>(lpVtbl->GetTimeOfLastChange)((IMoniker*)Unsafe.AsPointer(ref this), pbc, pmkToLeft, pFileTime);
        }

        [return: NativeTypeName("HRESULT")]
        public int Inverse([NativeTypeName("IMoniker **")] IMoniker** ppmk)
        {
            return Marshal.GetDelegateForFunctionPointer<_Inverse>(lpVtbl->Inverse)((IMoniker*)Unsafe.AsPointer(ref this), ppmk);
        }

        [return: NativeTypeName("HRESULT")]
        public int CommonPrefixWith([NativeTypeName("IMoniker *")] IMoniker* pmkOther, [NativeTypeName("IMoniker **")] IMoniker** ppmkPrefix)
        {
            return Marshal.GetDelegateForFunctionPointer<_CommonPrefixWith>(lpVtbl->CommonPrefixWith)((IMoniker*)Unsafe.AsPointer(ref this), pmkOther, ppmkPrefix);
        }

        [return: NativeTypeName("HRESULT")]
        public int RelativePathTo([NativeTypeName("IMoniker *")] IMoniker* pmkOther, [NativeTypeName("IMoniker **")] IMoniker** ppmkRelPath)
        {
            return Marshal.GetDelegateForFunctionPointer<_RelativePathTo>(lpVtbl->RelativePathTo)((IMoniker*)Unsafe.AsPointer(ref this), pmkOther, ppmkRelPath);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDisplayName([NativeTypeName("IBindCtx *")] IBindCtx* pbc, [NativeTypeName("IMoniker *")] IMoniker* pmkToLeft, [NativeTypeName("LPOLESTR *")] ushort** ppszDisplayName)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetDisplayName>(lpVtbl->GetDisplayName)((IMoniker*)Unsafe.AsPointer(ref this), pbc, pmkToLeft, ppszDisplayName);
        }

        [return: NativeTypeName("HRESULT")]
        public int ParseDisplayName([NativeTypeName("IBindCtx *")] IBindCtx* pbc, [NativeTypeName("IMoniker *")] IMoniker* pmkToLeft, [NativeTypeName("LPOLESTR")] ushort* pszDisplayName, [NativeTypeName("ULONG *")] uint* pchEaten, [NativeTypeName("IMoniker **")] IMoniker** ppmkOut)
        {
            return Marshal.GetDelegateForFunctionPointer<_ParseDisplayName>(lpVtbl->ParseDisplayName)((IMoniker*)Unsafe.AsPointer(ref this), pbc, pmkToLeft, pszDisplayName, pchEaten, ppmkOut);
        }

        [return: NativeTypeName("HRESULT")]
        public int IsSystemMoniker([NativeTypeName("DWORD *")] uint* pdwMksys)
        {
            return Marshal.GetDelegateForFunctionPointer<_IsSystemMoniker>(lpVtbl->IsSystemMoniker)((IMoniker*)Unsafe.AsPointer(ref this), pdwMksys);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (CLSID *) __attribute__((stdcall))")]
            public IntPtr GetClassID;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public IntPtr IsDirty;

            [NativeTypeName("HRESULT (IStream *) __attribute__((stdcall))")]
            public IntPtr Load;

            [NativeTypeName("HRESULT (IStream *, BOOL) __attribute__((stdcall))")]
            public IntPtr Save;

            [NativeTypeName("HRESULT (ULARGE_INTEGER *) __attribute__((stdcall))")]
            public IntPtr GetSizeMax;

            [NativeTypeName("HRESULT (IBindCtx *, IMoniker *, const IID &, void **) __attribute__((stdcall))")]
            public IntPtr BindToObject;

            [NativeTypeName("HRESULT (IBindCtx *, IMoniker *, const IID &, void **) __attribute__((stdcall))")]
            public IntPtr BindToStorage;

            [NativeTypeName("HRESULT (IBindCtx *, DWORD, IMoniker **, IMoniker **) __attribute__((stdcall))")]
            public IntPtr Reduce;

            [NativeTypeName("HRESULT (IMoniker *, BOOL, IMoniker **) __attribute__((stdcall))")]
            public IntPtr ComposeWith;

            [NativeTypeName("HRESULT (BOOL, IEnumMoniker **) __attribute__((stdcall))")]
            public IntPtr Enum;

            [NativeTypeName("HRESULT (IMoniker *) __attribute__((stdcall))")]
            public IntPtr IsEqual;

            [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
            public IntPtr Hash;

            [NativeTypeName("HRESULT (IBindCtx *, IMoniker *, IMoniker *) __attribute__((stdcall))")]
            public IntPtr IsRunning;

            [NativeTypeName("HRESULT (IBindCtx *, IMoniker *, FILETIME *) __attribute__((stdcall))")]
            public IntPtr GetTimeOfLastChange;

            [NativeTypeName("HRESULT (IMoniker **) __attribute__((stdcall))")]
            public IntPtr Inverse;

            [NativeTypeName("HRESULT (IMoniker *, IMoniker **) __attribute__((stdcall))")]
            public IntPtr CommonPrefixWith;

            [NativeTypeName("HRESULT (IMoniker *, IMoniker **) __attribute__((stdcall))")]
            public IntPtr RelativePathTo;

            [NativeTypeName("HRESULT (IBindCtx *, IMoniker *, LPOLESTR *) __attribute__((stdcall))")]
            public IntPtr GetDisplayName;

            [NativeTypeName("HRESULT (IBindCtx *, IMoniker *, LPOLESTR, ULONG *, IMoniker **) __attribute__((stdcall))")]
            public IntPtr ParseDisplayName;

            [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
            public IntPtr IsSystemMoniker;
        }
    }
}
