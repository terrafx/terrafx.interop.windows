// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/IContentPrefetcherTaskTrigger.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("1B35A14A-6094-4799-A60E-E474E15D4DC9")]
    [NativeTypeName("struct IContentPrefetcherTaskTrigger : IInspectable")]
    public unsafe partial struct IContentPrefetcherTaskTrigger
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IContentPrefetcherTaskTrigger*, Guid*, void**, int>)(lpVtbl[0]))((IContentPrefetcherTaskTrigger*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IContentPrefetcherTaskTrigger*, uint>)(lpVtbl[1]))((IContentPrefetcherTaskTrigger*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IContentPrefetcherTaskTrigger*, uint>)(lpVtbl[2]))((IContentPrefetcherTaskTrigger*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged[Stdcall]<IContentPrefetcherTaskTrigger*, uint*, Guid**, int>)(lpVtbl[3]))((IContentPrefetcherTaskTrigger*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged[Stdcall]<IContentPrefetcherTaskTrigger*, IntPtr*, int>)(lpVtbl[4]))((IContentPrefetcherTaskTrigger*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged[Stdcall]<IContentPrefetcherTaskTrigger*, TrustLevel*, int>)(lpVtbl[5]))((IContentPrefetcherTaskTrigger*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int TriggerContentPrefetcherTask([NativeTypeName("LPCWSTR")] ushort* packageFullName)
        {
            return ((delegate* unmanaged[Stdcall]<IContentPrefetcherTaskTrigger*, ushort*, int>)(lpVtbl[6]))((IContentPrefetcherTaskTrigger*)Unsafe.AsPointer(ref this), packageFullName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int IsRegisteredForContentPrefetch([NativeTypeName("LPCWSTR")] ushort* packageFullName, [NativeTypeName("boolean *")] byte* isRegistered)
        {
            return ((delegate* unmanaged[Stdcall]<IContentPrefetcherTaskTrigger*, ushort*, byte*, int>)(lpVtbl[7]))((IContentPrefetcherTaskTrigger*)Unsafe.AsPointer(ref this), packageFullName, isRegistered);
        }
    }
}
