// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.foundation.metadata.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IApiInformationStatics.xml' path='doc/member[@name="IApiInformationStatics"]/*' />
[Guid("997439FE-F681-4A11-B416-C13A47E8BA36")]
[NativeTypeName("struct IApiInformationStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IApiInformationStatics : IApiInformationStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IApiInformationStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IApiInformationStatics*, Guid*, void**, int>)(lpVtbl[0]))((IApiInformationStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IApiInformationStatics*, uint>)(lpVtbl[1]))((IApiInformationStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IApiInformationStatics*, uint>)(lpVtbl[2]))((IApiInformationStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged<IApiInformationStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IApiInformationStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IApiInformationStatics*, HSTRING*, int>)(lpVtbl[4]))((IApiInformationStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IApiInformationStatics*, TrustLevel*, int>)(lpVtbl[5]))((IApiInformationStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IApiInformationStatics.xml' path='doc/member[@name="IApiInformationStatics.IsTypePresent"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT IsTypePresent(HSTRING typeName, [NativeTypeName("boolean *")] byte* result)
    {
        return ((delegate* unmanaged<IApiInformationStatics*, HSTRING, byte*, int>)(lpVtbl[6]))((IApiInformationStatics*)Unsafe.AsPointer(ref this), typeName, result);
    }

    /// <include file='IApiInformationStatics.xml' path='doc/member[@name="IApiInformationStatics.IsMethodPresent"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT IsMethodPresent(HSTRING typeName, HSTRING methodName, [NativeTypeName("boolean *")] byte* result)
    {
        return ((delegate* unmanaged<IApiInformationStatics*, HSTRING, HSTRING, byte*, int>)(lpVtbl[7]))((IApiInformationStatics*)Unsafe.AsPointer(ref this), typeName, methodName, result);
    }

    /// <include file='IApiInformationStatics.xml' path='doc/member[@name="IApiInformationStatics.IsMethodPresentWithArity"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT IsMethodPresentWithArity(HSTRING typeName, HSTRING methodName, [NativeTypeName("UINT32")] uint inputParameterCount, [NativeTypeName("boolean *")] byte* result)
    {
        return ((delegate* unmanaged<IApiInformationStatics*, HSTRING, HSTRING, uint, byte*, int>)(lpVtbl[8]))((IApiInformationStatics*)Unsafe.AsPointer(ref this), typeName, methodName, inputParameterCount, result);
    }

    /// <include file='IApiInformationStatics.xml' path='doc/member[@name="IApiInformationStatics.IsEventPresent"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT IsEventPresent(HSTRING typeName, HSTRING eventName, [NativeTypeName("boolean *")] byte* result)
    {
        return ((delegate* unmanaged<IApiInformationStatics*, HSTRING, HSTRING, byte*, int>)(lpVtbl[9]))((IApiInformationStatics*)Unsafe.AsPointer(ref this), typeName, eventName, result);
    }

    /// <include file='IApiInformationStatics.xml' path='doc/member[@name="IApiInformationStatics.IsPropertyPresent"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT IsPropertyPresent(HSTRING typeName, HSTRING propertyName, [NativeTypeName("boolean *")] byte* result)
    {
        return ((delegate* unmanaged<IApiInformationStatics*, HSTRING, HSTRING, byte*, int>)(lpVtbl[10]))((IApiInformationStatics*)Unsafe.AsPointer(ref this), typeName, propertyName, result);
    }

    /// <include file='IApiInformationStatics.xml' path='doc/member[@name="IApiInformationStatics.IsReadOnlyPropertyPresent"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT IsReadOnlyPropertyPresent(HSTRING typeName, HSTRING propertyName, [NativeTypeName("boolean *")] byte* result)
    {
        return ((delegate* unmanaged<IApiInformationStatics*, HSTRING, HSTRING, byte*, int>)(lpVtbl[11]))((IApiInformationStatics*)Unsafe.AsPointer(ref this), typeName, propertyName, result);
    }

    /// <include file='IApiInformationStatics.xml' path='doc/member[@name="IApiInformationStatics.IsWriteablePropertyPresent"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT IsWriteablePropertyPresent(HSTRING typeName, HSTRING propertyName, [NativeTypeName("boolean *")] byte* result)
    {
        return ((delegate* unmanaged<IApiInformationStatics*, HSTRING, HSTRING, byte*, int>)(lpVtbl[12]))((IApiInformationStatics*)Unsafe.AsPointer(ref this), typeName, propertyName, result);
    }

    /// <include file='IApiInformationStatics.xml' path='doc/member[@name="IApiInformationStatics.IsEnumNamedValuePresent"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT IsEnumNamedValuePresent(HSTRING enumTypeName, HSTRING valueName, [NativeTypeName("boolean *")] byte* result)
    {
        return ((delegate* unmanaged<IApiInformationStatics*, HSTRING, HSTRING, byte*, int>)(lpVtbl[13]))((IApiInformationStatics*)Unsafe.AsPointer(ref this), enumTypeName, valueName, result);
    }

    /// <include file='IApiInformationStatics.xml' path='doc/member[@name="IApiInformationStatics.IsApiContractPresentByMajor"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT IsApiContractPresentByMajor(HSTRING contractName, [NativeTypeName("UINT16")] ushort majorVersion, [NativeTypeName("boolean *")] byte* result)
    {
        return ((delegate* unmanaged<IApiInformationStatics*, HSTRING, ushort, byte*, int>)(lpVtbl[14]))((IApiInformationStatics*)Unsafe.AsPointer(ref this), contractName, majorVersion, result);
    }

    /// <include file='IApiInformationStatics.xml' path='doc/member[@name="IApiInformationStatics.IsApiContractPresentByMajorAndMinor"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT IsApiContractPresentByMajorAndMinor(HSTRING contractName, [NativeTypeName("UINT16")] ushort majorVersion, [NativeTypeName("UINT16")] ushort minorVersion, [NativeTypeName("boolean *")] byte* result)
    {
        return ((delegate* unmanaged<IApiInformationStatics*, HSTRING, ushort, ushort, byte*, int>)(lpVtbl[15]))((IApiInformationStatics*)Unsafe.AsPointer(ref this), contractName, majorVersion, minorVersion, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT IsTypePresent(HSTRING typeName, [NativeTypeName("boolean *")] byte* result);

        [VtblIndex(7)]
        HRESULT IsMethodPresent(HSTRING typeName, HSTRING methodName, [NativeTypeName("boolean *")] byte* result);

        [VtblIndex(8)]
        HRESULT IsMethodPresentWithArity(HSTRING typeName, HSTRING methodName, [NativeTypeName("UINT32")] uint inputParameterCount, [NativeTypeName("boolean *")] byte* result);

        [VtblIndex(9)]
        HRESULT IsEventPresent(HSTRING typeName, HSTRING eventName, [NativeTypeName("boolean *")] byte* result);

        [VtblIndex(10)]
        HRESULT IsPropertyPresent(HSTRING typeName, HSTRING propertyName, [NativeTypeName("boolean *")] byte* result);

        [VtblIndex(11)]
        HRESULT IsReadOnlyPropertyPresent(HSTRING typeName, HSTRING propertyName, [NativeTypeName("boolean *")] byte* result);

        [VtblIndex(12)]
        HRESULT IsWriteablePropertyPresent(HSTRING typeName, HSTRING propertyName, [NativeTypeName("boolean *")] byte* result);

        [VtblIndex(13)]
        HRESULT IsEnumNamedValuePresent(HSTRING enumTypeName, HSTRING valueName, [NativeTypeName("boolean *")] byte* result);

        [VtblIndex(14)]
        HRESULT IsApiContractPresentByMajor(HSTRING contractName, [NativeTypeName("UINT16")] ushort majorVersion, [NativeTypeName("boolean *")] byte* result);

        [VtblIndex(15)]
        HRESULT IsApiContractPresentByMajorAndMinor(HSTRING contractName, [NativeTypeName("UINT16")] ushort majorVersion, [NativeTypeName("UINT16")] ushort minorVersion, [NativeTypeName("boolean *")] byte* result);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> Release;

        [NativeTypeName("HRESULT (ULONG *, IID **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, Guid**, int> GetIids;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> GetRuntimeClassName;

        [NativeTypeName("HRESULT (TrustLevel *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, TrustLevel*, int> GetTrustLevel;

        [NativeTypeName("HRESULT (HSTRING, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, byte*, int> IsTypePresent;

        [NativeTypeName("HRESULT (HSTRING, HSTRING, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, HSTRING, byte*, int> IsMethodPresent;

        [NativeTypeName("HRESULT (HSTRING, HSTRING, UINT32, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, HSTRING, uint, byte*, int> IsMethodPresentWithArity;

        [NativeTypeName("HRESULT (HSTRING, HSTRING, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, HSTRING, byte*, int> IsEventPresent;

        [NativeTypeName("HRESULT (HSTRING, HSTRING, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, HSTRING, byte*, int> IsPropertyPresent;

        [NativeTypeName("HRESULT (HSTRING, HSTRING, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, HSTRING, byte*, int> IsReadOnlyPropertyPresent;

        [NativeTypeName("HRESULT (HSTRING, HSTRING, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, HSTRING, byte*, int> IsWriteablePropertyPresent;

        [NativeTypeName("HRESULT (HSTRING, HSTRING, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, HSTRING, byte*, int> IsEnumNamedValuePresent;

        [NativeTypeName("HRESULT (HSTRING, UINT16, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, ushort, byte*, int> IsApiContractPresentByMajor;

        [NativeTypeName("HRESULT (HSTRING, UINT16, UINT16, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, ushort, ushort, byte*, int> IsApiContractPresentByMajorAndMinor;
    }
}
