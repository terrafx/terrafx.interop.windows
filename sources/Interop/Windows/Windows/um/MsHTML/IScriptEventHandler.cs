// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[Guid("3051083A-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IScriptEventHandler : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IScriptEventHandler : IScriptEventHandler.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
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
    public HRESULT FunctionName([NativeTypeName("BSTR *")] ushort** pbstrFunctionName)
    {
        return ((delegate* unmanaged<IScriptEventHandler*, ushort**, int>)(lpVtbl[3]))((IScriptEventHandler*)Unsafe.AsPointer(ref this), pbstrFunctionName);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT DebugDocumentContext(IUnknown** ppDebugDocumentContext)
    {
        return ((delegate* unmanaged<IScriptEventHandler*, IUnknown**, int>)(lpVtbl[4]))((IScriptEventHandler*)Unsafe.AsPointer(ref this), ppDebugDocumentContext);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT EventHandlerDispatch(IDispatch** ppDispHandler)
    {
        return ((delegate* unmanaged<IScriptEventHandler*, IDispatch**, int>)(lpVtbl[5]))((IScriptEventHandler*)Unsafe.AsPointer(ref this), ppDispHandler);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT UsesCapture(BOOL* pfUsesCapture)
    {
        return ((delegate* unmanaged<IScriptEventHandler*, BOOL*, int>)(lpVtbl[6]))((IScriptEventHandler*)Unsafe.AsPointer(ref this), pfUsesCapture);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT Cookie([NativeTypeName("ULONGLONG *")] ulong* pullCookie)
    {
        return ((delegate* unmanaged<IScriptEventHandler*, ulong*, int>)(lpVtbl[7]))((IScriptEventHandler*)Unsafe.AsPointer(ref this), pullCookie);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT FunctionName([NativeTypeName("BSTR *")] ushort** pbstrFunctionName);

        [VtblIndex(4)]
        HRESULT DebugDocumentContext(IUnknown** ppDebugDocumentContext);

        [VtblIndex(5)]
        HRESULT EventHandlerDispatch(IDispatch** ppDispHandler);

        [VtblIndex(6)]
        HRESULT UsesCapture(BOOL* pfUsesCapture);

        [VtblIndex(7)]
        HRESULT Cookie([NativeTypeName("ULONGLONG *")] ulong* pullCookie);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<IScriptEventHandler*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IScriptEventHandler*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IScriptEventHandler*, uint> Release;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<IScriptEventHandler*, ushort**, int> FunctionName;

        [NativeTypeName("HRESULT (IUnknown **) __attribute__((stdcall))")]
        public delegate* unmanaged<IScriptEventHandler*, IUnknown**, int> DebugDocumentContext;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<IScriptEventHandler*, IDispatch**, int> EventHandlerDispatch;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<IScriptEventHandler*, BOOL*, int> UsesCapture;

        [NativeTypeName("HRESULT (ULONGLONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<IScriptEventHandler*, ulong*, int> Cookie;
    }
}
