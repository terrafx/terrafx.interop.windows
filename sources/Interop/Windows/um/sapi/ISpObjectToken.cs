// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("14056589-E16C-11D2-BB90-00C04F8EE6C0")]
    [NativeTypeName("struct ISpObjectToken : ISpDataKey")]
    [NativeInheritance("ISpDataKey")]
    public unsafe partial struct ISpObjectToken
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISpObjectToken*, Guid*, void**, int>)(lpVtbl[0]))((ISpObjectToken*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISpObjectToken*, uint>)(lpVtbl[1]))((ISpObjectToken*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISpObjectToken*, uint>)(lpVtbl[2]))((ISpObjectToken*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT SetData([NativeTypeName("LPCWSTR")] ushort* pszValueName, [NativeTypeName("ULONG")] uint cbData, [NativeTypeName("const BYTE *")] byte* pData)
        {
            return ((delegate* unmanaged<ISpObjectToken*, ushort*, uint, byte*, int>)(lpVtbl[3]))((ISpObjectToken*)Unsafe.AsPointer(ref this), pszValueName, cbData, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetData([NativeTypeName("LPCWSTR")] ushort* pszValueName, [NativeTypeName("ULONG *")] uint* pcbData, byte* pData)
        {
            return ((delegate* unmanaged<ISpObjectToken*, ushort*, uint*, byte*, int>)(lpVtbl[4]))((ISpObjectToken*)Unsafe.AsPointer(ref this), pszValueName, pcbData, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT SetStringValue([NativeTypeName("LPCWSTR")] ushort* pszValueName, [NativeTypeName("LPCWSTR")] ushort* pszValue)
        {
            return ((delegate* unmanaged<ISpObjectToken*, ushort*, ushort*, int>)(lpVtbl[5]))((ISpObjectToken*)Unsafe.AsPointer(ref this), pszValueName, pszValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT GetStringValue([NativeTypeName("LPCWSTR")] ushort* pszValueName, [NativeTypeName("LPWSTR *")] ushort** ppszValue)
        {
            return ((delegate* unmanaged<ISpObjectToken*, ushort*, ushort**, int>)(lpVtbl[6]))((ISpObjectToken*)Unsafe.AsPointer(ref this), pszValueName, ppszValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT SetDWORD([NativeTypeName("LPCWSTR")] ushort* pszValueName, [NativeTypeName("DWORD")] uint dwValue)
        {
            return ((delegate* unmanaged<ISpObjectToken*, ushort*, uint, int>)(lpVtbl[7]))((ISpObjectToken*)Unsafe.AsPointer(ref this), pszValueName, dwValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT GetDWORD([NativeTypeName("LPCWSTR")] ushort* pszValueName, [NativeTypeName("DWORD *")] uint* pdwValue)
        {
            return ((delegate* unmanaged<ISpObjectToken*, ushort*, uint*, int>)(lpVtbl[8]))((ISpObjectToken*)Unsafe.AsPointer(ref this), pszValueName, pdwValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT OpenKey([NativeTypeName("LPCWSTR")] ushort* pszSubKeyName, ISpDataKey** ppSubKey)
        {
            return ((delegate* unmanaged<ISpObjectToken*, ushort*, ISpDataKey**, int>)(lpVtbl[9]))((ISpObjectToken*)Unsafe.AsPointer(ref this), pszSubKeyName, ppSubKey);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT CreateKey([NativeTypeName("LPCWSTR")] ushort* pszSubKey, ISpDataKey** ppSubKey)
        {
            return ((delegate* unmanaged<ISpObjectToken*, ushort*, ISpDataKey**, int>)(lpVtbl[10]))((ISpObjectToken*)Unsafe.AsPointer(ref this), pszSubKey, ppSubKey);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT DeleteKey([NativeTypeName("LPCWSTR")] ushort* pszSubKey)
        {
            return ((delegate* unmanaged<ISpObjectToken*, ushort*, int>)(lpVtbl[11]))((ISpObjectToken*)Unsafe.AsPointer(ref this), pszSubKey);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT DeleteValue([NativeTypeName("LPCWSTR")] ushort* pszValueName)
        {
            return ((delegate* unmanaged<ISpObjectToken*, ushort*, int>)(lpVtbl[12]))((ISpObjectToken*)Unsafe.AsPointer(ref this), pszValueName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT EnumKeys([NativeTypeName("ULONG")] uint Index, [NativeTypeName("LPWSTR *")] ushort** ppszSubKeyName)
        {
            return ((delegate* unmanaged<ISpObjectToken*, uint, ushort**, int>)(lpVtbl[13]))((ISpObjectToken*)Unsafe.AsPointer(ref this), Index, ppszSubKeyName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT EnumValues([NativeTypeName("ULONG")] uint Index, [NativeTypeName("LPWSTR *")] ushort** ppszValueName)
        {
            return ((delegate* unmanaged<ISpObjectToken*, uint, ushort**, int>)(lpVtbl[14]))((ISpObjectToken*)Unsafe.AsPointer(ref this), Index, ppszValueName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT SetId([NativeTypeName("LPCWSTR")] ushort* pszCategoryId, [NativeTypeName("LPCWSTR")] ushort* pszTokenId, BOOL fCreateIfNotExist)
        {
            return ((delegate* unmanaged<ISpObjectToken*, ushort*, ushort*, BOOL, int>)(lpVtbl[15]))((ISpObjectToken*)Unsafe.AsPointer(ref this), pszCategoryId, pszTokenId, fCreateIfNotExist);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT GetId([NativeTypeName("LPWSTR *")] ushort** ppszCoMemTokenId)
        {
            return ((delegate* unmanaged<ISpObjectToken*, ushort**, int>)(lpVtbl[16]))((ISpObjectToken*)Unsafe.AsPointer(ref this), ppszCoMemTokenId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT GetCategory(ISpObjectTokenCategory** ppTokenCategory)
        {
            return ((delegate* unmanaged<ISpObjectToken*, ISpObjectTokenCategory**, int>)(lpVtbl[17]))((ISpObjectToken*)Unsafe.AsPointer(ref this), ppTokenCategory);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT CreateInstance(IUnknown* pUnkOuter, [NativeTypeName("DWORD")] uint dwClsContext, [NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISpObjectToken*, IUnknown*, uint, Guid*, void**, int>)(lpVtbl[18]))((ISpObjectToken*)Unsafe.AsPointer(ref this), pUnkOuter, dwClsContext, riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HRESULT GetStorageFileName([NativeTypeName("const IID &")] Guid* clsidCaller, [NativeTypeName("LPCWSTR")] ushort* pszValueName, [NativeTypeName("LPCWSTR")] ushort* pszFileNameSpecifier, [NativeTypeName("ULONG")] uint nFolder, [NativeTypeName("LPWSTR *")] ushort** ppszFilePath)
        {
            return ((delegate* unmanaged<ISpObjectToken*, Guid*, ushort*, ushort*, uint, ushort**, int>)(lpVtbl[19]))((ISpObjectToken*)Unsafe.AsPointer(ref this), clsidCaller, pszValueName, pszFileNameSpecifier, nFolder, ppszFilePath);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public HRESULT RemoveStorageFileName([NativeTypeName("const IID &")] Guid* clsidCaller, [NativeTypeName("LPCWSTR")] ushort* pszKeyName, BOOL fDeleteFile)
        {
            return ((delegate* unmanaged<ISpObjectToken*, Guid*, ushort*, BOOL, int>)(lpVtbl[20]))((ISpObjectToken*)Unsafe.AsPointer(ref this), clsidCaller, pszKeyName, fDeleteFile);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public HRESULT Remove([NativeTypeName("const CLSID *")] Guid* pclsidCaller)
        {
            return ((delegate* unmanaged<ISpObjectToken*, Guid*, int>)(lpVtbl[21]))((ISpObjectToken*)Unsafe.AsPointer(ref this), pclsidCaller);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        public HRESULT IsUISupported([NativeTypeName("LPCWSTR")] ushort* pszTypeOfUI, void* pvExtraData, [NativeTypeName("ULONG")] uint cbExtraData, IUnknown* punkObject, BOOL* pfSupported)
        {
            return ((delegate* unmanaged<ISpObjectToken*, ushort*, void*, uint, IUnknown*, BOOL*, int>)(lpVtbl[22]))((ISpObjectToken*)Unsafe.AsPointer(ref this), pszTypeOfUI, pvExtraData, cbExtraData, punkObject, pfSupported);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        public HRESULT DisplayUI(HWND hwndParent, [NativeTypeName("LPCWSTR")] ushort* pszTitle, [NativeTypeName("LPCWSTR")] ushort* pszTypeOfUI, void* pvExtraData, [NativeTypeName("ULONG")] uint cbExtraData, IUnknown* punkObject)
        {
            return ((delegate* unmanaged<ISpObjectToken*, HWND, ushort*, ushort*, void*, uint, IUnknown*, int>)(lpVtbl[23]))((ISpObjectToken*)Unsafe.AsPointer(ref this), hwndParent, pszTitle, pszTypeOfUI, pvExtraData, cbExtraData, punkObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        public HRESULT MatchesAttributes([NativeTypeName("LPCWSTR")] ushort* pszAttributes, BOOL* pfMatches)
        {
            return ((delegate* unmanaged<ISpObjectToken*, ushort*, BOOL*, int>)(lpVtbl[24]))((ISpObjectToken*)Unsafe.AsPointer(ref this), pszAttributes, pfMatches);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpObjectToken*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ISpObjectToken*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ISpObjectToken*, uint> Release;

            [NativeTypeName("HRESULT (LPCWSTR, ULONG, const BYTE *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpObjectToken*, ushort*, uint, byte*, int> SetData;

            [NativeTypeName("HRESULT (LPCWSTR, ULONG *, BYTE *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpObjectToken*, ushort*, uint*, byte*, int> GetData;

            [NativeTypeName("HRESULT (LPCWSTR, LPCWSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpObjectToken*, ushort*, ushort*, int> SetStringValue;

            [NativeTypeName("HRESULT (LPCWSTR, LPWSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpObjectToken*, ushort*, ushort**, int> GetStringValue;

            [NativeTypeName("HRESULT (LPCWSTR, DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpObjectToken*, ushort*, uint, int> SetDWORD;

            [NativeTypeName("HRESULT (LPCWSTR, DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpObjectToken*, ushort*, uint*, int> GetDWORD;

            [NativeTypeName("HRESULT (LPCWSTR, ISpDataKey **) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpObjectToken*, ushort*, ISpDataKey**, int> OpenKey;

            [NativeTypeName("HRESULT (LPCWSTR, ISpDataKey **) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpObjectToken*, ushort*, ISpDataKey**, int> CreateKey;

            [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpObjectToken*, ushort*, int> DeleteKey;

            [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpObjectToken*, ushort*, int> DeleteValue;

            [NativeTypeName("HRESULT (ULONG, LPWSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpObjectToken*, uint, ushort**, int> EnumKeys;

            [NativeTypeName("HRESULT (ULONG, LPWSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpObjectToken*, uint, ushort**, int> EnumValues;

            [NativeTypeName("HRESULT (LPCWSTR, LPCWSTR, BOOL) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpObjectToken*, ushort*, ushort*, BOOL, int> SetId;

            [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpObjectToken*, ushort**, int> GetId;

            [NativeTypeName("HRESULT (ISpObjectTokenCategory **) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpObjectToken*, ISpObjectTokenCategory**, int> GetCategory;

            [NativeTypeName("HRESULT (IUnknown *, DWORD, const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpObjectToken*, IUnknown*, uint, Guid*, void**, int> CreateInstance;

            [NativeTypeName("HRESULT (const IID &, LPCWSTR, LPCWSTR, ULONG, LPWSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpObjectToken*, Guid*, ushort*, ushort*, uint, ushort**, int> GetStorageFileName;

            [NativeTypeName("HRESULT (const IID &, LPCWSTR, BOOL) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpObjectToken*, Guid*, ushort*, BOOL, int> RemoveStorageFileName;

            [NativeTypeName("HRESULT (const CLSID *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpObjectToken*, Guid*, int> Remove;

            [NativeTypeName("HRESULT (LPCWSTR, void *, ULONG, IUnknown *, BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpObjectToken*, ushort*, void*, uint, IUnknown*, BOOL*, int> IsUISupported;

            [NativeTypeName("HRESULT (HWND, LPCWSTR, LPCWSTR, void *, ULONG, IUnknown *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpObjectToken*, HWND, ushort*, ushort*, void*, uint, IUnknown*, int> DisplayUI;

            [NativeTypeName("HRESULT (LPCWSTR, BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpObjectToken*, ushort*, BOOL*, int> MatchesAttributes;
        }
    }
}
