// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OCIdl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("B196B28C-BAB4-101A-B69C-00AA00341D07")]
    [NativeTypeName("struct IPropertyPageSite : IUnknown")]
    public unsafe partial struct IPropertyPageSite
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IPropertyPageSite*, Guid*, void**, int>)(lpVtbl[0]))((IPropertyPageSite*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IPropertyPageSite*, uint>)(lpVtbl[1]))((IPropertyPageSite*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IPropertyPageSite*, uint>)(lpVtbl[2]))((IPropertyPageSite*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnStatusChange([NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* unmanaged<IPropertyPageSite*, uint, int>)(lpVtbl[3]))((IPropertyPageSite*)Unsafe.AsPointer(ref this), dwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetLocaleID([NativeTypeName("LCID *")] uint* pLocaleID)
        {
            return ((delegate* unmanaged<IPropertyPageSite*, uint*, int>)(lpVtbl[4]))((IPropertyPageSite*)Unsafe.AsPointer(ref this), pLocaleID);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPageContainer(IUnknown** ppUnk)
        {
            return ((delegate* unmanaged<IPropertyPageSite*, IUnknown**, int>)(lpVtbl[5]))((IPropertyPageSite*)Unsafe.AsPointer(ref this), ppUnk);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int TranslateAccelerator(MSG* pMsg)
        {
            return ((delegate* unmanaged<IPropertyPageSite*, MSG*, int>)(lpVtbl[6]))((IPropertyPageSite*)Unsafe.AsPointer(ref this), pMsg);
        }
    }
}
