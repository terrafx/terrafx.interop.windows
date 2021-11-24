// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[Guid("7E9FB0D3-919F-4307-AB2E-9B1860310C93")]
[NativeTypeName("struct IShellItem2 : IShellItem")]
[NativeInheritance("IShellItem")]
public unsafe partial struct IShellItem2 : IShellItem2.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IShellItem2*, Guid*, void**, int>)(lpVtbl[0]))((IShellItem2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IShellItem2*, uint>)(lpVtbl[1]))((IShellItem2*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IShellItem2*, uint>)(lpVtbl[2]))((IShellItem2*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT BindToHandler(IBindCtx* pbc, [NativeTypeName("const GUID &")] Guid* bhid, [NativeTypeName("const IID &")] Guid* riid, void** ppv)
    {
        return ((delegate* unmanaged<IShellItem2*, IBindCtx*, Guid*, Guid*, void**, int>)(lpVtbl[3]))((IShellItem2*)Unsafe.AsPointer(ref this), pbc, bhid, riid, ppv);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetParent(IShellItem** ppsi)
    {
        return ((delegate* unmanaged<IShellItem2*, IShellItem**, int>)(lpVtbl[4]))((IShellItem2*)Unsafe.AsPointer(ref this), ppsi);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetDisplayName(SIGDN sigdnName, [NativeTypeName("LPWSTR *")] ushort** ppszName)
    {
        return ((delegate* unmanaged<IShellItem2*, SIGDN, ushort**, int>)(lpVtbl[5]))((IShellItem2*)Unsafe.AsPointer(ref this), sigdnName, ppszName);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetAttributes([NativeTypeName("SFGAOF")] uint sfgaoMask, [NativeTypeName("SFGAOF *")] uint* psfgaoAttribs)
    {
        return ((delegate* unmanaged<IShellItem2*, uint, uint*, int>)(lpVtbl[6]))((IShellItem2*)Unsafe.AsPointer(ref this), sfgaoMask, psfgaoAttribs);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT Compare(IShellItem* psi, [NativeTypeName("SICHINTF")] uint hint, int* piOrder)
    {
        return ((delegate* unmanaged<IShellItem2*, IShellItem*, uint, int*, int>)(lpVtbl[7]))((IShellItem2*)Unsafe.AsPointer(ref this), psi, hint, piOrder);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetPropertyStore(GETPROPERTYSTOREFLAGS flags, [NativeTypeName("const IID &")] Guid* riid, void** ppv)
    {
        return ((delegate* unmanaged<IShellItem2*, GETPROPERTYSTOREFLAGS, Guid*, void**, int>)(lpVtbl[8]))((IShellItem2*)Unsafe.AsPointer(ref this), flags, riid, ppv);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetPropertyStoreWithCreateObject(GETPROPERTYSTOREFLAGS flags, IUnknown* punkCreateObject, [NativeTypeName("const IID &")] Guid* riid, void** ppv)
    {
        return ((delegate* unmanaged<IShellItem2*, GETPROPERTYSTOREFLAGS, IUnknown*, Guid*, void**, int>)(lpVtbl[9]))((IShellItem2*)Unsafe.AsPointer(ref this), flags, punkCreateObject, riid, ppv);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetPropertyStoreForKeys([NativeTypeName("const PROPERTYKEY *")] PROPERTYKEY* rgKeys, uint cKeys, GETPROPERTYSTOREFLAGS flags, [NativeTypeName("const IID &")] Guid* riid, void** ppv)
    {
        return ((delegate* unmanaged<IShellItem2*, PROPERTYKEY*, uint, GETPROPERTYSTOREFLAGS, Guid*, void**, int>)(lpVtbl[10]))((IShellItem2*)Unsafe.AsPointer(ref this), rgKeys, cKeys, flags, riid, ppv);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetPropertyDescriptionList([NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* keyType, [NativeTypeName("const IID &")] Guid* riid, void** ppv)
    {
        return ((delegate* unmanaged<IShellItem2*, PROPERTYKEY*, Guid*, void**, int>)(lpVtbl[11]))((IShellItem2*)Unsafe.AsPointer(ref this), keyType, riid, ppv);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT Update(IBindCtx* pbc)
    {
        return ((delegate* unmanaged<IShellItem2*, IBindCtx*, int>)(lpVtbl[12]))((IShellItem2*)Unsafe.AsPointer(ref this), pbc);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetProperty([NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* key, PROPVARIANT* ppropvar)
    {
        return ((delegate* unmanaged<IShellItem2*, PROPERTYKEY*, PROPVARIANT*, int>)(lpVtbl[13]))((IShellItem2*)Unsafe.AsPointer(ref this), key, ppropvar);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetCLSID([NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* key, [NativeTypeName("CLSID *")] Guid* pclsid)
    {
        return ((delegate* unmanaged<IShellItem2*, PROPERTYKEY*, Guid*, int>)(lpVtbl[14]))((IShellItem2*)Unsafe.AsPointer(ref this), key, pclsid);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT GetFileTime([NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* key, FILETIME* pft)
    {
        return ((delegate* unmanaged<IShellItem2*, PROPERTYKEY*, FILETIME*, int>)(lpVtbl[15]))((IShellItem2*)Unsafe.AsPointer(ref this), key, pft);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT GetInt32([NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* key, int* pi)
    {
        return ((delegate* unmanaged<IShellItem2*, PROPERTYKEY*, int*, int>)(lpVtbl[16]))((IShellItem2*)Unsafe.AsPointer(ref this), key, pi);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT GetString([NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* key, [NativeTypeName("LPWSTR *")] ushort** ppsz)
    {
        return ((delegate* unmanaged<IShellItem2*, PROPERTYKEY*, ushort**, int>)(lpVtbl[17]))((IShellItem2*)Unsafe.AsPointer(ref this), key, ppsz);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT GetUInt32([NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* key, [NativeTypeName("ULONG *")] uint* pui)
    {
        return ((delegate* unmanaged<IShellItem2*, PROPERTYKEY*, uint*, int>)(lpVtbl[18]))((IShellItem2*)Unsafe.AsPointer(ref this), key, pui);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT GetUInt64([NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* key, [NativeTypeName("ULONGLONG *")] ulong* pull)
    {
        return ((delegate* unmanaged<IShellItem2*, PROPERTYKEY*, ulong*, int>)(lpVtbl[19]))((IShellItem2*)Unsafe.AsPointer(ref this), key, pull);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT GetBool([NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* key, BOOL* pf)
    {
        return ((delegate* unmanaged<IShellItem2*, PROPERTYKEY*, BOOL*, int>)(lpVtbl[20]))((IShellItem2*)Unsafe.AsPointer(ref this), key, pf);
    }

    public interface Interface : IShellItem.Interface
    {
        [VtblIndex(8)]
        HRESULT GetPropertyStore(GETPROPERTYSTOREFLAGS flags, [NativeTypeName("const IID &")] Guid* riid, void** ppv);

        [VtblIndex(9)]
        HRESULT GetPropertyStoreWithCreateObject(GETPROPERTYSTOREFLAGS flags, IUnknown* punkCreateObject, [NativeTypeName("const IID &")] Guid* riid, void** ppv);

        [VtblIndex(10)]
        HRESULT GetPropertyStoreForKeys([NativeTypeName("const PROPERTYKEY *")] PROPERTYKEY* rgKeys, uint cKeys, GETPROPERTYSTOREFLAGS flags, [NativeTypeName("const IID &")] Guid* riid, void** ppv);

        [VtblIndex(11)]
        HRESULT GetPropertyDescriptionList([NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* keyType, [NativeTypeName("const IID &")] Guid* riid, void** ppv);

        [VtblIndex(12)]
        HRESULT Update(IBindCtx* pbc);

        [VtblIndex(13)]
        HRESULT GetProperty([NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* key, PROPVARIANT* ppropvar);

        [VtblIndex(14)]
        HRESULT GetCLSID([NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* key, [NativeTypeName("CLSID *")] Guid* pclsid);

        [VtblIndex(15)]
        HRESULT GetFileTime([NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* key, FILETIME* pft);

        [VtblIndex(16)]
        HRESULT GetInt32([NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* key, int* pi);

        [VtblIndex(17)]
        HRESULT GetString([NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* key, [NativeTypeName("LPWSTR *")] ushort** ppsz);

        [VtblIndex(18)]
        HRESULT GetUInt32([NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* key, [NativeTypeName("ULONG *")] uint* pui);

        [VtblIndex(19)]
        HRESULT GetUInt64([NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* key, [NativeTypeName("ULONGLONG *")] ulong* pull);

        [VtblIndex(20)]
        HRESULT GetBool([NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* key, BOOL* pf);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<IShellItem2*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IShellItem2*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IShellItem2*, uint> Release;

        [NativeTypeName("HRESULT (IBindCtx *, const GUID &, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<IShellItem2*, IBindCtx*, Guid*, Guid*, void**, int> BindToHandler;

        [NativeTypeName("HRESULT (IShellItem **) __attribute__((stdcall))")]
        public delegate* unmanaged<IShellItem2*, IShellItem**, int> GetParent;

        [NativeTypeName("HRESULT (SIGDN, LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<IShellItem2*, SIGDN, ushort**, int> GetDisplayName;

        [NativeTypeName("HRESULT (SFGAOF, SFGAOF *) __attribute__((stdcall))")]
        public delegate* unmanaged<IShellItem2*, uint, uint*, int> GetAttributes;

        [NativeTypeName("HRESULT (IShellItem *, SICHINTF, int *) __attribute__((stdcall))")]
        public delegate* unmanaged<IShellItem2*, IShellItem*, uint, int*, int> Compare;

        [NativeTypeName("HRESULT (GETPROPERTYSTOREFLAGS, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<IShellItem2*, GETPROPERTYSTOREFLAGS, Guid*, void**, int> GetPropertyStore;

        [NativeTypeName("HRESULT (GETPROPERTYSTOREFLAGS, IUnknown *, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<IShellItem2*, GETPROPERTYSTOREFLAGS, IUnknown*, Guid*, void**, int> GetPropertyStoreWithCreateObject;

        [NativeTypeName("HRESULT (const PROPERTYKEY *, UINT, GETPROPERTYSTOREFLAGS, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<IShellItem2*, PROPERTYKEY*, uint, GETPROPERTYSTOREFLAGS, Guid*, void**, int> GetPropertyStoreForKeys;

        [NativeTypeName("HRESULT (const PROPERTYKEY &, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<IShellItem2*, PROPERTYKEY*, Guid*, void**, int> GetPropertyDescriptionList;

        [NativeTypeName("HRESULT (IBindCtx *) __attribute__((stdcall))")]
        public delegate* unmanaged<IShellItem2*, IBindCtx*, int> Update;

        [NativeTypeName("HRESULT (const PROPERTYKEY &, PROPVARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<IShellItem2*, PROPERTYKEY*, PROPVARIANT*, int> GetProperty;

        [NativeTypeName("HRESULT (const PROPERTYKEY &, CLSID *) __attribute__((stdcall))")]
        public delegate* unmanaged<IShellItem2*, PROPERTYKEY*, Guid*, int> GetCLSID;

        [NativeTypeName("HRESULT (const PROPERTYKEY &, FILETIME *) __attribute__((stdcall))")]
        public delegate* unmanaged<IShellItem2*, PROPERTYKEY*, FILETIME*, int> GetFileTime;

        [NativeTypeName("HRESULT (const PROPERTYKEY &, int *) __attribute__((stdcall))")]
        public delegate* unmanaged<IShellItem2*, PROPERTYKEY*, int*, int> GetInt32;

        [NativeTypeName("HRESULT (const PROPERTYKEY &, LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<IShellItem2*, PROPERTYKEY*, ushort**, int> GetString;

        [NativeTypeName("HRESULT (const PROPERTYKEY &, ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<IShellItem2*, PROPERTYKEY*, uint*, int> GetUInt32;

        [NativeTypeName("HRESULT (const PROPERTYKEY &, ULONGLONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<IShellItem2*, PROPERTYKEY*, ulong*, int> GetUInt64;

        [NativeTypeName("HRESULT (const PROPERTYKEY &, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<IShellItem2*, PROPERTYKEY*, BOOL*, int> GetBool;
    }
}
