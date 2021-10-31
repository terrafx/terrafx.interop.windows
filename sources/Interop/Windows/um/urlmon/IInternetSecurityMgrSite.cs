// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("79EAC9ED-BAF9-11CE-8C82-00AA004BA90B")]
    [NativeTypeName("struct IInternetSecurityMgrSite : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IInternetSecurityMgrSite
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IInternetSecurityMgrSite*, Guid*, void**, int>)(lpVtbl[0]))((IInternetSecurityMgrSite*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IInternetSecurityMgrSite*, uint>)(lpVtbl[1]))((IInternetSecurityMgrSite*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IInternetSecurityMgrSite*, uint>)(lpVtbl[2]))((IInternetSecurityMgrSite*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetWindow([NativeTypeName("HWND *")] IntPtr* phwnd)
        {
            return ((delegate* unmanaged<IInternetSecurityMgrSite*, IntPtr*, int>)(lpVtbl[3]))((IInternetSecurityMgrSite*)Unsafe.AsPointer(ref this), phwnd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int EnableModeless(BOOL fEnable)
        {
            return ((delegate* unmanaged<IInternetSecurityMgrSite*, BOOL, int>)(lpVtbl[4]))((IInternetSecurityMgrSite*)Unsafe.AsPointer(ref this), fEnable);
        }
    }
}
