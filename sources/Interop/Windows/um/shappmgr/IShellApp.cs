// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/shappmgr.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("A3E14960-935F-11D1-B8B8-006008059382")]
    [NativeTypeName("struct IShellApp : IUnknown")]
    public unsafe partial struct IShellApp
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IShellApp*, Guid*, void**, int>)(lpVtbl[0]))((IShellApp*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IShellApp*, uint>)(lpVtbl[1]))((IShellApp*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IShellApp*, uint>)(lpVtbl[2]))((IShellApp*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetAppInfo([NativeTypeName("PAPPINFODATA")] _AppInfoData* pai)
        {
            return ((delegate* unmanaged<IShellApp*, _AppInfoData*, int>)(lpVtbl[3]))((IShellApp*)Unsafe.AsPointer(ref this), pai);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPossibleActions([NativeTypeName("DWORD *")] uint* pdwActions)
        {
            return ((delegate* unmanaged<IShellApp*, uint*, int>)(lpVtbl[4]))((IShellApp*)Unsafe.AsPointer(ref this), pdwActions);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSlowAppInfo([NativeTypeName("PSLOWAPPINFO")] _tagSlowAppInfo* psaid)
        {
            return ((delegate* unmanaged<IShellApp*, _tagSlowAppInfo*, int>)(lpVtbl[5]))((IShellApp*)Unsafe.AsPointer(ref this), psaid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCachedSlowAppInfo([NativeTypeName("PSLOWAPPINFO")] _tagSlowAppInfo* psaid)
        {
            return ((delegate* unmanaged<IShellApp*, _tagSlowAppInfo*, int>)(lpVtbl[6]))((IShellApp*)Unsafe.AsPointer(ref this), psaid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int IsInstalled()
        {
            return ((delegate* unmanaged<IShellApp*, int>)(lpVtbl[7]))((IShellApp*)Unsafe.AsPointer(ref this));
        }
    }
}
