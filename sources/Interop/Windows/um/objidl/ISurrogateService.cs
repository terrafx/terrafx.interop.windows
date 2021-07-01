// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/objidl.h in the Windows SDK for Windows 10.0.20348.0
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

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISurrogateService*, Guid*, void**, int>)(lpVtbl[0]))((ISurrogateService*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISurrogateService*, uint>)(lpVtbl[1]))((ISurrogateService*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISurrogateService*, uint>)(lpVtbl[2]))((ISurrogateService*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Init([NativeTypeName("const GUID &")] Guid* rguidProcessID, IProcessLock* pProcessLock, [NativeTypeName("BOOL *")] int* pfApplicationAware)
        {
            return ((delegate* unmanaged<ISurrogateService*, Guid*, IProcessLock*, int*, int>)(lpVtbl[3]))((ISurrogateService*)Unsafe.AsPointer(ref this), rguidProcessID, pProcessLock, pfApplicationAware);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ApplicationLaunch([NativeTypeName("const GUID &")] Guid* rguidApplID, ApplicationType appType)
        {
            return ((delegate* unmanaged<ISurrogateService*, Guid*, ApplicationType, int>)(lpVtbl[4]))((ISurrogateService*)Unsafe.AsPointer(ref this), rguidApplID, appType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ApplicationFree([NativeTypeName("const GUID &")] Guid* rguidApplID)
        {
            return ((delegate* unmanaged<ISurrogateService*, Guid*, int>)(lpVtbl[5]))((ISurrogateService*)Unsafe.AsPointer(ref this), rguidApplID);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CatalogRefresh([NativeTypeName("ULONG")] uint ulReserved)
        {
            return ((delegate* unmanaged<ISurrogateService*, uint, int>)(lpVtbl[6]))((ISurrogateService*)Unsafe.AsPointer(ref this), ulReserved);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ProcessShutdown(ShutdownType shutdownType)
        {
            return ((delegate* unmanaged<ISurrogateService*, ShutdownType, int>)(lpVtbl[7]))((ISurrogateService*)Unsafe.AsPointer(ref this), shutdownType);
        }
    }
}
