// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/IContact.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("70DD27DD-5CBD-46E8-BEF0-23B6B346288F")]
    [NativeTypeName("struct IContactProperties : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IContactProperties
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IContactProperties*, Guid*, void**, int>)(lpVtbl[0]))((IContactProperties*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IContactProperties*, uint>)(lpVtbl[1]))((IContactProperties*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IContactProperties*, uint>)(lpVtbl[2]))((IContactProperties*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetString([NativeTypeName("LPCWSTR")] ushort* pszPropertyName, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPWSTR")] ushort* pszValue, [NativeTypeName("DWORD")] uint cchValue, [NativeTypeName("DWORD *")] uint* pdwcchPropertyValueRequired)
        {
            return ((delegate* unmanaged<IContactProperties*, ushort*, uint, ushort*, uint, uint*, int>)(lpVtbl[3]))((IContactProperties*)Unsafe.AsPointer(ref this), pszPropertyName, dwFlags, pszValue, cchValue, pdwcchPropertyValueRequired);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetDate([NativeTypeName("LPCWSTR")] ushort* pszPropertyName, [NativeTypeName("DWORD")] uint dwFlags, FILETIME* pftDateTime)
        {
            return ((delegate* unmanaged<IContactProperties*, ushort*, uint, FILETIME*, int>)(lpVtbl[4]))((IContactProperties*)Unsafe.AsPointer(ref this), pszPropertyName, dwFlags, pftDateTime);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetBinary([NativeTypeName("LPCWSTR")] ushort* pszPropertyName, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPWSTR")] ushort* pszContentType, [NativeTypeName("DWORD")] uint cchContentType, [NativeTypeName("DWORD *")] uint* pdwcchContentTypeRequired, IStream** ppStream)
        {
            return ((delegate* unmanaged<IContactProperties*, ushort*, uint, ushort*, uint, uint*, IStream**, int>)(lpVtbl[5]))((IContactProperties*)Unsafe.AsPointer(ref this), pszPropertyName, dwFlags, pszContentType, cchContentType, pdwcchContentTypeRequired, ppStream);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT GetLabels([NativeTypeName("LPCWSTR")] ushort* pszArrayElementName, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPWSTR")] ushort* pszLabels, [NativeTypeName("DWORD")] uint cchLabels, [NativeTypeName("DWORD *")] uint* pdwcchLabelsRequired)
        {
            return ((delegate* unmanaged<IContactProperties*, ushort*, uint, ushort*, uint, uint*, int>)(lpVtbl[6]))((IContactProperties*)Unsafe.AsPointer(ref this), pszArrayElementName, dwFlags, pszLabels, cchLabels, pdwcchLabelsRequired);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT SetString([NativeTypeName("LPCWSTR")] ushort* pszPropertyName, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPCWSTR")] ushort* pszValue)
        {
            return ((delegate* unmanaged<IContactProperties*, ushort*, uint, ushort*, int>)(lpVtbl[7]))((IContactProperties*)Unsafe.AsPointer(ref this), pszPropertyName, dwFlags, pszValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT SetDate([NativeTypeName("LPCWSTR")] ushort* pszPropertyName, [NativeTypeName("DWORD")] uint dwFlags, FILETIME ftDateTime)
        {
            return ((delegate* unmanaged<IContactProperties*, ushort*, uint, FILETIME, int>)(lpVtbl[8]))((IContactProperties*)Unsafe.AsPointer(ref this), pszPropertyName, dwFlags, ftDateTime);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT SetBinary([NativeTypeName("LPCWSTR")] ushort* pszPropertyName, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPCWSTR")] ushort* pszContentType, IStream* pStream)
        {
            return ((delegate* unmanaged<IContactProperties*, ushort*, uint, ushort*, IStream*, int>)(lpVtbl[9]))((IContactProperties*)Unsafe.AsPointer(ref this), pszPropertyName, dwFlags, pszContentType, pStream);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT SetLabels([NativeTypeName("LPCWSTR")] ushort* pszArrayElementName, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD")] uint dwLabelCount, [NativeTypeName("LPCWSTR []")] ushort** ppszLabels)
        {
            return ((delegate* unmanaged<IContactProperties*, ushort*, uint, uint, ushort**, int>)(lpVtbl[10]))((IContactProperties*)Unsafe.AsPointer(ref this), pszArrayElementName, dwFlags, dwLabelCount, ppszLabels);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT CreateArrayNode([NativeTypeName("LPCWSTR")] ushort* pszArrayName, [NativeTypeName("DWORD")] uint dwFlags, BOOL fAppend, [NativeTypeName("LPWSTR")] ushort* pszNewArrayElementName, [NativeTypeName("DWORD")] uint cchNewArrayElementName, [NativeTypeName("DWORD *")] uint* pdwcchNewArrayElementNameRequired)
        {
            return ((delegate* unmanaged<IContactProperties*, ushort*, uint, BOOL, ushort*, uint, uint*, int>)(lpVtbl[11]))((IContactProperties*)Unsafe.AsPointer(ref this), pszArrayName, dwFlags, fAppend, pszNewArrayElementName, cchNewArrayElementName, pdwcchNewArrayElementNameRequired);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT DeleteProperty([NativeTypeName("LPCWSTR")] ushort* pszPropertyName, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* unmanaged<IContactProperties*, ushort*, uint, int>)(lpVtbl[12]))((IContactProperties*)Unsafe.AsPointer(ref this), pszPropertyName, dwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT DeleteArrayNode([NativeTypeName("LPCWSTR")] ushort* pszArrayElementName, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* unmanaged<IContactProperties*, ushort*, uint, int>)(lpVtbl[13]))((IContactProperties*)Unsafe.AsPointer(ref this), pszArrayElementName, dwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT DeleteLabels([NativeTypeName("LPCWSTR")] ushort* pszArrayElementName, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* unmanaged<IContactProperties*, ushort*, uint, int>)(lpVtbl[14]))((IContactProperties*)Unsafe.AsPointer(ref this), pszArrayElementName, dwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT GetPropertyCollection(IContactPropertyCollection** ppPropertyCollection, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPCWSTR")] ushort* pszMultiValueName, [NativeTypeName("DWORD")] uint dwLabelCount, [NativeTypeName("LPCWSTR []")] ushort** ppszLabels, BOOL fAnyLabelMatches)
        {
            return ((delegate* unmanaged<IContactProperties*, IContactPropertyCollection**, uint, ushort*, uint, ushort**, BOOL, int>)(lpVtbl[15]))((IContactProperties*)Unsafe.AsPointer(ref this), ppPropertyCollection, dwFlags, pszMultiValueName, dwLabelCount, ppszLabels, fAnyLabelMatches);
        }
    }
}
