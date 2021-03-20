// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/Windows.ApplicationModel.core.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("998681FB-1AB6-4B7F-BE4A-9A0645224C04")]
    [NativeTypeName("struct ICoreApplication2 : IInspectable")]
    public unsafe partial struct ICoreApplication2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<ICoreApplication2*, Guid*, void**, int>)(lpVtbl[0]))((ICoreApplication2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ICoreApplication2*, uint>)(lpVtbl[1]))((ICoreApplication2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ICoreApplication2*, uint>)(lpVtbl[2]))((ICoreApplication2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<ICoreApplication2*, uint*, Guid**, int>)(lpVtbl[3]))((ICoreApplication2*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<ICoreApplication2*, IntPtr*, int>)(lpVtbl[4]))((ICoreApplication2*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<ICoreApplication2*, TrustLevel*, int>)(lpVtbl[5]))((ICoreApplication2*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int add_BackgroundActivated([NativeTypeName("ABI::Windows::Foundation::__FIEventHandler_1_Windows__CApplicationModel__CActivation__CBackgroundActivatedEventArgs_t *")] IEventHandler<IntPtr>* handler, [NativeTypeName("EventRegistrationToken *")] EventRegistrationToken* token)
        {
            return ((delegate* unmanaged<ICoreApplication2*, IEventHandler<IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[6]))((ICoreApplication2*)Unsafe.AsPointer(ref this), handler, token);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int remove_BackgroundActivated(EventRegistrationToken token)
        {
            return ((delegate* unmanaged<ICoreApplication2*, EventRegistrationToken, int>)(lpVtbl[7]))((ICoreApplication2*)Unsafe.AsPointer(ref this), token);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int add_LeavingBackground([NativeTypeName("ABI::Windows::Foundation::__FIEventHandler_1_Windows__CApplicationModel__CLeavingBackgroundEventArgs_t *")] IEventHandler<IntPtr>* handler, [NativeTypeName("EventRegistrationToken *")] EventRegistrationToken* token)
        {
            return ((delegate* unmanaged<ICoreApplication2*, IEventHandler<IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[8]))((ICoreApplication2*)Unsafe.AsPointer(ref this), handler, token);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int remove_LeavingBackground(EventRegistrationToken token)
        {
            return ((delegate* unmanaged<ICoreApplication2*, EventRegistrationToken, int>)(lpVtbl[9]))((ICoreApplication2*)Unsafe.AsPointer(ref this), token);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int add_EnteredBackground([NativeTypeName("ABI::Windows::Foundation::__FIEventHandler_1_Windows__CApplicationModel__CEnteredBackgroundEventArgs_t *")] IEventHandler<IntPtr>* handler, [NativeTypeName("EventRegistrationToken *")] EventRegistrationToken* token)
        {
            return ((delegate* unmanaged<ICoreApplication2*, IEventHandler<IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[10]))((ICoreApplication2*)Unsafe.AsPointer(ref this), handler, token);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int remove_EnteredBackground(EventRegistrationToken token)
        {
            return ((delegate* unmanaged<ICoreApplication2*, EventRegistrationToken, int>)(lpVtbl[11]))((ICoreApplication2*)Unsafe.AsPointer(ref this), token);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int EnablePrelaunch([NativeTypeName("boolean")] byte value)
        {
            return ((delegate* unmanaged<ICoreApplication2*, byte, int>)(lpVtbl[12]))((ICoreApplication2*)Unsafe.AsPointer(ref this), value);
        }
    }
}
