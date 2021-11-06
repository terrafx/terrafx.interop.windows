// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("71F312DE-43ED-4190-8477-E9536B82350B")]
    [NativeTypeName("struct INameSpaceTreeAccessible : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct INameSpaceTreeAccessible : INameSpaceTreeAccessible.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<INameSpaceTreeAccessible*, Guid*, void**, int>)(lpVtbl[0]))((INameSpaceTreeAccessible*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<INameSpaceTreeAccessible*, uint>)(lpVtbl[1]))((INameSpaceTreeAccessible*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<INameSpaceTreeAccessible*, uint>)(lpVtbl[2]))((INameSpaceTreeAccessible*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT OnGetDefaultAccessibilityAction(IShellItem* psi, [NativeTypeName("BSTR *")] ushort** pbstrDefaultAction)
        {
            return ((delegate* unmanaged<INameSpaceTreeAccessible*, IShellItem*, ushort**, int>)(lpVtbl[3]))((INameSpaceTreeAccessible*)Unsafe.AsPointer(ref this), psi, pbstrDefaultAction);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT OnDoDefaultAccessibilityAction(IShellItem* psi)
        {
            return ((delegate* unmanaged<INameSpaceTreeAccessible*, IShellItem*, int>)(lpVtbl[4]))((INameSpaceTreeAccessible*)Unsafe.AsPointer(ref this), psi);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT OnGetAccessibilityRole(IShellItem* psi, VARIANT* pvarRole)
        {
            return ((delegate* unmanaged<INameSpaceTreeAccessible*, IShellItem*, VARIANT*, int>)(lpVtbl[5]))((INameSpaceTreeAccessible*)Unsafe.AsPointer(ref this), psi, pvarRole);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT OnGetDefaultAccessibilityAction(IShellItem* psi, [NativeTypeName("BSTR *")] ushort** pbstrDefaultAction);

            [VtblIndex(4)]
            HRESULT OnDoDefaultAccessibilityAction(IShellItem* psi);

            [VtblIndex(5)]
            HRESULT OnGetAccessibilityRole(IShellItem* psi, VARIANT* pvarRole);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<INameSpaceTreeAccessible*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<INameSpaceTreeAccessible*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<INameSpaceTreeAccessible*, uint> Release;

            [NativeTypeName("HRESULT (IShellItem *, BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<INameSpaceTreeAccessible*, IShellItem*, ushort**, int> OnGetDefaultAccessibilityAction;

            [NativeTypeName("HRESULT (IShellItem *) __attribute__((stdcall))")]
            public delegate* unmanaged<INameSpaceTreeAccessible*, IShellItem*, int> OnDoDefaultAccessibilityAction;

            [NativeTypeName("HRESULT (IShellItem *, VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged<INameSpaceTreeAccessible*, IShellItem*, VARIANT*, int> OnGetAccessibilityRole;
        }
    }
}
