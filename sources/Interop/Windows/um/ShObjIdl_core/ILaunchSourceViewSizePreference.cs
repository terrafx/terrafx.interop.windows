// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("E5AA01F7-1FB8-4830-8720-4E6734CBD5F3")]
    [NativeTypeName("struct ILaunchSourceViewSizePreference : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ILaunchSourceViewSizePreference
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ILaunchSourceViewSizePreference*, Guid*, void**, int>)(lpVtbl[0]))((ILaunchSourceViewSizePreference*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ILaunchSourceViewSizePreference*, uint>)(lpVtbl[1]))((ILaunchSourceViewSizePreference*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ILaunchSourceViewSizePreference*, uint>)(lpVtbl[2]))((ILaunchSourceViewSizePreference*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetSourceViewToPosition([NativeTypeName("HWND *")] IntPtr* hwnd)
        {
            return ((delegate* unmanaged<ILaunchSourceViewSizePreference*, IntPtr*, int>)(lpVtbl[3]))((ILaunchSourceViewSizePreference*)Unsafe.AsPointer(ref this), hwnd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetSourceViewSizePreference(APPLICATION_VIEW_SIZE_PREFERENCE* sourceSizeAfterLaunch)
        {
            return ((delegate* unmanaged<ILaunchSourceViewSizePreference*, APPLICATION_VIEW_SIZE_PREFERENCE*, int>)(lpVtbl[4]))((ILaunchSourceViewSizePreference*)Unsafe.AsPointer(ref this), sourceSizeAfterLaunch);
        }
    }
}
