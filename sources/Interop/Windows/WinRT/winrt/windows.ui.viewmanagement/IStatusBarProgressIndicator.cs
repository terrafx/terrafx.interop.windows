// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.viewmanagement.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IStatusBarProgressIndicator.xml' path='doc/member[@name="IStatusBarProgressIndicator"]/*' />
[Guid("76CB2670-A3D7-49CF-8200-4F3EEDCA27BB")]
[NativeTypeName("struct IStatusBarProgressIndicator : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IStatusBarProgressIndicator : IStatusBarProgressIndicator.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IStatusBarProgressIndicator));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IStatusBarProgressIndicator*, Guid*, void**, int>)(lpVtbl[0]))((IStatusBarProgressIndicator*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IStatusBarProgressIndicator*, uint>)(lpVtbl[1]))((IStatusBarProgressIndicator*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IStatusBarProgressIndicator*, uint>)(lpVtbl[2]))((IStatusBarProgressIndicator*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IStatusBarProgressIndicator*, uint*, Guid**, int>)(lpVtbl[3]))((IStatusBarProgressIndicator*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IStatusBarProgressIndicator*, HSTRING*, int>)(lpVtbl[4]))((IStatusBarProgressIndicator*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IStatusBarProgressIndicator*, TrustLevel*, int>)(lpVtbl[5]))((IStatusBarProgressIndicator*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IStatusBarProgressIndicator.xml' path='doc/member[@name="IStatusBarProgressIndicator.ShowAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT ShowAsync([NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** returnValue)
    {
        return ((delegate* unmanaged[MemberFunction]<IStatusBarProgressIndicator*, IAsyncAction**, int>)(lpVtbl[6]))((IStatusBarProgressIndicator*)Unsafe.AsPointer(ref this), returnValue);
    }

    /// <include file='IStatusBarProgressIndicator.xml' path='doc/member[@name="IStatusBarProgressIndicator.HideAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT HideAsync([NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** returnValue)
    {
        return ((delegate* unmanaged[MemberFunction]<IStatusBarProgressIndicator*, IAsyncAction**, int>)(lpVtbl[7]))((IStatusBarProgressIndicator*)Unsafe.AsPointer(ref this), returnValue);
    }

    /// <include file='IStatusBarProgressIndicator.xml' path='doc/member[@name="IStatusBarProgressIndicator.get_Text"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Text(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStatusBarProgressIndicator*, HSTRING*, int>)(lpVtbl[8]))((IStatusBarProgressIndicator*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStatusBarProgressIndicator.xml' path='doc/member[@name="IStatusBarProgressIndicator.put_Text"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_Text(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStatusBarProgressIndicator*, HSTRING, int>)(lpVtbl[9]))((IStatusBarProgressIndicator*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStatusBarProgressIndicator.xml' path='doc/member[@name="IStatusBarProgressIndicator.get_ProgressValue"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_ProgressValue([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_double_t **")] IReference<double>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStatusBarProgressIndicator*, IReference<double>**, int>)(lpVtbl[10]))((IStatusBarProgressIndicator*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStatusBarProgressIndicator.xml' path='doc/member[@name="IStatusBarProgressIndicator.put_ProgressValue"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_ProgressValue([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_double_t *")] IReference<double>* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStatusBarProgressIndicator*, IReference<double>*, int>)(lpVtbl[11]))((IStatusBarProgressIndicator*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT ShowAsync([NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** returnValue);

        [VtblIndex(7)]
        HRESULT HideAsync([NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** returnValue);

        [VtblIndex(8)]
        HRESULT get_Text(HSTRING* value);

        [VtblIndex(9)]
        HRESULT put_Text(HSTRING value);

        [VtblIndex(10)]
        HRESULT get_ProgressValue([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_double_t **")] IReference<double>** value);

        [VtblIndex(11)]
        HRESULT put_ProgressValue([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_double_t *")] IReference<double>* value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncAction**, int> ShowAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncAction**, int> HideAsync;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Text;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_Text;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_double_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<double>**, int> get_ProgressValue;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_double_t *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<double>*, int> put_ProgressValue;
    }
}
