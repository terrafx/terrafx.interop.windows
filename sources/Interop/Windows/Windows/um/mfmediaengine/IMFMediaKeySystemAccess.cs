// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[Guid("AEC63FDA-7A97-4944-B35C-6C6DF8085CC3")]
[NativeTypeName("struct IMFMediaKeySystemAccess : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMFMediaKeySystemAccess : IMFMediaKeySystemAccess.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFMediaKeySystemAccess*, Guid*, void**, int>)(lpVtbl[0]))((IMFMediaKeySystemAccess*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFMediaKeySystemAccess*, uint>)(lpVtbl[1]))((IMFMediaKeySystemAccess*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFMediaKeySystemAccess*, uint>)(lpVtbl[2]))((IMFMediaKeySystemAccess*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT CreateMediaKeys(IPropertyStore* pCdmCustomConfig, IMFMediaKeys2** ppKeys)
    {
        return ((delegate* unmanaged<IMFMediaKeySystemAccess*, IPropertyStore*, IMFMediaKeys2**, int>)(lpVtbl[3]))((IMFMediaKeySystemAccess*)Unsafe.AsPointer(ref this), pCdmCustomConfig, ppKeys);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT get_SupportedConfiguration(IPropertyStore** ppSupportedConfiguration)
    {
        return ((delegate* unmanaged<IMFMediaKeySystemAccess*, IPropertyStore**, int>)(lpVtbl[4]))((IMFMediaKeySystemAccess*)Unsafe.AsPointer(ref this), ppSupportedConfiguration);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT get_KeySystem([NativeTypeName("BSTR *")] ushort** pKeySystem)
    {
        return ((delegate* unmanaged<IMFMediaKeySystemAccess*, ushort**, int>)(lpVtbl[5]))((IMFMediaKeySystemAccess*)Unsafe.AsPointer(ref this), pKeySystem);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT CreateMediaKeys(IPropertyStore* pCdmCustomConfig, IMFMediaKeys2** ppKeys);

        [VtblIndex(4)]
        HRESULT get_SupportedConfiguration(IPropertyStore** ppSupportedConfiguration);

        [VtblIndex(5)]
        HRESULT get_KeySystem([NativeTypeName("BSTR *")] ushort** pKeySystem);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<IMFMediaKeySystemAccess*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IMFMediaKeySystemAccess*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IMFMediaKeySystemAccess*, uint> Release;

        [NativeTypeName("HRESULT (IPropertyStore *, IMFMediaKeys2 **) __attribute__((stdcall))")]
        public delegate* unmanaged<IMFMediaKeySystemAccess*, IPropertyStore*, IMFMediaKeys2**, int> CreateMediaKeys;

        [NativeTypeName("HRESULT (IPropertyStore **) __attribute__((stdcall))")]
        public delegate* unmanaged<IMFMediaKeySystemAccess*, IPropertyStore**, int> get_SupportedConfiguration;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<IMFMediaKeySystemAccess*, ushort**, int> get_KeySystem;
    }
}
