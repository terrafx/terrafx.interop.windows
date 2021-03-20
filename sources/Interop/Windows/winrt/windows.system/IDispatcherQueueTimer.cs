// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("5FEABB1D-A31C-4727-B1AC-37454649D56A")]
    [NativeTypeName("struct IDispatcherQueueTimer : IInspectable")]
    public unsafe partial struct IDispatcherQueueTimer
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IDispatcherQueueTimer*, Guid*, void**, int>)(lpVtbl[0]))((IDispatcherQueueTimer*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDispatcherQueueTimer*, uint>)(lpVtbl[1]))((IDispatcherQueueTimer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDispatcherQueueTimer*, uint>)(lpVtbl[2]))((IDispatcherQueueTimer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IDispatcherQueueTimer*, uint*, Guid**, int>)(lpVtbl[3]))((IDispatcherQueueTimer*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IDispatcherQueueTimer*, IntPtr*, int>)(lpVtbl[4]))((IDispatcherQueueTimer*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IDispatcherQueueTimer*, TrustLevel*, int>)(lpVtbl[5]))((IDispatcherQueueTimer*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Interval([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value)
        {
            return ((delegate* unmanaged<IDispatcherQueueTimer*, TimeSpan*, int>)(lpVtbl[6]))((IDispatcherQueueTimer*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_Interval([NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan value)
        {
            return ((delegate* unmanaged<IDispatcherQueueTimer*, TimeSpan, int>)(lpVtbl[7]))((IDispatcherQueueTimer*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_IsRunning([NativeTypeName("boolean *")] byte* value)
        {
            return ((delegate* unmanaged<IDispatcherQueueTimer*, byte*, int>)(lpVtbl[8]))((IDispatcherQueueTimer*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_IsRepeating([NativeTypeName("boolean *")] byte* value)
        {
            return ((delegate* unmanaged<IDispatcherQueueTimer*, byte*, int>)(lpVtbl[9]))((IDispatcherQueueTimer*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_IsRepeating([NativeTypeName("boolean")] byte value)
        {
            return ((delegate* unmanaged<IDispatcherQueueTimer*, byte, int>)(lpVtbl[10]))((IDispatcherQueueTimer*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Start()
        {
            return ((delegate* unmanaged<IDispatcherQueueTimer*, int>)(lpVtbl[11]))((IDispatcherQueueTimer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Stop()
        {
            return ((delegate* unmanaged<IDispatcherQueueTimer*, int>)(lpVtbl[12]))((IDispatcherQueueTimer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int add_Tick([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CSystem__CDispatcherQueueTimer_IInspectable_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, [NativeTypeName("EventRegistrationToken *")] EventRegistrationToken* token)
        {
            return ((delegate* unmanaged<IDispatcherQueueTimer*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[13]))((IDispatcherQueueTimer*)Unsafe.AsPointer(ref this), handler, token);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int remove_Tick(EventRegistrationToken token)
        {
            return ((delegate* unmanaged<IDispatcherQueueTimer*, EventRegistrationToken, int>)(lpVtbl[14]))((IDispatcherQueueTimer*)Unsafe.AsPointer(ref this), token);
        }
    }
}
