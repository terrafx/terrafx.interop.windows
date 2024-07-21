// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.devices.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ICameraIntrinsicsFactory.xml' path='doc/member[@name="ICameraIntrinsicsFactory"]/*' />
[Guid("C0DDC486-2132-4A34-A659-9BFE2A055712")]
[NativeTypeName("struct ICameraIntrinsicsFactory : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICameraIntrinsicsFactory : ICameraIntrinsicsFactory.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICameraIntrinsicsFactory));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICameraIntrinsicsFactory*, Guid*, void**, int>)(lpVtbl[0]))((ICameraIntrinsicsFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICameraIntrinsicsFactory*, uint>)(lpVtbl[1]))((ICameraIntrinsicsFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICameraIntrinsicsFactory*, uint>)(lpVtbl[2]))((ICameraIntrinsicsFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ICameraIntrinsicsFactory*, uint*, Guid**, int>)(lpVtbl[3]))((ICameraIntrinsicsFactory*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ICameraIntrinsicsFactory*, HSTRING*, int>)(lpVtbl[4]))((ICameraIntrinsicsFactory*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ICameraIntrinsicsFactory*, TrustLevel*, int>)(lpVtbl[5]))((ICameraIntrinsicsFactory*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ICameraIntrinsicsFactory.xml' path='doc/member[@name="ICameraIntrinsicsFactory.Create"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Create([NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2")] Vector2 focalLength, [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2")] Vector2 principalPoint, [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3")] Vector3 radialDistortion, [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2")] Vector2 tangentialDistortion, [NativeTypeName("UINT32")] uint imageWidth, [NativeTypeName("UINT32")] uint imageHeight, [NativeTypeName("ABI::Windows::Media::Devices::Core::ICameraIntrinsics **")] ICameraIntrinsics** result)
    {
        return ((delegate* unmanaged[MemberFunction]<ICameraIntrinsicsFactory*, Vector2, Vector2, Vector3, Vector2, uint, uint, ICameraIntrinsics**, int>)(lpVtbl[6]))((ICameraIntrinsicsFactory*)Unsafe.AsPointer(ref this), focalLength, principalPoint, radialDistortion, tangentialDistortion, imageWidth, imageHeight, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT Create([NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2")] Vector2 focalLength, [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2")] Vector2 principalPoint, [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3")] Vector3 radialDistortion, [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2")] Vector2 tangentialDistortion, [NativeTypeName("UINT32")] uint imageWidth, [NativeTypeName("UINT32")] uint imageHeight, [NativeTypeName("ABI::Windows::Media::Devices::Core::ICameraIntrinsics **")] ICameraIntrinsics** result);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Numerics::Vector2, ABI::Windows::Foundation::Numerics::Vector2, ABI::Windows::Foundation::Numerics::Vector3, ABI::Windows::Foundation::Numerics::Vector2, UINT32, UINT32, ABI::Windows::Media::Devices::Core::ICameraIntrinsics **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Vector2, Vector2, Vector3, Vector2, uint, uint, ICameraIntrinsics**, int> Create;
    }
}
