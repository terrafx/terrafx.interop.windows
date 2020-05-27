// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/oleidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("0000011B-0000-0000-C000-000000000046")]
    public unsafe partial struct IOleContainer
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IOleContainer* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IOleContainer* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IOleContainer* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _ParseDisplayName(IOleContainer* pThis, [NativeTypeName("IBindCtx *")] IBindCtx* pbc, [NativeTypeName("LPOLESTR")] ushort* pszDisplayName, [NativeTypeName("ULONG *")] uint* pchEaten, [NativeTypeName("IMoniker **")] IMoniker** ppmkOut);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _EnumObjects(IOleContainer* pThis, [NativeTypeName("DWORD")] uint grfFlags, [NativeTypeName("IEnumUnknown **")] IEnumUnknown** ppenum);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _LockContainer(IOleContainer* pThis, [NativeTypeName("BOOL")] int fLock);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IOleContainer*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IOleContainer*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IOleContainer*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int ParseDisplayName([NativeTypeName("IBindCtx *")] IBindCtx* pbc, [NativeTypeName("LPOLESTR")] ushort* pszDisplayName, [NativeTypeName("ULONG *")] uint* pchEaten, [NativeTypeName("IMoniker **")] IMoniker** ppmkOut)
        {
            return Marshal.GetDelegateForFunctionPointer<_ParseDisplayName>(lpVtbl->ParseDisplayName)((IOleContainer*)Unsafe.AsPointer(ref this), pbc, pszDisplayName, pchEaten, ppmkOut);
        }

        [return: NativeTypeName("HRESULT")]
        public int EnumObjects([NativeTypeName("DWORD")] uint grfFlags, [NativeTypeName("IEnumUnknown **")] IEnumUnknown** ppenum)
        {
            return Marshal.GetDelegateForFunctionPointer<_EnumObjects>(lpVtbl->EnumObjects)((IOleContainer*)Unsafe.AsPointer(ref this), grfFlags, ppenum);
        }

        [return: NativeTypeName("HRESULT")]
        public int LockContainer([NativeTypeName("BOOL")] int fLock)
        {
            return Marshal.GetDelegateForFunctionPointer<_LockContainer>(lpVtbl->LockContainer)((IOleContainer*)Unsafe.AsPointer(ref this), fLock);
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
        }
    }
}
