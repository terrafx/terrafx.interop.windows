// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.printers.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IPrintSchema.xml' path='doc/member[@name="IPrintSchema"]/*' />
[Guid("C2B98316-26B8-4BFB-8138-9F962C22A35B")]
[NativeTypeName("struct IPrintSchema : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPrintSchema : IPrintSchema.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IPrintSchema);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintSchema*, Guid*, void**, int>)(lpVtbl[0]))((IPrintSchema*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintSchema*, uint>)(lpVtbl[1]))((IPrintSchema*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintSchema*, uint>)(lpVtbl[2]))((IPrintSchema*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintSchema*, uint*, Guid**, int>)(lpVtbl[3]))((IPrintSchema*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintSchema*, HSTRING*, int>)(lpVtbl[4]))((IPrintSchema*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintSchema*, TrustLevel*, int>)(lpVtbl[5]))((IPrintSchema*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IPrintSchema.xml' path='doc/member[@name="IPrintSchema.GetDefaultPrintTicketAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetDefaultPrintTicketAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStreams__CIRandomAccessStreamWithContentType_t **")] IAsyncOperation<Pointer<IRandomAccessStreamWithContentType>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintSchema*, IAsyncOperation<Pointer<IRandomAccessStreamWithContentType>>**, int>)(lpVtbl[6]))((IPrintSchema*)Unsafe.AsPointer(ref this), operation);
    }

    /// <include file='IPrintSchema.xml' path='doc/member[@name="IPrintSchema.GetCapabilitiesAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetCapabilitiesAsync([NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamWithContentType *")] IRandomAccessStreamWithContentType* constrainTicket, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStreams__CIRandomAccessStreamWithContentType_t **")] IAsyncOperation<Pointer<IRandomAccessStreamWithContentType>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintSchema*, IRandomAccessStreamWithContentType*, IAsyncOperation<Pointer<IRandomAccessStreamWithContentType>>**, int>)(lpVtbl[7]))((IPrintSchema*)Unsafe.AsPointer(ref this), constrainTicket, operation);
    }

    /// <include file='IPrintSchema.xml' path='doc/member[@name="IPrintSchema.MergeAndValidateWithDefaultPrintTicketAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT MergeAndValidateWithDefaultPrintTicketAsync([NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamWithContentType *")] IRandomAccessStreamWithContentType* deltaTicket, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStreams__CIRandomAccessStreamWithContentType_t **")] IAsyncOperation<Pointer<IRandomAccessStreamWithContentType>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintSchema*, IRandomAccessStreamWithContentType*, IAsyncOperation<Pointer<IRandomAccessStreamWithContentType>>**, int>)(lpVtbl[8]))((IPrintSchema*)Unsafe.AsPointer(ref this), deltaTicket, operation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetDefaultPrintTicketAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStreams__CIRandomAccessStreamWithContentType_t **")] IAsyncOperation<Pointer<IRandomAccessStreamWithContentType>>** operation);

        [VtblIndex(7)]
        HRESULT GetCapabilitiesAsync([NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamWithContentType *")] IRandomAccessStreamWithContentType* constrainTicket, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStreams__CIRandomAccessStreamWithContentType_t **")] IAsyncOperation<Pointer<IRandomAccessStreamWithContentType>>** operation);

        [VtblIndex(8)]
        HRESULT MergeAndValidateWithDefaultPrintTicketAsync([NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamWithContentType *")] IRandomAccessStreamWithContentType* deltaTicket, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStreams__CIRandomAccessStreamWithContentType_t **")] IAsyncOperation<Pointer<IRandomAccessStreamWithContentType>>** operation);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStreams__CIRandomAccessStreamWithContentType_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<Pointer<IRandomAccessStreamWithContentType>>**, int> GetDefaultPrintTicketAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IRandomAccessStreamWithContentType *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStreams__CIRandomAccessStreamWithContentType_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IRandomAccessStreamWithContentType*, IAsyncOperation<Pointer<IRandomAccessStreamWithContentType>>**, int> GetCapabilitiesAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IRandomAccessStreamWithContentType *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStreams__CIRandomAccessStreamWithContentType_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IRandomAccessStreamWithContentType*, IAsyncOperation<Pointer<IRandomAccessStreamWithContentType>>**, int> MergeAndValidateWithDefaultPrintTicketAsync;
    }
}
