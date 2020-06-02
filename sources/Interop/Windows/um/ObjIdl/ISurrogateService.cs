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

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((ISurrogateService*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((ISurrogateService*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((ISurrogateService*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Init([NativeTypeName("const GUID &")] Guid* rguidProcessID, [NativeTypeName("IProcessLock *")] IProcessLock* pProcessLock, [NativeTypeName("BOOL *")] int* pfApplicationAware)
        {
            return lpVtbl->Init((ISurrogateService*)Unsafe.AsPointer(ref this), rguidProcessID, pProcessLock, pfApplicationAware);
        }

        [return: NativeTypeName("HRESULT")]
        public int ApplicationLaunch([NativeTypeName("const GUID &")] Guid* rguidApplID, ApplicationType appType)
        {
            return lpVtbl->ApplicationLaunch((ISurrogateService*)Unsafe.AsPointer(ref this), rguidApplID, appType);
        }

        [return: NativeTypeName("HRESULT")]
        public int ApplicationFree([NativeTypeName("const GUID &")] Guid* rguidApplID)
        {
            return lpVtbl->ApplicationFree((ISurrogateService*)Unsafe.AsPointer(ref this), rguidApplID);
        }

        [return: NativeTypeName("HRESULT")]
        public int CatalogRefresh([NativeTypeName("ULONG")] uint ulReserved)
        {
            return lpVtbl->CatalogRefresh((ISurrogateService*)Unsafe.AsPointer(ref this), ulReserved);
        }

        [return: NativeTypeName("HRESULT")]
        public int ProcessShutdown(ShutdownType shutdownType)
        {
            return lpVtbl->ProcessShutdown((ISurrogateService*)Unsafe.AsPointer(ref this), shutdownType);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<ISurrogateService*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ISurrogateService*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ISurrogateService*, uint> Release;

            [NativeTypeName("HRESULT (const GUID &, IProcessLock *, BOOL *) __attribute__((stdcall))")]
            public delegate* stdcall<ISurrogateService*, Guid*, IProcessLock*, int*, int> Init;

            [NativeTypeName("HRESULT (const GUID &, ApplicationType) __attribute__((stdcall))")]
            public delegate* stdcall<ISurrogateService*, Guid*, ApplicationType, int> ApplicationLaunch;

            [NativeTypeName("HRESULT (const GUID &) __attribute__((stdcall))")]
            public delegate* stdcall<ISurrogateService*, Guid*, int> ApplicationFree;

            [NativeTypeName("HRESULT (ULONG) __attribute__((stdcall))")]
            public delegate* stdcall<ISurrogateService*, uint, int> CatalogRefresh;

            [NativeTypeName("HRESULT (ShutdownType) __attribute__((stdcall))")]
            public delegate* stdcall<ISurrogateService*, ShutdownType, int> ProcessShutdown;
        }
    }
}
