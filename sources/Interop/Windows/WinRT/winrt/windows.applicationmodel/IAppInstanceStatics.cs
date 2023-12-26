// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IAppInstanceStatics.xml' path='doc/member[@name="IAppInstanceStatics"]/*' />
[Guid("9D11E77F-9EA6-47AF-A6EC-46784C5BA254")]
[NativeTypeName("struct IAppInstanceStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAppInstanceStatics : IAppInstanceStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppInstanceStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppInstanceStatics*, Guid*, void**, int>)(lpVtbl[0]))((IAppInstanceStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppInstanceStatics*, uint>)(lpVtbl[1]))((IAppInstanceStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppInstanceStatics*, uint>)(lpVtbl[2]))((IAppInstanceStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppInstanceStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IAppInstanceStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppInstanceStatics*, HSTRING*, int>)(lpVtbl[4]))((IAppInstanceStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppInstanceStatics*, TrustLevel*, int>)(lpVtbl[5]))((IAppInstanceStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IAppInstanceStatics.xml' path='doc/member[@name="IAppInstanceStatics.get_RecommendedInstance"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_RecommendedInstance([NativeTypeName("ABI::Windows::ApplicationModel::IAppInstance **")] IAppInstance** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppInstanceStatics*, IAppInstance**, int>)(lpVtbl[6]))((IAppInstanceStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppInstanceStatics.xml' path='doc/member[@name="IAppInstanceStatics.GetActivatedEventArgs"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetActivatedEventArgs([NativeTypeName("ABI::Windows::ApplicationModel::Activation::IActivatedEventArgs **")] IActivatedEventArgs** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppInstanceStatics*, IActivatedEventArgs**, int>)(lpVtbl[7]))((IAppInstanceStatics*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='IAppInstanceStatics.xml' path='doc/member[@name="IAppInstanceStatics.FindOrRegisterInstanceForKey"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT FindOrRegisterInstanceForKey(HSTRING key, [NativeTypeName("ABI::Windows::ApplicationModel::IAppInstance **")] IAppInstance** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppInstanceStatics*, HSTRING, IAppInstance**, int>)(lpVtbl[8]))((IAppInstanceStatics*)Unsafe.AsPointer(ref this), key, result);
    }

    /// <include file='IAppInstanceStatics.xml' path='doc/member[@name="IAppInstanceStatics.Unregister"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT Unregister()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppInstanceStatics*, int>)(lpVtbl[9]))((IAppInstanceStatics*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAppInstanceStatics.xml' path='doc/member[@name="IAppInstanceStatics.GetInstances"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetInstances([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CApplicationModel__CAppInstance_t **")] IVector<IntPtr>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppInstanceStatics*, IVector<IntPtr>**, int>)(lpVtbl[10]))((IAppInstanceStatics*)Unsafe.AsPointer(ref this), result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_RecommendedInstance([NativeTypeName("ABI::Windows::ApplicationModel::IAppInstance **")] IAppInstance** value);

        [VtblIndex(7)]
        HRESULT GetActivatedEventArgs([NativeTypeName("ABI::Windows::ApplicationModel::Activation::IActivatedEventArgs **")] IActivatedEventArgs** result);

        [VtblIndex(8)]
        HRESULT FindOrRegisterInstanceForKey(HSTRING key, [NativeTypeName("ABI::Windows::ApplicationModel::IAppInstance **")] IAppInstance** result);

        [VtblIndex(9)]
        HRESULT Unregister();

        [VtblIndex(10)]
        HRESULT GetInstances([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CApplicationModel__CAppInstance_t **")] IVector<IntPtr>** result);
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

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::IAppInstance **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAppInstance**, int> get_RecommendedInstance;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Activation::IActivatedEventArgs **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IActivatedEventArgs**, int> GetActivatedEventArgs;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::ApplicationModel::IAppInstance **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IAppInstance**, int> FindOrRegisterInstanceForKey;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> Unregister;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CApplicationModel__CAppInstance_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVector<IntPtr>**, int> GetInstances;
    }
}
