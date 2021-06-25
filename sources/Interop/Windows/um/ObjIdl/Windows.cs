// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/objidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        public static readonly Guid IID_IMallocSpy = new Guid(0x0000001D, 0x0000, 0x0000, 0xC0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x46);

        public static readonly Guid IID_IBindCtx = new Guid(0x0000000E, 0x0000, 0x0000, 0xC0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x46);

        public static readonly Guid IID_IEnumMoniker = new Guid(0x00000102, 0x0000, 0x0000, 0xC0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x46);

        public static readonly Guid IID_IRunnableObject = new Guid(0x00000126, 0x0000, 0x0000, 0xC0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x46);

        public static readonly Guid IID_IRunningObjectTable = new Guid(0x00000010, 0x0000, 0x0000, 0xC0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x46);

        public static readonly Guid IID_IPersist = new Guid(0x0000010C, 0x0000, 0x0000, 0xC0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x46);

        public static readonly Guid IID_IPersistStream = new Guid(0x00000109, 0x0000, 0x0000, 0xC0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x46);

        public static readonly Guid IID_IMoniker = new Guid(0x0000000F, 0x0000, 0x0000, 0xC0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x46);

        public static readonly Guid IID_IROTData = new Guid(0xF29F6BC0, 0x5021, 0x11CE, 0xAA, 0x15, 0x00, 0x00, 0x69, 0x01, 0x29, 0x3F);

        public static readonly Guid IID_IEnumSTATSTG = new Guid(0x0000000D, 0x0000, 0x0000, 0xC0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x46);

        public static readonly Guid IID_IStorage = new Guid(0x0000000B, 0x0000, 0x0000, 0xC0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x46);

        public static readonly Guid IID_IPersistFile = new Guid(0x0000010B, 0x0000, 0x0000, 0xC0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x46);

        public static readonly Guid IID_IPersistStorage = new Guid(0x0000010A, 0x0000, 0x0000, 0xC0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x46);

        public static readonly Guid IID_ILockBytes = new Guid(0x0000000A, 0x0000, 0x0000, 0xC0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x46);

        public static readonly Guid IID_IEnumFORMATETC = new Guid(0x00000103, 0x0000, 0x0000, 0xC0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x46);

        public static readonly Guid IID_IEnumSTATDATA = new Guid(0x00000105, 0x0000, 0x0000, 0xC0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x46);

        public static readonly Guid IID_IRootStorage = new Guid(0x00000012, 0x0000, 0x0000, 0xC0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x46);

        public static readonly Guid IID_IAdviseSink = new Guid(0x0000010F, 0x0000, 0x0000, 0xC0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x46);

        public static readonly Guid IID_AsyncIAdviseSink = new Guid(0x00000150, 0x0000, 0x0000, 0xC0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x46);

        public static readonly Guid IID_IAdviseSink2 = new Guid(0x00000125, 0x0000, 0x0000, 0xC0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x46);

        public static readonly Guid IID_AsyncIAdviseSink2 = new Guid(0x00000151, 0x0000, 0x0000, 0xC0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x46);

        public static readonly Guid IID_IDataObject = new Guid(0x0000010E, 0x0000, 0x0000, 0xC0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x46);

        public static readonly Guid IID_IDataAdviseHolder = new Guid(0x00000110, 0x0000, 0x0000, 0xC0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x46);

        public static readonly Guid IID_IMessageFilter = new Guid(0x00000016, 0x0000, 0x0000, 0xC0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x46);

        public static readonly Guid IID_IClassActivator = new Guid(0x00000140, 0x0000, 0x0000, 0xC0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x46);

        public static readonly Guid IID_IFillLockBytes = new Guid(0x99CAF010, 0x415E, 0x11CF, 0x88, 0x14, 0x00, 0xAA, 0x00, 0xB5, 0x69, 0xF5);

        public static readonly Guid IID_IProgressNotify = new Guid(0xA9D758A0, 0x4617, 0x11CF, 0x95, 0xFC, 0x00, 0xAA, 0x00, 0x68, 0x0D, 0xB4);

        public static readonly Guid IID_ILayoutStorage = new Guid(0x0E6D4D90, 0x6738, 0x11CF, 0x96, 0x08, 0x00, 0xAA, 0x00, 0x68, 0x0D, 0xB4);

        public static readonly Guid IID_IBlockingLock = new Guid(0x30F3D47A, 0x6447, 0x11D1, 0x8E, 0x3C, 0x00, 0xC0, 0x4F, 0xB9, 0x38, 0x6D);

        public static readonly Guid IID_ITimeAndNoticeControl = new Guid(0xBC0BF6AE, 0x8878, 0x11D1, 0x83, 0xE9, 0x00, 0xC0, 0x4F, 0xC2, 0xC6, 0xD4);

        public static readonly Guid IID_IOplockStorage = new Guid(0x8D19C834, 0x8879, 0x11D1, 0x83, 0xE9, 0x00, 0xC0, 0x4F, 0xC2, 0xC6, 0xD4);

        public static readonly Guid IID_IDirectWriterLock = new Guid(0x0E6D4D92, 0x6738, 0x11CF, 0x96, 0x08, 0x00, 0xAA, 0x00, 0x68, 0x0D, 0xB4);

        public static readonly Guid IID_IUrlMon = new Guid(0x00000026, 0x0000, 0x0000, 0xC0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x46);

        public static readonly Guid IID_IForegroundTransfer = new Guid(0x00000145, 0x0000, 0x0000, 0xC0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x46);

        public static readonly Guid IID_IThumbnailExtractor = new Guid(0x969DC708, 0x5C76, 0x11D1, 0x8D, 0x86, 0x00, 0x00, 0xF8, 0x04, 0xB0, 0x57);

        public static readonly Guid IID_IDummyHICONIncluder = new Guid(0x947990DE, 0xCC28, 0x11D2, 0xA0, 0xF7, 0x00, 0x80, 0x5F, 0x85, 0x8F, 0xB1);

        public static readonly Guid IID_IProcessLock = new Guid(0x000001D5, 0x0000, 0x0000, 0xC0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x46);

        public static readonly Guid IID_ISurrogateService = new Guid(0x000001D4, 0x0000, 0x0000, 0xC0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x46);

        public static readonly Guid IID_IInitializeSpy = new Guid(0x00000034, 0x0000, 0x0000, 0xC0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x46);

        public static readonly Guid IID_IApartmentShutdown = new Guid(0xA2F05A09, 0x27A2, 0x42B5, 0xBC, 0x0E, 0xAC, 0x16, 0x3E, 0xF4, 0x9D, 0x9B);
    }
}
