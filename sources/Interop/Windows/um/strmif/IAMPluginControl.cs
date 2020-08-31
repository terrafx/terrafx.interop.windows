// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("0E26A181-F40C-4635-8786-976284B52981")]
    [NativeTypeName("struct IAMPluginControl : IUnknown")]
    public unsafe partial struct IAMPluginControl
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IAMPluginControl*, Guid*, void**, int>)(lpVtbl[0]))((IAMPluginControl*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IAMPluginControl*, uint>)(lpVtbl[1]))((IAMPluginControl*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IAMPluginControl*, uint>)(lpVtbl[2]))((IAMPluginControl*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPreferredClsid([NativeTypeName("const GUID &")] Guid* subType, [NativeTypeName("CLSID *")] Guid* clsid)
        {
            return ((delegate* stdcall<IAMPluginControl*, Guid*, Guid*, int>)(lpVtbl[3]))((IAMPluginControl*)Unsafe.AsPointer(ref this), subType, clsid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPreferredClsidByIndex([NativeTypeName("DWORD")] uint index, [NativeTypeName("GUID *")] Guid* subType, [NativeTypeName("CLSID *")] Guid* clsid)
        {
            return ((delegate* stdcall<IAMPluginControl*, uint, Guid*, Guid*, int>)(lpVtbl[4]))((IAMPluginControl*)Unsafe.AsPointer(ref this), index, subType, clsid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetPreferredClsid([NativeTypeName("const GUID &")] Guid* subType, [NativeTypeName("const CLSID *")] Guid* clsid)
        {
            return ((delegate* stdcall<IAMPluginControl*, Guid*, Guid*, int>)(lpVtbl[5]))((IAMPluginControl*)Unsafe.AsPointer(ref this), subType, clsid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int IsDisabled([NativeTypeName("const IID &")] Guid* clsid)
        {
            return ((delegate* stdcall<IAMPluginControl*, Guid*, int>)(lpVtbl[6]))((IAMPluginControl*)Unsafe.AsPointer(ref this), clsid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDisabledByIndex([NativeTypeName("DWORD")] uint index, [NativeTypeName("CLSID *")] Guid* clsid)
        {
            return ((delegate* stdcall<IAMPluginControl*, uint, Guid*, int>)(lpVtbl[7]))((IAMPluginControl*)Unsafe.AsPointer(ref this), index, clsid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetDisabled([NativeTypeName("const IID &")] Guid* clsid, [NativeTypeName("BOOL")] int disabled)
        {
            return ((delegate* stdcall<IAMPluginControl*, Guid*, int, int>)(lpVtbl[8]))((IAMPluginControl*)Unsafe.AsPointer(ref this), clsid, disabled);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int IsLegacyDisabled([NativeTypeName("LPCWSTR")] ushort* dllName)
        {
            return ((delegate* stdcall<IAMPluginControl*, ushort*, int>)(lpVtbl[9]))((IAMPluginControl*)Unsafe.AsPointer(ref this), dllName);
        }
    }
}
