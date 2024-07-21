// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ICoreApplication.xml' path='doc/member[@name="ICoreApplication"]/*' />
[Guid("0AACF7A4-5E1D-49DF-8034-FB6A68BC5ED1")]
[NativeTypeName("struct ICoreApplication : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICoreApplication : ICoreApplication.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICoreApplication));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreApplication*, Guid*, void**, int>)(lpVtbl[0]))((ICoreApplication*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreApplication*, uint>)(lpVtbl[1]))((ICoreApplication*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreApplication*, uint>)(lpVtbl[2]))((ICoreApplication*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreApplication*, uint*, Guid**, int>)(lpVtbl[3]))((ICoreApplication*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreApplication*, HSTRING*, int>)(lpVtbl[4]))((ICoreApplication*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreApplication*, TrustLevel*, int>)(lpVtbl[5]))((ICoreApplication*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ICoreApplication.xml' path='doc/member[@name="ICoreApplication.get_Id"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Id(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreApplication*, HSTRING*, int>)(lpVtbl[6]))((ICoreApplication*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICoreApplication.xml' path='doc/member[@name="ICoreApplication.add_Suspending"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT add_Suspending([NativeTypeName("ABI::Windows::Foundation::__FIEventHandler_1_Windows__CApplicationModel__CSuspendingEventArgs_t *")] IEventHandler<Pointer<ISuspendingEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreApplication*, IEventHandler<Pointer<ISuspendingEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[7]))((ICoreApplication*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='ICoreApplication.xml' path='doc/member[@name="ICoreApplication.remove_Suspending"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT remove_Suspending(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreApplication*, EventRegistrationToken, int>)(lpVtbl[8]))((ICoreApplication*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='ICoreApplication.xml' path='doc/member[@name="ICoreApplication.add_Resuming"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT add_Resuming([NativeTypeName("ABI::Windows::Foundation::__FIEventHandler_1_IInspectable_t *")] IEventHandler<Pointer<IInspectable>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreApplication*, IEventHandler<Pointer<IInspectable>>*, EventRegistrationToken*, int>)(lpVtbl[9]))((ICoreApplication*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='ICoreApplication.xml' path='doc/member[@name="ICoreApplication.remove_Resuming"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT remove_Resuming(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreApplication*, EventRegistrationToken, int>)(lpVtbl[10]))((ICoreApplication*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='ICoreApplication.xml' path='doc/member[@name="ICoreApplication.get_Properties"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_Properties([NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet **")] IPropertySet** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreApplication*, IPropertySet**, int>)(lpVtbl[11]))((ICoreApplication*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICoreApplication.xml' path='doc/member[@name="ICoreApplication.GetCurrentView"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetCurrentView([NativeTypeName("ABI::Windows::ApplicationModel::Core::ICoreApplicationView **")] ICoreApplicationView** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreApplication*, ICoreApplicationView**, int>)(lpVtbl[12]))((ICoreApplication*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICoreApplication.xml' path='doc/member[@name="ICoreApplication.Run"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT Run([NativeTypeName("ABI::Windows::ApplicationModel::Core::IFrameworkViewSource *")] IFrameworkViewSource* viewSource)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreApplication*, IFrameworkViewSource*, int>)(lpVtbl[13]))((ICoreApplication*)Unsafe.AsPointer(ref this), viewSource);
    }

    /// <include file='ICoreApplication.xml' path='doc/member[@name="ICoreApplication.RunWithActivationFactories"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT RunWithActivationFactories([NativeTypeName("ABI::Windows::Foundation::IGetActivationFactory *")] IGetActivationFactory* activationFactoryCallback)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreApplication*, IGetActivationFactory*, int>)(lpVtbl[14]))((ICoreApplication*)Unsafe.AsPointer(ref this), activationFactoryCallback);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Id(HSTRING* value);

        [VtblIndex(7)]
        HRESULT add_Suspending([NativeTypeName("ABI::Windows::Foundation::__FIEventHandler_1_Windows__CApplicationModel__CSuspendingEventArgs_t *")] IEventHandler<Pointer<ISuspendingEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(8)]
        HRESULT remove_Suspending(EventRegistrationToken token);

        [VtblIndex(9)]
        HRESULT add_Resuming([NativeTypeName("ABI::Windows::Foundation::__FIEventHandler_1_IInspectable_t *")] IEventHandler<Pointer<IInspectable>>* handler, EventRegistrationToken* token);

        [VtblIndex(10)]
        HRESULT remove_Resuming(EventRegistrationToken token);

        [VtblIndex(11)]
        HRESULT get_Properties([NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet **")] IPropertySet** value);

        [VtblIndex(12)]
        HRESULT GetCurrentView([NativeTypeName("ABI::Windows::ApplicationModel::Core::ICoreApplicationView **")] ICoreApplicationView** value);

        [VtblIndex(13)]
        HRESULT Run([NativeTypeName("ABI::Windows::ApplicationModel::Core::IFrameworkViewSource *")] IFrameworkViewSource* viewSource);

        [VtblIndex(14)]
        HRESULT RunWithActivationFactories([NativeTypeName("ABI::Windows::Foundation::IGetActivationFactory *")] IGetActivationFactory* activationFactoryCallback);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

        [NativeTypeName("HRESULT (ULONG *, IID **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, Guid**, int> GetIids;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> GetRuntimeClassName;

        [NativeTypeName("HRESULT (TrustLevel *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TrustLevel*, int> GetTrustLevel;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Id;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIEventHandler_1_Windows__CApplicationModel__CSuspendingEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IEventHandler<Pointer<ISuspendingEventArgs>>*, EventRegistrationToken*, int> add_Suspending;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_Suspending;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIEventHandler_1_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IEventHandler<Pointer<IInspectable>>*, EventRegistrationToken*, int> add_Resuming;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_Resuming;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::IPropertySet **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IPropertySet**, int> get_Properties;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Core::ICoreApplicationView **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ICoreApplicationView**, int> GetCurrentView;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Core::IFrameworkViewSource *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IFrameworkViewSource*, int> Run;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IGetActivationFactory *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IGetActivationFactory*, int> RunWithActivationFactories;
    }
}
