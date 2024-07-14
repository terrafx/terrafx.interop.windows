// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.background.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ICachedFileUpdaterTriggerDetails.xml' path='doc/member[@name="ICachedFileUpdaterTriggerDetails"]/*' />
[Guid("71838C13-1314-47B4-9597-DC7E248C17CC")]
[NativeTypeName("struct ICachedFileUpdaterTriggerDetails : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICachedFileUpdaterTriggerDetails : ICachedFileUpdaterTriggerDetails.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICachedFileUpdaterTriggerDetails));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICachedFileUpdaterTriggerDetails*, Guid*, void**, int>)(lpVtbl[0]))((ICachedFileUpdaterTriggerDetails*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICachedFileUpdaterTriggerDetails*, uint>)(lpVtbl[1]))((ICachedFileUpdaterTriggerDetails*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICachedFileUpdaterTriggerDetails*, uint>)(lpVtbl[2]))((ICachedFileUpdaterTriggerDetails*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ICachedFileUpdaterTriggerDetails*, uint*, Guid**, int>)(lpVtbl[3]))((ICachedFileUpdaterTriggerDetails*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ICachedFileUpdaterTriggerDetails*, HSTRING*, int>)(lpVtbl[4]))((ICachedFileUpdaterTriggerDetails*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ICachedFileUpdaterTriggerDetails*, TrustLevel*, int>)(lpVtbl[5]))((ICachedFileUpdaterTriggerDetails*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ICachedFileUpdaterTriggerDetails.xml' path='doc/member[@name="ICachedFileUpdaterTriggerDetails.get_UpdateTarget"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_UpdateTarget([NativeTypeName("ABI::Windows::Storage::Provider::CachedFileTarget *")] CachedFileTarget* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICachedFileUpdaterTriggerDetails*, CachedFileTarget*, int>)(lpVtbl[6]))((ICachedFileUpdaterTriggerDetails*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICachedFileUpdaterTriggerDetails.xml' path='doc/member[@name="ICachedFileUpdaterTriggerDetails.get_UpdateRequest"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_UpdateRequest([NativeTypeName("ABI::Windows::Storage::Provider::IFileUpdateRequest **")] IFileUpdateRequest** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICachedFileUpdaterTriggerDetails*, IFileUpdateRequest**, int>)(lpVtbl[7]))((ICachedFileUpdaterTriggerDetails*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICachedFileUpdaterTriggerDetails.xml' path='doc/member[@name="ICachedFileUpdaterTriggerDetails.get_CanRequestUserInput"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_CanRequestUserInput([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICachedFileUpdaterTriggerDetails*, byte*, int>)(lpVtbl[8]))((ICachedFileUpdaterTriggerDetails*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_UpdateTarget([NativeTypeName("ABI::Windows::Storage::Provider::CachedFileTarget *")] CachedFileTarget* value);

        [VtblIndex(7)]
        HRESULT get_UpdateRequest([NativeTypeName("ABI::Windows::Storage::Provider::IFileUpdateRequest **")] IFileUpdateRequest** value);

        [VtblIndex(8)]
        HRESULT get_CanRequestUserInput([NativeTypeName("boolean *")] byte* value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Provider::CachedFileTarget *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, CachedFileTarget*, int> get_UpdateTarget;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Provider::IFileUpdateRequest **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IFileUpdateRequest**, int> get_UpdateRequest;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_CanRequestUserInput;
    }
}
