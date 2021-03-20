// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/Windows.ApplicationModel.core.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("638BB2DB-451D-4661-B099-414F34FFB9F1")]
    [NativeTypeName("struct ICoreApplicationView : IInspectable")]
    public unsafe partial struct ICoreApplicationView
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<ICoreApplicationView*, Guid*, void**, int>)(lpVtbl[0]))((ICoreApplicationView*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ICoreApplicationView*, uint>)(lpVtbl[1]))((ICoreApplicationView*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ICoreApplicationView*, uint>)(lpVtbl[2]))((ICoreApplicationView*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<ICoreApplicationView*, uint*, Guid**, int>)(lpVtbl[3]))((ICoreApplicationView*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<ICoreApplicationView*, IntPtr*, int>)(lpVtbl[4]))((ICoreApplicationView*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<ICoreApplicationView*, TrustLevel*, int>)(lpVtbl[5]))((ICoreApplicationView*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_CoreWindow([NativeTypeName("ABI::Windows::UI::Core::ICoreWindow **")] ICoreWindow** value)
        {
            return ((delegate* unmanaged<ICoreApplicationView*, ICoreWindow**, int>)(lpVtbl[6]))((ICoreApplicationView*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int add_Activated([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CCore__CCoreApplicationView_Windows__CApplicationModel__CActivation__CIActivatedEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, [NativeTypeName("EventRegistrationToken *")] EventRegistrationToken* token)
        {
            return ((delegate* unmanaged<ICoreApplicationView*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[7]))((ICoreApplicationView*)Unsafe.AsPointer(ref this), handler, token);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int remove_Activated(EventRegistrationToken token)
        {
            return ((delegate* unmanaged<ICoreApplicationView*, EventRegistrationToken, int>)(lpVtbl[8]))((ICoreApplicationView*)Unsafe.AsPointer(ref this), token);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_IsMain([NativeTypeName("boolean *")] byte* value)
        {
            return ((delegate* unmanaged<ICoreApplicationView*, byte*, int>)(lpVtbl[9]))((ICoreApplicationView*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_IsHosted([NativeTypeName("boolean *")] byte* value)
        {
            return ((delegate* unmanaged<ICoreApplicationView*, byte*, int>)(lpVtbl[10]))((ICoreApplicationView*)Unsafe.AsPointer(ref this), value);
        }
    }
}
