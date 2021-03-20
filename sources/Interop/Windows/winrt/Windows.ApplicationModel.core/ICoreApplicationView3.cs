// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/Windows.ApplicationModel.core.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("07EBE1B3-A4CF-4550-AB70-B07E85330BC8")]
    [NativeTypeName("struct ICoreApplicationView3 : IInspectable")]
    public unsafe partial struct ICoreApplicationView3
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<ICoreApplicationView3*, Guid*, void**, int>)(lpVtbl[0]))((ICoreApplicationView3*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ICoreApplicationView3*, uint>)(lpVtbl[1]))((ICoreApplicationView3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ICoreApplicationView3*, uint>)(lpVtbl[2]))((ICoreApplicationView3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<ICoreApplicationView3*, uint*, Guid**, int>)(lpVtbl[3]))((ICoreApplicationView3*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<ICoreApplicationView3*, IntPtr*, int>)(lpVtbl[4]))((ICoreApplicationView3*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<ICoreApplicationView3*, TrustLevel*, int>)(lpVtbl[5]))((ICoreApplicationView3*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_IsComponent([NativeTypeName("boolean *")] byte* value)
        {
            return ((delegate* unmanaged<ICoreApplicationView3*, byte*, int>)(lpVtbl[6]))((ICoreApplicationView3*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_TitleBar([NativeTypeName("ABI::Windows::ApplicationModel::Core::ICoreApplicationViewTitleBar **")] ICoreApplicationViewTitleBar** value)
        {
            return ((delegate* unmanaged<ICoreApplicationView3*, ICoreApplicationViewTitleBar**, int>)(lpVtbl[7]))((ICoreApplicationView3*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int add_HostedViewClosing([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CCore__CCoreApplicationView_Windows__CApplicationModel__CCore__CHostedViewClosingEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, [NativeTypeName("EventRegistrationToken *")] EventRegistrationToken* token)
        {
            return ((delegate* unmanaged<ICoreApplicationView3*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[8]))((ICoreApplicationView3*)Unsafe.AsPointer(ref this), handler, token);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int remove_HostedViewClosing(EventRegistrationToken token)
        {
            return ((delegate* unmanaged<ICoreApplicationView3*, EventRegistrationToken, int>)(lpVtbl[9]))((ICoreApplicationView3*)Unsafe.AsPointer(ref this), token);
        }
    }
}
