// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.windowmanagement.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IAppWindowStatics.xml' path='doc/member[@name="IAppWindowStatics"]/*' />
[Guid("FF1F3EA3-B769-50EF-9873-108CD0E89746")]
[NativeTypeName("struct IAppWindowStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAppWindowStatics : IAppWindowStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppWindowStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppWindowStatics*, Guid*, void**, int>)(lpVtbl[0]))((IAppWindowStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppWindowStatics*, uint>)(lpVtbl[1]))((IAppWindowStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppWindowStatics*, uint>)(lpVtbl[2]))((IAppWindowStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppWindowStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IAppWindowStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppWindowStatics*, HSTRING*, int>)(lpVtbl[4]))((IAppWindowStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppWindowStatics*, TrustLevel*, int>)(lpVtbl[5]))((IAppWindowStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IAppWindowStatics.xml' path='doc/member[@name="IAppWindowStatics.TryCreateAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT TryCreateAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CUI__CWindowManagement__CAppWindow_t **")] IAsyncOperation<IntPtr>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppWindowStatics*, IAsyncOperation<IntPtr>**, int>)(lpVtbl[6]))((IAppWindowStatics*)Unsafe.AsPointer(ref this), operation);
    }

    /// <include file='IAppWindowStatics.xml' path='doc/member[@name="IAppWindowStatics.ClearAllPersistedState"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT ClearAllPersistedState()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppWindowStatics*, int>)(lpVtbl[7]))((IAppWindowStatics*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAppWindowStatics.xml' path='doc/member[@name="IAppWindowStatics.ClearPersistedState"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT ClearPersistedState(HSTRING key)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppWindowStatics*, HSTRING, int>)(lpVtbl[8]))((IAppWindowStatics*)Unsafe.AsPointer(ref this), key);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT TryCreateAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CUI__CWindowManagement__CAppWindow_t **")] IAsyncOperation<IntPtr>** operation);

        [VtblIndex(7)]
        HRESULT ClearAllPersistedState();

        [VtblIndex(8)]
        HRESULT ClearPersistedState(HSTRING key);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CUI__CWindowManagement__CAppWindow_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<IntPtr>**, int> TryCreateAsync;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> ClearAllPersistedState;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> ClearPersistedState;
    }
}
