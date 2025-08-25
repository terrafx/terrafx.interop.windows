// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.input.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ISystemFunctionLockIndicatorChangedEventArgs.xml' path='doc/member[@name="ISystemFunctionLockIndicatorChangedEventArgs"]/*' />
[Guid("B212B94E-7A6F-58AE-B304-BAE61D0371B9")]
[NativeTypeName("struct ISystemFunctionLockIndicatorChangedEventArgs : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISystemFunctionLockIndicatorChangedEventArgs : ISystemFunctionLockIndicatorChangedEventArgs.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ISystemFunctionLockIndicatorChangedEventArgs);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemFunctionLockIndicatorChangedEventArgs*, Guid*, void**, int>)(lpVtbl[0]))((ISystemFunctionLockIndicatorChangedEventArgs*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemFunctionLockIndicatorChangedEventArgs*, uint>)(lpVtbl[1]))((ISystemFunctionLockIndicatorChangedEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemFunctionLockIndicatorChangedEventArgs*, uint>)(lpVtbl[2]))((ISystemFunctionLockIndicatorChangedEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemFunctionLockIndicatorChangedEventArgs*, uint*, Guid**, int>)(lpVtbl[3]))((ISystemFunctionLockIndicatorChangedEventArgs*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemFunctionLockIndicatorChangedEventArgs*, HSTRING*, int>)(lpVtbl[4]))((ISystemFunctionLockIndicatorChangedEventArgs*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemFunctionLockIndicatorChangedEventArgs*, TrustLevel*, int>)(lpVtbl[5]))((ISystemFunctionLockIndicatorChangedEventArgs*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ISystemFunctionLockIndicatorChangedEventArgs.xml' path='doc/member[@name="ISystemFunctionLockIndicatorChangedEventArgs.get_Timestamp"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Timestamp([NativeTypeName("UINT64 *")] ulong* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemFunctionLockIndicatorChangedEventArgs*, ulong*, int>)(lpVtbl[6]))((ISystemFunctionLockIndicatorChangedEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISystemFunctionLockIndicatorChangedEventArgs.xml' path='doc/member[@name="ISystemFunctionLockIndicatorChangedEventArgs.get_IsIndicatorOn"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_IsIndicatorOn([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemFunctionLockIndicatorChangedEventArgs*, byte*, int>)(lpVtbl[7]))((ISystemFunctionLockIndicatorChangedEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISystemFunctionLockIndicatorChangedEventArgs.xml' path='doc/member[@name="ISystemFunctionLockIndicatorChangedEventArgs.get_Handled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Handled([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemFunctionLockIndicatorChangedEventArgs*, byte*, int>)(lpVtbl[8]))((ISystemFunctionLockIndicatorChangedEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISystemFunctionLockIndicatorChangedEventArgs.xml' path='doc/member[@name="ISystemFunctionLockIndicatorChangedEventArgs.put_Handled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_Handled([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemFunctionLockIndicatorChangedEventArgs*, byte, int>)(lpVtbl[9]))((ISystemFunctionLockIndicatorChangedEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Timestamp([NativeTypeName("UINT64 *")] ulong* value);

        [VtblIndex(7)]
        HRESULT get_IsIndicatorOn([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(8)]
        HRESULT get_Handled([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(9)]
        HRESULT put_Handled([NativeTypeName("boolean")] byte value);
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

        [NativeTypeName("HRESULT (UINT64 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ulong*, int> get_Timestamp;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsIndicatorOn;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_Handled;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_Handled;
    }
}
