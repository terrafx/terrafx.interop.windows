// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("75575070-01D3-489A-9325-52F9CC6EDE0A")]
    [NativeTypeName("struct IAppDiagnosticInfoWatcher : IInspectable")]
    public unsafe partial struct IAppDiagnosticInfoWatcher
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IAppDiagnosticInfoWatcher*, Guid*, void**, int>)(lpVtbl[0]))((IAppDiagnosticInfoWatcher*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAppDiagnosticInfoWatcher*, uint>)(lpVtbl[1]))((IAppDiagnosticInfoWatcher*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAppDiagnosticInfoWatcher*, uint>)(lpVtbl[2]))((IAppDiagnosticInfoWatcher*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IAppDiagnosticInfoWatcher*, uint*, Guid**, int>)(lpVtbl[3]))((IAppDiagnosticInfoWatcher*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IAppDiagnosticInfoWatcher*, IntPtr*, int>)(lpVtbl[4]))((IAppDiagnosticInfoWatcher*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IAppDiagnosticInfoWatcher*, TrustLevel*, int>)(lpVtbl[5]))((IAppDiagnosticInfoWatcher*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int add_Added([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CSystem__CAppDiagnosticInfoWatcher_Windows__CSystem__CAppDiagnosticInfoWatcherEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, [NativeTypeName("EventRegistrationToken *")] EventRegistrationToken* token)
        {
            return ((delegate* unmanaged<IAppDiagnosticInfoWatcher*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[6]))((IAppDiagnosticInfoWatcher*)Unsafe.AsPointer(ref this), handler, token);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int remove_Added(EventRegistrationToken token)
        {
            return ((delegate* unmanaged<IAppDiagnosticInfoWatcher*, EventRegistrationToken, int>)(lpVtbl[7]))((IAppDiagnosticInfoWatcher*)Unsafe.AsPointer(ref this), token);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int add_Removed([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CSystem__CAppDiagnosticInfoWatcher_Windows__CSystem__CAppDiagnosticInfoWatcherEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, [NativeTypeName("EventRegistrationToken *")] EventRegistrationToken* token)
        {
            return ((delegate* unmanaged<IAppDiagnosticInfoWatcher*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[8]))((IAppDiagnosticInfoWatcher*)Unsafe.AsPointer(ref this), handler, token);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int remove_Removed(EventRegistrationToken token)
        {
            return ((delegate* unmanaged<IAppDiagnosticInfoWatcher*, EventRegistrationToken, int>)(lpVtbl[9]))((IAppDiagnosticInfoWatcher*)Unsafe.AsPointer(ref this), token);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int add_EnumerationCompleted([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CSystem__CAppDiagnosticInfoWatcher_IInspectable_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, [NativeTypeName("EventRegistrationToken *")] EventRegistrationToken* token)
        {
            return ((delegate* unmanaged<IAppDiagnosticInfoWatcher*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[10]))((IAppDiagnosticInfoWatcher*)Unsafe.AsPointer(ref this), handler, token);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int remove_EnumerationCompleted(EventRegistrationToken token)
        {
            return ((delegate* unmanaged<IAppDiagnosticInfoWatcher*, EventRegistrationToken, int>)(lpVtbl[11]))((IAppDiagnosticInfoWatcher*)Unsafe.AsPointer(ref this), token);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int add_Stopped([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CSystem__CAppDiagnosticInfoWatcher_IInspectable_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, [NativeTypeName("EventRegistrationToken *")] EventRegistrationToken* token)
        {
            return ((delegate* unmanaged<IAppDiagnosticInfoWatcher*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[12]))((IAppDiagnosticInfoWatcher*)Unsafe.AsPointer(ref this), handler, token);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int remove_Stopped(EventRegistrationToken token)
        {
            return ((delegate* unmanaged<IAppDiagnosticInfoWatcher*, EventRegistrationToken, int>)(lpVtbl[13]))((IAppDiagnosticInfoWatcher*)Unsafe.AsPointer(ref this), token);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Status([NativeTypeName("ABI::Windows::System::AppDiagnosticInfoWatcherStatus *")] AppDiagnosticInfoWatcherStatus* value)
        {
            return ((delegate* unmanaged<IAppDiagnosticInfoWatcher*, AppDiagnosticInfoWatcherStatus*, int>)(lpVtbl[14]))((IAppDiagnosticInfoWatcher*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Start()
        {
            return ((delegate* unmanaged<IAppDiagnosticInfoWatcher*, int>)(lpVtbl[15]))((IAppDiagnosticInfoWatcher*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Stop()
        {
            return ((delegate* unmanaged<IAppDiagnosticInfoWatcher*, int>)(lpVtbl[16]))((IAppDiagnosticInfoWatcher*)Unsafe.AsPointer(ref this));
        }
    }
}
