// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.foundation.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IAsyncAction.xml' path='doc/member[@name="IAsyncAction"]/*' />
[Guid("5A648006-843A-4DA9-865B-9D26E5DFAD7B")]
[NativeTypeName("struct IAsyncAction : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAsyncAction : IAsyncAction.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAsyncAction));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAsyncAction*, Guid*, void**, int>)(lpVtbl[0]))((IAsyncAction*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAsyncAction*, uint>)(lpVtbl[1]))((IAsyncAction*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAsyncAction*, uint>)(lpVtbl[2]))((IAsyncAction*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged<IAsyncAction*, uint*, Guid**, int>)(lpVtbl[3]))((IAsyncAction*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IAsyncAction*, HSTRING*, int>)(lpVtbl[4]))((IAsyncAction*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IAsyncAction*, TrustLevel*, int>)(lpVtbl[5]))((IAsyncAction*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IAsyncAction.xml' path='doc/member[@name="IAsyncAction.put_Completed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT put_Completed([NativeTypeName("ABI::Windows::Foundation::IAsyncActionCompletedHandler *")] IAsyncActionCompletedHandler* handler)
    {
        return ((delegate* unmanaged<IAsyncAction*, IAsyncActionCompletedHandler*, int>)(lpVtbl[6]))((IAsyncAction*)Unsafe.AsPointer(ref this), handler);
    }

    /// <include file='IAsyncAction.xml' path='doc/member[@name="IAsyncAction.get_Completed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Completed([NativeTypeName("ABI::Windows::Foundation::IAsyncActionCompletedHandler **")] IAsyncActionCompletedHandler** handler)
    {
        return ((delegate* unmanaged<IAsyncAction*, IAsyncActionCompletedHandler**, int>)(lpVtbl[7]))((IAsyncAction*)Unsafe.AsPointer(ref this), handler);
    }

    /// <include file='IAsyncAction.xml' path='doc/member[@name="IAsyncAction.GetResults"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetResults()
    {
        return ((delegate* unmanaged<IAsyncAction*, int>)(lpVtbl[8]))((IAsyncAction*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT put_Completed([NativeTypeName("ABI::Windows::Foundation::IAsyncActionCompletedHandler *")] IAsyncActionCompletedHandler* handler);

        [VtblIndex(7)]
        HRESULT get_Completed([NativeTypeName("ABI::Windows::Foundation::IAsyncActionCompletedHandler **")] IAsyncActionCompletedHandler** handler);

        [VtblIndex(8)]
        HRESULT GetResults();
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> Release;

        [NativeTypeName("HRESULT (ULONG *, IID **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, Guid**, int> GetIids;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> GetRuntimeClassName;

        [NativeTypeName("HRESULT (TrustLevel *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, TrustLevel*, int> GetTrustLevel;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IAsyncActionCompletedHandler *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IAsyncActionCompletedHandler*, int> put_Completed;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IAsyncActionCompletedHandler **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IAsyncActionCompletedHandler**, int> get_Completed;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> GetResults;
    }
}
