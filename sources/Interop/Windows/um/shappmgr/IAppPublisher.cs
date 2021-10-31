// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/shappmgr.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("07250A10-9CF9-11D1-9076-006008059382")]
    [NativeTypeName("struct IAppPublisher : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IAppPublisher
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAppPublisher*, Guid*, void**, int>)(lpVtbl[0]))((IAppPublisher*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAppPublisher*, uint>)(lpVtbl[1]))((IAppPublisher*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAppPublisher*, uint>)(lpVtbl[2]))((IAppPublisher*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetNumberOfCategories([NativeTypeName("DWORD *")] uint* pdwCat)
        {
            return ((delegate* unmanaged<IAppPublisher*, uint*, int>)(lpVtbl[3]))((IAppPublisher*)Unsafe.AsPointer(ref this), pdwCat);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetCategories(APPCATEGORYINFOLIST* pAppCategoryList)
        {
            return ((delegate* unmanaged<IAppPublisher*, APPCATEGORYINFOLIST*, int>)(lpVtbl[4]))((IAppPublisher*)Unsafe.AsPointer(ref this), pAppCategoryList);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetNumberOfApps([NativeTypeName("DWORD *")] uint* pdwApps)
        {
            return ((delegate* unmanaged<IAppPublisher*, uint*, int>)(lpVtbl[5]))((IAppPublisher*)Unsafe.AsPointer(ref this), pdwApps);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT EnumApps([NativeTypeName("GUID *")] Guid* pAppCategoryId, IEnumPublishedApps** ppepa)
        {
            return ((delegate* unmanaged<IAppPublisher*, Guid*, IEnumPublishedApps**, int>)(lpVtbl[6]))((IAppPublisher*)Unsafe.AsPointer(ref this), pAppCategoryId, ppepa);
        }
    }
}
