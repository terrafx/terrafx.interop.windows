// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.windowmanagement.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IWindowingEnvironmentStatics.xml' path='doc/member[@name="IWindowingEnvironmentStatics"]/*' />
[Guid("874E9FB7-C642-55AB-8AA2-162F734A9A72")]
[NativeTypeName("struct IWindowingEnvironmentStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IWindowingEnvironmentStatics : IWindowingEnvironmentStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWindowingEnvironmentStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IWindowingEnvironmentStatics*, Guid*, void**, int>)(lpVtbl[0]))((IWindowingEnvironmentStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IWindowingEnvironmentStatics*, uint>)(lpVtbl[1]))((IWindowingEnvironmentStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IWindowingEnvironmentStatics*, uint>)(lpVtbl[2]))((IWindowingEnvironmentStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IWindowingEnvironmentStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IWindowingEnvironmentStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IWindowingEnvironmentStatics*, HSTRING*, int>)(lpVtbl[4]))((IWindowingEnvironmentStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IWindowingEnvironmentStatics*, TrustLevel*, int>)(lpVtbl[5]))((IWindowingEnvironmentStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IWindowingEnvironmentStatics.xml' path='doc/member[@name="IWindowingEnvironmentStatics.FindAll"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT FindAll([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CUI__CWindowManagement__CWindowingEnvironment_t **")] IVectorView<IntPtr>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IWindowingEnvironmentStatics*, IVectorView<IntPtr>**, int>)(lpVtbl[6]))((IWindowingEnvironmentStatics*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='IWindowingEnvironmentStatics.xml' path='doc/member[@name="IWindowingEnvironmentStatics.FindAllWithKind"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT FindAllWithKind([NativeTypeName("ABI::Windows::UI::WindowManagement::WindowingEnvironmentKind")] WindowingEnvironmentKind kind, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CUI__CWindowManagement__CWindowingEnvironment_t **")] IVectorView<IntPtr>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IWindowingEnvironmentStatics*, WindowingEnvironmentKind, IVectorView<IntPtr>**, int>)(lpVtbl[7]))((IWindowingEnvironmentStatics*)Unsafe.AsPointer(ref this), kind, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT FindAll([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CUI__CWindowManagement__CWindowingEnvironment_t **")] IVectorView<IntPtr>** result);

        [VtblIndex(7)]
        HRESULT FindAllWithKind([NativeTypeName("ABI::Windows::UI::WindowManagement::WindowingEnvironmentKind")] WindowingEnvironmentKind kind, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CUI__CWindowManagement__CWindowingEnvironment_t **")] IVectorView<IntPtr>** result);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CUI__CWindowManagement__CWindowingEnvironment_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVectorView<IntPtr>**, int> FindAll;

        [NativeTypeName("HRESULT (ABI::Windows::UI::WindowManagement::WindowingEnvironmentKind, ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CUI__CWindowManagement__CWindowingEnvironment_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, WindowingEnvironmentKind, IVectorView<IntPtr>**, int> FindAllWithKind;
    }
}
