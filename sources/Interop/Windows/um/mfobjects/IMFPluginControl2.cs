// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfobjects.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("C6982083-3DDC-45CB-AF5E-0F7A8CE4DE77")]
    [NativeTypeName("struct IMFPluginControl2 : IMFPluginControl")]
    public unsafe partial struct IMFPluginControl2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFPluginControl2*, Guid*, void**, int>)(lpVtbl[0]))((IMFPluginControl2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFPluginControl2*, uint>)(lpVtbl[1]))((IMFPluginControl2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFPluginControl2*, uint>)(lpVtbl[2]))((IMFPluginControl2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPreferredClsid([NativeTypeName("DWORD")] uint pluginType, [NativeTypeName("LPCWSTR")] ushort* selector, [NativeTypeName("CLSID *")] Guid* clsid)
        {
            return ((delegate* unmanaged<IMFPluginControl2*, uint, ushort*, Guid*, int>)(lpVtbl[3]))((IMFPluginControl2*)Unsafe.AsPointer(ref this), pluginType, selector, clsid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPreferredClsidByIndex([NativeTypeName("DWORD")] uint pluginType, [NativeTypeName("DWORD")] uint index, [NativeTypeName("LPWSTR *")] ushort** selector, [NativeTypeName("CLSID *")] Guid* clsid)
        {
            return ((delegate* unmanaged<IMFPluginControl2*, uint, uint, ushort**, Guid*, int>)(lpVtbl[4]))((IMFPluginControl2*)Unsafe.AsPointer(ref this), pluginType, index, selector, clsid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetPreferredClsid([NativeTypeName("DWORD")] uint pluginType, [NativeTypeName("LPCWSTR")] ushort* selector, [NativeTypeName("const CLSID *")] Guid* clsid)
        {
            return ((delegate* unmanaged<IMFPluginControl2*, uint, ushort*, Guid*, int>)(lpVtbl[5]))((IMFPluginControl2*)Unsafe.AsPointer(ref this), pluginType, selector, clsid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int IsDisabled([NativeTypeName("DWORD")] uint pluginType, [NativeTypeName("const IID &")] Guid* clsid)
        {
            return ((delegate* unmanaged<IMFPluginControl2*, uint, Guid*, int>)(lpVtbl[6]))((IMFPluginControl2*)Unsafe.AsPointer(ref this), pluginType, clsid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDisabledByIndex([NativeTypeName("DWORD")] uint pluginType, [NativeTypeName("DWORD")] uint index, [NativeTypeName("CLSID *")] Guid* clsid)
        {
            return ((delegate* unmanaged<IMFPluginControl2*, uint, uint, Guid*, int>)(lpVtbl[7]))((IMFPluginControl2*)Unsafe.AsPointer(ref this), pluginType, index, clsid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetDisabled([NativeTypeName("DWORD")] uint pluginType, [NativeTypeName("const IID &")] Guid* clsid, [NativeTypeName("BOOL")] int disabled)
        {
            return ((delegate* unmanaged<IMFPluginControl2*, uint, Guid*, int, int>)(lpVtbl[8]))((IMFPluginControl2*)Unsafe.AsPointer(ref this), pluginType, clsid, disabled);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetPolicy(MF_PLUGIN_CONTROL_POLICY policy)
        {
            return ((delegate* unmanaged<IMFPluginControl2*, MF_PLUGIN_CONTROL_POLICY, int>)(lpVtbl[9]))((IMFPluginControl2*)Unsafe.AsPointer(ref this), policy);
        }
    }
}
