// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("5C6C279C-D7CA-4779-9188-4057219CE64C")]
    [NativeTypeName("struct IMemoryManagerStatics : IInspectable")]
    public unsafe partial struct IMemoryManagerStatics
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IMemoryManagerStatics*, Guid*, void**, int>)(lpVtbl[0]))((IMemoryManagerStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMemoryManagerStatics*, uint>)(lpVtbl[1]))((IMemoryManagerStatics*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMemoryManagerStatics*, uint>)(lpVtbl[2]))((IMemoryManagerStatics*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IMemoryManagerStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IMemoryManagerStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IMemoryManagerStatics*, IntPtr*, int>)(lpVtbl[4]))((IMemoryManagerStatics*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IMemoryManagerStatics*, TrustLevel*, int>)(lpVtbl[5]))((IMemoryManagerStatics*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_AppMemoryUsage([NativeTypeName("UINT64 *")] ulong* value)
        {
            return ((delegate* unmanaged<IMemoryManagerStatics*, ulong*, int>)(lpVtbl[6]))((IMemoryManagerStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_AppMemoryUsageLimit([NativeTypeName("UINT64 *")] ulong* value)
        {
            return ((delegate* unmanaged<IMemoryManagerStatics*, ulong*, int>)(lpVtbl[7]))((IMemoryManagerStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_AppMemoryUsageLevel([NativeTypeName("ABI::Windows::System::AppMemoryUsageLevel *")] AppMemoryUsageLevel* value)
        {
            return ((delegate* unmanaged<IMemoryManagerStatics*, AppMemoryUsageLevel*, int>)(lpVtbl[8]))((IMemoryManagerStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int add_AppMemoryUsageIncreased([NativeTypeName("ABI::Windows::Foundation::__FIEventHandler_1_IInspectable_t *")] IEventHandler<IntPtr>* handler, [NativeTypeName("EventRegistrationToken *")] EventRegistrationToken* token)
        {
            return ((delegate* unmanaged<IMemoryManagerStatics*, IEventHandler<IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[9]))((IMemoryManagerStatics*)Unsafe.AsPointer(ref this), handler, token);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int remove_AppMemoryUsageIncreased(EventRegistrationToken token)
        {
            return ((delegate* unmanaged<IMemoryManagerStatics*, EventRegistrationToken, int>)(lpVtbl[10]))((IMemoryManagerStatics*)Unsafe.AsPointer(ref this), token);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int add_AppMemoryUsageDecreased([NativeTypeName("ABI::Windows::Foundation::__FIEventHandler_1_IInspectable_t *")] IEventHandler<IntPtr>* handler, [NativeTypeName("EventRegistrationToken *")] EventRegistrationToken* token)
        {
            return ((delegate* unmanaged<IMemoryManagerStatics*, IEventHandler<IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[11]))((IMemoryManagerStatics*)Unsafe.AsPointer(ref this), handler, token);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int remove_AppMemoryUsageDecreased(EventRegistrationToken token)
        {
            return ((delegate* unmanaged<IMemoryManagerStatics*, EventRegistrationToken, int>)(lpVtbl[12]))((IMemoryManagerStatics*)Unsafe.AsPointer(ref this), token);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int add_AppMemoryUsageLimitChanging([NativeTypeName("ABI::Windows::Foundation::__FIEventHandler_1_Windows__CSystem__CAppMemoryUsageLimitChangingEventArgs_t *")] IEventHandler<IntPtr>* handler, [NativeTypeName("EventRegistrationToken *")] EventRegistrationToken* token)
        {
            return ((delegate* unmanaged<IMemoryManagerStatics*, IEventHandler<IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[13]))((IMemoryManagerStatics*)Unsafe.AsPointer(ref this), handler, token);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int remove_AppMemoryUsageLimitChanging(EventRegistrationToken token)
        {
            return ((delegate* unmanaged<IMemoryManagerStatics*, EventRegistrationToken, int>)(lpVtbl[14]))((IMemoryManagerStatics*)Unsafe.AsPointer(ref this), token);
        }
    }
}
