// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("603E88E4-A338-4FFE-A457-A5CFB9CEB899")]
    [NativeTypeName("struct IDispatcherQueue : IInspectable")]
    public unsafe partial struct IDispatcherQueue
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IDispatcherQueue*, Guid*, void**, int>)(lpVtbl[0]))((IDispatcherQueue*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDispatcherQueue*, uint>)(lpVtbl[1]))((IDispatcherQueue*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDispatcherQueue*, uint>)(lpVtbl[2]))((IDispatcherQueue*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IDispatcherQueue*, uint*, Guid**, int>)(lpVtbl[3]))((IDispatcherQueue*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IDispatcherQueue*, IntPtr*, int>)(lpVtbl[4]))((IDispatcherQueue*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IDispatcherQueue*, TrustLevel*, int>)(lpVtbl[5]))((IDispatcherQueue*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateTimer([NativeTypeName("ABI::Windows::System::IDispatcherQueueTimer **")] IDispatcherQueueTimer** result)
        {
            return ((delegate* unmanaged<IDispatcherQueue*, IDispatcherQueueTimer**, int>)(lpVtbl[6]))((IDispatcherQueue*)Unsafe.AsPointer(ref this), result);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int TryEnqueue([NativeTypeName("ABI::Windows::System::IDispatcherQueueHandler *")] IDispatcherQueueHandler* callback, [NativeTypeName("boolean *")] byte* result)
        {
            return ((delegate* unmanaged<IDispatcherQueue*, IDispatcherQueueHandler*, byte*, int>)(lpVtbl[7]))((IDispatcherQueue*)Unsafe.AsPointer(ref this), callback, result);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int TryEnqueueWithPriority([NativeTypeName("ABI::Windows::System::DispatcherQueuePriority")] DispatcherQueuePriority priority, [NativeTypeName("ABI::Windows::System::IDispatcherQueueHandler *")] IDispatcherQueueHandler* callback, [NativeTypeName("boolean *")] byte* result)
        {
            return ((delegate* unmanaged<IDispatcherQueue*, DispatcherQueuePriority, IDispatcherQueueHandler*, byte*, int>)(lpVtbl[8]))((IDispatcherQueue*)Unsafe.AsPointer(ref this), priority, callback, result);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int add_ShutdownStarting([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CSystem__CDispatcherQueue_Windows__CSystem__CDispatcherQueueShutdownStartingEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, [NativeTypeName("EventRegistrationToken *")] EventRegistrationToken* token)
        {
            return ((delegate* unmanaged<IDispatcherQueue*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[9]))((IDispatcherQueue*)Unsafe.AsPointer(ref this), handler, token);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int remove_ShutdownStarting(EventRegistrationToken token)
        {
            return ((delegate* unmanaged<IDispatcherQueue*, EventRegistrationToken, int>)(lpVtbl[10]))((IDispatcherQueue*)Unsafe.AsPointer(ref this), token);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int add_ShutdownCompleted([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CSystem__CDispatcherQueue_IInspectable_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, [NativeTypeName("EventRegistrationToken *")] EventRegistrationToken* token)
        {
            return ((delegate* unmanaged<IDispatcherQueue*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[11]))((IDispatcherQueue*)Unsafe.AsPointer(ref this), handler, token);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int remove_ShutdownCompleted(EventRegistrationToken token)
        {
            return ((delegate* unmanaged<IDispatcherQueue*, EventRegistrationToken, int>)(lpVtbl[12]))((IDispatcherQueue*)Unsafe.AsPointer(ref this), token);
        }
    }
}
