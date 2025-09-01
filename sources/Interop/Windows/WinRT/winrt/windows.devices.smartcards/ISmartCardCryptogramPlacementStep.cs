// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.smartcards.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ISmartCardCryptogramPlacementStep.xml' path='doc/member[@name="ISmartCardCryptogramPlacementStep"]/*' />
[Guid("947B03EB-8342-4792-A2E5-925636378A53")]
[NativeTypeName("struct ISmartCardCryptogramPlacementStep : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISmartCardCryptogramPlacementStep : ISmartCardCryptogramPlacementStep.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ISmartCardCryptogramPlacementStep);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardCryptogramPlacementStep*, Guid*, void**, int>)(lpVtbl[0]))((ISmartCardCryptogramPlacementStep*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardCryptogramPlacementStep*, uint>)(lpVtbl[1]))((ISmartCardCryptogramPlacementStep*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardCryptogramPlacementStep*, uint>)(lpVtbl[2]))((ISmartCardCryptogramPlacementStep*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardCryptogramPlacementStep*, uint*, Guid**, int>)(lpVtbl[3]))((ISmartCardCryptogramPlacementStep*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardCryptogramPlacementStep*, HSTRING*, int>)(lpVtbl[4]))((ISmartCardCryptogramPlacementStep*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardCryptogramPlacementStep*, TrustLevel*, int>)(lpVtbl[5]))((ISmartCardCryptogramPlacementStep*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ISmartCardCryptogramPlacementStep.xml' path='doc/member[@name="ISmartCardCryptogramPlacementStep.get_Algorithm"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Algorithm([NativeTypeName("ABI::Windows::Devices::SmartCards::SmartCardCryptogramAlgorithm *")] SmartCardCryptogramAlgorithm* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardCryptogramPlacementStep*, SmartCardCryptogramAlgorithm*, int>)(lpVtbl[6]))((ISmartCardCryptogramPlacementStep*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmartCardCryptogramPlacementStep.xml' path='doc/member[@name="ISmartCardCryptogramPlacementStep.put_Algorithm"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_Algorithm([NativeTypeName("ABI::Windows::Devices::SmartCards::SmartCardCryptogramAlgorithm")] SmartCardCryptogramAlgorithm value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardCryptogramPlacementStep*, SmartCardCryptogramAlgorithm, int>)(lpVtbl[7]))((ISmartCardCryptogramPlacementStep*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmartCardCryptogramPlacementStep.xml' path='doc/member[@name="ISmartCardCryptogramPlacementStep.get_SourceData"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_SourceData([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardCryptogramPlacementStep*, IBuffer**, int>)(lpVtbl[8]))((ISmartCardCryptogramPlacementStep*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmartCardCryptogramPlacementStep.xml' path='doc/member[@name="ISmartCardCryptogramPlacementStep.put_SourceData"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_SourceData([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardCryptogramPlacementStep*, IBuffer*, int>)(lpVtbl[9]))((ISmartCardCryptogramPlacementStep*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmartCardCryptogramPlacementStep.xml' path='doc/member[@name="ISmartCardCryptogramPlacementStep.get_CryptogramMaterialPackageName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_CryptogramMaterialPackageName(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardCryptogramPlacementStep*, HSTRING*, int>)(lpVtbl[10]))((ISmartCardCryptogramPlacementStep*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmartCardCryptogramPlacementStep.xml' path='doc/member[@name="ISmartCardCryptogramPlacementStep.put_CryptogramMaterialPackageName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_CryptogramMaterialPackageName(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardCryptogramPlacementStep*, HSTRING, int>)(lpVtbl[11]))((ISmartCardCryptogramPlacementStep*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmartCardCryptogramPlacementStep.xml' path='doc/member[@name="ISmartCardCryptogramPlacementStep.get_CryptogramMaterialName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_CryptogramMaterialName(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardCryptogramPlacementStep*, HSTRING*, int>)(lpVtbl[12]))((ISmartCardCryptogramPlacementStep*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmartCardCryptogramPlacementStep.xml' path='doc/member[@name="ISmartCardCryptogramPlacementStep.put_CryptogramMaterialName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_CryptogramMaterialName(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardCryptogramPlacementStep*, HSTRING, int>)(lpVtbl[13]))((ISmartCardCryptogramPlacementStep*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmartCardCryptogramPlacementStep.xml' path='doc/member[@name="ISmartCardCryptogramPlacementStep.get_TemplateOffset"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_TemplateOffset([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardCryptogramPlacementStep*, int*, int>)(lpVtbl[14]))((ISmartCardCryptogramPlacementStep*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmartCardCryptogramPlacementStep.xml' path='doc/member[@name="ISmartCardCryptogramPlacementStep.put_TemplateOffset"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT put_TemplateOffset([NativeTypeName("INT32")] int value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardCryptogramPlacementStep*, int, int>)(lpVtbl[15]))((ISmartCardCryptogramPlacementStep*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmartCardCryptogramPlacementStep.xml' path='doc/member[@name="ISmartCardCryptogramPlacementStep.get_CryptogramOffset"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_CryptogramOffset([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardCryptogramPlacementStep*, int*, int>)(lpVtbl[16]))((ISmartCardCryptogramPlacementStep*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmartCardCryptogramPlacementStep.xml' path='doc/member[@name="ISmartCardCryptogramPlacementStep.put_CryptogramOffset"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT put_CryptogramOffset([NativeTypeName("INT32")] int value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardCryptogramPlacementStep*, int, int>)(lpVtbl[17]))((ISmartCardCryptogramPlacementStep*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmartCardCryptogramPlacementStep.xml' path='doc/member[@name="ISmartCardCryptogramPlacementStep.get_CryptogramLength"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_CryptogramLength([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardCryptogramPlacementStep*, int*, int>)(lpVtbl[18]))((ISmartCardCryptogramPlacementStep*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmartCardCryptogramPlacementStep.xml' path='doc/member[@name="ISmartCardCryptogramPlacementStep.put_CryptogramLength"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT put_CryptogramLength([NativeTypeName("INT32")] int value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardCryptogramPlacementStep*, int, int>)(lpVtbl[19]))((ISmartCardCryptogramPlacementStep*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmartCardCryptogramPlacementStep.xml' path='doc/member[@name="ISmartCardCryptogramPlacementStep.get_CryptogramPlacementOptions"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_CryptogramPlacementOptions([NativeTypeName("ABI::Windows::Devices::SmartCards::SmartCardCryptogramPlacementOptions *")] SmartCardCryptogramPlacementOptions* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardCryptogramPlacementStep*, SmartCardCryptogramPlacementOptions*, int>)(lpVtbl[20]))((ISmartCardCryptogramPlacementStep*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmartCardCryptogramPlacementStep.xml' path='doc/member[@name="ISmartCardCryptogramPlacementStep.put_CryptogramPlacementOptions"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT put_CryptogramPlacementOptions([NativeTypeName("ABI::Windows::Devices::SmartCards::SmartCardCryptogramPlacementOptions")] SmartCardCryptogramPlacementOptions value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardCryptogramPlacementStep*, SmartCardCryptogramPlacementOptions, int>)(lpVtbl[21]))((ISmartCardCryptogramPlacementStep*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmartCardCryptogramPlacementStep.xml' path='doc/member[@name="ISmartCardCryptogramPlacementStep.get_ChainedOutputStep"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT get_ChainedOutputStep([NativeTypeName("ABI::Windows::Devices::SmartCards::ISmartCardCryptogramPlacementStep **")] ISmartCardCryptogramPlacementStep** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardCryptogramPlacementStep*, ISmartCardCryptogramPlacementStep**, int>)(lpVtbl[22]))((ISmartCardCryptogramPlacementStep*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmartCardCryptogramPlacementStep.xml' path='doc/member[@name="ISmartCardCryptogramPlacementStep.put_ChainedOutputStep"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT put_ChainedOutputStep([NativeTypeName("ABI::Windows::Devices::SmartCards::ISmartCardCryptogramPlacementStep *")] ISmartCardCryptogramPlacementStep* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardCryptogramPlacementStep*, ISmartCardCryptogramPlacementStep*, int>)(lpVtbl[23]))((ISmartCardCryptogramPlacementStep*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Algorithm([NativeTypeName("ABI::Windows::Devices::SmartCards::SmartCardCryptogramAlgorithm *")] SmartCardCryptogramAlgorithm* value);

        [VtblIndex(7)]
        HRESULT put_Algorithm([NativeTypeName("ABI::Windows::Devices::SmartCards::SmartCardCryptogramAlgorithm")] SmartCardCryptogramAlgorithm value);

        [VtblIndex(8)]
        HRESULT get_SourceData([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer** value);

        [VtblIndex(9)]
        HRESULT put_SourceData([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* value);

        [VtblIndex(10)]
        HRESULT get_CryptogramMaterialPackageName(HSTRING* value);

        [VtblIndex(11)]
        HRESULT put_CryptogramMaterialPackageName(HSTRING value);

        [VtblIndex(12)]
        HRESULT get_CryptogramMaterialName(HSTRING* value);

        [VtblIndex(13)]
        HRESULT put_CryptogramMaterialName(HSTRING value);

        [VtblIndex(14)]
        HRESULT get_TemplateOffset([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(15)]
        HRESULT put_TemplateOffset([NativeTypeName("INT32")] int value);

        [VtblIndex(16)]
        HRESULT get_CryptogramOffset([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(17)]
        HRESULT put_CryptogramOffset([NativeTypeName("INT32")] int value);

        [VtblIndex(18)]
        HRESULT get_CryptogramLength([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(19)]
        HRESULT put_CryptogramLength([NativeTypeName("INT32")] int value);

        [VtblIndex(20)]
        HRESULT get_CryptogramPlacementOptions([NativeTypeName("ABI::Windows::Devices::SmartCards::SmartCardCryptogramPlacementOptions *")] SmartCardCryptogramPlacementOptions* value);

        [VtblIndex(21)]
        HRESULT put_CryptogramPlacementOptions([NativeTypeName("ABI::Windows::Devices::SmartCards::SmartCardCryptogramPlacementOptions")] SmartCardCryptogramPlacementOptions value);

        [VtblIndex(22)]
        HRESULT get_ChainedOutputStep([NativeTypeName("ABI::Windows::Devices::SmartCards::ISmartCardCryptogramPlacementStep **")] ISmartCardCryptogramPlacementStep** value);

        [VtblIndex(23)]
        HRESULT put_ChainedOutputStep([NativeTypeName("ABI::Windows::Devices::SmartCards::ISmartCardCryptogramPlacementStep *")] ISmartCardCryptogramPlacementStep* value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Devices::SmartCards::SmartCardCryptogramAlgorithm *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, SmartCardCryptogramAlgorithm*, int> get_Algorithm;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::SmartCards::SmartCardCryptogramAlgorithm) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, SmartCardCryptogramAlgorithm, int> put_Algorithm;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IBuffer **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBuffer**, int> get_SourceData;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IBuffer *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBuffer*, int> put_SourceData;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_CryptogramMaterialPackageName;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_CryptogramMaterialPackageName;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_CryptogramMaterialName;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_CryptogramMaterialName;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_TemplateOffset;

        [NativeTypeName("HRESULT (INT32) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, int> put_TemplateOffset;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_CryptogramOffset;

        [NativeTypeName("HRESULT (INT32) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, int> put_CryptogramOffset;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_CryptogramLength;

        [NativeTypeName("HRESULT (INT32) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, int> put_CryptogramLength;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::SmartCards::SmartCardCryptogramPlacementOptions *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, SmartCardCryptogramPlacementOptions*, int> get_CryptogramPlacementOptions;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::SmartCards::SmartCardCryptogramPlacementOptions) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, SmartCardCryptogramPlacementOptions, int> put_CryptogramPlacementOptions;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::SmartCards::ISmartCardCryptogramPlacementStep **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ISmartCardCryptogramPlacementStep**, int> get_ChainedOutputStep;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::SmartCards::ISmartCardCryptogramPlacementStep *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ISmartCardCryptogramPlacementStep*, int> put_ChainedOutputStep;
    }
}
