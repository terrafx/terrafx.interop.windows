// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='ISpObjectToken.xml' path='doc/member[@name="ISpObjectToken"]/*' />
[Guid("14056589-E16C-11D2-BB90-00C04F8EE6C0")]
[NativeTypeName("struct ISpObjectToken : ISpDataKey")]
[NativeInheritance("ISpDataKey")]
public unsafe partial struct ISpObjectToken : ISpObjectToken.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISpObjectToken));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpObjectToken*, Guid*, void**, int>)(lpVtbl[0]))((ISpObjectToken*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISpObjectToken*, uint>)(lpVtbl[1]))((ISpObjectToken*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISpObjectToken*, uint>)(lpVtbl[2]))((ISpObjectToken*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="ISpDataKey.SetData" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetData([NativeTypeName("LPCWSTR")] char* pszValueName, [NativeTypeName("ULONG")] uint cbData, [NativeTypeName("const BYTE *")] byte* pData)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpObjectToken*, char*, uint, byte*, int>)(lpVtbl[3]))((ISpObjectToken*)Unsafe.AsPointer(ref this), pszValueName, cbData, pData);
    }

    /// <inheritdoc cref="ISpDataKey.GetData" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetData([NativeTypeName("LPCWSTR")] char* pszValueName, [NativeTypeName("ULONG *")] uint* pcbData, byte* pData)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpObjectToken*, char*, uint*, byte*, int>)(lpVtbl[4]))((ISpObjectToken*)Unsafe.AsPointer(ref this), pszValueName, pcbData, pData);
    }

    /// <inheritdoc cref="ISpDataKey.SetStringValue" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetStringValue([NativeTypeName("LPCWSTR")] char* pszValueName, [NativeTypeName("LPCWSTR")] char* pszValue)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpObjectToken*, char*, char*, int>)(lpVtbl[5]))((ISpObjectToken*)Unsafe.AsPointer(ref this), pszValueName, pszValue);
    }

    /// <inheritdoc cref="ISpDataKey.GetStringValue" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetStringValue([NativeTypeName("LPCWSTR")] char* pszValueName, [NativeTypeName("LPWSTR *")] char** ppszValue)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpObjectToken*, char*, char**, int>)(lpVtbl[6]))((ISpObjectToken*)Unsafe.AsPointer(ref this), pszValueName, ppszValue);
    }

    /// <inheritdoc cref="ISpDataKey.SetDWORD" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetDWORD([NativeTypeName("LPCWSTR")] char* pszValueName, [NativeTypeName("DWORD")] uint dwValue)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpObjectToken*, char*, uint, int>)(lpVtbl[7]))((ISpObjectToken*)Unsafe.AsPointer(ref this), pszValueName, dwValue);
    }

    /// <inheritdoc cref="ISpDataKey.GetDWORD" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetDWORD([NativeTypeName("LPCWSTR")] char* pszValueName, [NativeTypeName("DWORD *")] uint* pdwValue)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpObjectToken*, char*, uint*, int>)(lpVtbl[8]))((ISpObjectToken*)Unsafe.AsPointer(ref this), pszValueName, pdwValue);
    }

    /// <inheritdoc cref="ISpDataKey.OpenKey" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT OpenKey([NativeTypeName("LPCWSTR")] char* pszSubKeyName, ISpDataKey** ppSubKey)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpObjectToken*, char*, ISpDataKey**, int>)(lpVtbl[9]))((ISpObjectToken*)Unsafe.AsPointer(ref this), pszSubKeyName, ppSubKey);
    }

    /// <inheritdoc cref="ISpDataKey.CreateKey" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT CreateKey([NativeTypeName("LPCWSTR")] char* pszSubKey, ISpDataKey** ppSubKey)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpObjectToken*, char*, ISpDataKey**, int>)(lpVtbl[10]))((ISpObjectToken*)Unsafe.AsPointer(ref this), pszSubKey, ppSubKey);
    }

    /// <inheritdoc cref="ISpDataKey.DeleteKey" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT DeleteKey([NativeTypeName("LPCWSTR")] char* pszSubKey)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpObjectToken*, char*, int>)(lpVtbl[11]))((ISpObjectToken*)Unsafe.AsPointer(ref this), pszSubKey);
    }

    /// <inheritdoc cref="ISpDataKey.DeleteValue" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT DeleteValue([NativeTypeName("LPCWSTR")] char* pszValueName)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpObjectToken*, char*, int>)(lpVtbl[12]))((ISpObjectToken*)Unsafe.AsPointer(ref this), pszValueName);
    }

    /// <inheritdoc cref="ISpDataKey.EnumKeys" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT EnumKeys([NativeTypeName("ULONG")] uint Index, [NativeTypeName("LPWSTR *")] char** ppszSubKeyName)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpObjectToken*, uint, char**, int>)(lpVtbl[13]))((ISpObjectToken*)Unsafe.AsPointer(ref this), Index, ppszSubKeyName);
    }

    /// <inheritdoc cref="ISpDataKey.EnumValues" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT EnumValues([NativeTypeName("ULONG")] uint Index, [NativeTypeName("LPWSTR *")] char** ppszValueName)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpObjectToken*, uint, char**, int>)(lpVtbl[14]))((ISpObjectToken*)Unsafe.AsPointer(ref this), Index, ppszValueName);
    }

    /// <include file='ISpObjectToken.xml' path='doc/member[@name="ISpObjectToken.SetId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT SetId([NativeTypeName("LPCWSTR")] char* pszCategoryId, [NativeTypeName("LPCWSTR")] char* pszTokenId, BOOL fCreateIfNotExist)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpObjectToken*, char*, char*, BOOL, int>)(lpVtbl[15]))((ISpObjectToken*)Unsafe.AsPointer(ref this), pszCategoryId, pszTokenId, fCreateIfNotExist);
    }

    /// <include file='ISpObjectToken.xml' path='doc/member[@name="ISpObjectToken.GetId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT GetId([NativeTypeName("LPWSTR *")] char** ppszCoMemTokenId)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpObjectToken*, char**, int>)(lpVtbl[16]))((ISpObjectToken*)Unsafe.AsPointer(ref this), ppszCoMemTokenId);
    }

    /// <include file='ISpObjectToken.xml' path='doc/member[@name="ISpObjectToken.GetCategory"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT GetCategory(ISpObjectTokenCategory** ppTokenCategory)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpObjectToken*, ISpObjectTokenCategory**, int>)(lpVtbl[17]))((ISpObjectToken*)Unsafe.AsPointer(ref this), ppTokenCategory);
    }

    /// <include file='ISpObjectToken.xml' path='doc/member[@name="ISpObjectToken.CreateInstance"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT CreateInstance(IUnknown* pUnkOuter, [NativeTypeName("DWORD")] uint dwClsContext, [NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpObjectToken*, IUnknown*, uint, Guid*, void**, int>)(lpVtbl[18]))((ISpObjectToken*)Unsafe.AsPointer(ref this), pUnkOuter, dwClsContext, riid, ppvObject);
    }

    /// <include file='ISpObjectToken.xml' path='doc/member[@name="ISpObjectToken.GetStorageFileName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT GetStorageFileName([NativeTypeName("const IID &")] Guid* clsidCaller, [NativeTypeName("LPCWSTR")] char* pszValueName, [NativeTypeName("LPCWSTR")] char* pszFileNameSpecifier, [NativeTypeName("ULONG")] uint nFolder, [NativeTypeName("LPWSTR *")] char** ppszFilePath)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpObjectToken*, Guid*, char*, char*, uint, char**, int>)(lpVtbl[19]))((ISpObjectToken*)Unsafe.AsPointer(ref this), clsidCaller, pszValueName, pszFileNameSpecifier, nFolder, ppszFilePath);
    }

    /// <include file='ISpObjectToken.xml' path='doc/member[@name="ISpObjectToken.RemoveStorageFileName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT RemoveStorageFileName([NativeTypeName("const IID &")] Guid* clsidCaller, [NativeTypeName("LPCWSTR")] char* pszKeyName, BOOL fDeleteFile)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpObjectToken*, Guid*, char*, BOOL, int>)(lpVtbl[20]))((ISpObjectToken*)Unsafe.AsPointer(ref this), clsidCaller, pszKeyName, fDeleteFile);
    }

    /// <include file='ISpObjectToken.xml' path='doc/member[@name="ISpObjectToken.Remove"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT Remove([NativeTypeName("const CLSID *")] Guid* pclsidCaller)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpObjectToken*, Guid*, int>)(lpVtbl[21]))((ISpObjectToken*)Unsafe.AsPointer(ref this), pclsidCaller);
    }

    /// <include file='ISpObjectToken.xml' path='doc/member[@name="ISpObjectToken.IsUISupported"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT IsUISupported([NativeTypeName("LPCWSTR")] char* pszTypeOfUI, void* pvExtraData, [NativeTypeName("ULONG")] uint cbExtraData, IUnknown* punkObject, BOOL* pfSupported)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpObjectToken*, char*, void*, uint, IUnknown*, BOOL*, int>)(lpVtbl[22]))((ISpObjectToken*)Unsafe.AsPointer(ref this), pszTypeOfUI, pvExtraData, cbExtraData, punkObject, pfSupported);
    }

    /// <include file='ISpObjectToken.xml' path='doc/member[@name="ISpObjectToken.DisplayUI"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT DisplayUI(HWND hwndParent, [NativeTypeName("LPCWSTR")] char* pszTitle, [NativeTypeName("LPCWSTR")] char* pszTypeOfUI, void* pvExtraData, [NativeTypeName("ULONG")] uint cbExtraData, IUnknown* punkObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpObjectToken*, HWND, char*, char*, void*, uint, IUnknown*, int>)(lpVtbl[23]))((ISpObjectToken*)Unsafe.AsPointer(ref this), hwndParent, pszTitle, pszTypeOfUI, pvExtraData, cbExtraData, punkObject);
    }

    /// <include file='ISpObjectToken.xml' path='doc/member[@name="ISpObjectToken.MatchesAttributes"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT MatchesAttributes([NativeTypeName("LPCWSTR")] char* pszAttributes, BOOL* pfMatches)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpObjectToken*, char*, BOOL*, int>)(lpVtbl[24]))((ISpObjectToken*)Unsafe.AsPointer(ref this), pszAttributes, pfMatches);
    }

    public interface Interface : ISpDataKey.Interface
    {
        [VtblIndex(15)]
        HRESULT SetId([NativeTypeName("LPCWSTR")] char* pszCategoryId, [NativeTypeName("LPCWSTR")] char* pszTokenId, BOOL fCreateIfNotExist);

        [VtblIndex(16)]
        HRESULT GetId([NativeTypeName("LPWSTR *")] char** ppszCoMemTokenId);

        [VtblIndex(17)]
        HRESULT GetCategory(ISpObjectTokenCategory** ppTokenCategory);

        [VtblIndex(18)]
        HRESULT CreateInstance(IUnknown* pUnkOuter, [NativeTypeName("DWORD")] uint dwClsContext, [NativeTypeName("const IID &")] Guid* riid, void** ppvObject);

        [VtblIndex(19)]
        HRESULT GetStorageFileName([NativeTypeName("const IID &")] Guid* clsidCaller, [NativeTypeName("LPCWSTR")] char* pszValueName, [NativeTypeName("LPCWSTR")] char* pszFileNameSpecifier, [NativeTypeName("ULONG")] uint nFolder, [NativeTypeName("LPWSTR *")] char** ppszFilePath);

        [VtblIndex(20)]
        HRESULT RemoveStorageFileName([NativeTypeName("const IID &")] Guid* clsidCaller, [NativeTypeName("LPCWSTR")] char* pszKeyName, BOOL fDeleteFile);

        [VtblIndex(21)]
        HRESULT Remove([NativeTypeName("const CLSID *")] Guid* pclsidCaller);

        [VtblIndex(22)]
        HRESULT IsUISupported([NativeTypeName("LPCWSTR")] char* pszTypeOfUI, void* pvExtraData, [NativeTypeName("ULONG")] uint cbExtraData, IUnknown* punkObject, BOOL* pfSupported);

        [VtblIndex(23)]
        HRESULT DisplayUI(HWND hwndParent, [NativeTypeName("LPCWSTR")] char* pszTitle, [NativeTypeName("LPCWSTR")] char* pszTypeOfUI, void* pvExtraData, [NativeTypeName("ULONG")] uint cbExtraData, IUnknown* punkObject);

        [VtblIndex(24)]
        HRESULT MatchesAttributes([NativeTypeName("LPCWSTR")] char* pszAttributes, BOOL* pfMatches);
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

        [NativeTypeName("HRESULT (LPCWSTR, ULONG, const BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, uint, byte*, int> SetData;

        [NativeTypeName("HRESULT (LPCWSTR, ULONG *, BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, uint*, byte*, int> GetData;

        [NativeTypeName("HRESULT (LPCWSTR, LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, char*, int> SetStringValue;

        [NativeTypeName("HRESULT (LPCWSTR, LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, char**, int> GetStringValue;

        [NativeTypeName("HRESULT (LPCWSTR, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, uint, int> SetDWORD;

        [NativeTypeName("HRESULT (LPCWSTR, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, uint*, int> GetDWORD;

        [NativeTypeName("HRESULT (LPCWSTR, ISpDataKey **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, ISpDataKey**, int> OpenKey;

        [NativeTypeName("HRESULT (LPCWSTR, ISpDataKey **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, ISpDataKey**, int> CreateKey;

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> DeleteKey;

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> DeleteValue;

        [NativeTypeName("HRESULT (ULONG, LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, char**, int> EnumKeys;

        [NativeTypeName("HRESULT (ULONG, LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, char**, int> EnumValues;

        [NativeTypeName("HRESULT (LPCWSTR, LPCWSTR, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, char*, BOOL, int> SetId;

        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> GetId;

        [NativeTypeName("HRESULT (ISpObjectTokenCategory **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ISpObjectTokenCategory**, int> GetCategory;

        [NativeTypeName("HRESULT (IUnknown *, DWORD, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUnknown*, uint, Guid*, void**, int> CreateInstance;

        [NativeTypeName("HRESULT (const IID &, LPCWSTR, LPCWSTR, ULONG, LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, char*, char*, uint, char**, int> GetStorageFileName;

        [NativeTypeName("HRESULT (const IID &, LPCWSTR, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, char*, BOOL, int> RemoveStorageFileName;

        [NativeTypeName("HRESULT (const CLSID *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> Remove;

        [NativeTypeName("HRESULT (LPCWSTR, void *, ULONG, IUnknown *, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, void*, uint, IUnknown*, BOOL*, int> IsUISupported;

        [NativeTypeName("HRESULT (HWND, LPCWSTR, LPCWSTR, void *, ULONG, IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HWND, char*, char*, void*, uint, IUnknown*, int> DisplayUI;

        [NativeTypeName("HRESULT (LPCWSTR, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, BOOL*, int> MatchesAttributes;
    }
}
