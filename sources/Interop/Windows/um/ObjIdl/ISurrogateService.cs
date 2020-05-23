// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("000001D4-0000-0000-C000-000000000046")]
    public unsafe partial struct ISurrogateService
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(ISurrogateService* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(ISurrogateService* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(ISurrogateService* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Init(ISurrogateService* pThis, [NativeTypeName("const GUID &")] Guid* rguidProcessID, [NativeTypeName("IProcessLock *")] IProcessLock* pProcessLock, [NativeTypeName("BOOL *")] int* pfApplicationAware);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _ApplicationLaunch(ISurrogateService* pThis, [NativeTypeName("const GUID &")] Guid* rguidApplID, ApplicationType appType);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _ApplicationFree(ISurrogateService* pThis, [NativeTypeName("const GUID &")] Guid* rguidApplID);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CatalogRefresh(ISurrogateService* pThis, [NativeTypeName("ULONG")] uint ulReserved);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _ProcessShutdown(ISurrogateService* pThis, ShutdownType shutdownType);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((ISurrogateService*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((ISurrogateService*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((ISurrogateService*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Init([NativeTypeName("const GUID &")] Guid* rguidProcessID, [NativeTypeName("IProcessLock *")] IProcessLock* pProcessLock, [NativeTypeName("BOOL *")] int* pfApplicationAware)
        {
            return Marshal.GetDelegateForFunctionPointer<_Init>(lpVtbl->Init)((ISurrogateService*)Unsafe.AsPointer(ref this), rguidProcessID, pProcessLock, pfApplicationAware);
        }

        [return: NativeTypeName("HRESULT")]
        public int ApplicationLaunch([NativeTypeName("const GUID &")] Guid* rguidApplID, ApplicationType appType)
        {
            return Marshal.GetDelegateForFunctionPointer<_ApplicationLaunch>(lpVtbl->ApplicationLaunch)((ISurrogateService*)Unsafe.AsPointer(ref this), rguidApplID, appType);
        }

        [return: NativeTypeName("HRESULT")]
        public int ApplicationFree([NativeTypeName("const GUID &")] Guid* rguidApplID)
        {
            return Marshal.GetDelegateForFunctionPointer<_ApplicationFree>(lpVtbl->ApplicationFree)((ISurrogateService*)Unsafe.AsPointer(ref this), rguidApplID);
        }

        [return: NativeTypeName("HRESULT")]
        public int CatalogRefresh([NativeTypeName("ULONG")] uint ulReserved)
        {
            return Marshal.GetDelegateForFunctionPointer<_CatalogRefresh>(lpVtbl->CatalogRefresh)((ISurrogateService*)Unsafe.AsPointer(ref this), ulReserved);
        }

        [return: NativeTypeName("HRESULT")]
        public int ProcessShutdown(ShutdownType shutdownType)
        {
            return Marshal.GetDelegateForFunctionPointer<_ProcessShutdown>(lpVtbl->ProcessShutdown)((ISurrogateService*)Unsafe.AsPointer(ref this), shutdownType);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (const GUID &, IProcessLock *, BOOL *) __attribute__((stdcall))")]
            public IntPtr Init;

            [NativeTypeName("HRESULT (const GUID &, ApplicationType) __attribute__((stdcall))")]
            public IntPtr ApplicationLaunch;

            [NativeTypeName("HRESULT (const GUID &) __attribute__((stdcall))")]
            public IntPtr ApplicationFree;

            [NativeTypeName("HRESULT (ULONG) __attribute__((stdcall))")]
            public IntPtr CatalogRefresh;

            [NativeTypeName("HRESULT (ShutdownType) __attribute__((stdcall))")]
            public IntPtr ProcessShutdown;
        }
    }
}
