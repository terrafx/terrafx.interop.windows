// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("14056581-E16C-11D2-BB90-00C04F8EE6C0")]
    [NativeTypeName("struct ISpDataKey : IUnknown")]
    public unsafe partial struct ISpDataKey
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISpDataKey*, Guid*, void**, int>)(lpVtbl[0]))((ISpDataKey*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISpDataKey*, uint>)(lpVtbl[1]))((ISpDataKey*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISpDataKey*, uint>)(lpVtbl[2]))((ISpDataKey*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetData([NativeTypeName("LPCWSTR")] ushort* pszValueName, [NativeTypeName("ULONG")] uint cbData, [NativeTypeName("const BYTE *")] byte* pData)
        {
            return ((delegate* unmanaged<ISpDataKey*, ushort*, uint, byte*, int>)(lpVtbl[3]))((ISpDataKey*)Unsafe.AsPointer(ref this), pszValueName, cbData, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetData([NativeTypeName("LPCWSTR")] ushort* pszValueName, [NativeTypeName("ULONG *")] uint* pcbData, [NativeTypeName("BYTE *")] byte* pData)
        {
            return ((delegate* unmanaged<ISpDataKey*, ushort*, uint*, byte*, int>)(lpVtbl[4]))((ISpDataKey*)Unsafe.AsPointer(ref this), pszValueName, pcbData, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetStringValue([NativeTypeName("LPCWSTR")] ushort* pszValueName, [NativeTypeName("LPCWSTR")] ushort* pszValue)
        {
            return ((delegate* unmanaged<ISpDataKey*, ushort*, ushort*, int>)(lpVtbl[5]))((ISpDataKey*)Unsafe.AsPointer(ref this), pszValueName, pszValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetStringValue([NativeTypeName("LPCWSTR")] ushort* pszValueName, [NativeTypeName("LPWSTR *")] ushort** ppszValue)
        {
            return ((delegate* unmanaged<ISpDataKey*, ushort*, ushort**, int>)(lpVtbl[6]))((ISpDataKey*)Unsafe.AsPointer(ref this), pszValueName, ppszValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetDWORD([NativeTypeName("LPCWSTR")] ushort* pszValueName, [NativeTypeName("DWORD")] uint dwValue)
        {
            return ((delegate* unmanaged<ISpDataKey*, ushort*, uint, int>)(lpVtbl[7]))((ISpDataKey*)Unsafe.AsPointer(ref this), pszValueName, dwValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDWORD([NativeTypeName("LPCWSTR")] ushort* pszValueName, [NativeTypeName("DWORD *")] uint* pdwValue)
        {
            return ((delegate* unmanaged<ISpDataKey*, ushort*, uint*, int>)(lpVtbl[8]))((ISpDataKey*)Unsafe.AsPointer(ref this), pszValueName, pdwValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OpenKey([NativeTypeName("LPCWSTR")] ushort* pszSubKeyName, ISpDataKey** ppSubKey)
        {
            return ((delegate* unmanaged<ISpDataKey*, ushort*, ISpDataKey**, int>)(lpVtbl[9]))((ISpDataKey*)Unsafe.AsPointer(ref this), pszSubKeyName, ppSubKey);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateKey([NativeTypeName("LPCWSTR")] ushort* pszSubKey, ISpDataKey** ppSubKey)
        {
            return ((delegate* unmanaged<ISpDataKey*, ushort*, ISpDataKey**, int>)(lpVtbl[10]))((ISpDataKey*)Unsafe.AsPointer(ref this), pszSubKey, ppSubKey);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DeleteKey([NativeTypeName("LPCWSTR")] ushort* pszSubKey)
        {
            return ((delegate* unmanaged<ISpDataKey*, ushort*, int>)(lpVtbl[11]))((ISpDataKey*)Unsafe.AsPointer(ref this), pszSubKey);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DeleteValue([NativeTypeName("LPCWSTR")] ushort* pszValueName)
        {
            return ((delegate* unmanaged<ISpDataKey*, ushort*, int>)(lpVtbl[12]))((ISpDataKey*)Unsafe.AsPointer(ref this), pszValueName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int EnumKeys([NativeTypeName("ULONG")] uint Index, [NativeTypeName("LPWSTR *")] ushort** ppszSubKeyName)
        {
            return ((delegate* unmanaged<ISpDataKey*, uint, ushort**, int>)(lpVtbl[13]))((ISpDataKey*)Unsafe.AsPointer(ref this), Index, ppszSubKeyName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int EnumValues([NativeTypeName("ULONG")] uint Index, [NativeTypeName("LPWSTR *")] ushort** ppszValueName)
        {
            return ((delegate* unmanaged<ISpDataKey*, uint, ushort**, int>)(lpVtbl[14]))((ISpDataKey*)Unsafe.AsPointer(ref this), Index, ppszValueName);
        }
    }
}
