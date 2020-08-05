// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("000001D4-0000-0000-C000-000000000046")]
    [NativeTypeName("struct ISurrogateService : IUnknown")]
    public unsafe partial struct ISurrogateService
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<ISurrogateService*, Guid*, void**, int>)(lpVtbl[0]))((ISurrogateService*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<ISurrogateService*, uint>)(lpVtbl[1]))((ISurrogateService*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<ISurrogateService*, uint>)(lpVtbl[2]))((ISurrogateService*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Init([NativeTypeName("const GUID &")] Guid* rguidProcessID, [NativeTypeName("IProcessLock *")] IProcessLock* pProcessLock, [NativeTypeName("BOOL *")] int* pfApplicationAware)
        {
            return ((delegate* stdcall<ISurrogateService*, Guid*, IProcessLock*, int*, int>)(lpVtbl[3]))((ISurrogateService*)Unsafe.AsPointer(ref this), rguidProcessID, pProcessLock, pfApplicationAware);
        }

        [return: NativeTypeName("HRESULT")]
        public int ApplicationLaunch([NativeTypeName("const GUID &")] Guid* rguidApplID, ApplicationType appType)
        {
            return ((delegate* stdcall<ISurrogateService*, Guid*, ApplicationType, int>)(lpVtbl[4]))((ISurrogateService*)Unsafe.AsPointer(ref this), rguidApplID, appType);
        }

        [return: NativeTypeName("HRESULT")]
        public int ApplicationFree([NativeTypeName("const GUID &")] Guid* rguidApplID)
        {
            return ((delegate* stdcall<ISurrogateService*, Guid*, int>)(lpVtbl[5]))((ISurrogateService*)Unsafe.AsPointer(ref this), rguidApplID);
        }

        [return: NativeTypeName("HRESULT")]
        public int CatalogRefresh([NativeTypeName("ULONG")] uint ulReserved)
        {
            return ((delegate* stdcall<ISurrogateService*, uint, int>)(lpVtbl[6]))((ISurrogateService*)Unsafe.AsPointer(ref this), ulReserved);
        }

        [return: NativeTypeName("HRESULT")]
        public int ProcessShutdown(ShutdownType shutdownType)
        {
            return ((delegate* stdcall<ISurrogateService*, ShutdownType, int>)(lpVtbl[7]))((ISurrogateService*)Unsafe.AsPointer(ref this), shutdownType);
        }
    }
}
