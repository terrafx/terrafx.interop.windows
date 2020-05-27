// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OCIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct QACONTAINER
    {
        [NativeTypeName("ULONG")]
        public uint cbSize;

        [NativeTypeName("IOleClientSite *")]
        public IOleClientSite* pClientSite;

        [NativeTypeName("IAdviseSinkEx *")]
        public IAdviseSinkEx* pAdviseSink;

        [NativeTypeName("IPropertyNotifySink *")]
        public IPropertyNotifySink* pPropertyNotifySink;

        [NativeTypeName("IUnknown *")]
        public IUnknown* pUnkEventSink;

        [NativeTypeName("DWORD")]
        public uint dwAmbientFlags;

        [NativeTypeName("OLE_COLOR")]
        public uint colorFore;

        [NativeTypeName("OLE_COLOR")]
        public uint colorBack;

        [NativeTypeName("IFont *")]
        public IFont* pFont;

        [NativeTypeName("IOleUndoManager *")]
        public IOleUndoManager* pUndoMgr;

        [NativeTypeName("DWORD")]
        public uint dwAppearance;

        [NativeTypeName("LONG")]
        public int lcid;

        [NativeTypeName("HPALETTE")]
        public IntPtr hpal;

        [NativeTypeName("IBindHost *")]
        public IBindHost* pBindHost;

        [NativeTypeName("IOleControlSite *")]
        public IOleControlSite* pOleControlSite;

        [NativeTypeName("IServiceProvider *")]
        public IServiceProvider* pServiceProvider;
    }
}
