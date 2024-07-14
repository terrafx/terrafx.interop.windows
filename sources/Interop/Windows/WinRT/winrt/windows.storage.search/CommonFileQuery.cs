// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.search.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='CommonFileQuery.xml' path='doc/member[@name="CommonFileQuery"]/*' />
public enum CommonFileQuery
{
    /// <include file='CommonFileQuery.xml' path='doc/member[@name="CommonFileQuery.CommonFileQuery_DefaultQuery"]/*' />
    CommonFileQuery_DefaultQuery = 0,

    /// <include file='CommonFileQuery.xml' path='doc/member[@name="CommonFileQuery.CommonFileQuery_OrderByName"]/*' />
    CommonFileQuery_OrderByName = 1,

    /// <include file='CommonFileQuery.xml' path='doc/member[@name="CommonFileQuery.CommonFileQuery_OrderByTitle"]/*' />
    CommonFileQuery_OrderByTitle = 2,

    /// <include file='CommonFileQuery.xml' path='doc/member[@name="CommonFileQuery.CommonFileQuery_OrderByMusicProperties"]/*' />
    CommonFileQuery_OrderByMusicProperties = 3,

    /// <include file='CommonFileQuery.xml' path='doc/member[@name="CommonFileQuery.CommonFileQuery_OrderBySearchRank"]/*' />
    CommonFileQuery_OrderBySearchRank = 4,

    /// <include file='CommonFileQuery.xml' path='doc/member[@name="CommonFileQuery.CommonFileQuery_OrderByDate"]/*' />
    CommonFileQuery_OrderByDate = 5,
}
