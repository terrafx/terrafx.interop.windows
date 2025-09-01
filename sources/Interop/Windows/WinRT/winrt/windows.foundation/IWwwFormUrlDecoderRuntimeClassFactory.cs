// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.foundation.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IWwwFormUrlDecoderRuntimeClassFactory.xml' path='doc/member[@name="IWwwFormUrlDecoderRuntimeClassFactory"]/*' />
[Guid("5B8C6B3D-24AE-41B5-A1BF-F0C3D544845B")]
[NativeTypeName("struct IWwwFormUrlDecoderRuntimeClassFactory : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IWwwFormUrlDecoderRuntimeClassFactory : IWwwFormUrlDecoderRuntimeClassFactory.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IWwwFormUrlDecoderRuntimeClassFactory);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IWwwFormUrlDecoderRuntimeClassFactory*, Guid*, void**, int>)(lpVtbl[0]))((IWwwFormUrlDecoderRuntimeClassFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IWwwFormUrlDecoderRuntimeClassFactory*, uint>)(lpVtbl[1]))((IWwwFormUrlDecoderRuntimeClassFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IWwwFormUrlDecoderRuntimeClassFactory*, uint>)(lpVtbl[2]))((IWwwFormUrlDecoderRuntimeClassFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IWwwFormUrlDecoderRuntimeClassFactory*, uint*, Guid**, int>)(lpVtbl[3]))((IWwwFormUrlDecoderRuntimeClassFactory*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IWwwFormUrlDecoderRuntimeClassFactory*, HSTRING*, int>)(lpVtbl[4]))((IWwwFormUrlDecoderRuntimeClassFactory*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IWwwFormUrlDecoderRuntimeClassFactory*, TrustLevel*, int>)(lpVtbl[5]))((IWwwFormUrlDecoderRuntimeClassFactory*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IWwwFormUrlDecoderRuntimeClassFactory.xml' path='doc/member[@name="IWwwFormUrlDecoderRuntimeClassFactory.CreateWwwFormUrlDecoder"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateWwwFormUrlDecoder(HSTRING query, [NativeTypeName("ABI::Windows::Foundation::IWwwFormUrlDecoderRuntimeClass **")] IWwwFormUrlDecoderRuntimeClass** instance)
    {
        return ((delegate* unmanaged[MemberFunction]<IWwwFormUrlDecoderRuntimeClassFactory*, HSTRING, IWwwFormUrlDecoderRuntimeClass**, int>)(lpVtbl[6]))((IWwwFormUrlDecoderRuntimeClassFactory*)Unsafe.AsPointer(ref this), query, instance);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateWwwFormUrlDecoder(HSTRING query, [NativeTypeName("ABI::Windows::Foundation::IWwwFormUrlDecoderRuntimeClass **")] IWwwFormUrlDecoderRuntimeClass** instance);
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

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::IWwwFormUrlDecoderRuntimeClass **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IWwwFormUrlDecoderRuntimeClass**, int> CreateWwwFormUrlDecoder;
    }
}
