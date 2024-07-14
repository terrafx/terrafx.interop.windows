// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.perception.spatial.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ISpatialEntityStore.xml' path='doc/member[@name="ISpatialEntityStore"]/*' />
[Guid("329788BA-E513-4F06-889D-1BE30ECF43E6")]
[NativeTypeName("struct ISpatialEntityStore : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISpatialEntityStore : ISpatialEntityStore.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISpatialEntityStore));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialEntityStore*, Guid*, void**, int>)(lpVtbl[0]))((ISpatialEntityStore*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialEntityStore*, uint>)(lpVtbl[1]))((ISpatialEntityStore*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialEntityStore*, uint>)(lpVtbl[2]))((ISpatialEntityStore*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialEntityStore*, uint*, Guid**, int>)(lpVtbl[3]))((ISpatialEntityStore*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialEntityStore*, HSTRING*, int>)(lpVtbl[4]))((ISpatialEntityStore*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialEntityStore*, TrustLevel*, int>)(lpVtbl[5]))((ISpatialEntityStore*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ISpatialEntityStore.xml' path='doc/member[@name="ISpatialEntityStore.SaveAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SaveAsync([NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialEntity *")] ISpatialEntity* entity, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** action)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialEntityStore*, ISpatialEntity*, IAsyncAction**, int>)(lpVtbl[6]))((ISpatialEntityStore*)Unsafe.AsPointer(ref this), entity, action);
    }

    /// <include file='ISpatialEntityStore.xml' path='doc/member[@name="ISpatialEntityStore.RemoveAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT RemoveAsync([NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialEntity *")] ISpatialEntity* entity, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** action)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialEntityStore*, ISpatialEntity*, IAsyncAction**, int>)(lpVtbl[7]))((ISpatialEntityStore*)Unsafe.AsPointer(ref this), entity, action);
    }

    /// <include file='ISpatialEntityStore.xml' path='doc/member[@name="ISpatialEntityStore.CreateEntityWatcher"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CreateEntityWatcher([NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialEntityWatcher **")] ISpatialEntityWatcher** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialEntityStore*, ISpatialEntityWatcher**, int>)(lpVtbl[8]))((ISpatialEntityStore*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT SaveAsync([NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialEntity *")] ISpatialEntity* entity, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** action);

        [VtblIndex(7)]
        HRESULT RemoveAsync([NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialEntity *")] ISpatialEntity* entity, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** action);

        [VtblIndex(8)]
        HRESULT CreateEntityWatcher([NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialEntityWatcher **")] ISpatialEntityWatcher** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Perception::Spatial::ISpatialEntity *, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ISpatialEntity*, IAsyncAction**, int> SaveAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Perception::Spatial::ISpatialEntity *, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ISpatialEntity*, IAsyncAction**, int> RemoveAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Perception::Spatial::ISpatialEntityWatcher **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ISpatialEntityWatcher**, int> CreateEntityWatcher;
    }
}
