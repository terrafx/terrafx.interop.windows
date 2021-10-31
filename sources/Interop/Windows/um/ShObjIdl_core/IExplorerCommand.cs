// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("A08CE4D0-FA25-44AB-B57C-C7B1C323E0B9")]
    [NativeTypeName("struct IExplorerCommand : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IExplorerCommand
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IExplorerCommand*, Guid*, void**, int>)(lpVtbl[0]))((IExplorerCommand*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IExplorerCommand*, uint>)(lpVtbl[1]))((IExplorerCommand*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IExplorerCommand*, uint>)(lpVtbl[2]))((IExplorerCommand*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetTitle(IShellItemArray* psiItemArray, [NativeTypeName("LPWSTR *")] ushort** ppszName)
        {
            return ((delegate* unmanaged<IExplorerCommand*, IShellItemArray*, ushort**, int>)(lpVtbl[3]))((IExplorerCommand*)Unsafe.AsPointer(ref this), psiItemArray, ppszName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetIcon(IShellItemArray* psiItemArray, [NativeTypeName("LPWSTR *")] ushort** ppszIcon)
        {
            return ((delegate* unmanaged<IExplorerCommand*, IShellItemArray*, ushort**, int>)(lpVtbl[4]))((IExplorerCommand*)Unsafe.AsPointer(ref this), psiItemArray, ppszIcon);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetToolTip(IShellItemArray* psiItemArray, [NativeTypeName("LPWSTR *")] ushort** ppszInfotip)
        {
            return ((delegate* unmanaged<IExplorerCommand*, IShellItemArray*, ushort**, int>)(lpVtbl[5]))((IExplorerCommand*)Unsafe.AsPointer(ref this), psiItemArray, ppszInfotip);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int GetCanonicalName([NativeTypeName("GUID *")] Guid* pguidCommandName)
        {
            return ((delegate* unmanaged<IExplorerCommand*, Guid*, int>)(lpVtbl[6]))((IExplorerCommand*)Unsafe.AsPointer(ref this), pguidCommandName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int GetState(IShellItemArray* psiItemArray, BOOL fOkToBeSlow, [NativeTypeName("EXPCMDSTATE *")] uint* pCmdState)
        {
            return ((delegate* unmanaged<IExplorerCommand*, IShellItemArray*, BOOL, uint*, int>)(lpVtbl[7]))((IExplorerCommand*)Unsafe.AsPointer(ref this), psiItemArray, fOkToBeSlow, pCmdState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke(IShellItemArray* psiItemArray, IBindCtx* pbc)
        {
            return ((delegate* unmanaged<IExplorerCommand*, IShellItemArray*, IBindCtx*, int>)(lpVtbl[8]))((IExplorerCommand*)Unsafe.AsPointer(ref this), psiItemArray, pbc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int GetFlags([NativeTypeName("EXPCMDFLAGS *")] uint* pFlags)
        {
            return ((delegate* unmanaged<IExplorerCommand*, uint*, int>)(lpVtbl[9]))((IExplorerCommand*)Unsafe.AsPointer(ref this), pFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int EnumSubCommands(IEnumExplorerCommand** ppEnum)
        {
            return ((delegate* unmanaged<IExplorerCommand*, IEnumExplorerCommand**, int>)(lpVtbl[10]))((IExplorerCommand*)Unsafe.AsPointer(ref this), ppEnum);
        }
    }
}
