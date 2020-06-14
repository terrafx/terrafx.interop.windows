// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("2D3D3845-39AF-4850-BBF9-40B49780011D")]
    public unsafe partial struct ISpObjectTokenCategory
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<ISpObjectTokenCategory*, Guid*, void**, int>)(lpVtbl[0]))((ISpObjectTokenCategory*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<ISpObjectTokenCategory*, uint>)(lpVtbl[1]))((ISpObjectTokenCategory*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<ISpObjectTokenCategory*, uint>)(lpVtbl[2]))((ISpObjectTokenCategory*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetData([NativeTypeName("LPCWSTR")] ushort* pszValueName, [NativeTypeName("ULONG")] uint cbData, [NativeTypeName("const BYTE *")] byte* pData)
        {
            return ((delegate* stdcall<ISpObjectTokenCategory*, ushort*, uint, byte*, int>)(lpVtbl[3]))((ISpObjectTokenCategory*)Unsafe.AsPointer(ref this), pszValueName, cbData, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetData([NativeTypeName("LPCWSTR")] ushort* pszValueName, [NativeTypeName("ULONG *")] uint* pcbData, [NativeTypeName("BYTE *")] byte* pData)
        {
            return ((delegate* stdcall<ISpObjectTokenCategory*, ushort*, uint*, byte*, int>)(lpVtbl[4]))((ISpObjectTokenCategory*)Unsafe.AsPointer(ref this), pszValueName, pcbData, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetStringValue([NativeTypeName("LPCWSTR")] ushort* pszValueName, [NativeTypeName("LPCWSTR")] ushort* pszValue)
        {
            return ((delegate* stdcall<ISpObjectTokenCategory*, ushort*, ushort*, int>)(lpVtbl[5]))((ISpObjectTokenCategory*)Unsafe.AsPointer(ref this), pszValueName, pszValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetStringValue([NativeTypeName("LPCWSTR")] ushort* pszValueName, [NativeTypeName("LPWSTR *")] ushort** ppszValue)
        {
            return ((delegate* stdcall<ISpObjectTokenCategory*, ushort*, ushort**, int>)(lpVtbl[6]))((ISpObjectTokenCategory*)Unsafe.AsPointer(ref this), pszValueName, ppszValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetDWORD([NativeTypeName("LPCWSTR")] ushort* pszValueName, [NativeTypeName("DWORD")] uint dwValue)
        {
            return ((delegate* stdcall<ISpObjectTokenCategory*, ushort*, uint, int>)(lpVtbl[7]))((ISpObjectTokenCategory*)Unsafe.AsPointer(ref this), pszValueName, dwValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDWORD([NativeTypeName("LPCWSTR")] ushort* pszValueName, [NativeTypeName("DWORD *")] uint* pdwValue)
        {
            return ((delegate* stdcall<ISpObjectTokenCategory*, ushort*, uint*, int>)(lpVtbl[8]))((ISpObjectTokenCategory*)Unsafe.AsPointer(ref this), pszValueName, pdwValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int OpenKey([NativeTypeName("LPCWSTR")] ushort* pszSubKeyName, [NativeTypeName("ISpDataKey **")] ISpDataKey** ppSubKey)
        {
            return ((delegate* stdcall<ISpObjectTokenCategory*, ushort*, ISpDataKey**, int>)(lpVtbl[9]))((ISpObjectTokenCategory*)Unsafe.AsPointer(ref this), pszSubKeyName, ppSubKey);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateKey([NativeTypeName("LPCWSTR")] ushort* pszSubKey, [NativeTypeName("ISpDataKey **")] ISpDataKey** ppSubKey)
        {
            return ((delegate* stdcall<ISpObjectTokenCategory*, ushort*, ISpDataKey**, int>)(lpVtbl[10]))((ISpObjectTokenCategory*)Unsafe.AsPointer(ref this), pszSubKey, ppSubKey);
        }

        [return: NativeTypeName("HRESULT")]
        public int DeleteKey([NativeTypeName("LPCWSTR")] ushort* pszSubKey)
        {
            return ((delegate* stdcall<ISpObjectTokenCategory*, ushort*, int>)(lpVtbl[11]))((ISpObjectTokenCategory*)Unsafe.AsPointer(ref this), pszSubKey);
        }

        [return: NativeTypeName("HRESULT")]
        public int DeleteValue([NativeTypeName("LPCWSTR")] ushort* pszValueName)
        {
            return ((delegate* stdcall<ISpObjectTokenCategory*, ushort*, int>)(lpVtbl[12]))((ISpObjectTokenCategory*)Unsafe.AsPointer(ref this), pszValueName);
        }

        [return: NativeTypeName("HRESULT")]
        public int EnumKeys([NativeTypeName("ULONG")] uint Index, [NativeTypeName("LPWSTR *")] ushort** ppszSubKeyName)
        {
            return ((delegate* stdcall<ISpObjectTokenCategory*, uint, ushort**, int>)(lpVtbl[13]))((ISpObjectTokenCategory*)Unsafe.AsPointer(ref this), Index, ppszSubKeyName);
        }

        [return: NativeTypeName("HRESULT")]
        public int EnumValues([NativeTypeName("ULONG")] uint Index, [NativeTypeName("LPWSTR *")] ushort** ppszValueName)
        {
            return ((delegate* stdcall<ISpObjectTokenCategory*, uint, ushort**, int>)(lpVtbl[14]))((ISpObjectTokenCategory*)Unsafe.AsPointer(ref this), Index, ppszValueName);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetId([NativeTypeName("LPCWSTR")] ushort* pszCategoryId, [NativeTypeName("BOOL")] int fCreateIfNotExist)
        {
            return ((delegate* stdcall<ISpObjectTokenCategory*, ushort*, int, int>)(lpVtbl[15]))((ISpObjectTokenCategory*)Unsafe.AsPointer(ref this), pszCategoryId, fCreateIfNotExist);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetId([NativeTypeName("LPWSTR *")] ushort** ppszCoMemCategoryId)
        {
            return ((delegate* stdcall<ISpObjectTokenCategory*, ushort**, int>)(lpVtbl[16]))((ISpObjectTokenCategory*)Unsafe.AsPointer(ref this), ppszCoMemCategoryId);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDataKey(SPDATAKEYLOCATION spdkl, [NativeTypeName("ISpDataKey **")] ISpDataKey** ppDataKey)
        {
            return ((delegate* stdcall<ISpObjectTokenCategory*, SPDATAKEYLOCATION, ISpDataKey**, int>)(lpVtbl[17]))((ISpObjectTokenCategory*)Unsafe.AsPointer(ref this), spdkl, ppDataKey);
        }

        [return: NativeTypeName("HRESULT")]
        public int EnumTokens([NativeTypeName("LPCWSTR")] ushort* pzsReqAttribs, [NativeTypeName("LPCWSTR")] ushort* pszOptAttribs, [NativeTypeName("IEnumSpObjectTokens **")] IEnumSpObjectTokens** ppEnum)
        {
            return ((delegate* stdcall<ISpObjectTokenCategory*, ushort*, ushort*, IEnumSpObjectTokens**, int>)(lpVtbl[18]))((ISpObjectTokenCategory*)Unsafe.AsPointer(ref this), pzsReqAttribs, pszOptAttribs, ppEnum);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetDefaultTokenId([NativeTypeName("LPCWSTR")] ushort* pszTokenId)
        {
            return ((delegate* stdcall<ISpObjectTokenCategory*, ushort*, int>)(lpVtbl[19]))((ISpObjectTokenCategory*)Unsafe.AsPointer(ref this), pszTokenId);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDefaultTokenId([NativeTypeName("LPWSTR *")] ushort** ppszCoMemTokenId)
        {
            return ((delegate* stdcall<ISpObjectTokenCategory*, ushort**, int>)(lpVtbl[20]))((ISpObjectTokenCategory*)Unsafe.AsPointer(ref this), ppszCoMemTokenId);
        }
    }
}
