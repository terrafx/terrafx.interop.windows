// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfobjects.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows
{
    [SupportedOSPlatform("windows8.0")]
    [Guid("C6982083-3DDC-45CB-AF5E-0F7A8CE4DE77")]
    [NativeTypeName("struct IMFPluginControl2 : IMFPluginControl")]
    [NativeInheritance("IMFPluginControl")]
    public unsafe partial struct IMFPluginControl2 : IMFPluginControl2.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFPluginControl2*, Guid*, void**, int>)(lpVtbl[0]))((IMFPluginControl2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFPluginControl2*, uint>)(lpVtbl[1]))((IMFPluginControl2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFPluginControl2*, uint>)(lpVtbl[2]))((IMFPluginControl2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetPreferredClsid([NativeTypeName("DWORD")] uint pluginType, [NativeTypeName("LPCWSTR")] ushort* selector, [NativeTypeName("CLSID *")] Guid* clsid)
        {
            return ((delegate* unmanaged<IMFPluginControl2*, uint, ushort*, Guid*, int>)(lpVtbl[3]))((IMFPluginControl2*)Unsafe.AsPointer(ref this), pluginType, selector, clsid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetPreferredClsidByIndex([NativeTypeName("DWORD")] uint pluginType, [NativeTypeName("DWORD")] uint index, [NativeTypeName("LPWSTR *")] ushort** selector, [NativeTypeName("CLSID *")] Guid* clsid)
        {
            return ((delegate* unmanaged<IMFPluginControl2*, uint, uint, ushort**, Guid*, int>)(lpVtbl[4]))((IMFPluginControl2*)Unsafe.AsPointer(ref this), pluginType, index, selector, clsid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT SetPreferredClsid([NativeTypeName("DWORD")] uint pluginType, [NativeTypeName("LPCWSTR")] ushort* selector, [NativeTypeName("const CLSID *")] Guid* clsid)
        {
            return ((delegate* unmanaged<IMFPluginControl2*, uint, ushort*, Guid*, int>)(lpVtbl[5]))((IMFPluginControl2*)Unsafe.AsPointer(ref this), pluginType, selector, clsid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT IsDisabled([NativeTypeName("DWORD")] uint pluginType, [NativeTypeName("const IID &")] Guid* clsid)
        {
            return ((delegate* unmanaged<IMFPluginControl2*, uint, Guid*, int>)(lpVtbl[6]))((IMFPluginControl2*)Unsafe.AsPointer(ref this), pluginType, clsid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT GetDisabledByIndex([NativeTypeName("DWORD")] uint pluginType, [NativeTypeName("DWORD")] uint index, [NativeTypeName("CLSID *")] Guid* clsid)
        {
            return ((delegate* unmanaged<IMFPluginControl2*, uint, uint, Guid*, int>)(lpVtbl[7]))((IMFPluginControl2*)Unsafe.AsPointer(ref this), pluginType, index, clsid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT SetDisabled([NativeTypeName("DWORD")] uint pluginType, [NativeTypeName("const IID &")] Guid* clsid, BOOL disabled)
        {
            return ((delegate* unmanaged<IMFPluginControl2*, uint, Guid*, BOOL, int>)(lpVtbl[8]))((IMFPluginControl2*)Unsafe.AsPointer(ref this), pluginType, clsid, disabled);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT SetPolicy(MF_PLUGIN_CONTROL_POLICY policy)
        {
            return ((delegate* unmanaged<IMFPluginControl2*, MF_PLUGIN_CONTROL_POLICY, int>)(lpVtbl[9]))((IMFPluginControl2*)Unsafe.AsPointer(ref this), policy);
        }

        public interface Interface : IMFPluginControl.Interface
        {
            [VtblIndex(9)]
            HRESULT SetPolicy(MF_PLUGIN_CONTROL_POLICY policy);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFPluginControl2*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFPluginControl2*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFPluginControl2*, uint> Release;

            [NativeTypeName("HRESULT (DWORD, LPCWSTR, CLSID *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFPluginControl2*, uint, ushort*, Guid*, int> GetPreferredClsid;

            [NativeTypeName("HRESULT (DWORD, DWORD, LPWSTR *, CLSID *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFPluginControl2*, uint, uint, ushort**, Guid*, int> GetPreferredClsidByIndex;

            [NativeTypeName("HRESULT (DWORD, LPCWSTR, const CLSID *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFPluginControl2*, uint, ushort*, Guid*, int> SetPreferredClsid;

            [NativeTypeName("HRESULT (DWORD, const IID &) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFPluginControl2*, uint, Guid*, int> IsDisabled;

            [NativeTypeName("HRESULT (DWORD, DWORD, CLSID *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFPluginControl2*, uint, uint, Guid*, int> GetDisabledByIndex;

            [NativeTypeName("HRESULT (DWORD, const IID &, BOOL) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFPluginControl2*, uint, Guid*, BOOL, int> SetDisabled;

            [NativeTypeName("HRESULT (MF_PLUGIN_CONTROL_POLICY) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFPluginControl2*, MF_PLUGIN_CONTROL_POLICY, int> SetPolicy;
        }
    }
}
