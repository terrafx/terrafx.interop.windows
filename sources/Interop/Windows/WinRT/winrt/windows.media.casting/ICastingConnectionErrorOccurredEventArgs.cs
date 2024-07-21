// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.casting.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ICastingConnectionErrorOccurredEventArgs.xml' path='doc/member[@name="ICastingConnectionErrorOccurredEventArgs"]/*' />
[Guid("A7FB3C69-8719-4F00-81FB-961863C79A32")]
[NativeTypeName("struct ICastingConnectionErrorOccurredEventArgs : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICastingConnectionErrorOccurredEventArgs : ICastingConnectionErrorOccurredEventArgs.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICastingConnectionErrorOccurredEventArgs));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICastingConnectionErrorOccurredEventArgs*, Guid*, void**, int>)(lpVtbl[0]))((ICastingConnectionErrorOccurredEventArgs*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICastingConnectionErrorOccurredEventArgs*, uint>)(lpVtbl[1]))((ICastingConnectionErrorOccurredEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICastingConnectionErrorOccurredEventArgs*, uint>)(lpVtbl[2]))((ICastingConnectionErrorOccurredEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ICastingConnectionErrorOccurredEventArgs*, uint*, Guid**, int>)(lpVtbl[3]))((ICastingConnectionErrorOccurredEventArgs*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ICastingConnectionErrorOccurredEventArgs*, HSTRING*, int>)(lpVtbl[4]))((ICastingConnectionErrorOccurredEventArgs*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ICastingConnectionErrorOccurredEventArgs*, TrustLevel*, int>)(lpVtbl[5]))((ICastingConnectionErrorOccurredEventArgs*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ICastingConnectionErrorOccurredEventArgs.xml' path='doc/member[@name="ICastingConnectionErrorOccurredEventArgs.get_ErrorStatus"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_ErrorStatus([NativeTypeName("ABI::Windows::Media::Casting::CastingConnectionErrorStatus *")] CastingConnectionErrorStatus* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICastingConnectionErrorOccurredEventArgs*, CastingConnectionErrorStatus*, int>)(lpVtbl[6]))((ICastingConnectionErrorOccurredEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICastingConnectionErrorOccurredEventArgs.xml' path='doc/member[@name="ICastingConnectionErrorOccurredEventArgs.get_Message"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Message(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICastingConnectionErrorOccurredEventArgs*, HSTRING*, int>)(lpVtbl[7]))((ICastingConnectionErrorOccurredEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_ErrorStatus([NativeTypeName("ABI::Windows::Media::Casting::CastingConnectionErrorStatus *")] CastingConnectionErrorStatus* value);

        [VtblIndex(7)]
        HRESULT get_Message(HSTRING* value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Media::Casting::CastingConnectionErrorStatus *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, CastingConnectionErrorStatus*, int> get_ErrorStatus;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Message;
    }
}
