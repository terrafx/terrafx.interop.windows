// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.619.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX;

/// <include file='ID3D12RuntimeValidationControl.xml' path='doc/member[@name="ID3D12RuntimeValidationControl"]/*' />
[Guid("C706C811-3663-4BF1-91B9-1E8A7C114AB9")]
[NativeTypeName("struct ID3D12RuntimeValidationControl : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID3D12RuntimeValidationControl : ID3D12RuntimeValidationControl.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ID3D12RuntimeValidationControl);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12RuntimeValidationControl*, Guid*, void**, int>)(lpVtbl[0]))((ID3D12RuntimeValidationControl*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12RuntimeValidationControl*, uint>)(lpVtbl[1]))((ID3D12RuntimeValidationControl*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12RuntimeValidationControl*, uint>)(lpVtbl[2]))((ID3D12RuntimeValidationControl*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID3D12RuntimeValidationControl.xml' path='doc/member[@name="ID3D12RuntimeValidationControl.DisableFailuresFromStricterValidationInAppLocalRuntime"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void DisableFailuresFromStricterValidationInAppLocalRuntime(BOOL bDisable)
    {
        ((delegate* unmanaged[MemberFunction]<ID3D12RuntimeValidationControl*, BOOL, void>)(lpVtbl[3]))((ID3D12RuntimeValidationControl*)Unsafe.AsPointer(ref this), bDisable);
    }

    /// <include file='ID3D12RuntimeValidationControl.xml' path='doc/member[@name="ID3D12RuntimeValidationControl.FailuresFromStricterValidationInAppLocalRuntimeDisabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public BOOL FailuresFromStricterValidationInAppLocalRuntimeDisabled()
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12RuntimeValidationControl*, int>)(lpVtbl[4]))((ID3D12RuntimeValidationControl*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        void DisableFailuresFromStricterValidationInAppLocalRuntime(BOOL bDisable);

        [VtblIndex(4)]
        BOOL FailuresFromStricterValidationInAppLocalRuntimeDisabled();
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

        [NativeTypeName("void (BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BOOL, void> DisableFailuresFromStricterValidationInAppLocalRuntime;

        [NativeTypeName("BOOL () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> FailuresFromStricterValidationInAppLocalRuntimeDisabled;
    }
}
