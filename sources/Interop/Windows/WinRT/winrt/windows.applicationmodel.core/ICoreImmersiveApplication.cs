// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ICoreImmersiveApplication.xml' path='doc/member[@name="ICoreImmersiveApplication"]/*' />
[Guid("1ADA0E3E-E4A2-4123-B451-DC96BF800419")]
[NativeTypeName("struct ICoreImmersiveApplication : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICoreImmersiveApplication : ICoreImmersiveApplication.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICoreImmersiveApplication));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreImmersiveApplication*, Guid*, void**, int>)(lpVtbl[0]))((ICoreImmersiveApplication*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreImmersiveApplication*, uint>)(lpVtbl[1]))((ICoreImmersiveApplication*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreImmersiveApplication*, uint>)(lpVtbl[2]))((ICoreImmersiveApplication*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreImmersiveApplication*, uint*, Guid**, int>)(lpVtbl[3]))((ICoreImmersiveApplication*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreImmersiveApplication*, HSTRING*, int>)(lpVtbl[4]))((ICoreImmersiveApplication*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreImmersiveApplication*, TrustLevel*, int>)(lpVtbl[5]))((ICoreImmersiveApplication*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ICoreImmersiveApplication.xml' path='doc/member[@name="ICoreImmersiveApplication.get_Views"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Views([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CApplicationModel__CCore__CCoreApplicationView_t **")] IVectorView<Pointer<ICoreApplicationView>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreImmersiveApplication*, IVectorView<Pointer<ICoreApplicationView>>**, int>)(lpVtbl[6]))((ICoreImmersiveApplication*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICoreImmersiveApplication.xml' path='doc/member[@name="ICoreImmersiveApplication.CreateNewView"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateNewView(HSTRING runtimeType, HSTRING entryPoint, [NativeTypeName("ABI::Windows::ApplicationModel::Core::ICoreApplicationView **")] ICoreApplicationView** view)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreImmersiveApplication*, HSTRING, HSTRING, ICoreApplicationView**, int>)(lpVtbl[7]))((ICoreImmersiveApplication*)Unsafe.AsPointer(ref this), runtimeType, entryPoint, view);
    }

    /// <include file='ICoreImmersiveApplication.xml' path='doc/member[@name="ICoreImmersiveApplication.get_MainView"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_MainView([NativeTypeName("ABI::Windows::ApplicationModel::Core::ICoreApplicationView **")] ICoreApplicationView** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreImmersiveApplication*, ICoreApplicationView**, int>)(lpVtbl[8]))((ICoreImmersiveApplication*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Views([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CApplicationModel__CCore__CCoreApplicationView_t **")] IVectorView<Pointer<ICoreApplicationView>>** value);

        [VtblIndex(7)]
        HRESULT CreateNewView(HSTRING runtimeType, HSTRING entryPoint, [NativeTypeName("ABI::Windows::ApplicationModel::Core::ICoreApplicationView **")] ICoreApplicationView** view);

        [VtblIndex(8)]
        HRESULT get_MainView([NativeTypeName("ABI::Windows::ApplicationModel::Core::ICoreApplicationView **")] ICoreApplicationView** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CApplicationModel__CCore__CCoreApplicationView_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVectorView<Pointer<ICoreApplicationView>>**, int> get_Views;

        [NativeTypeName("HRESULT (HSTRING, HSTRING, ABI::Windows::ApplicationModel::Core::ICoreApplicationView **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, HSTRING, ICoreApplicationView**, int> CreateNewView;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Core::ICoreApplicationView **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ICoreApplicationView**, int> get_MainView;
    }
}
