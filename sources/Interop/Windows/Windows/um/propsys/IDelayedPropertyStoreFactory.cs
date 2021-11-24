// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/propsys.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[Guid("40D4577F-E237-4BDB-BD69-58F089431B6A")]
[NativeTypeName("struct IDelayedPropertyStoreFactory : IPropertyStoreFactory")]
[NativeInheritance("IPropertyStoreFactory")]
public unsafe partial struct IDelayedPropertyStoreFactory : IDelayedPropertyStoreFactory.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDelayedPropertyStoreFactory*, Guid*, void**, int>)(lpVtbl[0]))((IDelayedPropertyStoreFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDelayedPropertyStoreFactory*, uint>)(lpVtbl[1]))((IDelayedPropertyStoreFactory*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDelayedPropertyStoreFactory*, uint>)(lpVtbl[2]))((IDelayedPropertyStoreFactory*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetPropertyStore(GETPROPERTYSTOREFLAGS flags, IUnknown* pUnkFactory, [NativeTypeName("const IID &")] Guid* riid, void** ppv)
    {
        return ((delegate* unmanaged<IDelayedPropertyStoreFactory*, GETPROPERTYSTOREFLAGS, IUnknown*, Guid*, void**, int>)(lpVtbl[3]))((IDelayedPropertyStoreFactory*)Unsafe.AsPointer(ref this), flags, pUnkFactory, riid, ppv);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetPropertyStoreForKeys([NativeTypeName("const PROPERTYKEY *")] PROPERTYKEY* rgKeys, uint cKeys, GETPROPERTYSTOREFLAGS flags, [NativeTypeName("const IID &")] Guid* riid, void** ppv)
    {
        return ((delegate* unmanaged<IDelayedPropertyStoreFactory*, PROPERTYKEY*, uint, GETPROPERTYSTOREFLAGS, Guid*, void**, int>)(lpVtbl[4]))((IDelayedPropertyStoreFactory*)Unsafe.AsPointer(ref this), rgKeys, cKeys, flags, riid, ppv);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetDelayedPropertyStore(GETPROPERTYSTOREFLAGS flags, [NativeTypeName("DWORD")] uint dwStoreId, [NativeTypeName("const IID &")] Guid* riid, void** ppv)
    {
        return ((delegate* unmanaged<IDelayedPropertyStoreFactory*, GETPROPERTYSTOREFLAGS, uint, Guid*, void**, int>)(lpVtbl[5]))((IDelayedPropertyStoreFactory*)Unsafe.AsPointer(ref this), flags, dwStoreId, riid, ppv);
    }

    public interface Interface : IPropertyStoreFactory.Interface
    {
        [VtblIndex(5)]
        HRESULT GetDelayedPropertyStore(GETPROPERTYSTOREFLAGS flags, [NativeTypeName("DWORD")] uint dwStoreId, [NativeTypeName("const IID &")] Guid* riid, void** ppv);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<IDelayedPropertyStoreFactory*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IDelayedPropertyStoreFactory*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IDelayedPropertyStoreFactory*, uint> Release;

        [NativeTypeName("HRESULT (GETPROPERTYSTOREFLAGS, IUnknown *, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<IDelayedPropertyStoreFactory*, GETPROPERTYSTOREFLAGS, IUnknown*, Guid*, void**, int> GetPropertyStore;

        [NativeTypeName("HRESULT (const PROPERTYKEY *, UINT, GETPROPERTYSTOREFLAGS, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<IDelayedPropertyStoreFactory*, PROPERTYKEY*, uint, GETPROPERTYSTOREFLAGS, Guid*, void**, int> GetPropertyStoreForKeys;

        [NativeTypeName("HRESULT (GETPROPERTYSTOREFLAGS, DWORD, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<IDelayedPropertyStoreFactory*, GETPROPERTYSTOREFLAGS, uint, Guid*, void**, int> GetDelayedPropertyStore;
    }
}
