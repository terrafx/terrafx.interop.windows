// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/Windows.ApplicationModel.core.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("0AACF7A4-5E1D-49DF-8034-FB6A68BC5ED1")]
    [NativeTypeName("struct ICoreApplication : IInspectable")]
    public unsafe partial struct ICoreApplication
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<ICoreApplication*, Guid*, void**, int>)(lpVtbl[0]))((ICoreApplication*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ICoreApplication*, uint>)(lpVtbl[1]))((ICoreApplication*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ICoreApplication*, uint>)(lpVtbl[2]))((ICoreApplication*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<ICoreApplication*, uint*, Guid**, int>)(lpVtbl[3]))((ICoreApplication*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<ICoreApplication*, IntPtr*, int>)(lpVtbl[4]))((ICoreApplication*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<ICoreApplication*, TrustLevel*, int>)(lpVtbl[5]))((ICoreApplication*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Id([NativeTypeName("HSTRING *")] IntPtr* value)
        {
            return ((delegate* unmanaged<ICoreApplication*, IntPtr*, int>)(lpVtbl[6]))((ICoreApplication*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int add_Suspending([NativeTypeName("ABI::Windows::Foundation::__FIEventHandler_1_Windows__CApplicationModel__CSuspendingEventArgs_t *")] IEventHandler<IntPtr>* handler, [NativeTypeName("EventRegistrationToken *")] EventRegistrationToken* token)
        {
            return ((delegate* unmanaged<ICoreApplication*, IEventHandler<IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[7]))((ICoreApplication*)Unsafe.AsPointer(ref this), handler, token);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int remove_Suspending(EventRegistrationToken token)
        {
            return ((delegate* unmanaged<ICoreApplication*, EventRegistrationToken, int>)(lpVtbl[8]))((ICoreApplication*)Unsafe.AsPointer(ref this), token);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int add_Resuming([NativeTypeName("ABI::Windows::Foundation::__FIEventHandler_1_IInspectable_t *")] IEventHandler<IntPtr>* handler, [NativeTypeName("EventRegistrationToken *")] EventRegistrationToken* token)
        {
            return ((delegate* unmanaged<ICoreApplication*, IEventHandler<IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[9]))((ICoreApplication*)Unsafe.AsPointer(ref this), handler, token);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int remove_Resuming(EventRegistrationToken token)
        {
            return ((delegate* unmanaged<ICoreApplication*, EventRegistrationToken, int>)(lpVtbl[10]))((ICoreApplication*)Unsafe.AsPointer(ref this), token);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Properties([NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet **")] IPropertySet** value)
        {
            return ((delegate* unmanaged<ICoreApplication*, IPropertySet**, int>)(lpVtbl[11]))((ICoreApplication*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCurrentView([NativeTypeName("ABI::Windows::ApplicationModel::Core::ICoreApplicationView **")] ICoreApplicationView** value)
        {
            return ((delegate* unmanaged<ICoreApplication*, ICoreApplicationView**, int>)(lpVtbl[12]))((ICoreApplication*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Run([NativeTypeName("ABI::Windows::ApplicationModel::Core::IFrameworkViewSource *")] IFrameworkViewSource* viewSource)
        {
            return ((delegate* unmanaged<ICoreApplication*, IFrameworkViewSource*, int>)(lpVtbl[13]))((ICoreApplication*)Unsafe.AsPointer(ref this), viewSource);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RunWithActivationFactories([NativeTypeName("ABI::Windows::Foundation::IGetActivationFactory *")] IGetActivationFactory* activationFactoryCallback)
        {
            return ((delegate* unmanaged<ICoreApplication*, IGetActivationFactory*, int>)(lpVtbl[14]))((ICoreApplication*)Unsafe.AsPointer(ref this), activationFactoryCallback);
        }
    }
}
