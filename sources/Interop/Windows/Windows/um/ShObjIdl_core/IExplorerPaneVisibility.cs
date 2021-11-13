// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [Guid("E07010EC-BC17-44C0-97B0-46C7C95B9EDC")]
    [NativeTypeName("struct IExplorerPaneVisibility : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IExplorerPaneVisibility : IExplorerPaneVisibility.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IExplorerPaneVisibility*, Guid*, void**, int>)(lpVtbl[0]))((IExplorerPaneVisibility*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IExplorerPaneVisibility*, uint>)(lpVtbl[1]))((IExplorerPaneVisibility*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IExplorerPaneVisibility*, uint>)(lpVtbl[2]))((IExplorerPaneVisibility*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetPaneState([NativeTypeName("const EXPLORERPANE &")] Guid* ep, [NativeTypeName("EXPLORERPANESTATE *")] uint* peps)
        {
            return ((delegate* unmanaged<IExplorerPaneVisibility*, Guid*, uint*, int>)(lpVtbl[3]))((IExplorerPaneVisibility*)Unsafe.AsPointer(ref this), ep, peps);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT GetPaneState([NativeTypeName("const EXPLORERPANE &")] Guid* ep, [NativeTypeName("EXPLORERPANESTATE *")] uint* peps);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IExplorerPaneVisibility*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IExplorerPaneVisibility*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IExplorerPaneVisibility*, uint> Release;

            [NativeTypeName("HRESULT (const EXPLORERPANE &, EXPLORERPANESTATE *) __attribute__((stdcall))")]
            public delegate* unmanaged<IExplorerPaneVisibility*, Guid*, uint*, int> GetPaneState;
        }
    }
}
