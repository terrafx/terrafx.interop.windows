// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3051083A-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct IScriptEventHandler : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IScriptEventHandler
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IScriptEventHandler*, Guid*, void**, int>)(lpVtbl[0]))((IScriptEventHandler*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IScriptEventHandler*, uint>)(lpVtbl[1]))((IScriptEventHandler*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IScriptEventHandler*, uint>)(lpVtbl[2]))((IScriptEventHandler*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int FunctionName([NativeTypeName("BSTR *")] ushort** pbstrFunctionName)
        {
            return ((delegate* unmanaged<IScriptEventHandler*, ushort**, int>)(lpVtbl[3]))((IScriptEventHandler*)Unsafe.AsPointer(ref this), pbstrFunctionName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int DebugDocumentContext(IUnknown** ppDebugDocumentContext)
        {
            return ((delegate* unmanaged<IScriptEventHandler*, IUnknown**, int>)(lpVtbl[4]))((IScriptEventHandler*)Unsafe.AsPointer(ref this), ppDebugDocumentContext);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int EventHandlerDispatch(IDispatch** ppDispHandler)
        {
            return ((delegate* unmanaged<IScriptEventHandler*, IDispatch**, int>)(lpVtbl[5]))((IScriptEventHandler*)Unsafe.AsPointer(ref this), ppDispHandler);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int UsesCapture([NativeTypeName("BOOL *")] int* pfUsesCapture)
        {
            return ((delegate* unmanaged<IScriptEventHandler*, int*, int>)(lpVtbl[6]))((IScriptEventHandler*)Unsafe.AsPointer(ref this), pfUsesCapture);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int Cookie([NativeTypeName("ULONGLONG *")] ulong* pullCookie)
        {
            return ((delegate* unmanaged<IScriptEventHandler*, ulong*, int>)(lpVtbl[7]))((IScriptEventHandler*)Unsafe.AsPointer(ref this), pullCookie);
        }
    }
}
