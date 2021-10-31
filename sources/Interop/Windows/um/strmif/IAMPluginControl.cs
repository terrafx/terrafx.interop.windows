// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("0E26A181-F40C-4635-8786-976284B52981")]
    [NativeTypeName("struct IAMPluginControl : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IAMPluginControl
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAMPluginControl*, Guid*, void**, int>)(lpVtbl[0]))((IAMPluginControl*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAMPluginControl*, uint>)(lpVtbl[1]))((IAMPluginControl*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAMPluginControl*, uint>)(lpVtbl[2]))((IAMPluginControl*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetPreferredClsid([NativeTypeName("const GUID &")] Guid* subType, [NativeTypeName("CLSID *")] Guid* clsid)
        {
            return ((delegate* unmanaged<IAMPluginControl*, Guid*, Guid*, int>)(lpVtbl[3]))((IAMPluginControl*)Unsafe.AsPointer(ref this), subType, clsid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetPreferredClsidByIndex([NativeTypeName("DWORD")] uint index, Guid* subType, [NativeTypeName("CLSID *")] Guid* clsid)
        {
            return ((delegate* unmanaged<IAMPluginControl*, uint, Guid*, Guid*, int>)(lpVtbl[4]))((IAMPluginControl*)Unsafe.AsPointer(ref this), index, subType, clsid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT SetPreferredClsid([NativeTypeName("const GUID &")] Guid* subType, [NativeTypeName("const CLSID *")] Guid* clsid)
        {
            return ((delegate* unmanaged<IAMPluginControl*, Guid*, Guid*, int>)(lpVtbl[5]))((IAMPluginControl*)Unsafe.AsPointer(ref this), subType, clsid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT IsDisabled([NativeTypeName("const IID &")] Guid* clsid)
        {
            return ((delegate* unmanaged<IAMPluginControl*, Guid*, int>)(lpVtbl[6]))((IAMPluginControl*)Unsafe.AsPointer(ref this), clsid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT GetDisabledByIndex([NativeTypeName("DWORD")] uint index, [NativeTypeName("CLSID *")] Guid* clsid)
        {
            return ((delegate* unmanaged<IAMPluginControl*, uint, Guid*, int>)(lpVtbl[7]))((IAMPluginControl*)Unsafe.AsPointer(ref this), index, clsid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT SetDisabled([NativeTypeName("const IID &")] Guid* clsid, BOOL disabled)
        {
            return ((delegate* unmanaged<IAMPluginControl*, Guid*, BOOL, int>)(lpVtbl[8]))((IAMPluginControl*)Unsafe.AsPointer(ref this), clsid, disabled);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT IsLegacyDisabled([NativeTypeName("LPCWSTR")] ushort* dllName)
        {
            return ((delegate* unmanaged<IAMPluginControl*, ushort*, int>)(lpVtbl[9]))((IAMPluginControl*)Unsafe.AsPointer(ref this), dllName);
        }
    }
}
