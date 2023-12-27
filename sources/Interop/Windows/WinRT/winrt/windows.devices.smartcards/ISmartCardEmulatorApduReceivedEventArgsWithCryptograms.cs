// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.smartcards.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ISmartCardEmulatorApduReceivedEventArgsWithCryptograms.xml' path='doc/member[@name="ISmartCardEmulatorApduReceivedEventArgsWithCryptograms"]/*' />
[Guid("D550BAC7-B7BF-4E29-9294-0C4AC3C941BD")]
[NativeTypeName("struct ISmartCardEmulatorApduReceivedEventArgsWithCryptograms : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISmartCardEmulatorApduReceivedEventArgsWithCryptograms : ISmartCardEmulatorApduReceivedEventArgsWithCryptograms.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISmartCardEmulatorApduReceivedEventArgsWithCryptograms));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardEmulatorApduReceivedEventArgsWithCryptograms*, Guid*, void**, int>)(lpVtbl[0]))((ISmartCardEmulatorApduReceivedEventArgsWithCryptograms*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardEmulatorApduReceivedEventArgsWithCryptograms*, uint>)(lpVtbl[1]))((ISmartCardEmulatorApduReceivedEventArgsWithCryptograms*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardEmulatorApduReceivedEventArgsWithCryptograms*, uint>)(lpVtbl[2]))((ISmartCardEmulatorApduReceivedEventArgsWithCryptograms*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardEmulatorApduReceivedEventArgsWithCryptograms*, uint*, Guid**, int>)(lpVtbl[3]))((ISmartCardEmulatorApduReceivedEventArgsWithCryptograms*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardEmulatorApduReceivedEventArgsWithCryptograms*, HSTRING*, int>)(lpVtbl[4]))((ISmartCardEmulatorApduReceivedEventArgsWithCryptograms*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardEmulatorApduReceivedEventArgsWithCryptograms*, TrustLevel*, int>)(lpVtbl[5]))((ISmartCardEmulatorApduReceivedEventArgsWithCryptograms*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ISmartCardEmulatorApduReceivedEventArgsWithCryptograms.xml' path='doc/member[@name="ISmartCardEmulatorApduReceivedEventArgsWithCryptograms.TryRespondWithCryptogramsAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT TryRespondWithCryptogramsAsync([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* responseTemplate, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CDevices__CSmartCards__CSmartCardCryptogramPlacementStep_t *")] IIterable<Pointer<ISmartCardCryptogramPlacementStep>>* cryptogramPlacementSteps, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSmartCards__CSmartCardCryptogramGeneratorOperationStatus_t **")] IAsyncOperation<SmartCardCryptogramGeneratorOperationStatus>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardEmulatorApduReceivedEventArgsWithCryptograms*, IBuffer*, IIterable<Pointer<ISmartCardCryptogramPlacementStep>>*, IAsyncOperation<SmartCardCryptogramGeneratorOperationStatus>**, int>)(lpVtbl[6]))((ISmartCardEmulatorApduReceivedEventArgsWithCryptograms*)Unsafe.AsPointer(ref this), responseTemplate, cryptogramPlacementSteps, result);
    }

    /// <include file='ISmartCardEmulatorApduReceivedEventArgsWithCryptograms.xml' path='doc/member[@name="ISmartCardEmulatorApduReceivedEventArgsWithCryptograms.TryRespondWithCryptogramsAndStateAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT TryRespondWithCryptogramsAndStateAsync([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* responseTemplate, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CDevices__CSmartCards__CSmartCardCryptogramPlacementStep_t *")] IIterable<Pointer<ISmartCardCryptogramPlacementStep>>* cryptogramPlacementSteps, [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT32_t *")] IReference<uint>* nextState, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSmartCards__CSmartCardCryptogramGeneratorOperationStatus_t **")] IAsyncOperation<SmartCardCryptogramGeneratorOperationStatus>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardEmulatorApduReceivedEventArgsWithCryptograms*, IBuffer*, IIterable<Pointer<ISmartCardCryptogramPlacementStep>>*, IReference<uint>*, IAsyncOperation<SmartCardCryptogramGeneratorOperationStatus>**, int>)(lpVtbl[7]))((ISmartCardEmulatorApduReceivedEventArgsWithCryptograms*)Unsafe.AsPointer(ref this), responseTemplate, cryptogramPlacementSteps, nextState, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT TryRespondWithCryptogramsAsync([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* responseTemplate, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CDevices__CSmartCards__CSmartCardCryptogramPlacementStep_t *")] IIterable<Pointer<ISmartCardCryptogramPlacementStep>>* cryptogramPlacementSteps, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSmartCards__CSmartCardCryptogramGeneratorOperationStatus_t **")] IAsyncOperation<SmartCardCryptogramGeneratorOperationStatus>** result);

        [VtblIndex(7)]
        HRESULT TryRespondWithCryptogramsAndStateAsync([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* responseTemplate, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CDevices__CSmartCards__CSmartCardCryptogramPlacementStep_t *")] IIterable<Pointer<ISmartCardCryptogramPlacementStep>>* cryptogramPlacementSteps, [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT32_t *")] IReference<uint>* nextState, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSmartCards__CSmartCardCryptogramGeneratorOperationStatus_t **")] IAsyncOperation<SmartCardCryptogramGeneratorOperationStatus>** result);
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

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IBuffer *, ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CDevices__CSmartCards__CSmartCardCryptogramPlacementStep_t *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSmartCards__CSmartCardCryptogramGeneratorOperationStatus_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBuffer*, IIterable<Pointer<ISmartCardCryptogramPlacementStep>>*, IAsyncOperation<SmartCardCryptogramGeneratorOperationStatus>**, int> TryRespondWithCryptogramsAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IBuffer *, ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CDevices__CSmartCards__CSmartCardCryptogramPlacementStep_t *, ABI::Windows::Foundation::__FIReference_1_UINT32_t *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSmartCards__CSmartCardCryptogramGeneratorOperationStatus_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBuffer*, IIterable<Pointer<ISmartCardCryptogramPlacementStep>>*, IReference<uint>*, IAsyncOperation<SmartCardCryptogramGeneratorOperationStatus>**, int> TryRespondWithCryptogramsAndStateAsync;
    }
}
