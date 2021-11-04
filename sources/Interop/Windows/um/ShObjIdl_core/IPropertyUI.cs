// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("757A7D9F-919A-4118-99D7-DBB208C8CC66")]
    [NativeTypeName("struct IPropertyUI : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IPropertyUI
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IPropertyUI*, Guid*, void**, int>)(lpVtbl[0]))((IPropertyUI*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IPropertyUI*, uint>)(lpVtbl[1]))((IPropertyUI*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IPropertyUI*, uint>)(lpVtbl[2]))((IPropertyUI*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT ParsePropertyName([NativeTypeName("LPCWSTR")] ushort* pszName, [NativeTypeName("FMTID *")] Guid* pfmtid, [NativeTypeName("PROPID *")] uint* ppid, [NativeTypeName("ULONG *")] uint* pchEaten)
        {
            return ((delegate* unmanaged<IPropertyUI*, ushort*, Guid*, uint*, uint*, int>)(lpVtbl[3]))((IPropertyUI*)Unsafe.AsPointer(ref this), pszName, pfmtid, ppid, pchEaten);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetCannonicalName([NativeTypeName("const IID &")] Guid* fmtid, [NativeTypeName("PROPID")] uint pid, [NativeTypeName("LPWSTR")] ushort* pwszText, [NativeTypeName("DWORD")] uint cchText)
        {
            return ((delegate* unmanaged<IPropertyUI*, Guid*, uint, ushort*, uint, int>)(lpVtbl[4]))((IPropertyUI*)Unsafe.AsPointer(ref this), fmtid, pid, pwszText, cchText);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetDisplayName([NativeTypeName("const IID &")] Guid* fmtid, [NativeTypeName("PROPID")] uint pid, [NativeTypeName("PROPERTYUI_NAME_FLAGS")] uint flags, [NativeTypeName("LPWSTR")] ushort* pwszText, [NativeTypeName("DWORD")] uint cchText)
        {
            return ((delegate* unmanaged<IPropertyUI*, Guid*, uint, uint, ushort*, uint, int>)(lpVtbl[5]))((IPropertyUI*)Unsafe.AsPointer(ref this), fmtid, pid, flags, pwszText, cchText);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT GetPropertyDescription([NativeTypeName("const IID &")] Guid* fmtid, [NativeTypeName("PROPID")] uint pid, [NativeTypeName("LPWSTR")] ushort* pwszText, [NativeTypeName("DWORD")] uint cchText)
        {
            return ((delegate* unmanaged<IPropertyUI*, Guid*, uint, ushort*, uint, int>)(lpVtbl[6]))((IPropertyUI*)Unsafe.AsPointer(ref this), fmtid, pid, pwszText, cchText);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT GetDefaultWidth([NativeTypeName("const IID &")] Guid* fmtid, [NativeTypeName("PROPID")] uint pid, [NativeTypeName("ULONG *")] uint* pcxChars)
        {
            return ((delegate* unmanaged<IPropertyUI*, Guid*, uint, uint*, int>)(lpVtbl[7]))((IPropertyUI*)Unsafe.AsPointer(ref this), fmtid, pid, pcxChars);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT GetFlags([NativeTypeName("const IID &")] Guid* fmtid, [NativeTypeName("PROPID")] uint pid, [NativeTypeName("PROPERTYUI_FLAGS *")] uint* pflags)
        {
            return ((delegate* unmanaged<IPropertyUI*, Guid*, uint, uint*, int>)(lpVtbl[8]))((IPropertyUI*)Unsafe.AsPointer(ref this), fmtid, pid, pflags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT FormatForDisplay([NativeTypeName("const IID &")] Guid* fmtid, [NativeTypeName("PROPID")] uint pid, [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* ppropvar, [NativeTypeName("PROPERTYUI_FORMAT_FLAGS")] uint puiff, [NativeTypeName("LPWSTR")] ushort* pwszText, [NativeTypeName("DWORD")] uint cchText)
        {
            return ((delegate* unmanaged<IPropertyUI*, Guid*, uint, PROPVARIANT*, uint, ushort*, uint, int>)(lpVtbl[9]))((IPropertyUI*)Unsafe.AsPointer(ref this), fmtid, pid, ppropvar, puiff, pwszText, cchText);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT GetHelpInfo([NativeTypeName("const IID &")] Guid* fmtid, [NativeTypeName("PROPID")] uint pid, [NativeTypeName("LPWSTR")] ushort* pwszHelpFile, [NativeTypeName("DWORD")] uint cch, uint* puHelpID)
        {
            return ((delegate* unmanaged<IPropertyUI*, Guid*, uint, ushort*, uint, uint*, int>)(lpVtbl[10]))((IPropertyUI*)Unsafe.AsPointer(ref this), fmtid, pid, pwszHelpFile, cch, puHelpID);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IPropertyUI*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IPropertyUI*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IPropertyUI*, uint> Release;

            [NativeTypeName("HRESULT (LPCWSTR, FMTID *, PROPID *, ULONG *) __attribute__((stdcall))")]
            public delegate* unmanaged<IPropertyUI*, ushort*, Guid*, uint*, uint*, int> ParsePropertyName;

            [NativeTypeName("HRESULT (const IID &, PROPID, LPWSTR, DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged<IPropertyUI*, Guid*, uint, ushort*, uint, int> GetCannonicalName;

            [NativeTypeName("HRESULT (const IID &, PROPID, PROPERTYUI_NAME_FLAGS, LPWSTR, DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged<IPropertyUI*, Guid*, uint, uint, ushort*, uint, int> GetDisplayName;

            [NativeTypeName("HRESULT (const IID &, PROPID, LPWSTR, DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged<IPropertyUI*, Guid*, uint, ushort*, uint, int> GetPropertyDescription;

            [NativeTypeName("HRESULT (const IID &, PROPID, ULONG *) __attribute__((stdcall))")]
            public delegate* unmanaged<IPropertyUI*, Guid*, uint, uint*, int> GetDefaultWidth;

            [NativeTypeName("HRESULT (const IID &, PROPID, PROPERTYUI_FLAGS *) __attribute__((stdcall))")]
            public delegate* unmanaged<IPropertyUI*, Guid*, uint, uint*, int> GetFlags;

            [NativeTypeName("HRESULT (const IID &, PROPID, const PROPVARIANT *, PROPERTYUI_FORMAT_FLAGS, LPWSTR, DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged<IPropertyUI*, Guid*, uint, PROPVARIANT*, uint, ushort*, uint, int> FormatForDisplay;

            [NativeTypeName("HRESULT (const IID &, PROPID, LPWSTR, DWORD, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IPropertyUI*, Guid*, uint, ushort*, uint, uint*, int> GetHelpInfo;
        }
    }
}
