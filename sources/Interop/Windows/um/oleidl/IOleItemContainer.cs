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

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IOleItemContainer* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IOleItemContainer* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IOleItemContainer* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _ParseDisplayName(IOleItemContainer* pThis, [NativeTypeName("IBindCtx *")] IBindCtx* pbc, [NativeTypeName("LPOLESTR")] ushort* pszDisplayName, [NativeTypeName("ULONG *")] uint* pchEaten, [NativeTypeName("IMoniker **")] IMoniker** ppmkOut);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _EnumObjects(IOleItemContainer* pThis, [NativeTypeName("DWORD")] uint grfFlags, [NativeTypeName("IEnumUnknown **")] IEnumUnknown** ppenum);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _LockContainer(IOleItemContainer* pThis, [NativeTypeName("BOOL")] int fLock);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetObjectA(IOleItemContainer* pThis, [NativeTypeName("LPOLESTR")] ushort* pszItem, [NativeTypeName("DWORD")] uint dwSpeedNeeded, [NativeTypeName("IBindCtx *")] IBindCtx* pbc, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetObjectStorage(IOleItemContainer* pThis, [NativeTypeName("LPOLESTR")] ushort* pszItem, [NativeTypeName("IBindCtx *")] IBindCtx* pbc, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvStorage);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _IsRunning(IOleItemContainer* pThis, [NativeTypeName("LPOLESTR")] ushort* pszItem);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IOleItemContainer*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IOleItemContainer*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IOleItemContainer*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int ParseDisplayName([NativeTypeName("IBindCtx *")] IBindCtx* pbc, [NativeTypeName("LPOLESTR")] ushort* pszDisplayName, [NativeTypeName("ULONG *")] uint* pchEaten, [NativeTypeName("IMoniker **")] IMoniker** ppmkOut)
        {
            return Marshal.GetDelegateForFunctionPointer<_ParseDisplayName>(lpVtbl->ParseDisplayName)((IOleItemContainer*)Unsafe.AsPointer(ref this), pbc, pszDisplayName, pchEaten, ppmkOut);
        }

        [return: NativeTypeName("HRESULT")]
        public int EnumObjects([NativeTypeName("DWORD")] uint grfFlags, [NativeTypeName("IEnumUnknown **")] IEnumUnknown** ppenum)
        {
            return Marshal.GetDelegateForFunctionPointer<_EnumObjects>(lpVtbl->EnumObjects)((IOleItemContainer*)Unsafe.AsPointer(ref this), grfFlags, ppenum);
        }

        [return: NativeTypeName("HRESULT")]
        public int LockContainer([NativeTypeName("BOOL")] int fLock)
        {
            return Marshal.GetDelegateForFunctionPointer<_LockContainer>(lpVtbl->LockContainer)((IOleItemContainer*)Unsafe.AsPointer(ref this), fLock);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetObjectA([NativeTypeName("LPOLESTR")] ushort* pszItem, [NativeTypeName("DWORD")] uint dwSpeedNeeded, [NativeTypeName("IBindCtx *")] IBindCtx* pbc, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetObjectA>(lpVtbl->GetObjectA)((IOleItemContainer*)Unsafe.AsPointer(ref this), pszItem, dwSpeedNeeded, pbc, riid, ppvObject);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetObjectStorage([NativeTypeName("LPOLESTR")] ushort* pszItem, [NativeTypeName("IBindCtx *")] IBindCtx* pbc, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvStorage)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetObjectStorage>(lpVtbl->GetObjectStorage)((IOleItemContainer*)Unsafe.AsPointer(ref this), pszItem, pbc, riid, ppvStorage);
        }

        [return: NativeTypeName("HRESULT")]
        public int IsRunning([NativeTypeName("LPOLESTR")] ushort* pszItem)
        {
            return Marshal.GetDelegateForFunctionPointer<_IsRunning>(lpVtbl->IsRunning)((IOleItemContainer*)Unsafe.AsPointer(ref this), pszItem);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (IBindCtx *, LPOLESTR, ULONG *, IMoniker **) __attribute__((stdcall))")]
            public IntPtr ParseDisplayName;

            [NativeTypeName("HRESULT (DWORD, IEnumUnknown **) __attribute__((stdcall))")]
            public IntPtr EnumObjects;

            [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
            public IntPtr LockContainer;

            [NativeTypeName("HRESULT (LPOLESTR, DWORD, IBindCtx *, const IID &, void **) __attribute__((stdcall))")]
            public IntPtr GetObjectA;

            [NativeTypeName("HRESULT (LPOLESTR, IBindCtx *, const IID &, void **) __attribute__((stdcall))")]
            public IntPtr GetObjectStorage;

            [NativeTypeName("HRESULT (LPOLESTR) __attribute__((stdcall))")]
            public IntPtr IsRunning;
        }
    }
}
