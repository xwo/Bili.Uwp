﻿// Copyright (c) Richasy. All rights reserved.

using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Reactive;
using Bili.Lib.Interfaces;
using Bili.Models.Data.Community;
using Bili.Models.Data.Live;
using Bili.Toolkit.Interfaces;
using Bili.ViewModels.Interfaces.Core;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;

namespace Bili.ViewModels.Uwp.Live
{
    /// <summary>
    /// 直播分区详情页面视图模型.
    /// </summary>
    public sealed partial class LivePartitionDetailPageViewModel
    {
        private readonly ILiveProvider _liveProvider;
        private readonly IResourceToolkit _resourceToolkit;
        private readonly INavigationViewModel _navigationViewModel;
        private readonly Dictionary<LiveTag, IEnumerable<LiveInformation>> _caches;

        private int _totalCount;

        /// <inheritdoc/>
        public ObservableCollection<LiveTag> Tags { get; }

        /// <inheritdoc/>
        public ReactiveCommand<LiveTag, Unit> SelectTagCommand { get; }

        /// <inheritdoc/>
        public ReactiveCommand<Unit, Unit> SeeAllPartitionsCommand { get; }

        /// <inheritdoc/>
        [Reactive]
        public Partition OriginPartition { get; private set; }

        /// <inheritdoc/>
        [Reactive]
        public LiveTag CurrentTag { get; set; }

        /// <inheritdoc/>
        [Reactive]
        public bool IsEmpty { get; set; }
    }
}
